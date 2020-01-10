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
    root.CgClient.ContactActionLockItem = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';



  /**
   * The ContactActionLockItem model module.
   * @module model/ContactActionLockItem
   * @version 1.0
   */

  /**
   * Constructs a new <code>ContactActionLockItem</code>.
   * @alias module:model/ContactActionLockItem
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ContactActionLockItem</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContactActionLockItem} obj Optional instance to populate.
   * @return {module:model/ContactActionLockItem} The populated <code>ContactActionLockItem</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('instanceId')) {
        obj['instanceId'] = ApiClient.convertToType(data['instanceId'], 'String');
      }
      if (data.hasOwnProperty('contactActionInstanceId')) {
        obj['contactActionInstanceId'] = ApiClient.convertToType(data['contactActionInstanceId'], 'String');
      }
      if (data.hasOwnProperty('isEnabled')) {
        obj['isEnabled'] = ApiClient.convertToType(data['isEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('isEnabledText')) {
        obj['isEnabledText'] = ApiClient.convertToType(data['isEnabledText'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {String} instanceId
   */
  exports.prototype['instanceId'] = undefined;
  /**
   * @member {String} contactActionInstanceId
   */
  exports.prototype['contactActionInstanceId'] = undefined;
  /**
   * @member {Boolean} isEnabled
   */
  exports.prototype['isEnabled'] = undefined;
  /**
   * @member {String} isEnabledText
   */
  exports.prototype['isEnabledText'] = undefined;



  return exports;
}));

