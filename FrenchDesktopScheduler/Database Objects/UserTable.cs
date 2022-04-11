using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchDesktopScheduler.Database_Objects
{
	public class UserTable
	{
		public int UserID;
		public string UserName;
		public string Password;
		public int Active;
		public DateTime CreateDate;
		public string CreatedBy;
		public DateTime LastUpdate;
		public string LastUpdatedBy;
	}

}
