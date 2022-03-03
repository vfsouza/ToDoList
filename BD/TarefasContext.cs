using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ToDoList.BD.Entities;

namespace ToDoList.BD {
	public class TarefasContext : DbContext {
		public DbSet<Tarefas> Tarefas { get; set; }

		public TarefasContext() : base(System.Environment.GetEnvironmentVariable("SQL_SERVER_CON_STRING")) {
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<TarefasContext, ToDoList.Migrations.Configuration>());
		}
	}
}
