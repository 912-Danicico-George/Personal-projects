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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        private void btnYes_Click(object sender, EventArgs e)
        {
            Form10.IsTrue = 1;
            if (Form1.Check == 1)
            {
                SqlConnection scn = new SqlConnection(connection);
                scn.Open();
                SqlCommand command = new SqlCommand("insert into Appointments (AppDate, ContactName, Phone, Comment, Id_medic) values (@date, @name, @phone, @comment, @medic)", scn);
                command.Parameters.AddWithValue("@date", frmManageAppointment.new_date);
                command.Parameters.AddWithValue("@name", frmManageAppointment.name1);
                command.Parameters.AddWithValue("@phone", frmManageAppointment.phone1);
                command.Parameters.AddWithValue("@comment", frmManageAppointment.comments1);
                command.Parameters.AddWithValue("@medic", Form4.id_medic);
                command.ExecuteNonQuery();
                MessageBox.Show("Programarea a fost realizata!");
                Form1.Check = 0;
                scn.Close();
            }

            if(Form1.Check == 2)
            {
                SqlConnection scn = new SqlConnection(connection);
                scn.Open();
                SqlCommand scm = new SqlCommand("insert into PacientActions (Id_medic, AppDate, Action, Price, Pacient_name, show_case) values (@idmedic, @date, @action, @price, @name, @show)", scn);
                scm.Parameters.AddWithValue("@idmedic", Form4.id_medic);
                scm.Parameters.AddWithValue("@date", DateTime.Today);
                scm.Parameters.AddWithValue("@action", Form10.comment);
                scm.Parameters.AddWithValue("@price", Form10.price);
                scm.Parameters.AddWithValue("@name", Form10.name);
                scm.Parameters.AddWithValue("@show", "OFF");

                scm.ExecuteNonQuery();
                MessageBox.Show("Consultatia s-a terminat!");
                Form1.Check = 0;

                scn.Close();

                scn.Open();
                SqlCommand command = new SqlCommand($"delete from Appointments where Id = {AppointmentManager.link_tag}", scn);
                command.ExecuteNonQuery();
                scn.Close();
            }

            if(Form1.Check == 3)
            {
                SqlConnection scn = new SqlConnection(connection);
                scn.Open();
                SqlCommand command = new SqlCommand($"delete from Appointments where Id = {AppointmentManager.link_tag}", scn);
                command.ExecuteNonQuery();
                scn.Close();
            }
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Form10.IsTrue = 0;
            Form1.Check = 0;
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if(Form1.Check == 1)
            {
                lblQuestion.Text = "Sunteti sigur ca doriti sa salvati?";
            }
            else
            {
                if (Form1.Check == 2)
                {
                    lblQuestion.Text = "Sunteti sigur ca ati terminat consultul?";
                }
                else
                {
                    lblQuestion.Text = "Sunteti sigur ca doriti sa stergeti programarea?";
                }
            }
        }
    }
}
