using HaberAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class HaberController : ControllerBase
    {
        private HaberContext _haberContext;
        public HaberController(HaberContext haberContext)
        {
            _haberContext = haberContext;
        }
        [HttpGet("/haberlerigetir")]
        public IActionResult HaberleriGetir()
        {
            return Ok(_haberContext.Haberler.ToList());
        }
    }
}
