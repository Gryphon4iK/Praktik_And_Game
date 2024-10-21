using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products : Form
    {
        private ProductsForm productsForm;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.shopDataSet.catalogs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.shopDataSet.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.shopDataSet.products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            productsForm = new ProductsForm();
            productsForm.Show();
        }
    }
}
