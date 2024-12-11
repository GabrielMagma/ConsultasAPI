using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasAPI.Controllers
{
    public class MapsController : Controller
    {

        readonly IMapsServices mapsServices;

        public MapsController(IMapsServices _mapsServices)
        {
            mapsServices = _mapsServices;            
        }

        [HttpGet]
        [Route(nameof(MapsController.GetCompensation))]
        public async Task<IActionResult> GetCompensation(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<Compensation> response = new ResponseEntity<Compensation>();
                mapsServices.GetCompensation(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(MapsController.GetMPLightning))]
        public async Task<IActionResult> GetMPLightning(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<MpLightning> response = new ResponseEntity<MpLightning>();
                mapsServices.GetMPLightning(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(MapsController.GetMPTransformerBurned))]
        public async Task<IActionResult> GetMPTransformerBurned(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<MpTransformerBurned> response = new ResponseEntity<MpTransformerBurned>();
                mapsServices.GetMPTransformerBurned(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(MapsController.GetMPUtilityPole))]
        public async Task<IActionResult> GetMPUtilityPole(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<MpUtilityPole> response = new ResponseEntity<MpUtilityPole>();
                mapsServices.GetMPUtilityPole(id, response);
                return Ok(response);
            });
        }

    }
}
