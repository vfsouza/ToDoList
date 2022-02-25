using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ToDoList {
	public class Tarefas {
		public string Data { get; set; }
		public Enum.DiasSemana DiaDaSemana { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public string DataDeEntrega { get; set; }

		public Tarefas() {
			Data = "";
			DiaDaSemana = Enum.DiasSemana.Segunda;
			Titulo = "";
			Descricao = "";
			DataDeEntrega = "";
		}

		public Tarefas(string data, Enum.DiasSemana diaDaSemana, string titulo, string descricao, string dataDeEntrega) {
			Data = data;
			DiaDaSemana = diaDaSemana;
			Titulo = titulo;
			Descricao = descricao;
			DataDeEntrega = dataDeEntrega;
		}
	}
}
