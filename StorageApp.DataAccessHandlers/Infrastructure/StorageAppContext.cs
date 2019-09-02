using Microsoft.EntityFrameworkCore;
using StorageApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.DataAccessHandlers.Infrastructure
{
    public class StorageAppContext : DbContext
    {
        public StorageAppContext(DbContextOptions options) : base(options) {

        }

        public virtual DbSet<FileSampleEntity> FileSamples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            var options = new DbContextOptionsBuilder<StorageAppContext>().EnableSensitiveDataLogging().Options;

            //FileSamples
            var myFile1 = new FileSampleEntity() { Id = 1, FileName = "FileName1" };
            var myFile2 = new FileSampleEntity() { Id = 2, FileName = "FileName2" };
            var myFile3 = new FileSampleEntity() {  Id = 3, FileName = "FileName3" };
            modelBuilder.Entity<FileSampleEntity>().HasData(myFile1, myFile2, myFile3);
        }

        
    }
}
