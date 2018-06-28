using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalApiClient.Models;
using HospitalApiClient.Models.VM;
using HospitalApiClient.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalApiClient.Controllers
{
    public class SearchController : Controller
    {
        private readonly IDiseaseService _diseaseService;
        private readonly ISymptomService _symptomService;

        public SearchController(IDiseaseService diseaseService, ISymptomService symptomService)
        {
            _diseaseService = diseaseService;
            _symptomService = symptomService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View(new SearchVM
            {
                Symptoms = new SelectList(await _symptomService.GetAllSymptomsAsync(), nameof(Symptom.Id), nameof(Symptom.Name))
            });
        }
        [HttpPost]
        public async Task<IActionResult> Results([FromForm] SearchVM vm)
        {
            if (!ModelState.IsValid)
            {
                return  View("Index", new SearchVM
                {
                    Symptoms = new SelectList(await _symptomService.GetAllSymptomsAsync(), nameof(Symptom.Id), nameof(Symptom.Name))
                    
                });
            }

            var symptoms = vm.SelectedSymptoms.Select(s => new Symptom { Id = s }).ToList();
            return View("Index", new SearchVM
            {
                Symptoms = new SelectList(await _symptomService.GetAllSymptomsAsync(), nameof(Symptom.Id), nameof(Symptom.Name)),
                DiseaseResults = await _diseaseService.SearchDiseases(symptoms)
            });
        }
    }
}