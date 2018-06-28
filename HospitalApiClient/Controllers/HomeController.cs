using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HospitalApiClient.Models;
using HospitalApiClient.Services;

namespace HospitalApiClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDiseaseService _diseaseService;
        private readonly ISymptomService _symptomService;

        public HomeController(IDiseaseService diseaseService, ISymptomService symptomService)
        {
            _diseaseService = diseaseService;
            _symptomService = symptomService;
        }

        public async Task<IActionResult> Index()
        {

            return View(new HomeVM
            {
                GreatestDiseases = await _diseaseService.GetGreatestDiseasesAsync(),
                GreatestSymptoms = await _symptomService.GetGreatestSymptomsAsync(),
                SymptomsCount = await _symptomService.GetSymptomsCountAsync()
            });
        }


    }
}
