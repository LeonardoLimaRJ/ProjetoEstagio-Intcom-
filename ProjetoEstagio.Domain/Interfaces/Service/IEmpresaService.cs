﻿using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Domain.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Interfaces.Service
{
    public interface IEmpresaService
    {
        string GetNomeEmpresaById(int id);
        Empresa GetById(int id);
    }
}
