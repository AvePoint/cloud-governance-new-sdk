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
    define(['ApiClient', 'model/AnonymousLinkSettings', 'model/ExternalUserSharingType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./AnonymousLinkSettings'), require('./ExternalUserSharingType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ExternalUserSharingSettings = factory(root.CgClient.ApiClient, root.CgClient.AnonymousLinkSettings, root.CgClient.ExternalUserSharingType);
  }
}(this, function(ApiClient, AnonymousLinkSettings, ExternalUserSharingType) {
  'use strict';



  /**
   * The ExternalUserSharingSettings model module.
   * @module model/ExternalUserSharingSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>ExternalUserSharingSettings</code>.
   * @alias module:model/ExternalUserSharingSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ExternalUserSharingSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExternalUserSharingSettings} obj Optional instance to populate.
   * @return {module:model/ExternalUserSharingSettings} The populated <code>ExternalUserSharingSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
      if (data.hasOwnProperty('sharingType')) {
        obj['sharingType'] = ExternalUserSharingType.constructFromObject(data['sharingType']);
      }
      if (data.hasOwnProperty('anonymousLinkSettings')) {
        obj['anonymousLinkSettings'] = AnonymousLinkSettings.constructFromObject(data['anonymousLinkSettings']);
      }
    }
    return obj;
  }

  /**
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;
  /**
   * @member {module:model/ExternalUserSharingType} sharingType
   */
  exports.prototype['sharingType'] = undefined;
  /**
   * @member {module:model/AnonymousLinkSettings} anonymousLinkSettings
   */
  exports.prototype['anonymousLinkSettings'] = undefined;



  return exports;
}));


