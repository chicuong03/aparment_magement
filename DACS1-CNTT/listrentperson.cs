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
    public partial class listrentperson : Form
    {
        function fu = new function();
        string query;
        public listrentperson()
        {
            InitializeComponent();
        }

        private void listrentperson_Load(object sender, EventArgs e)
        {
            query = "SELECT n.roomNo,   n.name_, n.mobile, n.email, n.paddress, p.autumnday, p.summoney FROM newhuman n LEFT JOIN priceroom p ON n.roomNo = p.roomNo where living = 'da thue'";
            DataSet ds = fu.getData(query);
            dgvlistperson.DataSource = ds.Tables[0];
        }

        private void dgvlistperson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvlistperson.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox tương ứng
                txtfind.Text = row.Cells["roomNo"].Value.ToString();
            }
        }

            private void btnback_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfind.Text != "")
                {
                    string id = txtfind.Text;
                    query = "SELECT n.roomNo, n.name_, n.mobile, n.email, n.paddress, p.autumnday, p.summoney " +
                    "FROM newhuman n " +
                    "LEFT JOIN priceroom p ON n.roomNo = p.roomNo " +
                    "WHERE n.roomNo = '" + id + "'";
                    DataSet d = fu.getData(query);
                    dgvlistperson.DataSource = d.Tables[0];
                }
                else
                {
                    MessageBox.Show("Hãy nhập Số Phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Nhập sai");
            }
        }
        public string SelectedId { get; set; }
        private void btnbill_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy id từ textbox
                string IDroom = txtfind.Text;

                // tạo databill
                bill bill = new bill();

                // gán giá trị của detailBill = id cảu ô textbox vừa lấy đc
                bill.SelectedId = IDroom;

                // hiển thị
                bill.ShowDialog();
                
                // ẩn
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
