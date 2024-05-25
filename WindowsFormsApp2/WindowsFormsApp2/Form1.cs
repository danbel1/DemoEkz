using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void requestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.demoEkzDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Request". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.demoEkzDataSet.Client);
            RefreshTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            DialogResult result = frm2.ShowDialog(this);

            if(result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into Client (ID_Client, Name, Surname) values (@idC, @Name, @Surname)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idC", frm2.textBox1.Text);
                        command.Parameters.AddWithValue("@Name", frm2.textBox2.Text);
                        command.Parameters.AddWithValue("@Surname", frm2.textBox3.Text);

                        command.ExecuteNonQuery();
                        RefreshTable();
                    }
                }
            }
        }

        private void RefreshTable()
        {
            string sql = "Select * from Client";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand( sql, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter (command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

                string sql = "Delete from Client where ID_Client = @id";
                using(SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand( sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Object del");
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

                Form2 frm2 = new Form2();
                DialogResult result = frm2.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Client set ID_Client = @id, Name = @Name, Surname = @Surname where ID_Client = @id";
                using(SqlConnection conn  = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand( sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Name", frm2.textBox2.Text);
                        cmd.Parameters.AddWithValue("@Surname", frm2.textBox3.Text);

                        cmd.ExecuteNonQuery();
                        RefreshTable();
                    }
                }

                
            }
        }
    }
}
