namespace RuffCoJetReservation
{
    partial class Form1
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
            this.labLogIn = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLogIn
            // 
            this.labLogIn.AutoSize = true;
            this.labLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogIn.Location = new System.Drawing.Point(13, 22);
            this.labLogIn.Name = "labLogIn";
            this.labLogIn.Size = new System.Drawing.Size(155, 24);
            this.labLogIn.TabIndex = 0;
            this.labLogIn.Text = "Please Log In...";
            this.labLogIn.Click += new System.EventHandler(this.labLogIn_Click);
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(17, 81);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(60, 13);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "User Name";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(20, 132);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 13);
            this.labPassword.TabIndex = 0;
            this.labPassword.Text = "Password";
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(112, 73);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtbxUserName.TabIndex = 1;
            this.txtbxUserName.TextChanged += new System.EventHandler(this.txtbxUserName_TextChanged);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(112, 124);
            this.txtbxPassword.MaxLength = 8;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxPassword.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(103, 171);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(216, 226);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(56, 24);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Log Off";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUserName);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labLogIn);
            this.Name = "Form1";
            this.Text = "logIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLogIn;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnQuit;
    }
}

