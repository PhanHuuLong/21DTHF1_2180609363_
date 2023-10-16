using Lab4_01.temp_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_01
{
    public partial class OrderImformation : Form
    {
        public OrderImformation()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void OrderImformation_Load(object sender, EventArgs e)
        {
            // Thiết lập kiểu dữ liệu "Date" cho cột "orderDate"
            dgvOrderInformation.Columns["orderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrderInformation.Columns["orderDate"].ValueType = typeof(DateTime);

            // Thiết lập kiểu dữ liệu "Date" cho cột "deliveryDate"
            dgvOrderInformation.Columns["deliveryDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrderInformation.Columns["deliveryDate"].ValueType = typeof(DateTime);
            /*dgvOrderInformation.CellFormatting += dgvOrderInformation_CellFormatting;*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /*private void dgvOrderInformation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            int columnIndex = dgvOrderInformation.Columns["orderDate"].Index;
            if (e.ColumnIndex == columnIndex && e.Value != null)
            {
                DateTime dateValue;
                if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng ngày tháng năm tùy chỉnh ở đây
                    e.FormattingApplied = true;
                }
            }
        }*/
       void UpdateDataGridView()
        {
            OrderContextDB db = new OrderContextDB();
            listInvoice = db.Invoices.ToList();
            listorder = db.Orders.ToList();

            var list = listInvoice.Where(li => li.OrderDate.Date >= dateTimePicker1.Value.Date &&
            li.DeliveryDate.Date <= dateTimePicker2.Value.Date).ToList();

            dgvOrderInformation.Rows.Clear();

            foreach (var li in list)
            {
                var order = listorder.Where(lo => lo.InvoiceNo.Equals(li.InvoiceNo)).ToList();
                foreach (var temp_listorder in order)
                {
                    //orderTotal
                    int rowIndex = dgvOrderInformation.Rows.Add();
                    dgvOrderInformation.Rows[rowIndex].Cells["nummers"].Value = (rowIndex + 1).ToString();
                    dgvOrderInformation.Rows[rowIndex].Cells["orderID"].Value = li.InvoiceNo.ToString();
                    dgvOrderInformation.Rows[rowIndex].Cells["orderDate"].Value = li.OrderDate;
                    dgvOrderInformation.Rows[rowIndex].Cells["deliveryDate"].Value = li.DeliveryDate;
                    dgvOrderInformation.Rows[rowIndex].Cells["orderTotal"].Value = (temp_listorder.Price * temp_listorder.Quantity).ToString();
                }
            }
        }
        List<Invoice> listInvoice= new List<Invoice>();
        List<Order> listorder=new List<Order>();
        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;

            if (checkbox.Checked)
            {

                OrderContextDB db = new OrderContextDB();
                listInvoice = db.Invoices.ToList();
                listorder = db.Orders.ToList();

                dgvOrderInformation.Rows.Clear();

                foreach (var li in listInvoice)
                {
                    var order = listorder.Where(lo => lo.InvoiceNo.Equals(li.InvoiceNo)).ToList();
                    foreach (var temp_listorder in order)
                    {
                        //orderTotal
                        int rowIndex = dgvOrderInformation.Rows.Add();
                        dgvOrderInformation.Rows[rowIndex].Cells["nummers"].Value = (rowIndex + 1).ToString();
                        dgvOrderInformation.Rows[rowIndex].Cells["orderID"].Value = li.InvoiceNo.ToString();
                        dgvOrderInformation.Rows[rowIndex].Cells["orderDate"].Value = li.OrderDate;
                        dgvOrderInformation.Rows[rowIndex].Cells["deliveryDate"].Value = li.DeliveryDate;
                        dgvOrderInformation.Rows[rowIndex].Cells["orderTotal"].Value = (temp_listorder.Price * temp_listorder.Quantity).ToString();
                    }
                }
            }
            else
            {
                
                dgvOrderInformation.Rows.Clear();
            }
        }
    }
}
