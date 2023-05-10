using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Domain.Common.Interfaces
{
    public interface IAuditableEntity : IEntity
    {
        int? CreatedUser { get; set; }
        string? CreatedScreen { set; get; }
        DateTime? CreatedDate { get; set; }
        int? UpdatedUser { get; set; }
        string? UpdatedScreen { set; get; }
        DateTime? UpdatedDate { get; set; }
        byte[] TimeStamp { get; set; }
    }
}
