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
    define(['ApiClient', 'model/AssignBy', 'model/GroupConstructureRule', 'model/GroupIdRuleType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./AssignBy'), require('./GroupConstructureRule'), require('./GroupIdRuleType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.GroupIdConstructureSettings = factory(root.CgClient.ApiClient, root.CgClient.AssignBy, root.CgClient.GroupConstructureRule, root.CgClient.GroupIdRuleType);
  }
}(this, function(ApiClient, AssignBy, GroupConstructureRule, GroupIdRuleType) {
  'use strict';



  /**
   * The GroupIdConstructureSettings model module.
   * @module model/GroupIdConstructureSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>GroupIdConstructureSettings</code>.
   * @alias module:model/GroupIdConstructureSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>GroupIdConstructureSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GroupIdConstructureSettings} obj Optional instance to populate.
   * @return {module:model/GroupIdConstructureSettings} The populated <code>GroupIdConstructureSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('ruleType')) {
        obj['ruleType'] = GroupIdRuleType.constructFromObject(data['ruleType']);
      }
      if (data.hasOwnProperty('enableAutoSequenceNumber')) {
        obj['enableAutoSequenceNumber'] = ApiClient.convertToType(data['enableAutoSequenceNumber'], 'Boolean');
      }
      if (data.hasOwnProperty('autoSequenceNumber')) {
        obj['autoSequenceNumber'] = ApiClient.convertToType(data['autoSequenceNumber'], 'String');
      }
      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
      if (data.hasOwnProperty('assignBy')) {
        obj['assignBy'] = AssignBy.constructFromObject(data['assignBy']);
      }
      if (data.hasOwnProperty('prefixs')) {
        obj['prefixs'] = ApiClient.convertToType(data['prefixs'], [GroupConstructureRule]);
      }
      if (data.hasOwnProperty('suffixs')) {
        obj['suffixs'] = ApiClient.convertToType(data['suffixs'], [GroupConstructureRule]);
      }
    }
    return obj;
  }

  /**
   * @member {module:model/GroupIdRuleType} ruleType
   */
  exports.prototype['ruleType'] = undefined;
  /**
   * @member {Boolean} enableAutoSequenceNumber
   */
  exports.prototype['enableAutoSequenceNumber'] = undefined;
  /**
   * @member {String} autoSequenceNumber
   */
  exports.prototype['autoSequenceNumber'] = undefined;
  /**
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;
  /**
   * @member {module:model/AssignBy} assignBy
   */
  exports.prototype['assignBy'] = undefined;
  /**
   * @member {Array.<module:model/GroupConstructureRule>} prefixs
   */
  exports.prototype['prefixs'] = undefined;
  /**
   * @member {Array.<module:model/GroupConstructureRule>} suffixs
   */
  exports.prototype['suffixs'] = undefined;



  return exports;
}));

