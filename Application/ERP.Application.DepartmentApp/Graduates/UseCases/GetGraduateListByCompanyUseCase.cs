﻿using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.Repository;
using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Graduates.UseCases
{
    public class GetGraduateListByCompanyUseCase : IGetGraduateListByCompanyUseCase
    {
        private readonly IGraduateRepository _graduateRepository;

        public GetGraduateListByCompanyUseCase(IGraduateRepository graduateRepository)
        {
            _graduateRepository = graduateRepository;
        }

        public async Task<IEnumerable<Graduate>> ExecuteAsync(string company = "")
        {
            return await _graduateRepository.GetGraduateByCompanyAsync(company);
        }
    }
}
