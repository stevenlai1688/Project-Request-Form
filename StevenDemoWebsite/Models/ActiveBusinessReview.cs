using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ActiveBusinessReview
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public bool Active { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Status { get; set; }
        public int? AreaId { get; set; }
        public int? AreaManagerId { get; set; }
        public int? BranchId { get; set; }
        public int? BranchManagerId { get; set; }
        public int? EmployeeId { get; set; }
        public int? EmployeeManagerId { get; set; }
        public int? RegionId { get; set; }
        public int? RegionManagerId { get; set; }
        public int? DivisionId { get; set; }
        public int? CreatedBy { get; set; }
        public int? DivisionManagerId { get; set; }
        public decimal? EmployeeVolumeGoal { get; set; }
        public int? EmployeeUnitsGoal { get; set; }
        public decimal? EmployeePurchaseVolumeGoal { get; set; }
        public decimal? EmployeePercentBondLoansGoal { get; set; }
        public int? EmployeeExtensionRequestGoal { get; set; }
        public decimal? EmployeeAveragePricingGoal { get; set; }
        public decimal? EmployeeCostToCuresGoal { get; set; }
        public int? EmployeeTotalApplicationGoal { get; set; }
        public int? EmployeeTotalLeadsGoal { get; set; }
        public decimal? EntityPurchaseVolumeGoal { get; set; }
        public decimal? EntityPercentBondLoansGoal { get; set; }
        public int? EntityExtensionRequestGoal { get; set; }
        public decimal? EntityAveragePricingGoal { get; set; }
        public decimal? EntityCostToCuresGoal { get; set; }
        public int? EntityTotalApplicationGoal { get; set; }
        public int? EntityTotalLeadsGoal { get; set; }
        public int? RecruitsThisMonth { get; set; }
        public int? RecruitsYtd { get; set; }
        public int? RecruitsGoal { get; set; }
        public int? CallsThisMonth { get; set; }
        public int? CallsYtd { get; set; }
        public int? CallsGoal { get; set; }
        public int? FaceToFaceThisMonth { get; set; }
        public int? FaceToFaceYtd { get; set; }
        public int? FaceToFaceGoal { get; set; }
        public int? NewHiresThisMonth { get; set; }
        public int? NewHiresYtd { get; set; }
        public int? NewHiresGoal { get; set; }
        public string EmployeeProducerRecognition { get; set; }
        public string EmployeeLessThanThree { get; set; }
        public string EmployeeRealtorOpportunities { get; set; }
        public string EmployeeBuilderOpportunities { get; set; }
        public string EmployeeCorporateOpportunities { get; set; }
        public string EmployeeOtherMarketing { get; set; }
        public string EmployeeKeyWins { get; set; }
        public string EmployeeKeyTopics { get; set; }
        public bool? Locked { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? SubmittedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public decimal? EntityVolumeGoal { get; set; }
        public int? EntityUnitsGoal { get; set; }
        public decimal? EntityPurchasePercentageGoal { get; set; }
        public decimal? EmployeePurchasePercentageGoal { get; set; }
        public string EmployeeManagementAndDevelopmentNotes { get; set; }
        public string ManagerManagementAndDevelopmentNotes { get; set; }
        public string EmployeeLeadershipNotes { get; set; }
        public string ManagerLeadershipNotes { get; set; }
        public string EmployeeSelfDevelopmentNotes { get; set; }
        public string ManagerSelfDevelopmentNotes { get; set; }
        public string EmployeeTurnoverNotes { get; set; }
        public string ManagerTurnoverNotes { get; set; }
        public string ManagerKeyWins { get; set; }
        public string ManagerKeyTopics { get; set; }
        public string ManagerProducerRecognition { get; set; }
        public string ManagerLessThanThree { get; set; }
        public string ManagerRealtorOpportunities { get; set; }
        public string ManagerBuilderOpportunities { get; set; }
        public string ManagerCorporateOpportunities { get; set; }
        public string ManagerOtherMarketing { get; set; }
        public string EmployeeAcknowledgement { get; set; }
        public string ManagerAcknowledgement { get; set; }
        public DateTime? EmployeeAcknowledgementDate { get; set; }
        public DateTime? ManagerAcknowledgementDate { get; set; }
        public string EmployeeTeamworkNotes { get; set; }
        public string ManagerTeamworkNotes { get; set; }
        public string EmployeeToolsResourcesTrainingNotes { get; set; }
        public string ManagerToolsResourcesTrainingNotes { get; set; }
        public string ReviewUserType { get; set; }
        public string TurnoverEmployeeNotes { get; set; }
        public string TurnoverManagerNotes { get; set; }
        public string EmployeeReferringPartner { get; set; }
        public string EmployeeNewPartnerMeeting { get; set; }
        public string EmployeeExistingRealtor { get; set; }
        public string EmployeeBuilder { get; set; }
        public string EmployeeOpenHouseVisits { get; set; }
        public string EmployeeOtherMarketingEvents { get; set; }
        public string ManagerReferringPartner { get; set; }
        public string ManagerNewPartnerMeeting { get; set; }
        public string ManagerExistingRealtor { get; set; }
        public string ManagerBuilder { get; set; }
        public string ManagerOpenHouseVisits { get; set; }
        public string ManagerOtherMarketingEvents { get; set; }
    }
}
