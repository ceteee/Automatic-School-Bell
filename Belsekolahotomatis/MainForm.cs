using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Media;
using System.Threading;

namespace Belsekolahotomatis
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        string _pathbel;
        public MainForm()
        {
            InitializeComponent();
            LoadData();
            LoadSuara();            
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataSet DS1 = new DataSet();
        private DataSet DS2 = new DataSet();
        private DataSet DS3 = new DataSet();
        private DataSet DS4 = new DataSet();
        private DataSet DS5 = new DataSet();
        private DataTable DT = new DataTable();
        private DataTable DT1 = new DataTable();
        private DataTable DT2 = new DataTable();
        private DataTable DT3 = new DataTable();
        private DataTable DT4 = new DataTable();
        private DataTable DT5 = new DataTable();

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Load += MainForm_Load;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            //suara

            //jam
            for (int i = 0; i < 2400; i += 100)
                for (int j = 0; j < 60; j++)
                {
                    comboBox2.Items.Add(string.Format("{0:0#:##}", i+j));
            }

        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=BellDB.db;version=3;New=False;Compress=True;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadBell()
        {
            DateTime currentTime = DateTime.Now;
            SetConnection();
            sql_con.Open();
            int IDhr = (int)DateTime.Now.DayOfWeek;
            if (IDhr == 1)
            {
                SQLiteCommand myCmd = new SQLiteCommand("SELECT Suara from Senin WHERE Jam = @JAM", sql_con);
            
                string Jam = fullClock();
                myCmd.Parameters.AddWithValue("@JAM", Jam);
                SQLiteDataReader Reader = null;

                Reader = myCmd.ExecuteReader();
           

            while (Reader.Read())
               {

                _pathbel = Reader["Suara"].ToString();
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = (@".\Sound\" + _pathbel);
                player.Play();
                Thread.Sleep(30000);

                }
            }
            if (IDhr == 2)
            {
                SQLiteCommand myCmd = new SQLiteCommand("SELECT Suara from Selasa WHERE Jam = @JAM", sql_con);

                string Jam = fullClock();
                myCmd.Parameters.AddWithValue("@JAM", Jam);
                SQLiteDataReader Reader = null;

                Reader = myCmd.ExecuteReader();


                while (Reader.Read())
                {

                    _pathbel = Reader["Suara"].ToString();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = (@".\Sound\" + _pathbel);
                    player.Play();
                    Thread.Sleep(30000);

                }
            }
            if (IDhr == 3)
            {
                SQLiteCommand myCmd = new SQLiteCommand("SELECT Suara from Rabu WHERE Jam = @JAM", sql_con);

                string Jam = fullClock();
                myCmd.Parameters.AddWithValue("@JAM", Jam);
                SQLiteDataReader Reader = null;

                Reader = myCmd.ExecuteReader();


                while (Reader.Read())
                {

                    _pathbel = Reader["Suara"].ToString();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = (@".\Sound\" + _pathbel);
                    player.Play();
                    Thread.Sleep(30000);

                }
            }
            if (IDhr == 4)
            {
                SQLiteCommand myCmd = new SQLiteCommand("SELECT Suara from Kamis WHERE Jam = @JAM", sql_con);

                string Jam = fullClock();
                myCmd.Parameters.AddWithValue("@JAM", Jam);
                SQLiteDataReader Reader = null;

                Reader = myCmd.ExecuteReader();


                while (Reader.Read())
                {

                    _pathbel = Reader["Suara"].ToString();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = (@".\Sound\" + _pathbel);
                    player.Play();
                    Thread.Sleep(30000);

                }
            }
            if (IDhr == 5)
            {
                SQLiteCommand myCmd = new SQLiteCommand("SELECT Suara from Jumat WHERE Jam = @JAM", sql_con);

                string Jam = fullClock();
                myCmd.Parameters.AddWithValue("@JAM", Jam);
                SQLiteDataReader Reader = null;

                Reader = myCmd.ExecuteReader();


                while (Reader.Read())
                {

                    _pathbel = Reader["Suara"].ToString();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = (@".\Sound\" + _pathbel);
                    player.Play();
                    Thread.Sleep(30000);

                }
            }
            if (IDhr == 6)
            {
                SQLiteCommand myCmd = new SQLiteCommand("SELECT Suara from Sabtu WHERE Jam = @JAM", sql_con);

                string Jam = fullClock();
                myCmd.Parameters.AddWithValue("@JAM", Jam);
                SQLiteDataReader Reader = null;

                Reader = myCmd.ExecuteReader();


                while (Reader.Read())
                {

                    _pathbel = Reader["Suara"].ToString();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = (@".\Sound\" + _pathbel);
                    player.Play();
                    Thread.Sleep(30000);

                }
            }
        }
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Senin" ;
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT= DS.Tables[0];
            dataGridView1.DataSource = DT;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 50;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 200;
            DataGridViewColumn column17 = dataGridView1.Columns[2];
            column17.Width = 150;


            sql_cmd = sql_con.CreateCommand();
            string CommandText1 = "select * from Selasa";
            DB = new SQLiteDataAdapter(CommandText1, sql_con);
            DS1.Reset();
            DB.Fill(DS1);
            DT1 = DS1.Tables[0];
            dataGridView2.DataSource = DT1;
            DataGridViewColumn column2 = dataGridView2.Columns[0];
            column2.Width = 50;
            DataGridViewColumn column3 = dataGridView2.Columns[1];
            column3.Width = 200;
            DataGridViewColumn column16 = dataGridView2.Columns[2];
            column16.Width = 150;

            sql_cmd = sql_con.CreateCommand();
            string CommandText2 = "select * from Rabu";
            DB = new SQLiteDataAdapter(CommandText2, sql_con);
            DS2.Reset();
            DB.Fill(DS2);
            DT2 = DS2.Tables[0];
            dataGridView3.DataSource = DT2;
            DataGridViewColumn column4 = dataGridView3.Columns[0];
            column4.Width = 50;
            DataGridViewColumn column5 = dataGridView3.Columns[1];
            column5.Width = 200;
            DataGridViewColumn column15 = dataGridView3.Columns[2];
            column15.Width = 150;

            sql_cmd = sql_con.CreateCommand();
            string CommandText3 = "select * from Kamis";
            DB = new SQLiteDataAdapter(CommandText3, sql_con);
            DS3.Reset();
            DB.Fill(DS3);
            DT3 = DS3.Tables[0];
            dataGridView4.DataSource = DT3;
            DataGridViewColumn column6 = dataGridView4.Columns[0];
            column6.Width = 50;
            DataGridViewColumn column7 = dataGridView4.Columns[1];
            column7.Width = 200;
            DataGridViewColumn column14 = dataGridView4.Columns[2];
            column14.Width = 150;

            sql_cmd = sql_con.CreateCommand();
            string CommandText4 = "select * from Jumat";
            DB = new SQLiteDataAdapter(CommandText4, sql_con);
            DS4.Reset();
            DB.Fill(DS4);
            DT4 = DS4.Tables[0];
            dataGridView5.DataSource = DT4;
            DataGridViewColumn column8 = dataGridView5.Columns[0];
            column8.Width = 50;
            DataGridViewColumn column9 = dataGridView5.Columns[1];
            column9.Width = 200;
            DataGridViewColumn column13 = dataGridView5.Columns[2];
            column13.Width = 150;

            sql_cmd = sql_con.CreateCommand();
            string CommandText5 = "select * from Sabtu";
            DB = new SQLiteDataAdapter(CommandText5, sql_con);
            DS5.Reset();
            DB.Fill(DS5);
            DT5 = DS5.Tables[0];
            dataGridView6.DataSource = DT5;
            sql_con.Close();
            DataGridViewColumn column10 = dataGridView6.Columns[0];
            column10.Width = 50;
            DataGridViewColumn column11 = dataGridView6.Columns[1];
            column11.Width = 200;
            DataGridViewColumn column12 = dataGridView6.Columns[2];
            column12.Width = 150;


        }

        public void LoadSuara()
        {
            comboBox3.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(@".\Sound\");
            FileInfo[] Files = dinfo.GetFiles("*.wav");
            foreach (FileInfo file in Files)
            {

                comboBox3.Items.Add(file.Name);

            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string da = DateTime.Now.ToString("dddd");
            Dictionary<string, string> harii = new Dictionary<string, string>();

            harii.Add("Monday", "Senin");
            harii.Add("Tuesday", "Selasa");
            harii.Add("Wednesday", "Rabu");
            harii.Add("Thursday", "Kamis");
            harii.Add("Friday", "Jum'at");
            harii.Add("Saturday", "Sabtu");
            harii.Add("Sunday", "Minggu");

            harii.Add("Senin", "Senin");
            harii.Add("Selasa", "Selasa");
            harii.Add("Rabu", "Rabu");
            harii.Add("Kamis", "Kamis");
            harii.Add("Jumat", "Jum'at");
            harii.Add("Sabtu", "Sabtu");
            harii.Add("Minggu", "Minggu");
            string indo = harii[da];
            string time = ""; 
            if(hh<10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if(mm<10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;

            }
            else
            {
                time += ss;

            }
            waktus.Text = time;
            hari.Text = indo;
            LoadBell();
        }

        private void tambahs_Click(object sender, EventArgs e)
        {
            addsound form2 = new addsound();
            form2.Show();

        }
        
        //add
        private void button6_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into "+comboBox1.Text+" (Jam,Deskripsi,Suara)values('" + comboBox2.Text + "','" + textBox1.Text + "','" + comboBox3.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "update "+comboBox1.Text+" set Deskripsi='" + textBox1.Text + "', Suara='" + comboBox3.Text + "' where Jam='" + comboBox2.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }


        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from "+comboBox1.Text+" Where Jam='"+comboBox2.Text+"'";
            ExecuteQuery(txtQuery);
            LoadData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
 
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            LoadSuara();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            comboBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            comboBox2.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            comboBox2.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            comboBox2.Text = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView5.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            comboBox2.Text = dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView6.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView6.Rows[e.RowIndex].Cells[2].Value.ToString();
        }




        private string fullClock()
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }


            return time;
        }



    }
}
