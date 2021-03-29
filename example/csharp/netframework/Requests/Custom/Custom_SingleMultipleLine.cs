﻿
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;

    public class Custom_SingleMultipleLine : TestBase
    {
        public Custom_SingleMultipleLine(ApiConfig config) : base(config) { }

        public Guid Run(CustomTestData data)
        {

            try
            {
                

                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCustomService(serviceId);
                var request = service.RequestTemplate;
                request.Summary = $"Custom_SingleMultipleLineSummary_{DateTime.Now}";
                var metadataInfo = request.Metadatas.FirstOrDefault(m => m.Name.Equals(data.SingleLineMetadataName, StringComparison.CurrentCultureIgnoreCase));
                if (metadataInfo != null)
                {
                    metadataInfo.Value = data.SingleLineMetadataValue;
                }
                return this.RequestsApi.SubmitCustomRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCustomRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}
