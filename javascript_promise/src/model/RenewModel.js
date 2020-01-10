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
    define(['ApiClient', 'model/MembershipRenewalItemModel', 'model/ObjectContactModel', 'model/RequestMetadata'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./MembershipRenewalItemModel'), require('./ObjectContactModel'), require('./RequestMetadata'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.RenewModel = factory(root.CgClient.ApiClient, root.CgClient.MembershipRenewalItemModel, root.CgClient.ObjectContactModel, root.CgClient.RequestMetadata);
  }
}(this, function(ApiClient, MembershipRenewalItemModel, ObjectContactModel, RequestMetadata) {
  'use strict';



  /**
   * The RenewModel model module.
   * @module model/RenewModel
   * @version 1.0
   */

  /**
   * Constructs a new <code>RenewModel</code>.
   * @alias module:model/RenewModel
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>RenewModel</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RenewModel} obj Optional instance to populate.
   * @return {module:model/RenewModel} The populated <code>RenewModel</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('contacts')) {
        obj['contacts'] = ObjectContactModel.constructFromObject(data['contacts']);
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [RequestMetadata]);
      }
      if (data.hasOwnProperty('memberships')) {
        obj['memberships'] = ApiClient.convertToType(data['memberships'], [MembershipRenewalItemModel]);
      }
    }
    return obj;
  }

  /**
   * @member {module:model/ObjectContactModel} contacts
   */
  exports.prototype['contacts'] = undefined;
  /**
   * @member {Array.<module:model/RequestMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;
  /**
   * @member {Array.<module:model/MembershipRenewalItemModel>} memberships
   */
  exports.prototype['memberships'] = undefined;



  return exports;
}));


