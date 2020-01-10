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
    define(['ApiClient', 'model/ApiUser', 'model/AssignBy', 'model/CommonStatus', 'model/ContentMoveAction', 'model/ContentMoveCommonSetting', 'model/ContentMoveMethod', 'model/CopyMoveSetting', 'model/CopyMoveSettingAssignBy', 'model/CustomActionSettings', 'model/CustomMetadata', 'model/ServiceType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ApiUser'), require('./AssignBy'), require('./CommonStatus'), require('./ContentMoveAction'), require('./ContentMoveCommonSetting'), require('./ContentMoveMethod'), require('./CopyMoveSetting'), require('./CopyMoveSettingAssignBy'), require('./CustomActionSettings'), require('./CustomMetadata'), require('./ServiceType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ContentMoveService = factory(root.CgClient.ApiClient, root.CgClient.ApiUser, root.CgClient.AssignBy, root.CgClient.CommonStatus, root.CgClient.ContentMoveAction, root.CgClient.ContentMoveCommonSetting, root.CgClient.ContentMoveMethod, root.CgClient.CopyMoveSetting, root.CgClient.CopyMoveSettingAssignBy, root.CgClient.CustomActionSettings, root.CgClient.CustomMetadata, root.CgClient.ServiceType);
  }
}(this, function(ApiClient, ApiUser, AssignBy, CommonStatus, ContentMoveAction, ContentMoveCommonSetting, ContentMoveMethod, CopyMoveSetting, CopyMoveSettingAssignBy, CustomActionSettings, CustomMetadata, ServiceType) {
  'use strict';



  /**
   * The ContentMoveService model module.
   * @module model/ContentMoveService
   * @version 1.0
   */

  /**
   * Constructs a new <code>ContentMoveService</code>.
   * @alias module:model/ContentMoveService
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ContentMoveService</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContentMoveService} obj Optional instance to populate.
   * @return {module:model/ContentMoveService} The populated <code>ContentMoveService</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('method')) {
        obj['method'] = ContentMoveMethod.constructFromObject(data['method']);
      }
      if (data.hasOwnProperty('action')) {
        obj['action'] = ContentMoveAction.constructFromObject(data['action']);
      }
      if (data.hasOwnProperty('copySettings')) {
        obj['copySettings'] = CopyMoveSetting.constructFromObject(data['copySettings']);
      }
      if (data.hasOwnProperty('moveSettings')) {
        obj['moveSettings'] = CopyMoveSetting.constructFromObject(data['moveSettings']);
      }
      if (data.hasOwnProperty('commonSettings')) {
        obj['commonSettings'] = ContentMoveCommonSetting.constructFromObject(data['commonSettings']);
      }
      if (data.hasOwnProperty('conflictResolutionAssignBy')) {
        obj['conflictResolutionAssignBy'] = AssignBy.constructFromObject(data['conflictResolutionAssignBy']);
      }
      if (data.hasOwnProperty('deleteTypeAssignBy')) {
        obj['deleteTypeAssignBy'] = AssignBy.constructFromObject(data['deleteTypeAssignBy']);
      }
      if (data.hasOwnProperty('deleteCheckedFilesAssignBy')) {
        obj['deleteCheckedFilesAssignBy'] = AssignBy.constructFromObject(data['deleteCheckedFilesAssignBy']);
      }
      if (data.hasOwnProperty('filterPolicyAssignBy')) {
        obj['filterPolicyAssignBy'] = AssignBy.constructFromObject(data['filterPolicyAssignBy']);
      }
      if (data.hasOwnProperty('methodAssignBy')) {
        obj['methodAssignBy'] = AssignBy.constructFromObject(data['methodAssignBy']);
      }
      if (data.hasOwnProperty('actionAssignBy')) {
        obj['actionAssignBy'] = AssignBy.constructFromObject(data['actionAssignBy']);
      }
      if (data.hasOwnProperty('copySettingAssignBy')) {
        obj['copySettingAssignBy'] = CopyMoveSettingAssignBy.constructFromObject(data['copySettingAssignBy']);
      }
      if (data.hasOwnProperty('moveSettingAssignBy')) {
        obj['moveSettingAssignBy'] = CopyMoveSettingAssignBy.constructFromObject(data['moveSettingAssignBy']);
      }
      if (data.hasOwnProperty('versionsAssignBy')) {
        obj['versionsAssignBy'] = AssignBy.constructFromObject(data['versionsAssignBy']);
      }
      if (data.hasOwnProperty('workflowAssignBy')) {
        obj['workflowAssignBy'] = AssignBy.constructFromObject(data['workflowAssignBy']);
      }
      if (data.hasOwnProperty('informationRightsManagementAssignBy')) {
        obj['informationRightsManagementAssignBy'] = AssignBy.constructFromObject(data['informationRightsManagementAssignBy']);
      }
      if (data.hasOwnProperty('nullColumnValueAssignBy')) {
        obj['nullColumnValueAssignBy'] = AssignBy.constructFromObject(data['nullColumnValueAssignBy']);
      }
      if (data.hasOwnProperty('modifiedByAndModifiedTimeAssignBy')) {
        obj['modifiedByAndModifiedTimeAssignBy'] = AssignBy.constructFromObject(data['modifiedByAndModifiedTimeAssignBy']);
      }
      if (data.hasOwnProperty('mappingSettingAssignBy')) {
        obj['mappingSettingAssignBy'] = AssignBy.constructFromObject(data['mappingSettingAssignBy']);
      }
      if (data.hasOwnProperty('backupEnvironmentAssignBy')) {
        obj['backupEnvironmentAssignBy'] = AssignBy.constructFromObject(data['backupEnvironmentAssignBy']);
      }
      if (data.hasOwnProperty('departmentAssignBy')) {
        obj['departmentAssignBy'] = AssignBy.constructFromObject(data['departmentAssignBy']);
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [CustomMetadata]);
      }
      if (data.hasOwnProperty('hideRequestSummary')) {
        obj['hideRequestSummary'] = ApiClient.convertToType(data['hideRequestSummary'], 'Boolean');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ServiceType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('department')) {
        obj['department'] = ApiClient.convertToType(data['department'], 'String');
      }
      if (data.hasOwnProperty('loadDepartmentFromUps')) {
        obj['loadDepartmentFromUps'] = ApiClient.convertToType(data['loadDepartmentFromUps'], 'Boolean');
      }
      if (data.hasOwnProperty('departments')) {
        obj['departments'] = ApiClient.convertToType(data['departments'], ['String']);
      }
      if (data.hasOwnProperty('serviceContact')) {
        obj['serviceContact'] = ApiUser.constructFromObject(data['serviceContact']);
      }
      if (data.hasOwnProperty('serviceAdminContact')) {
        obj['serviceAdminContact'] = ApiUser.constructFromObject(data['serviceAdminContact']);
      }
      if (data.hasOwnProperty('approversContainManagerRole')) {
        obj['approversContainManagerRole'] = ApiClient.convertToType(data['approversContainManagerRole'], 'Boolean');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = CommonStatus.constructFromObject(data['status']);
      }
      if (data.hasOwnProperty('showServiceInCatalog')) {
        obj['showServiceInCatalog'] = ApiClient.convertToType(data['showServiceInCatalog'], 'Boolean');
      }
      if (data.hasOwnProperty('customActions')) {
        obj['customActions'] = CustomActionSettings.constructFromObject(data['customActions']);
      }
      if (data.hasOwnProperty('approvalProcessId')) {
        obj['approvalProcessId'] = ApiClient.convertToType(data['approvalProcessId'], 'String');
      }
      if (data.hasOwnProperty('languageId')) {
        obj['languageId'] = ApiClient.convertToType(data['languageId'], 'Number');
      }
      if (data.hasOwnProperty('categoryId')) {
        obj['categoryId'] = ApiClient.convertToType(data['categoryId'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/ContentMoveMethod} method
   */
  exports.prototype['method'] = undefined;
  /**
   * @member {module:model/ContentMoveAction} action
   */
  exports.prototype['action'] = undefined;
  /**
   * @member {module:model/CopyMoveSetting} copySettings
   */
  exports.prototype['copySettings'] = undefined;
  /**
   * @member {module:model/CopyMoveSetting} moveSettings
   */
  exports.prototype['moveSettings'] = undefined;
  /**
   * @member {module:model/ContentMoveCommonSetting} commonSettings
   */
  exports.prototype['commonSettings'] = undefined;
  /**
   * @member {module:model/AssignBy} conflictResolutionAssignBy
   */
  exports.prototype['conflictResolutionAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} deleteTypeAssignBy
   */
  exports.prototype['deleteTypeAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} deleteCheckedFilesAssignBy
   */
  exports.prototype['deleteCheckedFilesAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} filterPolicyAssignBy
   */
  exports.prototype['filterPolicyAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} methodAssignBy
   */
  exports.prototype['methodAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} actionAssignBy
   */
  exports.prototype['actionAssignBy'] = undefined;
  /**
   * @member {module:model/CopyMoveSettingAssignBy} copySettingAssignBy
   */
  exports.prototype['copySettingAssignBy'] = undefined;
  /**
   * @member {module:model/CopyMoveSettingAssignBy} moveSettingAssignBy
   */
  exports.prototype['moveSettingAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} versionsAssignBy
   */
  exports.prototype['versionsAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} workflowAssignBy
   */
  exports.prototype['workflowAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} informationRightsManagementAssignBy
   */
  exports.prototype['informationRightsManagementAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} nullColumnValueAssignBy
   */
  exports.prototype['nullColumnValueAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} modifiedByAndModifiedTimeAssignBy
   */
  exports.prototype['modifiedByAndModifiedTimeAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} mappingSettingAssignBy
   */
  exports.prototype['mappingSettingAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} backupEnvironmentAssignBy
   */
  exports.prototype['backupEnvironmentAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} departmentAssignBy
   */
  exports.prototype['departmentAssignBy'] = undefined;
  /**
   * @member {Array.<module:model/CustomMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;
  /**
   * @member {Boolean} hideRequestSummary
   */
  exports.prototype['hideRequestSummary'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * @member {module:model/ServiceType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} department
   */
  exports.prototype['department'] = undefined;
  /**
   * @member {Boolean} loadDepartmentFromUps
   */
  exports.prototype['loadDepartmentFromUps'] = undefined;
  /**
   * @member {Array.<String>} departments
   */
  exports.prototype['departments'] = undefined;
  /**
   * @member {module:model/ApiUser} serviceContact
   */
  exports.prototype['serviceContact'] = undefined;
  /**
   * @member {module:model/ApiUser} serviceAdminContact
   */
  exports.prototype['serviceAdminContact'] = undefined;
  /**
   * @member {Boolean} approversContainManagerRole
   */
  exports.prototype['approversContainManagerRole'] = undefined;
  /**
   * @member {module:model/CommonStatus} status
   */
  exports.prototype['status'] = undefined;
  /**
   * @member {Boolean} showServiceInCatalog
   */
  exports.prototype['showServiceInCatalog'] = undefined;
  /**
   * @member {module:model/CustomActionSettings} customActions
   */
  exports.prototype['customActions'] = undefined;
  /**
   * @member {String} approvalProcessId
   */
  exports.prototype['approvalProcessId'] = undefined;
  /**
   * @member {Number} languageId
   */
  exports.prototype['languageId'] = undefined;
  /**
   * @member {String} categoryId
   */
  exports.prototype['categoryId'] = undefined;



  return exports;
}));


