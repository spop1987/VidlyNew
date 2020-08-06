namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'054dd89a-e914-46d5-91d3-dfb8dab2a040', N'sergio@domain.com', 0, N'AL36FAeOo//dGmTVojFSMg6o9E06HvaC2VMJG/40EsZGlc+yWJRBkkKyroQ3OVidoA==', N'3c24bab0-d1d7-4b36-abf1-9a3fad75e684', NULL, 0, 0, NULL, 1, 0, N'sergio@domain.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'68cada27-34f4-4892-96ba-a8ac86a625ed', N'admin@vidly.com', 0, N'ABBjOQI5qDSM52CLmpQrASuBZtiU9qHlSPJhbbs4S5GZgasCjkFxqblR0URpoU1b6g==', N'f481f072-bcfa-4fc4-84fc-d0e13833aa25', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c129a3e2-83b1-424a-97a6-e5ef0f28a784', N'guest@vidly.com', 0, N'ALofKJzTmjAv0I/VHcvCST9d/e4przH1mheHamUS77AK7k5JDqx+Ex/jU6f7PN0/wQ==', N'b94c3809-e479-426e-bf8b-472a833bb7f9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5688ce1d-da98-45c3-8cb7-40ec4aef088e', N'CanManageMovies')
            
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'68cada27-34f4-4892-96ba-a8ac86a625ed', N'5688ce1d-da98-45c3-8cb7-40ec4aef088e')
            
            ");
        }
        
        public override void Down()
        {
        }
    }
}
