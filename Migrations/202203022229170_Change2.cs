namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tarefas", "TarefaName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Tarefas", "TarefaDescricao", c => c.String(maxLength: 200));
            AlterColumn("dbo.Tarefas", "DataDeEntrega", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tarefas", "DataDeEntrega", c => c.String());
            AlterColumn("dbo.Tarefas", "TarefaDescricao", c => c.String());
            AlterColumn("dbo.Tarefas", "TarefaName", c => c.String());
        }
    }
}
