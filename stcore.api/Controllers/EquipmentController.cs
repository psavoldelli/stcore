using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stcore.business;
using stcore.model;

namespace stcore.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly ILogger<EquipmentController> Logger;
        
        private readonly EquipmentService Equipment;
        
        public EquipmentController(ILogger<EquipmentController> logger, EquipmentService equipment)
        {
            Logger = logger;
            Equipment = equipment;
        }

        [HttpGet]
        public IEnumerable<EquipmentModel> List()
        {
            return Equipment.List();
        }

        [HttpGet("{id}")]
        public EquipmentModel Get(string id)
        {
            return Equipment.Get(id);
        }

        [HttpPost]
        public EquipmentModel Save(EquipmentModel ingredient)
        {
            return Equipment.Save(ingredient);
        }

        
        [HttpDelete]
        public bool Delete(string id)
        {
            return Equipment.Delete(id);
        }
    }
}
