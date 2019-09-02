using StorageApp.Core.Interfaces.DataAccessHandlers;
using StorageApp.Core.Models;
using StorageApp.DataAccessHandlers.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageApp.DataAccessHandlers
{
    public class FileSampleHandler : BaseHandler<FileSampleEntity>, IFileSampleHandler
    {
        private StorageAppContext _context;

        public FileSampleHandler(StorageAppContext context) : base(context)
        {
            _context = context;
        }

        public FileSampleEntity GetById(string id) {
            FileSampleEntity fileSample = _context.FileSamples.Find(id);
            return fileSample;
        }

        public FileSampleEntity GetByFileName(string fileName)
        {
            FileSampleEntity fileSample = _context.FileSamples.Where(x => x.FileName == fileName).FirstOrDefault();
            return fileSample;
        }
    }
}
