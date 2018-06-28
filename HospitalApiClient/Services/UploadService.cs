using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HospitalApiClient.Services
{
    public class UploadService : BaseService, IUploadService
    {
        public async Task ClearDatabaseAsync()
        {
            await GetAsync<object>("clear");
            return;
        }

        public async Task UploadFileAsync(IFormFile file)
        {
            var streamreader = new StreamReader(file.OpenReadStream());
            var bytes = Encoding.UTF8.GetBytes(await streamreader.ReadToEndAsync());

            var form = new MultipartFormDataContent();
            form.Add(new ByteArrayContent(bytes), "database", "database.csv");
            
            var result = await Client.PostAsync("upload", form);
            result.EnsureSuccessStatusCode();
            return;

        }
    }
}
