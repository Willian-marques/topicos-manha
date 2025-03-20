using System;
using Microsoft.EntityFrameworkCore;
using API.Models;  // Certifique-se de que o namespace correto está sendo usado.

public class AppDataContext : DbContext
{
    // DbSet de Carro para representar a tabela "Carros" no banco de dados
    public DbSet<Carro> Carros { get; set; }

    // Método para configurar a conexão com o banco de dados
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Definir a string de conexão com o banco de dados SQLite
        optionsBuilder.UseSqlite("Data Source=willian.db");
    }
}
