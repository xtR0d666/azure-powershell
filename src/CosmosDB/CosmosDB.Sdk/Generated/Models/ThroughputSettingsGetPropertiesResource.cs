// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ThroughputSettingsGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ThroughputSettingsGetPropertiesResource class.
        /// </summary>
        public ThroughputSettingsGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ThroughputSettingsGetPropertiesResource class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource
        /// throughput. Either throughput is required or autoscaleSettings is
        /// required, but not both.</param>
        /// <param name="autoscaleSettings">Cosmos DB resource for autoscale
        /// settings. Either throughput is required or autoscaleSettings is
        /// required, but not both.</param>
        /// <param name="minimumThroughput">The minimum throughput of the
        /// resource</param>
        /// <param name="offerReplacePending">The throughput replace is
        /// pending</param>
        /// <param name="instantMaximumThroughput">The offer throughput value
        /// to instantly scale up without triggering splits</param>
        /// <param name="softAllowedMaximumThroughput">The maximum throughput
        /// value or the maximum maxThroughput value (for autoscale) that can
        /// be specified</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public ThroughputSettingsGetPropertiesResource(int? throughput = default(int?), AutoscaleSettingsResource autoscaleSettings = default(AutoscaleSettingsResource), string minimumThroughput = default(string), string offerReplacePending = default(string), string instantMaximumThroughput = default(string), string softAllowedMaximumThroughput = default(string), string _rid = default(string), double? _ts = default(double?), string _etag = default(string))
        {
            Throughput = throughput;
            AutoscaleSettings = autoscaleSettings;
            MinimumThroughput = minimumThroughput;
            OfferReplacePending = offerReplacePending;
            InstantMaximumThroughput = instantMaximumThroughput;
            SoftAllowedMaximumThroughput = softAllowedMaximumThroughput;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the Cosmos DB resource throughput. Either
        /// throughput is required or autoscaleSettings is required, but not
        /// both.
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public int? Throughput { get; set; }

        /// <summary>
        /// Gets or sets cosmos DB resource for autoscale settings. Either
        /// throughput is required or autoscaleSettings is required, but not
        /// both.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaleSettings")]
        public AutoscaleSettingsResource AutoscaleSettings { get; set; }

        /// <summary>
        /// Gets the minimum throughput of the resource
        /// </summary>
        [JsonProperty(PropertyName = "minimumThroughput")]
        public string MinimumThroughput { get; private set; }

        /// <summary>
        /// Gets the throughput replace is pending
        /// </summary>
        [JsonProperty(PropertyName = "offerReplacePending")]
        public string OfferReplacePending { get; private set; }

        /// <summary>
        /// Gets the offer throughput value to instantly scale up without
        /// triggering splits
        /// </summary>
        [JsonProperty(PropertyName = "instantMaximumThroughput")]
        public string InstantMaximumThroughput { get; private set; }

        /// <summary>
        /// Gets the maximum throughput value or the maximum maxThroughput
        /// value (for autoscale) that can be specified
        /// </summary>
        [JsonProperty(PropertyName = "softAllowedMaximumThroughput")]
        public string SoftAllowedMaximumThroughput { get; private set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public double? _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AutoscaleSettings != null)
            {
                AutoscaleSettings.Validate();
            }
        }
    }
}
