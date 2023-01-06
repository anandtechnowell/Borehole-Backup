using System;
using System.Collections.Generic;

namespace DataAccessLibrary
{
    //public class BoreholeNumberID
    //{
    //    public  Guid BoreholeID { get; set; }

    //}
    public class BoreHoleObjects
    {

       
        public class Organisation
        {

            public string OrganisationName { get; set; }
            public int TIN { get; set; }
            public int orgId { get; set; }
            public string registeredAddress { get; set; }
            public string type { get; set; }
        }
       
    }

    public class boreholesinfo
    {
        public string boreholeid { get; set; }
        public string boreholeNumber { get; set; }
        public double lattitude { get; set; }
        public double longitude { get; set; }
        public string district { get; set; }
        public string county { get; set; }
        public string subCounty { get; set; }
        public string parish { get; set; }
        public string village { get; set; }
        public string applicationStatus { get; set; }
        public string applicationReceivedDate { get; set; }
        public string applicationApprovedDate { get; set; }
    }

    public class Applicationtype {
        public string AppType { get; set; }
        public string Count { get; set; }
    }


    public class Identification_Location_details
    {
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public bool Functional { get; set; }
        public string Functional_str { get; set; }
        public DateTime DateOfAbandoned { get; set; }
        public string SourceType { get; set; }
        public string OwnerShip { get; set; }
        public string OtherOwnerShip { get; set; }
        public string SpecifyOwner { get; set; }
        public string OwnerContact { get; set; }
        public string Comments { get; set; }
        public string otherUse { get; set; }
        public string IfNotFunctional { get; set; }
        public string WaterUse { get; set; }
        public double Longitude { get; set; }
        public string Longitude_str { get; set; }
        public double Latitude { get; set; }
        public string Latitude_str { get; set; }
        public string UtmZone { get; set; }
        public string Easting { get; set; }
        public string Northing { get; set; }
        public string Altitude { get; set; }
        public string County { get; set; }
        public string SubCounty { get; set; }
        public string District { get; set; }
        public string Parish { get; set; }
        public string Village { get; set; }
        public string WaterPoint { get; set; }
        public Guid boreholeId { get; set; }
        public string StrDate { get; set; }
        public string applicationStatus { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }

    }


    public class siteinvestigation_details
    {
        public string BoreholeNumber { get; set; }
        public DateTime Date { get; set; }
        public string Date_str { get; set; }
        public int Organisation { get; set; }
        public string InvestigatorName { get; set; }
        public string InvestigatorTitle { get; set; }
        public string OtherInvestigator { get; set; }
        public bool SScheckResult { get; set; }
        public string SScheckResult_str { get; set; }
        public string SurveyMethod { get; set; }
        public string Comments { get; set; }
        public string SiteSelectionResultFile { get; set; }
        public string DocAuthType { get; set; }
        public string DocDescType { get; set; }
        public string OtherMethod { get; set; }
        public string RecommendedDepth { get; set; }
        public string type { get; set; }
        public Guid boreholeId { get; set; }
        public Guid? boreholeDocId { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }

    }
    public class VESMaster
    {
        public int vesMasterId { get; set; }
        public int StationNo { get; set; }
        public string AB { get; set; }
        public string MN { get; set; }
    }
    public class subverticalelectricsounding
    {
        public string Station_No { get; set; }
        public string AB { get; set; }
        public string Resistivity { get; set; }
        public string MN { get; set; }
        public string K_factor { get; set; }
        public string App_Res { get; set; }
        public Guid? vestId { get; set; }
    }
    public class verticalelectricsounding_details
    {
        public string BoreholeNumber { get; set; }
        public Guid boreholeId { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<subverticalelectricsounding> VES_tabledata { get; set; }
        public string type { get; set; }


    }

    public class constructionBasicInfo_details
    {
        public string BoreholeNumber { get; set; }
        public Guid boreholeId { get; set; }
        public Guid? constDataId { get; set; }
        public string type { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public string DateOfCompletion_str { get; set; }
        public string ActivityUndertaken { get; set; }
        public int Organisation { get; set; }
        public string Driller { get; set; }
        public string Title { get; set; }
        public string Supervisor { get; set; }
        public string Rigtype { get; set; }
        public string OtherDrillingMethod { get; set; }
        public string DrillingMethod { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }

    }

