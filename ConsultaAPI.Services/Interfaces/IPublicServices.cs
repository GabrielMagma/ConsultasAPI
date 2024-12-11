using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Responses;

namespace ConsultaAPI.Services.Interfaces
{
    public interface IPublicServices
    {
        #region Geolocality

        public ResponseEntity<SettingGeolocality> GetSettingGeolocality(string codeSig, ResponseEntity<SettingGeolocality> response);

        public ResponseEntity<List<SettingGeolocality>> GetSettingGeolocalityList(ResponseEntity<List<SettingGeolocality>> response);

        public ResponseEntity<SettingGeolocality> CreateSettingGeolocality(SettingGeolocality request, ResponseEntity<SettingGeolocality> response);

        public ResponseEntity<SettingGeolocality> UpdateSettingGeolocality(SettingGeolocality request, ResponseEntity<SettingGeolocality> response);

        public ResponseEntity<SettingGeolocality> DeleteSettingGeolocality(SettingGeolocality request, ResponseEntity<SettingGeolocality> response);

        #endregion

        #region locality

        public ResponseEntity<SettingLocality> GetSettinglocality(int id, ResponseEntity<SettingLocality> response);

        public ResponseEntity<List<SettingLocality>> GetSettinglocalityList(ResponseEntity<List<SettingLocality>> response);

        public ResponseEntity<SettingLocality> CreateSettinglocality(SettingLocality request, ResponseEntity<SettingLocality> response);

        public ResponseEntity<SettingLocality> UpdateSettinglocality(SettingLocality request, ResponseEntity<SettingLocality> response);

        public ResponseEntity<SettingLocality> DeleteSettinglocality(SettingLocality request, ResponseEntity<SettingLocality> response);

        #endregion

        #region locality-Region

        public ResponseEntity<SettingLocalityRegion> GetSettinglocalityRegion(int id, ResponseEntity<SettingLocalityRegion> response);

        public ResponseEntity<List<SettingLocalityRegion>> GetSettinglocalityRegionList(ResponseEntity<List<SettingLocalityRegion>> response);

        public ResponseEntity<SettingLocalityRegion> CreateSettinglocalityRegion(SettingLocalityRegion request, ResponseEntity<SettingLocalityRegion> response);

        public ResponseEntity<SettingLocalityRegion> UpdateSettinglocalityRegion(SettingLocalityRegion request, ResponseEntity<SettingLocalityRegion> response);

        public ResponseEntity<SettingLocalityRegion> DeleteSettinglocalityRegion(SettingLocalityRegion request, ResponseEntity<SettingLocalityRegion> response);

        #endregion

        #region Region

        public ResponseEntity<SettingRegion> GetSettingRegion(int id, ResponseEntity<SettingRegion> response);

        public ResponseEntity<List<SettingRegion>> GetSettingRegionList(ResponseEntity<List<SettingRegion>> response);

        public ResponseEntity<SettingRegion> CreateSettingRegion(SettingRegion request, ResponseEntity<SettingRegion> response);

        public ResponseEntity<SettingRegion> UpdateSettingRegion(SettingRegion request, ResponseEntity<SettingRegion> response);

        public ResponseEntity<SettingRegion> DeleteSettingRegion(SettingRegion request, ResponseEntity<SettingRegion> response);

        #endregion

        #region Sector

        public ResponseEntity<SettingSector> GetSettingSector(int id, ResponseEntity<SettingSector> response);

        public ResponseEntity<List<SettingSector>> GetSettingSectorList(ResponseEntity<List<SettingSector>> response);

        public ResponseEntity<SettingSector> CreateSettingSector(SettingSector request, ResponseEntity<SettingSector> response);

        public ResponseEntity<SettingSector> UpdateSettingSector(SettingSector request, ResponseEntity<SettingSector> response);

        public ResponseEntity<SettingSector> DeleteSettingSector(SettingSector request, ResponseEntity<SettingSector> response);

        #endregion

        #region Zone

        public ResponseEntity<SettingZone> GetSettingZone(int id, ResponseEntity<SettingZone> response);

        public ResponseEntity<List<SettingZone>> GetSettingZoneList(ResponseEntity<List<SettingZone>> response);

        public ResponseEntity<SettingZone> CreateSettingZone(SettingZone request, ResponseEntity<SettingZone> response);

        public ResponseEntity<SettingZone> UpdateSettingZone(SettingZone request, ResponseEntity<SettingZone> response);

        public ResponseEntity<SettingZone> DeleteSettingZone(SettingZone request, ResponseEntity<SettingZone> response);

        #endregion

    }

}
