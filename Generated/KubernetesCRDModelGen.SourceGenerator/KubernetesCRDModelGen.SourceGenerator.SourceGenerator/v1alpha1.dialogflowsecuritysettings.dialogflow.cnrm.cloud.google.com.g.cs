#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflow.cnrm.cloud.google.com;
/// <summary>DialogflowSecuritySettings is the Schema for the DialogflowSecuritySettings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowSecuritySettingsList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DialogflowSecuritySettings>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowSecuritySettingsList";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowsecuritysettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowSecuritySettingsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DialogflowSecuritySettings objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DialogflowSecuritySettings> Items { get; set; }
}

/// <summary>Controls audio export settings for post-conversation analytics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsSpecAudioExportSettings
{
    /// <summary>Filename pattern for exported audio.</summary>
    [JsonPropertyName("audioExportPattern")]
    public string? AudioExportPattern { get; set; }

    /// <summary>File format for exported audio file. Currently only in telephony recordings.</summary>
    [JsonPropertyName("audioFormat")]
    public string? AudioFormat { get; set; }

    /// <summary>Enable audio redaction if it is true. Note that this only redacts end-user audio data; Synthesised audio from the virtual agent is not redacted.</summary>
    [JsonPropertyName("enableAudioRedaction")]
    public bool? EnableAudioRedaction { get; set; }

    /// <summary>Cloud Storage bucket to export audio record to. Setting this field would grant the Storage Object Creator role to the Dialogflow Service Agent. API caller that tries to modify this field should have the permission of storage.buckets.setIamPolicy.</summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>Whether to store TTS audio. By default, TTS audio from the virtual agent is not exported.</summary>
    [JsonPropertyName("storeTtsAudio")]
    public bool? StoreTtsAudio { get; set; }
}

/// <summary>Controls conversation exporting settings to Insights after conversation is completed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsSpecInsightsExportSettings
{
    /// <summary>If enabled, we will automatically exports conversations to Insights and Insights runs its analyzers.</summary>
    [JsonPropertyName("enableInsightsExport")]
    public bool? EnableInsightsExport { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DialogflowSecuritySettingsSpec defines the desired state of DialogflowSecuritySettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsSpec
{
    /// <summary>Controls audio export settings for post-conversation analytics.</summary>
    [JsonPropertyName("audioExportSettings")]
    public V1alpha1DialogflowSecuritySettingsSpecAudioExportSettings? AudioExportSettings { get; set; }

    /// <summary>[DLP](https://cloud.google.com/dlp/docs) deidentify template name. Use this template to define de-identification configuration for the content.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>Required. The human-readable name of the security settings, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Controls conversation exporting settings to Insights after conversation is completed.</summary>
    [JsonPropertyName("insightsExportSettings")]
    public V1alpha1DialogflowSecuritySettingsSpecInsightsExportSettings? InsightsExportSettings { get; set; }

    /// <summary>[DLP](https://cloud.google.com/dlp/docs) inspect template name. Use this template to define inspect base settings.</summary>
    [JsonPropertyName("inspectTemplate")]
    public string? InspectTemplate { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DialogflowSecuritySettingsSpecProjectRef ProjectRef { get; set; }

    /// <summary>List of types of data to remove when retention settings triggers purge.</summary>
    [JsonPropertyName("purgeDataTypes")]
    public IList<string>? PurgeDataTypes { get; set; }

    /// <summary>Defines the data for which Dialogflow applies redaction. Dialogflow does not redact data that it does not have access to – for example, Cloud logging.</summary>
    [JsonPropertyName("redactionScope")]
    public string? RedactionScope { get; set; }

    /// <summary>Strategy that defines how we do redaction.</summary>
    [JsonPropertyName("redactionStrategy")]
    public string? RedactionStrategy { get; set; }

    /// <summary>The DialogflowSecuritySettings name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Specifies the retention behavior defined by SecuritySettings.RetentionStrategy.</summary>
    [JsonPropertyName("retentionStrategy")]
    public string? RetentionStrategy { get; set; }

    /// <summary>Retains the data for the specified number of days.</summary>
    [JsonPropertyName("retentionWindowDays")]
    public int? RetentionWindowDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsStatusObservedState
{
}

/// <summary>DialogflowSecuritySettingsStatus defines the config connector machine state of DialogflowSecuritySettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowSecuritySettingsStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowSecuritySettingsStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DialogflowSecuritySettings resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DialogflowSecuritySettingsStatusObservedState? ObservedState { get; set; }
}

/// <summary>DialogflowSecuritySettings is the Schema for the DialogflowSecuritySettings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowSecuritySettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowSecuritySettingsSpec>, IStatus<V1alpha1DialogflowSecuritySettingsStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowSecuritySettings";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowsecuritysettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowSecuritySettings";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DialogflowSecuritySettingsSpec defines the desired state of DialogflowSecuritySettings</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DialogflowSecuritySettingsSpec Spec { get; set; }

    /// <summary>DialogflowSecuritySettingsStatus defines the config connector machine state of DialogflowSecuritySettings</summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowSecuritySettingsStatus? Status { get; set; }
}