namespace EquipmentSystem.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class equipmentTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_EquipmentLend",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        T_EquipmentID = c.Int(nullable: false),
                        LendPersonnel = c.String(),
                        ContactWay = c.String(),
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
                    { "DynamicFilter_T_EquipmentLend_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Equipment", t => t.T_EquipmentID, cascadeDelete: true)
                .Index(t => t.T_EquipmentID)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.T_EquipmentMaintenance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        T_EquipmentID = c.Int(nullable: false),
                        MaintenanceDateTime = c.DateTime(nullable: false),
                        MaintenancePersonnel = c.String(nullable: false, maxLength: 64),
                        MaintenanceStatus = c.Int(nullable: false),
                        Cause = c.String(nullable: false),
                        Image = c.String(),
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
                    { "DynamicFilter_T_EquipmentMaintenance_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Equipment", t => t.T_EquipmentID, cascadeDelete: true)
                .Index(t => t.T_EquipmentID)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.T_EquipmentReturn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        T_EquipmentID = c.Int(nullable: false),
                        ReturnPersonnel = c.String(),
                        ContactWay = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Equipment", t => t.T_EquipmentID, cascadeDelete: true)
                .Index(t => t.T_EquipmentID);
            
            CreateTable(
                "dbo.T_EquipmentScrapping",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        T_EquipmentID = c.Int(nullable: false),
                        ScrappingdDateTime = c.DateTime(nullable: false),
                        Cause = c.String(),
                        Image = c.String(),
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
                    { "DynamicFilter_T_EquipmentScrapping_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Equipment", t => t.T_EquipmentID, cascadeDelete: true)
                .Index(t => t.T_EquipmentID)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_EquipmentScrapping", "T_EquipmentID", "dbo.T_Equipment");
            DropForeignKey("dbo.T_EquipmentReturn", "T_EquipmentID", "dbo.T_Equipment");
            DropForeignKey("dbo.T_EquipmentMaintenance", "T_EquipmentID", "dbo.T_Equipment");
            DropForeignKey("dbo.T_EquipmentLend", "T_EquipmentID", "dbo.T_Equipment");
            DropIndex("dbo.T_EquipmentScrapping", new[] { "IsDeleted" });
            DropIndex("dbo.T_EquipmentScrapping", new[] { "T_EquipmentID" });
            DropIndex("dbo.T_EquipmentReturn", new[] { "T_EquipmentID" });
            DropIndex("dbo.T_EquipmentMaintenance", new[] { "IsDeleted" });
            DropIndex("dbo.T_EquipmentMaintenance", new[] { "T_EquipmentID" });
            DropIndex("dbo.T_EquipmentLend", new[] { "IsDeleted" });
            DropIndex("dbo.T_EquipmentLend", new[] { "T_EquipmentID" });
            DropTable("dbo.T_EquipmentScrapping",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_T_EquipmentScrapping_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.T_EquipmentReturn");
            DropTable("dbo.T_EquipmentMaintenance",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_T_EquipmentMaintenance_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.T_EquipmentLend",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_T_EquipmentLend_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
