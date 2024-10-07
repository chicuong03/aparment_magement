using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Applier = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Linq.Expressions;

namespace DACS1_CNTT
{
    public partial class export : Form
    {
        function fu = new function();
        string query;
        public export()
        {
            InitializeComponent();
        }

        private void export_Load(object sender, EventArgs e)
        {
            // xuất file excel
            query = "select roomNo, electric unitpriceelectric, water, unitpricewater, autumnday, price, moneyelectric, moneywater, summoney from priceroom where pay = 0";
            DataSet dt = fu.getData(query);
            dgvexport.DataSource = dt.Tables[0];
        }
        private void exportfileexcell(DataGridView g, string link, string filename)
        {
            try
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 20;

                // Tìm vị trí giữa của bảng dữ liệu
                int titleRow = 1;
                int titleCol = 1;

                // Ghi tiêu đề vào ô giữa bảng
                obj.Cells[titleRow, titleCol] = "Danh sách hóa đơn phòng trọ";

                // Đặt font chữ in đậm
                obj.Cells[titleRow, titleCol].Font.Bold = true;

                // Căn giữa ngang toàn bộ dòng tiêu đề
                obj.Range[obj.Cells[titleRow, titleCol], obj.Cells[titleRow, g.Columns.Count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Căn giữa dọc tiêu đề
                obj.Cells[titleRow, titleCol].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Gộp ô tiêu đề sang phải để căn giữa tiêu đề
                obj.Cells[titleRow, titleCol].EntireRow.RowHeight = 30; // Đặt chiều cao dòng
                obj.Range[obj.Cells[titleRow, titleCol], obj.Cells[titleRow, g.Columns.Count]].Merge();

                // Căn giữa các ô trong vùng dữ liệu
                for (int i = 2; i <= g.Rows.Count + 2; i++)
                {
                    for (int j = 1; j <= g.Columns.Count; j++)
                    {
                        obj.ActiveSheet.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }

                // Ghi tiêu đề cột
                for (int i = 1; i <= g.Columns.Count; i++)
                {
                    obj.Cells[2, i] = g.Columns[i - 1].HeaderText;
                    obj.Cells[2, i].Font.Bold = true; // In đậm tiêu đề cột
                }

                // Kẻ viền cho tiêu đề cột
                obj.Range[obj.Cells[2, 1], obj.Cells[2, g.Columns.Count]].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick);

                // Ghi dữ liệu
                for (int i = 0; i < g.Rows.Count; i++)
                {
                    for (int j = 0; j < g.Columns.Count; j++)
                    {
                        if (g.Rows[i].Cells[j].Value != null)
                        {
                            // Kiểm tra nếu giá trị là số
                            if (g.Rows[i].Cells[j].Value.GetType() == typeof(double) || g.Rows[i].Cells[j].Value.GetType() == typeof(int))
                            {
                                obj.Cells[i + 3, j + 1].Value = Convert.ToDouble(g.Rows[i].Cells[j].Value).ToString("0.###");
                            }
                            else
                            {
                                obj.Cells[i + 3, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                }

                // Kẻ viền cho dữ liệu
                obj.Range[obj.Cells[3, 1], obj.Cells[g.Rows.Count + 2, g.Columns.Count]].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                // Tô màu vàng cho cột cuối cùng
                int lastCol = g.Columns.Count;
                Microsoft.Office.Interop.Excel.Range range = obj.Range[obj.Cells[2, lastCol], obj.Cells[g.Rows.Count + 2, lastCol]];
                range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                obj.ActiveWorkbook.SaveCopyAs(link + filename + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, Thư mục đang mở hoặc thông tin bị lỗi");
            }
        }
        private void btnexport_Click(object sender, EventArgs e)
        {
            exportfileexcell(dgvexport, @"D:\DOTNET\DACS1-CNTT\dataexcell\", "dataexcell");
            MessageBox.Show("Xuất file thành công","Thông Báo");
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
