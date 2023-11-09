using Domain.Entities;

namespace Applicacion.Interfaces.IRepositories
{
    public interface IMaquinaRepository
    {
        Task<Maquina?> GetMaquinaByNum(string NumMaquina);
        Task<Maquina> InsertMaquina(Maquina Maquina);
        Task<Maquina?> DeleteMaquina(string NumMaquina);
        Task<Maquina?> UpdateMaquina(Maquina Maquina);
        Task<IEnumerable<Maquina>> GetMaquinas();
        Task<bool> Save();
    }
}
