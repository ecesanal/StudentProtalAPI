﻿
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.DataModels;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;
        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
            var students = studentRepository.GetStudents();

                return Ok(mapper.Map<List<Studentt>>(students));
            
        }
    }
}