    public class DepthDiametertable
    {
        public Guid? WWdiaIntervald { get; set; }
        public string FromDepth { get; set; }
        public string ToDepth { get; set; }
        public string Diameter { get; set; }

    }

    public class FilterSlottable
    {
        public Guid? bhsizeIntervalId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string SlotSize { get; set; }
    }
    public class WellConstruction_details : constructionBasicInfo_details {
        public string CasingMaterial { get; set; }
        public string OtherMaterial { get; set; }
        public string CasingDiameter { get; set; }
        public string CasingLength { get; set; }
        public string SurfaceCasingHeight { get; set; }
        public string DatumElivation { get; set; }
        public string Sealtype { get; set; }
        public string Otherseal { get; set; }
        public string Developement { get; set; }
        public string OtherDeveopment { get; set; }
        public string Duration { get; set; }
        public string BoreholeFilters { get; set; }
        public string HydrofracturingComments { get; set; }
        public string TotalDrillDepth { get; set; }
        public string Comments { get; set; }
        public List<DepthDiametertable> DepthDiametertable { get; set; }
        public List<FilterSlottable> FilterSlottable { get; set; }

    }



    public class wellinstallation_details
    {
        public Guid boreholeId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public DateTime InstallationDate { get; set; }
        public string InstallationDate_str { get; set; }
        public string Pumptype { get; set; }
        public string PumpName { get; set; }
        public string PumpCapacity { get; set; }
        public string PumpIntakeDepth { get; set; }
        public string RiserPipeMaterial { get; set; }
        public string RiserPipeDiameter { get; set; }
        public string PumpRodMaterial { get; set; }
        public string PumpRodDiameter { get; set; }
        public string Comments { get; set; }
    }

    public class LithoDepthTable
    {
        public Guid? hydroLithoDepthDescId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Lithology_description { get; set; }

    }

    public class WaterstrikeTable
    {
        public Guid? hydroGeoLithoYieldAquiferId { get; set; }
        public string Water_strike { get; set; }
        public string Estimated_Yield { get; set; }
        public string Aquifer { get; set; }
        public string OtherAquifer { get; set; }

    }

    public class hydrogeologicalinformation_details
    {
        public Guid boreholeId { get; set; }
        public Guid? hydroLithoId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public string TotalEstimatedYield { get; set; }
        public string DepthtoBedrock { get; set; }
        public string GeologicalSetting { get; set; }
        public string Comments { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<LithoDepthTable> LithoDepthTable { get; set; }
        public List<WaterstrikeTable> WaterstrikeTable { get; set; }


    }

   

    public class FormationLogTable
    {

        public Guid? drillerDeepWellLogId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string DateAndTime_str { get; set; }
        public string DrillPipeNo { get; set; }
        public string Depth { get; set; }
        public string Minutes { get; set; }
        public string Rate { get; set; }
        public string Log { get; set; }
        public string Activity { get; set; }
        public string Comments { get; set; }

    }
    public class DeepWellLogForm_details
    {
        public Guid boreholeId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public DateTime DateStart { get; set; }
        public string DateStart_str { get; set; }
        public DateTime DateEnd { get; set; }
        public string DateEnd_str { get; set; }
        public string Driller_units { get; set; }
        public string TableHeight { get; set; }
        public string DrillingRodLength { get; set; }
        public string DrillBitLength { get; set; }
        public string DeepwellReportPath { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<FormationLogTable> FormationLogTable { get; set; }

    }

    public class DrawdownTable
    {

        public Guid? stepTestId { get; set; }
        public int StepNo { get; set; }
        public string Time { get; set; }
        public string Water_Level { get; set; }
        public string Draw_Down { get; set; }
        public string Discharge { get; set; }
        public string EC { get; set; }
        public string Remarks { get; set; }
    }

    public class Drawdown_details
    {
        public Guid boreholeId { get; set; }
        public string BoreholeNumber { get; set; }
        public string type { get; set; }
        public int TotalSteps { get; set; }
        public DateTime DrawdownPumpOn { get; set; }
        public string DrawdownPumpOn_str { get; set; }
        public DateTime DrawdownPumpOff { get; set; }
        public string DrawdownPumpOff_str { get; set; }
        public int StepTestNo { get; set; }
        public string DrawdownSiteFile { get; set; }
        public string DrawdownDuration { get; set; }
        public string DrawdownSWL { get; set; }
        public string DrawdownDWL { get; set; }
        public string DrawdownMeasuringPoint { get; set; }
        public string DrawdownPumpInstallationDepth { get; set; }
        public string DrawdownMeasuredBy { get; set; }
        public int userid { get; set; }
        public string userName { get; set; }
        public List<DrawdownTable> DrawdownTable { get; set; }


    }

