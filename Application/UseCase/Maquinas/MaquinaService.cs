using Applicacion.DTO;
using Applicacion.Interfaces.IRepositories;
using Applicacion.Interfaces.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicacion.UseCase.Maquinas
{
    public class MaquinaService : IMaquinaService
    {   
        private readonly IMaquinaRepository _repository;

        public MaquinaService(IMaquinaRepository repository)
        {
            _repository = repository;
        }

        public async Task<MaquinaDTO> CrearNuevaMaquina(MaquinaDTO maquina)
        {
            var nuevaMaquina = new Maquina
            {
                NumMaquina = maquina.NumMaquina,
                Nombre = maquina.Nombre,
                Descripcion = maquina.Descripcion,
                FechaCreacion = DateTime.Now
            };

            await _repository.InsertMaquina(nuevaMaquina);
            await _repository.Save();
            return maquina;
        }

        public async Task<MaquinaDTO?> ConsultarMaquinaById(string NumMaquina)
        {
            var found =  await _repository.GetMaquinaByNum(NumMaquina);

            if(found != null)
            {
                return new MaquinaDTO
                {
                    NumMaquina = found.NumMaquina,
                };
            }

            return null;
        }
    }
}
