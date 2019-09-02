using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Core.Interfaces.DataAccessHandlers
{
    
    public interface IBaseHandler<T> where T : IBaseEntity
    {
        T GetById(int id);
    }
}
