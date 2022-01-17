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
    public class ExamServices : IExam
    {
        private DataContext _context;
        private readonly ILogger<ExamServices> _logger;

        public ExamServices(DataContext context, ILogger<ExamServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        
        public Response Insert(Exam entity)
        {
            var resposta = new Response();

            try
            {
                entity.State = true;

                _context.Exams.Add(entity);
                _context.SaveChanges();

                return resposta.Good("Exame registado com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao registar exame "+e);
            }
        }
    }
}
