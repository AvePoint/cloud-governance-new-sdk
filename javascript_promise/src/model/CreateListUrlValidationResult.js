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
    define(['ApiClient', 'model/CreateListSPObject'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CreateListSPObject'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.CreateListUrlValidationResult = factory(root.CgClient.ApiClient, root.CgClient.CreateListSPObject);
  }
}(this, function(ApiClient, CreateListSPObject) {
  'use strict';



  /**
   * The CreateListUrlValidationResult model module.
   * @module model/CreateListUrlValidationResult
   * @version 1.0
   */

  /**
   * Constructs a new <code>CreateListUrlValidationResult</code>.
   * @alias module:model/CreateListUrlValidationResult
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>CreateListUrlValidationResult</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CreateListUrlValidationResult} obj Optional instance to populate.
   * @return {module:model/CreateListUrlValidationResult} The populated <code>CreateListUrlValidationResult</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('parentObject')) {
        obj['parentObject'] = CreateListSPObject.constructFromObject(data['parentObject']);
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
   * @member {module:model/CreateListSPObject} parentObject
   */
  exports.prototype['parentObject'] = undefined;
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


