using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoftHRMS.Persistence.Model.EmployeeMasterModel
{
    public class SeniorHead
    {
        public int SeniorHeadId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string SeniorHeadName { get; set; }

        public HeadDesignation HeadDesignation { get; set; }

        public DateTime CreatedDate { get; set; } 
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
