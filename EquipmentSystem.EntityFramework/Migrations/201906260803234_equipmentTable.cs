namespace EquipmentSystem.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class equipmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Equipment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentNumber = c.String(nullable: false, maxLength: 64),
                        EquipmentName = c.String(nullable: false, maxLength: 64),
                        ProductionDateTime = c.DateTime(nullable: false),
                        BuyDateTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Image = c.String(),
                        T_EquipmentTypeID = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_T_Equipment_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_EquipmentType", t => t.T_EquipmentTypeID, cascadeDelete: true)
                .Index(t => t.T_EquipmentTypeID)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.T_EquipmentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 16),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_Equipment", "T_EquipmentTypeID", "dbo.T_EquipmentType");
            DropIndex("dbo.T_Equipment", new[] { "IsDeleted" });
            DropIndex("dbo.T_Equipment", new[] { "T_EquipmentTypeID" });
            DropTable("dbo.T_EquipmentType");
            DropTable("dbo.T_Equipment",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_T_Equipment_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
