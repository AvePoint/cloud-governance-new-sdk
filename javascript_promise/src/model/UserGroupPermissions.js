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
    define(['ApiClient', 'model/ServiceGroupWithPermissions', 'model/ServiceUserWithPermissions'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ServiceGroupWithPermissions'), require('./ServiceUserWithPermissions'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.UserGroupPermissions = factory(root.CgClient.ApiClient, root.CgClient.ServiceGroupWithPermissions, root.CgClient.ServiceUserWithPermissions);
  }
}(this, function(ApiClient, ServiceGroupWithPermissions, ServiceUserWithPermissions) {
  'use strict';



  /**
   * The UserGroupPermissions model module.
   * @module model/UserGroupPermissions
   * @version 1.0
   */

  /**
   * Constructs a new <code>UserGroupPermissions</code>.
   * @alias module:model/UserGroupPermissions
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>UserGroupPermissions</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/UserGroupPermissions} obj Optional instance to populate.
   * @return {module:model/UserGroupPermissions} The populated <code>UserGroupPermissions</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('userPermissions')) {
        obj['userPermissions'] = ApiClient.convertToType(data['userPermissions'], [ServiceUserWithPermissions]);
      }
      if (data.hasOwnProperty('groupPermissions')) {
        obj['groupPermissions'] = ApiClient.convertToType(data['groupPermissions'], [ServiceGroupWithPermissions]);
      }
    }
    return obj;
  }

  /**
   * @member {Array.<module:model/ServiceUserWithPermissions>} userPermissions
   */
  exports.prototype['userPermissions'] = undefined;
  /**
   * @member {Array.<module:model/ServiceGroupWithPermissions>} groupPermissions
   */
  exports.prototype['groupPermissions'] = undefined;



  return exports;
}));


