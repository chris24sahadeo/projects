﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<bookauthor> bookauthors { get; set; }
        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<publisher> publishers { get; set; }
        public virtual DbSet<wishlistitem> wishlistitems { get; set; }
    }
}
