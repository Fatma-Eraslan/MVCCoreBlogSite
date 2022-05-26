using BlogSiteCore.Entities;
using BlogSiteCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteEntity.Concrete
{
    public class UserDetail : BaseEntity
    {
        public bool? IsActive { get; set; }
        public string Explanation { get; set; }
        public string Username { get; set; }
        //public bool State { get; set; }
        public string Photo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        public bool? Gender { get; set; }
        public string Job { get; set; }
        public UserRole UserRole { get; set; } = UserRole.StandardUser;

        public int? UserID { get; set; }
        public User User { get; set; }
    }
}
