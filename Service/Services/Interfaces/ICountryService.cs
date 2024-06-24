using Service.DTOs.Admin.Countries;

namespace Service.Services.Interfaces
{
    public interface ICountryService
    {
        Task CreateAsync(CountryCreateDto data);
        Task EditAsync(int? id, CountryEditDto data);
        Task DeleteAsync(int? id);
        Task<IEnumerable<CountryDto>> GetAllAsync();
        Task<CountryDetailDto> GetByIdAsync(int? id);
    }
}
