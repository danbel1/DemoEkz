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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.demoEkzDataSet.Equipment);
            RefreshTable();
        }

        private void RefreshTable()
        {
            string sql = "Select * from Equipment";
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
            AddEquipment addEq = new AddEquipment();
            DialogResult result = addEq.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into Equipment (ID_Equipment, Name_Equipment, Type_Malfucation, Description_Problem) values (@idEq, @NameEq, @TypeM, @DePrblm)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idEq", addEq.textBox1.Text);
                        command.Parameters.AddWithValue("@NameEq", addEq.textBox2.Text);
                        command.Parameters.AddWithValue("@TypeM", addEq.textBox3.Text);
                        command.Parameters.AddWithValue("@DePrblm", addEq.textBox4.Text);

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

                AddEquipment addEq = new AddEquipment();
                DialogResult result = addEq.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Equipment set Equipment = @id, Name_Equipment = @NameEq, Type_Malfucation = @TypeM, Description_Problem = @DesPrblm  where ID_Equipment = @id";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@NameEq", addEq.textBox2.Text);
                        cmd.Parameters.AddWithValue("@TypeM", addEq.textBox3.Text);
                        cmd.Parameters.AddWithValue("@DesPrblm", addEq.textBox4.Text);

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

                string sql = "Delete from Equipment where ID_Equipment = @id";
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
