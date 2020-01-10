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
    define(['ApiClient', 'model/ApiUser', 'model/CustomMetadata', 'model/PolicyRef'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ApiUser'), require('./CustomMetadata'), require('./PolicyRef'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.AutoImportProfileRef = factory(root.CgClient.ApiClient, root.CgClient.ApiUser, root.CgClient.CustomMetadata, root.CgClient.PolicyRef);
  }
}(this, function(ApiClient, ApiUser, CustomMetadata, PolicyRef) {
  'use strict';



  /**
   * The AutoImportProfileRef model module.
   * @module model/AutoImportProfileRef
   * @version 1.0
   */

  /**
   * Constructs a new <code>AutoImportProfileRef</code>.
   * @alias module:model/AutoImportProfileRef
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>AutoImportProfileRef</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AutoImportProfileRef} obj Optional instance to populate.
   * @return {module:model/AutoImportProfileRef} The populated <code>AutoImportProfileRef</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('objectName')) {
        obj['objectName'] = ApiClient.convertToType(data['objectName'], 'String');
      }
      if (data.hasOwnProperty('notesToPrimaryContact')) {
        obj['notesToPrimaryContact'] = ApiClient.convertToType(data['notesToPrimaryContact'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('defaultSecondaryContact')) {
        obj['defaultSecondaryContact'] = ApiUser.constructFromObject(data['defaultSecondaryContact']);
      }
      if (data.hasOwnProperty('defaultPolicyId')) {
        obj['defaultPolicyId'] = ApiClient.convertToType(data['defaultPolicyId'], 'String');
      }
      if (data.hasOwnProperty('departments')) {
        obj['departments'] = ApiClient.convertToType(data['departments'], ['String']);
      }
      if (data.hasOwnProperty('policies')) {
        obj['policies'] = ApiClient.convertToType(data['policies'], [PolicyRef]);
      }
      if (data.hasOwnProperty('loadDepartmentFromUps')) {
        obj['loadDepartmentFromUps'] = ApiClient.convertToType(data['loadDepartmentFromUps'], 'Boolean');
      }
      if (data.hasOwnProperty('isLastStep')) {
        obj['isLastStep'] = ApiClient.convertToType(data['isLastStep'], 'Boolean');
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [CustomMetadata]);
      }
    }
    return obj;
  }

  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} objectName
   */
  exports.prototype['objectName'] = undefined;
  /**
   * @member {String} notesToPrimaryContact
   */
  exports.prototype['notesToPrimaryContact'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * @member {module:model/ApiUser} defaultSecondaryContact
   */
  exports.prototype['defaultSecondaryContact'] = undefined;
  /**
   * @member {String} defaultPolicyId
   */
  exports.prototype['defaultPolicyId'] = undefined;
  /**
   * @member {Array.<String>} departments
   */
  exports.prototype['departments'] = undefined;
  /**
   * @member {Array.<module:model/PolicyRef>} policies
   */
  exports.prototype['policies'] = undefined;
  /**
   * @member {Boolean} loadDepartmentFromUps
   */
  exports.prototype['loadDepartmentFromUps'] = undefined;
  /**
   * @member {Boolean} isLastStep
   */
  exports.prototype['isLastStep'] = undefined;
  /**
   * @member {Array.<module:model/CustomMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;



  return exports;
}));


