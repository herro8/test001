using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sheng.SQLite.Plus;

namespace PersonalSite001
{
    [Table("People")]
    public class PeopleEntity
    {
        [Column("GUID")]
        public string GUID { get; set; }
        [Column("PName")]
        public string PName { get; set; }
        [Column("Ppassword")]
        public string Ppassword { get; set; }
    }
}
