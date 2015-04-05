namespace Contention
{
    partial class ContentionDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddObjToCache = new System.Windows.Forms.Button();
            this.GetAndLock = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.GetIfNewer = new System.Windows.Forms.Button();
            this.Put = new System.Windows.Forms.Button();
            this.PutAndUnLock = new System.Windows.Forms.Button();
            this.Unlock_Bad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalCache_On_Off = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.Unlock_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tStatus
            // 
            this.tStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStatus.Location = new System.Drawing.Point(2, 405);
            this.tStatus.Multiline = true;
            this.tStatus.Name = "tStatus";
            this.tStatus.ReadOnly = true;
            this.tStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tStatus.Size = new System.Drawing.Size(476, 73);
            this.tStatus.TabIndex = 0;
            this.tStatus.Text = "To start, add an object";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // AddObjToCache
            // 
            this.AddObjToCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddObjToCache.Location = new System.Drawing.Point(92, 27);
            this.AddObjToCache.Name = "AddObjToCache";
            this.AddObjToCache.Size = new System.Drawing.Size(139, 52);
            this.AddObjToCache.TabIndex = 2;
            this.AddObjToCache.Text = "Add\r\n(insert)";
            this.AddObjToCache.UseVisualStyleBackColor = true;
            this.AddObjToCache.Click += new System.EventHandler(this.AddObjToCache_Click);
            // 
            // GetAndLock
            // 
            this.GetAndLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetAndLock.Location = new System.Drawing.Point(92, 259);
            this.GetAndLock.Name = "GetAndLock";
            this.GetAndLock.Size = new System.Drawing.Size(139, 52);
            this.GetAndLock.TabIndex = 3;
            this.GetAndLock.Text = "GetAndLock\r\n(pessimistic)";
            this.GetAndLock.UseVisualStyleBackColor = true;
            this.GetAndLock.Click += new System.EventHandler(this.GetAndLock_Click);
            // 
            // Get
            // 
            this.Get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get.Location = new System.Drawing.Point(92, 98);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(139, 57);
            this.Get.TabIndex = 4;
            this.Get.Text = "Get\r\n(optimistic)";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // GetIfNewer
            // 
            this.GetIfNewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetIfNewer.Location = new System.Drawing.Point(92, 180);
            this.GetIfNewer.Name = "GetIfNewer";
            this.GetIfNewer.Size = new System.Drawing.Size(139, 57);
            this.GetIfNewer.TabIndex = 5;
            this.GetIfNewer.Text = "GetIfNewer\r\n(ref from Get)";
            this.GetIfNewer.UseVisualStyleBackColor = true;
            this.GetIfNewer.Click += new System.EventHandler(this.GetIfNewer_Click);
            // 
            // Put
            // 
            this.Put.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Put.Location = new System.Drawing.Point(264, 98);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(139, 57);
            this.Put.TabIndex = 6;
            this.Put.Text = "Put\r\n(update)";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Put_Click);
            // 
            // PutAndUnLock
            // 
            this.PutAndUnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PutAndUnLock.Location = new System.Drawing.Point(264, 259);
            this.PutAndUnLock.Name = "PutAndUnLock";
            this.PutAndUnLock.Size = new System.Drawing.Size(139, 57);
            this.PutAndUnLock.TabIndex = 7;
            this.PutAndUnLock.Text = "PutAndUnLock\r\n(right handle)";
            this.PutAndUnLock.UseVisualStyleBackColor = true;
            this.PutAndUnLock.Click += new System.EventHandler(this.PutAndUnLock_Click);
            // 
            // Unlock_Bad
            // 
            this.Unlock_Bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unlock_Bad.Location = new System.Drawing.Point(264, 180);
            this.Unlock_Bad.Name = "Unlock_Bad";
            this.Unlock_Bad.Size = new System.Drawing.Size(66, 57);
            this.Unlock_Bad.TabIndex = 8;
            this.Unlock_Bad.Text = "Unlock\r\n(bad)";
            this.Unlock_Bad.UseVisualStyleBackColor = true;
            this.Unlock_Bad.Click += new System.EventHandler(this.Unlock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Local cache:";
            // 
            // LocalCache_On_Off
            // 
            this.LocalCache_On_Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalCache_On_Off.FormattingEnabled = true;
            this.LocalCache_On_Off.Items.AddRange(new object[] {
            "ENABLED",
            "DISABLED"});
            this.LocalCache_On_Off.Location = new System.Drawing.Point(92, 342);
            this.LocalCache_On_Off.Name = "LocalCache_On_Off";
            this.LocalCache_On_Off.Size = new System.Drawing.Size(139, 26);
            this.LocalCache_On_Off.TabIndex = 11;
            this.LocalCache_On_Off.Text = "DISABLED";
            this.LocalCache_On_Off.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Two distinct DataCacheFactories";
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(264, 27);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(139, 52);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Unlock_OK
            // 
            this.Unlock_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unlock_OK.Location = new System.Drawing.Point(336, 180);
            this.Unlock_OK.Name = "Unlock_OK";
            this.Unlock_OK.Size = new System.Drawing.Size(67, 57);
            this.Unlock_OK.TabIndex = 14;
            this.Unlock_OK.Text = "Unlock\r\n(ok)";
            this.Unlock_OK.UseVisualStyleBackColor = true;
            this.Unlock_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContentionDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 483);
            this.Controls.Add(this.Unlock_OK);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalCache_On_Off);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Unlock_Bad);
            this.Controls.Add(this.PutAndUnLock);
            this.Controls.Add(this.Put);
            this.Controls.Add(this.GetIfNewer);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.GetAndLock);
            this.Controls.Add(this.AddObjToCache);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContentionDemo";
            this.ShowIcon = false;
            this.Text = "MS App Fabric Cache - API Demo";
            this.Load += new System.EventHandler(this.ContentionDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddObjToCache;
        private System.Windows.Forms.Button GetAndLock;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button GetIfNewer;
        private System.Windows.Forms.Button Put;
        private System.Windows.Forms.Button PutAndUnLock;
        private System.Windows.Forms.Button Unlock_Bad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LocalCache_On_Off;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Unlock_OK;
    }
}

