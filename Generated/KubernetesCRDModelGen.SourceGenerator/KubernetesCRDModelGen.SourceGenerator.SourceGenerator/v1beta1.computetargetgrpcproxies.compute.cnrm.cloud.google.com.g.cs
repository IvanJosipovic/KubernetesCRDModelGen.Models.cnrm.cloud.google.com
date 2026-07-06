#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeTargetGRPCProxy is the Schema for the ComputeTargetGRPCProxy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetGRPCProxyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeTargetGRPCProxy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetGRPCProxyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargetgrpcproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeTargetGRPCProxyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeTargetGRPCProxy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeTargetGRPCProxy> Items { get; set; }
}

/// <summary>The UrlMap resource that defines the mapping from URL to the BackendService. The protocol field in the BackendService must be set to GRPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetGRPCProxySpecUrlMapRef
{
    /// <summary>A reference to an externally managed ComputeURLMap resource. Should be in the format &quot;projects/{{projectID}}/global/urlMaps/{{urlMapID}}&quot; or &quot;projects/{{projectID}}/regions/{{region}}/urlMaps/{{urlMapID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeURLMap resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeURLMap resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ComputeTargetGRPCProxySpec defines the desired state of ComputeTargetGRPCProxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetGRPCProxySpec
{
    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ComputeTargetGRPCProxy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The UrlMap resource that defines the mapping from URL to the BackendService. The protocol field in the BackendService must be set to GRPC.</summary>
    [JsonPropertyName("urlMapRef")]
    public V1beta1ComputeTargetGRPCProxySpecUrlMapRef? UrlMapRef { get; set; }

    /// <summary>Immutable. If true, indicates that the BackendServices referenced by the urlMap may be accessed by gRPC applications without using a sidecar proxy. This will enable configuration checks on urlMap and its referenced BackendServices to not allow unsupported features. A gRPC application must use &quot;xds:///&quot; scheme in the target URI of the service it is connecting to. If false, indicates that the BackendServices referenced by the urlMap will be accessed by gRPC applications via a sidecar proxy. In this case, a gRPC application must not use &quot;xds:///&quot; scheme in the target URI of the service it is connecting to.</summary>
    [JsonPropertyName("validateForProxyless")]
    public bool? ValidateForProxyless { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetGRPCProxyStatusConditions
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

/// <summary>ComputeTargetGRPCProxyStatus defines the config connector machine state of ComputeTargetGRPCProxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetGRPCProxyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeTargetGRPCProxyStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking. This field will be ignored when inserting a TargetGrpcProxy. An up-to-date fingerprint must be provided in order to patch/update the TargetGrpcProxy; otherwise, the request will fail with error 412 conditionNotMet. To see the latest fingerprint, make a get() request to retrieve the TargetGrpcProxy. A base64-encoded string.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Server-defined URL with id for the resource.</summary>
    [JsonPropertyName("selfLinkWithId")]
    public string? SelfLinkWithId { get; set; }
}

/// <summary>ComputeTargetGRPCProxy is the Schema for the ComputeTargetGRPCProxy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetGRPCProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeTargetGRPCProxySpec?>, IStatus<V1beta1ComputeTargetGRPCProxyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetGRPCProxy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargetgrpcproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeTargetGRPCProxy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeTargetGRPCProxySpec defines the desired state of ComputeTargetGRPCProxy</summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputeTargetGRPCProxySpec? Spec { get; set; }

    /// <summary>ComputeTargetGRPCProxyStatus defines the config connector machine state of ComputeTargetGRPCProxy</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeTargetGRPCProxyStatus? Status { get; set; }
}