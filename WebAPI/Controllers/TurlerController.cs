using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurlerController : ControllerBase
    {
        ITurService _turService;



        public TurlerController(ITurService turService)
        {
            _turService = turService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _turService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _turService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("Add")]
        public IActionResult Add(Tur tur)
        {
            var result = _turService.Add(tur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Tur tur)
        {
            var result = _turService.Delete(tur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Tur tur)
        {
            var result = _turService.Update(tur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        


    }
}
