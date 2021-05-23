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
    public partial class frmMain : Form
    {
        public event Action onLoadBackupStart;
        public frmMain()
        {
            InitializeComponent();
            onLoadBackupStart += new Action(LoadBackupHandler);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if(!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                string filename = openFileDialog.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string json = reader.ReadToEnd();
                        Backup company = JsonConvert.DeserializeObject<Backup>(json);
                        lblValide.ForeColor = Color.Green;
                        lblValide.Text = "File Format Valide !";
                    }
                }
                catch (Exception ex)
                {
                    lblValide.ForeColor = Color.Red;
                    lblValide.Text = "File Format Invalide !";
                    //MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadBackupHandler()
        {
            throw;
        }
    }
}
