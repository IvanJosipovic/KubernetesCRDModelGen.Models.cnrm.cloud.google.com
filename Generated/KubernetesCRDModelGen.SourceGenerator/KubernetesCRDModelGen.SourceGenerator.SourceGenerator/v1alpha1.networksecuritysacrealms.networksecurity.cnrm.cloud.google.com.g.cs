#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecuritySACRealm is the Schema for the NetworkSecuritySACRealm API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecuritySACRealmList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecuritySACRealm>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecuritySACRealmList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritysacrealms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecuritySACRealmList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecuritySACRealm objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecuritySACRealm> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySACRealmSpecProjectRef
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

/// <summary>Immutable. SSE service provider associated with the realm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NetworkSecuritySACRealmSpecSecurityServiceEnum>))]
public enum V1alpha1NetworkSecuritySACRealmSpecSecurityServiceEnum
{
    [EnumMember(Value = "SECURITY_SERVICE_UNSPECIFIED"), JsonStringEnumMemberName("SECURITY_SERVICE_UNSPECIFIED")]
    SECURITYSERVICEUNSPECIFIED,
    [EnumMember(Value = "PALO_ALTO_PRISMA_ACCESS"), JsonStringEnumMemberName("PALO_ALTO_PRISMA_ACCESS")]
    PALOALTOPRISMAACCESS
}

/// <summary>NetworkSecuritySACRealmSpec defines the desired state of NetworkSecuritySACRealm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySACRealmSpec
{
    /// <summary>Optional. Optional list of labels applied to the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecuritySACRealmSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecuritySACRealm name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. SSE service provider associated with the realm.</summary>
    [JsonPropertyName("securityService")]
    public V1alpha1NetworkSecuritySACRealmSpecSecurityServiceEnum? SecurityService { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySACRealmStatusConditions
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

/// <summary>Output only. Key to be shared with SSE service provider during pairing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySACRealmStatusObservedStatePairingKey
{
    /// <summary>Output only. Timestamp in UTC of when this resource is considered expired. It expires 7 days after creation.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. Key value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySACRealmStatusObservedState
{
    /// <summary>Output only. Timestamp when the realm was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Key to be shared with SSE service provider during pairing.</summary>
    [JsonPropertyName("pairingKey")]
    public V1alpha1NetworkSecuritySACRealmStatusObservedStatePairingKey? PairingKey { get; set; }

    /// <summary>Output only. State of the realm.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Timestamp when the realm was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecuritySACRealmStatus defines the config connector machine state of NetworkSecuritySACRealm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySACRealmStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecuritySACRealmStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecuritySACRealm resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecuritySACRealmStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecuritySACRealm is the Schema for the NetworkSecuritySACRealm API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecuritySACRealm : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecuritySACRealmSpec>, IStatus<V1alpha1NetworkSecuritySACRealmStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecuritySACRealm";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritysacrealms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecuritySACRealm";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecuritySACRealmSpec defines the desired state of NetworkSecuritySACRealm</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkSecuritySACRealmSpec Spec { get; set; }

    /// <summary>NetworkSecuritySACRealmStatus defines the config connector machine state of NetworkSecuritySACRealm</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecuritySACRealmStatus? Status { get; set; }
}