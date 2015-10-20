namespace RuffCoJetReservation
{
    partial class Form3
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
            this.labConfirmation = new System.Windows.Forms.Label();
            this.labConfirmDestination = new System.Windows.Forms.Label();
            this.labConfirmDate = new System.Windows.Forms.Label();
            this.labConfirmTime = new System.Windows.Forms.Label();
            this.btnReturntoLogin = new System.Windows.Forms.Button();
            this.labConDest = new System.Windows.Forms.Label();
            this.labConDate = new System.Windows.Forms.Label();
            this.labConTime = new System.Windows.Forms.Label();
            this.labConManifest = new System.Windows.Forms.Label();
            this.lstbxManifest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labConfirmation
            // 
            this.labConfirmation.AutoSize = true;
            this.labConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmation.Location = new System.Drawing.Point(38, 9);
            this.labConfirmation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labConfirmation.Name = "labConfirmation";
            this.labConfirmation.Size = new System.Drawing.Size(293, 24);
            this.labConfirmation.TabIndex = 0;
            this.labConfirmation.Text = "Your Reservation is Confirmed";
            // 
            // labConfirmDestination
            // 
            this.labConfirmDestination.AutoSize = true;
            this.labConfirmDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmDestination.Location = new System.Drawing.Point(38, 60);
            this.labConfirmDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labConfirmDestination.Name = "labConfirmDestination";
            this.labConfirmDestination.Size = new System.Drawing.Size(106, 20);
            this.labConfirmDestination.TabIndex = 1;
            this.labConfirmDestination.Text = "Destination:";
            this.labConfirmDestination.Click += new System.EventHandler(this.labConfirmDestination_Click);
            // 
            // labConfirmDate
            // 
            this.labConfirmDate.AutoSize = true;
            this.labConfirmDate.Location = new System.Drawing.Point(190, 97);
            this.labConfirmDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labConfirmDate.Name = "labConfirmDate";
            this.labConfirmDate.Size = new System.Drawing.Size(79, 13);
            this.labConfirmDate.TabIndex = 2;
            this.labConfirmDate.Text = "labConfirmDate";
            this.labConfirmDate.Click += new System.EventHandler(this.labConfirmDate_Click);
            // 
            // labConfirmTime
            // 
            this.labConfirmTime.AutoSize = true;
            this.labConfirmTime.Location = new System.Drawing.Point(190, 134);
            this.labConfirmTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labConfirmTime.Name = "labConfirmTime";
            this.labConfirmTime.Size = new System.Drawing.Size(79, 13);
            this.labConfirmTime.TabIndex = 3;
            this.labConfirmTime.Text = "labConfirmTime";
            // 
            // btnReturntoLogin
            // 
            this.btnReturntoLogin.Location = new System.Drawing.Point(239, 327);
            this.btnReturntoLogin.Name = "btnReturntoLogin";
            this.btnReturntoLogin.Size = new System.Drawing.Size(99, 28);
            this.btnReturntoLogin.TabIndex = 7;
            this.btnReturntoLogin.Text = "Return to Log In";
            this.btnReturntoLogin.UseVisualStyleBackColor = true;
            this.btnReturntoLogin.Click += new System.EventHandler(this.btnReturntoLogin_Click);
            // 
            // labConDest
            // 
            this.labConDest.AutoSize = true;
            this.labConDest.Location = new System.Drawing.Point(190, 65);
            this.labConDest.Name = "labConDest";
            this.labConDest.Size = new System.Drawing.Size(62, 13);
            this.labConDest.TabIndex = 8;
            this.labConDest.Text = "labConDest";
            this.labConDest.Click += new System.EventHandler(this.labConDest_Click);
            // 
            // labConDate
            // 
            this.labConDate.AutoSize = true;
            this.labConDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConDate.Location = new System.Drawing.Point(38, 94);
            this.labConDate.Name = "labConDate";
            this.labConDate.Size = new System.Drawing.Size(139, 20);
            this.labConDate.TabIndex = 9;
            this.labConDate.Text = "Departure Date:";
            // 
            // labConTime
            // 
            this.labConTime.AutoSize = true;
            this.labConTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConTime.Location = new System.Drawing.Point(38, 133);
            this.labConTime.Name = "labConTime";
            this.labConTime.Size = new System.Drawing.Size(138, 20);
            this.labConTime.TabIndex = 10;
            this.labConTime.Text = "Departure Time:";
            // 
            // labConManifest
            // 
            this.labConManifest.AutoSize = true;
            this.labConManifest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConManifest.Location = new System.Drawing.Point(38, 179);
            this.labConManifest.Name = "labConManifest";
            this.labConManifest.Size = new System.Drawing.Size(173, 20);
            this.labConManifest.TabIndex = 11;
            this.labConManifest.Text = "Passenger Manifest:";
            // 
            // lstbxManifest
            // 
            this.lstbxManifest.FormattingEnabled = true;
            this.lstbxManifest.Location = new System.Drawing.Point(42, 213);
            this.lstbxManifest.Name = "lstbxManifest";
            this.lstbxManifest.Size = new System.Drawing.Size(164, 95);
            this.lstbxManifest.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.lstbxManifest);
            this.Controls.Add(this.labConManifest);
            this.Controls.Add(this.labConTime);
            this.Controls.Add(this.labConDate);
            this.Controls.Add(this.labConDest);
            this.Controls.Add(this.btnReturntoLogin);
            this.Controls.Add(this.labConfirmTime);
            this.Controls.Add(this.labConfirmDate);
            this.Controls.Add(this.labConfirmDestination);
            this.Controls.Add(this.labConfirmation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "confirmation";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labConfirmation;
        private System.Windows.Forms.Label labConfirmDestination;
        private System.Windows.Forms.Label labConfirmDate;
        private System.Windows.Forms.Label labConfirmTime;
        private System.Windows.Forms.Button btnReturntoLogin;
        private System.Windows.Forms.Label labConDest;
        private System.Windows.Forms.Label labConDate;
        private System.Windows.Forms.Label labConTime;
        private System.Windows.Forms.Label labConManifest;
        private System.Windows.Forms.ListBox lstbxManifest;
    }
}