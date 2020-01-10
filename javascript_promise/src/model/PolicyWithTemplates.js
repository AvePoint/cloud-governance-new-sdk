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
    define(['ApiClient', 'model/SiteTemplate'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./SiteTemplate'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.PolicyWithTemplates = factory(root.CgClient.ApiClient, root.CgClient.SiteTemplate);
  }
}(this, function(ApiClient, SiteTemplate) {
  'use strict';



  /**
   * The PolicyWithTemplates model module.
   * @module model/PolicyWithTemplates
   * @version 1.0
   */

  /**
   * Constructs a new <code>PolicyWithTemplates</code>.
   * @alias module:model/PolicyWithTemplates
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>PolicyWithTemplates</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PolicyWithTemplates} obj Optional instance to populate.
   * @return {module:model/PolicyWithTemplates} The populated <code>PolicyWithTemplates</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('policyId')) {
        obj['policyId'] = ApiClient.convertToType(data['policyId'], 'String');
      }
      if (data.hasOwnProperty('defaultTemplate')) {
        obj['defaultTemplate'] = ApiClient.convertToType(data['defaultTemplate'], 'String');
      }
      if (data.hasOwnProperty('templates')) {
        obj['templates'] = ApiClient.convertToType(data['templates'], [SiteTemplate]);
      }
    }
    return obj;
  }

  /**
   * @member {String} policyId
   */
  exports.prototype['policyId'] = undefined;
  /**
   * @member {String} defaultTemplate
   */
  exports.prototype['defaultTemplate'] = undefined;
  /**
   * @member {Array.<module:model/SiteTemplate>} templates
   */
  exports.prototype['templates'] = undefined;



  return exports;
}));


