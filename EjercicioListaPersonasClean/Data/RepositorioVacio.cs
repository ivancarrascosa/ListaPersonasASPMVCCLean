﻿using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RepositorioVacio : IGetListaPersonas
    {
        public Persona[] getListaPersonas()
        {
            return [];
        }
    }
}
