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
    public class ExamMedicServices : IExamMedic
    {
        private DataContext _context;
        private readonly ILogger<ExamMedicServices> _logger;

        public ExamMedicServices(DataContext context, ILogger<ExamMedicServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Response Insert(ExamMedic entity)
        {
            var resposta = new Response();

            try
            {
                
                entity.State = true;

                _context.ExamMedics.Add(entity);
                _context.SaveChanges();

                return resposta.Good("Administrador registado com sucesso", entity);

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao registar administrador "+e);
            }
        }
    }
}
