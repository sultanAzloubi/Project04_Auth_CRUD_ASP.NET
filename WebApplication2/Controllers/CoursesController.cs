﻿using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Helpers;

namespace WebApplication2.Controllers
{
    [Route("api")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly JwtService _jwtService;
        
        public CoursesController(IUserRepository repository, JwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }
        
        [HttpGet("courses")]
        public IActionResult Index()
        {
            return Ok(_repository.getCourses());
        }
    }
}