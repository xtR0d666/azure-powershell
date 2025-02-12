// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Parameters that define the configuration of traffic analytics.</summary>
    public partial class TrafficAnalyticsConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ITrafficAnalyticsConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ITrafficAnalyticsConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Flag to enable/disable traffic analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="TrafficAnalyticsInterval" /> property.</summary>
        private int? _trafficAnalyticsInterval;

        /// <summary>
        /// The interval in minutes which would decide how frequently TA service should do flow analytics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public int? TrafficAnalyticsInterval { get => this._trafficAnalyticsInterval; set => this._trafficAnalyticsInterval = value; }

        /// <summary>Backing field for <see cref="WorkspaceId" /> property.</summary>
        private string _workspaceId;

        /// <summary>The resource guid of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string WorkspaceId { get => this._workspaceId; set => this._workspaceId = value; }

        /// <summary>Backing field for <see cref="WorkspaceRegion" /> property.</summary>
        private string _workspaceRegion;

        /// <summary>The location of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string WorkspaceRegion { get => this._workspaceRegion; set => this._workspaceRegion = value; }

        /// <summary>Backing field for <see cref="WorkspaceResourceId" /> property.</summary>
        private string _workspaceResourceId;

        /// <summary>Resource Id of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string WorkspaceResourceId { get => this._workspaceResourceId; set => this._workspaceResourceId = value; }

        /// <summary>Creates an new <see cref="TrafficAnalyticsConfigurationProperties" /> instance.</summary>
        public TrafficAnalyticsConfigurationProperties()
        {

        }
    }
    /// Parameters that define the configuration of traffic analytics.
    public partial interface ITrafficAnalyticsConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>Flag to enable/disable traffic analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable/disable traffic analytics.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// The interval in minutes which would decide how frequently TA service should do flow analytics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval in minutes which would decide how frequently TA service should do flow analytics.",
        SerializedName = @"trafficAnalyticsInterval",
        PossibleTypes = new [] { typeof(int) })]
        int? TrafficAnalyticsInterval { get; set; }
        /// <summary>The resource guid of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource guid of the attached workspace.",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceId { get; set; }
        /// <summary>The location of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the attached workspace.",
        SerializedName = @"workspaceRegion",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceRegion { get; set; }
        /// <summary>Resource Id of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id of the attached workspace.",
        SerializedName = @"workspaceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceResourceId { get; set; }

    }
    /// Parameters that define the configuration of traffic analytics.
    internal partial interface ITrafficAnalyticsConfigurationPropertiesInternal

    {
        /// <summary>Flag to enable/disable traffic analytics.</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// The interval in minutes which would decide how frequently TA service should do flow analytics.
        /// </summary>
        int? TrafficAnalyticsInterval { get; set; }
        /// <summary>The resource guid of the attached workspace.</summary>
        string WorkspaceId { get; set; }
        /// <summary>The location of the attached workspace.</summary>
        string WorkspaceRegion { get; set; }
        /// <summary>Resource Id of the attached workspace.</summary>
        string WorkspaceResourceId { get; set; }

    }
}