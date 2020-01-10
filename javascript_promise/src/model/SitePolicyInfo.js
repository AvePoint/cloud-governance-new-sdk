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
    define(['ApiClient', 'model/CommonStatus', 'model/PolicyDaoSetting', 'model/PolicyElectionSetting', 'model/PolicyExpirationSetting', 'model/PolicyIconSetting', 'model/PolicyLifecycleSetting', 'model/PolicyQuotaSetting', 'model/PolicyQuotaThresholdSetting', 'model/PolicyRecertificationSetting', 'model/PolicySharingSetting', 'model/PolicyType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CommonStatus'), require('./PolicyDaoSetting'), require('./PolicyElectionSetting'), require('./PolicyExpirationSetting'), require('./PolicyIconSetting'), require('./PolicyLifecycleSetting'), require('./PolicyQuotaSetting'), require('./PolicyQuotaThresholdSetting'), require('./PolicyRecertificationSetting'), require('./PolicySharingSetting'), require('./PolicyType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.SitePolicyInfo = factory(root.CgClient.ApiClient, root.CgClient.CommonStatus, root.CgClient.PolicyDaoSetting, root.CgClient.PolicyElectionSetting, root.CgClient.PolicyExpirationSetting, root.CgClient.PolicyIconSetting, root.CgClient.PolicyLifecycleSetting, root.CgClient.PolicyQuotaSetting, root.CgClient.PolicyQuotaThresholdSetting, root.CgClient.PolicyRecertificationSetting, root.CgClient.PolicySharingSetting, root.CgClient.PolicyType);
  }
}(this, function(ApiClient, CommonStatus, PolicyDaoSetting, PolicyElectionSetting, PolicyExpirationSetting, PolicyIconSetting, PolicyLifecycleSetting, PolicyQuotaSetting, PolicyQuotaThresholdSetting, PolicyRecertificationSetting, PolicySharingSetting, PolicyType) {
  'use strict';



  /**
   * The SitePolicyInfo model module.
   * @module model/SitePolicyInfo
   * @version 1.0
   */

  /**
   * Constructs a new <code>SitePolicyInfo</code>.
   * @alias module:model/SitePolicyInfo
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>SitePolicyInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SitePolicyInfo} obj Optional instance to populate.
   * @return {module:model/SitePolicyInfo} The populated <code>SitePolicyInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('quotaSetting')) {
        obj['quotaSetting'] = PolicyQuotaSetting.constructFromObject(data['quotaSetting']);
      }
      if (data.hasOwnProperty('sharingSetting')) {
        obj['sharingSetting'] = PolicySharingSetting.constructFromObject(data['sharingSetting']);
      }
      if (data.hasOwnProperty('isDesignerEnabled')) {
        obj['isDesignerEnabled'] = ApiClient.convertToType(data['isDesignerEnabled'], 'Boolean');
      }
      if (data.hasOwnProperty('siteMaxDepth')) {
        obj['siteMaxDepth'] = ApiClient.convertToType(data['siteMaxDepth'], 'Number');
      }
      if (data.hasOwnProperty('iconSetting')) {
        obj['iconSetting'] = PolicyIconSetting.constructFromObject(data['iconSetting']);
      }
      if (data.hasOwnProperty('daoSetting')) {
        obj['daoSetting'] = PolicyDaoSetting.constructFromObject(data['daoSetting']);
      }
      if (data.hasOwnProperty('leasePeriodSetting')) {
        obj['leasePeriodSetting'] = PolicyExpirationSetting.constructFromObject(data['leasePeriodSetting']);
      }
      if (data.hasOwnProperty('inactivitySetting')) {
        obj['inactivitySetting'] = PolicyExpirationSetting.constructFromObject(data['inactivitySetting']);
      }
      if (data.hasOwnProperty('lifecycleSetting')) {
        obj['lifecycleSetting'] = PolicyLifecycleSetting.constructFromObject(data['lifecycleSetting']);
      }
      if (data.hasOwnProperty('recertificationSetting')) {
        obj['recertificationSetting'] = PolicyRecertificationSetting.constructFromObject(data['recertificationSetting']);
      }
      if (data.hasOwnProperty('renewalSetting')) {
        obj['renewalSetting'] = PolicyRecertificationSetting.constructFromObject(data['renewalSetting']);
      }
      if (data.hasOwnProperty('electionSetting')) {
        obj['electionSetting'] = PolicyElectionSetting.constructFromObject(data['electionSetting']);
      }
      if (data.hasOwnProperty('quotaThresholdSetting')) {
        obj['quotaThresholdSetting'] = PolicyQuotaThresholdSetting.constructFromObject(data['quotaThresholdSetting']);
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('category')) {
        obj['category'] = ApiClient.convertToType(data['category'], 'String');
      }
      if (data.hasOwnProperty('detail')) {
        obj['detail'] = ApiClient.convertToType(data['detail'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = PolicyType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('farmId')) {
        obj['farmId'] = ApiClient.convertToType(data['farmId'], 'String');
      }
      if (data.hasOwnProperty('createdTime')) {
        obj['createdTime'] = ApiClient.convertToType(data['createdTime'], 'Date');
      }
      if (data.hasOwnProperty('createdBy')) {
        obj['createdBy'] = ApiClient.convertToType(data['createdBy'], 'String');
      }
      if (data.hasOwnProperty('isDeleted')) {
        obj['isDeleted'] = ApiClient.convertToType(data['isDeleted'], 'Boolean');
      }
      if (data.hasOwnProperty('modifiedTime')) {
        obj['modifiedTime'] = ApiClient.convertToType(data['modifiedTime'], 'Date');
      }
      if (data.hasOwnProperty('modifiedBy')) {
        obj['modifiedBy'] = ApiClient.convertToType(data['modifiedBy'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = CommonStatus.constructFromObject(data['status']);
      }
      if (data.hasOwnProperty('isReferenced')) {
        obj['isReferenced'] = ApiClient.convertToType(data['isReferenced'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {module:model/PolicyQuotaSetting} quotaSetting
   */
  exports.prototype['quotaSetting'] = undefined;
  /**
   * @member {module:model/PolicySharingSetting} sharingSetting
   */
  exports.prototype['sharingSetting'] = undefined;
  /**
   * @member {Boolean} isDesignerEnabled
   */
  exports.prototype['isDesignerEnabled'] = undefined;
  /**
   * @member {Number} siteMaxDepth
   */
  exports.prototype['siteMaxDepth'] = undefined;
  /**
   * @member {module:model/PolicyIconSetting} iconSetting
   */
  exports.prototype['iconSetting'] = undefined;
  /**
   * @member {module:model/PolicyDaoSetting} daoSetting
   */
  exports.prototype['daoSetting'] = undefined;
  /**
   * @member {module:model/PolicyExpirationSetting} leasePeriodSetting
   */
  exports.prototype['leasePeriodSetting'] = undefined;
  /**
   * @member {module:model/PolicyExpirationSetting} inactivitySetting
   */
  exports.prototype['inactivitySetting'] = undefined;
  /**
   * @member {module:model/PolicyLifecycleSetting} lifecycleSetting
   */
  exports.prototype['lifecycleSetting'] = undefined;
  /**
   * @member {module:model/PolicyRecertificationSetting} recertificationSetting
   */
  exports.prototype['recertificationSetting'] = undefined;
  /**
   * @member {module:model/PolicyRecertificationSetting} renewalSetting
   */
  exports.prototype['renewalSetting'] = undefined;
  /**
   * @member {module:model/PolicyElectionSetting} electionSetting
   */
  exports.prototype['electionSetting'] = undefined;
  /**
   * @member {module:model/PolicyQuotaThresholdSetting} quotaThresholdSetting
   */
  exports.prototype['quotaThresholdSetting'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * @member {String} category
   */
  exports.prototype['category'] = undefined;
  /**
   * @member {String} detail
   */
  exports.prototype['detail'] = undefined;
  /**
   * @member {module:model/PolicyType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} farmId
   */
  exports.prototype['farmId'] = undefined;
  /**
   * @member {Date} createdTime
   */
  exports.prototype['createdTime'] = undefined;
  /**
   * @member {String} createdBy
   */
  exports.prototype['createdBy'] = undefined;
  /**
   * @member {Boolean} isDeleted
   */
  exports.prototype['isDeleted'] = undefined;
  /**
   * @member {Date} modifiedTime
   */
  exports.prototype['modifiedTime'] = undefined;
  /**
   * @member {String} modifiedBy
   */
  exports.prototype['modifiedBy'] = undefined;
  /**
   * @member {module:model/CommonStatus} status
   */
  exports.prototype['status'] = undefined;
  /**
   * @member {Boolean} isReferenced
   */
  exports.prototype['isReferenced'] = undefined;



  return exports;
}));