    public class ConstantTable
    {

        public Guid? testRowId { get; set; }
        public string Time { get; set; }
        public string Water_Level { get; set; }
        public string Draw_Down { get; set; }
        public string Discharge { get; set; }
        public string EC { get; set; }
        public string Remarks { get; set; }
    }

    public class   Constant_details
    {
        public Guid boreholeId { get; set; }
        public string BoreholeNumber { get; set; }
        public string type { get; set; }
        public DateTime ConstantPumpOn { get; set; }
        public string ConstantPumpOn_str { get; set; }
        public DateTime ConstantPumpOff { get; set; }
        public string ConstantPumpOff_str { get; set; }
        public string ConstantSiteFile { get; set; }
        public string ConstantDuration { get; set; }
        public string ConstantSWL { get; set; }
        public string ConstantDWL { get; set; }
        public string ConstantMeasuringPoint { get; set; }
        public string ConstantPumpInstallationDepth { get; set; }
        public string ConstantMeasuredBy { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<ConstantTable> ConstantTable { get; set; }


    }

    public class RecoveryTable
    {
        public Guid? recoveryTestStepId { get; set; }
        public string Time { get; set; }
        public string Water_Level { get; set; }
        public string Resedual_Drawdown { get; set; }
        public string RecoveryPercentage { get; set; }
        public string Remarks { get; set; }

    }

    public class RecoveryDetails
    {
        public Guid boreholeId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public DateTime RecoveryPumpOn { get; set; }
        public string RecoveryPumpOn_str { get; set; }
        public DateTime RecoveryPumpOff { get; set; }
        public string RecoveryPumpOff_str { get; set; }
        public string RecoveryDuration { get; set; }
        public string RecoverySWL { get; set; }
        public string RecoveryDWL { get; set; }
        public string RecoveryMeasuringPoint { get; set; }
        public string RecoveryPumpInstallationDepth { get; set; }
        public string RecoveryMeasuredBy { get; set; }
        public string RecoverySiteFilePath { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<RecoveryTable> RecoveryTable { get; set; }
    }
    public class ConstRecoveryTable
    {
        public Guid? constRecoveryTestMinId { get; set; }
        public string Time { get; set; }
        public string Water_Level { get; set; }
        public string Resedual_Drawdown { get; set; }
        public string RecoveryPercentage { get; set; }
        public string Remarks { get; set; }

    }

    public class ConstRecoveryDetails
    {
        public Guid boreholeId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public DateTime ConstRecoveryPumpOn { get; set; }
        public string ConstRecoveryPumpOn_str { get; set; }
        public DateTime ConstRecoveryPumpOff { get; set; }
        public string ConstRecoveryPumpOff_str { get; set; }
        public string ConstRecoveryDuration { get; set; }
        public string ConstRecoverySWL { get; set; }
        public string ConstRecoveryDWL { get; set; }
        public string ConstRecoveryMeasuringPoint { get; set; }
        public string ConstRecoveryPumpInstallationDepth { get; set; }
        public string ConstRecoveryMeasuredBy { get; set; }
        public string ConstRecoverySiteFilePath { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<ConstRecoveryTable> ConstRecoveryTable { get; set; }
    }
    public class DrillingSpecTable
    {
        public Guid? drillingSpecificationStepId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Bit_Dia { get; set; }
        public string Bit_Type { get; set; }
        public string Drill_Method { get; set; }

    }
    public class DrillingSpecDetails
    {
        public Guid boreholeId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public string DrillingSpecFilePath { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<DrillingSpecTable> DrillingSpecTable { get; set; }

    }

    public class LinningTable
    {
        public Guid? bhLinningInstalledStepId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Casing_screen { get; set; }
        public string Remarks { get; set; }

    }
    public class LinningInstalledDetails
    {
        public Guid boreholeId { get; set; }
        public string BoreholeNumber { get; set; }
        public string type { get; set; }
        public string CasingLengthAboveGround { get; set; }
        public string InnerDia { get; set; }
        public string OuterDia { get; set; }
        public string Material { get; set; }
        public string SlotSize { get; set; }
        public string LinningFilePath { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<LinningTable> LinningTable { get; set; }
    }

