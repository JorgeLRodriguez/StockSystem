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
        public readonly ILogRepository logRepository;
        public LogModel()
        {
            logRepository = new LogRepository();
        }
        public readonly static LogModel Instance = new LogModel();

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

                logRepository.Create(log);
            }
            catch
            {
            }
        }
    }
}
