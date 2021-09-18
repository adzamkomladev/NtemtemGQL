using System.ComponentModel.DataAnnotations;

namespace NtemtemGQL.Models
{
    public class WorkPeriod
    {
        public int Id { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        public Organization Organization { get; set; }
    }
}