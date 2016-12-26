using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEntity.Migrations
{
    [DbContext(typeof(LogContext))]
    [Migration("20161222121945_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyEntity.LogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Exception");

                    b.Property<string>("Level");

                    b.Property<string>("Logger");

                    b.Property<string>("Message");

                    b.Property<string>("Thread");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });
        }
    }
}
