using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }

        [Display(Name = "Subject Name")]
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string SubjectName { get; set; }

        #region Navigation Properties to ThesisAssign
             public ICollection<ThesisAssign> ThesisAssigns { get; set; }
        
        #endregion
    }
}
