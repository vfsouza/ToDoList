using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ToDoList {
	public class Tarefas {
		public string Data { get; set; }
		public string DiaDaSemana { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public string DataDeEntrega { get; set; }

		public Tarefas() {
			Data = "";
			DiaDaSemana = "";
			Titulo = "";
			Descricao = "";
			DataDeEntrega = "";
		}

		public Tarefas(string data, string diaDaSemana, string titulo, string descricao, string dataDeEntrega) {
			Data = data;
			DiaDaSemana = diaDaSemana;
			Titulo = titulo;
			Descricao = descricao;
			DataDeEntrega = dataDeEntrega;
		}
	}
}
