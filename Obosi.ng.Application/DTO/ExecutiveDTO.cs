using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public class ExecutiveDTO
    {
        public long UserId { get; set; }
        public int UnitId { get; set; }
        public string Designation { get; set; }
    }
}
