using Obosi.ng.Application.DTO;
using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Obosi.ng.Application.Interfaces
{
    public interface IAboutService
    {
       //Create about, deleteWbout, updateAbout , Get
       Task<List<About>> GetAbouts();
        Task<List<About>> CreateAbout(About about);
        Task<List<About>> DeleteAbout(int Id);
        Task<List<About>> UpdateAbout(About about);
        Task<About> GetAboutById(int id);
    }
}
