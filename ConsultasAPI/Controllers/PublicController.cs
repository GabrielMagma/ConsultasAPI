using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasAPI.Controllers
{
    public class PublicController : Controller
    {

        readonly IPublicServices publicServices;

        public PublicController(IPublicServices _publicServices)
        {
            publicServices = _publicServices;            
        }

        #region Geolocality
        [HttpGet]
        [Route(nameof(PublicController.GetSettingGeolocality))]
        public async Task<IActionResult> GetSettingGeolocality(string codeSig)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingGeolocality> response = new ResponseEntity<SettingGeolocality>();
                publicServices.GetSettingGeolocality(codeSig, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PublicController.GetSettingGeolocalityList))]
        public async Task<IActionResult> GetSettingGeolocalityList()
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<SettingGeolocality>> response = new ResponseEntity<List<SettingGeolocality>>();
                publicServices.GetSettingGeolocalityList(response);
                return Ok(response);
            });
        }

        [HttpPost]
        [Route(nameof(PublicController.CreateSettingGeolocality))]
        public async Task<IActionResult> CreateSettingGeolocality(SettingGeolocality request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingGeolocality> response = new ResponseEntity<SettingGeolocality>();
                publicServices.CreateSettingGeolocality(request, response);
                return Ok(response);
            });
        }

        [HttpPut]
        [Route(nameof(PublicController.UpdateSettingGeolocality))]
        public async Task<IActionResult> UpdateSettingGeolocality(SettingGeolocality request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingGeolocality> response = new ResponseEntity<SettingGeolocality>();
                publicServices.UpdateSettingGeolocality(request, response);
                return Ok(response);
            });
        }

        [HttpDelete]
        [Route(nameof(PublicController.DeleteSettingGeolocality))]
        public async Task<IActionResult> DeleteSettingGeolocality(SettingGeolocality request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingGeolocality> response = new ResponseEntity<SettingGeolocality>();
                publicServices.DeleteSettingGeolocality(request, response);
                return Ok(response);
            });
        }
        #endregion

        #region locality
        [HttpGet]
        [Route(nameof(PublicController.GetSettinglocality))]
        public async Task<IActionResult> GetSettinglocality(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocality> response = new ResponseEntity<SettingLocality>();
                publicServices.GetSettinglocality(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PublicController.GetSettinglocalityList))]
        public async Task<IActionResult> GetSettinglocalityList()
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<SettingLocality>> response = new ResponseEntity<List<SettingLocality>>();
                publicServices.GetSettinglocalityList(response);
                return Ok(response);
            });
        }

        [HttpPost]
        [Route(nameof(PublicController.CreateSettinglocality))]
        public async Task<IActionResult> CreateSettinglocality(SettingLocality request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocality> response = new ResponseEntity<SettingLocality>();
                publicServices.CreateSettinglocality(request, response);
                return Ok(response);
            });
        }

        [HttpPut]
        [Route(nameof(PublicController.UpdateSettinglocality))]
        public async Task<IActionResult> UpdateSettinglocality(SettingLocality request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocality> response = new ResponseEntity<SettingLocality>();
                publicServices.UpdateSettinglocality(request, response);
                return Ok(response);
            });
        }

        [HttpDelete]
        [Route(nameof(PublicController.DeleteSettinglocality))]
        public async Task<IActionResult> DeleteSettinglocality(SettingLocality request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocality> response = new ResponseEntity<SettingLocality>();
                publicServices.DeleteSettinglocality(request, response);
                return Ok(response);
            });
        }
        #endregion

        #region locality-Region

        [HttpGet]
        [Route(nameof(PublicController.GetSettinglocalityRegion))]
        public async Task<IActionResult> GetSettinglocalityRegion(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocalityRegion> response = new ResponseEntity<SettingLocalityRegion>();
                publicServices.GetSettinglocalityRegion(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PublicController.GetSettinglocalityRegionList))]
        public async Task<IActionResult> GetSettinglocalityRegionList()
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<SettingLocalityRegion>> response = new ResponseEntity<List<SettingLocalityRegion>>();
                publicServices.GetSettinglocalityRegionList(response);
                return Ok(response);
            });
        }

        [HttpPost]
        [Route(nameof(PublicController.CreateSettinglocalityRegion))]
        public async Task<IActionResult> CreateSettinglocalityRegion(SettingLocalityRegion request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocalityRegion> response = new ResponseEntity<SettingLocalityRegion>();
                publicServices.CreateSettinglocalityRegion(request, response);
                return Ok(response);
            });
        }

        [HttpPut]
        [Route(nameof(PublicController.UpdateSettinglocalityRegion))]
        public async Task<IActionResult> UpdateSettinglocalityRegion(SettingLocalityRegion request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocalityRegion> response = new ResponseEntity<SettingLocalityRegion>();
                publicServices.UpdateSettinglocalityRegion(request, response);
                return Ok(response);
            });
        }

        [HttpDelete]
        [Route(nameof(PublicController.DeleteSettinglocalityRegion))]
        public async Task<IActionResult> DeleteSettinglocalityRegion(SettingLocalityRegion request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingLocalityRegion> response = new ResponseEntity<SettingLocalityRegion>();
                publicServices.DeleteSettinglocalityRegion(request, response);
                return Ok(response);
            });
        }
        #endregion

        #region Region

        [HttpGet]
        [Route(nameof(PublicController.GetSettingRegion))]
        public async Task<IActionResult> GetSettingRegion(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingRegion> response = new ResponseEntity<SettingRegion>();
                publicServices.GetSettingRegion(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PublicController.GetSettingRegionList))]
        public async Task<IActionResult> GetSettingRegionList()
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<SettingRegion>> response = new ResponseEntity<List<SettingRegion>>();
                publicServices.GetSettingRegionList(response);
                return Ok(response);
            });
        }

        [HttpPost]
        [Route(nameof(PublicController.CreateSettingRegion))]
        public async Task<IActionResult> CreateSettingRegion(SettingRegion request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingRegion> response = new ResponseEntity<SettingRegion>();
                publicServices.CreateSettingRegion(request, response);
                return Ok(response);
            });
        }

        [HttpPut]
        [Route(nameof(PublicController.UpdateSettingRegion))]
        public async Task<IActionResult> UpdateSettingRegion(SettingRegion request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingRegion> response = new ResponseEntity<SettingRegion>();
                publicServices.UpdateSettingRegion(request, response);
                return Ok(response);
            });
        }

        [HttpDelete]
        [Route(nameof(PublicController.DeleteSettingRegion))]
        public async Task<IActionResult> DeleteSettingRegion(SettingRegion request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingRegion> response = new ResponseEntity<SettingRegion>();
                publicServices.DeleteSettingRegion(request, response);
                return Ok(response);
            });
        }
        #endregion

        #region Sector

        [HttpGet]
        [Route(nameof(PublicController.GetSettingSector))]
        public async Task<IActionResult> GetSettingSector(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingSector> response = new ResponseEntity<SettingSector>();
                publicServices.GetSettingSector(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PublicController.GetSettingSectorList))]
        public async Task<IActionResult> GetSettingSectorList()
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<SettingSector>> response = new ResponseEntity<List<SettingSector>>();
                publicServices.GetSettingSectorList(response);
                return Ok(response);
            });
        }

        [HttpPost]
        [Route(nameof(PublicController.CreateSettingSector))]
        public async Task<IActionResult> CreateSettingSector(SettingSector request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingSector> response = new ResponseEntity<SettingSector>();
                publicServices.CreateSettingSector(request, response);
                return Ok(response);
            });
        }

        [HttpPut]
        [Route(nameof(PublicController.UpdateSettingSector))]
        public async Task<IActionResult> UpdateSettingSector(SettingSector request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingSector> response = new ResponseEntity<SettingSector>();
                publicServices.UpdateSettingSector(request, response);
                return Ok(response);
            });
        }

        [HttpDelete]
        [Route(nameof(PublicController.DeleteSettingSector))]
        public async Task<IActionResult> DeleteSettingSector(SettingSector request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingSector> response = new ResponseEntity<SettingSector>();
                publicServices.DeleteSettingSector(request, response);
                return Ok(response);
            });
        }

        #endregion

        #region Zone

        [HttpGet]
        [Route(nameof(PublicController.GetSettingZone))]
        public async Task<IActionResult> GetSettingZone(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingZone> response = new ResponseEntity<SettingZone>();
                publicServices.GetSettingZone(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PublicController.GetSettingZoneList))]
        public async Task<IActionResult> GetSettingZoneList()
        {
            return await Task.Run(() =>
            {
                ResponseEntity<List<SettingZone>> response = new ResponseEntity<List<SettingZone>>();
                publicServices.GetSettingZoneList(response);
                return Ok(response);
            });
        }

        [HttpPost]
        [Route(nameof(PublicController.CreateSettingZone))]
        public async Task<IActionResult> CreateSettingZone(SettingZone request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingZone> response = new ResponseEntity<SettingZone>();
                publicServices.CreateSettingZone(request, response);
                return Ok(response);
            });
        }

        [HttpPut]
        [Route(nameof(PublicController.UpdateSettingZone))]
        public async Task<IActionResult> UpdateSettingZone(SettingZone request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingZone> response = new ResponseEntity<SettingZone>();
                publicServices.UpdateSettingZone(request, response);
                return Ok(response);
            });
        }

        [HttpDelete]
        [Route(nameof(PublicController.DeleteSettingZone))]
        public async Task<IActionResult> DeleteSettingZone(SettingZone request)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<SettingZone> response = new ResponseEntity<SettingZone>();
                publicServices.DeleteSettingZone(request, response);
                return Ok(response);
            });
        }

        #endregion
    }
}
