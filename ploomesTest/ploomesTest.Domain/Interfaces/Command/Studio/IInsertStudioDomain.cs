﻿using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Studio
{
    public interface IInsertStudioDomain
    {
        public bool InsertStudio(StudioDomain studioDomain);
    }
}
