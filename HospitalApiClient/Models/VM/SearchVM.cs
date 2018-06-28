using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApiClient.Models.VM
{
    public class SearchVM
    {
        public List<Disease> DiseaseResults { get; set; }
        public SelectList Symptoms { get; set; }
        [Required(ErrorMessage ="Please select atleast one symptom")]
        public List<int> SelectedSymptoms { set; get; }
    }
}
