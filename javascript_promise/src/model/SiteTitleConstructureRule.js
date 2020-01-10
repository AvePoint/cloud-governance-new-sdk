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
    define(['ApiClient', 'model/SiteConstructTitleType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./SiteConstructTitleType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.SiteTitleConstructureRule = factory(root.CgClient.ApiClient, root.CgClient.SiteConstructTitleType);
  }
}(this, function(ApiClient, SiteConstructTitleType) {
  'use strict';



  /**
   * The SiteTitleConstructureRule model module.
   * @module model/SiteTitleConstructureRule
   * @version 1.0
   */

  /**
   * Constructs a new <code>SiteTitleConstructureRule</code>.
   * @alias module:model/SiteTitleConstructureRule
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>SiteTitleConstructureRule</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SiteTitleConstructureRule} obj Optional instance to populate.
   * @return {module:model/SiteTitleConstructureRule} The populated <code>SiteTitleConstructureRule</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('type')) {
        obj['type'] = SiteConstructTitleType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('value')) {
        obj['value'] = ApiClient.convertToType(data['value'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/SiteConstructTitleType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} value
   */
  exports.prototype['value'] = undefined;



  return exports;
}));


