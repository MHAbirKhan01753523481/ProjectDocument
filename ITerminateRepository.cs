﻿using Pronali.Data.Models.Entity.Hr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pronali.Data.Repositories.Interfaces.Hr
{
    public interface ITerminateRepository : IBaseRepository<Terminated>
    {
        IEnumerable<Terminated> GetAllWithDataTeminate();
    }
}
