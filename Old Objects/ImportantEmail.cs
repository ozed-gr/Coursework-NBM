using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    class ImportantEmail : Email
    {
		private string sortCode;
		private string incident;

		public string Incident
		{
			get { return incident; }
			set { incident = value; }
		}

		public string SortCode
		{
			get { return sortCode; }
			set { sortCode = value; }
		}

	}
}
