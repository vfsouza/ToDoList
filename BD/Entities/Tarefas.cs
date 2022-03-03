using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList;

namespace ToDoList.BD.Entities {
	public class Tarefas {
		[Key]
		public int TarefaId { get; set; }
		[Required]
		[MaxLength(50)]
		public string TarefaName { get; set; }
		[MaxLength(200)]
		public string TarefaDescricao { get; set; }
		[Required]
		public int DiaEntrega { get; set; }
		[Required]
		public int MesEntrega { get; set; }
		public Enum.Materias? Materia { get; set; }

		public override string ToString() {
			return ($"ID = {TarefaId} NAME = {TarefaName} DESCRIÇÃO = {TarefaDescricao} DIA = {DiaEntrega} MES = {MesEntrega} MATERIA = {Materia}");
		}
	}
}
