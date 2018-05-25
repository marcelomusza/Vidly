namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7c747983-69e6-4215-accb-ffe3d88a2e42', N'guest@vidly.com', 0, N'APVt4xsTMC98SSWzZv5MMt2qxAW2XxFoVIi6KjArkJVXPT02DFsUiJwdfa18s8aa1Q==', N'6fbbe7be-3af9-4cac-94ef-df8d3f4e156d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8cf2e776-6646-406a-ba4d-90be91c076a9', N'admin@vidly.com', 0, N'AEkK1HBKB7BLAhwYyCv7S21M33G+D/uCithJPRSs5AgLUfEVcPBkO8qgsLHekgsjlw==', N'5d5e7a43-783d-4c9b-9446-ec6360378817', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cd07ffe4-50be-4027-89a4-5f03eeacf580', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8cf2e776-6646-406a-ba4d-90be91c076a9', N'cd07ffe4-50be-4027-89a4-5f03eeacf580')
            

            ");

        }
        
        public override void Down()
        {
        }
    }
}
