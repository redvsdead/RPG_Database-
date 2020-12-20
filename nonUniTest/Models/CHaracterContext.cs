using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace nonUniTest.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext() : base("name=CharactersEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<nonUniTest.Models.Character> Characters { get; set; }

        public System.Data.Entity.DbSet<nonUniTest.Models.Race> Races { get; set; }

        public System.Data.Entity.DbSet<nonUniTest.Models.Weapon> Weapons { get; set; }

        public System.Data.Entity.DbSet<nonUniTest.Models.Class> Classes { get; set; }
    }
}