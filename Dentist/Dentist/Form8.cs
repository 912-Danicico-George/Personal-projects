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
using System.IO;


namespace Dentist
{
    public partial class frmManageAppointment : Form
    {
        public frmManageAppointment()
        {
            InitializeComponent();
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        public static string name1 = "", phone1 = "", comments1 = "";
        public static DateTime new_date ;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsNumber(string number)
        {
            for(int i = 0; i <= number.Length - 1; i++)
            {
                if(number[i] < '0' || number[i] > '9')
                {
                    MessageBox.Show("Va rog sa folositi un numar de telefon valid");
                    return false;
                }
            }
            return true;
        }

        private bool ValidHour(string hour)
        {
            string[] hours = hour.Split(':');
            if (hours.Length == 1 || hours.Length > 2)
                return false;

            if (hours[1].Length != 2)
                return false;
            else
            {
                if (IsNumber(hours[0]) == false)
                    return false;
                else
                {
                    if (Convert.ToInt32(hours[0]) <= 7 || Convert.ToInt32(hours[0]) > 18)
                        return false;
                }

                if (IsNumber(hours[1]) == false)
                    return false;
                else
                {
                    if (Convert.ToInt32(hours[1]) <= 0 || Convert.ToInt32(hours[1]) > 60)
                        return false;
                }
            }

            return true;
        }

        private void frmManageAppointment_Load(object sender, EventArgs e)
        {
            programmingTime.Value = new_date;
        }

        private void Clear()
        {
            txtHour.Clear();
            name.Clear();
            phone.Clear();
            comments.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(name.Text == "" || phone.Text == "" || comments.Text == "" || txtHour.Text == "")
            {
                MessageBox.Show("Va rog completati toate campurile");
                return;
            }

            if (IsNumber(phone.Text) == false)
            {
                MessageBox.Show("Va rog sa introduceti un numar de telefon valid!");
                return;
            }
         
            if(ValidHour(txtHour.Text) == false)
            {
                MessageBox.Show("Va rog sa introduceti o ora valida");
                return;
            }

            SqlConnection scn = new SqlConnection(connection);
            scn.Open(); 
            SqlCommand scm = new SqlCommand("select count (*) as cnt from Pacients where @lname = last_name and @fname = first_name and @phone = phone_number", scn);
            scm.Parameters.AddWithValue("@phone", Convert.ToInt32(phone.Text));

            // we convert the name string into last_name and first_name
            string[] names = name.Text.Split(' ');
            
            if(names.Length < 2)
            {
                Clear();
                MessageBox.Show("Pacientul trebuie sa fie inregistrat!");
                scn.Close();
                return;
            }

            scm.Parameters.AddWithValue("@lname", names[0]);
            scm.Parameters.AddWithValue("@fname", names[1]);
            if(scm.ExecuteScalar().ToString() == "1")
            {
                name1 = name.Text;
                phone1 = phone.Text;
                comments1 = comments.Text;
                new_date = programmingTime.Value;

                string[] hours = txtHour.Text.Split(':');
                TimeSpan ts = new TimeSpan(Convert.ToInt32(hours[0]), Convert.ToInt32(hours[1]), 0);
                new_date = new_date.Date + ts;
                SqlConnection sqlConnection = new SqlConnection(connection);
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand($"select count(*) as cnt from Appointments where Id_medic = '{Form4.id_medic}' and AppDate = '{new_date}' ",sqlConnection);
                if(sqlCommand.ExecuteScalar().ToString() != "0")
                {
                    MessageBox.Show("Nu puteti programa 2 sedinte la aceiasi ora");
                    return;
                }


                sqlConnection.Close();


                
                Form1.Check = 1;
                Form9 form9 = new Form9();
                form9.ShowDialog();

                
                Clear();
                scn.Close();
                return;

            }
            else
            {
                MessageBox.Show("Pacientul trebuie sa fie inregistrat!");
                scn.Close();
                return;
            }
            
            
          


        }
    }
}
