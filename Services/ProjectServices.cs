using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Services
{
    
    public class ProjectServices
    {
        private ProjectDbContext _context;
        public ProjectServices(ProjectDbContext context)
        {
            _context = context;

        }


        //GetAllProjects get all the data in the database table
        public List<Project> GetAllProject() => _context.Projects.OrderBy(n => n.ProjectId).ToList();

        //GetProjectById get the data of the particular id inside the table
        public Project GetProjectById(int projectId) =>
            _context.Projects.FirstOrDefault(n => n.ProjectId == projectId);


        //AddProject
        public void AddProject(Project project)
        {
            //var _project = new Project()
            //{
            //    title = project.title,
            //    owner = project.owner,
            //    duedate = project.duedate

            //};
            var _project = new Project();
            _project.title = project.title;
            _project.owner = project.owner;
            _project.duedate = project.duedate;

            _context.Projects.Add(_project);
            _context.SaveChanges();
        }

        //UpdateProjectById
        public Project UpdateProjectById(Project project, int projectId)
        {
            var _project = _context.Projects.FirstOrDefault(n => n.ProjectId == projectId);
            if (_project != null)
            {
                _project.title = project.title;
                _project.owner = project.owner;
                _project.duedate = project.duedate;
                _context.SaveChanges();
            }

            return _project;
        }

        //DeleteProjectById
        public void DeleteProjectById(int projectId)
        {
            var _project = _context.Projects.FirstOrDefault(n => n.ProjectId == projectId);
            if (_project != null)
            {
                _context.Projects.Remove(_project);
                _context.SaveChanges();

            }
        }
    }

}
