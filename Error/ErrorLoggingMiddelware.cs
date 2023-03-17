//namespace _10.Error
//{
//    public class ErrorLoggingMiddelware
//    {
//        private readonly RequestDelegate _next;
//        public ErrorLoggingMiddelware(RequestDelegate next)
//        {
//            _next = next;
//        }
//        public async Task Invoke(HttpContext Context)
//        {
//            try
//            {
//               await _next(Context);
//            }
//            catch (Exception ex)
//            {
//                string path = "@D:\\1-maktab\\1-HW\\10\\hw\\10\\ErrorLog.txt";
//                using(StreamWriter s=File.AppendText(path)) 
//                {
//                    s.WriteLine(DateTime.Now.ToString() + ":" + ex.Message);
//                }
              
//                Context.Response.Redirect("/Home/Error");

//            }
//        }
//    }
//}
