using StorageApp.Core.Interfaces.DataAccessHandlers;
using StorageApp.Core.Interfaces.Engines;
using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Engines
{
    public class FileSampleEngine : IFileSampleEngine
    {
        private readonly IFileSampleHandler _fileSampleHandler;

        public FileSampleEngine(IFileSampleHandler fileSampleHandler) {
            _fileSampleHandler = fileSampleHandler;
        }

        public FileSampleEntity GetFileById(int id)
        {
            return _fileSampleHandler.GetById(id);
        }

        public FileSampleEntity GetFileByName(string fileName)
        {
            return _fileSampleHandler.GetByFileName(fileName);
        }
    }
}
