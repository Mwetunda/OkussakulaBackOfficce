using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Okussakula.Model;
using Okussakula.Model.Data;
using Okussakula.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Okussakula.Service.Services
{
    public class CronogramConsultServices : ICronogramConsult
    {
        private DataContext _context;
        private readonly ILogger<CronogramConsultServices> _logger;

        public CronogramConsultServices(DataContext context, ILogger<CronogramConsultServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Response Insert(CronogramConsult entity, string intevalo)
        {
            var resposta = new Response();

            try
            {

                _context.CronogramConsults.Add(entity);
                _context.SaveChanges();

                InsertHorario(intevalo, entity.CronogramConsultId);

                return resposta.Good("Cronograma criado com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao criar cronograma "+e);
            }
        }

        public void InsertHorario(string intervalo, long cronogramConsultId)
        {

            try
            {
                
                var Horas = new List<ConsultHorario>();

                int horaInicio, horaFim;

                string[] horas = intervalo.Split('-');

                horaInicio = Convert.ToInt32(horas[0]);
                horaFim = Convert.ToInt32(horas[1]);

                for (int a = horaInicio; a < horaFim; a++)
                {
                    var consultHorario = new ConsultHorario();

                    consultHorario.CronogramConsultId = cronogramConsultId;
                    consultHorario.Hora = a;
                    consultHorario.State = true;

                    Horas.Add(consultHorario);
                }

                _context.ConsultHorarios.AddRange(Horas);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException ("Erro ao registar horario " + e);
            }
        }
        public Response List(long instituitionId)
        {
            var resposta = new Response();

            try
            {
                var lista = _context.CronogramConsults
                    .Include(x => x.InstituitionSpeciality).ThenInclude(x => x.Speciality)
                    .Include(x => x.ConsultHorarios)
                    .AsNoTracking()
                    .Where(x => x.InstituitionSpeciality.InstituitionId == instituitionId)
                    .OrderBy(x => x.Data);

                return resposta.Good("Lista de Cronogramas", lista);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListBySpeciality(long instituitionId, long specialityId)
        {
            var resposta = new Response();

            try
            {
                var lista = _context.CronogramConsults
                    .Include(x => x.InstituitionSpeciality)
                    .Include(x => x.ConsultHorarios)
                    .AsNoTracking()
                    .Where(x => x.InstituitionSpeciality.InstituitionId == instituitionId && x.InstituitionSpeciality.SpecialityId == specialityId)
                    .OrderBy(x => x.Data);

                return resposta.Good("Lista de Cronogramas", lista);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }

        public Response ListBySpecialityAndData(long instituitionId, long specialityId, DateTime date)
        {
            var resposta = new Response();

            try
            {
                var lista = _context.CronogramConsults
                    .Include(x => x.InstituitionSpeciality)
                    .Include(x => x.ConsultHorarios)
                    .AsNoTracking()
                    .Where(x => x.InstituitionSpeciality.InstituitionId == instituitionId && x.InstituitionSpeciality.SpecialityId == specialityId && x.Data.Date == date.Date)
                    .OrderBy(x => x.Data);

                return resposta.Good("Lista de Cronogramas", lista);
            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao gerar lista " + e);
            }
        }
    }
}
