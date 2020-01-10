/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// Defines ServiceTypeNullable
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ServiceTypeNullable
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum ProvisionSiteCollection for value: ProvisionSiteCollection
        /// </summary>
        [EnumMember(Value = "ProvisionSiteCollection")]
        ProvisionSiteCollection = 2,

        /// <summary>
        /// Enum CreateSubSite for value: CreateSubSite
        /// </summary>
        [EnumMember(Value = "CreateSubSite")]
        CreateSubSite = 3,

        /// <summary>
        /// Enum SiteCollectionLifecycleMgmt for value: SiteCollectionLifecycleMgmt
        /// </summary>
        [EnumMember(Value = "SiteCollectionLifecycleMgmt")]
        SiteCollectionLifecycleMgmt = 4,

        /// <summary>
        /// Enum ArchiveSiteCollection for value: ArchiveSiteCollection
        /// </summary>
        [EnumMember(Value = "ArchiveSiteCollection")]
        ArchiveSiteCollection = 5,

        /// <summary>
        /// Enum DeleteSiteCollection for value: DeleteSiteCollection
        /// </summary>
        [EnumMember(Value = "DeleteSiteCollection")]
        DeleteSiteCollection = 6,

        /// <summary>
        /// Enum ExtendSiteCollection for value: ExtendSiteCollection
        /// </summary>
        [EnumMember(Value = "ExtendSiteCollection")]
        ExtendSiteCollection = 7,

        /// <summary>
        /// Enum ChangeSiteCollectionPolicy for value: ChangeSiteCollectionPolicy
        /// </summary>
        [EnumMember(Value = "ChangeSiteCollectionPolicy")]
        ChangeSiteCollectionPolicy = 8,

        /// <summary>
        /// Enum ChangeSiteCollectionMetadata for value: ChangeSiteCollectionMetadata
        /// </summary>
        [EnumMember(Value = "ChangeSiteCollectionMetadata")]
        ChangeSiteCollectionMetadata = 9,

        /// <summary>
        /// Enum ChangeSiteCollectionContact for value: ChangeSiteCollectionContact
        /// </summary>
        [EnumMember(Value = "ChangeSiteCollectionContact")]
        ChangeSiteCollectionContact = 10,

        /// <summary>
        /// Enum TransferUserPermission for value: TransferUserPermission
        /// </summary>
        [EnumMember(Value = "TransferUserPermission")]
        TransferUserPermission = 11,

        /// <summary>
        /// Enum ManualArchiveSiteCollectionContent for value: ManualArchiveSiteCollectionContent
        /// </summary>
        [EnumMember(Value = "ManualArchiveSiteCollectionContent")]
        ManualArchiveSiteCollectionContent = 12,

        /// <summary>
        /// Enum CloneUserPermissions for value: CloneUserPermissions
        /// </summary>
        [EnumMember(Value = "CloneUserPermissions")]
        CloneUserPermissions = 13,

        /// <summary>
        /// Enum SiteLifecycleManagement for value: SiteLifecycleManagement
        /// </summary>
        [EnumMember(Value = "SiteLifecycleManagement")]
        SiteLifecycleManagement = 14,

        /// <summary>
        /// Enum GrantUserPermissions for value: GrantUserPermissions
        /// </summary>
        [EnumMember(Value = "GrantUserPermissions")]
        GrantUserPermissions = 15,

        /// <summary>
        /// Enum RemoveUserPermissions for value: RemoveUserPermissions
        /// </summary>
        [EnumMember(Value = "RemoveUserPermissions")]
        RemoveUserPermissions = 16,

        /// <summary>
        /// Enum ChangeSubSitePolicy for value: ChangeSubSitePolicy
        /// </summary>
        [EnumMember(Value = "ChangeSubSitePolicy")]
        ChangeSubSitePolicy = 17,

        /// <summary>
        /// Enum ChangeSubSiteMetadata for value: ChangeSubSiteMetadata
        /// </summary>
        [EnumMember(Value = "ChangeSubSiteMetadata")]
        ChangeSubSiteMetadata = 18,

        /// <summary>
        /// Enum ChangeSubSiteContact for value: ChangeSubSiteContact
        /// </summary>
        [EnumMember(Value = "ChangeSubSiteContact")]
        ChangeSubSiteContact = 19,

        /// <summary>
        /// Enum CleanDeadAccounts for value: CleanDeadAccounts
        /// </summary>
        [EnumMember(Value = "CleanDeadAccounts")]
        CleanDeadAccounts = 20,

        /// <summary>
        /// Enum BackupAndRestore for value: BackupAndRestore
        /// </summary>
        [EnumMember(Value = "BackupAndRestore")]
        BackupAndRestore = 21,

        /// <summary>
        /// Enum ArchiveUserContent for value: ArchiveUserContent
        /// </summary>
        [EnumMember(Value = "ArchiveUserContent")]
        ArchiveUserContent = 22,

        /// <summary>
        /// Enum MoveListItem for value: MoveListItem
        /// </summary>
        [EnumMember(Value = "MoveListItem")]
        MoveListItem = 23,

        /// <summary>
        /// Enum MoveList for value: MoveList
        /// </summary>
        [EnumMember(Value = "MoveList")]
        MoveList = 24,

        /// <summary>
        /// Enum MoveSite for value: MoveSite
        /// </summary>
        [EnumMember(Value = "MoveSite")]
        MoveSite = 25,

        /// <summary>
        /// Enum SiteTemplateDeployment for value: SiteTemplateDeployment
        /// </summary>
        [EnumMember(Value = "SiteTemplateDeployment")]
        SiteTemplateDeployment = 26,

        /// <summary>
        /// Enum SiteThemeDeployment for value: SiteThemeDeployment
        /// </summary>
        [EnumMember(Value = "SiteThemeDeployment")]
        SiteThemeDeployment = 27,

        /// <summary>
        /// Enum SandboxSolutionDeployment for value: SandboxSolutionDeployment
        /// </summary>
        [EnumMember(Value = "SandboxSolutionDeployment")]
        SandboxSolutionDeployment = 28,

        /// <summary>
        /// Enum FarmSolutionDeployment for value: FarmSolutionDeployment
        /// </summary>
        [EnumMember(Value = "FarmSolutionDeployment")]
        FarmSolutionDeployment = 29,

        /// <summary>
        /// Enum SiteOwnerReporting for value: SiteOwnerReporting
        /// </summary>
        [EnumMember(Value = "SiteOwnerReporting")]
        SiteOwnerReporting = 30,

        /// <summary>
        /// Enum SiteCollectionOwnerReporting for value: SiteCollectionOwnerReporting
        /// </summary>
        [EnumMember(Value = "SiteCollectionOwnerReporting")]
        SiteCollectionOwnerReporting = 31,

        /// <summary>
        /// Enum SiteRequestReporting for value: SiteRequestReporting
        /// </summary>
        [EnumMember(Value = "SiteRequestReporting")]
        SiteRequestReporting = 32,

        /// <summary>
        /// Enum ContentManager for value: ContentManager
        /// </summary>
        [EnumMember(Value = "ContentManager")]
        ContentManager = 33,

        /// <summary>
        /// Enum ProvisionSiteCollectionExternal for value: ProvisionSiteCollectionExternal
        /// </summary>
        [EnumMember(Value = "ProvisionSiteCollectionExternal")]
        ProvisionSiteCollectionExternal = 34,

        /// <summary>
        /// Enum MySite for value: MySite
        /// </summary>
        [EnumMember(Value = "MySite")]
        MySite = 35,

        /// <summary>
        /// Enum CreateList for value: CreateList
        /// </summary>
        [EnumMember(Value = "CreateList")]
        CreateList = 36,

        /// <summary>
        /// Enum ChangeList for value: ChangeList
        /// </summary>
        [EnumMember(Value = "ChangeList")]
        ChangeList = 37,

        /// <summary>
        /// Enum AutoSiteCollectionLifecycleMgmt for value: AutoSiteCollectionLifecycleMgmt
        /// </summary>
        [EnumMember(Value = "AutoSiteCollectionLifecycleMgmt")]
        AutoSiteCollectionLifecycleMgmt = 38,

        /// <summary>
        /// Enum QuestionaireMgmt for value: QuestionaireMgmt
        /// </summary>
        [EnumMember(Value = "QuestionaireMgmt")]
        QuestionaireMgmt = 39,

        /// <summary>
        /// Enum PermRecertify for value: PermRecertify
        /// </summary>
        [EnumMember(Value = "PermRecertify")]
        PermRecertify = 40,

        /// <summary>
        /// Enum MetadataRecertify for value: MetadataRecertify
        /// </summary>
        [EnumMember(Value = "MetadataRecertify")]
        MetadataRecertify = 41,

        /// <summary>
        /// Enum OwnershipRecertification for value: OwnershipRecertification
        /// </summary>
        [EnumMember(Value = "OwnershipRecertification")]
        OwnershipRecertification = 42,

        /// <summary>
        /// Enum Election for value: Election
        /// </summary>
        [EnumMember(Value = "Election")]
        Election = 43,

        /// <summary>
        /// Enum Unlock for value: Unlock
        /// </summary>
        [EnumMember(Value = "Unlock")]
        Unlock = 44,

        /// <summary>
        /// Enum AutoLocking for value: AutoLocking
        /// </summary>
        [EnumMember(Value = "AutoLocking")]
        AutoLocking = 45,

        /// <summary>
        /// Enum SCInactivityThreshold for value: SCInactivityThreshold
        /// </summary>
        [EnumMember(Value = "SCInactivityThreshold")]
        SCInactivityThreshold = 46,

        /// <summary>
        /// Enum SCLeasePeriod for value: SCLeasePeriod
        /// </summary>
        [EnumMember(Value = "SCLeasePeriod")]
        SCLeasePeriod = 47,

        /// <summary>
        /// Enum Blank for value: Blank
        /// </summary>
        [EnumMember(Value = "Blank")]
        Blank = 48,

        /// <summary>
        /// Enum LockSC for value: LockSC
        /// </summary>
        [EnumMember(Value = "LockSC")]
        LockSC = 49,

        /// <summary>
        /// Enum ChangeSCQuota for value: ChangeSCQuota
        /// </summary>
        [EnumMember(Value = "ChangeSCQuota")]
        ChangeSCQuota = 50,

        /// <summary>
        /// Enum ApplySiteInformation for value: ApplySiteInformation
        /// </summary>
        [EnumMember(Value = "ApplySiteInformation")]
        ApplySiteInformation = 51,

        /// <summary>
        /// Enum ImportSite for value: ImportSite
        /// </summary>
        [EnumMember(Value = "ImportSite")]
        ImportSite = 52,

        /// <summary>
        /// Enum ApplySitePolicy for value: ApplySitePolicy
        /// </summary>
        [EnumMember(Value = "ApplySitePolicy")]
        ApplySitePolicy = 53,

        /// <summary>
        /// Enum ImportWeb for value: ImportWeb
        /// </summary>
        [EnumMember(Value = "ImportWeb")]
        ImportWeb = 54,

        /// <summary>
        /// Enum RenewSite for value: RenewSite
        /// </summary>
        [EnumMember(Value = "RenewSite")]
        RenewSite = 55,

        /// <summary>
        /// Enum RenewGroup for value: RenewGroup
        /// </summary>
        [EnumMember(Value = "RenewGroup")]
        RenewGroup = 56,

        /// <summary>
        /// Enum ExportReport for value: ExportReport
        /// </summary>
        [EnumMember(Value = "ExportReport")]
        ExportReport = 57,

        /// <summary>
        /// Enum RequestValidation for value: RequestValidation
        /// </summary>
        [EnumMember(Value = "RequestValidation")]
        RequestValidation = 58,

        /// <summary>
        /// Enum SyncSiteMetadata for value: SyncSiteMetadata
        /// </summary>
        [EnumMember(Value = "SyncSiteMetadata")]
        SyncSiteMetadata = 59,

        /// <summary>
        /// Enum PermissionManagement for value: PermissionManagement
        /// </summary>
        [EnumMember(Value = "PermissionManagement")]
        PermissionManagement = 60,

        /// <summary>
        /// Enum CreateUser for value: CreateUser
        /// </summary>
        [EnumMember(Value = "CreateUser")]
        CreateUser = 61,

        /// <summary>
        /// Enum ChangeUser for value: ChangeUser
        /// </summary>
        [EnumMember(Value = "ChangeUser")]
        ChangeUser = 62,

        /// <summary>
        /// Enum UserLifecycle for value: UserLifecycle
        /// </summary>
        [EnumMember(Value = "UserLifecycle")]
        UserLifecycle = 63,

        /// <summary>
        /// Enum OffBoardingUser for value: OffBoardingUser
        /// </summary>
        [EnumMember(Value = "OffBoardingUser")]
        OffBoardingUser = 64,

        /// <summary>
        /// Enum ExtendUser for value: ExtendUser
        /// </summary>
        [EnumMember(Value = "ExtendUser")]
        ExtendUser = 65,

        /// <summary>
        /// Enum ChangeUserPolicy for value: ChangeUserPolicy
        /// </summary>
        [EnumMember(Value = "ChangeUserPolicy")]
        ChangeUserPolicy = 66,

        /// <summary>
        /// Enum UnblockUser for value: UnblockUser
        /// </summary>
        [EnumMember(Value = "UnblockUser")]
        UnblockUser = 67,

        /// <summary>
        /// Enum ChangeUserLoginName for value: ChangeUserLoginName
        /// </summary>
        [EnumMember(Value = "ChangeUserLoginName")]
        ChangeUserLoginName = 68,

        /// <summary>
        /// Enum CreateGroup for value: CreateGroup
        /// </summary>
        [EnumMember(Value = "CreateGroup")]
        CreateGroup = 69,

        /// <summary>
        /// Enum ChangeGroup for value: ChangeGroup
        /// </summary>
        [EnumMember(Value = "ChangeGroup")]
        ChangeGroup = 70,

        /// <summary>
        /// Enum GroupLifecycle for value: GroupLifecycle
        /// </summary>
        [EnumMember(Value = "GroupLifecycle")]
        GroupLifecycle = 71,

        /// <summary>
        /// Enum DeleteGroup for value: DeleteGroup
        /// </summary>
        [EnumMember(Value = "DeleteGroup")]
        DeleteGroup = 72,

        /// <summary>
        /// Enum ExtendGroup for value: ExtendGroup
        /// </summary>
        [EnumMember(Value = "ExtendGroup")]
        ExtendGroup = 73,

        /// <summary>
        /// Enum ChangeGroupPolicy for value: ChangeGroupPolicy
        /// </summary>
        [EnumMember(Value = "ChangeGroupPolicy")]
        ChangeGroupPolicy = 74,

        /// <summary>
        /// Enum ArchiveTeam for value: ArchiveTeam
        /// </summary>
        [EnumMember(Value = "ArchiveTeam")]
        ArchiveTeam = 75,

        /// <summary>
        /// Enum UnArchiveTeam for value: UnArchiveTeam
        /// </summary>
        [EnumMember(Value = "UnArchiveTeam")]
        UnArchiveTeam = 76,

        /// <summary>
        /// Enum GroupMembershipRecertification for value: GroupMembershipRecertification
        /// </summary>
        [EnumMember(Value = "GroupMembershipRecertification")]
        GroupMembershipRecertification = 77,

        /// <summary>
        /// Enum GroupPermissionRecertification for value: GroupPermissionRecertification
        /// </summary>
        [EnumMember(Value = "GroupPermissionRecertification")]
        GroupPermissionRecertification = 78,

        /// <summary>
        /// Enum ChangeGroupQuota for value: ChangeGroupQuota
        /// </summary>
        [EnumMember(Value = "ChangeGroupQuota")]
        ChangeGroupQuota = 79,

        /// <summary>
        /// Enum ContinueAccess for value: ContinueAccess
        /// </summary>
        [EnumMember(Value = "ContinueAccess")]
        ContinueAccess = 80,

        /// <summary>
        /// Enum ApplyGroupInformation for value: ApplyGroupInformation
        /// </summary>
        [EnumMember(Value = "ApplyGroupInformation")]
        ApplyGroupInformation = 81,

        /// <summary>
        /// Enum ApplyGroupPolicy for value: ApplyGroupPolicy
        /// </summary>
        [EnumMember(Value = "ApplyGroupPolicy")]
        ApplyGroupPolicy = 82,

        /// <summary>
        /// Enum ImportAzureGroup for value: ImportAzureGroup
        /// </summary>
        [EnumMember(Value = "ImportAzureGroup")]
        ImportAzureGroup = 83,

        /// <summary>
        /// Enum ImportAzureUser for value: ImportAzureUser
        /// </summary>
        [EnumMember(Value = "ImportAzureUser")]
        ImportAzureUser = 84,

        /// <summary>
        /// Enum SyncSite for value: SyncSite
        /// </summary>
        [EnumMember(Value = "SyncSite")]
        SyncSite = 85,

        /// <summary>
        /// Enum UpgradeSiteLifecycleSetting for value: UpgradeSiteLifecycleSetting
        /// </summary>
        [EnumMember(Value = "UpgradeSiteLifecycleSetting")]
        UpgradeSiteLifecycleSetting = 86,

        /// <summary>
        /// Enum AutoElection for value: AutoElection
        /// </summary>
        [EnumMember(Value = "AutoElection")]
        AutoElection = 87,

        /// <summary>
        /// Enum ManualArchiveTimer for value: ManualArchiveTimer
        /// </summary>
        [EnumMember(Value = "ManualArchiveTimer")]
        ManualArchiveTimer = 88,

        /// <summary>
        /// Enum SyncWeb for value: SyncWeb
        /// </summary>
        [EnumMember(Value = "SyncWeb")]
        SyncWeb = 89,

        /// <summary>
        /// Enum QuotaThresholdTimerJob for value: QuotaThresholdTimerJob
        /// </summary>
        [EnumMember(Value = "QuotaThresholdTimerJob")]
        QuotaThresholdTimerJob = 90,

        /// <summary>
        /// Enum SyncUserForDynamicRule for value: SyncUserForDynamicRule
        /// </summary>
        [EnumMember(Value = "SyncUserForDynamicRule")]
        SyncUserForDynamicRule = 91,

        /// <summary>
        /// Enum SyncGroup for value: SyncGroup
        /// </summary>
        [EnumMember(Value = "SyncGroup")]
        SyncGroup = 92,

        /// <summary>
        /// Enum AutoImportSiteCustomService for value: AutoImportSiteCustomService
        /// </summary>
        [EnumMember(Value = "AutoImportSiteCustomService")]
        AutoImportSiteCustomService = 93,

        /// <summary>
        /// Enum AutoImportSite for value: AutoImportSite
        /// </summary>
        [EnumMember(Value = "AutoImportSite")]
        AutoImportSite = 94,

        /// <summary>
        /// Enum AutoImportGroup for value: AutoImportGroup
        /// </summary>
        [EnumMember(Value = "AutoImportGroup")]
        AutoImportGroup = 95,

        /// <summary>
        /// Enum TemporaryPermissionStart for value: TemporaryPermissionStart
        /// </summary>
        [EnumMember(Value = "TemporaryPermissionStart")]
        TemporaryPermissionStart = 96,

        /// <summary>
        /// Enum TemporaryPermissionEnd for value: TemporaryPermissionEnd
        /// </summary>
        [EnumMember(Value = "TemporaryPermissionEnd")]
        TemporaryPermissionEnd = 97,

        /// <summary>
        /// Enum TemporaryPermissionExpiringNotificationJob for value: TemporaryPermissionExpiringNotificationJob
        /// </summary>
        [EnumMember(Value = "TemporaryPermissionExpiringNotificationJob")]
        TemporaryPermissionExpiringNotificationJob = 98,

        /// <summary>
        /// Enum RenewTeams for value: RenewTeams
        /// </summary>
        [EnumMember(Value = "RenewTeams")]
        RenewTeams = 99,

        /// <summary>
        /// Enum AutoExportReport for value: AutoExportReport
        /// </summary>
        [EnumMember(Value = "AutoExportReport")]
        AutoExportReport = 100,

        /// <summary>
        /// Enum SyncUserInformation for value: SyncUserInformation
        /// </summary>
        [EnumMember(Value = "SyncUserInformation")]
        SyncUserInformation = 101,

        /// <summary>
        /// Enum SyncUpsMetadata for value: SyncUpsMetadata
        /// </summary>
        [EnumMember(Value = "SyncUpsMetadata")]
        SyncUpsMetadata = 102

    }

}
