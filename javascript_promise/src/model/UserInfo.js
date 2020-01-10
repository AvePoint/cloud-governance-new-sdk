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
    define(['ApiClient', 'model/AuthenticationType', 'model/ExternalUserType', 'model/InviteType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./AuthenticationType'), require('./ExternalUserType'), require('./InviteType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.UserInfo = factory(root.CgClient.ApiClient, root.CgClient.AuthenticationType, root.CgClient.ExternalUserType, root.CgClient.InviteType);
  }
}(this, function(ApiClient, AuthenticationType, ExternalUserType, InviteType) {
  'use strict';



  /**
   * The UserInfo model module.
   * @module model/UserInfo
   * @version 1.0
   */

  /**
   * Constructs a new <code>UserInfo</code>.
   * @alias module:model/UserInfo
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>UserInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/UserInfo} obj Optional instance to populate.
   * @return {module:model/UserInfo} The populated <code>UserInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('identityName')) {
        obj['identityName'] = ApiClient.convertToType(data['identityName'], 'String');
      }
      if (data.hasOwnProperty('userDisplayName')) {
        obj['userDisplayName'] = ApiClient.convertToType(data['userDisplayName'], 'String');
      }
      if (data.hasOwnProperty('domainGroup')) {
        obj['domainGroup'] = ApiClient.convertToType(data['domainGroup'], 'Boolean');
      }
      if (data.hasOwnProperty('department')) {
        obj['department'] = ApiClient.convertToType(data['department'], 'String');
      }
      if (data.hasOwnProperty('mobilePhone')) {
        obj['mobilePhone'] = ApiClient.convertToType(data['mobilePhone'], 'String');
      }
      if (data.hasOwnProperty('manager')) {
        obj['manager'] = ApiClient.convertToType(data['manager'], 'String');
      }
      if (data.hasOwnProperty('permission')) {
        obj['permission'] = ApiClient.convertToType(data['permission'], 'String');
      }
      if (data.hasOwnProperty('isDeleted')) {
        obj['isDeleted'] = ApiClient.convertToType(data['isDeleted'], 'Boolean');
      }
      if (data.hasOwnProperty('securityToken')) {
        obj['securityToken'] = ApiClient.convertToType(data['securityToken'], 'String');
      }
      if (data.hasOwnProperty('userType')) {
        obj['userType'] = ApiClient.convertToType(data['userType'], 'Number');
      }
      if (data.hasOwnProperty('legalPerson')) {
        obj['legalPerson'] = ApiClient.convertToType(data['legalPerson'], 'Boolean');
      }
      if (data.hasOwnProperty('authenticationType')) {
        obj['authenticationType'] = AuthenticationType.constructFromObject(data['authenticationType']);
      }
      if (data.hasOwnProperty('adminCenterUrl')) {
        obj['adminCenterUrl'] = ApiClient.convertToType(data['adminCenterUrl'], 'String');
      }
      if (data.hasOwnProperty('inviteType')) {
        obj['inviteType'] = InviteType.constructFromObject(data['inviteType']);
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('isRegisteredAosGroup')) {
        obj['isRegisteredAosGroup'] = ApiClient.convertToType(data['isRegisteredAosGroup'], 'Boolean');
      }
      if (data.hasOwnProperty('isExternalUser')) {
        obj['isExternalUser'] = ExternalUserType.constructFromObject(data['isExternalUser']);
      }
      if (data.hasOwnProperty('isAPIExceptional')) {
        obj['isAPIExceptional'] = ApiClient.convertToType(data['isAPIExceptional'], 'Boolean');
      }
      if (data.hasOwnProperty('tenantId')) {
        obj['tenantId'] = ApiClient.convertToType(data['tenantId'], 'String');
      }
      if (data.hasOwnProperty('objectId')) {
        obj['objectId'] = ApiClient.convertToType(data['objectId'], 'String');
      }
      if (data.hasOwnProperty('version')) {
        obj['version'] = ApiClient.convertToType(data['version'], 'Number');
      }
      if (data.hasOwnProperty('jobTitle')) {
        obj['jobTitle'] = ApiClient.convertToType(data['jobTitle'], 'String');
      }
      if (data.hasOwnProperty('usageLocation')) {
        obj['usageLocation'] = ApiClient.convertToType(data['usageLocation'], 'String');
      }
      if (data.hasOwnProperty('physicalDeliveryOfficeName')) {
        obj['physicalDeliveryOfficeName'] = ApiClient.convertToType(data['physicalDeliveryOfficeName'], 'String');
      }
      if (data.hasOwnProperty('isOtherTenantUser')) {
        obj['isOtherTenantUser'] = ApiClient.convertToType(data['isOtherTenantUser'], 'Boolean');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Number');
      }
      if (data.hasOwnProperty('displayName')) {
        obj['displayName'] = ApiClient.convertToType(data['displayName'], 'String');
      }
      if (data.hasOwnProperty('title')) {
        obj['title'] = ApiClient.convertToType(data['title'], 'String');
      }
      if (data.hasOwnProperty('email')) {
        obj['email'] = ApiClient.convertToType(data['email'], 'String');
      }
      if (data.hasOwnProperty('isValid')) {
        obj['isValid'] = ApiClient.convertToType(data['isValid'], 'Boolean');
      }
      if (data.hasOwnProperty('existInAOS')) {
        obj['existInAOS'] = ApiClient.convertToType(data['existInAOS'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {String} identityName
   */
  exports.prototype['identityName'] = undefined;
  /**
   * @member {String} userDisplayName
   */
  exports.prototype['userDisplayName'] = undefined;
  /**
   * @member {Boolean} domainGroup
   */
  exports.prototype['domainGroup'] = undefined;
  /**
   * @member {String} department
   */
  exports.prototype['department'] = undefined;
  /**
   * @member {String} mobilePhone
   */
  exports.prototype['mobilePhone'] = undefined;
  /**
   * @member {String} manager
   */
  exports.prototype['manager'] = undefined;
  /**
   * @member {String} permission
   */
  exports.prototype['permission'] = undefined;
  /**
   * @member {Boolean} isDeleted
   */
  exports.prototype['isDeleted'] = undefined;
  /**
   * @member {String} securityToken
   */
  exports.prototype['securityToken'] = undefined;
  /**
   * @member {Number} userType
   */
  exports.prototype['userType'] = undefined;
  /**
   * @member {Boolean} legalPerson
   */
  exports.prototype['legalPerson'] = undefined;
  /**
   * @member {module:model/AuthenticationType} authenticationType
   */
  exports.prototype['authenticationType'] = undefined;
  /**
   * @member {String} adminCenterUrl
   */
  exports.prototype['adminCenterUrl'] = undefined;
  /**
   * @member {module:model/InviteType} inviteType
   */
  exports.prototype['inviteType'] = undefined;
  /**
   * @member {String} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {Boolean} isRegisteredAosGroup
   */
  exports.prototype['isRegisteredAosGroup'] = undefined;
  /**
   * @member {module:model/ExternalUserType} isExternalUser
   */
  exports.prototype['isExternalUser'] = undefined;
  /**
   * @member {Boolean} isAPIExceptional
   */
  exports.prototype['isAPIExceptional'] = undefined;
  /**
   * @member {String} tenantId
   */
  exports.prototype['tenantId'] = undefined;
  /**
   * @member {String} objectId
   */
  exports.prototype['objectId'] = undefined;
  /**
   * @member {Number} version
   */
  exports.prototype['version'] = undefined;
  /**
   * @member {String} jobTitle
   */
  exports.prototype['jobTitle'] = undefined;
  /**
   * @member {String} usageLocation
   */
  exports.prototype['usageLocation'] = undefined;
  /**
   * @member {String} physicalDeliveryOfficeName
   */
  exports.prototype['physicalDeliveryOfficeName'] = undefined;
  /**
   * @member {Boolean} isOtherTenantUser
   */
  exports.prototype['isOtherTenantUser'] = undefined;
  /**
   * @member {Number} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} displayName
   */
  exports.prototype['displayName'] = undefined;
  /**
   * @member {String} title
   */
  exports.prototype['title'] = undefined;
  /**
   * @member {String} email
   */
  exports.prototype['email'] = undefined;
  /**
   * @member {Boolean} isValid
   */
  exports.prototype['isValid'] = undefined;
  /**
   * @member {Boolean} existInAOS
   */
  exports.prototype['existInAOS'] = undefined;



  return exports;
}));


