using ListaTarefaApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ListaTarefaApi.Data
{
    public class ListaTarefasContext : DbContext
    {
        public ListaTarefasContext(DbContextOptions<ListaTarefasContext> options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TipoTarefa { get; set; }
    }
}