    public class FillingTable
    {
        public Guid? bhFillingStepId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string GravelPack { get; set; }
        public string BackFillMaterial { get; set; }
        public string SealType { get; set; }
        public string Packer { get; set; }
        public string BottomPlug { get; set; }
    }
    public class FillingDetails
    {
        public Guid boreholeId { get; set; }
        public string BoreholeNumber { get; set; }
        public string type { get; set; }
        public string FillingFilePath { get; set; }
        public string userName { get; set; }
        public int userid { get; set; }
        public List<FillingTable> FillingTable { get; set; }
    }

    public class YieldTable
    {
        public Guid? yieldStepTestReviewId { get; set; }
        public int StepNo { get; set; }
        public string Yield { get; set; }
        public string Draw_Down { get; set; }
        public string Specific_Capacity { get; set; }
    }
    public class YieldFlowData
    {
        public Guid boreholeId { get; set; }
        public string type { get; set; }
        public string BoreholeNumber { get; set; }
        public int YieldOrganisation { get; set; }
        public DateTime TestingDate { get; set; }
        public string TestingDate_str { get; set; }
        public string PersonName { get; set; }
        public string PersonTitle { get; set; }
        public string TestDuration { get; set; }
        public bool StepPumpTest { get; set; }
        public string StepPumpTest_str { get; set; }
        public bool Constantdischarge { get; set; }
        public string Constantdischarge_str { get; set; }
        public string AverageDischarge { get; set; }
        public string StaticWaterLevel { get; set; }
        public DateTime DateMeasured { get; set; }
        public string DateMeasured_str { get; set; }
        public string PumpingWaterLevel { get; set; }
        public string MaximumDrawDown { get; set; }
        public bool HydroFactured { get; set; }
        public string HydroFactured_str { get; set; }
        public DateTime HydroFacturedDate { get; set; }
        public string HydroFacturedDate_str { get; set; }
        public string Transmissivity { get; set; }
        public string SpecCapacity { get; set; }
        public bool Naturalflow { get; set; }
        public string Naturalflow_str { get; set; }
        public bool Airlifttest { get; set; }
        public string Airlifttest_str { get; set; }
        public string YieldComments { get; set; }
        public string PumpTestResults { get; set; }
        public int userid { get; set; }
        public string userName { get; set; }
        public List<YieldTable> YieldTable { get; set; }

    }

    public class BoreholeNumbers
    {
        public string BoreholeNumber { get; set; }
        public Guid boreholeId { get; set; }
        public string CreatedDate { get; set; }
        public string applicationReceivedDate { get; set; }
        public string applicationApprovedDate { get; set; }
        public string forwardedTo { get; set; }
        public string applicationStatus { get; set; }
        public string action { get; set; }
        public string applicationType { get; set; }
        public string applicationForwardedDate { get; set; }
        public string applicationexpirydate { get; set; }
        public string comment { get; set; }
        public string commentedBy { get; set; }
        public string commentedTo { get; set; }
        public string applicationApprovedBy { get; set; }
        public List<string> fileNames { get; set; }

    }

    public class hydrochemicalParameters
    {
        public Guid boreholeId { get; set; }
        public List<Parameters> Parameters { get; set; }

    }
    public class Parameters
    {
     
        public int wqMasterId { get; set; }
        public int? hydrochemicalMasterId { get; set; }
        public string GroupType { get; set; }
        public string Parameter { get; set; }
        public string PrimaryUnit { get; set; }
        public string SecondaryUnit { get; set; }
        public string NationalStandards { get; set; }

    }

    public class ApplicationAction_save_details
    {
        public string type { get; set; }
        public int taskId { get; set; }
        public string reviewText { get; set; }
        public string inputUserId { get; set; }
        public string inputRoleId { get; set; }
        public string deskRoleId { get; set; }
        public string markedUserId { get; set; }
        public string status { get; set; }
        public DateTime dateTime { get; set; }
        public int createdBy { get; set; }
        public string firstName { get; set; }
        public string RemarksDate { get; set; }

    }




}
