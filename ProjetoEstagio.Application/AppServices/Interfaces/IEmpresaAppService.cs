﻿using ProjetoEstagio.Application.ViewModels;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Application.AppServices.Interfaces
{
    public interface IEmpresaAppService
    {
        string GetNomeEmpresaById(int id);
        EmpresaViewModel GetById(int id);
    }
}
