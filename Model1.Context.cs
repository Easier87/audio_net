﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace audio_net
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class audiodbEntities : DbContext
    {
        private static audiodbEntities _context;
        public audiodbEntities()
            : base("name=audiodbEntities")
        {
        }

        public static audiodbEntities GetContext()
        {
            if (_context == null)
                _context = new audiodbEntities();

            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Song> Song { get; set; }
    }
}
