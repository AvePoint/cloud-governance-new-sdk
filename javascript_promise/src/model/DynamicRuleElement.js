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
    define(['ApiClient', 'model/MetadataFieldType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./MetadataFieldType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.DynamicRuleElement = factory(root.CgClient.ApiClient, root.CgClient.MetadataFieldType);
  }
}(this, function(ApiClient, MetadataFieldType) {
  'use strict';



  /**
   * The DynamicRuleElement model module.
   * @module model/DynamicRuleElement
   * @version 1.0
   */

  /**
   * Constructs a new <code>DynamicRuleElement</code>.
   * @alias module:model/DynamicRuleElement
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>DynamicRuleElement</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DynamicRuleElement} obj Optional instance to populate.
   * @return {module:model/DynamicRuleElement} The populated <code>DynamicRuleElement</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = MetadataFieldType.constructFromObject(data['type']);
      }
    }
    return obj;
  }

  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {module:model/MetadataFieldType} type
   */
  exports.prototype['type'] = undefined;



  return exports;
}));


