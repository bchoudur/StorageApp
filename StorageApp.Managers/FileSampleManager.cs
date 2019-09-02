using StorageApp.Core.Interfaces.Engines;
using StorageApp.Core.Interfaces.Managers;
using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Managers
{
    public class FileSampleManager : IFileSampleManager
    {
        private readonly IFileSampleEngine _fileSampleEngine;

        public FileSampleManager(IFileSampleEngine fileSampleEngine) {
            _fileSampleEngine = fileSampleEngine;
        }

        public FileSampleEntity GetById(int id)
        {
            return _fileSampleEngine.GetFileById(id);
        }

        public FileSampleEntity GetByFileName(string fileName)
        {
            return _fileSampleEngine.GetFileByName(fileName);
        }
    }
}
