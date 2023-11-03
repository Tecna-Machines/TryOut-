using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
