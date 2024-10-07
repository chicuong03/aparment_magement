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
    public partial class signin : Form
    {
        function fu = new function();
        string query;
        public signin()
        {
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {
            query = "select * from useraccounts";
            DataSet ds = fu.getData(query);
            dgvaccount.DataSource = ds.Tables[0];
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from useraccounts where username ='" + txtusername.Text + "'";
                fu.setData(query, "Xóa Thành công");
                txtpass.Clear();
                txtrole.Clear();
                txtusername.Clear();
                signin_Load(this, null);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string name = txtusername.Text;
            string password = txtpass.Text;
            string role = txtrole.Text;
            query = "insert into useraccounts (username,password, role) values ('" + name + "','" + password + "','" + role + "')";
            try
            {
                if (txtusername.Text != "" && txtpass.Text != "" && txtrole.Text != "")
                {
                    if (txtrole.Text == "admin" || txtrole.Text == "user" || txtrole.Text == "custommer")
                    {
                        fu.setData(query, "Thêm thành công");
                        txtpass.Clear();
                        txtrole.Clear();
                        txtusername.Clear();
                        signin_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Role chỉ nhận giá trị ADMIN, USER và CUSTOMMER", "Thông báo");
                        txtpass.Clear();
                        txtrole.Clear();
                        txtusername.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đang bỏ trống", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvaccount.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox tương ứng
                txtusername.Text = row.Cells["username"].Value.ToString();
                txtpass.Text = row.Cells["password"].Value.ToString();
                txtrole.Text = row.Cells["role"].Value.ToString();
            }
        }
    }
}
