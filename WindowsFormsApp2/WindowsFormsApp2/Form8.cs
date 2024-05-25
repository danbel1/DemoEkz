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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.OrderParts". При необходимости она может быть перемещена или удалена.
            this.orderPartsTableAdapter.Fill(this.demoEkzDataSet.OrderParts);
            RefreshTable();
        }
        private void RefreshTable()
        {
            string sql = "Select * from OrderParts";
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
            AddOrderParts addOP = new AddOrderParts();
            DialogResult result = addOP.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into OrderParts (ID_OrderParts, Date, ID_Application, ID_Executor, Comments) values (@idOP, ,@date, @idA, @idEx, @comm)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idOP", addOP.textBox1.Text);
                        command.Parameters.AddWithValue("@date", addOP.dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@idA", addOP.textBox2.Text);
                        command.Parameters.AddWithValue("@idEx", addOP.textBox3.Text);
                        command.Parameters.AddWithValue("@comm", addOP.textBox5.Text);

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

                AddOrderParts addOP = new AddOrderParts();
                DialogResult result = addOP.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Deta set ID_OrderParts = @idOP, ID_Detail = @idD, ID_Application = @idA, ID_Executor = @idEx Comments = @comm, where ID_OrderParts = @idOP";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idOP", id);
                        cmd.Parameters.AddWithValue("@date", addOP.dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@idA", addOP.textBox2.Text);
                        cmd.Parameters.AddWithValue("@idEx", addOP.textBox3.Text);
                        cmd.Parameters.AddWithValue("@comm", addOP.textBox5.Text);

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

                string sql = "Delete from OrderParts where ID_OrderParts = @id";
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
