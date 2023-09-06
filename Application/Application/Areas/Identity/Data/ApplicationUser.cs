﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Conversion;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace Application.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    [PersonalData]
    [Column(TypeName="nvarchar(100)")]
    public string FirstName { get; set; }

    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

}

