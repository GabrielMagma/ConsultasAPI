using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Responses;

namespace ConsultaAPI.Services.Interfaces
{
    public interface IMapsServices
    {
        public ResponseEntity<Compensation> GetCompensation(int id, ResponseEntity<Compensation> response);

        public ResponseEntity<MpLightning> GetMPLightning(int id, ResponseEntity<MpLightning> response);

        public ResponseEntity<MpTransformerBurned> GetMPTransformerBurned(int id, ResponseEntity<MpTransformerBurned> response);

        public ResponseEntity<MpUtilityPole> GetMPUtilityPole(int id, ResponseEntity<MpUtilityPole> response);        
    }

}
