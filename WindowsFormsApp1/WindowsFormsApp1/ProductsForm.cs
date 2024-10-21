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
    
    public partial class ProductsForm : Form
    {
        private System.Windows.Forms.DataGridViewColumn COL;
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.shopDataSet.products);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }

            if (radioButton1.Checked)
                productsDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                productsDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsBindingSource.Filter = "name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < productsDataGridView.ColumnCount - 1; i++)
            {
                for(int j = 0; j < productsDataGridView.RowCount - 1; j++)
                {
                    productsDataGridView[i, j].Style.BackColor = Color.White;
                    productsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < productsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < productsDataGridView.RowCount - 1; j++)
                {
                    if (productsDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        productsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        productsDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
