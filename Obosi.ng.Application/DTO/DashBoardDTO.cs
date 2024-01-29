using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.DTO
{
    public class DashBoardDTO
    {
        public int TotalMembers { get; set; }
        public int NewMembers { get; set; }
        public int TotalOdu { get; set; }
        public int Umunnas { get; set; }
        public List<Calender_Assets> Calender {get;set;}
        public List<Unit> Villages { get; set; }
    }
}
