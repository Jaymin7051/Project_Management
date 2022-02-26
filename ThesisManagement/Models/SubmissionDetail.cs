using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("SubmissionDetails")]
    public class SubmissionDetail
    {
        [Display(Name = "Submission Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }

        #region Navigation Properties
        
        [Display(Name = "Project Id")]
        [Required]
        [ForeignKey(nameof(SubmissionDetail.ThesisAssign))]
        public int ProjectId { get; set; }


        [Display(Name = "Project Id")]
        public ThesisAssign ThesisAssign { get; set; }
        #endregion

        [Display(Name = "Submission Description")]
        [Required]
        [StringLength(150)]
        [Column(TypeName = "varchar")]
        public string SubmissionDesc { get; set; }

        [Display(Name = "Submission Due On")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public System.DateTime SubmissionDue { get; set; }

        [Display(Name = "Submission On")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public System.DateTime SubmissionOn { get; set; }

     /*   [Display(Name = "Submission File")]
        [Required]
        public System.Reflection.Metadata.Blob SubmissionFile { get; set; } */

        [Display(Name = "Reviewed By")]
        [Required]
        [StringLength(150)]
        [Column(TypeName = "varchar")]
        public string ReviewedBy { get; set; }

        [Display(Name = "Reviewed On")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public System.DateTime ReviewedOn { get; set; }

        [Display(Name = "Review Remarks")]
        [Required]
        [Column(TypeName = "varchar")]
        public System.DateTime ReviewRemarks { get; set; }


    }
}
