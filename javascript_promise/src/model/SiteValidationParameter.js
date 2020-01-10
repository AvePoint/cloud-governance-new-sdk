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
    root.CgClient.SiteValidationParameter = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';



  /**
   * The SiteValidationParameter model module.
   * @module model/SiteValidationParameter
   * @version 1.0
   */

  /**
   * Constructs a new <code>SiteValidationParameter</code>.
   * @alias module:model/SiteValidationParameter
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>SiteValidationParameter</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SiteValidationParameter} obj Optional instance to populate.
   * @return {module:model/SiteValidationParameter} The populated <code>SiteValidationParameter</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('ignoreLock')) {
        obj['ignoreLock'] = ApiClient.convertToType(data['ignoreLock'], 'Boolean');
      }
      if (data.hasOwnProperty('isEditTask')) {
        obj['isEditTask'] = ApiClient.convertToType(data['isEditTask'], 'Boolean');
      }
      if (data.hasOwnProperty('isFromQuestionnaire')) {
        obj['isFromQuestionnaire'] = ApiClient.convertToType(data['isFromQuestionnaire'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;
  /**
   * @member {Boolean} ignoreLock
   */
  exports.prototype['ignoreLock'] = undefined;
  /**
   * @member {Boolean} isEditTask
   */
  exports.prototype['isEditTask'] = undefined;
  /**
   * @member {Boolean} isFromQuestionnaire
   */
  exports.prototype['isFromQuestionnaire'] = undefined;



  return exports;
}));


