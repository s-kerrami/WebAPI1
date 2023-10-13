using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Config
{
    internal class PayementConfig : IEntityTypeConfiguration<PayementEntity>
    {
        public void Configure(EntityTypeBuilder<PayementEntity> builder)
        {
            //Pas une bonne idée d'avoir un nom fr alors qu'on
            // est en En ..;En bref change moi ça !!!!!!!
            builder.ToTable("MoyenDePaiement");

            //Définir nos colonnes
            //PK
            builder.HasKey(e => e.PayementId)
                   .HasName("Pk_Payement")
                   .IsClustered(true);
            //auto-increment PK       
            builder.Property(e => e.PayementId)
                   .ValueGeneratedOnAddOrUpdate();

            builder.Property(e => e.PayementName)
                   .HasColumnType("nvarchar")
                   .IsRequired()
                   .HasMaxLength(200);
        }
    }
}
