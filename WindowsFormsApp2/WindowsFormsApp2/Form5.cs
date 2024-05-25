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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEkzDataSet.DetailOfEquipment". При необходимости она может быть перемещена или удалена.
            this.detailOfEquipmentTableAdapter.Fill(this.demoEkzDataSet.DetailOfEquipment);
            RefreshTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDetOfEquip addDofE = new AddDetOfEquip();
            DialogResult result = addDofE.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            string sql = "Insert into DetailOfEquipment (ID_DetailOfExecutor, ID_Detail, Quantity, Date, ID_Equipment) values (@idDofE, @idD, @quantity, @date, @idE)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idDofE", addDofE.textBox1.Text);
                        command.Parameters.AddWithValue("@idD", addDofE.textBox2.Text);
                        command.Parameters.AddWithValue("@quantity", addDofE.textBox3.Text);
                        command.Parameters.AddWithValue("@date", addDofE.dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@idE", addDofE.textBox5.Text);

                        command.ExecuteNonQuery();
                        RefreshTable();
                    }
                }
            }
        }
        private void RefreshTable()
        {
            string sql = "Select * from DetailOfEquipment";
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

                AddDetOfEquip addDofE = new AddDetOfEquip();
                DialogResult result = addDofE.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                string sql = "Update Deta set ID_DetailOfExecutor = @idDofE, ID_Detail = @idD, Quantity = @quant, Date = @date, ID_Equipment = @idE where ID_DetailOfExecutor = @idDofE";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDofE", id);
                        cmd.Parameters.AddWithValue("@idD", addDofE.textBox2.Text);
                        cmd.Parameters.AddWithValue("@quant", addDofE.textBox3.Text);
                        cmd.Parameters.AddWithValue("@date", addDofE.dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@idE", addDofE.textBox5.Text);

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

                string sql = "Delete from DetailOfEquipment where ID_DetailOfEquipment = @id";
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
