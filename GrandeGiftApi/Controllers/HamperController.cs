using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrandeGiftApi.Models;
using GrandeGiftApi.Repository;
using GrandeGiftApi.Models.DataManager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrandeGiftApi.Controllers
{
    [Route("api/hampers")]
    [ApiController]
    public class HamperController : ControllerBase
    {
        private readonly HamperDataManager _manager;

        public HamperController(HamperDataManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("gethampers")]
        public IEnumerable<Hampers> GetAllHampers()
        {
            return _manager.GetAll();
        }

        [HttpGet("{id}")]
        public IEnumerable<Hampers> GetByCategory([FromRoute] int id)
        {
            return _manager.GetByCategory(id);
        }

        [HttpGet]
        [Route("categories")]
        public IEnumerable<HamperCategory> GetCategories()
        {
            return _manager.GetCategories();
        }

        
    }
}
