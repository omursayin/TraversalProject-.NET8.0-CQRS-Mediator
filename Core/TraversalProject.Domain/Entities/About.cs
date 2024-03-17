using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string BannerImage { get; set; }
        public string Image1 { get; set; }
        public string Image1Title { get; set; }
        public string Image1Description { get; set; }
        public string Image2 { get; set; }
        public string Image2Title { get; set; }
        public string Image2Description { get; set; }
        public string Image3 { get; set; }
        public string Image3Title { get; set; }
        public string Image3Description { get; set; }
        public bool Status { get; set; }
    }
}
