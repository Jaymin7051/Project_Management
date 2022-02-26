using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("Faculties")]
    public class Faculty
    {
        #region Navogation Properties 
        
        [Display(Name = "User Id")]
        [Key]
        [Required]
        [ForeignKey(nameof(Faculty.User))]
        public int UserId { get; set; }


        [Display(Name = "User Id")]
        public User User { get; set; }

        #endregion

        [Display(Name = "RoleType")]
        [Required]
        // [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string RoleType { get; set; }

        [Display(Name = "Subject Name")]
        [Required]
        [StringLength(70)]
        [Column(TypeName = "varchar")]
        public string SubjectName { get; set; }

        #region Navigation Properties to ThesisAssign
            public ICollection<ThesisAssign> ThesisAssigns { get; set; }
        
        #endregion
    }
}
