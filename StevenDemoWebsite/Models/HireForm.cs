using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class HireForm
    {
        public int Id { get; set; }
        public string FullLegalName { get; set; }
        public int? TitlePositionId { get; set; }
        public string OtherTitlePosition { get; set; }
        public string NmlsId { get; set; }
        public string StatesLicencedId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public string OfficeConfiguration { get; set; }
        public string FirstPaycheck { get; set; }
        public DateTime? StartDate { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalMobileNumber { get; set; }
        public string BusinessCard { get; set; }
        public string PreferrerName { get; set; }
        public string PreferrerTitle { get; set; }
        public string PersonalMobileInMarketing { get; set; }
        public string PhotoOnCard { get; set; }
        public string Database { get; set; }
        public string NameTag { get; set; }
        public string ShipToCorporateBranch { get; set; }
        public string ShipToDivision1 { get; set; }
        public string ShipToDivision2 { get; set; }
        public string ShipToOtherBranch { get; set; }
        public string EmailGroups { get; set; }
        public string OtherEmailGroup { get; set; }
        public string SharedDrivesFolders { get; set; }
        public string Workstation { get; set; }
        public string ReissuingEquipment { get; set; }
        public string KeyboardAndMouse { get; set; }
        public string PhoneAndExtension { get; set; }
        public string PreviousUsersPhone { get; set; }
        public string PhysicalDeskPhone { get; set; }
        public string Fax { get; set; }
        public string PreviousUsersFax { get; set; }
        public string Manager { get; set; }
        public string ManagerContactInfo { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual CostCenter CostCenter { get; set; }
        public virtual EmployeeType TitlePosition { get; set; }
    }
}
