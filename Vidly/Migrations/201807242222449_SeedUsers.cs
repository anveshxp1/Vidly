namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6242438f-e396-44c7-b5be-ed53e8a5f4ee', N'admin@vidly.com', 0, N'ALjLEhoBcngUrtMxWN6QeErZdf5NkZuPbkVq/VPb9/i4TYfOcheLzyCdEuaOGvKKRA==', N'4fd2f2e1-b1f5-470e-b6a1-321394ec2a9e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'67a3c0c1-a0ac-4361-b68a-23d7df015766', N'guest@vidly.com', 0, N'AAVz1uiFJQ8K7cn0OeDq2cmb7cGKzx1OeZZeXY0ToXFrqIW8bsswVp9aN+ArXdJR0Q==', N'bdadce38-40f1-45ac-8f6c-9a98d05199d0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'086cae15-c001-4dd9-b68d-b456c2bbbbdf', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6242438f-e396-44c7-b5be-ed53e8a5f4ee', N'086cae15-c001-4dd9-b68d-b456c2bbbbdf')"
                    );
        }
        
        public override void Down()
        {
        }
    }
}
