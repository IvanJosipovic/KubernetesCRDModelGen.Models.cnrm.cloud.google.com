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
/// <summary>ComputeNetworkPeering is the Schema for the compute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNetworkPeeringList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeNetworkPeering>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNetworkPeeringList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeNetworkPeeringList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeNetworkPeering objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeNetworkPeering> Items { get; set; }
}

/// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkPeeringSpecNetworkRef
{
    /// <summary>A reference to an externally managed ComputeNetwork resource. Should be in the format &quot;projects/{{projectID}}/global/networks/{{networkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkPeeringSpecPeerNetworkRef
{
    /// <summary>A reference to an externally managed ComputeNetwork resource. Should be in the format &quot;projects/{{projectID}}/global/networks/{{networkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ComputeNetworkPeeringSpec defines the desired state of ComputeNetworkPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkPeeringSpec
{
    /// <summary>Whether to export the custom routes to the peer network. Defaults to false.</summary>
    [JsonPropertyName("exportCustomRoutes")]
    public bool? ExportCustomRoutes { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("exportSubnetRoutesWithPublicIp")]
    public bool? ExportSubnetRoutesWithPublicIp { get; set; }

    /// <summary>Whether to export the custom routes from the peer network. Defaults to false.</summary>
    [JsonPropertyName("importCustomRoutes")]
    public bool? ImportCustomRoutes { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("importSubnetRoutesWithPublicIp")]
    public bool? ImportSubnetRoutesWithPublicIp { get; set; }

    /// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
    [JsonPropertyName("networkRef")]
    public required V1beta1ComputeNetworkPeeringSpecNetworkRef NetworkRef { get; set; }

    /// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
    [JsonPropertyName("peerNetworkRef")]
    public required V1beta1ComputeNetworkPeeringSpecPeerNetworkRef PeerNetworkRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&quot;IPV4_ONLY&quot;, &quot;IPV4_IPV6&quot;].</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkPeeringStatusConditions
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

/// <summary>ComputeNetworkPeeringStatus defines the config connector machine state of ComputeNetworkPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkPeeringStatus
{
    /// <summary>Conditions represent the latest available observations of the ComputeNetworkPeering&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeNetworkPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&apos;s a matching configuration in the peer network.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Details about the current state of the peering.</summary>
    [JsonPropertyName("stateDetails")]
    public string? StateDetails { get; set; }
}

/// <summary>ComputeNetworkPeering is the Schema for the compute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeNetworkPeeringSpec>, IStatus<V1beta1ComputeNetworkPeeringStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNetworkPeering";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeNetworkPeering";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeNetworkPeeringSpec defines the desired state of ComputeNetworkPeering</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeNetworkPeeringSpec Spec { get; set; }

    /// <summary>ComputeNetworkPeeringStatus defines the config connector machine state of ComputeNetworkPeering</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeNetworkPeeringStatus? Status { get; set; }
}