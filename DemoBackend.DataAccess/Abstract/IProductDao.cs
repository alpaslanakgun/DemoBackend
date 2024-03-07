using DemoBackend.Core.DataAccess;
using DemoBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoBackend.DataAccess.Abstract
{
    public interface IProductDao : IEntityRepository<Product>
    {
    }
}
