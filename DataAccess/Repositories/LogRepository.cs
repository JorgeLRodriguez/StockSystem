using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class LogRepository : ILogRepository
    {
        protected Repository _db;
        public LogRepository()
        {
            _db = new Repository();
        }
        public Log Create(Log log)
        {
            _db.Set<Log>().Add(log);
            _db.SaveChanges();
            return log;
        }
    }
}