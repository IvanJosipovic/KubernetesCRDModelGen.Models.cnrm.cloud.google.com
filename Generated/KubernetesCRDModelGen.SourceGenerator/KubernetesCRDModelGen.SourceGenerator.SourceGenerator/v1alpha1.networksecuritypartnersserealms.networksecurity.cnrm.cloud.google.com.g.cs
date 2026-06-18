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
/// <summary>NetworkSecurityPartnerSSERealm is the Schema for the NetworkSecurityPartnerSSERealm API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityPartnerSSERealmList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecurityPartnerSSERealm>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityPartnerSSERealmList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritypartnersserealms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityPartnerSSERealmList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecurityPartnerSSERealm objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecurityPartnerSSERealm> Items { get; set; }
}

/// <summary>Optional. Required only for PAN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityPartnerSSERealmSpecPanOptions
{
    /// <summary>Optional. serial_number is provided by PAN to identify GCP customer on PAN side.</summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>Optional. tenant_id is provided by PAN to identify GCP customer on PAN side.</summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityPartnerSSERealmSpecProjectRef
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

/// <summary>NetworkSecurityPartnerSSERealmSpec defines the desired state of NetworkSecurityPartnerSSERealm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityPartnerSSERealmSpec
{
    /// <summary>Optional. Labels as key value pairs</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Required. value of the key to establish global handshake from SSERealm</summary>
    [JsonPropertyName("pairingKey")]
    public required string PairingKey { get; set; }

    /// <summary>Optional. Required only for PAN.</summary>
    [JsonPropertyName("panOptions")]
    public V1alpha1NetworkSecurityPartnerSSERealmSpecPanOptions? PanOptions { get; set; }

    /// <summary>Optional. Partner-owned network to be peered with CDEN&apos;s sse_network in sse_project</summary>
    [JsonPropertyName("partnerNetwork")]
    public string? PartnerNetwork { get; set; }

    /// <summary>Optional. VPC owned by the partner to be peered with CDEN sse_vpc in sse_project This field is deprecated. Use partner_network instead.</summary>
    [JsonPropertyName("partnerVPC")]
    public string? PartnerVPC { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecurityPartnerSSERealmSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecurityPartnerSSERealm name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityPartnerSSERealmStatusConditions
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
public partial class V1alpha1NetworkSecurityPartnerSSERealmStatusObservedState
{
    /// <summary>Output only. Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. CDEN-owned network to be peered with partner_network</summary>
    [JsonPropertyName("sseNetwork")]
    public string? SseNetwork { get; set; }

    /// <summary>Output only. CDEN owned project owning sse_vpc. It stores project id in the TTM flow, but project number in the NCCGW flow. This field will be deprecated after the partner migrates from using sse_project to using sse_project_number.</summary>
    [JsonPropertyName("sseProject")]
    public string? SseProject { get; set; }

    /// <summary>Output only. CDEN owned project owning sse_vpc</summary>
    [JsonPropertyName("sseProjectNumber")]
    public long? SseProjectNumber { get; set; }

    /// <summary>Output only. CDEN owned VPC to be peered with partner_vpc This field is deprecated. Use sse_network instead.</summary>
    [JsonPropertyName("sseVPC")]
    public string? SseVPC { get; set; }

    /// <summary>Output only. State of the realm. It can be either CUSTOMER_ATTACHED or CUSTOMER_DETACHED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityPartnerSSERealmStatus defines the config connector machine state of NetworkSecurityPartnerSSERealm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityPartnerSSERealmStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecurityPartnerSSERealmStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecurityPartnerSSERealm resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecurityPartnerSSERealmStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecurityPartnerSSERealm is the Schema for the NetworkSecurityPartnerSSERealm API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityPartnerSSERealm : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecurityPartnerSSERealmSpec>, IStatus<V1alpha1NetworkSecurityPartnerSSERealmStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityPartnerSSERealm";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritypartnersserealms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityPartnerSSERealm";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityPartnerSSERealmSpec defines the desired state of NetworkSecurityPartnerSSERealm</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkSecurityPartnerSSERealmSpec Spec { get; set; }

    /// <summary>NetworkSecurityPartnerSSERealmStatus defines the config connector machine state of NetworkSecurityPartnerSSERealm</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecurityPartnerSSERealmStatus? Status { get; set; }
}