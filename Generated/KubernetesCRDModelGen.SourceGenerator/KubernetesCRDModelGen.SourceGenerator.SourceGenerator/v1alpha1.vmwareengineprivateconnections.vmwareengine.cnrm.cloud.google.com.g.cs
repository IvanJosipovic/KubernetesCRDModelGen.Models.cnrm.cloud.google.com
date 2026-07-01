#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vmwareengine.cnrm.cloud.google.com;
/// <summary>VMwareEnginePrivateConnection is the Schema for the VMwareEnginePrivateConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEnginePrivateConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VMwareEnginePrivateConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEnginePrivateConnectionList";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineprivateconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vmwareengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VMwareEnginePrivateConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VMwareEnginePrivateConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VMwareEnginePrivateConnection> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateConnectionSpecProjectRef
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

/// <summary>Optional. Routing Mode. Default value is set to GLOBAL. For type = PRIVATE_SERVICE_ACCESS, this field can be set to GLOBAL or REGIONAL, for other types only GLOBAL is supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VMwareEnginePrivateConnectionSpecRoutingModeEnum>))]
public enum V1alpha1VMwareEnginePrivateConnectionSpecRoutingModeEnum
{
    [EnumMember(Value = "GLOBAL"), JsonStringEnumMemberName("GLOBAL")]
    GLOBAL,
    [EnumMember(Value = "REGIONAL"), JsonStringEnumMemberName("REGIONAL")]
    REGIONAL
}

/// <summary>Required. Reference to the service network to create private connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateConnectionSpecServiceNetworkRef
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

/// <summary>Required. Private connection type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VMwareEnginePrivateConnectionSpecTypeEnum>))]
public enum V1alpha1VMwareEnginePrivateConnectionSpecTypeEnum
{
    [EnumMember(Value = "PRIVATE_SERVICE_ACCESS"), JsonStringEnumMemberName("PRIVATE_SERVICE_ACCESS")]
    PRIVATESERVICEACCESS,
    [EnumMember(Value = "NETAPP_CLOUD_VOLUME"), JsonStringEnumMemberName("NETAPP_CLOUD_VOLUME")]
    NETAPPCLOUDVOLUME,
    [EnumMember(Value = "DELL_POWERSCALE"), JsonStringEnumMemberName("DELL_POWERSCALE")]
    DELLPOWERSCALE,
    [EnumMember(Value = "THIRD_PARTY_SERVICE"), JsonStringEnumMemberName("THIRD_PARTY_SERVICE")]
    THIRDPARTYSERVICE
}

/// <summary>Required. Reference to the VMware Engine network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateConnectionSpecVmwareEngineNetworkRef
{
    /// <summary>A reference to an externally managed VMwareEngineNetwork resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/vmwareEngineNetworks/{{vmwareenginenetworkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>VMwareEnginePrivateConnectionSpec defines the desired state of VMwareEnginePrivateConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateConnectionSpec
{
    /// <summary>Optional. User-provided description for this private connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VMwareEnginePrivateConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VMwareEnginePrivateConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Routing Mode. Default value is set to GLOBAL. For type = PRIVATE_SERVICE_ACCESS, this field can be set to GLOBAL or REGIONAL, for other types only GLOBAL is supported.</summary>
    [JsonPropertyName("routingMode")]
    public V1alpha1VMwareEnginePrivateConnectionSpecRoutingModeEnum? RoutingMode { get; set; }

    /// <summary>Required. Reference to the service network to create private connection.</summary>
    [JsonPropertyName("serviceNetworkRef")]
    public required V1alpha1VMwareEnginePrivateConnectionSpecServiceNetworkRef ServiceNetworkRef { get; set; }

    /// <summary>Required. Private connection type.</summary>
    [JsonPropertyName("type")]
    public required V1alpha1VMwareEnginePrivateConnectionSpecTypeEnum Type { get; set; }

    /// <summary>Required. Reference to the VMware Engine network.</summary>
    [JsonPropertyName("vmwareEngineNetworkRef")]
    public required V1alpha1VMwareEnginePrivateConnectionSpecVmwareEngineNetworkRef VmwareEngineNetworkRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateConnectionStatusConditions
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
public partial class V1alpha1VMwareEnginePrivateConnectionStatusObservedState
{
    /// <summary>Output only. Creation time of this resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. VPC network peering id between given network VPC and VMwareEngineNetwork.</summary>
    [JsonPropertyName("peeringID")]
    public string? PeeringID { get; set; }

    /// <summary>Output only. Peering state between service network and VMware Engine network.</summary>
    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    /// <summary>Output only. State of the private connection.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-generated unique identifier for the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Last update time of this resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The canonical name of the VMware Engine network in the form: `projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}`</summary>
    [JsonPropertyName("vmwareEngineNetworkCanonical")]
    public string? VmwareEngineNetworkCanonical { get; set; }
}

/// <summary>VMwareEnginePrivateConnectionStatus defines the config connector machine state of VMwareEnginePrivateConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VMwareEnginePrivateConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VMwareEnginePrivateConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VMwareEnginePrivateConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>VMwareEnginePrivateConnection is the Schema for the VMwareEnginePrivateConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEnginePrivateConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VMwareEnginePrivateConnectionSpec>, IStatus<V1alpha1VMwareEnginePrivateConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEnginePrivateConnection";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineprivateconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vmwareengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VMwareEnginePrivateConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VMwareEnginePrivateConnectionSpec defines the desired state of VMwareEnginePrivateConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VMwareEnginePrivateConnectionSpec Spec { get; set; }

    /// <summary>VMwareEnginePrivateConnectionStatus defines the config connector machine state of VMwareEnginePrivateConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1VMwareEnginePrivateConnectionStatus? Status { get; set; }
}