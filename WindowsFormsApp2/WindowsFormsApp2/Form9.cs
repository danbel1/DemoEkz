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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.demoEkzDataSet.Request);
            RefreshTable();

        }
        private void RefreshTable()
        {
            string sql = "Select * from Request";
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
            AddRequest addR = new AddRequest();
            DialogResult result = addR.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into Request (ID_Application, ID_Status, ID_Equipment, ID_Client, ID_Executor, Serial_Number, Priority, Date) values (@idR, ,@idS, @idEq, @idC, , @idEx, @serNum, @priority, @date)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idA", addR.textBox1.Text);
                        command.Parameters.AddWithValue("@idS", addR.textBox2.Text);
                        command.Parameters.AddWithValue("@idEq", addR.textBox3.Text);
                        command.Parameters.AddWithValue("@idC", addR.textBox4.Text);
                        command.Parameters.AddWithValue("@idEx", addR.textBox5.Text);
                        command.Parameters.AddWithValue("@serNum", addR.textBox6.Text);
                        command.Parameters.AddWithValue("@priority", addR.textBox7.Text);
                        command.Parameters.AddWithValue("@date", addR.dateTimePicker1.Value);

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

                AddRequest addR = new AddRequest();
                DialogResult result = addR.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Deta set ID_Application = @idA, ID_Status = @idS, ID_Equipment = @idEq, ID_Client = @idC, ID_Executor = @idEx Serial_Number = @serNum, Priority = @priority, Date = @date, where ID_Application = @idA";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idA", id);
                        cmd.Parameters.AddWithValue("@idS", addR.textBox2.Text);
                        cmd.Parameters.AddWithValue("@idEq", addR.textBox3.Text);
                        cmd.Parameters.AddWithValue("@idC", addR.textBox4.Text);
                        cmd.Parameters.AddWithValue("@idEx", addR.textBox5.Text);
                        cmd.Parameters.AddWithValue("@serNum", addR.textBox6.Text);
                        cmd.Parameters.AddWithValue("@priority", addR.textBox7.Text);
                        cmd.Parameters.AddWithValue("@date", addR.dateTimePicker1.Value);

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

                string sql = "Delete from Request where ID_Application = @id";
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
