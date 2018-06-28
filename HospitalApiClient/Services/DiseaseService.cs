using HospitalApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApiClient.Services
{
    public class DiseaseService : BaseService, IDiseaseService
    {
        public async Task<List<Disease>> GetGreatestDiseasesAsync()
        {
            return await GetAsync<List<Disease>>("diseases/greatest");
        }

        public async Task<List<Disease>> SearchDiseases(List<Symptom> symptoms)
        {
            return await PostAsync<List<Symptom>, List<Disease>>("diseases/find", symptoms);
        }
    }
}
