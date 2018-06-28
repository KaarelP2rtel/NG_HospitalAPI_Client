using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApiClient.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Symptom> Symptoms { get; set; }

    }
}
