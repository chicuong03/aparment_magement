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
    public partial class changepassword : Form
    {
        function fu = new function();
        string query;
        public changepassword()
        {
            InitializeComponent();
        }

  

        private void changepassword_Load(object sender, EventArgs e)
        {
            btnshow.Visible = true;
            lbnoti.Visible = false;
            btncfshow.Visible = true;
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            txtnewpass.UseSystemPasswordChar = true;
            btnshow.Visible = true;
            btnhide.Visible = false;
            txtnewpass.Focus();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            txtnewpass.UseSystemPasswordChar = false;
            btnhide.Visible = true;
            btnshow.Visible = false;
            txtnewpass.Focus();
        }

        private void btncfshow_Click(object sender, EventArgs e)
        {
            txtconfirm.UseSystemPasswordChar = false;
            btncfhide.Visible = true;
            btncfshow.Visible = false;
            txtconfirm.Focus();
        }


        private void btncfhide_Click_1(object sender, EventArgs e)
        {
            txtconfirm.UseSystemPasswordChar = true;
            btncfshow.Visible = true;
            btncfhide.Visible = false;
            txtconfirm.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = " select * from useraccounts where password = '" + txtoldpass.Text + "'";
                DataSet ds = fu.getData(query);
                if (txtconfirm.Text != "" && txtnewpass.Text != "" && txtoldpass.Text != "")
                {
                    if (txtnewpass.Text == txtconfirm.Text)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            query = "UPDATE useraccounts SET password = '" + txtnewpass.Text + "' WHERE username = 'admin'  AND password = '" + txtoldpass.Text + "'";
                            fu.setData(query, "Đổi mật khẩu thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        lbnoti.Visible = true;
                    }
                }
                else { MessageBox.Show("Bạn đang để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changepassword_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
