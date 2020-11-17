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

namespace Dentist
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand scm = new SqlCommand("select * from Pacients", scn);
            scm.ExecuteNonQuery();
            scm.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(scm);
            DataTable table = new DataTable();
            sda.Fill(table);
            mypacients_dgv.DataSource = table;


            scn.Close();
        }

        private void mypacients_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int id_pacient = Convert.ToInt32(mypacients_dgv.Rows[e.RowIndex].Cells[0].Value);

            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand scm = new SqlCommand($"select last_name, first_name, adress, phone_number from Pacients where Id = '{id_pacient}'", scn);
            SqlDataReader dataReader = scm.ExecuteReader();
            dataReader.Read();

            Form10.name = dataReader.GetValue(0).ToString() + " " + dataReader.GetValue(1).ToString();
            Form10.adress = dataReader.GetValue(2).ToString();
            Form10.phone = dataReader.GetValue(3).ToString();

            dataReader.Close();

            scn.Close();
            Form10.ok = 3;
            Form10 form10 = new Form10();
            form10.ShowDialog();

        }
    }
}
