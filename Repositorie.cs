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
			InitiateRepos();
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
			if (!repos.Contains(tarefa)) {
				repos.Add(tarefa);
				StreamWriter writer = File.AppendText(caminho);
				writer.WriteLine(tarefa.Data + "\t" + tarefa.DiaDaSemana + "\t" + tarefa.Titulo + "\t" + tarefa.Descricao + "\t" + tarefa.DataDeEntrega);
			}
		}

		public void RemoveTarefa(int index) {
			repos.RemoveAt(index);
			Update();
        }

		public void Update() {
			InitiateRepos();
			File.Delete(caminho);
			StreamWriter writer = File.AppendText(caminho);
			repos.ForEach((tarefa) => {
				string[] data = new string[3];
				data = tarefa.Data.Split("/");

				string[] dataAtual = DateTime.Today.ToString().Split("/");
				int mes = int.Parse(dataAtual[1]);

				if (mes > int.Parse(data[1])) {
					repos.Remove(tarefa);
				}
			});
			repos.Sort();
			for (int i = 0; i < repos.Count; i++) {
				repos.ForEach((tarefa) => {
					writer.WriteLine(tarefa.Data + "\t" + tarefa.DiaDaSemana + "\t" + tarefa.Titulo + "\t" + tarefa.Descricao + "\t" + tarefa.DataDeEntrega);
				});
			}
			Console.Clear();
			Console.WriteLine("Repositorio atualizado com sucesso!");
		}
	}
}
