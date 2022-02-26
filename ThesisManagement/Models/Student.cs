using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("Students")]
    public class Student
    {
        #region Navigation Properties to User
        
        [Display(Name ="User Id")]
        [Required]
        [ForeignKey(nameof(Student.User))]
         public int UserId { get; set; }
        
        
        [Display(Name ="User Id")]
        public User User { get; set; }
        
        #endregion

        [Display(Name = "Student Enrr_Id")]
        [Required]
        [Key]
        public int EnrollId { get; set; }

        #region Navigation Properties
        public ICollection<ThesisAssign> ThesisAssigns { get; set; }

        #endregion

        [Display(Name = "Parent Name")]
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ParentName { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public System.DateTime DateOfBirth { get; set; }

       
    }
}
