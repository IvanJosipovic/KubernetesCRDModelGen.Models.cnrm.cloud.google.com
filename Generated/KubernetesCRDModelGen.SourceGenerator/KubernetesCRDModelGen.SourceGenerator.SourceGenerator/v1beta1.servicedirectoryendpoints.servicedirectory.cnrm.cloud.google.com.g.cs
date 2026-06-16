#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicedirectory.cnrm.cloud.google.com;
/// <summary>ServiceDirectoryEndpoint is the Schema for the ServiceDirectoryEndpoint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceDirectoryEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServiceDirectoryEndpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceDirectoryEndpointList";
    public const string KubeGroup = "servicedirectory.cnrm.cloud.google.com";
    public const string KubePluralName = "servicedirectoryendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicedirectory.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceDirectoryEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ServiceDirectoryEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ServiceDirectoryEndpoint> Items { get; set; }
}

/// <summary>Optional. The ComputeAddress resource whose IP address this endpoint uses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceDirectoryEndpointSpecAddressRef
{
    /// <summary>A reference to an externally managed ComputeAddress resource. Should be in the format &quot;projects/{{projectID}}/global/addresses/{{addressID}}&quot; or &quot;projects/{{projectID}}/regions/{{region}}/addresses/{{addressID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeAddress resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeAddress resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The ComputeNetwork resource representing the GCE network of this endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceDirectoryEndpointSpecNetworkRef
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

/// <summary>Required. The ServiceDirectoryService that this endpoint belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceDirectoryEndpointSpecServiceRef
{
    /// <summary>A reference to an externally managed ServiceDirectoryService resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/namespaces/{{namespaceID}}/services/{{serviceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ServiceDirectoryService resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ServiceDirectoryService resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ServiceDirectoryEndpointSpec defines the desired state of ServiceDirectoryEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceDirectoryEndpointSpec
{
    /// <summary>Optional. The ComputeAddress resource whose IP address this endpoint uses.</summary>
    [JsonPropertyName("addressRef")]
    public V1beta1ServiceDirectoryEndpointSpecAddressRef? AddressRef { get; set; }

    /// <summary>Optional. The ComputeNetwork resource representing the GCE network of this endpoint.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ServiceDirectoryEndpointSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. Port that the endpoint is running on, must be in the range of [0, 65535]. If unspecified, the default is 0.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Immutable. Optional. The endpointId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The ServiceDirectoryService that this endpoint belongs to.</summary>
    [JsonPropertyName("serviceRef")]
    public required V1beta1ServiceDirectoryEndpointSpecServiceRef ServiceRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceDirectoryEndpointStatusConditions
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

/// <summary>ServiceDirectoryEndpointStatus defines the config connector machine state of ServiceDirectoryEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceDirectoryEndpointStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceDirectoryEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name for the endpoint in the format &apos;projects/*/locations/*/namespaces/*/services/*/endpoints/*&apos;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ServiceDirectoryEndpoint is the Schema for the ServiceDirectoryEndpoint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceDirectoryEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceDirectoryEndpointSpec>, IStatus<V1beta1ServiceDirectoryEndpointStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceDirectoryEndpoint";
    public const string KubeGroup = "servicedirectory.cnrm.cloud.google.com";
    public const string KubePluralName = "servicedirectoryendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicedirectory.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceDirectoryEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceDirectoryEndpointSpec defines the desired state of ServiceDirectoryEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ServiceDirectoryEndpointSpec Spec { get; set; }

    /// <summary>ServiceDirectoryEndpointStatus defines the config connector machine state of ServiceDirectoryEndpoint</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceDirectoryEndpointStatus? Status { get; set; }
}