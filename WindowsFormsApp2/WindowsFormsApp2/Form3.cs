using System;
using System.CodeDom.Compiler;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.demoEkzDataSet.Executor);
            RefreshTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExecutor addEx = new AddExecutor ();
            DialogResult result = addEx.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into Executor (ID_Executor, Name, Surname) values (@idE, @Name, @Surname)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idE", addEx.textBox1.Text);
                        command.Parameters.AddWithValue("@Name", addEx.textBox2.Text);
                        command.Parameters.AddWithValue("@Surname", addEx.textBox3.Text);

                        command.ExecuteNonQuery();
                        RefreshTable();
                    }
                }
            }
        }
        private void RefreshTable()
        {
            string sql = "Select * from Executor";
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

                AddExecutor addEx = new AddExecutor();
                DialogResult result = addEx.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Executor set ID_Executor = @id, Name = @Name, Surname = @Surname where ID_Executor = @id";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Name", addEx.textBox2.Text);
                        cmd.Parameters.AddWithValue("@Surname", addEx.textBox3.Text);

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

                string sql = "Delete from Executor where ID_Executor = @id";
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
