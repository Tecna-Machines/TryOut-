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

        public MaquinaDTO CrearNuevaMaquina(MaquinaDTO maquina)
        {
            var nuevaMaquina = new Maquina
            {
                NumMaquina = maquina.NumMaquina,
                Nombre = maquina.Nombre,
                Descripcion = maquina.Descripcion
            };

            _repository.InsertMaquina(nuevaMaquina);
            _repository.Save();
            return maquina;
        }
    }
}
