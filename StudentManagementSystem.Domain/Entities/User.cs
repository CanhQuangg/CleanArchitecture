using StudentManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ManagerCode { get; set; }
        public string RoleCode { get; set; }
        public string GroupCode { get; set; }
        public DateTime RegistrationDate { get; } = DateTime.Now;
        public int ExpireDate { get; set; } = 999;
        public string Status { get; set; } = "AC";
        public DateTime RecentLogin { get; set; } = DateTime.Now;

        public override int? CreatedUser { get ; set; }
        public override string? CreatedScreen { get; set; }
        public override DateTime? CreatedDate { get; set; }
        public override int? UpdatedUser { get; set; }
        public override string? UpdatedScreen { get; set; }
        public override DateTime? UpdatedDate { get; set; }
        public override byte[] TimeStamp { get; set; }
    }
}
