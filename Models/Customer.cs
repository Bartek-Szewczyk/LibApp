using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Customer
    {
        [Required]
        [StringLength(255)]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public bool HasNewsletterSubscribed { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}