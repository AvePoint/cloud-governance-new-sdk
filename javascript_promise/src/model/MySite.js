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
    define(['ApiClient', 'model/ApiUser', 'model/AutoImportPhase', 'model/MySiteType', 'model/RequestMetadata'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ApiUser'), require('./AutoImportPhase'), require('./MySiteType'), require('./RequestMetadata'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.MySite = factory(root.CgClient.ApiClient, root.CgClient.ApiUser, root.CgClient.AutoImportPhase, root.CgClient.MySiteType, root.CgClient.RequestMetadata);
  }
}(this, function(ApiClient, ApiUser, AutoImportPhase, MySiteType, RequestMetadata) {
  'use strict';



  /**
   * The MySite model module.
   * @module model/MySite
   * @version 1.0
   */

  /**
   * Constructs a new <code>MySite</code>.
   * @alias module:model/MySite
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>MySite</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MySite} obj Optional instance to populate.
   * @return {module:model/MySite} The populated <code>MySite</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('fullUrl')) {
        obj['fullUrl'] = ApiClient.convertToType(data['fullUrl'], 'String');
      }
      if (data.hasOwnProperty('title')) {
        obj['title'] = ApiClient.convertToType(data['title'], 'String');
      }
      if (data.hasOwnProperty('department')) {
        obj['department'] = ApiClient.convertToType(data['department'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('size')) {
        obj['size'] = ApiClient.convertToType(data['size'], 'Number');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = MySiteType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('mySiteType')) {
        obj['mySiteType'] = ApiClient.convertToType(data['mySiteType'], 'String');
      }
      if (data.hasOwnProperty('createdTime')) {
        obj['createdTime'] = ApiClient.convertToType(data['createdTime'], 'Date');
      }
      if (data.hasOwnProperty('storageUsed')) {
        obj['storageUsed'] = ApiClient.convertToType(data['storageUsed'], 'String');
      }
      if (data.hasOwnProperty('primaryAdministrator')) {
        obj['primaryAdministrator'] = ApiUser.constructFromObject(data['primaryAdministrator']);
      }
      if (data.hasOwnProperty('additionalAdministrator')) {
        obj['additionalAdministrator'] = ApiClient.convertToType(data['additionalAdministrator'], [ApiUser]);
      }
      if (data.hasOwnProperty('preferredDataLocation')) {
        obj['preferredDataLocation'] = ApiClient.convertToType(data['preferredDataLocation'], 'String');
      }
      if (data.hasOwnProperty('preferredDataLocationName')) {
        obj['preferredDataLocationName'] = ApiClient.convertToType(data['preferredDataLocationName'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('phase')) {
        obj['phase'] = AutoImportPhase.constructFromObject(data['phase']);
      }
      if (data.hasOwnProperty('phaseStartTime')) {
        obj['phaseStartTime'] = ApiClient.convertToType(data['phaseStartTime'], 'Date');
      }
      if (data.hasOwnProperty('phaseDescription')) {
        obj['phaseDescription'] = ApiClient.convertToType(data['phaseDescription'], 'String');
      }
      if (data.hasOwnProperty('autoImportProfileId')) {
        obj['autoImportProfileId'] = ApiClient.convertToType(data['autoImportProfileId'], 'String');
      }
      if (data.hasOwnProperty('autoImportProfileName')) {
        obj['autoImportProfileName'] = ApiClient.convertToType(data['autoImportProfileName'], 'String');
      }
      if (data.hasOwnProperty('policyName')) {
        obj['policyName'] = ApiClient.convertToType(data['policyName'], 'String');
      }
      if (data.hasOwnProperty('policyDescription')) {
        obj['policyDescription'] = ApiClient.convertToType(data['policyDescription'], 'String');
      }
      if (data.hasOwnProperty('isCurrentRenewer')) {
        obj['isCurrentRenewer'] = ApiClient.convertToType(data['isCurrentRenewer'], 'Boolean');
      }
      if (data.hasOwnProperty('phaseAssignees')) {
        obj['phaseAssignees'] = ApiClient.convertToType(data['phaseAssignees'], [ApiUser]);
      }
      if (data.hasOwnProperty('phaseDueDate')) {
        obj['phaseDueDate'] = ApiClient.convertToType(data['phaseDueDate'], 'Date');
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [RequestMetadata]);
      }
      if (data.hasOwnProperty('primaryContact')) {
        obj['primaryContact'] = ApiUser.constructFromObject(data['primaryContact']);
      }
      if (data.hasOwnProperty('secondaryContact')) {
        obj['secondaryContact'] = ApiUser.constructFromObject(data['secondaryContact']);
      }
    }
    return obj;
  }

  /**
   * @member {String} fullUrl
   */
  exports.prototype['fullUrl'] = undefined;
  /**
   * @member {String} title
   */
  exports.prototype['title'] = undefined;
  /**
   * @member {String} department
   */
  exports.prototype['department'] = undefined;
  /**
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * @member {Number} size
   */
  exports.prototype['size'] = undefined;
  /**
   * @member {module:model/MySiteType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} mySiteType
   */
  exports.prototype['mySiteType'] = undefined;
  /**
   * @member {Date} createdTime
   */
  exports.prototype['createdTime'] = undefined;
  /**
   * @member {String} storageUsed
   */
  exports.prototype['storageUsed'] = undefined;
  /**
   * @member {module:model/ApiUser} primaryAdministrator
   */
  exports.prototype['primaryAdministrator'] = undefined;
  /**
   * @member {Array.<module:model/ApiUser>} additionalAdministrator
   */
  exports.prototype['additionalAdministrator'] = undefined;
  /**
   * @member {String} preferredDataLocation
   */
  exports.prototype['preferredDataLocation'] = undefined;
  /**
   * @member {String} preferredDataLocationName
   */
  exports.prototype['preferredDataLocationName'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {module:model/AutoImportPhase} phase
   */
  exports.prototype['phase'] = undefined;
  /**
   * @member {Date} phaseStartTime
   */
  exports.prototype['phaseStartTime'] = undefined;
  /**
   * @member {String} phaseDescription
   */
  exports.prototype['phaseDescription'] = undefined;
  /**
   * @member {String} autoImportProfileId
   */
  exports.prototype['autoImportProfileId'] = undefined;
  /**
   * @member {String} autoImportProfileName
   */
  exports.prototype['autoImportProfileName'] = undefined;
  /**
   * @member {String} policyName
   */
  exports.prototype['policyName'] = undefined;
  /**
   * @member {String} policyDescription
   */
  exports.prototype['policyDescription'] = undefined;
  /**
   * @member {Boolean} isCurrentRenewer
   */
  exports.prototype['isCurrentRenewer'] = undefined;
  /**
   * @member {Array.<module:model/ApiUser>} phaseAssignees
   */
  exports.prototype['phaseAssignees'] = undefined;
  /**
   * @member {Date} phaseDueDate
   */
  exports.prototype['phaseDueDate'] = undefined;
  /**
   * @member {Array.<module:model/RequestMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;
  /**
   * @member {module:model/ApiUser} primaryContact
   */
  exports.prototype['primaryContact'] = undefined;
  /**
   * @member {module:model/ApiUser} secondaryContact
   */
  exports.prototype['secondaryContact'] = undefined;



  return exports;
}));


