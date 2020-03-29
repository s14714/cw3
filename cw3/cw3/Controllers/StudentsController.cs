using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw3.DAL;
using cw3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw3.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]

    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]

        public IActionResult GetStudent(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        //public string GetStudent(string orderBy)
        //{
        //    return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        //}

        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }
            return NotFound("Nie znaleziono Studenta");
        }
        public String getStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }

    }


}
