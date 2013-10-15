using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ImageHoster.Models
{
    public class ImageHosterContext : DbContext
    {
        public DbSet<ImageInformation> ImageInformations { get; set; }
        public DbSet<ImageData> ImageDatas { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}