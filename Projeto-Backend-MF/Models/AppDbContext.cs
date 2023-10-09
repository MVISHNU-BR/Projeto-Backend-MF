﻿using Microsoft.EntityFrameworkCore;

namespace Projeto_Backend_MF.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}