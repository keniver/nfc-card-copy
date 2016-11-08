namespace NFCCardCopy
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.readUID = new System.Windows.Forms.Button();
            this.writeUID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logbox = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NFC Card UID";
            // 
            // uid
            // 
            this.uid.Enabled = false;
            this.uid.Location = new System.Drawing.Point(124, 17);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(108, 22);
            this.uid.TabIndex = 1;
            // 
            // readUID
            // 
            this.readUID.Enabled = false;
            this.readUID.Location = new System.Drawing.Point(238, 16);
            this.readUID.Name = "readUID";
            this.readUID.Size = new System.Drawing.Size(149, 23);
            this.readUID.TabIndex = 2;
            this.readUID.Text = "Read From NFC Card";
            this.readUID.UseVisualStyleBackColor = true;
            this.readUID.Click += new System.EventHandler(this.readUID_Click);
            // 
            // writeUID
            // 
            this.writeUID.Enabled = false;
            this.writeUID.Location = new System.Drawing.Point(12, 45);
            this.writeUID.Name = "writeUID";
            this.writeUID.Size = new System.Drawing.Size(375, 42);
            this.writeUID.TabIndex = 3;
            this.writeUID.Text = "Write NFC Card UID";
            this.writeUID.UseVisualStyleBackColor = true;
            this.writeUID.Click += new System.EventHandler(this.writeUID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log:";
            // 
            // logbox
            // 
            this.logbox.HideSelection = false;
            this.logbox.Location = new System.Drawing.Point(12, 122);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logbox.Size = new System.Drawing.Size(375, 125);
            this.logbox.TabIndex = 5;
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(362, 258);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(34, 12);
            this.about.TabIndex = 6;
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(51, 258);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(23, 12);
            this.status.TabIndex = 8;
            this.status.Text = "Idle";
            // 
            // searchTimer
            // 
            this.searchTimer.Interval = 3000;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 274);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.about);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.writeUID);
            this.Controls.Add(this.readUID);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "NFC Card Copy";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Button readUID;
        private System.Windows.Forms.Button writeUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer searchTimer;
    }
}

