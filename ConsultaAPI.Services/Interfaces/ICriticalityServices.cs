using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Responses;

namespace ConsultaAPI.Services.Interfaces
{
    public interface ICriticalityServices
    {
        public ResponseEntity<CriticalityAllAsset> GetCriticalityAllAsset(int id, ResponseEntity<CriticalityAllAsset> response);

        public ResponseEntity<CriticalityAllAssetInd> GetCriticalityAllAssetInd(int id, ResponseEntity<CriticalityAllAssetInd> response);

        public ResponseEntity<CriticalityCategory> GetCriticalityCategory(int id, ResponseEntity<CriticalityCategory> response);

        public ResponseEntity<CriticalityConsequenceByCircuit> GetCriticalityConcequenceCircuit(int id, ResponseEntity<CriticalityConsequenceByCircuit> response);

        public ResponseEntity<CriticalityConsequenceParameter> GetCriticalityConcequenceParameter(int id, ResponseEntity<CriticalityConsequenceParameter> response);

        public ResponseEntity<CriticalityConsequencePrincipal> GetCriticalityConcequencePrincipal(int id, ResponseEntity<CriticalityConsequencePrincipal> response);

        public ResponseEntity<CriticalityConstructiveUnit> GetCriticalityConstructiveUnit(int id, ResponseEntity<CriticalityConstructiveUnit> response);

        public ResponseEntity<CriticalityFailureIo> GetCriticalityFailureIO(int id, ResponseEntity<CriticalityFailureIo> response);

        public ResponseEntity<CriticalityFailureIoExc> GetCriticalityFailureIOEXC(int id, ResponseEntity<CriticalityFailureIoExc> response);

        public ResponseEntity<CriticalityFailureIoMonthly> GetCriticalityFailureIOMonthly(int id, ResponseEntity<CriticalityFailureIoMonthly> response);

        public ResponseEntity<CriticalityFailureIoNoexc> GetCriticalityFailureIONoEXC(int id, ResponseEntity<CriticalityFailureIoNoexc> response);

        public ResponseEntity<CriticalityFailureIoYearly> GetCriticalityFailureIOYearly(int id, ResponseEntity<CriticalityFailureIoYearly> response);

        public ResponseEntity<CriticalityHealthAllAsset> GetCriticalityHealthAllAsset(int id, ResponseEntity<CriticalityHealthAllAsset> response);

        public ResponseEntity<CriticalityHistoricalFailure> GetCriticalityHistoricalFailure(int id, ResponseEntity<CriticalityHistoricalFailure> response);

        public ResponseEntity<CriticalityResumeCurrentFrequencyByCause> GetCriticalityResumeCurrentFrecuency(int id, ResponseEntity<CriticalityResumeCurrentFrequencyByCause> response);

        public ResponseEntity<CriticalityResumeFrequencyMap> GetCriticalityResumeFrecuencyMap(int id, ResponseEntity<CriticalityResumeFrequencyMap> response);


    }

}
