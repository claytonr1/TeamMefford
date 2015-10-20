using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuffCoJetReservation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            
            //Window Title Bar
            this.Text = "Ruffco";
            Program.myForm3 = new Form3();

            //Minimum Current Time for Departure Time
            DateTimePicker myPicker = new DateTimePicker();
            myPicker.Value = DateTime.Now;
            

        }

        
        private void datetimeTime_ValueChanged(object sender, EventArgs e)
        {
          
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {   
            
            //Minimum Current Time for Departure Time
            datetimeTime.Format = DateTimePickerFormat.Custom;
            datetimeTime.CustomFormat = "h:mm tt";
            this.datetimeTime.Value = DateTime.Now;
            labName.Text = LoginToken.Username;


        }


        private void labName_Click(object sender, EventArgs e)
        {

        }

        private void btnReserver_Click(object sender, EventArgs e)
        {  
            //Open form 3 and close form2
            Program.myForm3.Show();
            this.Hide();
        }

        private void datetimeDate_ValueChanged(object sender, EventArgs e)
        {
            //Minimum Current Date for Departure Date
            datetimeDate.MinDate = DateTime.Today;
        }

        private void lstbxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmboxJets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setUsername()
        {
        
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
