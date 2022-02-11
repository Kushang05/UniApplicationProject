using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace UniApp.Web.Models

{
    public class MyIdentityRole
        :IdentityRole<Guid>
    {
        [Display(Name ="Description")]
        [StringLength(100 , ErrorMessage ="{0} cannot be more then {1} characters !!!")]
        public string Description { get; set; }  
    }
}
