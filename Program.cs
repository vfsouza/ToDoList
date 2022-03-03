using System;
using ToDoList.BD;
using ToDoList.BD.Entities;

namespace ToDoList {
	public class Program {

		public static void Main(String[] args) {
			Environment.LoadEnv();

			Repositorie repos = Repositorie.GetInstance();

			repos.Add(new Tarefas { TarefaName = "z", TarefaDescricao = "z", DiaEntrega = 1, MesEntrega = 1, Materia = Enum.Materias.ES });


			/*int option = new int();
			do {
				Menu(out option);

				switch (option) {
					case 1:

						break;

					case 2:

						break;

					case 3:

						break;

					default:
						Console.Clear();
						Console.WriteLine("Opção inválida!\n\n");
						Thread.Sleep(2000);
						Console.Clear();
						break;
				}
			} while (option < 1 && option > 3);*/
		}

		private static void Menu(out int option) {
			Console.Write("Menu de opções" +
				"1. Listar tarefas da semana\n" +
				"2. Listar todas as tarefas do mês\n" + 
				"3. Adicionar tarefa\n\n" +
				": ");
			option = int.Parse(Console.ReadLine());
		}

		private static void ListarSemana() {

		}
	}
}