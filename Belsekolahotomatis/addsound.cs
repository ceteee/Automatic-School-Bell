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
using System.Media;

namespace Belsekolahotomatis
{
    public partial class addsound : Form
    {
        public addsound()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            lists.Items.Clear();

            DirectoryInfo dinfo = new DirectoryInfo(@".\Sound\");
            FileInfo[] Files = dinfo.GetFiles("*.wav") ;
            foreach (FileInfo file in Files)
            {
                lists.Items.Add(file.Name);
            }
        }
        private void browsef_Click(object sender, EventArgs e)
        {
       
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "wave|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                alamatfile.Text = open.FileName;
            }
        }

        private void savef_Click(object sender, EventArgs e)
        {
            File.Copy(alamatfile.Text, Path.Combine(@".\Sound\", Path.GetFileName(alamatfile.Text)), true);
            labelk.Text = "Berhasil Menyimpan File";
            LoadData();
            MainForm fu = new MainForm();
            fu.LoadSuara();
        }


        private void deletef_Click(object sender, EventArgs e)
        {


            if (lists.SelectedIndex != -1)
            {
                    
                    //Put your folder name here..
                    string filepath =lists.Items[lists.SelectedIndex].ToString();
                    if (File.Exists(@".\Sound\"+filepath))
                        File.Delete(@".\Sound\"+filepath);
                    lists.Items.RemoveAt(lists.SelectedIndex);
                LoadData();
                MainForm fu = new MainForm();
                fu.LoadSuara();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lists.SelectedIndex != -1)
            {

                //Put your folder name here..
                string filepath = lists.Items[lists.SelectedIndex].ToString();
                SoundPlayer simpleSound = new SoundPlayer(@".\Sound\"+filepath);
                simpleSound.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lists.SelectedIndex != -1)
            {
                string filepath = lists.Items[lists.SelectedIndex].ToString();
                SoundPlayer simpleSound = new SoundPlayer(@".\Sound\" + filepath);
                simpleSound.Stop();
            }
        }
    }
}
