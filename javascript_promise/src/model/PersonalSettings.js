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
    define(['ApiClient', 'model/PersonalSettingsPropertyInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./PersonalSettingsPropertyInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.PersonalSettings = factory(root.CgClient.ApiClient, root.CgClient.PersonalSettingsPropertyInfo);
  }
}(this, function(ApiClient, PersonalSettingsPropertyInfo) {
  'use strict';



  /**
   * The PersonalSettings model module.
   * @module model/PersonalSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>PersonalSettings</code>.
   * @alias module:model/PersonalSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>PersonalSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PersonalSettings} obj Optional instance to populate.
   * @return {module:model/PersonalSettings} The populated <code>PersonalSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('userID')) {
        obj['userID'] = ApiClient.convertToType(data['userID'], 'Number');
      }
      if (data.hasOwnProperty('languageID')) {
        obj['languageID'] = ApiClient.convertToType(data['languageID'], 'Number');
      }
      if (data.hasOwnProperty('timeZoneID')) {
        obj['timeZoneID'] = ApiClient.convertToType(data['timeZoneID'], 'Number');
      }
      if (data.hasOwnProperty('properties')) {
        obj['properties'] = PersonalSettingsPropertyInfo.constructFromObject(data['properties']);
      }
    }
    return obj;
  }

  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {Number} userID
   */
  exports.prototype['userID'] = undefined;
  /**
   * @member {Number} languageID
   */
  exports.prototype['languageID'] = undefined;
  /**
   * @member {Number} timeZoneID
   */
  exports.prototype['timeZoneID'] = undefined;
  /**
   * @member {module:model/PersonalSettingsPropertyInfo} properties
   */
  exports.prototype['properties'] = undefined;



  return exports;
}));

