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
    root.CgClient.PolicyDaoSetting = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';



  /**
   * The PolicyDaoSetting model module.
   * @module model/PolicyDaoSetting
   * @version 1.0
   */

  /**
   * Constructs a new <code>PolicyDaoSetting</code>.
   * @alias module:model/PolicyDaoSetting
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>PolicyDaoSetting</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PolicyDaoSetting} obj Optional instance to populate.
   * @return {module:model/PolicyDaoSetting} The populated <code>PolicyDaoSetting</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('isPolicyEnforcerEnabled')) {
        obj['isPolicyEnforcerEnabled'] = ApiClient.convertToType(data['isPolicyEnforcerEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('policyEnforcerProfile')) {
        obj['policyEnforcerProfile'] = ApiClient.convertToType(data['policyEnforcerProfile'], 'String');
      }
      if (data.hasOwnProperty('isDpmEnabled')) {
        obj['isDpmEnabled'] = ApiClient.convertToType(data['isDpmEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('dpmPlan')) {
        obj['dpmPlan'] = ApiClient.convertToType(data['dpmPlan'], 'String');
      }
      if (data.hasOwnProperty('isBackupEnabled')) {
        obj['isBackupEnabled'] = ApiClient.convertToType(data['isBackupEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('isAuditingEnabled')) {
        obj['isAuditingEnabled'] = ApiClient.convertToType(data['isAuditingEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('isArchiverEnabled')) {
        obj['isArchiverEnabled'] = ApiClient.convertToType(data['isArchiverEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('archiverProfile')) {
        obj['archiverProfile'] = ApiClient.convertToType(data['archiverProfile'], 'String');
      }
      if (data.hasOwnProperty('archiverProcessId')) {
        obj['archiverProcessId'] = ApiClient.convertToType(data['archiverProcessId'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {Boolean} isPolicyEnforcerEnabled
   */
  exports.prototype['isPolicyEnforcerEnabled'] = undefined;
  /**
   * @member {String} policyEnforcerProfile
   */
  exports.prototype['policyEnforcerProfile'] = undefined;
  /**
   * @member {Boolean} isDpmEnabled
   */
  exports.prototype['isDpmEnabled'] = undefined;
  /**
   * @member {String} dpmPlan
   */
  exports.prototype['dpmPlan'] = undefined;
  /**
   * @member {Boolean} isBackupEnabled
   */
  exports.prototype['isBackupEnabled'] = undefined;
  /**
   * @member {Boolean} isAuditingEnabled
   */
  exports.prototype['isAuditingEnabled'] = undefined;
  /**
   * @member {Boolean} isArchiverEnabled
   */
  exports.prototype['isArchiverEnabled'] = undefined;
  /**
   * @member {String} archiverProfile
   */
  exports.prototype['archiverProfile'] = undefined;
  /**
   * @member {String} archiverProcessId
   */
  exports.prototype['archiverProcessId'] = undefined;



  return exports;
}));


