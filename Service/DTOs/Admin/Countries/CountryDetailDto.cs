namespace Service.DTOs.Admin.Countries
{
    public class CountryDetailDto
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool SoftDeleted { get; set; }
    }
}
