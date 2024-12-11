using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasAPI.Controllers
{
    public class SimulateController : Controller
    {

        readonly ISimulateServices SimulateServices;

        public SimulateController(ISimulateServices _SimulateServices)
        {
            SimulateServices = _SimulateServices;            
        }

        //[HttpGet]
        //[Route(nameof(SimulateController.GetAllAssetNew))]
        //public async Task<IActionResult> GetAllAssetNew(int id)
        //{
        //    return await Task.Run(() =>
        //    {
        //        ResponseEntity<AllAssetNew> response = new ResponseEntity<AllAssetNew>();
        //        SimulateServices.GetAllAssetNew(id, response);
        //        return Ok(response);
        //    });
        //}

        //[HttpGet]
        //[Route(nameof(SimulateController.GetIdeam))]
        //public async Task<IActionResult> GetIdeam(int id)
        //{
        //    return await Task.Run(() =>
        //    {
        //        ResponseEntity<Ideam> response = new ResponseEntity<Ideam>();
        //        SimulateServices.GetIdeam(id, response);
        //        return Ok(response);
        //    });
        //}

    }
}
