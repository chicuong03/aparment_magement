using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DACS1_CNTT
{
    public partial class billcustomer : Form
    {
        string query;
        function fu = new function();
        public billcustomer()
        {
            InitializeComponent();
        }

        private void billcustomer_Load(object sender, EventArgs e)
        {
            query = "select roomNo from priceroom";
            DataSet ds = fu.getData(query);

            // Tạo một HashSet để lưu trữ các giá trị duy nhất
            HashSet<Int64> uniqueRoomNumbers = new HashSet<Int64>();

            // Duyệt qua từng dòng trong DataSet
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());

                // Chỉ thêm vào HashSet nếu giá trị chưa tồn tại
                if (!uniqueRoomNumbers.Contains(room))
                {
                    uniqueRoomNumbers.Add(room);
                }
            }

            // Thêm các giá trị duy nhất vào ComboBox
            foreach (Int64 room in uniqueRoomNumbers)
            {
                cbxroomnumber.Items.Add(room);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
    }
}
