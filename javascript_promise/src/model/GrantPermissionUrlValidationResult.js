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
    define(['ApiClient', 'model/ExternalSharingOptions', 'model/GrantPermissionGroup', 'model/GrantPermissionSPObject', 'model/IntModel'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ExternalSharingOptions'), require('./GrantPermissionGroup'), require('./GrantPermissionSPObject'), require('./IntModel'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.GrantPermissionUrlValidationResult = factory(root.CgClient.ApiClient, root.CgClient.ExternalSharingOptions, root.CgClient.GrantPermissionGroup, root.CgClient.GrantPermissionSPObject, root.CgClient.IntModel);
  }
}(this, function(ApiClient, ExternalSharingOptions, GrantPermissionGroup, GrantPermissionSPObject, IntModel) {
  'use strict';



  /**
   * The GrantPermissionUrlValidationResult model module.
   * @module model/GrantPermissionUrlValidationResult
   * @version 1.0
   */

  /**
   * Constructs a new <code>GrantPermissionUrlValidationResult</code>.
   * @alias module:model/GrantPermissionUrlValidationResult
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>GrantPermissionUrlValidationResult</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GrantPermissionUrlValidationResult} obj Optional instance to populate.
   * @return {module:model/GrantPermissionUrlValidationResult} The populated <code>GrantPermissionUrlValidationResult</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('externalSharingOptions')) {
        obj['externalSharingOptions'] = ExternalSharingOptions.constructFromObject(data['externalSharingOptions']);
      }
      if (data.hasOwnProperty('enableShareAnnoymousLink')) {
        obj['enableShareAnnoymousLink'] = ApiClient.convertToType(data['enableShareAnnoymousLink'], 'Boolean');
      }
      if (data.hasOwnProperty('object')) {
        obj['object'] = GrantPermissionSPObject.constructFromObject(data['object']);
      }
      if (data.hasOwnProperty('spPermissionLevels')) {
        obj['spPermissionLevels'] = ApiClient.convertToType(data['spPermissionLevels'], [IntModel]);
      }
      if (data.hasOwnProperty('spGroups')) {
        obj['spGroups'] = ApiClient.convertToType(data['spGroups'], [GrantPermissionGroup]);
      }
      if (data.hasOwnProperty('allowBreakPermissionInheritance')) {
        obj['allowBreakPermissionInheritance'] = ApiClient.convertToType(data['allowBreakPermissionInheritance'], 'Boolean');
      }
      if (data.hasOwnProperty('isValid')) {
        obj['isValid'] = ApiClient.convertToType(data['isValid'], 'Boolean');
      }
      if (data.hasOwnProperty('errorMessage')) {
        obj['errorMessage'] = ApiClient.convertToType(data['errorMessage'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/ExternalSharingOptions} externalSharingOptions
   */
  exports.prototype['externalSharingOptions'] = undefined;
  /**
   * @member {Boolean} enableShareAnnoymousLink
   */
  exports.prototype['enableShareAnnoymousLink'] = undefined;
  /**
   * @member {module:model/GrantPermissionSPObject} object
   */
  exports.prototype['object'] = undefined;
  /**
   * @member {Array.<module:model/IntModel>} spPermissionLevels
   */
  exports.prototype['spPermissionLevels'] = undefined;
  /**
   * @member {Array.<module:model/GrantPermissionGroup>} spGroups
   */
  exports.prototype['spGroups'] = undefined;
  /**
   * @member {Boolean} allowBreakPermissionInheritance
   */
  exports.prototype['allowBreakPermissionInheritance'] = undefined;
  /**
   * @member {Boolean} isValid
   */
  exports.prototype['isValid'] = undefined;
  /**
   * @member {String} errorMessage
   */
  exports.prototype['errorMessage'] = undefined;



  return exports;
}));


