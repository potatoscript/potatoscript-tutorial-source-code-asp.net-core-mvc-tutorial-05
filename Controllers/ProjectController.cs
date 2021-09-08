using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;
using ProjectAPI.Services;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        public ProjectServices _projectService;
        public ProjectController(ProjectServices projectServices)
        {
            _projectService = projectServices;
        }


        [HttpGet("get-all-projects")]
        public IActionResult GetAllProjects()
        {
            var allProjects = _projectService.GetAllProject();

            return Ok(allProjects);
        }

        [HttpGet("get-project-by-id/{id}")]
        public IActionResult GetProjectById(int id)
        {
            var project = _projectService.GetProjectById(id);

            return Ok(project);
        }

        [HttpPost("add-project")]
        public IActionResult AddProject(Project project)
        {
            _projectService.AddProject(project);
            return Ok();
        }

        [HttpPost("update-project-by-id/{id}")]
        public IActionResult UpdateProjectById(Project project, int id)
        {
            var updateProject = _projectService.UpdateProjectById(project, id);
            return Ok(updateProject);
        }

        [HttpPost("delete-project-by-id/{id}")]
        public IActionResult DeleteProjectById(int id)
        {
            _projectService.DeleteProjectById(id);

            return Ok();
        }


    }
}










