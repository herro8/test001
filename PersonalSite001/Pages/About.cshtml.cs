using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SQLite;
using Microsoft.AspNetCore.Hosting;
using Sheng.SQLite.Plus;

namespace PersonalSite001.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        private SQLiteConnection _connection;
        private readonly IHostingEnvironment _hostingEnvironment;
        private DatabaseWrapper _database;
        private string _conn_str;

        public AboutModel(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _conn_str = "Data Source='" + _hostingEnvironment.WebRootPath + "/z/db1.s3db'";
            _database = new DatabaseWrapper(_conn_str);
        }

        public void OnGet()
        {
           
            PeopleEntity _people = new PeopleEntity();
            _people.GUID = Guid.NewGuid().ToString();
            _people.PName = "zhangsan" + DateTime.Now.Millisecond.ToString();
            _people.Ppassword = DateTime.UtcNow.Millisecond.ToString();

            _database.Insert(_people);

            Message = "Insert Done";
          

        }
    }
}
