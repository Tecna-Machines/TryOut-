using Applicacion.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System.Data.Entity;

namespace Infrastructure.Repositories
{
    public class MaquinaRepository : IMaquinaRepository , IDisposable
    {
        private readonly TryOutContext context;
        private bool disposed = false;

        public MaquinaRepository(TryOutContext context)
        {
            this.context = context;
        }

        public async Task<Maquina> DeleteMaquina(string NumMaquina)
        {
            var foundMachine = await context.Maquinas.FindAsync(NumMaquina);

            if(foundMachine != null) { 
                context.Maquinas.Remove(foundMachine);
                return foundMachine;
            }

            throw new KeyNotFoundException();
        }

        public async Task<Maquina> GetMaquinaByNum(string NumMaquina)
        {
            return await context.Maquinas.FirstOrDefaultAsync(m => m.NumMaquina == NumMaquina);
        }

        public async Task<IEnumerable<Maquina>> GetMaquinas()
        {
            return await context.Maquinas.ToListAsync();
        }

        public async Task<Maquina> InsertMaquina(Maquina Maquina)
        {
            await context.Maquinas.AddAsync(Maquina);
            return Maquina;
        }

        public async Task<Maquina> UpdateMaquina(Maquina Maquina)
        {
            context.Entry(Maquina).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            await context.SaveChangesAsync();
            return  Maquina;
        }

        //liberacion de recursos
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //guardar
        public async Task<bool> Save()
        {
            await context.SaveChangesAsync();
            return true;
        }
    }
}
