using Obosi.ng.Domain.Entity;

namespace Obosi.ng.Application.Interfaces
{
    public interface IUmunna
    {
        Task<Umunna> CreateUmunna(Umunna umunna);
        Task<Umunna> UpdateUmunna(Umunna umunna);
        Task DeleteUmunna(int id);
        Task<List<Umunna>> GetUmunna();
        Task<List<Umunna>> GetUmunnaByAka(int AkaId);
        Task<Umunna> GetUmunnaById(int Id);
    }
}
