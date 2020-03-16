using Microsoft.EntityFrameworkCore;
using PatSystem.Data;
using PatSystem.Models.Curriculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Services
{
    public class CurriculoService
    {
        private readonly PatSystemContext _context;

        public CurriculoService(PatSystemContext context)
        {
            _context = context;
        }

        public async Task<List<Curriculo>> FindAllAsync()
        {
            return await _context.Curriculo.ToListAsync();
        }

        public async Task InsertAsync(Curriculo obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Curriculo.FindAsync(id);
            _context.Curriculo.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Curriculo> FindByIdAsync(int id)
        {
            return await _context.Curriculo.FirstOrDefaultAsync(obj => obj.CurriculoID == id);
        }
    }
}
