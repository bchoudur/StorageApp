using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Core.Interfaces.Managers
{
    public interface IFileSampleManager
    {
        FileSampleEntity GetById(int id);
        FileSampleEntity GetByFileName(string fileName);
    }
}
