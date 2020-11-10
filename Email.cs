using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    public class Email : Message
    {
        private int subject;
        private List<string> url;

        public List<string> Url
        {
            get { return url; }
            set { url = value; }
        }

        public int Subject
        {
            get { return subject; }
            set { subject = value; }
        }

    }
}
