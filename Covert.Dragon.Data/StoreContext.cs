﻿using Covert.Dragon.Api.Domain.Catalog;
using Microsoft.EntityFrameworkCore; 

namespace Covert.Dragon.Data 
{ 
    public class StoreContext: DbContext 
    { 
        public StoreContext( DbContextOptions< StoreContext> options)
           : base( options) 
        {}
        public DbSet<Item> Items { get; set; }
    }
}