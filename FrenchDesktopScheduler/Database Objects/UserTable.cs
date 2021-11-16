using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchDesktopScheduler.Database_Objects
{
	class UserTable
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int Active { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime LastUpdate { get; set; }
		public string LastUpdatedBy { get; set; }

		public UserTable(int userId, string userName, string password, int active,
			DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
		{
			UserID = userId;
			UserName = userName;
			Password = password;
			Active = active;
			CreateDate = createDate;
			CreatedBy = createdBy;
			LastUpdate = lastUpdate;
			LastUpdatedBy = lastUpdatedBy; 
		}
	}

}
