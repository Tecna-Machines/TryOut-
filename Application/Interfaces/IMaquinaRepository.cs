using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicacion.Interfaces
{
    public interface IMaquinaRepository
    {
        Task<Maquina> GetMaquinaByNum(String NumMaquina);
        Task<Maquina> InsertMaquina(Maquina Maquina);
        Task<Maquina> DeleteMaquina(String NumMaquina);
        Task<Maquina> UpdateMaquina(Maquina Maquina);
        Task<IEnumerable<Maquina>> GetMaquinas();
    }
}
