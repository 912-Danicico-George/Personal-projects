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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        string imgLocation = "";
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        public static int ok = 0, price = 0, IsTrue = 0;
        // ok is 1 or 2 when the medic is logged in the account and 3 if the administrator connects

        public static string name = "", phone = "", comment = "", adress = "", data = "";
        int id_pacient;
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime current_Date = DateTime.Now;
            lblDate.Text = Convert.ToString(current_Date);
        }

        private void btnUploadRad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                // we  now save the photo in the database

                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);

                SqlConnection scn = new SqlConnection(connection);
                scn.Open();
                SqlCommand scm = new SqlCommand("update Pacients set radiography = @image where Id = @id", scn);
                scm.Parameters.AddWithValue("@image", images);
                scm.Parameters.AddWithValue("@id", id_pacient);
                
                scm.ExecuteNonQuery();
                MessageBox.Show("Poza a fost schimbata cu succes!");


                scn.Close();
            }
        }
        public static Image pacient_radiography;
        private void btnShowRad_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand SCM = new SqlCommand($"select radiography from Pacients where Id = '{id_pacient}'", scn);
            SqlDataReader dataReader = SCM.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                if(dataReader.GetValue(0).ToString() == "")
                {
                    MessageBox.Show("Nu exista nici o radiografie a pacientului!");
                    return;
                }
                byte[] radiography = (byte[])dataReader.GetValue(0);
                if (radiography == null)
                {
                    MessageBox.Show("Nu exista nici o radiografie a pacientului!");
                    return;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(radiography);
                    pacient_radiography = Image.FromStream(ms);
                    Form5 form5 = new Form5();
                    form5.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nu exista nici o radiografie a pacientului!");
                return;
            }
            scn.Close();
        }

        private void dataFutureProgramation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Convert.ToString(dataFutureProgramation.Rows[e.RowIndex].Cells[1].Value) != "")
            {
                if(ok == 2)
                {
                    lblProgramare.Visible = true;
                    currentSchedule.Visible = true;
                }
                
         

                pacientProblems.Text = Convert.ToString(dataFutureProgramation.Rows[e.RowIndex].Cells[2].Value);
                DateTime hour = Convert.ToDateTime(dataFutureProgramation.Rows[e.RowIndex].Cells[1].Value);

                if (Convert.ToInt32(hour.Hour) < 10)
                {
                    lblHour.Text = "0" + Convert.ToString(hour.Hour) + ":";
                }
                else
                {
                    lblHour.Text = Convert.ToString(hour.Hour) + ":";
                }

                if (Convert.ToInt32(hour.Minute) < 10)
                {
                    lblHour.Text += "0" + Convert.ToString(hour.Minute);
                }
                else
                {
                    lblHour.Text += Convert.ToString(hour.Minute);
                }

                SqlConnection con = new SqlConnection(connection);
                con.Open();

                string sqlCommand = $"select * from Appointments where ContactName = '{name}' and Phone = '{phone}' and AppDate != '{hour}'";
                

                SqlCommand cmd = new SqlCommand(sqlCommand, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);

                dataFutureProgramation.DataSource = table;

                con.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand Command = new SqlCommand("select * from PacientActions where id_medic = @idmedic", scn);
            Command.Parameters.AddWithValue("@idmedic", Form4.id_medic);
            Command.ExecuteNonQuery();
            Command.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(Command);

            DataTable table = new DataTable();
            sda.Fill(table);
            pacientHistory.DataSource = table;


            scn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pacientProblems.Text == "<pacient problems>")
            {
                MessageBox.Show("Nu ati selectat nici o programare");
                return;
            }
            Form1.Check = 3;
            Form9 form9 = new Form9();
            form9.ShowDialog();
            if(IsTrue == 1)
            {
                IsTrue = 0;
                txtPrice.Clear();
                pacientProblems.Text = "<pacient problems>";
                txtPrice.Clear();
            }
        }

        private bool IsNumber(string number)
        {
            for(int i = 0; i <= number.Length - 1; i++)
            {
                if(number[i] < '0' || number[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if(pacientProblems.Text == "<pacient problems>")
            {
                MessageBox.Show("Nu ati selectat nici o programare");
                return;
            }
            if(txtPrice.Text == "")
            {
                MessageBox.Show("Va rog introduceti un pret!");
                return;
            }

            if(IsNumber(txtPrice.Text) == false)
            {
                MessageBox.Show("Pretul trebuie sa fie alcatuit doar din cifre!");
                return;
            }
            Form1.Check = 2;
            comment = pacientProblems.Text;
            price = Convert.ToInt32(txtPrice.Text);

            Form9 form9 = new Form9();
            form9.ShowDialog();
            if (IsTrue == 1)
            {
                txtPrice.Clear();
                pacientProblems.Text = "<pacient problems>";
                lblHour.Text = "<hour>";
                txtPrice.Clear();
                IsTrue = 0;
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            timer2.Start();
            DateTime currentDate = DateTime.Now;
            lblDate.Text = currentDate.ToString();
            if(ok == 1 || ok == 2)
            {
                btnShowRad.Visible = true;
                btnUploadRad.Visible = true;
            }
            else
            {
                btnShowRad.Visible = false;
                btnUploadRad.Visible = false;
            }

            timer1.Start();
            if(ok == 2)
            {
                SqlConnection con = new SqlConnection(connection);
                string sqlCommand = $"select * from Appointments where ContactName = '{name}' and Phone = '{phone}'";
                SqlCommand cmd = new SqlCommand(sqlCommand, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);
                dataFutureProgramation.DataSource = table;

                con.Close();
            }


            if(ok == 1)
            {
                DateTime hour = Convert.ToDateTime(data);
                if (Convert.ToInt32(hour.Hour) < 10)
                {
                    lblHour.Text = "0" + Convert.ToString(hour.Hour) + ":";
                }
                else
                {
                    lblHour.Text = Convert.ToString(hour.Hour) + ":";
                }

                if (Convert.ToInt32(hour.Minute) < 10)
                {
                    lblHour.Text += "0" + Convert.ToString(hour.Minute);
                }
                else
                {
                    lblHour.Text += Convert.ToString(hour.Minute);
                }

                lblProgramare.Visible = true;
                currentSchedule.Visible = true;
                /*SqlConnection SCN = new SqlConnection(connection);
                SCN.Open();
                SqlCommand SCM = new SqlCommand("select AppDate from Appointments where Id = @id", SCN);
                SCM.Parameters.AddWithValue("@Id", AppointmentManager.link_tag );
                SCM.ExecuteNonQuery();

                SqlDataReader DataReader = SCM.ExecuteReader();
                
                SCN.Close();
                */
                SqlConnection con = new SqlConnection(connection);
                con.Open();

                currentDate = hour;
                string sqlCommand = $"select * from Appointments where ContactName = '{name}' and Phone = '{phone}' and AppDate != '{currentDate}'";
                SqlCommand cmd = new SqlCommand(sqlCommand, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);
                dataFutureProgramation.DataSource = table;

                con.Close();

            }
            pacientName.Text = name;
            pacientPhone.Text = phone;
            pacientAdress.Text = adress;
            pacientProblems.Text = comment;
            pacientProblems.Font = new Font("Microsoft Sans Serif", 16);
            pacientProblems.ForeColor = Color.FromArgb(255, 128, 0);

            string[] names = name.Split(' ');
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            SqlCommand scm = new SqlCommand("select age, adress, Id from Pacients where last_name = @lname and first_name = @fname and phone_number = @number", scn);
            scm.Parameters.AddWithValue("@lname", names[0]);
            scm.Parameters.AddWithValue("@fname", names[1]);
            scm.Parameters.AddWithValue("@number", phone);

            SqlDataReader dataReader = scm.ExecuteReader();
            while(dataReader.Read())
            {
                 pacientAge.Text= dataReader.GetValue(0).ToString() + " ani";
                 pacientAdress.Text = dataReader.GetValue(1).ToString();
                 id_pacient = Convert.ToInt32(dataReader.GetValue(2).ToString());
            }
            scn.Close();
        }
    }
}
