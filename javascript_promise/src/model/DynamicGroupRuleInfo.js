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
    define(['ApiClient', 'model/CategoryType', 'model/DynamicRuleCondition', 'model/LogicalOperator'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CategoryType'), require('./DynamicRuleCondition'), require('./LogicalOperator'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.DynamicGroupRuleInfo = factory(root.CgClient.ApiClient, root.CgClient.CategoryType, root.CgClient.DynamicRuleCondition, root.CgClient.LogicalOperator);
  }
}(this, function(ApiClient, CategoryType, DynamicRuleCondition, LogicalOperator) {
  'use strict';



  /**
   * The DynamicGroupRuleInfo model module.
   * @module model/DynamicGroupRuleInfo
   * @version 1.0
   */

  /**
   * Constructs a new <code>DynamicGroupRuleInfo</code>.
   * @alias module:model/DynamicGroupRuleInfo
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>DynamicGroupRuleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DynamicGroupRuleInfo} obj Optional instance to populate.
   * @return {module:model/DynamicGroupRuleInfo} The populated <code>DynamicGroupRuleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('order')) {
        obj['order'] = ApiClient.convertToType(data['order'], 'Number');
      }
      if (data.hasOwnProperty('relation')) {
        obj['relation'] = LogicalOperator.constructFromObject(data['relation']);
      }
      if (data.hasOwnProperty('category')) {
        obj['category'] = CategoryType.constructFromObject(data['category']);
      }
      if (data.hasOwnProperty('metadataId')) {
        obj['metadataId'] = ApiClient.convertToType(data['metadataId'], 'String');
      }
      if (data.hasOwnProperty('metadataName')) {
        obj['metadataName'] = ApiClient.convertToType(data['metadataName'], 'String');
      }
      if (data.hasOwnProperty('metadataValue')) {
        obj['metadataValue'] = ApiClient.convertToType(data['metadataValue'], 'String');
      }
      if (data.hasOwnProperty('metadataDisplayValue')) {
        obj['metadataDisplayValue'] = ApiClient.convertToType(data['metadataDisplayValue'], 'String');
      }
      if (data.hasOwnProperty('condition')) {
        obj['condition'] = DynamicRuleCondition.constructFromObject(data['condition']);
      }
    }
    return obj;
  }

  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {Number} order
   */
  exports.prototype['order'] = undefined;
  /**
   * @member {module:model/LogicalOperator} relation
   */
  exports.prototype['relation'] = undefined;
  /**
   * @member {module:model/CategoryType} category
   */
  exports.prototype['category'] = undefined;
  /**
   * @member {String} metadataId
   */
  exports.prototype['metadataId'] = undefined;
  /**
   * @member {String} metadataName
   */
  exports.prototype['metadataName'] = undefined;
  /**
   * @member {String} metadataValue
   */
  exports.prototype['metadataValue'] = undefined;
  /**
   * @member {String} metadataDisplayValue
   */
  exports.prototype['metadataDisplayValue'] = undefined;
  /**
   * @member {module:model/DynamicRuleCondition} condition
   */
  exports.prototype['condition'] = undefined;



  return exports;
}));


