using System;
using System.ComponentModel.DataAnnotations;

namespace NtemtemGQL.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public string ExtraInfo { get; set; }

        public string Reason { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public string ClientPhone { get; set; }

        public string ClientEmail { get; set; }

        [Required]
        public string Timezone { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Organization Organization { get; set; }
    }
}