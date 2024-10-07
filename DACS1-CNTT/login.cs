using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DACS1_CNTT
{
    public partial class login : Form
    {
       
        function fu = new function();
        string query;
        public login()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lbdangnhap.Text = "Không được bỏ trống tên đăng nhập hoặc mật khẩu*";
                return;
            }

            string query = "SELECT * FROM useraccounts WHERE username = '" + username + "' AND password = '" + password + "'";
            DataSet ds = fu.getData(query);
            

            if (ds.Tables[0].Rows.Count > 0)
            {

                Menu adminForm = new Menu(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString());
                adminForm.Show();
                this.Hide();
            }
            else
            {
                lbdangnhap.Text = "Sai tên tài khoản hoặc mật khẩu*";
            }
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
