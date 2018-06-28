using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalApiClient.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApiClient.Controllers
{
    public class UploadController : Controller
    {
        private readonly IUploadService _uploadService;

        public UploadController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Clear()
        {
            await _uploadService.ClearDatabaseAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> File(IFormFile file)
        {
            await _uploadService.UploadFileAsync(file);   
            return RedirectToAction(nameof(Index));
        }

    }
}