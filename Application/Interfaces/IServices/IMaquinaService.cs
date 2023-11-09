using Applicacion.DTO;

namespace Applicacion.Interfaces.IServices
{
    public interface IMaquinaService
    {
        public Task<MaquinaDTO> CrearNuevaMaquina(MaquinaDTO maquina);
        public Task<MaquinaDTO?> ConsultarMaquinaById(string NumMaquin);
        public Task<IEnumerable<MaquinaDTO>> ConseguirTodasLasMaquinas();
    }
}
