using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    public abstract class Message
    {
		protected string sender;
		protected string body;
		protected string header;
		protected Dictionary<string, string> abbreviations = new Dictionary<string, string>(); 

		public string Sender
		{
			get { return sender; }
			set { sender = value; }
		}

		public string Header
		{
			get { return header; }
			set { header = value; }
		}


		public string Body
		{
			get { return body; }
			set { body = value; }
		}


		public Dictionary<string, string> Abbreviations
		{
			get { return abbreviations; }
			set { abbreviations = value; }
		}

	}
}
