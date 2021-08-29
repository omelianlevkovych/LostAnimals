using System.Collections.Generic;
using LostAnimals.Core.ProjectAggregate;

namespace LostAnimals.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
