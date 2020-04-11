using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Faculty_Conference_Management_System
{
	class Connection
	{
		public string conStr { get; set; }
		Connection()
		{
			conStr = "Data Source=orcl; User Id=hr; Password=hr;";
		}
	}
}
