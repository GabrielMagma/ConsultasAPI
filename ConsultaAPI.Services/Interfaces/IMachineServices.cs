using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Responses;

namespace ConsultaAPI.Services.Interfaces
{
    public interface IMachineServices
    {
        public ResponseEntity<AllAssetNew> GetAllAssetNew(int id, ResponseEntity<AllAssetNew> response);

        public ResponseEntity<Ideam> GetIdeam(int id, ResponseEntity<Ideam> response);
     
    }

}
