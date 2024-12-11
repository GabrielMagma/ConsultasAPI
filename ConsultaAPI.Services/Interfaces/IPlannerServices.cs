using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Responses;

namespace ConsultaAPI.Services.Interfaces
{
    public interface IPlannerServices
    {
        public ResponseEntity<Activity> GetActivity(int id, ResponseEntity<Activity> response);

        public ResponseEntity<ActivityAsset> GetActivityAsset(int id, ResponseEntity<ActivityAsset> response);

        public ResponseEntity<ActivityAssignedCrew> GetActivityAssignedCrew(int id, ResponseEntity<ActivityAssignedCrew> response);

        public ResponseEntity<ActivityConsignment> GetActivityConsignment(int id, ResponseEntity<ActivityConsignment> response);

        public ResponseEntity<ActivityCrew> GetActivityCrew(int id, ResponseEntity<ActivityCrew> response);

        public ResponseEntity<ActivityHistory> GetActivityHistory(int id, ResponseEntity<ActivityHistory> response);

        public ResponseEntity<ActivityImpact> GetActivityImpact(int id, ResponseEntity<ActivityImpact> response);

        public ResponseEntity<ActivityJustification> GetActivityJustification(int id, ResponseEntity<ActivityJustification> response);

        public ResponseEntity<ActivityLac> GetActivityLac(int id, ResponseEntity<ActivityLac> response);

        public ResponseEntity<ActivityPriority> GetActivityPriority(int id, ResponseEntity<ActivityPriority> response);

        public ResponseEntity<ActivityState> GetActivityState(int id, ResponseEntity<ActivityState> response);

        public ResponseEntity<ActivityType> GetActivityType(int id, ResponseEntity<ActivityType> response);

        public ResponseEntity<ActivityUser> GetActivityUser(int id, ResponseEntity<ActivityUser> response);

        public ResponseEntity<ActivityUtilityPole> GetActivityUtilityPoles(int id, ResponseEntity<ActivityUtilityPole> response);

        public ResponseEntity<ActivityWorkOrder> GetActivityWorkOrder(int id, ResponseEntity<ActivityWorkOrder> response);

    }

}
