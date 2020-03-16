using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatSystem.Services;
using PatSystem.Models.ViewModels;
using PatSystem.Models.Curriculo;
using PatSystem.Models.Curriculo.Cursos;

namespace PatSystem.Controllers
{
    public class CurriculoController : Controller
    {
        #region Servicos
        private readonly ClienteService _clienteService;
        private readonly CursoSuperiorService _cursoSuperiorService;
        private readonly CursoTecnicoService _cursoTecnicoService;
        private readonly ExperienciaService _experienciaService;
        private readonly IdiomaService _idiomaService;
        private readonly CurriculoService _curriculoService;
        #endregion

        #region Contrutor
        public CurriculoController(ClienteService clienteService, CursoSuperiorService cursoSuperior, CursoTecnicoService cursoTecnicoService, ExperienciaService experiencia, IdiomaService idioma, CurriculoService curriculoService)
        {
            _curriculoService = curriculoService;
            _clienteService = clienteService;
            _cursoSuperiorService = cursoSuperior;
            _cursoTecnicoService = cursoTecnicoService;
            _experienciaService = experiencia;
            _idiomaService = idioma;
        }
        #endregion


        #region Index
        public async Task<IActionResult> IndexAsync()
        {
            var curriculos = await _curriculoService.FindAllAsync();
            var clientes = await _clienteService.FindAllAsync();

            var join = from cr in curriculos
                       join cl in clientes
                       on cr.ClienteID
                       equals cl.ClienteId
                       select new CRindexViewModel
                       {
                           CurriculoID = cr.CurriculoID,
                           Nome = cl.Nome,
                           Idade = cl.Idade,
                           AreaAtuacao = cl.AreaAtuacao,
                           EnsinoMedio = cl.EnsinoMedio,
                           CursoTecnicoSN = cr.CursoTecnicoSN,
                           CursoSuperiorSN = cr.CursoSuperiorSN,
                           IdiomaSN = cr.IdiomaSN
                       };

            return View(join);
        }
        #endregion

        #region Create

        //Get
        public IActionResult Create()
        {
           return View();
        }

        //Post
        public async Task<ActionResult> CreateCR(CRcreateViewModel createViewModel)
        {
            var cliente = createViewModel.Cliente;
            var cursoSuperior = createViewModel.CursoSuperior;
            var cursoTecnico = createViewModel.CursoTecnico;
            var experiencia = createViewModel.Experiencia;
            var idioma = createViewModel.Idioma;

           await _clienteService.InsertAsync(cliente);

            Curriculo curriculo = new Curriculo
            {
                ClienteID = cliente.ClienteId,
                DataCriacao =  DateTime.Now,
            };

            if (createViewModel.CursoSuperior.Status ==  0)
            {
                curriculo.CursoSuperiorSN = "Não";
            }
            else
            {
                curriculo.CursoSuperiorSN = "Sim";
            }
            if (createViewModel.CursoTecnico.Status == 0)
            {
                curriculo.CursoTecnicoSN = "Não";
            }
            else
            {
                curriculo.CursoTecnicoSN = "Sim";
            }
            if (createViewModel.Idioma.NivelFluencia == 0)
            {
                curriculo.IdiomaSN = "Não";
            }
            else
            {
                curriculo.IdiomaSN = "Sim";
            }

           await _curriculoService.InsertAsync(curriculo);
            cursoSuperior.CurriculoID = curriculo.CurriculoID;
           await _cursoSuperiorService.InsertAsync(cursoSuperior);

            cursoTecnico.CurriculoID = curriculo.CurriculoID;
           await _cursoTecnicoService.InsertAsync(cursoTecnico);

            experiencia.CurriculoID = curriculo.CurriculoID;
           await _experienciaService.InsertAsync(experiencia);

            idioma.CurriculoID = curriculo.CurriculoID;
           await _idiomaService.InsertAsync(idioma);
           
            return RedirectToAction("Index");
        }

        #endregion

        #region Edit
        ////Get
        //public async Task<IActionResult> EditAsync(int? id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, Curriculo curriculo)
        //{


        //    return RedirectToAction(nameof(Index));
        //}
        #endregion

        #region Remove
        public async Task<IActionResult> Remove(int id)
        {
            var cr = await _curriculoService.FindByIdAsync(id);
            var cl = await _clienteService.FindByIdAsync(id);

            var removeViewModel = new CrdeleteViewModel
            {
                CurriculoID = cr.CurriculoID,
                ClienteId = cl.ClienteId,
                Nome = cl.Nome
            };


            return View(removeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var cr = await _curriculoService.FindByIdAsync(id);
            await _clienteService.RemoveAsync(cr.ClienteID);
            await _cursoSuperiorService.RemoveAllAsync(id);
            await _cursoTecnicoService.RemoveAllAsync(id);
            await _idiomaService.RemoveAllAsync(id);
            await _experienciaService.RemoveAllAsync(id);
            //await _curriculoService.RemoveAsync(id);

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Details
        public async Task<IActionResult> DetailsAsync(int id)
        {

                var curriculo = await _curriculoService.FindByIdAsync(id);
                var cliente =  await _clienteService.FindByIdAsync(curriculo.ClienteID);
                var cursosSuperior = await _cursoSuperiorService.FindAllByIdAsync(id);
                var cursosTecnico = await _cursoTecnicoService.FindAllByIdAsync(id);
                var idiomas = await _idiomaService.FindAllByIdAsync(id);
                var experiencias = await _experienciaService.FindAllByIdAsync(id);

                var detailsviewmodel = new CRdetailsViewModel
                {
                    Curriculo = curriculo,
                    Cliente = cliente,
                    CursosSuperior = cursosSuperior,
                    CursosTecnico = cursosTecnico,
                    Idiomas = idiomas,
                    Experiencias = experiencias
                };

            
           return View(detailsviewmodel);
        }

        #endregion

    }
}