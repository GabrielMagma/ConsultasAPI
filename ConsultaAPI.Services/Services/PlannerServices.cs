

using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Responses;
using System.Collections.Generic;

namespace ConsultaAPI.Services.Services
{
    public class PlannerServices : IPlannerServices
    {

        protected DannteDevelopmentContext context;

        public PlannerServices(DannteDevelopmentContext _context)
        {
            context = _context;
        }

        public ResponseEntity<Activity> GetActivity(int id, ResponseEntity<Activity> response)
        {
            response.Data = context.Activities.FirstOrDefault(c => c.Id == id);            
            response.Message = "complete";            
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityAsset> GetActivityAsset(int id, ResponseEntity<ActivityAsset> response)
        {
            response.Data = context.ActivityAssets.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityAssignedCrew> GetActivityAssignedCrew(int id, ResponseEntity<ActivityAssignedCrew> response)
        {
            response.Data = context.ActivityAssignedCrews.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityConsignment> GetActivityConsignment(int id, ResponseEntity<ActivityConsignment> response)
        {
            response.Data = context.ActivityConsignments.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityCrew> GetActivityCrew(int id, ResponseEntity<ActivityCrew> response)
        {
            response.Data = context.ActivityCrews.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityHistory> GetActivityHistory(int id, ResponseEntity<ActivityHistory> response)
        {
            response.Data = context.ActivityHistories.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityImpact> GetActivityImpact(int id, ResponseEntity<ActivityImpact> response)
        {
            response.Data = context.ActivityImpacts.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityJustification> GetActivityJustification(int id, ResponseEntity<ActivityJustification> response)
        {
            response.Data = context.ActivityJustifications.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityLac> GetActivityLac(int id, ResponseEntity<ActivityLac> response)
        {
            response.Data = context.ActivityLacs.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityPriority> GetActivityPriority(int id, ResponseEntity<ActivityPriority> response)
        {
            response.Data = context.ActivityPriorities.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityState> GetActivityState(int id, ResponseEntity<ActivityState> response)
        {
            response.Data = context.ActivityStates.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityType> GetActivityType(int id, ResponseEntity<ActivityType> response)
        {
            response.Data = context.ActivityTypes.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityUser> GetActivityUser(int id, ResponseEntity<ActivityUser> response)
        {
            response.Data = context.ActivityUsers.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityUtilityPole> GetActivityUtilityPoles(int id, ResponseEntity<ActivityUtilityPole> response)
        {
            response.Data = context.ActivityUtilityPoles.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

        public ResponseEntity<ActivityWorkOrder> GetActivityWorkOrder(int id, ResponseEntity<ActivityWorkOrder> response)
        {
            response.Data = context.ActivityWorkOrders.FirstOrDefault(c => c.Id == id);
            response.Message = "complete";
            response.Success = true;
            return response;

        }

    }
}
