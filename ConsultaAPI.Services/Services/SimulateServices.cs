

using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Services
{
    public class SimulateServices : ISimulateServices
    {

        protected DannteDevelopmentContext context;

        public SimulateServices(DannteDevelopmentContext _context)
        {
            context = _context;
        }

        public ResponseEntity<AllAssetNew> GetAllAssetNew(int id, ResponseEntity<AllAssetNew> response)
        {
            response.Data = context.AllAssetNews.FirstOrDefault(c => c.Id == id);            
            response.Message = "complete";            
            response.Success = true;
            return response;

        }

        public ResponseEntity<Ideam> GetIdeam(int id, ResponseEntity<Ideam> response)
        {
            response.Data = context.Ideams.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

    }
}
