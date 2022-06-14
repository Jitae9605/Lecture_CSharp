using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarInfoModel
    {

		public string id { get; set; }	
		public string carName { get; set; }	
		public string carYear { get; set; }	
		public string carPrice { get; set; }	
		public string carDoor { get; set; }	

		public string[] ToStringList()
		{
			return new string[] { id, carName, carYear, carPrice, carDoor };
		}
    }
}
