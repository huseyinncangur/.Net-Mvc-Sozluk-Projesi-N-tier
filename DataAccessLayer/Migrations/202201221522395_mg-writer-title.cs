﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgwritertitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Title", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "Title");
        }
    }
}
