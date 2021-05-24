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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    string filename = openFileDialog.FileName;
                    try
                    {
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            string json = reader.ReadToEnd();
                            Backup backup = JsonConvert.DeserializeObject<Backup>(json);
                            lblValide.ForeColor = Color.Green;
                            lblValide.Text = "File Format Valide !";
                            fill(backup);
                        }
                    }
                    catch (Exception)
                    {
                        lblValide.ForeColor = Color.Red;
                        lblValide.Text = "File Format Invalide !";
                        //MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fill(Backup backup)
        {
            lblParticipants.Text = $"Conversation entre {backup.participants[0].name} et {backup.participants[1].name}.";
            int count = 0;
            foreach (Message message in backup.messages)
            {
                count++;
                if(message.type == "Generic")
                {
                    if(message.photos == null)
                    {
                        ucMessage ucmsg = new ucMessage(message);
                        flowPanel.Controls.Add(ucmsg);
                    }
                }
                //bool found = false;
                //foreach (Control control in flowPanel.Controls)
                //{
                //    if(control.Text == message.type)
                //    {
                //        found = true;
                //        break;
                //    }
                //}
                //if (!found)
                //{
                //    Label label = new Label();
                //    label.AutoSize = true;
                //    label.Text = message.type;
                //    flowPanel.Controls.Add(label);
                //}
                if (count == 100)
                    break;
            }
        }
    }
}
