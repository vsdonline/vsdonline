using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using VSDOnline.Models;

[assembly: OwinStartupAttribute(typeof(VSDOnline.Startup))]
namespace VSDOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if(!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);


                var user = userManager.FindByEmail("admin@viswasaidwarakamai.com");

                if (user != null && !string.IsNullOrEmpty(user.Id))
                {
                    var results = userManager.AddToRole(user.Id, "Admin");
                }
            }

        }
    }
}
