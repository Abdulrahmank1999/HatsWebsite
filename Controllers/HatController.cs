using HatsApi.Modules;
using HatsApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HatController : Controller
    {
        private readonly IHatService _Hat;

        public HatController(IHatService Hat)
        {
            _Hat = Hat;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Hat> H = _Hat.GetHats();

            return Json(H);
        }

        [HttpPost]//[FromBody]
        public IActionResult Add([FromForm] Hat H)
        {
            
            if (_Hat.AddHat(H) == true)
            { 
                return Json(H); 
            }
            else
            {
                string O = "Not Succsess";

                return Json(O);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromForm] Hat H)
        {
            if (_Hat.DeleteHat(H) == true)
            {
                return Json(H);
            }
            else
            {
                string O = "Not Succsess";

                return Json(O);
            }
        }

        [HttpPut]
        public IActionResult Update([FromForm] Hat H)
        {
            if (_Hat.UpdateHat(H) == true)
            {
                return Json(H);
            }
            else
            {
                string O = "Not Succsess";

                return Json(O);
            }
        }

        
    }
}
