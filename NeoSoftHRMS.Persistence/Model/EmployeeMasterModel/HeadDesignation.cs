using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoftHRMS.Persistence.Model.EmployeeMasterModel
{
    public class HeadDesignation
    {
        [Key]
        public int HeadDesignationId { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]

        public string HeadDesignationName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
