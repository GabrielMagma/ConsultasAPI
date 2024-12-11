using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [Route(nameof(MapsController.GetCompensationData))]
        public async Task<IActionResult> GetCompensationData(CompensationDTO request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<CompensationDTO>> response = new ResponseEntity<List<CompensationDTO>>();
                mapsServices.GetCompensationData(request, response);
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

        //[HttpPost]
        //public async Task<IActionResult> GetTransformer([FromBody] FilterGeodata filter)
        //{
        //    try
        //    {

        //        var codeSigsQuery = _context.CregDius
        //              .AsNoTracking()
        //              .Where(x => x.NameRegion.Equals(filter.Region)
        //                          && filter.Circuits.Contains(x.Fparent)
        //                          && x.Year == filter.Year
        //                          && x.Month == filter.Month)
        //              .Select(x => new { x.CodeSig, x.Diu });

        //        var transformers = await _context.AllAssets
        //                                .AsNoTracking()
        //                                .Where(asset => codeSigsQuery.Any(codeSig => codeSig.CodeSig == asset.CodeSig))
        //                                .Select(asset => new
        //                                {
        //                                    latitude = asset.Latitude,
        //                                    longitude = asset.Longitude,
        //                                    codeSig = asset.CodeSig,
        //                                    install = asset.DateInst,
        //                                    uia = asset.Uia,
        //                                    diu = codeSigsQuery
        //                                        .Where(codeSig => codeSig.CodeSig == asset.CodeSig)
        //                                        .Select(codeSig => codeSig.Diu)
        //                                        .FirstOrDefault()
        //                                }).ToListAsync();



        //        return Ok(transformers);
        //    }
        //    catch (FormatException ex)
        //    {
        //        return Json(new { success = false, errorMessage = $"Error al procesar: {ex.Message}" });
        //    }
        //    catch (SqliteException ex)
        //    {
        //        return Json(new { success = false, errorMessage = $"Error al procesar: {ex.Message}" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { success = false, errorMessage = $"Error al procesar: {ex.Message}" });
        //    }
        //}
    }
}
