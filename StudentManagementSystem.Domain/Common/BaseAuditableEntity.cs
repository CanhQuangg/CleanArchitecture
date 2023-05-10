using StudentManagementSystem.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Domain.Common
{
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
        public abstract int? CreatedUser { get; set; }
        public abstract string? CreatedScreen { get; set; }
        public abstract DateTime? CreatedDate { get; set; }
        public abstract int? UpdatedUser { get; set; }
        public abstract string? UpdatedScreen { get; set; }
        public abstract DateTime? UpdatedDate { get; set; }
        public abstract byte[] TimeStamp { get; set;}
    }
}
