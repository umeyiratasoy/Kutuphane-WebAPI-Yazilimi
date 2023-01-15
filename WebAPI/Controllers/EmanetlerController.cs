using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmanetlerController : ControllerBase
    {
        IEmanetService _emanetService;

        public EmanetlerController(IEmanetService emanetService)
        {
            _emanetService = emanetService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _emanetService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _emanetService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("Add")]
        public IActionResult Add(Emanet emanet)
        {
            var result = _emanetService.Add(emanet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Emanet emanet)
        {
            var result = _emanetService.Delete(emanet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Emanet emanet)
        {
            var result = _emanetService.Update(emanet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getemanetdetaylar")]
        public IActionResult GetEmanetDetaylar()
        {
            var result = _emanetService.GetEmanetDetaylar();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }




    }
}
