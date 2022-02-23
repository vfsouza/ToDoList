using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList {
	public class Repositorie {
		public List<Tarefas> repos;
		private string caminho = new string("./BD/BD.txt");

		public Repositorie() {
			repos = new List<Tarefas>();
		}

		public void InitiateRepos() {
			string[] str = new string[5];
			StreamReader reader = File.OpenText(caminho);
			while (!reader.EndOfStream) { 
				str = reader.ReadLine().Split(' ');

				Tarefas tarefa = new Tarefas(str[0], str[1], str[2], str[3], str[4]);

				repos.Add(tarefa);
			}
			repos.Sort();
		}

		public void AddTarefa(Tarefas tarefa) {
			if(repos.Find(tarefa))
			repos.Add(tarefa);
		}
	}
}
