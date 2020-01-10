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
    define(['ApiClient', 'model/NodeType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./NodeType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ContentMoveSPObject = factory(root.CgClient.ApiClient, root.CgClient.NodeType);
  }
}(this, function(ApiClient, NodeType) {
  'use strict';



  /**
   * The ContentMoveSPObject model module.
   * @module model/ContentMoveSPObject
   * @version 1.0
   */

  /**
   * Constructs a new <code>ContentMoveSPObject</code>.
   * @alias module:model/ContentMoveSPObject
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ContentMoveSPObject</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContentMoveSPObject} obj Optional instance to populate.
   * @return {module:model/ContentMoveSPObject} The populated <code>ContentMoveSPObject</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('siteId')) {
        obj['siteId'] = ApiClient.convertToType(data['siteId'], 'String');
      }
      if (data.hasOwnProperty('siteUrl')) {
        obj['siteUrl'] = ApiClient.convertToType(data['siteUrl'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('title')) {
        obj['title'] = ApiClient.convertToType(data['title'], 'String');
      }
      if (data.hasOwnProperty('fullUrl')) {
        obj['fullUrl'] = ApiClient.convertToType(data['fullUrl'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = NodeType.constructFromObject(data['type']);
      }
    }
    return obj;
  }

  /**
   * @member {String} siteId
   */
  exports.prototype['siteId'] = undefined;
  /**
   * @member {String} siteUrl
   */
  exports.prototype['siteUrl'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} title
   */
  exports.prototype['title'] = undefined;
  /**
   * @member {String} fullUrl
   */
  exports.prototype['fullUrl'] = undefined;
  /**
   * @member {module:model/NodeType} type
   */
  exports.prototype['type'] = undefined;



  return exports;
}));

