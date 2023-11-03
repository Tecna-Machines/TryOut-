using Applicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicacion.Interfaces.IServices
{
    public interface IMaquinaService
    {
        public Task<MaquinaDTO> CrearNuevaMaquina(MaquinaDTO maquina);
        public Task<MaquinaDTO?> ConsultarMaquinaById(string NumMaquin);
    }
}
