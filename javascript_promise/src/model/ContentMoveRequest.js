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
    define(['ApiClient', 'model/ContentMoveCommonSetting', 'model/ContentMoveMethod', 'model/ContentMoveSPObjectMapping', 'model/CopyMoveSetting', 'model/RequestMetadata', 'model/RequestStatusNullable', 'model/ServiceTypeNullable'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ContentMoveCommonSetting'), require('./ContentMoveMethod'), require('./ContentMoveSPObjectMapping'), require('./CopyMoveSetting'), require('./RequestMetadata'), require('./RequestStatusNullable'), require('./ServiceTypeNullable'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ContentMoveRequest = factory(root.CgClient.ApiClient, root.CgClient.ContentMoveCommonSetting, root.CgClient.ContentMoveMethod, root.CgClient.ContentMoveSPObjectMapping, root.CgClient.CopyMoveSetting, root.CgClient.RequestMetadata, root.CgClient.RequestStatusNullable, root.CgClient.ServiceTypeNullable);
  }
}(this, function(ApiClient, ContentMoveCommonSetting, ContentMoveMethod, ContentMoveSPObjectMapping, CopyMoveSetting, RequestMetadata, RequestStatusNullable, ServiceTypeNullable) {
  'use strict';



  /**
   * The ContentMoveRequest model module.
   * @module model/ContentMoveRequest
   * @version 1.0
   */

  /**
   * Constructs a new <code>ContentMoveRequest</code>.
   * @alias module:model/ContentMoveRequest
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ContentMoveRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContentMoveRequest} obj Optional instance to populate.
   * @return {module:model/ContentMoveRequest} The populated <code>ContentMoveRequest</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('method')) {
        obj['method'] = ContentMoveMethod.constructFromObject(data['method']);
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
      if (data.hasOwnProperty('objectMappings')) {
        obj['objectMappings'] = ApiClient.convertToType(data['objectMappings'], [ContentMoveSPObjectMapping]);
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('serviceId')) {
        obj['serviceId'] = ApiClient.convertToType(data['serviceId'], 'String');
      }
      if (data.hasOwnProperty('department')) {
        obj['department'] = ApiClient.convertToType(data['department'], 'String');
      }
      if (data.hasOwnProperty('summary')) {
        obj['summary'] = ApiClient.convertToType(data['summary'], 'String');
      }
      if (data.hasOwnProperty('notesToApprovers')) {
        obj['notesToApprovers'] = ApiClient.convertToType(data['notesToApprovers'], 'String');
      }
      if (data.hasOwnProperty('questionnaireId')) {
        obj['questionnaireId'] = ApiClient.convertToType(data['questionnaireId'], 'String');
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [RequestMetadata]);
      }
      if (data.hasOwnProperty('ticketNumber')) {
        obj['ticketNumber'] = ApiClient.convertToType(data['ticketNumber'], 'Number');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], ServiceTypeNullable);
      }
      if (data.hasOwnProperty('typeDescription')) {
        obj['typeDescription'] = ApiClient.convertToType(data['typeDescription'], 'String');
      }
      if (data.hasOwnProperty('requester')) {
        obj['requester'] = ApiClient.convertToType(data['requester'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], RequestStatusNullable);
      }
      if (data.hasOwnProperty('progressStatus')) {
        obj['progressStatus'] = ApiClient.convertToType(data['progressStatus'], 'Number');
      }
      if (data.hasOwnProperty('progressStatusDescription')) {
        obj['progressStatusDescription'] = ApiClient.convertToType(data['progressStatusDescription'], 'String');
      }
      if (data.hasOwnProperty('submittedTime')) {
        obj['submittedTime'] = ApiClient.convertToType(data['submittedTime'], 'Date');
      }
      if (data.hasOwnProperty('lastUpdated')) {
        obj['lastUpdated'] = ApiClient.convertToType(data['lastUpdated'], 'Date');
      }
      if (data.hasOwnProperty('createdTime')) {
        obj['createdTime'] = ApiClient.convertToType(data['createdTime'], 'Date');
      }
      if (data.hasOwnProperty('assignTo')) {
        obj['assignTo'] = ApiClient.convertToType(data['assignTo'], 'String');
      }
      if (data.hasOwnProperty('fullPath')) {
        obj['fullPath'] = ApiClient.convertToType(data['fullPath'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/ContentMoveMethod} method
   */
  exports.prototype['method'] = undefined;
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
   * @member {Array.<module:model/ContentMoveSPObjectMapping>} objectMappings
   */
  exports.prototype['objectMappings'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} serviceId
   */
  exports.prototype['serviceId'] = undefined;
  /**
   * @member {String} department
   */
  exports.prototype['department'] = undefined;
  /**
   * @member {String} summary
   */
  exports.prototype['summary'] = undefined;
  /**
   * @member {String} notesToApprovers
   */
  exports.prototype['notesToApprovers'] = undefined;
  /**
   * @member {String} questionnaireId
   */
  exports.prototype['questionnaireId'] = undefined;
  /**
   * @member {Array.<module:model/RequestMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;
  /**
   * @member {Number} ticketNumber
   */
  exports.prototype['ticketNumber'] = undefined;
  /**
   * @member {module:model/ServiceTypeNullable} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} typeDescription
   */
  exports.prototype['typeDescription'] = undefined;
  /**
   * @member {String} requester
   */
  exports.prototype['requester'] = undefined;
  /**
   * @member {module:model/RequestStatusNullable} status
   */
  exports.prototype['status'] = undefined;
  /**
   * @member {Number} progressStatus
   */
  exports.prototype['progressStatus'] = undefined;
  /**
   * @member {String} progressStatusDescription
   */
  exports.prototype['progressStatusDescription'] = undefined;
  /**
   * @member {Date} submittedTime
   */
  exports.prototype['submittedTime'] = undefined;
  /**
   * @member {Date} lastUpdated
   */
  exports.prototype['lastUpdated'] = undefined;
  /**
   * @member {Date} createdTime
   */
  exports.prototype['createdTime'] = undefined;
  /**
   * @member {String} assignTo
   */
  exports.prototype['assignTo'] = undefined;
  /**
   * @member {String} fullPath
   */
  exports.prototype['fullPath'] = undefined;



  return exports;
}));


