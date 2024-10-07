using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace DACS1_CNTT
{
    public partial class addhuman : Form
    {
        function fu = new function();
        string query;
        public addhuman()
        {
            InitializeComponent();
        }

        private void addhuman_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select roomNo from rooms where roomStatus = 'san sang' and Booked = 'Trong'";
                DataSet ds = fu.getData(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                    cbxroomnumber.Items.Add(room);
                }
                string q = "select * from newhuman order by id DESC";
                DataSet d = fu.getData(q);
                dgvlist.DataSource = d.Tables[0];
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txthovaten.Clear();
            txtphone.Clear();
            txtcccd.Clear();
            txtdc.Clear();
            txtemail.Clear();
            cbxroomnumber.SelectedItem = null;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        { try
            {

                string phonenumber = txtphone.Text;
                if (txtphone.Text == "" || txtcccd.Text == "" || txtdc.Text == "" || txtemail.Text == "" || txthovaten.Text == "" || cbxroomnumber.Text == "" || !phonenumber.All(char.IsDigit))
                {
                    MessageBox.Show("Bạn đã nhập thiếu thông tin hoặc nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Int64 phone = Int64.Parse(txtphone.Text);
                    string cccd = txtcccd.Text;
                    string dc = txtdc.Text;
                    string email = txtemail.Text;
                    string hovaten = txthovaten.Text;
                    Int64 roomNo = Int64.Parse(cbxroomnumber.Text);                    
                    query = "insert into newhuman (mobile, name_, email, paddress,idproof, roomNo) values  (" + phone + ",N'" + hovaten + "','" + email + "',N'" + dc + "','" + cccd + "'," + roomNo + ") update rooms set Booked = 'da thue' where roomNo = " + roomNo + "";
                    fu.setData(query, "Thêm Người thuê Thành công");
                    cbxroomnumber.Items.Clear();
                    addhuman_Load(dgvlist, null);
                }
                txthovaten.Clear();
                txtphone.Clear();
                txtcccd.Clear();
                txtdc.Clear();
                txtemail.Clear();
                cbxroomnumber.SelectedItem = null;



            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi"); ;
            }
        }

        private void cbxroomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvlist.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox tương ứng
                txthovaten.Text = row.Cells["name_"].Value.ToString();
                txtphone.Text = row.Cells["mobile"].Value.ToString();
                txtemail.Text = row.Cells["email"].Value.ToString();
                txtdc.Text = row.Cells["paddress"].Value.ToString();
                txtcccd.Text = row.Cells["idproof"].Value.ToString() ;
                txtid.Text = row.Cells["roomNo"].Value.ToString();

                // Lấy dữ liệu từ cột "ColumnName" trong dòng được chọn
                string data = dgvlist.Rows[e.RowIndex].Cells["roomNo"].Value?.ToString();

                // Xóa tất cả các mục hiện có trong ComboBox
                cbxroomnumber.Items.Clear();

                // Thêm dữ liệu vào ComboBox
                cbxroomnumber.Items.Add(data);
            }
        }

        public string SelectedId { get; set; }
   

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy id từ textbox
                string IDroom = txtid.Text;

                // tạo databill
                update update = new update();

                // gán giá trị của detailBill = id cảu ô textbox vừa lấy đc
                update.SelectedOrderId = IDroom;

                // hiển thị
                update.Show();

                // ẩn
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnlistrent_Click(object sender, EventArgs e)
        {
            listrentperson listrentperson = new listrentperson();
            listrentperson.ShowDialog();
        }
    }
}
