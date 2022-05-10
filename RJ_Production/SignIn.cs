using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Production
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOut_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            if (SignIn_txtBox.Text == "" && Password_txtBox.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                if (SignIn_txtBox.Text == "admin" && Password_txtBox.Text == "admin")
                { 
                //MessageBox.Show("Thank you for activation!");
                this.Hide();
                WaterMark fm = new WaterMark();
                fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
