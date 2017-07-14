using System.ComponentModel.DataAnnotations;

namespace TestProject.BL.DTO
{
    public class RecordDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is required.")]
        [StringLength(20, ErrorMessage = "UserName can't be less than 4 and more than 20 symbols.", MinimumLength = 4)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "UserRecord is required.")]
        [StringLength(100, ErrorMessage = "UserRecord can't be less than 1 and more than 100 symbols.", MinimumLength = 1)]
        public string UserRecord { get; set; }
    }
}
