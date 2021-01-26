using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Repositories;

namespace Domain
{
    public class LogModel
    {
        private readonly IUnitOfWork unitOfWork;
        private static LogModel _instance = new LogModel();
        public static LogModel Instance()
        {
            return _instance = _instance ?? new LogModel();
        }
        public LogModel()
        {
            unitOfWork = UnitOfWork.Instance();
        }
        public void Log(Log log, Exception ex)
        {
            try
            {
                log.CreatedBy = Environment.UserName;
                log.CreatedOn = DateTime.Now;

                if (ex == null)
                {
                    log.id_tipolog = 1;
                }
                else
                {
                    log.id_tipolog = 2;
                    log.Mensaje = ex.Message;
                    log.Ubicacion = ex.StackTrace;
                }
                unitOfWork.LogRepository.Create(log);
                unitOfWork.SaveChanges();
            }
            catch(Exception e)
            {

            }
        }
    }
}