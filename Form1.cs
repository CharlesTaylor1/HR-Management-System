using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class Fr_HrManagementSystem : Form
    {
        public Fr_HrManagementSystem()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            String Uemail = "d", Upassword = "d", Email, Password;

            Email = tb_Email.Text;
            Password = tb_Password.Text;

          

            if (Email.Equals(Uemail) && Password.Equals(Upassword))

            {
                
                MessageBox.Show("Log In is Successfull");

                main obj = new main();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Please enter a correct email/password", "HR Management System");
                tb_Email.Clear();
                tb_Password.Clear();
                tb_Email.Focus();
            }


            
        }

        private void HR_Management_System_Load(object sender, EventArgs e)
        {
           
        }

        private void Fr_HrManagementSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
