﻿using AlonsoAdmin.Entities;
using AlonsoAdmin.Entities.System;
using AlonsoAdmin.Services.System.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlonsoAdmin.Services.System.Interface
{
    public interface ISysGroupService:IBaseService<GroupFilterRequest,GroupAddRequest, GroupEditRequest>
    {


    }
}