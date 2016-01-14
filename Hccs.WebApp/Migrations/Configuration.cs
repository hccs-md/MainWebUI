namespace Hccs.WebApp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity.Owin;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;
    internal sealed class Configuration : DbMigrationsConfiguration<Hccs.WebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Hccs.WebApp.Models.ApplicationDbContext context)
        {
            //    var PasswordHash = new PasswordHasher();
            //    using (var store = new RoleStore<IdentityRole>(context))
            //    {
            //        var manager = new RoleManager<IdentityRole>(store);
            //        foreach (string roleName in new string[] { "Admin", "Teacher" })
            //        {
            //            if (!context.Roles.Any(r => r.Name == roleName))
            //            {
            //                var role = new IdentityRole { Name = roleName };
            //                manager.Create(role);
            //            }
            //        }
            //    }


            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var roleManager = HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();

            const string name = "it@hccs-md.org";
            const string password = "Admin@123456";
            string[] roles = new string[] { "Dean", "Teacher", "Admin" };


            //Create Role Admin if it does not exist
            foreach (string roleName in roles)
            {
                var role = roleManager.FindByName(roleName);
                if (role == null)
                {
                    role = new ApplicationRole(roleName);
                    var roleresult = roleManager.Create(role);
                }
            }


            var user = userManager.FindByName(name);
            if (user == null)
            {
                Person p = new Person { FirstName = "Fan", LastName = "Yang", ChineseName = "杨帆", Gender = "M", Email = name, CreationDt = DateTime.UtcNow, PersonType = 0 };
                
                user = new ApplicationUser { UserName = name, Email = name, EmailConfirmed = true, Person = p };
                var result = userManager.Create(user, password);
                result = userManager.SetLockoutEnabled(user.Id, false);

            }

            var groupManager = new ApplicationGroupManager();
            var newGroup = new ApplicationGroup("SuperAdmins", "Full Access to All");

            groupManager.CreateGroup(newGroup);
            groupManager.SetUserGroups(user.Id, new string[] { newGroup.Id });

            groupManager.SetGroupRoles(newGroup.Id, roles);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
