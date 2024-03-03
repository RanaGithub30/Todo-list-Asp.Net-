using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Todo.FrontEndRoute
{
    public static class FrontEnd
    {
        public static void ConfigureCustomRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "root",
                pattern: "/",
                defaults: new { controller = "AuthManage", action = "Login" });
            
            endpoints.MapControllerRoute(
                name: "login",
                pattern: "login",
                defaults: new { controller = "AuthManage", action = "Login" });
            
            endpoints.MapControllerRoute(
                name: "register",
                pattern: "register",
                defaults: new { controller = "AuthManage", action = "Register" });
            
            endpoints.MapControllerRoute(
                name: "register-action",
                pattern: "register-action",
                defaults: new { controller = "AuthManage", action = "RegisterAction" });
        }
    }
}