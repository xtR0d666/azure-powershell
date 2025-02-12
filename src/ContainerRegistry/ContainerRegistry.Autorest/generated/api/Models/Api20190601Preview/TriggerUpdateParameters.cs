// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties for updating triggers.</summary>
    public partial class TriggerUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="BaseImageTrigger" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters _baseImageTrigger;

        /// <summary>The trigger based on base image dependencies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters BaseImageTrigger { get => (this._baseImageTrigger = this._baseImageTrigger ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.BaseImageTriggerUpdateParameters()); set => this._baseImageTrigger = value; }

        /// <summary>The type of the auto trigger for base image dependency updates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType? BaseImageTriggerBaseImageTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).BaseImageTriggerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).BaseImageTriggerType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType)""); }

        /// <summary>The name of the trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string BaseImageTriggerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).Name = value ?? null; }

        /// <summary>The current status of trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus? BaseImageTriggerStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus)""); }

        /// <summary>The endpoint URL for receiving update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string BaseImageTriggerUpdateTriggerEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).UpdateTriggerEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).UpdateTriggerEndpoint = value ?? null; }

        /// <summary>Type of Payload body for Base image update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType? BaseImageTriggerUpdateTriggerPayloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).UpdateTriggerPayloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParametersInternal)BaseImageTrigger).UpdateTriggerPayloadType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType)""); }

        /// <summary>Internal Acessors for BaseImageTrigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal.BaseImageTrigger { get => (this._baseImageTrigger = this._baseImageTrigger ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.BaseImageTriggerUpdateParameters()); set { {_baseImageTrigger = value;} } }

        /// <summary>Backing field for <see cref="SourceTrigger" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] _sourceTrigger;

        /// <summary>The collection of triggers based on source code repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] SourceTrigger { get => this._sourceTrigger; set => this._sourceTrigger = value; }

        /// <summary>Backing field for <see cref="TimerTrigger" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] _timerTrigger;

        /// <summary>The collection of timer triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] TimerTrigger { get => this._timerTrigger; set => this._timerTrigger = value; }

        /// <summary>Creates an new <see cref="TriggerUpdateParameters" /> instance.</summary>
        public TriggerUpdateParameters()
        {

        }
    }
    /// The properties for updating triggers.
    public partial interface ITriggerUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The type of the auto trigger for base image dependency updates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the auto trigger for base image dependency updates.",
        SerializedName = @"baseImageTriggerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType? BaseImageTriggerBaseImageTriggerType { get; set; }
        /// <summary>The name of the trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the trigger.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string BaseImageTriggerName { get; set; }
        /// <summary>The current status of trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current status of trigger.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus? BaseImageTriggerStatus { get; set; }
        /// <summary>The endpoint URL for receiving update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint URL for receiving update triggers.",
        SerializedName = @"updateTriggerEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string BaseImageTriggerUpdateTriggerEndpoint { get; set; }
        /// <summary>Type of Payload body for Base image update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Payload body for Base image update triggers.",
        SerializedName = @"updateTriggerPayloadType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType? BaseImageTriggerUpdateTriggerPayloadType { get; set; }
        /// <summary>The collection of triggers based on source code repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of triggers based on source code repository.",
        SerializedName = @"sourceTriggers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] SourceTrigger { get; set; }
        /// <summary>The collection of timer triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of timer triggers.",
        SerializedName = @"timerTriggers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] TimerTrigger { get; set; }

    }
    /// The properties for updating triggers.
    internal partial interface ITriggerUpdateParametersInternal

    {
        /// <summary>The trigger based on base image dependencies.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters BaseImageTrigger { get; set; }
        /// <summary>The type of the auto trigger for base image dependency updates.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType? BaseImageTriggerBaseImageTriggerType { get; set; }
        /// <summary>The name of the trigger.</summary>
        string BaseImageTriggerName { get; set; }
        /// <summary>The current status of trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus? BaseImageTriggerStatus { get; set; }
        /// <summary>The endpoint URL for receiving update triggers.</summary>
        string BaseImageTriggerUpdateTriggerEndpoint { get; set; }
        /// <summary>Type of Payload body for Base image update triggers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType? BaseImageTriggerUpdateTriggerPayloadType { get; set; }
        /// <summary>The collection of triggers based on source code repository.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] SourceTrigger { get; set; }
        /// <summary>The collection of timer triggers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] TimerTrigger { get; set; }

    }
}