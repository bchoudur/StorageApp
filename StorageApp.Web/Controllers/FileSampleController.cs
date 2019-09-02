using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorageApp.Core.Interfaces.Managers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StorageApp.Web.Controllers
{
    [Route("api/files")]
    public class FileSampleController : Controller
    {
        private readonly IFileSampleManager _fileSampleManager;

        public FileSampleController(IFileSampleManager fileSampleManager) {
            _fileSampleManager = _fileSampleManager;
        }

        [HttpGet("{id}")]
        public IActionResult GetFileById(int id) {
            return Json(_fileSampleManager.GetById(id));
        }

        [HttpGet("{fileName}")]
        public IActionResult GetFileByName(string fileName)
        {
            return Json(_fileSampleManager.GetByFileName(fileName));
        }
    }
}
