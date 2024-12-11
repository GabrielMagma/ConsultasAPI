

using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Services
{
    public class MapsServices : IMapsServices
    {

        protected DannteDevelopmentContext context;

        public MapsServices(DannteDevelopmentContext _context)
        {
            context = _context;
        }

        public ResponseEntity<Compensation> GetCompensation(int id, ResponseEntity<Compensation> response)
        {
            response.Data = context.Compensations.FirstOrDefault(c => c.Id == id);            
            response.Message = "complete";            
            response.Success = true;
            return response;

        }

        public ResponseEntity<MpLightning> GetMPLightning(int id, ResponseEntity<MpLightning> response)
        {
            response.Data = context.MpLightnings.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<MpTransformerBurned> GetMPTransformerBurned(int id, ResponseEntity<MpTransformerBurned> response)
        {
            response.Data = context.MpTransformerBurneds.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<MpUtilityPole> GetMPUtilityPole(int id, ResponseEntity<MpUtilityPole> response)
        {
            response.Data = context.MpUtilityPoles.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

    }
}
