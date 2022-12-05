namespace GeoPet.Models
{
    public interface IGeoPetController
    {
        Task<IActionResult> FindGeoPet(string latitude, string longitude);
    }
}