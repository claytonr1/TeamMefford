namespace RuffCoJetReservation
{
    partial class Form2
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
            this.labReservation = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labDestination = new System.Windows.Forms.Label();
            this.labDepartDate = new System.Windows.Forms.Label();
            this.datetimeDate = new System.Windows.Forms.DateTimePicker();
            this.labDepartTime = new System.Windows.Forms.Label();
            this.datetimeTime = new System.Windows.Forms.DateTimePicker();
            this.labJets = new System.Windows.Forms.Label();
            this.btnReserver = new System.Windows.Forms.Button();
            this.cklstbxDestination = new System.Windows.Forms.CheckedListBox();
            this.cklstbxJets = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labReservation
            // 
            this.labReservation.AutoSize = true;
            this.labReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReservation.Location = new System.Drawing.Point(13, 25);
            this.labReservation.Name = "labReservation";
            this.labReservation.Size = new System.Drawing.Size(120, 24);
            this.labReservation.TabIndex = 0;
            this.labReservation.Text = "Reservation";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(19, 72);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(35, 13);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "Name";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(99, 72);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(49, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "labName";
            this.labName.Click += new System.EventHandler(this.labName_Click);
            // 
            // labDestination
            // 
            this.labDestination.AutoSize = true;
            this.labDestination.Location = new System.Drawing.Point(17, 104);
            this.labDestination.Name = "labDestination";
            this.labDestination.Size = new System.Drawing.Size(60, 13);
            this.labDestination.TabIndex = 0;
            this.labDestination.Text = "Destination";
            // 
            // labDepartDate
            // 
            this.labDepartDate.AutoSize = true;
            this.labDepartDate.Location = new System.Drawing.Point(19, 194);
            this.labDepartDate.Name = "labDepartDate";
            this.labDepartDate.Size = new System.Drawing.Size(80, 13);
            this.labDepartDate.TabIndex = 0;
            this.labDepartDate.Text = "Departure Date";
            // 
            // datetimeDate
            // 
            this.datetimeDate.Location = new System.Drawing.Point(117, 194);
            this.datetimeDate.Name = "datetimeDate";
            this.datetimeDate.Size = new System.Drawing.Size(200, 20);
            this.datetimeDate.TabIndex = 2;
            this.datetimeDate.ValueChanged += new System.EventHandler(this.datetimeDate_ValueChanged);
            // 
            // labDepartTime
            // 
            this.labDepartTime.AutoSize = true;
            this.labDepartTime.Location = new System.Drawing.Point(19, 223);
            this.labDepartTime.Name = "labDepartTime";
            this.labDepartTime.Size = new System.Drawing.Size(80, 13);
            this.labDepartTime.TabIndex = 0;
            this.labDepartTime.Text = "Departure Time";
            // 
            // datetimeTime
            // 
            this.datetimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimeTime.Location = new System.Drawing.Point(117, 223);
            this.datetimeTime.Name = "datetimeTime";
            this.datetimeTime.Size = new System.Drawing.Size(109, 20);
            this.datetimeTime.TabIndex = 3;
            this.datetimeTime.Value = new System.DateTime(2015, 9, 10, 12, 0, 0, 0);
            this.datetimeTime.ValueChanged += new System.EventHandler(this.datetimeTime_ValueChanged);
            // 
            // labJets
            // 
            this.labJets.AutoSize = true;
            this.labJets.Location = new System.Drawing.Point(19, 264);
            this.labJets.Name = "labJets";
            this.labJets.Size = new System.Drawing.Size(72, 13);
            this.labJets.TabIndex = 0;
            this.labJets.Text = "Available Jets";
            // 
            // btnReserver
            // 
            this.btnReserver.Location = new System.Drawing.Point(249, 384);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(118, 23);
            this.btnReserver.TabIndex = 5;
            this.btnReserver.Text = "Make Reservation";
            this.btnReserver.UseVisualStyleBackColor = true;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // cklstbxDestination
            // 
            this.cklstbxDestination.FormattingEnabled = true;
            this.cklstbxDestination.Items.AddRange(new object[] {
            "Charlotte, NC",
            "Greenville, SC",
            "Missoula, MT",
            "Rapid City, SD"});
            this.cklstbxDestination.Location = new System.Drawing.Point(117, 104);
            this.cklstbxDestination.Name = "cklstbxDestination";
            this.cklstbxDestination.Size = new System.Drawing.Size(102, 64);
            this.cklstbxDestination.TabIndex = 7;
            // 
            // cklstbxJets
            // 
            this.cklstbxJets.FormattingEnabled = true;
            this.cklstbxJets.Items.AddRange(new object[] {
            "Beechjet 400",
            "Challenger 600",
            "Challenger 601",
            "Lear 45"});
            this.cklstbxJets.Location = new System.Drawing.Point(117, 264);
            this.cklstbxJets.Name = "cklstbxJets";
            this.cklstbxJets.Size = new System.Drawing.Size(120, 64);
            this.cklstbxJets.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 419);
            this.Controls.Add(this.cklstbxJets);
            this.Controls.Add(this.cklstbxDestination);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.labJets);
            this.Controls.Add(this.datetimeTime);
            this.Controls.Add(this.labDepartTime);
            this.Controls.Add(this.datetimeDate);
            this.Controls.Add(this.labDepartDate);
            this.Controls.Add(this.labDestination);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labReservation);
            this.Name = "Form2";
            this.Text = "reservation";
            this.Activated += new System.EventHandler(this.Form2_Load);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labReservation;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDestination;
        private System.Windows.Forms.Label labDepartDate;
        private System.Windows.Forms.DateTimePicker datetimeDate;
        private System.Windows.Forms.Label labDepartTime;
        private System.Windows.Forms.DateTimePicker datetimeTime;
        private System.Windows.Forms.Label labJets;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.CheckedListBox cklstbxDestination;
        private System.Windows.Forms.CheckedListBox cklstbxJets;
    }
}