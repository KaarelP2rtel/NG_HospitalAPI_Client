using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalApiClient.Models;

namespace HospitalApiClient.Services
{
    public class SymptomService : BaseService, ISymptomService
    {
        public async Task<List<Symptom>> GetAllSymptomsAsync()
        {
            return await GetAsync<List<Symptom>>("symptoms");
        }

        public async Task<List<Symptom>> GetGreatestSymptomsAsync()
        {
            return await GetAsync<List<Symptom>>("symptoms/greatest");
        }

        public async Task<int> GetSymptomsCountAsync()
        {
            return (await GetAsync<CountDTO>("symptoms/count")).Count;
        }
        private class CountDTO{
            public int Count { get; set; }
        }
    }
}
