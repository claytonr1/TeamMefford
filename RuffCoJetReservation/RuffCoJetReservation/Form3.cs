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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            //Window Title Bar
            this.Text = "Ruffco";
        }

        private void labConfirmDestination_Click(object sender, EventArgs e)
        {
            

        }

        private void labConfirmDate_Click(object sender, EventArgs e)
        {
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReturntoLogin_Click(object sender, EventArgs e)
        {
            //Close form3 and open form1
            Program.myForm1 = new Form1();
            Program.myForm1.Show();
            this.Hide();
        }

        private void labConDest_Click(object sender, EventArgs e)
        {

        }
    }
}
