﻿using Ecommerce.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Repositories.Interfaces
{
    public interface IStoreRepository : IGenericRepository<StoreModel>
    {
        Task Update(StoreModel storeModel);
    }
}
