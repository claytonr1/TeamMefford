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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Window Title Bar
            this.Text = "Ruffco";

            Program.myForm2 = new Form2();
           
            
        } 

        private void btnLogIn_Click(object sender, EventArgs e)
        {
         //Close form1 and open form2
            Program.myForm2.Show();
            this.Hide();
           //Program.myForm2.labName.text = 


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //User name from form1 to Name on form2
           /* Program.theUser = new Person();
            Program.theUser.Name();
            this.txtbxUserName.Text = Program.theUser.Name; */
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {   //Log off
            Application.Exit();
        }

        private void labLogIn_Click(object sender, EventArgs e)
        {

        }

        private void txtbxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
