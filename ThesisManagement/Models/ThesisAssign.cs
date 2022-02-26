using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("ThesisAssigns")]
    public class ThesisAssign
    {
        [Display(Name = "Project Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        #region Navigation Properties to SubmissionDetail

            public ICollection<SubmissionDetail> SubmissionDetails { get; set; }

        #endregion

        [Display(Name = "Project Title")]
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string ProjectTitle { get; set; }

        [Display(Name = "Project Description")]
        [Required]
        [StringLength(150)]
        [Column(TypeName = "varchar")]
        public string ProjectDesc { get; set; }

        #region Navigation Properties to Subject
       
        [Display(Name = "Subject Id")]
        [Required]
        [ForeignKey(nameof(ThesisAssign.Subject))]
        public int SubjectId { get; set; }


        [Display(Name = "Subject ID")]
        public Subject Subject { get; set; }

        #endregion

        #region Navigation Properties to Student
        
        [Display(Name = "Student Id")]
        [Required]
        [ForeignKey(nameof(ThesisAssign.Student))]
        public int EnrollId { get; set; }


        [Display(Name = "Student ID")]
        public Student Student { get; set; }

        #endregion

        #region Navigation Properties to Faculty
        
        [Display(Name = "Professor Id")]
        [Required]
        [ForeignKey(nameof(ThesisAssign.Faculty))]
        public int ProfessorId { get; set; }


        [Display(Name = "Professor ID")]
        public Faculty Faculty { get; set; }
       
        #endregion

        /* #region Navigation Properties
         [Display(Name = "Mentor Id")]
         [Required]
         [ForeignKey(nameof(ThesisAssign.Faculty))]
         public int MentorID { get; set; }


         [Display(Name = " ID")]
         public Faculty Faculty { get; set; }
         #endregion */

        [Display(Name = "Start Date")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public System.DateTime EndDate { get; set; }

        [Display(Name = "Completion Percentage")]
        [Required]
        [Column(TypeName = "varchar")]
        public string CmptPercent { get; set; }


    }
}
