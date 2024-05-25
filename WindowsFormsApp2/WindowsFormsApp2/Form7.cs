using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.DetailOfOrderParts". При необходимости она может быть перемещена или удалена.
            this.detailOfOrderPartsTableAdapter.Fill(this.demoEkzDataSet.DetailOfOrderParts);
            RefreshTable();
        }
        private void RefreshTable()
        {
            string sql = "Select * from DetailOfOrderParts";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDetailOfOrderParts addDofOP = new AddDetailOfOrderParts();
            DialogResult result = addDofOP.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into DetailOfOrderParts (ID_DetailOfExecutor, ID_Detail, ID_OrderParts, Quantity, Price) values (@idDoOP, ,@idD, @idOP, @quantity, @price)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idDofE", addDofOP.textBox1.Text);
                        command.Parameters.AddWithValue("@idD", addDofOP.textBox2.Text);
                        command.Parameters.AddWithValue("@idOP", addDofOP.textBox3.Text);
                        command.Parameters.AddWithValue("@quantity", addDofOP.textBox4.Text);
                        command.Parameters.AddWithValue("@price", addDofOP.textBox5.Text);

                        command.ExecuteNonQuery();
                        RefreshTable();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                if (converted == false)
                {
                    return;
                }

                AddDetailOfOrderParts addDofOP = new AddDetailOfOrderParts();
                DialogResult result = addDofOP.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Deta set ID_DetailOfOrderParts = @idDofOP, ID_Detail = @idD, ID_OrderParts = @idOP Quantity = @quant, Price = @price where ID_DetailOfOrderParts = @idDofOP";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDofOP", id);
                        cmd.Parameters.AddWithValue("@idD", addDofOP.textBox2.Text);
                        cmd.Parameters.AddWithValue("@idOP", addDofOP.textBox3.Text);
                        cmd.Parameters.AddWithValue("@quant", addDofOP.textBox4.Text);
                        cmd.Parameters.AddWithValue("@price", addDofOP.textBox5.Text);

                        cmd.ExecuteNonQuery();
                        RefreshTable();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                {
                    return;
                }

                string sql = "Delete from DetailOfOrderParts where ID_DetailOfOrderParts = @id";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Object del");
                        RefreshTable();
                    }
                }
            }
        }
    }
}
