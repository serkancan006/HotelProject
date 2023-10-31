using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hİzmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hİzmet başlıgı giriniz")]
        [StringLength(100, ErrorMessage = "Hİzmet başlıgı en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hİzmet açıklaması giriniz")]
        [StringLength(100, ErrorMessage = "Hİzmet açıklaması en fazla 100 karakter olabilir.")]
        public string Description { get; set; }
    }
}
