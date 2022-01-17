﻿using Okussakula.Model;
using Okussakula.Model.Interface;
using System;

namespace Okussakula.Service.Services
{
    public class ExamServices : IExam
    {
        
        public ExamServices()
        {

        }

        public Response List()
        {
            var resposta = new Response();

            try
            {
               

                return resposta.Good("Exame registado com sucesso");

            }
            catch (Exception e)
            {
                return resposta.Bad("Erro ao registar exame "+e);
            }
        }
    }
}
