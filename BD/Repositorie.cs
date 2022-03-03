using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BD.Entities;
using System.Data.Entity.Migrations;

namespace ToDoList.BD {
	public class Repositorie {
		private static TarefasContext db = new TarefasContext();
		private static Repositorie repos;

		private Repositorie() { }

		public static Repositorie GetInstance() {
			if (repos == null)
				repos = new Repositorie();
			return repos;
		}

		public int GetMaxId() {
			return db.Tarefas.Max(b => b.TarefaId);
		}

		public Tarefas GetById(int id) {
			return db.Tarefas.Where(b => b.TarefaId == id).First();
		}

		public Tarefas[] GetByMateria(Enum.Materias materia) {
			return db.Tarefas.Where((b) => b.Materia == materia).ToArray();
		}

		public void Add(Tarefas tarefa) {
			db.Tarefas.Add(tarefa);
			db.SaveChanges();
		}

		public void Delete(int id) {
			Tarefas tarefa = db.Tarefas.Find(id);
			db.Tarefas.Remove(tarefa);
			db.SaveChanges();
		}

		public void Update(Tarefas tarefa) {
			db.Tarefas.AddOrUpdate(tarefa);
			db.SaveChanges();
		}

		public Tarefas[] GetByNextSevenDays() {
			string[] today = DateOnly.FromDateTime(DateTime.Today).ToString().Substring(0, 5).Split("/");
			int month = int.Parse(today[0]);
			return db.Tarefas
				.Where(b => b.MesEntrega >= month)
				.OrderBy(b => b.MesEntrega)
				.ThenBy(b => b.DiaEntrega)
				.Take(7)
				.ToArray();
		}
	}
}
