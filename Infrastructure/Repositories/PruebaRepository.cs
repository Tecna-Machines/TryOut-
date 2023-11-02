using Applicacion.Interfaces.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PruebaRepository : IPruebaRepository , IDisposable
    {
        private readonly TryOutContext context;
        private bool disposed = false;

        public PruebaRepository(TryOutContext context)
        {
            this.context = context;
        }

        public async Task<List<Prueba>> GetPruebas()
        {
            return await context.Pruebas.ToListAsync();
        }

        public async Task<Prueba?> DeletePrueba(int Numprueba)
        {
            var foundPrueba = await context.Pruebas.FindAsync(Numprueba);

            if (foundPrueba != null)
            {
                context.Pruebas.Remove(foundPrueba);
                return foundPrueba;
            }

            throw new KeyNotFoundException();
        }

        public async Task<Prueba?> GetPruebaById(int Numprueba)
        {
            return await context.Pruebas.FindAsync(Numprueba);
        }

        public async Task<Prueba> InsertPrueba(Prueba prueba)
        {
            await context.Pruebas.AddAsync(prueba);
            return prueba;
        }

        public async Task<Prueba?> UpdatePrueba(Prueba prueba)
        {
            context.Entry(prueba).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return prueba;
        }
        public async Task<bool> Save()
        {
            await context.SaveChangesAsync();
            return true;
        }

        //resource release
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
    }
}
