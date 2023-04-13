namespace WakeOnApp
{
    partial class WakeOnApp
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dfStatus = new System.Windows.Forms.TextBox();
            this.awakeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(32, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(224, 28);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Click the ON button to keep your \r\nmachine awake.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnOn.Location = new System.Drawing.Point(52, 84);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 23);
            this.btnOn.TabIndex = 1;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOn_MouseClick);
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.Red;
            this.btnOff.Location = new System.Drawing.Point(154, 84);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOff_MouseClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(69, 57);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 14);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // dfStatus
            // 
            this.dfStatus.Cursor = System.Windows.Forms.Cursors.No;
            this.dfStatus.Enabled = false;
            this.dfStatus.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfStatus.Location = new System.Drawing.Point(126, 54);
            this.dfStatus.Name = "dfStatus";
            this.dfStatus.ReadOnly = true;
            this.dfStatus.Size = new System.Drawing.Size(103, 22);
            this.dfStatus.TabIndex = 4;
            // 
            // WakeOnApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 119);
            this.Controls.Add(this.dfStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.lblInfo);
            this.Name = "WakeOnApp";
            this.Text = "Wake On Monitor";
            this.Load += new System.EventHandler(this.WakeOnApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox dfStatus;
        private System.Windows.Forms.Timer awakeTimer;
    }
}

