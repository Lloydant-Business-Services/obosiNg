﻿using Obosi.ng.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obosi.ng.Application.Interfaces
{
    public interface IBoulevard
    {
        Task<Builders_Boulevard> CreateBoulevard(Builders_Boulevard builders_Boulevard);
        Task<List<Builders_Boulevard>> GetBoulevard(int pageId);
        Task<List<Builders_Boulevard>> GetBoulevard();
        Task<Builders_Boulevard> GetBoulevardById(int id);
        Task<Builders_Boulevard> UpdateBoulevard(Builders_Boulevard builders_Boulevard);
        Task DeleteBoulevard(int id);
    }
}
