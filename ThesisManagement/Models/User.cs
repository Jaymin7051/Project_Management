using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("Users")]
    public class User
    {
        [Display(Name = "User Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string UserName { get; set; }

        [Display(Name = "User Email")]
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string UserEmail { get; set; }

        [Display(Name = "Phone")]
        [Required]
        [Column(TypeName = "varchar")]
        public string Phone { get; set; }

        [Display(Name = "User Password")]
        [Required]
        [MinLength(8),MaxLength(24)]       
        [Column(TypeName = "varchar")]
        public string UserPassword { get; set; }

        [Display(Name = "User RoleType")]
        [Required]
       // [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string RoleType { get; set; }

        #region Navigation Properties to Student Model

        public ICollection<Student> Students { get; set; }

        #endregion

        #region Navigation Properties  to ThesisAssigns Model

        public ICollection<ThesisAssign> ThesisAssigns { get; set; }

        #endregion


    }
}
