using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ListDonGia
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        [MaxLength(36)]
        public string IdGVien { get; set; }
        [MaxLength(36)]
        public string IdMonHoc { get; set; }
        [MaxLength(36)]
        public string IdCaHoc { get; set; }
        public float? GiaTT30 { get; set; }
        public float? GiaTT45 { get; set; }
        public float? GiaTT60 { get; set; }
        public float? GiaTN30 { get; set; }
        public float? GiaTN45 { get; set; }
        public float? GiaTN60 { get; set; }
    }
}
