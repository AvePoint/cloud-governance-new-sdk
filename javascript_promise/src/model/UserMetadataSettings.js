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
    define(['ApiClient', 'model/ApiUser'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ApiUser'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.UserMetadataSettings = factory(root.CgClient.ApiClient, root.CgClient.ApiUser);
  }
}(this, function(ApiClient, ApiUser) {
  'use strict';



  /**
   * The UserMetadataSettings model module.
   * @module model/UserMetadataSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>UserMetadataSettings</code>.
   * @alias module:model/UserMetadataSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>UserMetadataSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/UserMetadataSettings} obj Optional instance to populate.
   * @return {module:model/UserMetadataSettings} The populated <code>UserMetadataSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('value')) {
        obj['value'] = ApiClient.convertToType(data['value'], [ApiUser]);
      }
      if (data.hasOwnProperty('allowReferenceAsRoleInApprovalProcess')) {
        obj['allowReferenceAsRoleInApprovalProcess'] = ApiClient.convertToType(data['allowReferenceAsRoleInApprovalProcess'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {Array.<module:model/ApiUser>} value
   */
  exports.prototype['value'] = undefined;
  /**
   * @member {Boolean} allowReferenceAsRoleInApprovalProcess
   */
  exports.prototype['allowReferenceAsRoleInApprovalProcess'] = undefined;



  return exports;
}));


