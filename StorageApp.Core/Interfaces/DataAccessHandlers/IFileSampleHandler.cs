using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Core.Interfaces.DataAccessHandlers
{
    public interface IFileSampleHandler : IBaseHandler<FileSampleEntity>
    {
        new FileSampleEntity GetById(int id);
        FileSampleEntity GetByFileName(string fileName);
    }
}
