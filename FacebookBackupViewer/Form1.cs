using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookBackupViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename;
            DialogResult result = openFileDialog1.ShowDialog();
            if(!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                filename = openFileDialog1.FileName;
                using (StreamReader r = new StreamReader(filename))
                {
                    string json = r.ReadToEnd();
                    Backup company = JsonConvert.DeserializeObject<Backup>(json);
                }
            }
        }
    }
}
