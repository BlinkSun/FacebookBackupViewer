using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookBackupViewer
{
    public class Message
    {
        public string sender_name;
        public long timestamp_ms;
        public string content;
        public string type;
        public bool is_unsent;
        public int call_duration;
        public List<Photo> photos;
        public List<Reaction> reactions;
        public List<Gif> gifs;
    }
}
