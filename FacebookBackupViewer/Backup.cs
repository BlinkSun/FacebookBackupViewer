using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookBackupViewer
{
    public class Backup
    {
        public List<Participant> participants;
        public List<Message> messages;
        public string title;
        public bool is_still_participant;
        public string thread_type;
        public string thread_path;
        public List<Magic_Word> magic_words;
    }
}
