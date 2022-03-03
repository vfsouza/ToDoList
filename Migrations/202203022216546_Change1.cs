﻿namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tarefas", "DataDeEntrega", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tarefas", "DataDeEntrega", c => c.DateTime(nullable: false));
        }
    }
}
