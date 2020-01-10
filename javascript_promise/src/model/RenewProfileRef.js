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
    root.CgClient.RenewProfileRef = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';



  /**
   * The RenewProfileRef model module.
   * @module model/RenewProfileRef
   * @version 1.0
   */

  /**
   * Constructs a new <code>RenewProfileRef</code>.
   * @alias module:model/RenewProfileRef
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>RenewProfileRef</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RenewProfileRef} obj Optional instance to populate.
   * @return {module:model/RenewProfileRef} The populated <code>RenewProfileRef</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('isLastStage')) {
        obj['isLastStage'] = ApiClient.convertToType(data['isLastStage'], 'Boolean');
      }
      if (data.hasOwnProperty('confirmMessage')) {
        obj['confirmMessage'] = ApiClient.convertToType(data['confirmMessage'], 'String');
      }
      if (data.hasOwnProperty('objectTitle')) {
        obj['objectTitle'] = ApiClient.convertToType(data['objectTitle'], 'String');
      }
      if (data.hasOwnProperty('enableContactRenewal')) {
        obj['enableContactRenewal'] = ApiClient.convertToType(data['enableContactRenewal'], 'Boolean');
      }
      if (data.hasOwnProperty('enablePermissionRenewal')) {
        obj['enablePermissionRenewal'] = ApiClient.convertToType(data['enablePermissionRenewal'], 'Boolean');
      }
      if (data.hasOwnProperty('enableMetadataRenewal')) {
        obj['enableMetadataRenewal'] = ApiClient.convertToType(data['enableMetadataRenewal'], 'Boolean');
      }
      if (data.hasOwnProperty('enableReassign')) {
        obj['enableReassign'] = ApiClient.convertToType(data['enableReassign'], 'Boolean');
      }
      if (data.hasOwnProperty('enableDeletion')) {
        obj['enableDeletion'] = ApiClient.convertToType(data['enableDeletion'], 'Boolean');
      }
      if (data.hasOwnProperty('enableArchival')) {
        obj['enableArchival'] = ApiClient.convertToType(data['enableArchival'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {Boolean} isLastStage
   */
  exports.prototype['isLastStage'] = undefined;
  /**
   * @member {String} confirmMessage
   */
  exports.prototype['confirmMessage'] = undefined;
  /**
   * @member {String} objectTitle
   */
  exports.prototype['objectTitle'] = undefined;
  /**
   * @member {Boolean} enableContactRenewal
   */
  exports.prototype['enableContactRenewal'] = undefined;
  /**
   * @member {Boolean} enablePermissionRenewal
   */
  exports.prototype['enablePermissionRenewal'] = undefined;
  /**
   * @member {Boolean} enableMetadataRenewal
   */
  exports.prototype['enableMetadataRenewal'] = undefined;
  /**
   * @member {Boolean} enableReassign
   */
  exports.prototype['enableReassign'] = undefined;
  /**
   * @member {Boolean} enableDeletion
   */
  exports.prototype['enableDeletion'] = undefined;
  /**
   * @member {Boolean} enableArchival
   */
  exports.prototype['enableArchival'] = undefined;



  return exports;
}));


