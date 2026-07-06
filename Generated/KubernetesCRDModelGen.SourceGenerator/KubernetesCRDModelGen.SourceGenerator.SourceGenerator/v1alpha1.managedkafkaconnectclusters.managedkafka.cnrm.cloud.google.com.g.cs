#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.managedkafka.cnrm.cloud.google.com;
/// <summary>ManagedKafkaConnectCluster is the Schema for the ManagedKafkaConnectCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedKafkaConnectClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedKafkaConnectCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedKafkaConnectClusterList";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaconnectclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "managedkafka.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedKafkaConnectClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ManagedKafkaConnectCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ManagedKafkaConnectCluster> Items { get; set; }
}

/// <summary>Required. Capacity configuration for the Kafka Connect cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecCapacityConfig
{
    /// <summary>Required. The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between 1:1 and 1:8. Minimum: 3221225472 (3 GiB).</summary>
    [JsonPropertyName("memoryBytes")]
    public required long MemoryBytes { get; set; }

    /// <summary>Required. The number of vCPUs to provision for the cluster. Minimum: 3.</summary>
    [JsonPropertyName("vcpuCount")]
    public required long VcpuCount { get; set; }
}

/// <summary>Required. Reference to the Kafka cluster this Kafka Connect cluster is attached to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecClusterRef
{
    /// <summary>A reference to an externally managed ManagedKafkaCluster resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/clusters/{{clusterID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ManagedKafkaCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ManagedKafkaCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfigNetworkConfigsAdditionalSubnetRefs
{
    /// <summary>A reference to an externally managed ComputeSubnetwork resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/subnetworks/{{subnetworkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Required. VPC subnet to make available to the Kafka Connect cluster.
///  It is used to create a Private Service Connect (PSC) interface for the
///  Kafka Connect workers. It must be located in the same region as the
///  Kafka Connect cluster.
/// 
///  The CIDR range of the subnet must be within the IPv4 address ranges for
///  private networks, as specified in RFC 1918. The primary subnet CIDR range
///  must have a minimum size of /22 (1024 addresses).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfigNetworkConfigsPrimarySubnetRef
{
    /// <summary>A reference to an externally managed ComputeSubnetwork resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/subnetworks/{{subnetworkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfigNetworkConfigs
{
    /// <summary>Optional. Additional subnets may be specified. They may be in another region, but must be in the same VPC network. The Connect workers can communicate with network endpoints in either the primary or additional subnets.</summary>
    [JsonPropertyName("additionalSubnetRefs")]
    public IList<V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfigNetworkConfigsAdditionalSubnetRefs>? AdditionalSubnetRefs { get; set; }

    /// <summary>Optional. Additional DNS domain names from the subnet&apos;s network to be made visible to the Connect Cluster. When using MirrorMaker2, it&apos;s necessary to add the bootstrap address&apos;s dns domain name of the target cluster to make it visible to the connector. For example: my-kafka-cluster.us-central1.managedkafka.my-project.cloud.goog</summary>
    [JsonPropertyName("dnsDomainNames")]
    public IList<string>? DnsDomainNames { get; set; }

    /// <summary>
    /// Required. VPC subnet to make available to the Kafka Connect cluster.
    ///  It is used to create a Private Service Connect (PSC) interface for the
    ///  Kafka Connect workers. It must be located in the same region as the
    ///  Kafka Connect cluster.
    /// 
    ///  The CIDR range of the subnet must be within the IPv4 address ranges for
    ///  private networks, as specified in RFC 1918. The primary subnet CIDR range
    ///  must have a minimum size of /22 (1024 addresses).
    /// </summary>
    [JsonPropertyName("primarySubnetRef")]
    public required V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfigNetworkConfigsPrimarySubnetRef PrimarySubnetRef { get; set; }
}

/// <summary>Required. Access configuration for the Kafka Connect cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfig
{
    /// <summary>Required. Virtual Private Cloud (VPC) networks that must be granted direct access to the Kafka Connect cluster. Minimum of 1 network is required. Maximum 10 networks can be specified.</summary>
    [JsonPropertyName("networkConfigs")]
    public required IList<V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfigNetworkConfigs> NetworkConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecGcpConfigSecretPaths
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Configuration properties for a Kafka Connect cluster deployed to Google Cloud Platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecGcpConfig
{
    /// <summary>Required. Access configuration for the Kafka Connect cluster.</summary>
    [JsonPropertyName("accessConfig")]
    public required V1alpha1ManagedKafkaConnectClusterSpecGcpConfigAccessConfig AccessConfig { get; set; }

    /// <summary>Optional. Secrets to load into workers. Exact SecretVersions from Secret Manager must be provided -- aliases are not supported. Up to 32 secrets may be loaded into one cluster.</summary>
    [JsonPropertyName("secretPaths")]
    public IList<V1alpha1ManagedKafkaConnectClusterSpecGcpConfigSecretPaths>? SecretPaths { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpecProjectRef
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

/// <summary>ManagedKafkaConnectClusterSpec defines the desired state of ManagedKafkaConnectCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterSpec
{
    /// <summary>Required. Capacity configuration for the Kafka Connect cluster.</summary>
    [JsonPropertyName("capacityConfig")]
    public required V1alpha1ManagedKafkaConnectClusterSpecCapacityConfig CapacityConfig { get; set; }

    /// <summary>Required. Reference to the Kafka cluster this Kafka Connect cluster is attached to.</summary>
    [JsonPropertyName("clusterRef")]
    public required V1alpha1ManagedKafkaConnectClusterSpecClusterRef ClusterRef { get; set; }

    /// <summary>Optional. Configurations for the worker that are overridden from the defaults. The key of the map is a Kafka Connect worker property name, for example: `exactly.once.source.support`.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Required. Configuration properties for a Kafka Connect cluster deployed to Google Cloud Platform.</summary>
    [JsonPropertyName("gcpConfig")]
    public required V1alpha1ManagedKafkaConnectClusterSpecGcpConfig GcpConfig { get; set; }

    /// <summary>Optional. Labels as key value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ManagedKafkaConnectClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ManagedKafkaConnectCluster name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterStatusConditions
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
public partial class V1alpha1ManagedKafkaConnectClusterStatusObservedState
{
    /// <summary>Output only. The time when the cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The current state of the cluster.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ManagedKafkaConnectClusterStatus defines the config connector machine state of ManagedKafkaConnectCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConnectClusterStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ManagedKafkaConnectClusterStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ManagedKafkaConnectCluster resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ManagedKafkaConnectClusterStatusObservedState? ObservedState { get; set; }
}

/// <summary>ManagedKafkaConnectCluster is the Schema for the ManagedKafkaConnectCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedKafkaConnectCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedKafkaConnectClusterSpec>, IStatus<V1alpha1ManagedKafkaConnectClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedKafkaConnectCluster";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaconnectclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "managedkafka.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedKafkaConnectCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedKafkaConnectClusterSpec defines the desired state of ManagedKafkaConnectCluster</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ManagedKafkaConnectClusterSpec Spec { get; set; }

    /// <summary>ManagedKafkaConnectClusterStatus defines the config connector machine state of ManagedKafkaConnectCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedKafkaConnectClusterStatus? Status { get; set; }
}