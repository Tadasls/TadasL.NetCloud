using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILog
    {
        void WriteLog(int iskurpaimtas, int diskas, int ikurpadetas, Tower[] Game, DateTime pradziosdata, int ejimonr, bool baigtas = false);

    }
}
