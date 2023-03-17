//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Http;
//using System.Threading.Tasks;

//namespace _10.Error
//{
//    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
//    public class TestMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public TestMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task Invoke(HttpContext httpContext)
//        {
//            try
//            {
//                await _next(httpContext);
//            }
//            catch (Exception ex)
//            {
//                string path = "@D:\\1-maktab\\1-HW\\10\\hw\\10\\ErrorLog.txt";
//                File.AppendAllText(path, DateTime.Now.ToString() + ":" + ex.Message);


//                httpContext.Response.Redirect("/Home/Error");

//            }
//        }
//    }

//    // Extension method used to add the middleware to the HTTP request pipeline.
//    public static class TestMiddlewareExtensions
//    {
//        public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder builder)
//        {
//            return builder.UseMiddleware<TestMiddleware>();
//        }
//    }
//}
