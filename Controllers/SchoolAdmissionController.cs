using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAdmissioionManagement.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissioionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolAdmissionController : ControllerBase
    {
        // GET: api/<SchoolAdmissionController>
        [HttpGet]
        public IEnumerable<StudentsAdmissionModels> Get()
        {
            StudentsAdmissionModels admissionobj1 = new StudentsAdmissionModels();
            StudentsAdmissionModels admissionobj2 = new StudentsAdmissionModels();
            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Adam";
            admissionobj1.StudentClass = "X";
            admissionobj1.DateofJoining = DateTime.Now;
            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Brad";
            admissionobj2.StudentClass = "IX";
            admissionobj2.DateofJoining = DateTime.Now;
            List<StudentsAdmissionModels> listofobj = new List<StudentsAdmissionModels>
{
admissionobj1,
admissionobj2
};
            return listofobj;
        }
    }
}




