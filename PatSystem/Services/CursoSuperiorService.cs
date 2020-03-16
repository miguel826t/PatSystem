using Microsoft.EntityFrameworkCore;
using PatSystem.Data;
using PatSystem.Models.Curriculo.Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Services
{
    public class CursoSuperiorService
    {
        private readonly PatSystemContext _context;

        public CursoSuperiorService(PatSystemContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(CursoSuperior obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task InsertAllAsync(List<CursoSuperior> objs)
        {
            foreach(var obj in objs)
            {
                _context.Add(obj);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task RemoveAllAsync(int curriculoId)
        {
            var Cursos = await _context.CursoSuperior.Where(c => c.CurriculoID == curriculoId).ToListAsync();
            foreach(var curso in Cursos)
            {
                _context.CursoSuperior.Remove(curso);
                await _context.SaveChangesAsync();
            }
            
        }


        public async Task<CursoSuperior> FindByIdAsync(int id)
        {
            return await _context.CursoSuperior.FirstOrDefaultAsync(obj => obj.CurriculoID == id);
        }

        public async Task<List<CursoSuperior>> FindAllByIdAsync(int id)
        {
            return await _context.CursoSuperior.Where(obj => obj.CurriculoID == id).ToListAsync();
        }
    }
}
