﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModels.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Persons> Persons { get; }
    }
}
