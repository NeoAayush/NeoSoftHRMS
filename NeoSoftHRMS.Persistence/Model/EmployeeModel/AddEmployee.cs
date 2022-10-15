using NeoSoftHRMS.Persistence.Model.EmployeeMasterModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoftHRMS.Persistence.Model.EmployeeModel
{
    public class AddEmployee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Branch Branch { get; set; }

        [Column(TypeName = "NVARCHAR(250)")]
        public string Address { get; set; }

        [Column(TypeName = "NVARCHAR(5)")]
        public string? IndianExtNo { get; set; }

        [Column(TypeName = "NVARCHAR(15)")]
        public string? IndianLandLine { get; set; }

        [Column(TypeName = "NVARCHAR(20)")]
        public string? IndianMobile { get; set; }

        [Column(TypeName = "NVARCHAR(15)")]
        public string? USLandLine { get; set; }

        [Column(TypeName = "NVARCHAR(20)")]
        public string USMobile { get; set; }

        [Column(TypeName = "NVARCHAR(15)")]
        public string SkypeId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string? CcEmail { get; set; }

        public HeadDesignation HeadDesignation { get; set; }

        public SeniorHead SeniorHead { get; set; }

        public DateTime JoinDate { get; set; }

        [Column(TypeName = "NVARCHAR(8)")]
        public string DutyHour { get; set; }

        public bool LeftCompany { get; set; }

        public DateTime LeftDate { get; set; }

        [Column(TypeName = "NVARCHAR(30)")]
        public string UserName { get; set; }

        [Column(TypeName = "NVARCHAR(32)")]
        public string Password { get; set; }
        [Column(TypeName = "NVARCHAR(20)")]

        public string EmployeeCode { get; set; }

        public Designation Designation { get; set; }

        public Division Division { get; set; }

        public Country Country { get; set; }

        public State State { get; set; }

        public City City { get; set; }

        public Location Location { get; set; }

        [Column(TypeName = "NVARCHAR(6)")]
        public string Pincode { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string Email { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string? BccEmail { get; set; }

        public string PanNumber { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public Shift Shift { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]

        public string Image { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Signature { get; set; }


        public EmployeeType EmployeeType { get; set; }

        public AccessGroup AccessGroup { get; set; }

        public bool LoginStatus { get; set; }




    }
}
