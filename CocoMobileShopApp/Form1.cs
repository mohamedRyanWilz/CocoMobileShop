using CocoMobileShopApp.Controller;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocoMobileShopApp
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string Email = userName.Text.ToString();
            string Pass = Password.Text.ToString();
            if (Email.Length ==0 )
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم");
                return;
            }
            if (Pass.Length == 0)
            {
                MessageBox.Show("من فضلك ادخل كلمه المرور");
                return;
            }
            if (IsValidEmail(Email))
            {

                UsersController usercontrol = new UsersController();
                var user = usercontrol.Login(Email, Pass);
                if (user == null)
                {
                    MessageBox.Show("من فضلك ادخل اسم المستخدم وكلمه مرور صحيحين");
                    return;
                }
                else
                {
                    if(user.Role == 1)
                    {
                        MessageBox.Show("admin");
                    }
                    else
                    {
                        MessageBox.Show("user");
                    }
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل اسم مستخدم صحيح ");
                return;
            }
           
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Password_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
