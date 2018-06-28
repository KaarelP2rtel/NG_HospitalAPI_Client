using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HospitalApiClient.Services
{
    public interface IUploadService
    {
        Task ClearDatabaseAsync();
        Task UploadFileAsync(IFormFile file);
    }
}