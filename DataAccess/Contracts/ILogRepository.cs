using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Contracts
{
    public interface ILogRepository
    {
        Log Create(Log log);
    }
}