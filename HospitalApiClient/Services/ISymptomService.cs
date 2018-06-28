using HospitalApiClient.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApiClient.Services
{
    public interface ISymptomService
    {
        Task<int> GetSymptomsCountAsync();
        Task<List<Symptom>> GetGreatestSymptomsAsync();
        Task<List<Symptom>> GetAllSymptomsAsync();
    }
}
