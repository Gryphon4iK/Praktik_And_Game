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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.shopDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.ViewORDER". При необходимости она может быть перемещена или удалена.
            this.viewORDERTableAdapter.Fill(this.shopDataSet.ViewORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.emp". При необходимости она может быть перемещена или удалена.
            this.empTableAdapter.Fill(this.shopDataSet.emp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.shopDataSet.orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox12.Text = Convert.ToString(Convert.ToDouble(maskedTextBox1.Text) * Convert.ToDouble(maskedTextBox2.Text));
        }
    }
}
