using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ApplicationServer.Caching;
using System.Threading;

namespace Contention
{
    public partial class ContentionDemo : Form
    {
        DataCacheFactory myCacheFactory;
        DataCacheFactory myCacheFactory_LC;

        static readonly string LCENABLED = "ENABLED";

        DataCache myDefaultCache;
        DataCacheItemVersion itemVersion = null,
            myVersionBeforeChange = null,
            myVersionAfterChange = null,
            myVersionChangedOnceMore = null;
        DataCacheLockHandle lockHandle;

        string myKey = "KeyLockDemo";
        string RetrievedStrFromCache = string.Empty;
        string myObjectForCaching = "This is my Object";

        static int TimeLockedObj = 5;

        public ContentionDemo()
        {
            InitializeComponent();
        }

        // Configure Cache Client When loading form 
        private void ContentionDemo_Load(object sender, EventArgs e)
        {
            //Array for the Cache Host
            List<DataCacheServerEndpoint> servers = new List<DataCacheServerEndpoint>(1);

            //Cache Host Details 
            servers.Add(new DataCacheServerEndpoint("localhost", 22233));

            //Create cache configuration with disabled local cache (default) on the just added server
            DataCacheFactoryConfiguration configuration = new DataCacheFactoryConfiguration();
            configuration.Servers = servers;
            configuration.LocalCacheProperties = new DataCacheLocalCacheProperties();

            //Create the Non local cache cacheFactory constructor
            myCacheFactory = new DataCacheFactory(configuration);

            //Create the local cache cacheFactory constructor, kept for 5 min.
            configuration.LocalCacheProperties = new DataCacheLocalCacheProperties(1000, new TimeSpan(0, 5, 0),
                                                            DataCacheLocalCacheInvalidationPolicy.TimeoutBased);
            myCacheFactory_LC = new DataCacheFactory(configuration);

            //Get tje reference cache "default"
            myDefaultCache = myCacheFactory.GetDefaultCache();
            //Minimize exception messages
            DataCacheClientLogManager.ChangeLogLevel(System.Diagnostics.TraceLevel.Off);
        }

        private void AddObjToCache_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                // Initialize the object with a Add
                if ((itemVersion = myDefaultCache.Add(myKey, myObjectForCaching)) != null)
                {
                    tStatus.Text = ">>Add-Object Added to Cache [key=" + myKey + "]";
                }
                else
                {
                    tStatus.Text = "FAIL >> Add-Object did not add to cache [key" + myKey + "]";
                }

            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Add hit an exception, Object is already present. [key=" + myKey + "] " + "\n\n"
                             + ex.ToString();
            }
        }

        private void Put_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            string newObject = "MOD 1 - " + myObjectForCaching;
            try
            {
                if ((myVersionAfterChange = (DataCacheItemVersion)myDefaultCache.Put(myKey, newObject)) != null)
                {
                    tStatus.Text = ">> Put passes even if Object is locked and it gets unlocked (new Reference collected). [key=" + myKey + ", Object=" + newObject + "]";
                }
                    
                else
                {
                    tStatus.Text = "FAIL >> Object did not change. [key=" + myKey + "]";
                }
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Put hit an exception. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = LocalCache_On_Off.SelectedIndex;
            string option = null;

            if (selectedIndex != -1)
                option = LocalCache_On_Off.Items[selectedIndex].ToString();

            if (option.ToUpper().Equals(LCENABLED))
                myDefaultCache = myCacheFactory_LC.GetDefaultCache();
            else
                myDefaultCache = myCacheFactory.GetDefaultCache();

        }

        private void Get_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                //Compare if the retrieved object is the same as added object (both are strings)
                if ((RetrievedStrFromCache = (string)myDefaultCache.Get(myKey, out myVersionBeforeChange)) != null)
                {
                    tStatus.Text = ">> Get Object and reference retrived from cache. [key=" + myKey + ", Object=" + RetrievedStrFromCache + "]";
                }
                else
                {
                    tStatus.Text = "FAIL >> Object was not retrived from cache. [key=" + myKey + "]";
                }
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Get hit an exception. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
        }

        private void GetAndLock_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                //Lock Object
                if ((myDefaultCache.GetAndLock(myKey, new TimeSpan(0, 0, TimeLockedObj), out lockHandle)) != null)
                {
                    tStatus.Text = ">> GetAndLock Object [key=" + myKey + "]";
                }
                else
                {
                    tStatus.Text = "FAIL >> GetAndLock Object not obtained [key=" + myKey + "]";
                }
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Key does not exist or is already locked. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
        }

        private void PutAndUnLock_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                // Try the above PutAndUnlock                 
                if ((myVersionChangedOnceMore = (DataCacheItemVersion)myDefaultCache.PutAndUnlock(myKey,
                                                    myObjectForCaching, lockHandle)) != null)
                {
                    tStatus.Text = "PASS >> PutAndUnlock updated and unlocked object. [key=" + myKey + "]";
                }
                else
                    tStatus.Text = "FAIL >> PutAndUnlock could not updated and unlocked. [key=" + myKey + "]";
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Object is already unlocked. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
        }
                
        private void Unlock_Click(object sender, EventArgs e)
        {
            DataCacheLockHandle wronglockHandle = null;

            tStatus.Text = string.Empty;
            try
            {
                myDefaultCache.Add("Other Key", "Other object");
                
            }
            catch (DataCacheException ex)
            {
                //Ignored for the purppose of the exercise
            }

            try
            {
                myDefaultCache.GetAndLock("Other Key", new TimeSpan(0, 0, TimeLockedObj), out wronglockHandle);
            }
            catch (DataCacheException ex)
            {
                //Ignored for the purppose of the exercise
            }

            try
            {
                myDefaultCache.Unlock(myKey,wronglockHandle);
                tStatus.Text = ">> Object unlocked. [key=" + myKey + "]";
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Could not Unlock, bad handle. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
            catch (ArgumentNullException ex)
            {
                tStatus.Text = "Exception >> too many tries, passed handle is Null. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
        }

        private void GetIfNewer_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                if ((RetrievedStrFromCache = (string)myDefaultCache.GetIfNewer(myKey, ref myVersionBeforeChange)) != null)
                {
                    tStatus.Text = ">> GetIfNewer found object with changed reference. [key=" + myKey + ", Object=" + RetrievedStrFromCache + "]";
                }
                else
                {
                    tStatus.Text = ">> GetIfNewer found no object with newer reference. [key=" + myKey + ", Object= NULL object returned]";
                }
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> GetIfNewer exception. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
            catch (ArgumentNullException ex)
            {
                tStatus.Text = "Exception >> Null reference, Get(obj) not yet executed against object. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                if (myDefaultCache.Remove(myKey))
                {
                    tStatus.Text = ">> Object removed [key=" + myKey + "]";
                }
                else
                {
                    tStatus.Text = "FAIL >> Object with the given Key not found - [key" + myKey + "]";
                }

            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Remove hit an exception. [key=" + myKey + "] " + "\n\n"
                             + ex.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tStatus.Text = string.Empty;
            try
            {
                myDefaultCache.Unlock(myKey, lockHandle);
                tStatus.Text = ">> Object unlocked. [key=" + myKey + "]";
            }
            catch (DataCacheException ex)
            {
                tStatus.Text = "Exception >> Object already unlocked or does not exist. [key=" + myKey + "] - Cache Generated Exception:" + "\n"
                             + ex.ToString();
            }
        }
    }
}
