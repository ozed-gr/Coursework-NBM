using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    class Tweet : Message
    {
        private List<string> hashtags;
        private List<string> mentions;  

        public List<string> Mentions
        {
            get { return mentions; }
            set { mentions = value; }
        }

        public List<string> Hashtags
        {
            get { return hashtags; }
            set { hashtags = value; }
        }

    }
}
