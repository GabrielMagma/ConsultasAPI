using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasAPI.Controllers
{
    public class PlannerController : Controller
    {

        readonly IPlannerServices plannerServices;

        public PlannerController(IPlannerServices _plannerServices)
        {
            plannerServices = _plannerServices;            
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivity))]
        public async Task<IActionResult> GetActivity(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<Activity> response = new ResponseEntity<Activity>();
                plannerServices.GetActivity(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityAsset))]
        public async Task<IActionResult> GetActivityAsset(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityAsset> response = new ResponseEntity<ActivityAsset>();
                plannerServices.GetActivityAsset(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityAssignedCrew))]
        public async Task<IActionResult> GetActivityAssignedCrew(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityAssignedCrew> response = new ResponseEntity<ActivityAssignedCrew>();
                plannerServices.GetActivityAssignedCrew(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityConsignment))]
        public async Task<IActionResult> GetActivityConsignment(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityConsignment> response = new ResponseEntity<ActivityConsignment>();
                plannerServices.GetActivityConsignment(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityCrew))]
        public async Task<IActionResult> GetActivityCrew(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityCrew> response = new ResponseEntity<ActivityCrew>();
                plannerServices.GetActivityCrew(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityHistory))]
        public async Task<IActionResult> GetActivityHistory(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityHistory> response = new ResponseEntity<ActivityHistory>();
                plannerServices.GetActivityHistory(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityImpact))]
        public async Task<IActionResult> GetActivityImpact(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityImpact> response = new ResponseEntity<ActivityImpact>();
                plannerServices.GetActivityImpact(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityJustification))]
        public async Task<IActionResult> GetActivityJustification(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityJustification> response = new ResponseEntity<ActivityJustification>();
                plannerServices.GetActivityJustification(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityLac))]
        public async Task<IActionResult> GetActivityLac(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityLac> response = new ResponseEntity<ActivityLac>();
                plannerServices.GetActivityLac(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityPriority))]
        public async Task<IActionResult> GetActivityPriority(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityPriority> response = new ResponseEntity<ActivityPriority>();
                plannerServices.GetActivityPriority(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityState))]
        public async Task<IActionResult> GetActivityState(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityState> response = new ResponseEntity<ActivityState>();
                plannerServices.GetActivityState(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityType))]
        public async Task<IActionResult> GetActivityType(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityType> response = new ResponseEntity<ActivityType>();
                plannerServices.GetActivityType(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityUser))]
        public async Task<IActionResult> GetActivityUser(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityUser> response = new ResponseEntity<ActivityUser>();
                plannerServices.GetActivityUser(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityUtilityPoles))]
        public async Task<IActionResult> GetActivityUtilityPoles(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityUtilityPole> response = new ResponseEntity<ActivityUtilityPole>();
                plannerServices.GetActivityUtilityPoles(id, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(PlannerController.GetActivityWorkOrder))]
        public async Task<IActionResult> GetActivityWorkOrder(int id)
        {
            return await Task.Run(() =>
            {
                ResponseEntity<ActivityWorkOrder> response = new ResponseEntity<ActivityWorkOrder>();
                plannerServices.GetActivityWorkOrder(id, response);
                return Ok(response);
            });
        }

    }
}
