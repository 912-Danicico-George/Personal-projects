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
    public partial class AppointmentManager : Form
    {
        public AppointmentManager()
        {
            InitializeComponent();
        }
        string connection = Properties.Settings.Default.Cico_DatabaseConnectionString;
        public static int link_tag = 0;
        List<FlowLayoutPanel> listFlDay = new List<FlowLayoutPanel>();
        DateTime currentDate = DateTime.Today; 
        private void GenerateDayPanel(int totalDays)
        {
            flDays.Controls.Clear();
            listFlDay.Clear();
            for(int i = 1; i <= totalDays; i++)
            {
                FlowLayoutPanel fl = new FlowLayoutPanel();
                fl.Name = $"flDay{i}";
                fl.Size = new Size(170, 143);
                fl.BackColor = Color.NavajoWhite;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fl.Cursor = Cursors.Hand;
                fl.AutoScroll = true;
                fl.Click += new EventHandler( AddNewAppointment);
                flDays.Controls.Add(fl);
                listFlDay.Add(fl);

            }
        }

        private void AddNewAppointment(object sender, EventArgs e)
        {
            FlowLayoutPanel flow = sender as FlowLayoutPanel;
            
            int day = Convert.ToInt32(flow.Tag);
            
            if (day != 0)
            {
                frmManageAppointment.new_date = new DateTime(currentDate.Year, currentDate.Month, day);
                if(frmManageAppointment.new_date <= DateTime.Today)
                {
                    MessageBox.Show("Va rog sa folositi o data valida!");
                    return;
                }
                frmManageAppointment form8 = new frmManageAppointment();
                form8.ShowDialog();
                DisplayCurrentDate();
            }

        }
        
        private void AddAppointmentToFlDay(int startDayAtFlNumber)
        {
            DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            string sqlQuery = $"select * from Appointments where Id_medic = {Form4.id_medic} and AppDate between '{startDate.ToShortDateString()}' and '{endDate.ToShortDateString()}'";
            DataTable dt = QueryAsDataTable(sqlQuery);

           
            foreach ( DataRow row in dt.Rows)
            {
                DateTime appDay = DateTime.Parse(row["AppDate"].ToString());
                LinkLabel link = new LinkLabel();
                link.Name = $"link{row["Id"]}";
                link.Tag = row["Id"];
                link.Text = row["ContactName"].ToString();
                link.Click += new EventHandler(ShowAppointmentDetail);
                listFlDay[appDay.Day - 1+ (startDayAtFlNumber - 1)].Controls.Add(link);

            }

        }

        private DataTable QueryAsDataTable(string sqlQuery)
        {
            SqlConnection scn = new SqlConnection(connection);
            scn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, scn);
            DataSet ds = new DataSet();            

            sda.Fill(ds, "result");
            return ds.Tables["result"];
        }

        private void DisplayCurrentDate()
        {
            lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();
            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
            AddAppointmentToFlDay(firstDayAtFlNumber);
        }

        private void ShowAppointmentDetail(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            int appID = Convert.ToInt32(link.Tag);
            link_tag = appID;
            string sqlQuery = $"select * from Appointments where Id = {appID}";
            DataTable dt = QueryAsDataTable(sqlQuery);

            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Form10.name = row["ContactName"].ToString();
                Form10.comment = row["Comment"].ToString();
                Form10.phone = row["Phone"].ToString();
                Form10.data = row["AppDate"].ToString();
                Form10.ok = 1;

                Form10 form10 = new Form10();
                form10.ShowDialog();
                DisplayCurrentDate();
            }
            
            
        }


        private void AddLabelDayToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {

            foreach (FlowLayoutPanel fl in listFlDay)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
            }
            
            for(int i = 1; i <= totalDaysInMonth ; i++)
            {
                Label lbl = new Label();
                lbl.Name = $"lblDay{i}";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.TopRight;
                lbl.Size = new Size(125, 22);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);
            }
        }


        private void nextMonth()
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }

        private void prevMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void Today()
        {
            currentDate = DateTime.Today;
            DisplayCurrentDate();

        }

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek + 1);
        }

        private int GetTotalDaysOfCurrentDate()
        {
            DateTime firstDayOfCurrentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day;
        }

        private void AppointmentManager_Load(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            GenerateDayPanel(42);
            DisplayCurrentDate();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previous_month_Click(object sender, EventArgs e)
        {
            prevMonth();
        }

        private void next_month_Click(object sender, EventArgs e)
        {
            nextMonth();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            Today();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentManager form7 = new AppointmentManager();
            form7.MdiParent = Form1.ActiveForm;
            form7.Location = new Point(0, 0);
            form7.Size = this.Size;
            form7.Show();
        }
    }
}
