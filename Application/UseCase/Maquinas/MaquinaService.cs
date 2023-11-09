using Applicacion.DTO;
using Applicacion.Interfaces.IRepositories;
using Applicacion.Interfaces.IServices;
using Domain.Entities;

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
            MaquinaDTO? foundMachine = new MaquinaDTO(); ;

            if (maquina.NumMaquina != null)
            {
                foundMachine = await ConsultarMaquinaById(maquina.NumMaquina);
            }


            if (foundMachine != null) { throw new InvalidOperationException(); };

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
            var found = await _repository.GetMaquinaByNum(NumMaquina);

            if (found != null)
            {
                return new MaquinaDTO
                {
                    NumMaquina = found.NumMaquina,
                };
            }

            return null;
        }

        public async Task<IEnumerable<MaquinaDTO>> ConseguirTodasLasMaquinas()
        {
            var machinesMapear =  await _repository.GetMaquinas();
            List<MaquinaDTO> maquinaDTOs = new List<MaquinaDTO>();


            foreach (var maquina in machinesMapear)
            {
                var nuevaMauqina = new MaquinaDTO
                {
                    NumMaquina = maquina.NumMaquina,
                    Descripcion = maquina.Descripcion,
                    Nombre = maquina.Nombre
                };

                maquinaDTOs.Add(nuevaMauqina);
            }

            return maquinaDTOs;
        }
    }
}
