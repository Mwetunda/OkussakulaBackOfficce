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
    public class CronogramExamServices : ICronogramExam
    {
        private DataContext _context;
        private readonly ILogger<CronogramExamServices> _logger;

        public CronogramExamServices(DataContext context, ILogger<CronogramExamServices> logger)
        {
            _context = context;
            _logger = logger;
        }


        public Response Insert(CronogramExam entity, string intevalo)
        {
            var resposta = new Response();

            try
            {
                _context.CronogramExams.Add(entity);
                _context.SaveChanges();

                InsertHorario(intevalo, entity.CronogramExamId);

                return resposta.Good("Cronograma criado com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao criar cronograma " + e);
            }
        }

        public void InsertHorario(string intervalo, long cronogramExamtId)
        {

            try
            {

                var Horas = new List<ExamHorario>();

                int horaInicio, horaFim;

                string[] horas = intervalo.Split('-');

                horaInicio = Convert.ToInt32(horas[0]);
                horaFim = Convert.ToInt32(horas[1]);

                for (int a = horaInicio; a < horaFim; a++)
                {
                    var examHorario = new ExamHorario();

                    examHorario.CronogramExamId = cronogramExamtId;
                    examHorario.Hora = a;
                    examHorario.State = true;

                    Horas.Add(examHorario);
                }

                _context.ExamHorarios.AddRange(Horas);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException("Erro ao registar horario " + e);
            }
        }
    }
}
