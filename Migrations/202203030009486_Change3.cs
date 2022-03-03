namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tarefas", "DiaEntrega", c => c.Int(nullable: false));
            AddColumn("dbo.Tarefas", "MesEntrega", c => c.Int(nullable: false));
            AlterColumn("dbo.Tarefas", "TarefaName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Tarefas", "Materia", c => c.Int());
            DropColumn("dbo.Tarefas", "DataDeEntrega");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tarefas", "DataDeEntrega", c => c.String(maxLength: 10));
            AlterColumn("dbo.Tarefas", "Materia", c => c.Int(nullable: false));
            AlterColumn("dbo.Tarefas", "TarefaName", c => c.String(maxLength: 50));
            DropColumn("dbo.Tarefas", "MesEntrega");
            DropColumn("dbo.Tarefas", "DiaEntrega");
        }
    }
}
