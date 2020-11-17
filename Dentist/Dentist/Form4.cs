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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        string imgLocation = "";
        
        string seq1 ="", seq2 = "";
        public static int id_medic;

        private bool IsNumber(string sequence)
        {
            for(int i = 0; i <= sequence.Length - 1; i ++)
            {
                if (sequence[i] < '0' || sequence[i] > '9')
                    return false;
            }
            return true;
        }

        private void deleteBeforeProgram(DateTime current_date)
        {
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand scm = new SqlCommand($"DELETE FROM Appointments where Id_medic = '{id_medic}' and AppDate < '{current_date}'", scn);
            scm.ExecuteNonQuery();

            scn.Close();
        }

        private void Enabledbuttons(int ok)
        {
            if (ok == 1)
            {
                change_photo.Enabled = false;
                show_appointment.Enabled = false;
                pacient_register.Enabled = false;
                show_allpacients.Enabled = false;
            }
            else
            {
                change_photo.Enabled = true;
                show_appointment.Enabled = true;
                pacient_register.Enabled = true;
                show_allpacients.Enabled = true;
            }

        }
        private void Clear()
        {
            last_namepacient.Clear();
            first_namepacient.Clear();
            cnp_pacient.Clear();
            adress_pacient.Clear();
            phone_pacient.Clear();
            age_pacient.Clear();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SqlConnection scn = new SqlConnection(connection);
            DateTime currentDate = DateTime.Today;
            TimeSpan ts = new TimeSpan(24, 0, 0);
            DateTime new_date = currentDate.Date + ts;
            scn.Open();
            string command = $"Select count (*) as cnt from Appointments where AppDate between '{currentDate}' and  '{new_date}'";
            SqlCommand command1 = new SqlCommand(command, scn);
            string message = command1.ExecuteScalar().ToString();
            if(message != "0")
            {
                MessageBox.Show("Astazi aveti " + message + " programari");

            }


            scn.Close();
            /*
             we create the reader from the database in order to show the doctors last name and first name
            */
            scn.Open();

            SqlCommand scm = new SqlCommand("Select last_name, first_name, id_medic, profile_image from Doctors where username = @username",scn);
            scm.Parameters.AddWithValue("@username", Form1.username);
            SqlDataReader dataReader = scm.ExecuteReader();

            while(dataReader.Read())
            {
                seq1 = dataReader.GetValue(0).ToString();
                seq2 = dataReader.GetValue(1).ToString();

                id_medic = Convert.ToInt32(dataReader.GetValue(2).ToString());

                if (dataReader.HasRows)
                {
                    byte[] images = ((byte[])dataReader.GetValue(3));

                    if (images == null)
                    {
                        doctor_picture.Image = Properties.Resources.default_user_image;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(images);
                        doctor_picture.Image = Image.FromStream(mstream);
                    }
                }
                else
                {
                    doctor_picture.Image = Properties.Resources.default_user_image;
                }
            }
            dataReader.Close();

            doctor_name.Text = "Dr. " + seq1 + " " + seq2;

            scn.Close();
            DateTime now = DateTime.Today;
            deleteBeforeProgram(now);
            timerAction.Start();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppointmentManager form7 = new AppointmentManager();
            form7.MdiParent = Form1.ActiveForm;
            form7.Location = new Point(0, 0);
            form7.Size = this.Size;
            form7.Show();
        }

        private void pacient_register_Click(object sender, EventArgs e)
        {
            Clear();
            Enabledbuttons(1);
            mypacients.Visible = false;
            activity_group.Visible = false;
            register_box.Visible = true;
        }

        private void backagain_Click(object sender, EventArgs e)
        {
            Enabledbuttons(2);
            activity_group.Visible = true;
            register_box.Visible = false;
            mypacients.Visible = false;
        }

        private void register_now_Click(object sender, EventArgs e)
        {


            if(last_namepacient.Text == "" || first_namepacient.Text == "" || cnp_pacient.Text == "" || adress_pacient.Text == "" || age_pacient.Text == "" || phone_pacient.Text == "")
            {
                MessageBox.Show("Completati toate campurile va rog!");
                return ;
            }

            if(IsNumber(cnp_pacient.Text) == false || IsNumber(phone_pacient.Text) == false || IsNumber(age_pacient.Text) == false)
            {
                MessageBox.Show("CNP-ul, varsta si numarul de telefon trebuie sa fie alcatuite doar din cifre!");
                return;
            }

            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            SqlCommand scm = new SqlCommand("insert into Pacients (last_name, first_name, CNP, adress, phone_number, age, id_medic) values (@last, @first, @cnp, @adress, @phone, @age, @medic)", scn);
            scm.Parameters.AddWithValue("@last", last_namepacient.Text);
            scm.Parameters.AddWithValue("@first", first_namepacient.Text);
            scm.Parameters.AddWithValue("@cnp", cnp_pacient.Text);
            scm.Parameters.AddWithValue("@adress", adress_pacient.Text);
            scm.Parameters.AddWithValue("@phone", phone_pacient.Text);
            scm.Parameters.AddWithValue("@age", Convert.ToInt64(age_pacient.Text));
            scm.Parameters.AddWithValue("@medic", id_medic);
            scm.ExecuteNonQuery();

            MessageBox.Show("Pacientul a fost inregistrat cu succes!");
            scn.Close();
            Clear();
            return;
        }

        private void show_allpacients_Click(object sender, EventArgs e)
        {
            Enabledbuttons(1);
            mypacients.Visible = true;
            activity_group.Visible = false;
            register_box.Visible = false;
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();

            SqlCommand scm = new SqlCommand("select * from Pacients where id_medic = @medic", scn);
            scm.Parameters.AddWithValue("@medic", id_medic);
            scm.ExecuteNonQuery();
            scm.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(scm);
            DataTable table = new DataTable();
            sda.Fill(table);
            mypacients_dgv.DataSource = table;


            scn.Close();
        }

        private void backshow_Click(object sender, EventArgs e)
        {
            Enabledbuttons(2);
            mypacients.Visible = false;
            activity_group.Visible = true;
            register_box.Visible = false;
        }
        int i = 0;
        private void timerAction_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            string sqlQuery = $"select * from PacientActions";
            SqlCommand scm = new SqlCommand(sqlQuery, scn);
            scm.CommandType = CommandType.Text;

            SqlDataAdapter sda = new SqlDataAdapter(scm);
            DataTable table = new DataTable();
            sda.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                
                if (row["show_case"].ToString() == "OFF")
                { 
                    string current_Row = "";

                    SqlConnection SCN = new SqlConnection(connection);
                    SCN.Open();
                    SqlCommand sqlCommand = new SqlCommand($"update PacientActions set show_case = '{"ON"}' where Id = '{Convert.ToInt32(row["Id"].ToString())}'", SCN);
                    sqlCommand.ExecuteNonQuery();
                    SCN.Close();

                    SCN.Open();
                    int doctorid = Convert.ToInt32(row["Id_medic"].ToString());
                    SqlCommand command = new SqlCommand($"select last_name, first_name from Doctors where id_medic = '{doctorid}'", scn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        current_Row = dataReader.GetValue(0).ToString() + " " + dataReader.GetValue(0).ToString();
                    }
                    dataReader.Close();
                    SCN.Close();
                    current_Row = current_Row + "; Actiune: " + row["Action"].ToString() + "; Pacient: " + row["Pacient_name"];
                Random rand = new Random();
                int a = rand.Next(1, 255);
                    int b = rand.Next(1, 255);
                int c = rand.Next(1, 255);
                Label lblMedic = new Label();
                    lblMedic.Name = $"lbl{i}";
                    lblMedic.Text = current_Row;
                    lblMedic.Dock = DockStyle.Top;
                    lblMedic.AutoEllipsis = true;
                    lblMedic.Font = new Font("Microsoft Sans Serif", 14);
                    lblMedic.AllowDrop = true;
                    lblMedic.ForeColor = Color.FromArgb(a, b, c);
                    activity_panel.Controls.Add(lblMedic);
                    i++;
                }
            }

            scn.Close();

        }
        public static int id_pacient;
        private void mypacients_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            id_pacient = Convert.ToInt32(mypacients_dgv.Rows[e.RowIndex].Cells[0].Value);

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
            Form10.ok = 2;
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void change_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                doctor_picture.ImageLocation = imgLocation;
              

                // we  now save the photo in the database

                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);

                SqlConnection scn = new SqlConnection(connection);
                scn.Open();
                SqlCommand scm = new SqlCommand("update Doctors set profile_image = @image where @id = id_medic", scn);
                scm.Parameters.AddWithValue("@image", images);
                scm.Parameters.AddWithValue("@id", id_medic);
                scm.ExecuteNonQuery();
                MessageBox.Show("Poza a fost schimbata cu succes!");


                scn.Close();
            }
        }
    }
}
