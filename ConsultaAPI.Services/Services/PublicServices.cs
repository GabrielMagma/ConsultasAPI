

using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using ConsultaAPI.Services.Utilities;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Services
{
    public class PublicServices : IPublicServices
    {

        protected DannteDevelopmentContext context;

        public PublicServices(DannteDevelopmentContext _context)
        {
            context = _context;
        }

        #region Geolocality

        public ResponseEntity<SettingGeolocality> GetSettingGeolocality(string codeSig, ResponseEntity<SettingGeolocality> response)
        {
            try
            {
                response.Data = context.SettingGeolocalities.FirstOrDefault(c => c.CodeSig == codeSig);
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }
            

        }

        public ResponseEntity<List<SettingGeolocality>> GetSettingGeolocalityList(ResponseEntity<List<SettingGeolocality>> response)
        {
            try
            {
                response.Data = context.SettingGeolocalities.ToList();
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingGeolocality> CreateSettingGeolocality(SettingGeolocality request, ResponseEntity<SettingGeolocality> response)
        {
            try
            {
                context.SettingGeolocalities.Add(request);
                context.SaveChanges();
                response.Data = request;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingGeolocality> UpdateSettingGeolocality(SettingGeolocality request, ResponseEntity<SettingGeolocality> response)
        {

            try
            {
                var Exist = context.SettingGeolocalities.FirstOrDefault(x => x.CodeSig == request.CodeSig);
                if (Exist != null)
                {
                    // Campos a actualizar
                    FrameworkTypeUtility.SetProperties(request, Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "complete";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not updated";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingGeolocality> DeleteSettingGeolocality(SettingGeolocality request, ResponseEntity<SettingGeolocality> response)
        {
            try
            {
                var Exist = context.SettingGeolocalities.FirstOrDefault(x => x.CodeSig == request.CodeSig);
                if (Exist != null)
                {

                    context.SettingGeolocalities.Remove(Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "Deleted";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not Deleted";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        #endregion

        #region locality

        public ResponseEntity<SettingLocality> GetSettinglocality(int id, ResponseEntity<SettingLocality> response)
        {
            try
            {
                response.Data = context.SettingLocalities.FirstOrDefault(c => c.Id == id);
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }


        }

        public ResponseEntity<List<SettingLocality>> GetSettinglocalityList(ResponseEntity<List<SettingLocality>> response)
        {
            try
            {
                response.Data = context.SettingLocalities.ToList();
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingLocality> CreateSettinglocality(SettingLocality request, ResponseEntity<SettingLocality> response)
        {
            try
            {
                context.SettingLocalities.Add(request);
                context.SaveChanges();
                response.Data = request;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingLocality> UpdateSettinglocality(SettingLocality request, ResponseEntity<SettingLocality> response)
        {

            try
            {
                var Exist = context.SettingLocalities.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {
                    // Campos a actualizar
                    FrameworkTypeUtility.SetProperties(request, Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "complete";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not updated";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingLocality> DeleteSettinglocality(SettingLocality request, ResponseEntity<SettingLocality> response)
        {
            try
            {
                var Exist = context.SettingLocalities.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {

                    context.SettingLocalities.Remove(Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "Deleted";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not Deleted";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        #endregion

        #region locality-Region

        public ResponseEntity<SettingLocalityRegion> GetSettinglocalityRegion(int id, ResponseEntity<SettingLocalityRegion> response)
        {
            try
            {
                response.Data = context.SettingLocalityRegions.FirstOrDefault(c => c.Id == id);
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }


        }

        public ResponseEntity<List<SettingLocalityRegion>> GetSettinglocalityRegionList(ResponseEntity<List<SettingLocalityRegion>> response)
        {
            try
            {
                response.Data = context.SettingLocalityRegions.ToList();
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingLocalityRegion> CreateSettinglocalityRegion(SettingLocalityRegion request, ResponseEntity<SettingLocalityRegion> response)
        {
            try
            {
                context.SettingLocalityRegions.Add(request);
                context.SaveChanges();
                response.Data = request;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingLocalityRegion> UpdateSettinglocalityRegion(SettingLocalityRegion request, ResponseEntity<SettingLocalityRegion> response)
        {

            try
            {
                var Exist = context.SettingLocalityRegions.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {
                    // Campos a actualizar
                    FrameworkTypeUtility.SetProperties(request, Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "complete";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not updated";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingLocalityRegion> DeleteSettinglocalityRegion(SettingLocalityRegion request, ResponseEntity<SettingLocalityRegion> response)
        {
            try
            {
                var Exist = context.SettingLocalityRegions.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {

                    context.SettingLocalityRegions.Remove(Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "Deleted";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not Deleted";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        #endregion

        #region Region

        public ResponseEntity<SettingRegion> GetSettingRegion(int id, ResponseEntity<SettingRegion> response)
        {
            try
            {
                response.Data = context.SettingRegions.FirstOrDefault(c => c.Id == id);
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }


        }

        public ResponseEntity<List<SettingRegion>> GetSettingRegionList(ResponseEntity<List<SettingRegion>> response)
        {
            try
            {
                response.Data = context.SettingRegions.ToList();
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingRegion> CreateSettingRegion(SettingRegion request, ResponseEntity<SettingRegion> response)
        {
            try
            {
                context.SettingRegions.Add(request);
                context.SaveChanges();
                response.Data = request;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingRegion> UpdateSettingRegion(SettingRegion request, ResponseEntity<SettingRegion> response)
        {

            try
            {
                var Exist = context.SettingRegions.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {
                    // Campos a actualizar
                    FrameworkTypeUtility.SetProperties(request, Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "complete";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not updated";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingRegion> DeleteSettingRegion(SettingRegion request, ResponseEntity<SettingRegion> response)
        {
            try
            {
                var Exist = context.SettingRegions.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {

                    context.SettingRegions.Remove(Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "Deleted";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not Deleted";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        #endregion

        #region Sector

        public ResponseEntity<SettingSector> GetSettingSector(int id, ResponseEntity<SettingSector> response)
        {
            try
            {
                response.Data = context.SettingSectors.FirstOrDefault(c => c.Id == id);
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }


        }

        public ResponseEntity<List<SettingSector>> GetSettingSectorList(ResponseEntity<List<SettingSector>> response)
        {
            try
            {
                response.Data = context.SettingSectors.ToList();
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingSector> CreateSettingSector(SettingSector request, ResponseEntity<SettingSector> response)
        {
            try
            {
                context.SettingSectors.Add(request);
                context.SaveChanges();
                response.Data = request;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingSector> UpdateSettingSector(SettingSector request, ResponseEntity<SettingSector> response)
        {

            try
            {
                var Exist = context.SettingSectors.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {
                    // Campos a actualizar
                    FrameworkTypeUtility.SetProperties(request, Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "complete";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not updated";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingSector> DeleteSettingSector(SettingSector request, ResponseEntity<SettingSector> response)
        {
            try
            {
                var Exist = context.SettingSectors.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {

                    context.SettingSectors.Remove(Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "Deleted";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not Deleted";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        #endregion

        #region Zone

        public ResponseEntity<SettingZone> GetSettingZone(int id, ResponseEntity<SettingZone> response)
        {
            try
            {
                response.Data = context.SettingZones.FirstOrDefault(c => c.Id == id);
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }


        }

        public ResponseEntity<List<SettingZone>> GetSettingZoneList(ResponseEntity<List<SettingZone>> response)
        {
            try
            {
                response.Data = context.SettingZones.ToList();
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingZone> CreateSettingZone(SettingZone request, ResponseEntity<SettingZone> response)
        {
            try
            {
                context.SettingZones.Add(request);
                context.SaveChanges();
                response.Data = request;
                response.Message = "complete";
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingZone> UpdateSettingZone(SettingZone request, ResponseEntity<SettingZone> response)
        {

            try
            {
                var Exist = context.SettingZones.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {
                    // Campos a actualizar
                    FrameworkTypeUtility.SetProperties(request, Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "complete";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not updated";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        public ResponseEntity<SettingZone> DeleteSettingZone(SettingZone request, ResponseEntity<SettingZone> response)
        {
            try
            {
                var Exist = context.SettingZones.FirstOrDefault(x => x.Id == request.Id);
                if (Exist != null)
                {

                    context.SettingZones.Remove(Exist);

                    // Guardar cambios
                    context.SaveChanges();
                    response.Data = request;
                    response.Message = "Deleted";
                    response.Success = true;
                    return response;
                }
                else
                {
                    response.Data = request;
                    response.Message = "Incorrect, not Deleted";
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }

        }

        #endregion

    }
}
