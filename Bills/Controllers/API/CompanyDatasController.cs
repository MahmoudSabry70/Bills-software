using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bills.Models.Entities;
using Bills.Services.Interfaces;
using Bills.Models.ModelView;


namespace Bills.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyDatasController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public readonly ApiModel _apiModel;

        public CompanyDatasController(ICompanyService companyService , ApiModel apiModel) {
            _companyService = companyService;
            _apiModel = apiModel;
        }    

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(IEnumerable<ApiModel>), 200)]
        public IActionResult Create( CompanyData companyData)
        {
            if (ModelState.IsValid)
            {
                _apiModel.Date = _companyService.create(companyData);
                _apiModel.Success = true;
                return Ok(_apiModel);
            }
            _apiModel.Date = companyData;
            _apiModel.Success = false;
            _apiModel.Message = "Validation Error";
            return BadRequest(_apiModel);
        }
       
    }
}
