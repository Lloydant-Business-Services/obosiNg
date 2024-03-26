using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Domain.Entity
{
	public class UnitAdmin
	{
		public long Id { get; set; }	
		public long UsersId { get; set; }	
		public virtual Users Users { get; set; }
		public int UnitId { get; set; }
		public virtual Unit Unit { get; set; }
		public DateTime DateAdded { get; set; }
		public bool Active { get; set; }
 	}
}
