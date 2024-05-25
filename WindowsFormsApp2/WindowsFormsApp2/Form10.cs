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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.demoEkzDataSet.Status);
            RefreshTable();
        }
        private void RefreshTable()
        {
            string sql = "Select * from Status";
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
            AddStatus addS = new AddStatus();
            DialogResult result = addS.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into Status (ID_Status, Status_Application) values (@idS, @status)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@ids", addS.textBox1.Text);
                        command.Parameters.AddWithValue("@status", addS.textBox2.Text);


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

                AddStatus addS = new AddStatus();
                DialogResult result = addS.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Status set ID_Status = @id, Status_Application = @status where ID_Status = @id";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@status", addS.textBox2.Text);

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

                string sql = "Delete from Status where ID_Status = @id";
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
