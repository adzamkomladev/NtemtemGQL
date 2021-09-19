using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NtemtemGQL.Models
{
    public class Organization
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<WorkPeriod> WorkPeriods { get; set; } = new List<WorkPeriod>();

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}