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
    define(['ApiClient', 'model/ChangeWebSPObject', 'model/CustomMetadata'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ChangeWebSPObject'), require('./CustomMetadata'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ChangeWebUrlValidateResult = factory(root.CgClient.ApiClient, root.CgClient.ChangeWebSPObject, root.CgClient.CustomMetadata);
  }
}(this, function(ApiClient, ChangeWebSPObject, CustomMetadata) {
  'use strict';



  /**
   * The ChangeWebUrlValidateResult model module.
   * @module model/ChangeWebUrlValidateResult
   * @version 1.0
   */

  /**
   * Constructs a new <code>ChangeWebUrlValidateResult</code>.
   * @alias module:model/ChangeWebUrlValidateResult
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ChangeWebUrlValidateResult</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ChangeWebUrlValidateResult} obj Optional instance to populate.
   * @return {module:model/ChangeWebUrlValidateResult} The populated <code>ChangeWebUrlValidateResult</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('url')) {
        obj['url'] = ChangeWebSPObject.constructFromObject(data['url']);
      }
      if (data.hasOwnProperty('webTitle')) {
        obj['webTitle'] = ApiClient.convertToType(data['webTitle'], 'String');
      }
      if (data.hasOwnProperty('webDescription')) {
        obj['webDescription'] = ApiClient.convertToType(data['webDescription'], 'String');
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [CustomMetadata]);
      }
      if (data.hasOwnProperty('isValid')) {
        obj['isValid'] = ApiClient.convertToType(data['isValid'], 'Boolean');
      }
      if (data.hasOwnProperty('errorMessage')) {
        obj['errorMessage'] = ApiClient.convertToType(data['errorMessage'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/ChangeWebSPObject} url
   */
  exports.prototype['url'] = undefined;
  /**
   * @member {String} webTitle
   */
  exports.prototype['webTitle'] = undefined;
  /**
   * @member {String} webDescription
   */
  exports.prototype['webDescription'] = undefined;
  /**
   * @member {Array.<module:model/CustomMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;
  /**
   * @member {Boolean} isValid
   */
  exports.prototype['isValid'] = undefined;
  /**
   * @member {String} errorMessage
   */
  exports.prototype['errorMessage'] = undefined;



  return exports;
}));


