using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DACS1_CNTT
{
    public partial class Menu : Form
    {
        function f = new function();
        string query;
        string username = "", password = "", role = "";
       
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string username,string password, string role)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.role = role;
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắn chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


        private void btnmanagerroom_Click(object sender, EventArgs e)
        {
           
                openchildform(new addroom());
          
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(role == "user")
            {
                btnmanagerroom.Enabled = false;
                btnpay.Enabled = false;
                btnservice.Enabled = false;
                btnaccount.Enabled = false;
                chart1.Visible = false;
            }
            if (role == "custommer")
            {
                btnmanagerroom.Visible = false;
                btnpay.Visible = false;
                btnservice.Visible = false;
                btnaccount.Visible = false;
                chart1.Visible = false;
                btnbill.Visible = false;
                btncustommer.Visible = true;
                btnaddhuman.Visible = false;
                btnleaveroom.Visible = false;
                btnaccount.Visible = false;
               
            }   
            try
            {
                DateTime selectedDate = DateTime.Now;          

                // Trích xuất ngày từ DateTime
                int year_ = selectedDate.Year;
                string query = $"SELECT MONTH(autumnday) AS Month, SUM(summoney) AS TotalMoney FROM priceroom WHERE YEAR(autumnday) = {year_} GROUP BY MONTH(autumnday) ORDER BY MONTH(autumnday);";

                DataSet d = f.getData(query);

                // Tạo Series cho biểu đồ
                if (chart1.Series.IndexOf("Tổng Doanh Thu Tháng") != -1)
                {
                    chart1.Series.Remove(chart1.Series["Biểu Đồ Doanh Thu"]);
                }

                chart1.Series.Add("Biểu Đồ Doanh Thu");
                chart1.Series["Biểu Đồ Doanh Thu"].ChartType = SeriesChartType.Column;

                // Vẽ cột cho mỗi tháng
                foreach (DataRow row in d.Tables[0].Rows)
                {
                    int month = Convert.ToInt32(row["Month"]);
                    double totalMoney = Convert.ToDouble(row["TotalMoney"]);
                    chart1.Series["Biểu Đồ Doanh Thu"].Points.AddXY(month, totalMoney);
                }


                // Vẽ cột cho mỗi tháng và thêm nhãn hiển thị giá trị
                foreach (DataRow row in d.Tables[0].Rows)
                {
                    int month = Convert.ToInt32(row["Month"]);
                    double totalMoney = Convert.ToDouble(row["TotalMoney"]);

                    // Tạo một DataPoint mới và thêm vào Series của biểu đồ
                    DataPoint point = new DataPoint();
                    point.XValue = month;
                    point.YValues = new double[] { totalMoney };

                    // Thêm nhãn hiển thị giá trị
                    point.Label = totalMoney.ToString(); // Bạn có thể định dạng chuỗi này theo nhu cầu của mình
                    point.LabelForeColor = Color.Black; // Tuỳ chỉnh màu sắc của nhãn
                    point.LabelAngle = -90; // Xoay nhãn nếu cần thiết

                    // Thêm DataPoint vào Series của biểu đồ
                    chart1.Series["Biểu Đồ Doanh Thu"].Points.Add(point);
                    
          
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnaddhuman_Click(object sender, EventArgs e)
        {
           openchildform( new addhuman());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                openchildform(new bill());
            
            
        }

        private void btnlistrent_Click(object sender, EventArgs e)
        {
            openchildform(new listrentperson());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            openchildform( new update());
        }

        private void btnpay_Click(object sender, EventArgs e)
        {        
                openchildform(new pay());          
        }

        private void btnleaveroom_Click(object sender, EventArgs e)
        {
            openchildform(new leavedhuman());
        }

        private void btnstatus_Click(object sender, EventArgs e)
        {
            openchildform(new changepassword());
        }


        // form cha form con
        private Form currentFormchid;
        private void openchildform (Form childform)
        {
            if(currentFormchid !=null)
            { currentFormchid.Close(); }
            currentFormchid = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnbody.Controls.Add(childform);
            pnbody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btncustommer_Click(object sender, EventArgs e)
        {
            openchildform(new billcustomer());  
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
             openchildform(new signin());          
        }



        private void btnservice_Click(object sender, EventArgs e)
        {          
                openchildform(new Service());          
        }

        
    }
}
