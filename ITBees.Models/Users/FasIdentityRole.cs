using System;
using Microsoft.AspNetCore.Identity;

namespace ITBees.Models.Users;

public class FasIdentityRole : IdentityRole<Guid>
{
    public FasIdentityRole()
    {
        
    }
    public FasIdentityRole(string roleName) : base(roleName)
    {
        
    }
}