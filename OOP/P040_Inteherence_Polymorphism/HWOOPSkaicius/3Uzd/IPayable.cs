﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas
{
    public interface IPayable
    {

        double GetCurrentSalary();
        double IncreaseCurrentSalary(double bonus);
        string GetPhisicalAdress();

    }
}
