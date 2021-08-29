using System.ComponentModel.DataAnnotations;

namespace LostAnimals.Web.Endpoints.ProjectEndpoints
{
    public class CreateProjectRequest
    {
        public const string Route = "/Projects";

        [Required]
        public string Name { get; set; }
    }
}