﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace EquipmentSystem
{
    public class EquipmentSystemDomainServiceBase:DomainService
    {
        public EquipmentSystemDomainServiceBase()
        {
            LocalizationSourceName = EquipmentSystemConsts.LocalizationSourceName;
        }
    }
}
