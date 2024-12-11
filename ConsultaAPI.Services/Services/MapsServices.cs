

using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.EntityFrameworkCore;
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

        public ResponseEntity<List<CompensationDTO>> GetCompensationData(CompensationDTO request, ResponseEntity<List<CompensationDTO>> response)
        {
            try
            {
                var Temp = context.Compensations
                      .AsNoTracking()
                      .Where(x => request.Fparent.Contains(x.Fparent)
                                  && x.Year == request.Year
                                  && request.Month.Contains(x.Month))
                      .Select(x => new {x.Fparent, x.Year, x.Month, x.CodeSig, x.Vcf, x.Vcd, x.Latitude, x.Longitude });
                
                var CompensacionesDTOList = new List<CompensationDTO>();
                foreach (var item in Temp) {
                    var CompensacionesDTOTemp = new CompensationDTO();
                    CompensacionesDTOTemp.FparentUnit = item.Fparent;
                    CompensacionesDTOTemp.Year = item.Year;
                    CompensacionesDTOTemp.MonthUnit = item.Month;
                    CompensacionesDTOTemp.CodeSig = item.CodeSig;
                    CompensacionesDTOTemp.Vcf = item.Vcf;
                    CompensacionesDTOTemp.Vcd = item.Vcd;
                    CompensacionesDTOTemp.Latitude = item.Latitude;
                    CompensacionesDTOTemp.Longitude = item.Longitude;
                    CompensacionesDTOList.Add(CompensacionesDTOTemp);
                }
                var FparentList = new List<string>();
                foreach (var item in CompensacionesDTOList) { 
                    if (!FparentList.Contains(item.FparentUnit))
                    {
                        FparentList.Add(item.FparentUnit);
                    }
                }
                var tempListCompensaciones = new List<CompensationDTO>();

                var fparent = string.Empty;
                float? suma1 = 0;
                float? suma2 = 0;
                foreach (var item in FparentList)
                {
                    var filteredListCompensaciones = CompensacionesDTOList.Where(x => x.FparentUnit == item).ToList();
                    foreach (var item2 in filteredListCompensaciones)
                    {
                        suma1 = suma1 + item2.Vcf;
                        suma2 = suma2 + item2.Vcd;
                    }
                    var tempUnitCompensaciones = new CompensationDTO();
                    tempUnitCompensaciones.FparentUnit = filteredListCompensaciones[0].FparentUnit;
                    tempUnitCompensaciones.Year = filteredListCompensaciones[0].Year;
                    tempUnitCompensaciones.MonthUnit = filteredListCompensaciones[0].MonthUnit;
                    tempUnitCompensaciones.CodeSig = filteredListCompensaciones[0].CodeSig;
                    tempUnitCompensaciones.Vcf = suma1;
                    tempUnitCompensaciones.Vcd = suma2;
                    tempUnitCompensaciones.Latitude = filteredListCompensaciones[0].Latitude;
                    tempUnitCompensaciones.Longitude = filteredListCompensaciones[0].Longitude;
                    tempListCompensaciones.Add(tempUnitCompensaciones);
                }
                response.Data = tempListCompensaciones;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = new List<CompensationDTO>();
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }


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
