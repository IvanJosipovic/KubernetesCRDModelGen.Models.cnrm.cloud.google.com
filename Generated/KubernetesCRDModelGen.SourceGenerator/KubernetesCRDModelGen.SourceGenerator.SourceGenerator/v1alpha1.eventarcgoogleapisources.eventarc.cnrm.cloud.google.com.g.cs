#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventarc.cnrm.cloud.google.com;
/// <summary>EventarcGoogleAPISource is the Schema for the EventarcGoogleAPISource API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventarcGoogleAPISourceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EventarcGoogleAPISource>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventarcGoogleAPISourceList";
    public const string KubeGroup = "eventarc.cnrm.cloud.google.com";
    public const string KubePluralName = "eventarcgoogleapisources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventarc.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventarcGoogleAPISourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1EventarcGoogleAPISource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1EventarcGoogleAPISource> Items { get; set; }
}

/// <summary>
/// Optional. Resource name of a KMS crypto key (managed by the user) used to
/// encrypt/decrypt their event data.
/// 
/// It must match the pattern
/// `projects/-*-/locations/-*-/keyRings/-*-/cryptoKeys/-*`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceSpecCryptoKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The minimum severity of logs that will be sent to Stackdriver/Platform Telemetry. Logs at severity &gt;= this value will be sent, unless it is NONE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1EventarcGoogleAPISourceSpecLoggingConfigLogSeverityEnum>))]
public enum V1alpha1EventarcGoogleAPISourceSpecLoggingConfigLogSeverityEnum
{
    [EnumMember(Value = "NONE"), JsonStringEnumMemberName("NONE")]
    NONE,
    [EnumMember(Value = "DEBUG"), JsonStringEnumMemberName("DEBUG")]
    DEBUG,
    [EnumMember(Value = "INFO"), JsonStringEnumMemberName("INFO")]
    INFO,
    [EnumMember(Value = "NOTICE"), JsonStringEnumMemberName("NOTICE")]
    NOTICE,
    [EnumMember(Value = "WARNING"), JsonStringEnumMemberName("WARNING")]
    WARNING,
    [EnumMember(Value = "ERROR"), JsonStringEnumMemberName("ERROR")]
    ERROR,
    [EnumMember(Value = "CRITICAL"), JsonStringEnumMemberName("CRITICAL")]
    CRITICAL,
    [EnumMember(Value = "ALERT"), JsonStringEnumMemberName("ALERT")]
    ALERT,
    [EnumMember(Value = "EMERGENCY"), JsonStringEnumMemberName("EMERGENCY")]
    EMERGENCY
}

/// <summary>Optional. Config to control Platform logging for the GoogleApiSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceSpecLoggingConfig
{
    /// <summary>Optional. The minimum severity of logs that will be sent to Stackdriver/Platform Telemetry. Logs at severity &gt;= this value will be sent, unless it is NONE.</summary>
    [JsonPropertyName("logSeverity")]
    public V1alpha1EventarcGoogleAPISourceSpecLoggingConfigLogSeverityEnum? LogSeverity { get; set; }
}

/// <summary>Required. Destination is the message bus that the GoogleApiSource is delivering to. It must be point to the full resource name of a MessageBus. Format: &quot;projects/{PROJECT_ID}/locations/{region}/messagesBuses/{MESSAGE_BUS_ID)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceSpecMessageBusRef
{
    /// <summary>A reference to an externally managed EventarcMessageBus resource. Should be in the format `projects/{{projectID}}/locations/{{location}}/messageBuses/{{messageBusID}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `EventarcMessageBus` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `EventarcMessageBus` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceSpecProjectRef
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

/// <summary>EventarcGoogleAPISourceSpec defines the desired state of EventarcGoogleAPISource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceSpec
{
    /// <summary>Optional. Resource annotations.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Optional. Resource name of a KMS crypto key (managed by the user) used to
    /// encrypt/decrypt their event data.
    /// 
    /// It must match the pattern
    /// `projects/-*-/locations/-*-/keyRings/-*-/cryptoKeys/-*`.
    /// </summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1alpha1EventarcGoogleAPISourceSpecCryptoKeyRef? CryptoKeyRef { get; set; }

    /// <summary>Optional. Resource display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Resource labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Config to control Platform logging for the GoogleApiSource.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1EventarcGoogleAPISourceSpecLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. Destination is the message bus that the GoogleApiSource is delivering to. It must be point to the full resource name of a MessageBus. Format: &quot;projects/{PROJECT_ID}/locations/{region}/messagesBuses/{MESSAGE_BUS_ID)</summary>
    [JsonPropertyName("messageBusRef")]
    public required V1alpha1EventarcGoogleAPISourceSpecMessageBusRef MessageBusRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1EventarcGoogleAPISourceSpecProjectRef ProjectRef { get; set; }

    /// <summary>The EventarcGoogleAPISource name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceStatusConditions
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
public partial class V1alpha1EventarcGoogleAPISourceStatusObservedState
{
    /// <summary>Output only. The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields, and might be sent only on update and delete requests to ensure that the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Server assigned unique identifier for the channel. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>EventarcGoogleAPISourceStatus defines the config connector machine state of EventarcGoogleAPISource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleAPISourceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventarcGoogleAPISourceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the EventarcGoogleAPISource resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1EventarcGoogleAPISourceStatusObservedState? ObservedState { get; set; }
}

/// <summary>EventarcGoogleAPISource is the Schema for the EventarcGoogleAPISource API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventarcGoogleAPISource : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EventarcGoogleAPISourceSpec>, IStatus<V1alpha1EventarcGoogleAPISourceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventarcGoogleAPISource";
    public const string KubeGroup = "eventarc.cnrm.cloud.google.com";
    public const string KubePluralName = "eventarcgoogleapisources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventarc.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventarcGoogleAPISource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventarcGoogleAPISourceSpec defines the desired state of EventarcGoogleAPISource</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1EventarcGoogleAPISourceSpec Spec { get; set; }

    /// <summary>EventarcGoogleAPISourceStatus defines the config connector machine state of EventarcGoogleAPISource</summary>
    [JsonPropertyName("status")]
    public V1alpha1EventarcGoogleAPISourceStatus? Status { get; set; }
}