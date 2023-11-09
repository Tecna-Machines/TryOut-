using Domain.Entities;

namespace Applicacion.Interfaces.IRepositories
{
    public interface IPruebaRepository
    {
        Task<List<Prueba>> GetPruebas();
        Task<Prueba> InsertPrueba(Prueba prueba);
        Task<Prueba?> UpdatePrueba(Prueba prueba);
        Task<Prueba?> DeletePrueba(int Numprueba);
        Task<Prueba?> GetPruebaById(int Numprueba);
        Task<bool> Save();
    }
}
