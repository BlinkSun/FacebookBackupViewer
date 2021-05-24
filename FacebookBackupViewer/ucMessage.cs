using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookBackupViewer
{
    public partial class ucMessage : UserControl
    {
        private Message _message = null;

        public ucMessage(Message message = null)
        {
            InitializeComponent();
            _message = message;
        }

        private void ucMessage_Load(object sender, EventArgs e)
        {
            if(_message != null)
            {
                switch (_message.type)
                {
                    case "Generic":
                        LoadGenericMessage();
                        break;
                    case "Share":
                        LoadShareMessage();
                        break;
                    case "Call":
                        LoadCallMessage();
                        break;
                }
            }
        }

        private void LoadGenericMessage()
        {
            if(_message.photos == null)
            {
                lblSenderName.Text = _message.sender_name;
                lblTimestamp.Text = ConvertTimestampToString(_message.timestamp_ms);
                lblContent.Text = UnicodeToASCII();
            }
        }

        private string UnicodeToASCII()
        {
            byte[] bytSrc = Encoding.Unicode.GetBytes(Uri.UnescapeDataString(_message.content)));
            byte[] bytDestination = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, bytSrc);
            return Encoding.ASCII.GetString(bytDestination);
        }
        private void LoadShareMessage()
        {

        }
        private void LoadCallMessage()
        {

        }

        private string ConvertTimestampToString(long timestamp)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(timestamp).DateTime.ToString();
        }
    }
}
