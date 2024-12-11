using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsultaAPI.Services.Data;

public partial class DannteDevelopmentContext : DbContext
{
    public DannteDevelopmentContext()
    {
    }

    public DannteDevelopmentContext(DbContextOptions<DannteDevelopmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityAsset> ActivityAssets { get; set; }

    public virtual DbSet<ActivityAssignedCrew> ActivityAssignedCrews { get; set; }

    public virtual DbSet<ActivityConsignment> ActivityConsignments { get; set; }

    public virtual DbSet<ActivityCrew> ActivityCrews { get; set; }

    public virtual DbSet<ActivityHistory> ActivityHistories { get; set; }

    public virtual DbSet<ActivityImpact> ActivityImpacts { get; set; }

    public virtual DbSet<ActivityJustification> ActivityJustifications { get; set; }

    public virtual DbSet<ActivityLac> ActivityLacs { get; set; }

    public virtual DbSet<ActivityPriority> ActivityPriorities { get; set; }

    public virtual DbSet<ActivityState> ActivityStates { get; set; }

    public virtual DbSet<ActivityType> ActivityTypes { get; set; }

    public virtual DbSet<ActivityUser> ActivityUsers { get; set; }

    public virtual DbSet<ActivityUtilityPole> ActivityUtilityPoles { get; set; }

    public virtual DbSet<ActivityWorkOrder> ActivityWorkOrders { get; set; }

    public virtual DbSet<AdminCompany> AdminCompanies { get; set; }

    public virtual DbSet<AdminModule> AdminModules { get; set; }

    public virtual DbSet<AdminPermission> AdminPermissions { get; set; }

    public virtual DbSet<AdminRole> AdminRoles { get; set; }

    public virtual DbSet<AdminTeam> AdminTeams { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<AdminUserRegion> AdminUserRegions { get; set; }

    public virtual DbSet<AllAsset> AllAssets { get; set; }

    public virtual DbSet<AllAssetNew> AllAssetNews { get; set; }

    public virtual DbSet<AssetSummary> AssetSummaries { get; set; }

    public virtual DbSet<CategoryDiuFiu> CategoryDiuFius { get; set; }

    public virtual DbSet<CausalSimulationType> CausalSimulationTypes { get; set; }

    public virtual DbSet<CauseCreg> CauseCregs { get; set; }

    public virtual DbSet<CauseCregInternal> CauseCregInternals { get; set; }

    public virtual DbSet<CauseCregSui> CauseCregSuis { get; set; }

    public virtual DbSet<CauseInternal> CauseInternals { get; set; }

    public virtual DbSet<CauseSui> CauseSuis { get; set; }

    public virtual DbSet<Compensation> Compensations { get; set; }

    public virtual DbSet<CregDiu> CregDius { get; set; }

    public virtual DbSet<CregDiuCause> CregDiuCauses { get; set; }

    public virtual DbSet<CregDiuFiuMonthPercent> CregDiuFiuMonthPercents { get; set; }

    public virtual DbSet<CregDiuMonth> CregDiuMonths { get; set; }

    public virtual DbSet<CregDiuMonthNiu> CregDiuMonthNius { get; set; }

    public virtual DbSet<CregDiuMonthNiuSummary> CregDiuMonthNiuSummaries { get; set; }

    public virtual DbSet<CregDiuMonthNiuTemp> CregDiuMonthNiuTemps { get; set; }

    public virtual DbSet<CregDiuMonthSummary> CregDiuMonthSummaries { get; set; }

    public virtual DbSet<CregFiu> CregFius { get; set; }

    public virtual DbSet<CregFiuCause> CregFiuCauses { get; set; }

    public virtual DbSet<CregFiuMonth> CregFiuMonths { get; set; }

    public virtual DbSet<CregFiuMonthNiu> CregFiuMonthNius { get; set; }

    public virtual DbSet<CregFiuMonthNiuSummary> CregFiuMonthNiuSummaries { get; set; }

    public virtual DbSet<CregFiuMonthNiuTemp> CregFiuMonthNiuTemps { get; set; }

    public virtual DbSet<CregFiuMonthSummary> CregFiuMonthSummaries { get; set; }

    public virtual DbSet<CregSaidiAnnual> CregSaidiAnnuals { get; set; }

    public virtual DbSet<CregSaidiCause> CregSaidiCauses { get; set; }

    public virtual DbSet<CregSaidiEvent> CregSaidiEvents { get; set; }

    public virtual DbSet<CregSaidiMonth> CregSaidiMonths { get; set; }

    public virtual DbSet<CregSaidiRegionLocality> CregSaidiRegionLocalities { get; set; }

    public virtual DbSet<CregSaidiUser> CregSaidiUsers { get; set; }

    public virtual DbSet<CregSaifiAnnual> CregSaifiAnnuals { get; set; }

    public virtual DbSet<CregSaifiCause> CregSaifiCauses { get; set; }

    public virtual DbSet<CregSaifiEvent> CregSaifiEvents { get; set; }

    public virtual DbSet<CregSaifiMonth> CregSaifiMonths { get; set; }

    public virtual DbSet<CregSaifiRegionLocality> CregSaifiRegionLocalities { get; set; }

    public virtual DbSet<CregSaifiUser> CregSaifiUsers { get; set; }

    public virtual DbSet<CriticalityAllAsset> CriticalityAllAssets { get; set; }

    public virtual DbSet<CriticalityAllAssetInd> CriticalityAllAssetInds { get; set; }

    public virtual DbSet<CriticalityCategory> CriticalityCategories { get; set; }

    public virtual DbSet<CriticalityConsequenceByCircuit> CriticalityConsequenceByCircuits { get; set; }

    public virtual DbSet<CriticalityConsequenceParameter> CriticalityConsequenceParameters { get; set; }

    public virtual DbSet<CriticalityConsequencePrincipal> CriticalityConsequencePrincipals { get; set; }

    public virtual DbSet<CriticalityConstructiveUnit> CriticalityConstructiveUnits { get; set; }

    public virtual DbSet<CriticalityFailureIo> CriticalityFailureIos { get; set; }

    public virtual DbSet<CriticalityFailureIoExc> CriticalityFailureIoExcs { get; set; }

    public virtual DbSet<CriticalityFailureIoInterval> CriticalityFailureIoIntervals { get; set; }

    public virtual DbSet<CriticalityFailureIoMonthly> CriticalityFailureIoMonthlies { get; set; }

    public virtual DbSet<CriticalityFailureIoNoexc> CriticalityFailureIoNoexcs { get; set; }

    public virtual DbSet<CriticalityFailureIoYearly> CriticalityFailureIoYearlies { get; set; }

    public virtual DbSet<CriticalityHealthAllAsset> CriticalityHealthAllAssets { get; set; }

    public virtual DbSet<CriticalityHealthAssetCategory> CriticalityHealthAssetCategories { get; set; }

    public virtual DbSet<CriticalityHistoricalFailure> CriticalityHistoricalFailures { get; set; }

    public virtual DbSet<CriticalityResumeCurrentFrequencyByCause> CriticalityResumeCurrentFrequencyByCauses { get; set; }

    public virtual DbSet<CriticalityResumeFrequencyMap> CriticalityResumeFrequencyMaps { get; set; }

    public virtual DbSet<Cs1> Cs1s { get; set; }

    public virtual DbSet<Cs2> Cs2s { get; set; }

    public virtual DbSet<EventCountLac> EventCountLacs { get; set; }

    public virtual DbSet<FestivalsFairsHistory> FestivalsFairsHistories { get; set; }

    public virtual DbSet<FileIoTemp> FileIoTemps { get; set; }

    public virtual DbSet<FileIoTempDetail> FileIoTempDetails { get; set; }

    public virtual DbSet<FilesIo> FilesIos { get; set; }

    public virtual DbSet<FilesLac> FilesLacs { get; set; }

    public virtual DbSet<FilesTc1> FilesTc1s { get; set; }

    public virtual DbSet<FilesTc1Temp> FilesTc1Temps { get; set; }

    public virtual DbSet<FilesTc1Temp1> FilesTc1Temps1 { get; set; }

    public virtual DbSet<FilesTt2> FilesTt2s { get; set; }

    public virtual DbSet<Forecast1> Forecast1s { get; set; }

    public virtual DbSet<Forecast2> Forecast2s { get; set; }

    public virtual DbSet<Forecast3> Forecast3s { get; set; }

    public virtual DbSet<Forecast4> Forecast4s { get; set; }

    public virtual DbSet<Forecast5> Forecast5s { get; set; }

    public virtual DbSet<Ideam> Ideams { get; set; }

    public virtual DbSet<IndicatorCountCodeSigCregUser> IndicatorCountCodeSigCregUsers { get; set; }

    public virtual DbSet<IndicatorCountCodeSigUser> IndicatorCountCodeSigUsers { get; set; }

    public virtual DbSet<IndicatorCountCodeSigUser1> IndicatorCountCodeSigUsers1 { get; set; }

    public virtual DbSet<IndicatorTotalUser> IndicatorTotalUsers { get; set; }

    public virtual DbSet<IndicatorTotalUser1> IndicatorTotalUsers1 { get; set; }

    public virtual DbSet<MachineConnectivity> MachineConnectivities { get; set; }

    public virtual DbSet<MaifiAnnual> MaifiAnnuals { get; set; }

    public virtual DbSet<MaifiDiuMonthNiu> MaifiDiuMonthNius { get; set; }

    public virtual DbSet<MaifiMonth> MaifiMonths { get; set; }

    public virtual DbSet<MpLightning> MpLightnings { get; set; }

    public virtual DbSet<MpTransformerBurned> MpTransformerBurneds { get; set; }

    public virtual DbSet<MpUtilityPole> MpUtilityPoles { get; set; }

    public virtual DbSet<NumCategory> NumCategories { get; set; }

    public virtual DbSet<PerceptionDiu> PerceptionDius { get; set; }

    public virtual DbSet<PerceptionDiuCause> PerceptionDiuCauses { get; set; }

    public virtual DbSet<PerceptionDiuMonth> PerceptionDiuMonths { get; set; }

    public virtual DbSet<PerceptionDiuMonthNiu> PerceptionDiuMonthNius { get; set; }

    public virtual DbSet<PerceptionDiuMonthNiuTemp> PerceptionDiuMonthNiuTemps { get; set; }

    public virtual DbSet<PerceptionDiuNiu> PerceptionDiuNius { get; set; }

    public virtual DbSet<PerceptionFiu> PerceptionFius { get; set; }

    public virtual DbSet<PerceptionFiuCause> PerceptionFiuCauses { get; set; }

    public virtual DbSet<PerceptionFiuMonth> PerceptionFiuMonths { get; set; }

    public virtual DbSet<PerceptionFiuMonthNiu> PerceptionFiuMonthNius { get; set; }

    public virtual DbSet<PerceptionFiuMonthNiuTemp> PerceptionFiuMonthNiuTemps { get; set; }

    public virtual DbSet<PerceptionFiuNiu> PerceptionFiuNius { get; set; }

    public virtual DbSet<PerceptionSaidiAnnual> PerceptionSaidiAnnuals { get; set; }

    public virtual DbSet<PerceptionSaidiCause> PerceptionSaidiCauses { get; set; }

    public virtual DbSet<PerceptionSaidiEvent> PerceptionSaidiEvents { get; set; }

    public virtual DbSet<PerceptionSaidiMonth> PerceptionSaidiMonths { get; set; }

    public virtual DbSet<PerceptionSaidiRegionLocality> PerceptionSaidiRegionLocalities { get; set; }

    public virtual DbSet<PerceptionSaidiUser> PerceptionSaidiUsers { get; set; }

    public virtual DbSet<PerceptionSaifiAnnual> PerceptionSaifiAnnuals { get; set; }

    public virtual DbSet<PerceptionSaifiCause> PerceptionSaifiCauses { get; set; }

    public virtual DbSet<PerceptionSaifiEvent> PerceptionSaifiEvents { get; set; }

    public virtual DbSet<PerceptionSaifiMonth> PerceptionSaifiMonths { get; set; }

    public virtual DbSet<PerceptionSaifiRegionLocality> PerceptionSaifiRegionLocalities { get; set; }

    public virtual DbSet<PerceptionSaifiUser> PerceptionSaifiUsers { get; set; }

    public virtual DbSet<Priorized> Priorizeds { get; set; }

    public virtual DbSet<SettingGeolocality> SettingGeolocalities { get; set; }

    public virtual DbSet<SettingLocality> SettingLocalities { get; set; }

    public virtual DbSet<SettingLocalityRegion> SettingLocalityRegions { get; set; }

    public virtual DbSet<SettingRegion> SettingRegions { get; set; }

    public virtual DbSet<SettingSector> SettingSectors { get; set; }

    public virtual DbSet<SettingZone> SettingZones { get; set; }

    public virtual DbSet<SimCuttingElement> SimCuttingElements { get; set; }

    public virtual DbSet<SimDiu> SimDius { get; set; }

    public virtual DbSet<SimDiuMonth> SimDiuMonths { get; set; }

    public virtual DbSet<SimDiuMonthNiu> SimDiuMonthNius { get; set; }

    public virtual DbSet<SimDiuMonthNiuTemp> SimDiuMonthNiuTemps { get; set; }

    public virtual DbSet<SimFilesLac> SimFilesLacs { get; set; }

    public virtual DbSet<SimFilesLacRandom> SimFilesLacRandoms { get; set; }

    public virtual DbSet<SimFilesLacTemp> SimFilesLacTemps { get; set; }

    public virtual DbSet<SimFiu> SimFius { get; set; }

    public virtual DbSet<SimFiuMonth> SimFiuMonths { get; set; }

    public virtual DbSet<SimFiuMonthNiu> SimFiuMonthNius { get; set; }

    public virtual DbSet<SimFiuMonthNiuTemp> SimFiuMonthNiuTemps { get; set; }

    public virtual DbSet<SimSaidiAnnual> SimSaidiAnnuals { get; set; }

    public virtual DbSet<SimSaidiFparent> SimSaidiFparents { get; set; }

    public virtual DbSet<SimSaidiMonth> SimSaidiMonths { get; set; }

    public virtual DbSet<SimSaifiAnnual> SimSaifiAnnuals { get; set; }

    public virtual DbSet<SimSaifiFparent> SimSaifiFparents { get; set; }

    public virtual DbSet<SimSaifiMonth> SimSaifiMonths { get; set; }

    public virtual DbSet<SimSimulationParticipation> SimSimulationParticipations { get; set; }

    public virtual DbSet<SimSimulationParticipationStatistic> SimSimulationParticipationStatistics { get; set; }

    public virtual DbSet<Simulation> Simulations { get; set; }

    public virtual DbSet<SimulationAsset> SimulationAssets { get; set; }

    public virtual DbSet<SimulationAsset1> SimulationAssets1 { get; set; }

    public virtual DbSet<SimulationAuxiliaryAssetType> SimulationAuxiliaryAssetTypes { get; set; }

    public virtual DbSet<SimulationHistory> SimulationHistories { get; set; }

    public virtual DbSet<SimulationType> SimulationTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_pkey");

            entity.ToTable("activity", "planner");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('planner.activity_id_seq1'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityType)
                .HasMaxLength(50)
                .HasColumnName("activity_type");
            entity.Property(e => e.Attachment)
                .HasMaxLength(300)
                .HasColumnName("attachment");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.DateCreate).HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_update");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .HasColumnName("description");
            entity.Property(e => e.FinishDate).HasColumnName("finish_date");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasColumnName("fparent");
            entity.Property(e => e.ImageMap)
                .HasMaxLength(300)
                .HasColumnName("image_map");
            entity.Property(e => e.IsApproved)
                .HasDefaultValue(false)
                .HasColumnName("is_approved");
            entity.Property(e => e.IsGeodata)
                .HasDefaultValue(false)
                .HasColumnName("is_geodata");
            entity.Property(e => e.IsRequest)
                .HasDefaultValue(false)
                .HasColumnName("is_request");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .HasColumnName("priority");
            entity.Property(e => e.PriorityId).HasColumnName("priority_id");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.RegionName)
                .HasMaxLength(500)
                .HasColumnName("region_name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .HasColumnName("title");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UserIdCreate).HasColumnName("user_id_create");
            entity.Property(e => e.UserIdUpdate).HasColumnName("user_id_update");
            entity.Property(e => e.UsernameCreate)
                .HasMaxLength(50)
                .HasColumnName("username_create");
            entity.Property(e => e.UsernameUpdate)
                .HasMaxLength(50)
                .HasColumnName("username_update");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<ActivityAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_code_sig_pkey");

            entity.ToTable("activity_asset", "planner");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('planner.activity_code_sig_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasColumnName("code_sig");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ActivityAssignedCrew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_assigned_team_pkey");

            entity.ToTable("activity_assigned_crew", "planner");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.CrewId).HasColumnName("crew_id");
        });

        modelBuilder.Entity<ActivityConsignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_consignment_pkey");

            entity.ToTable("activity_consignment", "planner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(255)
                .HasColumnName("consignment_number");
        });

        modelBuilder.Entity<ActivityCrew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_work_crew_pkey");

            entity.ToTable("activity_crew", "planner");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Crew)
                .HasMaxLength(200)
                .HasColumnName("crew");
        });

        modelBuilder.Entity<ActivityHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_history_pkey");

            entity.ToTable("activity_history", "planner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(300)
                .HasColumnName("attachment");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Comments)
                .HasMaxLength(20000)
                .HasColumnName("comments");
            entity.Property(e => e.FinishDate).HasColumnName("finish_date");
            entity.Property(e => e.FinishDateRequest).HasColumnName("finish_date_request");
            entity.Property(e => e.IsRequest)
                .HasDefaultValue(false)
                .HasColumnName("is_request");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_update");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartDateRequest).HasColumnName("start_date_request");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ActivityImpact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_impact_pkey");

            entity.ToTable("activity_impact", "planner");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Impact)
                .HasMaxLength(50)
                .HasColumnName("impact");
        });

        modelBuilder.Entity<ActivityJustification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_justification_pkey");

            entity.ToTable("activity_justification", "planner");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Justify)
                .HasMaxLength(200)
                .HasColumnName("justify");
        });

        modelBuilder.Entity<ActivityLac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_lac_pkey");

            entity.ToTable("activity_lac", "planner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
        });

        modelBuilder.Entity<ActivityPriority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("priority_pkey");

            entity.ToTable("activity_priority", "planner");

            entity.HasIndex(e => e.Priority, "priority_name_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('planner.priority_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Priority)
                .HasMaxLength(30)
                .HasColumnName("priority");
        });

        modelBuilder.Entity<ActivityState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_status_pkey");

            entity.ToTable("activity_state", "planner");

            entity.HasIndex(e => e.State, "activity_status_name_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('planner.activity_status_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
        });

        modelBuilder.Entity<ActivityType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_type_pkey");

            entity.ToTable("activity_type", "planner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ActivityUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_activity_pkey");

            entity.ToTable("activity_user", "planner");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('planner.user_activity_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasColumnName("company");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.PhotoPreview).HasColumnName("photo_preview");
            entity.Property(e => e.Team)
                .HasMaxLength(50)
                .HasColumnName("team");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ActivityUtilityPole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_backing_pkey");

            entity.ToTable("activity_utility_poles", "planner");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('planner.activity_backing_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.PaintingCode)
                .HasMaxLength(50)
                .HasColumnName("painting_code");
        });

        modelBuilder.Entity<ActivityWorkOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_work_order_pkey");

            entity.ToTable("activity_work_order", "planner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(200)
                .HasColumnName("order_number");
        });

        modelBuilder.Entity<AdminCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_user_company_pkey");

            entity.ToTable("admin_company");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasColumnName("company");
        });

        modelBuilder.Entity<AdminModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_modules_pkey");

            entity.ToTable("admin_module");

            entity.HasIndex(e => e.Id, "asc_idx2");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('admin_modules_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .HasColumnName("module");
        });

        modelBuilder.Entity<AdminPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_permissions_pkey");

            entity.ToTable("admin_permission");

            entity.HasIndex(e => e.Id, "asc_idx4");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
        });

        modelBuilder.Entity<AdminRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_roles_pkey");

            entity.ToTable("admin_role");

            entity.HasIndex(e => e.Id, "asc_idx5");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
        });

        modelBuilder.Entity<AdminTeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_user_team_pkey");

            entity.ToTable("admin_team");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Team)
                .HasMaxLength(50)
                .HasColumnName("team");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_users_pkey");

            entity.ToTable("admin_user");

            entity.HasIndex(e => e.Id, "table1_pk").IsUnique();

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.A2f)
                .HasDefaultValue(true)
                .HasColumnName("a2f");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasColumnName("company");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_update");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.PhotoPreview).HasColumnName("photo_preview");
            entity.Property(e => e.Pswd)
                .HasMaxLength(64)
                .HasColumnName("pswd");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
            entity.Property(e => e.Team)
                .HasMaxLength(50)
                .HasColumnName("team");
            entity.Property(e => e.TeamId).HasColumnName("team_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AdminUserRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_user_region_pkey");

            entity.ToTable("admin_user_region");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<AllAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("all_asset_pkey");

            entity.ToTable("all_asset");

            entity.HasIndex(e => new { e.Uia, e.IdRegion, e.IdLocality }, "idx_all_asset");

            entity.HasIndex(e => new { e.CodeSig, e.Id }, "idx_all_asset_code_sig_id");

            entity.HasIndex(e => new { e.IdLocality, e.IdRegion }, "idx_all_asset_id_locality_region");

            entity.HasIndex(e => e.Uia, "idx_all_asset_uia");

            entity.HasIndex(e => e.CodeSig, "index_code_sig_spard_all");

            entity.HasIndex(e => new { e.CodeSig, e.Uia }, "unique_code_sig_uia").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Dirección de la ubicación del activo")
                .HasColumnName("address");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Código de identificación del activo dentro del circuito.\nDepende de la posición geográfica y no varía si se reemplaza el activo")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Código taxonómico; utilizado para identificar el activo en el software Máximo")
                .HasColumnName("codetaxo");
            entity.Property(e => e.DateInst)
                .HasComment("Fecha de instalación del activo")
                .HasColumnName("date_inst");
            entity.Property(e => e.DateUnin)
                .HasComment("Fecha de desinstalación de activo")
                .HasColumnName("date_unin");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Código del circuito al cual pertenece el activo")
                .HasColumnName("fparent");
            entity.Property(e => e.GeographicalCode).HasColumnName("geographical_code");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Grupo de calidad del activo; de acuerdo a la CREG 015\n\nPrimer Dígito: Criticidad del Activo\n1: Alta Criticidad\n2: Media Criticidad\n3: Baja Criticidad\n\nSegundo Dígito: Nivel de Tensión\n1: Alta Tensión (AT)\n2: Media Tensión (MT)\n3: Baja Tensión (BT)")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality).HasColumnName("id_locality");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.IdSector).HasColumnName("id_sector");
            entity.Property(e => e.IdZone).HasColumnName("id_zone");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasComment("Latitud; ubicación geográfica del activo")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasComment("Longitud; ubicación geográfica del activo")
                .HasColumnName("longitude");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(100)
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(100)
                .HasColumnName("name_region");
            entity.Property(e => e.NameSector)
                .HasMaxLength(100)
                .HasColumnName("name_sector");
            entity.Property(e => e.NameZone)
                .HasMaxLength(100)
                .HasColumnName("name_zone");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.State)
                .HasDefaultValue(2)
                .HasColumnName("state");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Tipo de activo: transformador, interruptor, reconectador o seccionador")
                .HasColumnName("type_asset");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Unidad constructiva del activo;  de acuerdo al capítulo 14 de la CREG 015.\n\nEs una agrupación lógica de componentes que funcionan juntos como una unidad única y que tienen un propósito específico dentro del sistema eléctrico.\n\nEn DANNTE lo utilizamos para identificar el tiempo de vida util de un activo de acuerdo a la CREG")
                .HasColumnName("uccap14");
            entity.Property(e => e.Uia)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasComment("Código de identificación del activo; está asociado al code_sig\nVaría si se reemplaza el activo")
                .HasColumnName("uia");
        });

        modelBuilder.Entity<AllAssetNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("all_asset_new_pkey");

            entity.ToTable("all_asset_new", "machine");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("address");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.DateInst).HasColumnName("date_inst");
            entity.Property(e => e.DateUnin).HasColumnName("date_unin");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.GeographicalCode).HasColumnName("geographical_code");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality).HasColumnName("id_locality");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.IdSector).HasColumnName("id_sector");
            entity.Property(e => e.IdZone).HasColumnName("id_zone");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(100)
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(100)
                .HasColumnName("name_region");
            entity.Property(e => e.NameSector)
                .HasMaxLength(100)
                .HasColumnName("name_sector");
            entity.Property(e => e.NameZone)
                .HasMaxLength(100)
                .HasColumnName("name_zone");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.State)
                .HasDefaultValue(2)
                .HasColumnName("state");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uccap14");
            entity.Property(e => e.Uia)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
        });

        modelBuilder.Entity<AssetSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("asset_summary");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasColumnName("code_sig");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasColumnName("fparent");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(100)
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(50)
                .HasColumnName("uia");
        });

        modelBuilder.Entity<CategoryDiuFiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("category_diu_fiu");

            entity.Property(e => e.CategoryNumber).HasColumnName("category_number");
            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .HasColumnName("description");
            entity.Property(e => e.EndLimit).HasColumnName("end_limit");
            entity.Property(e => e.InitialLimit).HasColumnName("initial_limit");
        });

        modelBuilder.Entity<CausalSimulationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("causalsimulationtypes_pk");

            entity.ToTable("causal_simulation_types", "simulate");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.SimulationTypeCode).HasColumnName("simulation_type_code");
        });

        modelBuilder.Entity<CauseCreg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cause_event_creg_pkey");

            entity.ToTable("cause_creg", tb => tb.HasComment("Causales Creg"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CregCause).HasColumnName("creg_cause");
            entity.Property(e => e.DescriptionCreg)
                .HasMaxLength(1000)
                .HasColumnName("description_creg");
            entity.Property(e => e.Exclusion).HasColumnName("exclusion");
            entity.Property(e => e.Maintenance).HasColumnName("maintenance");
        });

        modelBuilder.Entity<CauseCregInternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cause_creg_internal_pkey");

            entity.ToTable("cause_creg_internal", tb => tb.HasComment("Causas internas  y Causas Creg"));

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Clasification)
                .HasMaxLength(100)
                .HasColumnName("clasification");
            entity.Property(e => e.CregCause).HasColumnName("creg_cause");
            entity.Property(e => e.DescriptionCause)
                .HasMaxLength(1000)
                .HasColumnName("description_cause");
            entity.Property(e => e.Exclusion).HasColumnName("exclusion");
            entity.Property(e => e.InternalCause).HasColumnName("internal_cause");
        });

        modelBuilder.Entity<CauseCregSui>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cause_event_pkey");

            entity.ToTable("cause_creg_sui", tb => tb.HasComment("CAUSAS SUI Y CAUSAS CREG"));

            entity.HasIndex(e => e.SuiCause, "idx_cause");

            entity.HasIndex(e => new { e.CregCause, e.SuiCause }, "idx_cause_event_creg_cause_sui_cause");

            entity.HasIndex(e => e.CregCause, "idx_cause_event_event_cause");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Clasification)
                .HasMaxLength(100)
                .HasColumnName("clasification");
            entity.Property(e => e.CregCause).HasColumnName("creg_cause");
            entity.Property(e => e.DescriptionCause)
                .HasMaxLength(1000)
                .HasColumnName("description_cause");
            entity.Property(e => e.Exclusion).HasColumnName("exclusion");
            entity.Property(e => e.SuiCause).HasColumnName("sui_cause");
        });

        modelBuilder.Entity<CauseInternal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cause_internal");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DescriptionCause)
                .HasMaxLength(100)
                .HasColumnName("description_cause");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
        });

        modelBuilder.Entity<CauseSui>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cause_sui");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DescriptionCause)
                .HasMaxLength(100)
                .HasColumnName("description_cause");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Compensation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("compensation_pkey");

            entity.ToTable("compensation", "maps");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasColumnName("code_sig");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Nui)
                .HasMaxLength(255)
                .HasColumnName("nui");
            entity.Property(e => e.QualityGroup)
                .HasMaxLength(255)
                .HasColumnName("quality_group");
            entity.Property(e => e.TensionLevel)
                .HasMaxLength(255)
                .HasColumnName("tension_level");
            entity.Property(e => e.Vc).HasColumnName("vc");
            entity.Property(e => e.Vcd).HasColumnName("vcd");
            entity.Property(e => e.Vcf).HasColumnName("vcf");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_diu");

            entity.HasIndex(e => e.Uia, "idx_creg_diu_uia");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_creg_diu_year_month_code");

            entity.Property(e => e.CategoryDiu)
                .HasDefaultValue(1)
                .HasColumnName("category_diu");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_diu_cause");

            entity.Property(e => e.CategoryDiu)
                .HasDefaultValue(1)
                .HasColumnName("category_diu");
            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser).HasColumnName("count_user");
            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuFiuMonthPercent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_diu_fiu_month_percent");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CurrentDium)
                .HasDefaultValueSql("0")
                .HasColumnName("current_dium");
            entity.Property(e => e.CurrentFium)
                .HasDefaultValueSql("0")
                .HasColumnName("current_fium");
            entity.Property(e => e.DiumPercentage)
                .HasDefaultValueSql("0")
                .HasColumnName("dium_percentage");
            entity.Property(e => e.FiumPercentage)
                .HasDefaultValueSql("0")
                .HasColumnName("fium_percentage");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.PreviousDium)
                .HasDefaultValueSql("0")
                .HasColumnName("previous_dium");
            entity.Property(e => e.PreviousFium)
                .HasDefaultValueSql("0")
                .HasColumnName("previous_fium");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_diu_month");

            entity.HasIndex(e => new { e.CodeSig, e.Year, e.Month, e.Uia }, "idx_creg_diu_month");

            entity.HasIndex(e => e.Uia, "idx_creg_diu_month_uia");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_creg_diu_month_year_month_code");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_diu_month_niu");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig, e.Uia, e.Niu }, "idx_creg_diu_month_niu_group");

            entity.HasIndex(e => e.Uia, "idx_creg_diu_month_niu_uia");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_creg_diu_month_niu_year_month_code");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuMonthNiuSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("creg_diu_month_niu_summary");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasColumnName("code_sig");
            entity.Property(e => e.DiumTotal).HasColumnName("dium_total");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuMonthNiuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_diu_month_niu_temp");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_creg_diu_month_niu_temp_year_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregDiuMonthSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("creg_diu_month_summary");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasColumnName("code_sig");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TotalDium).HasColumnName("total_dium");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_fiu");

            entity.HasIndex(e => e.Uia, "idx_creg_fiu_uia");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_creg_fiu_year_month_code");

            entity.Property(e => e.CategoryFiu)
                .HasDefaultValue(1)
                .HasColumnName("category_fiu");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiuCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_fiu_cause");

            entity.Property(e => e.CategoryFiu)
                .HasDefaultValue(1)
                .HasColumnName("category_fiu");
            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser).HasColumnName("count_user");
            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiuMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_fiu_month");

            entity.HasIndex(e => e.Uia, "idx_creg_fiu_month_uia");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_creg_fiu_month_year_month_code");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_fiu_month_niu");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig, e.Uia, e.Niu }, "idx_creg_fiu_month_niu_group");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_creg_fiu_month_niu_year_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiuMonthNiuSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("creg_fiu_month_niu_summary");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasColumnName("code_sig");
            entity.Property(e => e.FiumTotal).HasColumnName("fium_total");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiuMonthNiuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_fiu_month_niu_temp");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregFiuMonthSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("creg_fiu_month_summary");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasColumnName("code_sig");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TotalFium).HasColumnName("total_fium");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaidiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saidi_annual");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaidiCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saidi_cause");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi)
                .HasDefaultValueSql("0")
                .HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaidiEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saidi_event");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi)
                .HasDefaultValueSql("0")
                .HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaidiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saidi_month");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaidiRegionLocality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saidi_region_locality");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi)
                .HasDefaultValueSql("0")
                .HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaidiUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saidi_user");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi)
                .HasDefaultValueSql("0")
                .HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaifiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saifi_annual");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaifiCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saifi_cause");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi)
                .HasDefaultValueSql("0")
                .HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaifiEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saifi_event");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaifiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saifi_month");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaifiRegionLocality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saifi_region_locality");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi)
                .HasDefaultValueSql("0")
                .HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CregSaifiUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creg_saifi_user");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityAllAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("criticality_all_asset_pkey");

            entity.ToTable("criticality_all_asset", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.criticality_all_asset_id_seq1'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("category");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Consequence)
                .HasMaxLength(38)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("consequence");
            entity.Property(e => e.Criticality)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("criticality");
            entity.Property(e => e.CriticalityCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("criticality_count");
            entity.Property(e => e.CriticalityNum)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("criticality_num");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("group015");
            entity.Property(e => e.IntervalId)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("interval_id");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.NumCategory)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("num_category");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uccap14");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityAllAssetInd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("criticality_all_asset_ind_pkey");

            entity.ToTable("criticality_all_asset_ind", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.criticality_all_asset_ind_id_seq1'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("category");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Consequence)
                .HasMaxLength(38)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("consequence");
            entity.Property(e => e.Criticality)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("criticality");
            entity.Property(e => e.CriticalityCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("criticality_count");
            entity.Property(e => e.CriticalityNum)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("criticality_num");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("group015");
            entity.Property(e => e.IntervalId)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("interval_id");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.NumCategory)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("num_category");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uccap14");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityCategory>(entity =>
        {
            entity.HasKey(e => e.IdTb).HasName("criticality_category_pkey");

            entity.ToTable("criticality_category", "criticality");

            entity.Property(e => e.IdTb)
                .HasDefaultValueSql("nextval('criticality.criticality_category_id_tb_seq1'::regclass)")
                .HasColumnName("id_tb");
            entity.Property(e => e.Criticality)
                .HasMaxLength(50)
                .HasColumnName("criticality");
            entity.Property(e => e.CriticalityNum).HasColumnName("criticality_num");
            entity.Property(e => e.LowerBound).HasColumnName("lower_bound");
            entity.Property(e => e.UpperBound).HasColumnName("upper_bound");
        });

        modelBuilder.Entity<CriticalityConsequenceByCircuit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("consequence_by_circuit_pkey");

            entity.ToTable("criticality_consequence_by_circuit", "criticality");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CfId)
                .HasDefaultValue(0L)
                .HasColumnName("cf_id");
            entity.Property(e => e.CfValue)
                .HasDefaultValueSql("0")
                .HasColumnName("cf_value");
            entity.Property(e => e.CfValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("cf_value_wg");
            entity.Property(e => e.ConsequenceNum)
                .HasComputedColumnSql("((((((ss_value_wg + im_value_wg) + eo_dna_value_wg) + eo_tr_value_wg) + cf_value_wg) + ip_value_wg) + ml_value_wg)", true)
                .HasColumnName("consequence_num");
            entity.Property(e => e.EoDnaId)
                .HasDefaultValue(0L)
                .HasColumnName("eo_dna_id");
            entity.Property(e => e.EoDnaValue)
                .HasDefaultValueSql("0")
                .HasColumnName("eo_dna_value");
            entity.Property(e => e.EoDnaValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("eo_dna_value_wg");
            entity.Property(e => e.EoTrId)
                .HasDefaultValue(0L)
                .HasColumnName("eo_tr_id");
            entity.Property(e => e.EoTrValue)
                .HasDefaultValueSql("0")
                .HasColumnName("eo_tr_value");
            entity.Property(e => e.EoTrValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("eo_tr_value_wg");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasColumnName("fparent");
            entity.Property(e => e.ImId)
                .HasDefaultValue(0L)
                .HasColumnName("im_id");
            entity.Property(e => e.ImValue)
                .HasDefaultValueSql("0")
                .HasColumnName("im_value");
            entity.Property(e => e.ImValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("im_value_wg");
            entity.Property(e => e.IpId)
                .HasDefaultValue(0L)
                .HasColumnName("ip_id");
            entity.Property(e => e.IpValue)
                .HasDefaultValueSql("0")
                .HasColumnName("ip_value");
            entity.Property(e => e.IpValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("ip_value_wg");
            entity.Property(e => e.MlId)
                .HasDefaultValue(0L)
                .HasColumnName("ml_id");
            entity.Property(e => e.MlValue)
                .HasDefaultValueSql("0")
                .HasColumnName("ml_value");
            entity.Property(e => e.MlValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("ml_value_wg");
            entity.Property(e => e.SsId)
                .HasDefaultValue(0L)
                .HasColumnName("ss_id");
            entity.Property(e => e.SsValue)
                .HasDefaultValueSql("0")
                .HasColumnName("ss_value");
            entity.Property(e => e.SsValueWg)
                .HasDefaultValueSql("0")
                .HasColumnName("ss_value_wg");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityConsequenceParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("consequence_parameter_pkey");

            entity.ToTable("criticality_consequence_parameter", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.consequence_parameter_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Concept)
                .HasMaxLength(1000)
                .HasColumnName("concept");
            entity.Property(e => e.Parameter)
                .HasMaxLength(50)
                .HasColumnName("parameter");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CriticalityConsequencePrincipal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("consequence_principal_pkey");

            entity.ToTable("criticality_consequence_principal", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.consequence_principal_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Concept)
                .HasMaxLength(1000)
                .HasColumnName("concept");
            entity.Property(e => e.Consequence)
                .HasMaxLength(50)
                .HasColumnName("consequence");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CriticalityConstructiveUnit>(entity =>
        {
            entity.HasKey(e => e.IdTb).HasName("constructive_unit_pkey");

            entity.ToTable("criticality_constructive_unit", "criticality");

            entity.Property(e => e.IdTb)
                .HasDefaultValueSql("nextval('criticality.constructive_unit_id_tb_seq'::regclass)")
                .HasColumnName("id_tb");
            entity.Property(e => e.LifeYears)
                .HasDefaultValue(10)
                .HasColumnName("life_years");
            entity.Property(e => e.TensionLevel)
                .HasDefaultValue(1)
                .HasColumnName("tension_level");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(10)
                .HasColumnName("uccap14");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityFailureIo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("failure_io_pkey");

            entity.ToTable("criticality_failure_io", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.failure_io_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityFailureIoExc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("failure_io_exc_pkey");

            entity.ToTable("criticality_failure_io_exc", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.failure_io_exc_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityFailureIoInterval>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("criticality_failure_io_interval", "criticality");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.IntervalId).HasColumnName("interval_id");
            entity.Property(e => e.LowerBound).HasColumnName("lower_bound");
            entity.Property(e => e.NumCategory).HasColumnName("num_category");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(50)
                .HasColumnName("type_asset");
            entity.Property(e => e.UpperBound).HasColumnName("upper_bound");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityFailureIoMonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("failure_io_monthly_pkey");

            entity.ToTable("criticality_failure_io_monthly", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.failure_io_monthly_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityFailureIoNoexc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("failure_io_noexc_pkey");

            entity.ToTable("criticality_failure_io_noexc", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.failure_io_noexc_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.FailureCount).HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityFailureIoYearly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("failure_io_yearly_pkey");

            entity.ToTable("criticality_failure_io_yearly", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.failure_io_yearly_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(20)
                .HasColumnName("code_sig");
            entity.Property(e => e.FailureCount).HasColumnName("failure_count");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(20)
                .HasColumnName("type_asset");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityHealthAllAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("health_all_asset_pkey");

            entity.ToTable("criticality_health_all_asset", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.health_all_asset_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.ConstructiveUnit)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("constructive_unit");
            entity.Property(e => e.Criticality)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("criticality");
            entity.Property(e => e.CriticalityNum)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("criticality_num");
            entity.Property(e => e.DateInst).HasColumnName("date_inst");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("group015");
            entity.Property(e => e.LifeYears)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("life_years");
            entity.Property(e => e.Mc)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("mc");
            entity.Property(e => e.McNum)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("mc_num");
            entity.Property(e => e.Obsolescence)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("obsolescence");
            entity.Property(e => e.ObsolescenceYear)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("obsolescence_year");
            entity.Property(e => e.PercentLife)
                .HasComputedColumnSql("\nCASE\n    WHEN (constructive_unit = 0) THEN 0\n    ELSE (abs((life_years / constructive_unit)) * 100)\nEND", true)
                .HasColumnName("percent_life");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uccap14");
        });

        modelBuilder.Entity<CriticalityHealthAssetCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("criticality_health_asset_category", "criticality");

            entity.Property(e => e.Criticality).HasColumnName("criticality");
            entity.Property(e => e.Mc)
                .HasMaxLength(20)
                .HasColumnName("mc");
            entity.Property(e => e.McNum).HasColumnName("mc_num");
            entity.Property(e => e.PercentLifeEnd).HasColumnName("percent_life_end");
            entity.Property(e => e.PercentLifeStart).HasColumnName("percent_life_start");
        });

        modelBuilder.Entity<CriticalityHistoricalFailure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("historical_failure_pkey");

            entity.ToTable("criticality_historical_failure", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.historical_failure_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Cause)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("cause");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CregCause)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("creg_cause");
            entity.Property(e => e.DateIo).HasColumnName("date_io");
            entity.Property(e => e.DescriptionCause)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("description_cause");
            entity.Property(e => e.DescriptionCreg)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("description_creg");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.MinInterruption)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("min_interruption");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Users)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("users");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityResumeCurrentFrequencyByCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("criticality_resume_current_frequency_by_cause", "criticality");

            entity.Property(e => e.Cause)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("cause");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CregCause)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("creg_cause");
            entity.Property(e => e.DescriptionCause)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("description_cause");
            entity.Property(e => e.DescriptionCreg)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("description_creg");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("group015");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<CriticalityResumeFrequencyMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resume_frequency_map_pkey");

            entity.ToTable("criticality_resume_frequency_map", "criticality");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('criticality.resume_frequency_map_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("category");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.FailureCount)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("failure_count");
            entity.Property(e => e.Fparent)
                .HasMaxLength(16)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("group015");
            entity.Property(e => e.IntervalId)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("interval_id");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("0")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("0")
                .HasColumnName("longitude");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.NumCategory)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("num_category");
            entity.Property(e => e.Poblation)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("poblation");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(32)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("type_asset");
            entity.Property(e => e.Uccap14)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uccap14");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<Cs1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cs1");

            entity.Property(e => e.Caidi).HasColumnName("caidi");
            entity.Property(e => e.Maifi).HasColumnName("maifi");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Cs2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cs2");

            entity.Property(e => e.CregCause).HasColumnName("creg_cause");
            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.IdMercado).HasColumnName("id_mercado");
            entity.Property(e => e.Interruption).HasColumnName("interruption");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<EventCountLac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("event_count_lac_pkey");

            entity.ToTable("event_count_lac", tb => tb.HasComment("RESUMIR POR AÑO - MES LA CANTIDAD DE EVENTOS ASOCIADOS A UN UIA EN ESPECIFICO"));

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.CodeEvent)
                .HasMaxLength(52)
                .HasColumnName("code_event");
            entity.Property(e => e.CountUia)
                .HasMaxLength(52)
                .HasColumnName("count_uia");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<FestivalsFairsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("festivals_fairs_history", "machine");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.FinalDate).HasColumnName("final_date");
            entity.Property(e => e.InitialDate).HasColumnName("initial_date");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Locality)
                .HasMaxLength(200)
                .HasColumnName("locality");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<FileIoTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("file_io_temp_pkey");

            entity.ToTable("file_io_temp");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ApoyoApertura)
                .HasMaxLength(50)
                .HasColumnName("apoyo_apertura");
            entity.Property(e => e.ApoyoFalla)
                .HasMaxLength(50)
                .HasColumnName("apoyo_falla");
            entity.Property(e => e.CodInterruptor)
                .HasMaxLength(50)
                .HasColumnName("cod_interruptor");
            entity.Property(e => e.CodigoCausaEvento).HasColumnName("codigo_causa_evento");
            entity.Property(e => e.CodigoCircuito)
                .HasMaxLength(50)
                .HasColumnName("codigo_circuito");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(50)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.FechaFinal).HasColumnName("fecha_final");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.NombreTipoInterruptor)
                .HasMaxLength(50)
                .HasColumnName("nombre_tipo_interruptor");
            entity.Property(e => e.TotalClientes).HasColumnName("total_clientes");
            entity.Property(e => e.TotalOperaciones).HasColumnName("total_operaciones");
            entity.Property(e => e.TotalTrafo).HasColumnName("total_trafo");
        });

        modelBuilder.Entity<FileIoTempDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("file_io_temp_detail_pkey");

            entity.ToTable("file_io_temp_detail");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ApoyoApertura)
                .HasMaxLength(50)
                .HasColumnName("apoyo_apertura");
            entity.Property(e => e.ApoyoFalla)
                .HasMaxLength(50)
                .HasColumnName("apoyo_falla");
            entity.Property(e => e.CodInterruptor)
                .HasMaxLength(50)
                .HasColumnName("cod_interruptor");
            entity.Property(e => e.CodigoCausaEvento).HasColumnName("codigo_causa_evento");
            entity.Property(e => e.CodigoCircuito)
                .HasMaxLength(50)
                .HasColumnName("codigo_circuito");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(50)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.FechaFinal).HasColumnName("fecha_final");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.NombreTipoInterruptor)
                .HasMaxLength(50)
                .HasColumnName("nombre_tipo_interruptor");
            entity.Property(e => e.TotalClientes).HasColumnName("total_clientes");
            entity.Property(e => e.TotalOperaciones).HasColumnName("total_operaciones");
            entity.Property(e => e.TotalTrafo).HasColumnName("total_trafo");
            entity.Property(e => e.UiaTrafo)
                .HasMaxLength(50)
                .HasColumnName("uia_trafo");
        });

        modelBuilder.Entity<FilesIo>(entity =>
        {
            entity.HasKey(e => e.IdTb).HasName("files_io_pkey");

            entity.ToTable("files_io");

            entity.Property(e => e.IdTb)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_tb");
            entity.Property(e => e.Cause).HasColumnName("cause");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasColumnName("code_sig");
            entity.Property(e => e.Component)
                .HasMaxLength(200)
                .HasColumnName("component");
            entity.Property(e => e.CregCause).HasColumnName("creg_cause");
            entity.Property(e => e.DateIo).HasColumnName("date_io");
            entity.Property(e => e.Dependence)
                .HasMaxLength(50)
                .HasColumnName("dependence");
            entity.Property(e => e.DnaKwh).HasColumnName("dna_kwh");
            entity.Property(e => e.Element)
                .HasMaxLength(200)
                .HasColumnName("element");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .HasColumnName("event_type");
            entity.Property(e => e.Failure).HasColumnName("failure");
            entity.Property(e => e.FileIo)
                .HasMaxLength(50)
                .HasColumnName("file_io");
            entity.Property(e => e.FilesDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("files_date");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasColumnName("fparent");
            entity.Property(e => e.HourIn)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("hour_in");
            entity.Property(e => e.HourInterruption).HasColumnName("hour_interruption");
            entity.Property(e => e.HourOut)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("hour_out");
            entity.Property(e => e.Maneuver)
                .HasMaxLength(50)
                .HasColumnName("maneuver");
            entity.Property(e => e.MinInterruption).HasColumnName("min_interruption");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TypeAsset)
                .HasMaxLength(20)
                .HasColumnName("type_asset");
            entity.Property(e => e.Users).HasColumnName("users");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<FilesLac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("files_lac_pkey");

            entity.ToTable("files_lac");

            entity.HasIndex(e => new { e.Year, e.Month, e.Uia, e.StartDate, e.EndDate, e.EventCause }, "idx_f1_f2");

            entity.HasIndex(e => e.Uia, "idx_files_lac_uia");

            entity.HasIndex(e => new { e.Uia, e.EventCause, e.StartDate, e.EndDate, e.Year, e.Month }, "idx_files_lac_uia_event_cause_date_year_month");

            entity.HasIndex(e => new { e.Uia, e.Year, e.Month }, "idx_files_lac_uia_year_month");

            entity.HasIndex(e => new { e.Year, e.Month, e.EventCode }, "idx_files_lac_year_month_event_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AffectsConnection)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("affects_connection");
            entity.Property(e => e.ElementType)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("element_type");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.EventCause)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("event_cause");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("event_code");
            entity.Property(e => e.EventContinues)
                .HasMaxLength(2)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("event_continues");
            entity.Property(e => e.EventExcluidZin)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("event_excluid_zin");
            entity.Property(e => e.FileCode)
                .HasMaxLength(52)
                .HasDefaultValueSql("'NO DATA'::character varying")
                .HasColumnName("file_code");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("files");
            entity.Property(e => e.FilesDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("files_date");
            entity.Property(e => e.LightingUsers)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("lighting_users");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("start_date");
            entity.Property(e => e.State)
                .HasDefaultValue(0)
                .HasColumnName("state");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<FilesTc1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("files_tc1_pkey");

            entity.ToTable("files_tc1");

            entity.HasIndex(e => new { e.Month, e.Year }, "idx_files_tc1_month_year");

            entity.HasIndex(e => e.Uia, "idx_files_tc1_uia").HasAnnotation("Npgsql:StorageParameter:deduplicate_items", "true");

            entity.HasIndex(e => new { e.Uia, e.Niu, e.Year, e.Month }, "idx_files_tc1_uia_niuyearmonth").HasAnnotation("Npgsql:StorageParameter:deduplicate_items", "true");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_files_tc1_year_month");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_year_month");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(21204935L, null, null, null, null, null)
                .HasColumnName("id");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("year");
        });

        modelBuilder.Entity<FilesTc1Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("files_tc1_temp");

            entity.HasIndex(e => new { e.Niu, e.Year, e.Month, e.Uia }, "idx_files_tc1_temp_criteria");

            entity.HasIndex(e => e.Uia, "idx_files_tc1_temp_uia");

            entity.HasIndex(e => new { e.Uia, e.Niu, e.Year, e.Month }, "idx_files_tc1_temp_uia_niuyearmonth");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_files_tc1_temp_year_month");

            entity.HasIndex(e => new { e.Year, e.Month, e.Uia }, "idx_files_tc1_temp_year_month_uia");

            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<FilesTc1Temp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("files_tc1_temp", "simulate");

            entity.HasIndex(e => new { e.Niu, e.Year, e.Month, e.Uia }, "idx_files_tc1_temp_criteria");

            entity.HasIndex(e => e.Uia, "idx_files_tc1_temp_uia");

            entity.HasIndex(e => new { e.Uia, e.Niu, e.Year, e.Month }, "idx_files_tc1_temp_uia_niuyearmonth");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_files_tc1_temp_year_month");

            entity.HasIndex(e => new { e.Year, e.Month, e.Uia }, "idx_files_tc1_temp_year_month_uia");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<FilesTt2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("files_tt2_pkey");

            entity.ToTable("files_tt2");

            entity.HasIndex(e => e.CodeSig, "idx_files_tt2_code_sig");

            entity.HasIndex(e => e.Uia, "idx_files_tt2_uia");

            entity.HasIndex(e => new { e.Uia, e.Year, e.Month }, "idx_files_tt2_uia_year_month");

            entity.HasIndex(e => e.Uia, "indx_uia_tt2");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasColumnName("code_sig");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.State)
                .HasDefaultValue(2)
                .HasColumnName("state");
            entity.Property(e => e.StateDate).HasColumnName("state_date");
            entity.Property(e => e.Uia)
                .HasMaxLength(50)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Forecast1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("forecast_1", "machine");

            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Group).HasColumnName("group");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Forecast2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("forecast_2", "machine");

            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
        });

        modelBuilder.Entity<Forecast3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("forecast_3", "machine");

            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
        });

        modelBuilder.Entity<Forecast4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("forecast_4", "machine");

            entity.Property(e => e.Ds)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ds");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Trend).HasColumnName("trend");
            entity.Property(e => e.Yhat).HasColumnName("yhat");
            entity.Property(e => e.YhatLower).HasColumnName("yhat_lower");
            entity.Property(e => e.YhatUpper).HasColumnName("yhat_upper");
        });

        modelBuilder.Entity<Forecast5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("forecast_5", "machine");

            entity.Property(e => e.Ds)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ds");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Trend).HasColumnName("trend");
            entity.Property(e => e.Yhat).HasColumnName("yhat");
            entity.Property(e => e.YhatLower).HasColumnName("yhat_lower");
            entity.Property(e => e.YhatUpper).HasColumnName("yhat_upper");
        });

        modelBuilder.Entity<Ideam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ideam_pkey");

            entity.ToTable("ideam", "machine");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altitude).HasColumnName("altitude");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .HasColumnName("department");
            entity.Property(e => e.Frequency)
                .HasMaxLength(20)
                .HasColumnName("frequency");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Municipality)
                .HasMaxLength(255)
                .HasColumnName("municipality");
            entity.Property(e => e.Parameterid)
                .HasMaxLength(20)
                .HasColumnName("parameterid");
            entity.Property(e => e.Precipitation).HasColumnName("precipitation");
            entity.Property(e => e.Stationcode)
                .HasMaxLength(10)
                .HasColumnName("stationcode");
            entity.Property(e => e.Stationname)
                .HasMaxLength(255)
                .HasColumnName("stationname");
        });

        modelBuilder.Entity<IndicatorCountCodeSigCregUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("indicator_count_code_sig_creg_user");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CregCause).HasColumnName("creg_cause");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Users)
                .HasDefaultValue(0)
                .HasColumnName("users");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<IndicatorCountCodeSigUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("indicator_count_code_sig_user");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_ind_count_code_sig_user_year_month_code_sig");

            entity.HasIndex(e => new { e.CodeSig, e.Year, e.Month }, "idx_indicator_count_code_sig_user");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Users)
                .HasDefaultValue(0)
                .HasColumnName("users");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<IndicatorCountCodeSigUser1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("indicator_count_code_sig_user", "simulate");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Users)
                .HasDefaultValue(0)
                .HasColumnName("users");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<IndicatorTotalUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("indicator_total_user");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TotalUser).HasColumnName("total_user");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<IndicatorTotalUser1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("indicator_total_user", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TotalUser).HasColumnName("total_user");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<MachineConnectivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("machine_connectivity", "machine");
        });

        modelBuilder.Entity<MaifiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maifi_annual");

            entity.Property(e => e.Maifi).HasColumnName("maifi");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<MaifiDiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maifi_diu_month_niu");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig, e.Uia, e.Niu }, "idx_maifi_diu_month_niu_group");

            entity.HasIndex(e => e.Uia, "idx_maifi_diu_month_niu_uia");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig }, "idx_maifi_diu_month_niu_year_month_code");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<MaifiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maifi_month");

            entity.Property(e => e.Maifi).HasColumnName("maifi");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<MpLightning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lightning_historical_pkey");

            entity.ToTable("mp_lightning", "maps");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Amperage).HasColumnName("amperage");
            entity.Property(e => e.DateEvent)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_event");
            entity.Property(e => e.Error).HasColumnName("error");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NO DATA'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NO DATA'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NO DATA'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.NameZone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NO DATA'::character varying")
                .HasColumnName("name_zone");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<MpTransformerBurned>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maps_transformer_burned_pkey");

            entity.ToTable("mp_transformer_burned", "maps");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(50)
                .HasColumnName("code_sig");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasColumnName("fparent");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(100)
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(100)
                .HasColumnName("name_region");
            entity.Property(e => e.NameZone)
                .HasMaxLength(100)
                .HasColumnName("name_zone");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<MpUtilityPole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maps_utility_poles_pkey");

            entity.ToTable("mp_utility_pole", "maps");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Fparent)
                .HasMaxLength(20)
                .HasColumnName("fparent");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.InventaryCode)
                .HasMaxLength(50)
                .HasColumnName("inventary_code");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(50)
                .HasColumnName("name_region");
            entity.Property(e => e.PaintingCode)
                .HasMaxLength(50)
                .HasColumnName("painting_code");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<NumCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("num_category");

            entity.Property(e => e.CategoryNumber).HasColumnName("category_number");
        });

        modelBuilder.Entity<PerceptionDiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_diu");

            entity.HasIndex(e => new { e.Uia, e.Year, e.Month, e.CodeSig }, "idx_perception_diu");

            entity.Property(e => e.CategoryDiu)
                .HasDefaultValue(1)
                .HasColumnName("category_diu");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionDiuCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_diu_cause");

            entity.Property(e => e.CategoryDiu)
                .HasDefaultValue(1)
                .HasColumnName("category_diu");
            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser).HasColumnName("count_user");
            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionDiuMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_diu_month");

            entity.HasIndex(e => e.CodeSig, "idx_diu_month_code_sig");

            entity.HasIndex(e => new { e.Fparent, e.Group015, e.Codetaxo, e.CauseCreg, e.CauseSui }, "idx_diu_month_grouping");

            entity.HasIndex(e => e.Uia, "idx_diu_month_uia");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_diu_month_year_month");

            entity.HasIndex(e => new { e.Uia, e.Year, e.Month, e.CodeSig, e.CauseSui }, "idx_perception_diu_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionDiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_diu_month_niu");

            entity.HasIndex(e => e.Niu, "idx_niu_calp");

            entity.HasIndex(e => new { e.Uia, e.Year, e.Month, e.CodeSig, e.CauseSui }, "idx_perception_diu_month_niu");

            entity.HasIndex(e => new { e.Year, e.Month, e.Niu }, "idx_perception_diu_month_niu_year_month_niu");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionDiuMonthNiuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_diu_month_niu_temp");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_temp_year_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionDiuNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_diu_niu");

            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionFiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_fiu");

            entity.Property(e => e.CategoryFiu)
                .HasDefaultValue(1)
                .HasColumnName("category_fiu");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionFiuCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_fiu_cause");

            entity.Property(e => e.CategoryFiu)
                .HasDefaultValue(1)
                .HasColumnName("category_fiu");
            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser).HasColumnName("count_user");
            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionFiuMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_fiu_month");

            entity.HasIndex(e => new { e.Uia, e.Year, e.Month, e.CodeSig, e.CauseSui }, "idx_perception_fiu_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionFiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_fiu_month_niu");

            entity.HasIndex(e => new { e.Year, e.Month, e.Niu }, "idx_perception_fiu_month_niu_year_month_niu");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionFiuMonthNiuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_fiu_month_niu_temp");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_fiu_temp_year_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionFiuNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_fiu_niu");

            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaidiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saidi_annual");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaidiCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saidi_cause");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaidiEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saidi_event");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaidiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saidi_month");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaidiRegionLocality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saidi_region_locality");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaidiUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saidi_user");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaifiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saifi_annual");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaifiCause>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saifi_cause");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaifiEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saifi_event");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaifiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saifi_month");

            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaifiRegionLocality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saifi_region_locality");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<PerceptionSaifiUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perception_saifi_user");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocality)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locality");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Saifi)
                .HasDefaultValueSql("0")
                .HasColumnName("saifi");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Priorized>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("priorized");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Category12).HasColumnName("category12");
            entity.Property(e => e.Category3).HasColumnName("category3");
            entity.Property(e => e.Category6).HasColumnName("category6");
            entity.Property(e => e.Category9).HasColumnName("category9");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(255)
                .HasColumnName("code_sig");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasColumnName("codetaxo");
            entity.Property(e => e.Consequence)
                .HasMaxLength(50)
                .HasColumnName("consequence");
            entity.Property(e => e.Criticality)
                .HasMaxLength(50)
                .HasColumnName("criticality");
            entity.Property(e => e.Diu).HasColumnName("diu");
            entity.Property(e => e.FailureCount).HasColumnName("failure_count");
            entity.Property(e => e.Fiu).HasColumnName("fiu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(255)
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(255)
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<SettingGeolocality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("setting_geolocality");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(100)
                .HasColumnName("code_sig");
            entity.Property(e => e.CodigoGeografico)
                .HasMaxLength(100)
                .HasColumnName("codigo_geografico");
            entity.Property(e => e.GrupoCalidad)
                .HasMaxLength(100)
                .HasColumnName("grupo_calidad");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .HasColumnName("localidad");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .HasColumnName("municipio");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(100)
                .HasColumnName("nombre_categoria");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("region");
            entity.Property(e => e.Zona)
                .HasMaxLength(100)
                .HasColumnName("zona");
        });

        modelBuilder.Entity<SettingLocality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locality_pkey");

            entity.ToTable("setting_locality");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SettingLocalityRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locality_region_pkey");

            entity.ToTable("setting_locality_region");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdLocality).HasColumnName("id_locality");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");

            entity.HasOne(d => d.IdLocalityNavigation).WithMany(p => p.SettingLocalityRegions)
                .HasForeignKey(d => d.IdLocality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("locality_region_id_locality_fkey");
        });

        modelBuilder.Entity<SettingRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("region_pkey");

            entity.ToTable("setting_region");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.IdZone).HasColumnName("id_zone");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");

            entity.HasOne(d => d.IdZoneNavigation).WithMany(p => p.SettingRegions)
                .HasForeignKey(d => d.IdZone)
                .HasConstraintName("region_id_zone_fkey");
        });

        modelBuilder.Entity<SettingSector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sector_pkey");

            entity.ToTable("setting_sector");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.IdLocality).HasColumnName("id_locality");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");

            entity.HasOne(d => d.IdLocalityNavigation).WithMany(p => p.SettingSectors)
                .HasForeignKey(d => d.IdLocality)
                .HasConstraintName("sector_id_locality_fkey");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.SettingSectors)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("sector_id_region_fkey");
        });

        modelBuilder.Entity<SettingZone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zone_pkey");

            entity.ToTable("setting_zone");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SimCuttingElement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_cutting_element", "simulate");

            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SimDiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_diu", "simulate");

            entity.Property(e => e.CategoryDiu)
                .HasDefaultValue(1)
                .HasColumnName("category_diu");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Diu)
                .HasDefaultValueSql("0")
                .HasColumnName("diu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocatity)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locatity");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_diu");
        });

        modelBuilder.Entity<SimDiuMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_diu_month", "simulate");

            entity.HasIndex(e => new { e.CodeSig, e.Year, e.Month, e.Uia }, "idx_creg_diu_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_diu_month");
        });

        modelBuilder.Entity<SimDiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_diu_month_niu", "simulate");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig, e.Uia, e.Niu }, "idx_creg_diu_month_niu_group");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_diu_month_niu");
        });

        modelBuilder.Entity<SimDiuMonthNiuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_diu_month_niu_temp", "simulate");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_creg_diu_month_niu_temp_year_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.Dium).HasColumnName("dium");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_diu_month_niu_temp");
        });

        modelBuilder.Entity<SimFilesLac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_files_lac", "simulate");

            entity.Property(e => e.AffectsConnection).HasColumnName("affects_connection");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.ElementType).HasColumnName("element_type");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.EventCause).HasColumnName("event_cause");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.EventContinues)
                .HasMaxLength(2)
                .HasColumnName("event_continues");
            entity.Property(e => e.EventExcluidZin).HasColumnName("event_excluid_zin");
            entity.Property(e => e.FileCode)
                .HasMaxLength(52)
                .HasColumnName("file_code");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LightingUsers).HasColumnName("lighting_users");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("start_date");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_files_lac");
        });

        modelBuilder.Entity<SimFilesLacRandom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_files_lac_random", "simulate");

            entity.Property(e => e.AffectsConnection).HasColumnName("affects_connection");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.ElementType).HasColumnName("element_type");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.EventCause).HasColumnName("event_cause");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.EventContinues)
                .HasMaxLength(2)
                .HasColumnName("event_continues");
            entity.Property(e => e.EventExcluidZin).HasColumnName("event_excluid_zin");
            entity.Property(e => e.FileCode)
                .HasMaxLength(52)
                .HasColumnName("file_code");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LightingUsers).HasColumnName("lighting_users");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("start_date");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_files_lac_random");
        });

        modelBuilder.Entity<SimFilesLacTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_files_lac_temp", "simulate");

            entity.Property(e => e.AffectsConnection).HasColumnName("affects_connection");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.ElementType).HasColumnName("element_type");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.EventCause).HasColumnName("event_cause");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.EventContinues)
                .HasMaxLength(2)
                .HasColumnName("event_continues");
            entity.Property(e => e.EventExcluidZin).HasColumnName("event_excluid_zin");
            entity.Property(e => e.FileCode)
                .HasMaxLength(52)
                .HasColumnName("file_code");
            entity.Property(e => e.Files)
                .HasMaxLength(52)
                .HasColumnName("files");
            entity.Property(e => e.FilesDate).HasColumnName("files_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LightingUsers).HasColumnName("lighting_users");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("start_date");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_files_lac_temp");
        });

        modelBuilder.Entity<SimFiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_fiu", "simulate");

            entity.Property(e => e.CategoryFiu)
                .HasDefaultValue(1)
                .HasColumnName("category_fiu");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.CountUser)
                .HasDefaultValue(0)
                .HasColumnName("count_user");
            entity.Property(e => e.Fiu)
                .HasDefaultValueSql("0")
                .HasColumnName("fiu");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.IdLocality)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_locality");
            entity.Property(e => e.IdRegion)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("id_region");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.NameLocatity)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_locatity");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("name_region");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_fiu");
        });

        modelBuilder.Entity<SimFiuMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_fiu_month", "simulate");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_fiu_month");
        });

        modelBuilder.Entity<SimFiuMonthNiu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_fiu_month_niu", "simulate");

            entity.HasIndex(e => new { e.Year, e.Month, e.CodeSig, e.Uia, e.Niu }, "idx_creg_fiu_month_niu_group");

            entity.HasIndex(e => new { e.Year, e.Month }, "idx_creg_fiu_month_niu_year_month");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_fiu_month_niu");
        });

        modelBuilder.Entity<SimFiuMonthNiuTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_fiu_month_niu_temp", "simulate");

            entity.Property(e => e.CauseCreg).HasColumnName("cause_creg");
            entity.Property(e => e.CauseSui).HasColumnName("cause_sui");
            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Codetaxo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("codetaxo");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Fium).HasColumnName("fium");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("fparent");
            entity.Property(e => e.Group015)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("group015");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Niu)
                .HasMaxLength(52)
                .HasColumnName("niu");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("uia");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_fiu_month_niu_temp");
        });

        modelBuilder.Entity<SimSaidiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_saidi_annual", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_saidi_annual");
        });

        modelBuilder.Entity<SimSaidiFparent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_saidi_fparent", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_saidi_fparent");
        });

        modelBuilder.Entity<SimSaidiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_saidi_month", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saidi).HasColumnName("saidi");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_saidi_month");
        });

        modelBuilder.Entity<SimSaifiAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_saifi_annual", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_saifi_annual");
        });

        modelBuilder.Entity<SimSaifiFparent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_saifi_fparent", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_saifi_fparent");
        });

        modelBuilder.Entity<SimSaifiMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_saifi_month", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Saifi).HasColumnName("saifi");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.CodeSimNavigation).WithMany()
                .HasForeignKey(d => d.CodeSim)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_code_sim_sim_saifi_month");
        });

        modelBuilder.Entity<SimSimulationParticipation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_simulation_participation", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.EventCode)
                .HasMaxLength(52)
                .HasColumnName("event_code");
            entity.Property(e => e.Exclusion).HasColumnName("exclusion");
            entity.Property(e => e.ParticipationPercentage).HasColumnName("participation_percentage");
            entity.Property(e => e.TotalDium).HasColumnName("total_dium");
        });

        modelBuilder.Entity<SimSimulationParticipationStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sim_simulation_participation_statistics", "simulate");

            entity.Property(e => e.AverageParticipationPercentage).HasColumnName("average_participation_percentage");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.MedianParticipationPercentage).HasColumnName("median_participation_percentage");
        });

        modelBuilder.Entity<Simulation>(entity =>
        {
            entity.HasKey(e => e.CodeSim).HasName("simulation_pkey");

            entity.ToTable("simulation", "simulate");

            entity.HasIndex(e => e.CodeSim, "simulation_consecutive_idx").IsUnique();

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.AvgDiu).HasColumnName("avg_diu");
            entity.Property(e => e.AvgFiu).HasColumnName("avg_fiu");
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .HasColumnName("code");
            entity.Property(e => e.CodeSimulationType).HasColumnName("code_simulation_type");
            entity.Property(e => e.Factor).HasColumnName("factor");
            entity.Property(e => e.Fparent)
                .HasMaxLength(50)
                .HasColumnName("fparent");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.NameRegion)
                .HasMaxLength(200)
                .HasColumnName("name_region");
            entity.Property(e => e.SaidiAnnual).HasColumnName("saidi_annual");
            entity.Property(e => e.SaidiFparent).HasColumnName("saidi_fparent");
            entity.Property(e => e.SaifiAnnual).HasColumnName("saifi_annual");
            entity.Property(e => e.SaifiFparent).HasColumnName("saifi_fparent");
            entity.Property(e => e.SimDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sim_date");
            entity.Property(e => e.TotalCodeSig)
                .HasDefaultValue(0)
                .HasColumnName("total_code_sig");
            entity.Property(e => e.TotalUsers)
                .HasDefaultValue(0)
                .HasColumnName("total_users");
            entity.Property(e => e.Usuario)
                .HasMaxLength(52)
                .HasColumnName("usuario");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<SimulationAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("simulation_asset", "simulate");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
        });

        modelBuilder.Entity<SimulationAsset1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("simulation_asset", "maps");

            entity.Property(e => e.CodeSig)
                .HasMaxLength(52)
                .HasColumnName("code_sig");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Uia)
                .HasMaxLength(52)
                .HasColumnName("uia");
        });

        modelBuilder.Entity<SimulationAuxiliaryAssetType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("simulation_auxiliary_asset_type", "simulate");

            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.IdAuxiliaryAssetType).HasColumnName("id_auxiliary_asset_type");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
        });

        modelBuilder.Entity<SimulationHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("simulation_history_pkey");

            entity.ToTable("simulation_history", "simulate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSim).HasColumnName("code_sim");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.CodeSimNavigation).WithMany(p => p.SimulationHistories)
                .HasForeignKey(d => d.CodeSim)
                .HasConstraintName("fk_simulation_code");
        });

        modelBuilder.Entity<SimulationType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("simulationtypes_pk");

            entity.ToTable("simulation_types", "simulate", tb => tb.HasComment("La tabla SimulationTypes almacena los distintos tipos de simulaciones que pueden ser realizadas en el sistema. Cada tipo de simulación representa una categoría o clase de simulación con características y objetivos específicos"));

            entity.Property(e => e.Code)
                .ValueGeneratedNever()
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.Name).HasMaxLength(50);
        });
        modelBuilder.HasSequence("activity_history_id_seq", "planner");
        modelBuilder.HasSequence("activity_id_seq", "planner");
        modelBuilder.HasSequence("consequence_by_circuit_id_seq", "criticality");
        modelBuilder.HasSequence("consequence_parameter_id_seq", "criticality");
        modelBuilder.HasSequence("consequence_principal_id_seq", "criticality");
        modelBuilder.HasSequence("constructive_unit_id_tb_seq", "criticality");
        modelBuilder.HasSequence("criticality_all_asset_id_seq", "criticality");
        modelBuilder.HasSequence("criticality_all_asset_ind_id_seq", "criticality");
        modelBuilder.HasSequence("criticality_category_id_tb_seq", "criticality");
        modelBuilder.HasSequence("failure_io_exc_id_seq", "criticality");
        modelBuilder.HasSequence("failure_io_id_seq", "criticality");
        modelBuilder.HasSequence("failure_io_monthly_id_seq", "criticality");
        modelBuilder.HasSequence("failure_io_noexc_id_seq", "criticality");
        modelBuilder.HasSequence("failure_io_yearly_id_seq", "criticality");
        modelBuilder.HasSequence("health_all_asset_id_seq", "criticality");
        modelBuilder.HasSequence("historical_failure_id_seq", "criticality");
        modelBuilder.HasSequence("resume_current_frequency_by_cause_id_seq", "criticality");
        modelBuilder.HasSequence("resume_frequency_map_id_seq", "criticality");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
