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
    define(['ApiClient', 'model/CreateListSPObject', 'model/ListPermissionSettings', 'model/ListType', 'model/ListVersionSettings', 'model/RequestMetadata', 'model/RequestStatusNullable', 'model/ServiceTypeNullable'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CreateListSPObject'), require('./ListPermissionSettings'), require('./ListType'), require('./ListVersionSettings'), require('./RequestMetadata'), require('./RequestStatusNullable'), require('./ServiceTypeNullable'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.CreateListRequest = factory(root.CgClient.ApiClient, root.CgClient.CreateListSPObject, root.CgClient.ListPermissionSettings, root.CgClient.ListType, root.CgClient.ListVersionSettings, root.CgClient.RequestMetadata, root.CgClient.RequestStatusNullable, root.CgClient.ServiceTypeNullable);
  }
}(this, function(ApiClient, CreateListSPObject, ListPermissionSettings, ListType, ListVersionSettings, RequestMetadata, RequestStatusNullable, ServiceTypeNullable) {
  'use strict';



  /**
   * The CreateListRequest model module.
   * @module model/CreateListRequest
   * @version 1.0
   */

  /**
   * Constructs a new <code>CreateListRequest</code>.
   * @alias module:model/CreateListRequest
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>CreateListRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CreateListRequest} obj Optional instance to populate.
   * @return {module:model/CreateListRequest} The populated <code>CreateListRequest</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('listTitle')) {
        obj['listTitle'] = ApiClient.convertToType(data['listTitle'], 'String');
      }
      if (data.hasOwnProperty('listName')) {
        obj['listName'] = ApiClient.convertToType(data['listName'], 'String');
      }
      if (data.hasOwnProperty('listDescription')) {
        obj['listDescription'] = ApiClient.convertToType(data['listDescription'], 'String');
      }
      if (data.hasOwnProperty('parentObject')) {
        obj['parentObject'] = CreateListSPObject.constructFromObject(data['parentObject']);
      }
      if (data.hasOwnProperty('listTemplate')) {
        obj['listTemplate'] = ApiClient.convertToType(data['listTemplate'], 'String');
      }
      if (data.hasOwnProperty('enableNavigation')) {
        obj['enableNavigation'] = ApiClient.convertToType(data['enableNavigation'], 'Boolean');
      }
      if (data.hasOwnProperty('listType')) {
        obj['listType'] = ListType.constructFromObject(data['listType']);
      }
      if (data.hasOwnProperty('versionSettings')) {
        obj['versionSettings'] = ListVersionSettings.constructFromObject(data['versionSettings']);
      }
      if (data.hasOwnProperty('permissionSettings')) {
        obj['permissionSettings'] = ListPermissionSettings.constructFromObject(data['permissionSettings']);
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
   * @member {String} listTitle
   */
  exports.prototype['listTitle'] = undefined;
  /**
   * @member {String} listName
   */
  exports.prototype['listName'] = undefined;
  /**
   * @member {String} listDescription
   */
  exports.prototype['listDescription'] = undefined;
  /**
   * @member {module:model/CreateListSPObject} parentObject
   */
  exports.prototype['parentObject'] = undefined;
  /**
   * @member {String} listTemplate
   */
  exports.prototype['listTemplate'] = undefined;
  /**
   * @member {Boolean} enableNavigation
   */
  exports.prototype['enableNavigation'] = undefined;
  /**
   * @member {module:model/ListType} listType
   */
  exports.prototype['listType'] = undefined;
  /**
   * @member {module:model/ListVersionSettings} versionSettings
   */
  exports.prototype['versionSettings'] = undefined;
  /**
   * @member {module:model/ListPermissionSettings} permissionSettings
   */
  exports.prototype['permissionSettings'] = undefined;
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


