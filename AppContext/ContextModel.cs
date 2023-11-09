using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContext
{
    public class ContextModel:IdentityDbContext
    {
        public ContextModel(DbContextOptions<ContextModel> options)
            :base(options)
        {

        }
        public DbSet<DataModels> models { get; set; }
    }
}
