/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 4.2.2
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ServiceTypeNullable = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';


  /**
   * Enum class ServiceTypeNullable.
   * @enum {}
   * @readonly
   */
  var exports = {
    /**
     * value: "None"
     * @const
     */
    "None": "None",
    /**
     * value: "ProvisionSiteCollection"
     * @const
     */
    "ProvisionSiteCollection": "ProvisionSiteCollection",
    /**
     * value: "CreateSubSite"
     * @const
     */
    "CreateSubSite": "CreateSubSite",
    /**
     * value: "SiteCollectionLifecycleMgmt"
     * @const
     */
    "SiteCollectionLifecycleMgmt": "SiteCollectionLifecycleMgmt",
    /**
     * value: "ArchiveSiteCollection"
     * @const
     */
    "ArchiveSiteCollection": "ArchiveSiteCollection",
    /**
     * value: "DeleteSiteCollection"
     * @const
     */
    "DeleteSiteCollection": "DeleteSiteCollection",
    /**
     * value: "ExtendSiteCollection"
     * @const
     */
    "ExtendSiteCollection": "ExtendSiteCollection",
    /**
     * value: "ChangeSiteCollectionPolicy"
     * @const
     */
    "ChangeSiteCollectionPolicy": "ChangeSiteCollectionPolicy",
    /**
     * value: "ChangeSiteCollectionMetadata"
     * @const
     */
    "ChangeSiteCollectionMetadata": "ChangeSiteCollectionMetadata",
    /**
     * value: "ChangeSiteCollectionContact"
     * @const
     */
    "ChangeSiteCollectionContact": "ChangeSiteCollectionContact",
    /**
     * value: "TransferUserPermission"
     * @const
     */
    "TransferUserPermission": "TransferUserPermission",
    /**
     * value: "ManualArchiveSiteCollectionContent"
     * @const
     */
    "ManualArchiveSiteCollectionContent": "ManualArchiveSiteCollectionContent",
    /**
     * value: "CloneUserPermissions"
     * @const
     */
    "CloneUserPermissions": "CloneUserPermissions",
    /**
     * value: "SiteLifecycleManagement"
     * @const
     */
    "SiteLifecycleManagement": "SiteLifecycleManagement",
    /**
     * value: "GrantUserPermissions"
     * @const
     */
    "GrantUserPermissions": "GrantUserPermissions",
    /**
     * value: "RemoveUserPermissions"
     * @const
     */
    "RemoveUserPermissions": "RemoveUserPermissions",
    /**
     * value: "ChangeSubSitePolicy"
     * @const
     */
    "ChangeSubSitePolicy": "ChangeSubSitePolicy",
    /**
     * value: "ChangeSubSiteMetadata"
     * @const
     */
    "ChangeSubSiteMetadata": "ChangeSubSiteMetadata",
    /**
     * value: "ChangeSubSiteContact"
     * @const
     */
    "ChangeSubSiteContact": "ChangeSubSiteContact",
    /**
     * value: "CleanDeadAccounts"
     * @const
     */
    "CleanDeadAccounts": "CleanDeadAccounts",
    /**
     * value: "BackupAndRestore"
     * @const
     */
    "BackupAndRestore": "BackupAndRestore",
    /**
     * value: "ArchiveUserContent"
     * @const
     */
    "ArchiveUserContent": "ArchiveUserContent",
    /**
     * value: "MoveListItem"
     * @const
     */
    "MoveListItem": "MoveListItem",
    /**
     * value: "MoveList"
     * @const
     */
    "MoveList": "MoveList",
    /**
     * value: "MoveSite"
     * @const
     */
    "MoveSite": "MoveSite",
    /**
     * value: "SiteTemplateDeployment"
     * @const
     */
    "SiteTemplateDeployment": "SiteTemplateDeployment",
    /**
     * value: "SiteThemeDeployment"
     * @const
     */
    "SiteThemeDeployment": "SiteThemeDeployment",
    /**
     * value: "SandboxSolutionDeployment"
     * @const
     */
    "SandboxSolutionDeployment": "SandboxSolutionDeployment",
    /**
     * value: "FarmSolutionDeployment"
     * @const
     */
    "FarmSolutionDeployment": "FarmSolutionDeployment",
    /**
     * value: "SiteOwnerReporting"
     * @const
     */
    "SiteOwnerReporting": "SiteOwnerReporting",
    /**
     * value: "SiteCollectionOwnerReporting"
     * @const
     */
    "SiteCollectionOwnerReporting": "SiteCollectionOwnerReporting",
    /**
     * value: "SiteRequestReporting"
     * @const
     */
    "SiteRequestReporting": "SiteRequestReporting",
    /**
     * value: "ContentManager"
     * @const
     */
    "ContentManager": "ContentManager",
    /**
     * value: "ProvisionSiteCollectionExternal"
     * @const
     */
    "ProvisionSiteCollectionExternal": "ProvisionSiteCollectionExternal",
    /**
     * value: "MySite"
     * @const
     */
    "MySite": "MySite",
    /**
     * value: "CreateList"
     * @const
     */
    "CreateList": "CreateList",
    /**
     * value: "ChangeList"
     * @const
     */
    "ChangeList": "ChangeList",
    /**
     * value: "AutoSiteCollectionLifecycleMgmt"
     * @const
     */
    "AutoSiteCollectionLifecycleMgmt": "AutoSiteCollectionLifecycleMgmt",
    /**
     * value: "QuestionaireMgmt"
     * @const
     */
    "QuestionaireMgmt": "QuestionaireMgmt",
    /**
     * value: "PermRecertify"
     * @const
     */
    "PermRecertify": "PermRecertify",
    /**
     * value: "MetadataRecertify"
     * @const
     */
    "MetadataRecertify": "MetadataRecertify",
    /**
     * value: "OwnershipRecertification"
     * @const
     */
    "OwnershipRecertification": "OwnershipRecertification",
    /**
     * value: "Election"
     * @const
     */
    "Election": "Election",
    /**
     * value: "Unlock"
     * @const
     */
    "Unlock": "Unlock",
    /**
     * value: "AutoLocking"
     * @const
     */
    "AutoLocking": "AutoLocking",
    /**
     * value: "SCInactivityThreshold"
     * @const
     */
    "SCInactivityThreshold": "SCInactivityThreshold",
    /**
     * value: "SCLeasePeriod"
     * @const
     */
    "SCLeasePeriod": "SCLeasePeriod",
    /**
     * value: "Blank"
     * @const
     */
    "Blank": "Blank",
    /**
     * value: "LockSC"
     * @const
     */
    "LockSC": "LockSC",
    /**
     * value: "ChangeSCQuota"
     * @const
     */
    "ChangeSCQuota": "ChangeSCQuota",
    /**
     * value: "ApplySiteInformation"
     * @const
     */
    "ApplySiteInformation": "ApplySiteInformation",
    /**
     * value: "ImportSite"
     * @const
     */
    "ImportSite": "ImportSite",
    /**
     * value: "ApplySitePolicy"
     * @const
     */
    "ApplySitePolicy": "ApplySitePolicy",
    /**
     * value: "ImportWeb"
     * @const
     */
    "ImportWeb": "ImportWeb",
    /**
     * value: "RenewSite"
     * @const
     */
    "RenewSite": "RenewSite",
    /**
     * value: "RenewGroup"
     * @const
     */
    "RenewGroup": "RenewGroup",
    /**
     * value: "ExportReport"
     * @const
     */
    "ExportReport": "ExportReport",
    /**
     * value: "RequestValidation"
     * @const
     */
    "RequestValidation": "RequestValidation",
    /**
     * value: "SyncSiteMetadata"
     * @const
     */
    "SyncSiteMetadata": "SyncSiteMetadata",
    /**
     * value: "PermissionManagement"
     * @const
     */
    "PermissionManagement": "PermissionManagement",
    /**
     * value: "CreateUser"
     * @const
     */
    "CreateUser": "CreateUser",
    /**
     * value: "ChangeUser"
     * @const
     */
    "ChangeUser": "ChangeUser",
    /**
     * value: "UserLifecycle"
     * @const
     */
    "UserLifecycle": "UserLifecycle",
    /**
     * value: "OffBoardingUser"
     * @const
     */
    "OffBoardingUser": "OffBoardingUser",
    /**
     * value: "ExtendUser"
     * @const
     */
    "ExtendUser": "ExtendUser",
    /**
     * value: "ChangeUserPolicy"
     * @const
     */
    "ChangeUserPolicy": "ChangeUserPolicy",
    /**
     * value: "UnblockUser"
     * @const
     */
    "UnblockUser": "UnblockUser",
    /**
     * value: "ChangeUserLoginName"
     * @const
     */
    "ChangeUserLoginName": "ChangeUserLoginName",
    /**
     * value: "CreateGroup"
     * @const
     */
    "CreateGroup": "CreateGroup",
    /**
     * value: "ChangeGroup"
     * @const
     */
    "ChangeGroup": "ChangeGroup",
    /**
     * value: "GroupLifecycle"
     * @const
     */
    "GroupLifecycle": "GroupLifecycle",
    /**
     * value: "DeleteGroup"
     * @const
     */
    "DeleteGroup": "DeleteGroup",
    /**
     * value: "ExtendGroup"
     * @const
     */
    "ExtendGroup": "ExtendGroup",
    /**
     * value: "ChangeGroupPolicy"
     * @const
     */
    "ChangeGroupPolicy": "ChangeGroupPolicy",
    /**
     * value: "ArchiveTeam"
     * @const
     */
    "ArchiveTeam": "ArchiveTeam",
    /**
     * value: "UnArchiveTeam"
     * @const
     */
    "UnArchiveTeam": "UnArchiveTeam",
    /**
     * value: "GroupMembershipRecertification"
     * @const
     */
    "GroupMembershipRecertification": "GroupMembershipRecertification",
    /**
     * value: "GroupPermissionRecertification"
     * @const
     */
    "GroupPermissionRecertification": "GroupPermissionRecertification",
    /**
     * value: "ChangeGroupQuota"
     * @const
     */
    "ChangeGroupQuota": "ChangeGroupQuota",
    /**
     * value: "ContinueAccess"
     * @const
     */
    "ContinueAccess": "ContinueAccess",
    /**
     * value: "ApplyGroupInformation"
     * @const
     */
    "ApplyGroupInformation": "ApplyGroupInformation",
    /**
     * value: "ApplyGroupPolicy"
     * @const
     */
    "ApplyGroupPolicy": "ApplyGroupPolicy",
    /**
     * value: "ImportAzureGroup"
     * @const
     */
    "ImportAzureGroup": "ImportAzureGroup",
    /**
     * value: "ImportAzureUser"
     * @const
     */
    "ImportAzureUser": "ImportAzureUser",
    /**
     * value: "SyncSite"
     * @const
     */
    "SyncSite": "SyncSite",
    /**
     * value: "UpgradeSiteLifecycleSetting"
     * @const
     */
    "UpgradeSiteLifecycleSetting": "UpgradeSiteLifecycleSetting",
    /**
     * value: "AutoElection"
     * @const
     */
    "AutoElection": "AutoElection",
    /**
     * value: "ManualArchiveTimer"
     * @const
     */
    "ManualArchiveTimer": "ManualArchiveTimer",
    /**
     * value: "SyncWeb"
     * @const
     */
    "SyncWeb": "SyncWeb",
    /**
     * value: "QuotaThresholdTimerJob"
     * @const
     */
    "QuotaThresholdTimerJob": "QuotaThresholdTimerJob",
    /**
     * value: "SyncUserForDynamicRule"
     * @const
     */
    "SyncUserForDynamicRule": "SyncUserForDynamicRule",
    /**
     * value: "SyncGroup"
     * @const
     */
    "SyncGroup": "SyncGroup",
    /**
     * value: "AutoImportSiteCustomService"
     * @const
     */
    "AutoImportSiteCustomService": "AutoImportSiteCustomService",
    /**
     * value: "AutoImportSite"
     * @const
     */
    "AutoImportSite": "AutoImportSite",
    /**
     * value: "AutoImportGroup"
     * @const
     */
    "AutoImportGroup": "AutoImportGroup",
    /**
     * value: "TemporaryPermissionStart"
     * @const
     */
    "TemporaryPermissionStart": "TemporaryPermissionStart",
    /**
     * value: "TemporaryPermissionEnd"
     * @const
     */
    "TemporaryPermissionEnd": "TemporaryPermissionEnd",
    /**
     * value: "TemporaryPermissionExpiringNotificationJob"
     * @const
     */
    "TemporaryPermissionExpiringNotificationJob": "TemporaryPermissionExpiringNotificationJob",
    /**
     * value: "RenewTeams"
     * @const
     */
    "RenewTeams": "RenewTeams",
    /**
     * value: "AutoExportReport"
     * @const
     */
    "AutoExportReport": "AutoExportReport",
    /**
     * value: "SyncUserInformation"
     * @const
     */
    "SyncUserInformation": "SyncUserInformation",
    /**
     * value: "SyncUpsMetadata"
     * @const
     */
    "SyncUpsMetadata": "SyncUpsMetadata"  };

  /**
   * Returns a <code>ServiceTypeNullable</code> enum value from a Javascript object name.
   * @param {Object} data The plain JavaScript object containing the name of the enum value.
   * @return {module:model/ServiceTypeNullable} The enum <code>ServiceTypeNullable</code> value.
   */
  exports.constructFromObject = function(object) {
    return object;
  }

  return exports;
}));


