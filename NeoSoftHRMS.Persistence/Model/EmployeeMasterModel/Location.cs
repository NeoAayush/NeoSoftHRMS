using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoftHRMS.Persistence.Model.EmployeeMasterModel
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]

        public string LocationName { get; set; }

        public City City { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
