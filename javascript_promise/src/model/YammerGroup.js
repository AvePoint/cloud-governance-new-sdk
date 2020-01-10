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
    define(['ApiClient', 'model/GroupInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./GroupInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.YammerGroup = factory(root.CgClient.ApiClient, root.CgClient.GroupInfo);
  }
}(this, function(ApiClient, GroupInfo) {
  'use strict';



  /**
   * The YammerGroup model module.
   * @module model/YammerGroup
   * @version 1.0
   */

  /**
   * Constructs a new <code>YammerGroup</code>.
   * @alias module:model/YammerGroup
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>YammerGroup</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/YammerGroup} obj Optional instance to populate.
   * @return {module:model/YammerGroup} The populated <code>YammerGroup</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('exists')) {
        obj['exists'] = ApiClient.convertToType(data['exists'], 'Boolean');
      }
      if (data.hasOwnProperty('group')) {
        obj['group'] = GroupInfo.constructFromObject(data['group']);
      }
    }
    return obj;
  }

  /**
   * @member {Boolean} exists
   */
  exports.prototype['exists'] = undefined;
  /**
   * @member {module:model/GroupInfo} group
   */
  exports.prototype['group'] = undefined;



  return exports;
}));


