using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entites
{
    public class UserDetail:BaseEntity
    {        
        public string Explanation { get; set; }
        public string Username { get; set; }
        public bool State { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Job { get; set; }

        public int? UserID { get; set; }
        public Users User { get; set; }

        
    }
}
