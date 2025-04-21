using System.ComponentModel.DataAnnotations;

namespace ContactListo.Domain
{
    public class Contact
    {
        [Key]
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
