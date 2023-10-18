using System.ComponentModel.DataAnnotations;

namespace CLothingStore1.Data.Models
{
    public class Clothing
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? type { get; set; }
        [Required]
        [StringLength(50)]
        public string? size { get; set; }
        public bool isTrending { get; set; }
        [Required]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        [Timestamp]
        public byte[]? TimeStamp {  get; set; }
    }
}
