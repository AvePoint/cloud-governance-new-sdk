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
    define(['ApiClient', 'model/DurationType', 'model/ExtendBasedOnPoint', 'model/PolicyExtensionType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./DurationType'), require('./ExtendBasedOnPoint'), require('./PolicyExtensionType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.PolicyExtensionLifecycleItem = factory(root.CgClient.ApiClient, root.CgClient.DurationType, root.CgClient.ExtendBasedOnPoint, root.CgClient.PolicyExtensionType);
  }
}(this, function(ApiClient, DurationType, ExtendBasedOnPoint, PolicyExtensionType) {
  'use strict';



  /**
   * The PolicyExtensionLifecycleItem model module.
   * @module model/PolicyExtensionLifecycleItem
   * @version 1.0
   */

  /**
   * Constructs a new <code>PolicyExtensionLifecycleItem</code>.
   * @alias module:model/PolicyExtensionLifecycleItem
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>PolicyExtensionLifecycleItem</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PolicyExtensionLifecycleItem} obj Optional instance to populate.
   * @return {module:model/PolicyExtensionLifecycleItem} The populated <code>PolicyExtensionLifecycleItem</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('type')) {
        obj['type'] = PolicyExtensionType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('duration')) {
        obj['duration'] = ApiClient.convertToType(data['duration'], 'Number');
      }
      if (data.hasOwnProperty('durationType')) {
        obj['durationType'] = DurationType.constructFromObject(data['durationType']);
      }
      if (data.hasOwnProperty('extendBasedOnPoint')) {
        obj['extendBasedOnPoint'] = ExtendBasedOnPoint.constructFromObject(data['extendBasedOnPoint']);
      }
      if (data.hasOwnProperty('isEnabled')) {
        obj['isEnabled'] = ApiClient.convertToType(data['isEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('isDefaultProcess')) {
        obj['isDefaultProcess'] = ApiClient.convertToType(data['isDefaultProcess'], 'Boolean');
      }
      if (data.hasOwnProperty('processId')) {
        obj['processId'] = ApiClient.convertToType(data['processId'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/PolicyExtensionType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {Number} duration
   */
  exports.prototype['duration'] = undefined;
  /**
   * @member {module:model/DurationType} durationType
   */
  exports.prototype['durationType'] = undefined;
  /**
   * @member {module:model/ExtendBasedOnPoint} extendBasedOnPoint
   */
  exports.prototype['extendBasedOnPoint'] = undefined;
  /**
   * @member {Boolean} isEnabled
   */
  exports.prototype['isEnabled'] = undefined;
  /**
   * @member {Boolean} isDefaultProcess
   */
  exports.prototype['isDefaultProcess'] = undefined;
  /**
   * @member {String} processId
   */
  exports.prototype['processId'] = undefined;



  return exports;
}));


