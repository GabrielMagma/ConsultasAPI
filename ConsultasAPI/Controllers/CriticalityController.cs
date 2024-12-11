using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasAPI.Controllers
{
    public class CriticalityController : Controller
    {

        readonly ICriticalityServices criticalityServices;

        public CriticalityController(ICriticalityServices _criticalityServices)
        {
            criticalityServices = _criticalityServices;            
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityAllAsset))]
        public async Task<IActionResult> GetCriticalityAllAsset(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityAllAsset> response = new ResponseEntity<CriticalityAllAsset>();
                criticalityServices.GetCriticalityAllAsset(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityAllAssetInd))]
        public async Task<IActionResult> GetCriticalityAllAssetInd(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityAllAssetInd> response = new ResponseEntity<CriticalityAllAssetInd>();
                criticalityServices.GetCriticalityAllAssetInd(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityCategory))]
        public async Task<IActionResult> GetCriticalityCategory(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityCategory> response = new ResponseEntity<CriticalityCategory>();
                criticalityServices.GetCriticalityCategory(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityConcequenceCircuit))]
        public async Task<IActionResult> GetCriticalityConcequenceCircuit(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityConsequenceByCircuit> response = new ResponseEntity<CriticalityConsequenceByCircuit>();
                criticalityServices.GetCriticalityConcequenceCircuit(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityConcequenceParameter))]
        public async Task<IActionResult> GetCriticalityConcequenceParameter(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityConsequenceParameter> response = new ResponseEntity<CriticalityConsequenceParameter>();
                criticalityServices.GetCriticalityConcequenceParameter(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityConcequencePrincipal))]
        public async Task<IActionResult> GetCriticalityConcequencePrincipal(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityConsequencePrincipal> response = new ResponseEntity<CriticalityConsequencePrincipal>();
                criticalityServices.GetCriticalityConcequencePrincipal(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityConstructiveUnit))]
        public async Task<IActionResult> GetCriticalityConstructiveUnit(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityConstructiveUnit> response = new ResponseEntity<CriticalityConstructiveUnit>();
                criticalityServices.GetCriticalityConstructiveUnit(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityFailureIO))]
        public async Task<IActionResult> GetCriticalityFailureIO(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityFailureIo> response = new ResponseEntity<CriticalityFailureIo>();
                criticalityServices.GetCriticalityFailureIO(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityFailureIOEXC))]
        public async Task<IActionResult> GetCriticalityFailureIOEXC(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityFailureIoExc> response = new ResponseEntity<CriticalityFailureIoExc>();
                criticalityServices.GetCriticalityFailureIOEXC(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityFailureIOMonthly))]
        public async Task<IActionResult> GetCriticalityFailureIOMonthly(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityFailureIoMonthly> response = new ResponseEntity<CriticalityFailureIoMonthly>();
                criticalityServices.GetCriticalityFailureIOMonthly(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityFailureIONoEXC))]
        public async Task<IActionResult> GetCriticalityFailureIONoEXC(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityFailureIoNoexc> response = new ResponseEntity<CriticalityFailureIoNoexc>();
                criticalityServices.GetCriticalityFailureIONoEXC(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityFailureIOYearly))]
        public async Task<IActionResult> GetCriticalityFailureIOYearly(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityFailureIoYearly> response = new ResponseEntity<CriticalityFailureIoYearly>();
                criticalityServices.GetCriticalityFailureIOYearly(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityHealthAllAsset))]
        public async Task<IActionResult> GetCriticalityHealthAllAsset(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityHealthAllAsset> response = new ResponseEntity<CriticalityHealthAllAsset>();
                criticalityServices.GetCriticalityHealthAllAsset(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityHistoricalFailure))]
        public async Task<IActionResult> GetCriticalityHistoricalFailure(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityHistoricalFailure> response = new ResponseEntity<CriticalityHistoricalFailure>();
                criticalityServices.GetCriticalityHistoricalFailure(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityResumeCurrentFrecuency))]
        public async Task<IActionResult> GetCriticalityResumeCurrentFrecuency(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityResumeCurrentFrequencyByCause> response = new ResponseEntity<CriticalityResumeCurrentFrequencyByCause>();
                criticalityServices.GetCriticalityResumeCurrentFrecuency(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(CriticalityController.GetCriticalityResumeFrecuencyMap))]
        public async Task<IActionResult> GetCriticalityResumeFrecuencyMap(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<CriticalityResumeFrequencyMap> response = new ResponseEntity<CriticalityResumeFrequencyMap>();
                criticalityServices.GetCriticalityResumeFrecuencyMap(id, response);
                return Ok(response);
            });
        }

    }
}
