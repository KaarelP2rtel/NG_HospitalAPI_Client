using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalApiClient.Models;

namespace HospitalApiClient.Services
{
    public interface IDiseaseService
    {
        Task<List<Disease>> GetGreatestDiseasesAsync();
        Task<List<Disease>> SearchDiseases(List<Symptom> symptoms);
    }
}