using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceStack.Redis;

namespace PersonalSite001.Pages
{
    public class RedisTestModel : PageModel
    {
        public string Message { get; set; }
        private string _redisConnectionString;

        public RedisTestModel()
        {
            _redisConnectionString = "redis://localhost:6379";
        }
        public void OnGet()
        {
            var clientsManager = new BasicRedisClientManager(_redisConnectionString);
            using (IRedisClient redis = clientsManager.GetClient())
            {
                //var ret = redis.Custom("set", "c", 345);

                var ret = redis.Custom("get", "a");
                Message = ret.Text;


                /*
                    var ret = Redis.Custom("SET", "foo", 1);          // ret.Text = "OK"
                    byte[] cmdSet = Commands.Set;
                    ret = Redis.Custom(cmdSet, "bar", "b");           // ret.Text = "OK"
                    ret = Redis.Custom("GET", "foo");                 // ret.Text = "1"
                    var ret = Redis.Custom(Commands.Keys, "*");
                    var keys = ret.GetResults();                      // keys = ["foo", "bar"]
                    ret = Redis.Custom(Commands.MGet, "foo", "bar");
                    var values = ret.GetResults();                    // values = ["1", "b"]
                    Enum.GetNames(typeof(DayOfWeek)).ToList()
                        .ForEach(x => Redis.Custom(Commands.RPush, "DaysOfWeek", x));
                    ret = Redis.Custom(Commands.LRange, "DaysOfWeek", 1, -2);
                    var weekDays = ret.GetResults();      
                    weekDays.PrintDump(); // ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"]
                    var ret = Redis.Custom(Commands.Set, "foo", new Poco { Name = "Bar" }); // ret.Text = "OK"
                    ret = Redis.Custom(Commands.Get, "foo");          // ret.Text =  {"Name":"Bar"}
                    Poco dto = ret.GetResult<Poco>();
                    dto.Name.Print(); // Bar
                 */


            }
        }
    }
}