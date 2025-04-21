using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.DTO
{
    public class ContactDto
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string Address { get; set; } = default!;

        [Required]
        public string PhoneNumber { get; set; } = default!;

        public string? Notes { get; set; }
    }
}
