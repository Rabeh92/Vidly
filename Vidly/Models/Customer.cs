using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name ="Date of birth")]
        public DateTime? Brithdate { get; set; }

        public MemberShipType MemberShipType { get; set; }

        [Display(Name ="Membership Type")]
        public byte MemberShipTypeId { get; set; }
    }
}