using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace LibApp.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public  string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
       
    }
}