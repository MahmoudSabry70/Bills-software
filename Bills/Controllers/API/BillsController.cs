using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bills.Models.Entities;
using Bills.Models.ModelView;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.IO;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Bills.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bills.Controllers.API
{
    [Route("api/[controller]/[action]")]
    public class BillsController : ControllerBase
    {
       
        private readonly ICompositeViewEngine _viewEngine;
        private readonly IItemService _itemService;
        private readonly IClientService _clientService;
        private readonly IBillService _billService;
        public readonly ApiModel _apiModel;
        public BillsController(ApiModel apiModel,IBillService billService, ICompositeViewEngine viewEngine, IItemService itemService, IClientService clientService)
        {
            _viewEngine = viewEngine;
            _itemService = itemService;
            _clientService = clientService;
            _billService = billService;
            _apiModel = apiModel;
        }
        public IActionResult bill()
        {
            _apiModel.Data = _billService.getAll();
            _apiModel.Success = true;
            return Ok(_apiModel);
        }
        public IActionResult bills()
        {
            _apiModel.Data = _billService.getAll().Count;
            _apiModel.Success = true;
            return Ok(_apiModel);
        }
        [HttpPost]
        public IActionResult bill([FromBody] BillApi bill , [FromBody]  List<BillItemView> listItemView)
        {
           
          /*  if (ModelState.IsValid)
            {
                bill.billDate = DateTime.Now;
               *//* bill.Id = _billService.getAll().Count;*//*
                #region add bill 
                *//*_apiModel.Data = _billService.create(billViewModel: bill);*//*
                _apiModel.Data = bill;
                _apiModel.Success = true;
                return Ok(_apiModel);
                #endregion
                 
               
            }*/
         
            _apiModel.Success = false;
            _apiModel.Message = "validation error ";
            _apiModel.Data = listItemView;
            return Ok(_apiModel);
        }





        //public IActionResult Create()
        //{
        //    ViewData["ClintId"] = new SelectList(_clientService.getAll(), "Id", "Name");
        //    ViewData["ItemId"] = new SelectList(_itemService.getAll(), "Id", "Name");
        //    BillView billView = new ();
        //    billView.BillId = 1 + _billService.getAll().Count;

        //    var str = JsonConvert.SerializeObject(billView);
        //    HttpContext.Session.SetString("SessionBillView", str);

        //    return View(billView);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(BillView billView) 
        //{
        //    var str2 = HttpContext.Session.GetString("SessionBillView");
        //    var SessionBillView = JsonConvert.DeserializeObject<BillView>(str2);

    //        if (ModelState.IsValid)
    //        {
    //            #region add bill 
    //            _billService.create(billViewModel: billView, billViewSession: SessionBillView) ;
    //            #endregion
    //            TempData["alert"] = "  the invoice has been sucessfully added";
    //            return RedirectToAction("Create", "Bills");
    //}
    //billView.listItemView = SessionBillView.listItemView;
    //        return View("Create", billView);
    //}





}
}
