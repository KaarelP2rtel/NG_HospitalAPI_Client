using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApiClient.Models
{
    public class HomeVM
    {
        public List<Disease> GreatestDiseases { get; set; }
        public int SymptomsCount { get; set; }
        public List<Symptom> GreatestSymptoms { get; set; }
    }
}
