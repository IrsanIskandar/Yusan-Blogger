using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YusanBlogger.ServicesHelpers
{
    public class ConstansHelpers
    {
        //Property Config Services
        public static string connectionString { get; set; }
        public static string AuthServer { get; set; }

        //appsetting
        public static string connStr { get; set; }
        public static string Authority { get; set; }

        //Time on GMT+0 Timezone
        public static readonly DateTime GMT_TIME =
            TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
    }
}
