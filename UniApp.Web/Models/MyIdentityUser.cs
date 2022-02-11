using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;  //for using <Guid> Guid generate unique id globally


namespace UniApp.Web.Models
{
    public class MyIdentityUser
        :IdentityUser<Guid>
    {
        [Display(Name ="Dispaly Name")]
        [Required (ErrorMessage ="{0} cannot be EMPTY !!!!")]
        [MinLength(3, ErrorMessage ="{0} cannot be less than {1} !!")]
        [StringLength(50, ErrorMessage ="{0} cannot be more than {1} characters") ]
        public string DisplayName { get; set; }


        [Display(Name ="Date of Birth")]
        [Required]
        [PersonalData]
        [Column(TypeName ="smalldatetime")]
        public DataType DateOfBirth { get; set; }


        [Display (Name ="Is Admin User")]
        [Required]
        public bool IsAminUser { get; set; }
    }
}
