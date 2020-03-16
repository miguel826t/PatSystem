using Microsoft.EntityFrameworkCore;
using PatSystem.Data;
using PatSystem.Models.Curriculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Services
{
    public class IdiomaService
    {
        private readonly PatSystemContext _context;

        public IdiomaService(PatSystemContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Idioma obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task InsertAllAsync(List<Idioma> objs)
        {
            foreach (var obj in objs)
            {
                _context.Add(obj);
                await _context.SaveChangesAsync();
            }

        }

        public async Task RemoveAllAsync(int curriculoId)
        {
            var Objs = await _context.Idioma.Where(c => c.CurriculoID == curriculoId).ToListAsync();
            foreach (var obj in Objs)
            {
                _context.Idioma.Remove(obj);
                await _context.SaveChangesAsync();
            }

        }


        public async Task<Idioma> FindByIdAsync(int id)
        {
            return await _context.Idioma.FirstOrDefaultAsync(obj => obj.CurriculoID == id);
        }

        public async Task<List<Idioma>> FindAllByIdAsync(int id)
        {
            return await _context.Idioma.Where(obj => obj.CurriculoID == id).ToListAsync();
        }
    }
}
