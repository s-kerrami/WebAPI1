using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DAL.Config;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL
{
    public class ButterContext:DbContext
    {
        private readonly string _cnstr;
        public DbSet<UserEntity> Users { get; set; }
        //DbSet<FriendEntity> Friends { get; set; }

        /// <summary>
        /// Constructeur pour les migrations uniquement
        /// </summary>
        public ButterContext()
        {
            this._cnstr = "Data Source=GOS-VDI509\\tftic;database=ButterDb;Integrated Security=True;TrustServerCertificate=True;";

        }

        public ButterContext(string cnstr)
        {
            this._cnstr = cnstr;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_cnstr);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<UserEntity>(new UserConfig());
            modelBuilder.ApplyConfiguration<FriendEntity>(new FriendsConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
