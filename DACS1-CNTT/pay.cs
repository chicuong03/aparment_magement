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
    public partial class pay : Form
    {
        function fu = new function();
        string query;
        public pay()
        {
            InitializeComponent();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pay_Load(object sender, EventArgs e)
        {
            query = "SELECT DISTINCT roomNo, MAX(CASE WHEN pay = 1 THEN 1 ELSE 0 END) AS pay FROM priceroom GROUP BY roomNo";
            DataSet d = fu.getData(query);
            dgvpay.DataSource = d.Tables[0];


            if (cbxroomnumber.Items.Count == 0)
            {
                // ComboBox không có dữ liệu
                // Thêm dữ liệu vào ComboBox
                query = "select roomNo from priceroom";
                DataSet ds = fu.getData(query);
                HashSet<Int64> uniqueRoomNumbers = new HashSet<Int64>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                    if (!uniqueRoomNumbers.Contains(room))
                    {
                        uniqueRoomNumbers.Add(room);
                    }
                }

                foreach (Int64 room in uniqueRoomNumbers)
                {
                    cbxroomnumber.Items.Add(room);
                }
            }


            query = "UPDATE priceroom SET pay = 0 WHERE MONTH(autumnday) <> MONTH(GETDATE())"; // tự động resset người đóng tiền khi qua tháng mới
            fu.setDataNO(query);


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT electric,unitpriceelectric, water, unitpricewater, autumnday,price,moneyelectric,moneywater,summoney  FROM priceroom WHERE roomNo = " + cbxroomnumber.Text + "";
                DataSet ds = fu.getData(query);

                if (cbxroomnumber.Text == "")
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Hiển thị dữ liệu lên các TextBox hoặc Controls khác
                    txtsodien.Text = ds.Tables[0].Rows[0]["electric"].ToString();
                    txtsonuoc.Text = ds.Tables[0].Rows[0]["water"].ToString();
                    txtgiadien.Text = ds.Tables[0].Rows[0]["unitpriceelectric"].ToString();
                    txtgianuoc.Text = ds.Tables[0].Rows[0]["unitpricewater"].ToString();
                    txttongdien.Text = ds.Tables[0].Rows[0]["moneyelectric"].ToString();
                    txttongnuoc.Text = ds.Tables[0].Rows[0]["moneywater"].ToString();
                    txttongtien.Text = ds.Tables[0].Rows[0]["summoney"].ToString();
                    txtgiaphong.Text = ds.Tables[0].Rows[0]["price"].ToString();
                    datetime.Text = ds.Tables[0].Rows[0]["autumnday"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string roomNo = cbxroomnumber.Text;
                if (chkwaspay.Checked)
                {
                    query = "update priceroom set pay = 1 where roomNo = '" + roomNo + "'";
                    fu.setData(query, "Thanh Toán Thành Công");
                    pay_Load(this, null);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            export export = new export();
            export.ShowDialog();
        }

        private void dgvpay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô được nhấp vào có phải là ô CheckBox không
            if (e.ColumnIndex == dgvpay.Columns["pay"].Index)
            {
                // Lấy giá trị hiện tại của CheckBox
                bool isChecked = (bool)dgvpay.Rows[e.RowIndex].Cells["pay"].Value;

                // Đảo giá trị CheckBox
                dgvpay.Rows[e.RowIndex].Cells["pay"].Value = !isChecked;
            }

            // Kiểm tra xem có dòng nào được chọn hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvpay.Rows[e.RowIndex];
                // Lấy giá trị hiện tại của CheckBox trong dòng được chọn
                bool isChecked = (bool)dgvpay.Rows[e.RowIndex].Cells["pay"].Value;

                // Đảo giá trị CheckBox
                chkwaspay.Checked = isChecked;

                cbxroomnumber.SelectedValue = row.Cells["roomNo"].Value;
            }
        }
    }
}
