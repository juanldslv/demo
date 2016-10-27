using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class democontext:DbContext
    {
        public democontext():base("DefaultConnection")
        {


        }

        public DbSet<State> States { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Voting> Votings { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.User> Users { get; set; }
    }
}