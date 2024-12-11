using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasAPI.Controllers
{
    public class MachineController : Controller
    {

        readonly IMachineServices machineServices;

        public MachineController(IMachineServices _machineServices)
        {
            machineServices = _machineServices;            
        }

        [HttpGet]
        [Route(nameof(MachineController.GetAllAssetNew))]
        public async Task<IActionResult> GetAllAssetNew(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<AllAssetNew> response = new ResponseEntity<AllAssetNew>();
                machineServices.GetAllAssetNew(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(MachineController.GetIdeam))]
        public async Task<IActionResult> GetIdeam(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<Ideam> response = new ResponseEntity<Ideam>();
                machineServices.GetIdeam(id, response);
                return Ok(response);
            });
        }

    }
}
