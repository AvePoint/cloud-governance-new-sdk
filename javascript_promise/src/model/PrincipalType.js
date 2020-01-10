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
    root.CgClient.PrincipalType = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';


  /**
   * Enum class PrincipalType.
   * @enum {}
   * @readonly
   */
  var exports = {
    /**
     * value: "None"
     * @const
     */
    "None": "None",
    /**
     * value: "User"
     * @const
     */
    "User": "User",
    /**
     * value: "DistributionList"
     * @const
     */
    "DistributionList": "DistributionList",
    /**
     * value: "SecurityGroup"
     * @const
     */
    "SecurityGroup": "SecurityGroup",
    /**
     * value: "SharePointGroup"
     * @const
     */
    "SharePointGroup": "SharePointGroup",
    /**
     * value: "All"
     * @const
     */
    "All": "All",
    /**
     * value: "Guest"
     * @const
     */
    "Guest": "Guest"  };

  /**
   * Returns a <code>PrincipalType</code> enum value from a Javascript object name.
   * @param {Object} data The plain JavaScript object containing the name of the enum value.
   * @return {module:model/PrincipalType} The enum <code>PrincipalType</code> value.
   */
  exports.constructFromObject = function(object) {
    return object;
  }

  return exports;
}));


