﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalabalarJurnali.Data.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AvatarUrl { get; set; }
    public Guid GroupId { get; set; }
    public ERole UserRole { get; set; } 
    [ForeignKey(nameof(GroupId))]
    public virtual Group? Group { get; set; }
}
