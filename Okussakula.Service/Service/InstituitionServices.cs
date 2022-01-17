using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Okussakula.Model;
using Okussakula.Model.Data;
using Okussakula.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okussakula.Service.Services
{
    public class InstituitionServices: IInstituition
    {
        private DataContext _context;
        private readonly ILogger<InstituitionServices> _logger;

        public InstituitionServices(DataContext context, ILogger<InstituitionServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Response Insert(Instituition entity)
        {
            var resposta = new Response();

            try
            {
                entity.DateInsert = DateTime.Now.Date;
                entity.DateUpdate = DateTime.Now.Date;
                entity.State = true;

                _context.Instituitions.Add(entity);
                _context.SaveChanges();

                return resposta.Good("Instituição registada com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao registar instituição " + e);
            }
        }
        public Response InsertSpeciality(List<InstituitionSpeciality> entity)
        {
            var resposta = new Response();

            try
            {
                foreach(var item in entity)
                {
                    item.State = true;
                }

                _context.InstituitionSpecialities.AddRange(entity);
                _context.SaveChanges();

                return resposta.Good("Especialidades adicionadas com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao adicionar especialidades " + e);
            }
        }
        public Response InsertExam(List<InstituitionExam> entity)
        {
            var resposta = new Response();

            try
            {
                foreach(var item in entity)
                {
                    item.State = true;
                }

                _context.InstituitionExams.AddRange(entity);
                _context.SaveChanges();

                return resposta.Good("Exames adicionados com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao adicionar exames " + e);
            }
        }

        public Response List(long id)
        {
            var resposta = new Response();

            try
            {
                var Lista = new List<Instituition>();

                var lista = _context.Instituitions
                    .Include(x => x.InstituitionSpeciality).ThenInclude(x => x.Speciality)
                    .AsNoTracking();

                foreach(var item in lista)
                {
                    foreach (var item2 in item.InstituitionSpeciality)
                    {
                        if(item2.SpecialityId == id)
                        {
                            item.InstituitionSpeciality.Clear();
                            item.InstituitionSpeciality.Add(item2);
                            Lista.Add(item);
                            goto Avancar;
                        }
                    }
                    Avancar:;
                }

                return resposta.Good("Lista de instituições", Lista);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListSpeciality(long id)
        {
            var resposta = new Response();

            try
            {
                var lista = _context.InstituitionSpecialities
                    .Include(x => x.Speciality)
                    .AsNoTracking()
                    .Where(x => x.InstituitionId == id)
                    .OrderBy(x => x.Speciality.Designation);

                return resposta.Good("Lista de especialidades", lista);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListExam(long id)
        {
            var resposta = new Response();

            try
            {
                var lista = _context.InstituitionExams
                    .Include(x => x.Exam)
                    .AsNoTracking()
                    .Where(x => x.InstituitionId == id)
                    .OrderBy(x => x.Exam.Designation);

                return resposta.Good("Lista de exames", lista);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
