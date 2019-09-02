using StorageApp.Core.Interfaces.DataAccessHandlers;
using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Core.Interfaces.Engines
{
    public interface IFileSampleEngine
    {
        FileSampleEntity GetFileById(int id);
        FileSampleEntity GetFileByName(string fileName);
    }
}
