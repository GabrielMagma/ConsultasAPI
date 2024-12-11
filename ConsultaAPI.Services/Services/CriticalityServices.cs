

using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Services
{
    public class CriticalityServices : ICriticalityServices
    {

        protected DannteDevelopmentContext context;

        public CriticalityServices(DannteDevelopmentContext _context)
        {
            context = _context;
        }

        public ResponseEntity<CriticalityAllAsset> GetCriticalityAllAsset(int id, ResponseEntity<CriticalityAllAsset> response)
        {
            response.Data = context.CriticalityAllAssets.FirstOrDefault(c => c.Id == id);            
            response.Message = "complete";            
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityAllAssetInd> GetCriticalityAllAssetInd(int id, ResponseEntity<CriticalityAllAssetInd> response)
        {
            response.Data = context.CriticalityAllAssetInds.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityCategory> GetCriticalityCategory(int id, ResponseEntity<CriticalityCategory> response)
        {
            response.Data = context.CriticalityCategories.FirstOrDefault(c => c.IdTb == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityConsequenceByCircuit> GetCriticalityConcequenceCircuit(int id, ResponseEntity<CriticalityConsequenceByCircuit> response)
        {
            response.Data = context.CriticalityConsequenceByCircuits.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityConsequenceParameter> GetCriticalityConcequenceParameter(int id, ResponseEntity<CriticalityConsequenceParameter> response)
        {
            response.Data = context.CriticalityConsequenceParameters.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityConsequencePrincipal> GetCriticalityConcequencePrincipal(int id, ResponseEntity<CriticalityConsequencePrincipal> response)
        {
            response.Data = context.CriticalityConsequencePrincipals.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityConstructiveUnit> GetCriticalityConstructiveUnit(int id, ResponseEntity<CriticalityConstructiveUnit> response)
        {
            response.Data = context.CriticalityConstructiveUnits.FirstOrDefault(c => c.IdTb == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityFailureIo> GetCriticalityFailureIO(int id, ResponseEntity<CriticalityFailureIo> response)
        {
            response.Data = context.CriticalityFailureIos.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityFailureIoExc> GetCriticalityFailureIOEXC(int id, ResponseEntity<CriticalityFailureIoExc> response)
        {
            response.Data = context.CriticalityFailureIoExcs.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityFailureIoMonthly> GetCriticalityFailureIOMonthly(int id, ResponseEntity<CriticalityFailureIoMonthly> response)
        {
            response.Data = context.CriticalityFailureIoMonthlies.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityFailureIoNoexc> GetCriticalityFailureIONoEXC(int id, ResponseEntity<CriticalityFailureIoNoexc> response)
        {
            response.Data = context.CriticalityFailureIoNoexcs.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityFailureIoYearly> GetCriticalityFailureIOYearly(int id, ResponseEntity<CriticalityFailureIoYearly> response)
        {
            response.Data = context.CriticalityFailureIoYearlies.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityHealthAllAsset> GetCriticalityHealthAllAsset(int id, ResponseEntity<CriticalityHealthAllAsset> response)
        {
            response.Data = context.CriticalityHealthAllAssets.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityHistoricalFailure> GetCriticalityHistoricalFailure(int id, ResponseEntity<CriticalityHistoricalFailure> response)
        {
            response.Data = context.CriticalityHistoricalFailures.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityResumeCurrentFrequencyByCause> GetCriticalityResumeCurrentFrecuency(int id, ResponseEntity<CriticalityResumeCurrentFrequencyByCause> response)
        {
            response.Data = context.CriticalityResumeCurrentFrequencyByCauses.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<CriticalityResumeFrequencyMap> GetCriticalityResumeFrecuencyMap(int id, ResponseEntity<CriticalityResumeFrequencyMap> response)
        {
            response.Data = context.CriticalityResumeFrequencyMaps.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

    }
}
