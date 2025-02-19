﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopBasketWeb.Models;
using ShopBasketWeb.Models.ProcedureModels;

namespace ShopBasketWeb.DataAccess
{

    public interface IDataProvider
    {
        Task<IEnumerable<ProductsOnSpecial>> GetProductsOnSpecial(int StoreID);

        Task<IEnumerable<SearchedProducts>> GetSeachedProducts(string searchData);

        Task<IEnumerable<ProductsByCat>> GetProductsByCategory(int CatID);
        Task<IEnumerable<Store_In_Range>> GetStoreLocations();
    }
}
