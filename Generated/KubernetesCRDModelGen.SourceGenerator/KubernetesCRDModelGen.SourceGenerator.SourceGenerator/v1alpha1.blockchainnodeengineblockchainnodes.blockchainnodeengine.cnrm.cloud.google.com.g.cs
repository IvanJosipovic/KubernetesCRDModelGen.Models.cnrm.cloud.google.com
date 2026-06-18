#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.blockchainnodeengine.cnrm.cloud.google.com;
/// <summary>BlockchainNodeEngineBlockchainNode is the Schema for the BlockchainNodeEngineBlockchainNode API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BlockchainNodeEngineBlockchainNode>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BlockchainNodeEngineBlockchainNodeList";
    public const string KubeGroup = "blockchainnodeengine.cnrm.cloud.google.com";
    public const string KubePluralName = "blockchainnodeengineblockchainnodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "blockchainnodeengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BlockchainNodeEngineBlockchainNodeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BlockchainNodeEngineBlockchainNode objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BlockchainNodeEngineBlockchainNode> Items { get; set; }
}

/// <summary>Immutable. The blockchain type of the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BlockchainNodeEngineBlockchainNodeSpecBlockchainTypeEnum>))]
public enum V1alpha1BlockchainNodeEngineBlockchainNodeSpecBlockchainTypeEnum
{
    [EnumMember(Value = "ETHEREUM"), JsonStringEnumMemberName("ETHEREUM")]
    ETHEREUM
}

/// <summary>Details for the Geth execution client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeSpecEthereumDetailsGethDetails
{
    /// <summary>Immutable. Blockchain garbage collection mode.</summary>
    [JsonPropertyName("garbageCollectionMode")]
    public string? GarbageCollectionMode { get; set; }
}

/// <summary>Configuration for validator-related parameters on the beacon client, and for any GCP-managed validator client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeSpecEthereumDetailsValidatorConfig
{
    /// <summary>
    /// An Ethereum address which the beacon client will send fee rewards to if
    ///  no recipient is configured in the validator client.
    /// 
    ///  See https://lighthouse-book.sigmaprime.io/suggested-fee-recipient.html
    ///  or https://docs.prylabs.network/docs/execution-node/fee-recipient for
    ///  examples of how this is used.
    /// 
    ///  Note that while this is often described as &quot;suggested&quot;, as we run the
    ///  execution node we can trust the execution node, and therefore this is
    ///  considered enforced.
    /// </summary>
    [JsonPropertyName("beaconFeeRecipient")]
    public string? BeaconFeeRecipient { get; set; }

    /// <summary>Immutable. When true, deploys a GCP-managed validator client alongside the beacon client.</summary>
    [JsonPropertyName("managedValidatorClient")]
    public bool? ManagedValidatorClient { get; set; }

    /// <summary>URLs for MEV-relay services to use for block building. When set, a GCP-managed MEV-boost service is configured on the beacon client.</summary>
    [JsonPropertyName("mevRelayURLs")]
    public IList<string>? MevRelayURLs { get; set; }
}

/// <summary>Ethereum-specific blockchain node details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeSpecEthereumDetails
{
    /// <summary>Immutable. Enables JSON-RPC access to functions in the `admin` namespace. Defaults to `false`.</summary>
    [JsonPropertyName("apiEnableAdmin")]
    public bool? ApiEnableAdmin { get; set; }

    /// <summary>Immutable. Enables JSON-RPC access to functions in the `debug` namespace. Defaults to `false`.</summary>
    [JsonPropertyName("apiEnableDebug")]
    public bool? ApiEnableDebug { get; set; }

    /// <summary>Immutable. The consensus client.</summary>
    [JsonPropertyName("consensusClient")]
    public string? ConsensusClient { get; set; }

    /// <summary>Immutable. The execution client</summary>
    [JsonPropertyName("executionClient")]
    public string? ExecutionClient { get; set; }

    /// <summary>Details for the Geth execution client.</summary>
    [JsonPropertyName("gethDetails")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeSpecEthereumDetailsGethDetails? GethDetails { get; set; }

    /// <summary>Immutable. The Ethereum environment being accessed.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Immutable. The type of Ethereum node.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Configuration for validator-related parameters on the beacon client, and for any GCP-managed validator client.</summary>
    [JsonPropertyName("validatorConfig")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeSpecEthereumDetailsValidatorConfig? ValidatorConfig { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeSpecProjectRef
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

/// <summary>BlockchainNodeEngineBlockchainNodeSpec defines the desired state of BlockchainNodeEngineBlockchainNode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeSpec
{
    /// <summary>Immutable. The blockchain type of the node.</summary>
    [JsonPropertyName("blockchainType")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeSpecBlockchainTypeEnum? BlockchainType { get; set; }

    /// <summary>Ethereum-specific blockchain node details.</summary>
    [JsonPropertyName("ethereumDetails")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeSpecEthereumDetails? EthereumDetails { get; set; }

    /// <summary>User-provided key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. When true, the node is only accessible via Private Service Connect; no public endpoints are exposed. Otherwise, the node is only accessible via public endpoints. Warning: These nodes are deprecated, please use public endpoints instead.</summary>
    [JsonPropertyName("privateServiceConnectEnabled")]
    public bool? PrivateServiceConnectEnabled { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BlockchainNodeEngineBlockchainNodeSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The BlockchainNode name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatusConditions
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

/// <summary>Output only. The endpoint information through which to interact with a blockchain node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateConnectionInfoEndpointInfo
{
    /// <summary>Output only. The assigned URL for the node JSON-RPC API endpoint.</summary>
    [JsonPropertyName("jsonRpcAPIEndpoint")]
    public string? JsonRpcAPIEndpoint { get; set; }

    /// <summary>Output only. The assigned URL for the node WebSockets API endpoint.</summary>
    [JsonPropertyName("websocketsAPIEndpoint")]
    public string? WebsocketsAPIEndpoint { get; set; }
}

/// <summary>Output only. The connection information used to interact with a blockchain node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateConnectionInfo
{
    /// <summary>Output only. The endpoint information through which to interact with a blockchain node.</summary>
    [JsonPropertyName("endpointInfo")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateConnectionInfoEndpointInfo? EndpointInfo { get; set; }

    /// <summary>Output only. A service attachment that exposes a node, and has the following format: projects/{project}/regions/{region}/serviceAttachments/{service_attachment_name}</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

/// <summary>Output only. Ethereum-specific endpoint information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateEthereumDetailsAdditionalEndpoints
{
    /// <summary>Output only. The assigned URL for the node&apos;s Beacon API endpoint.</summary>
    [JsonPropertyName("beaconAPIEndpoint")]
    public string? BeaconAPIEndpoint { get; set; }

    /// <summary>Output only. The assigned URL for the node&apos;s Beacon Prometheus metrics endpoint. See [Prometheus Metrics](https://lighthouse-book.sigmaprime.io/advanced_metrics.html) for more details.</summary>
    [JsonPropertyName("beaconPrometheusMetricsAPIEndpoint")]
    public string? BeaconPrometheusMetricsAPIEndpoint { get; set; }

    /// <summary>Output only. The assigned URL for the node&apos;s execution client&apos;s Prometheus metrics endpoint.</summary>
    [JsonPropertyName("executionClientPrometheusMetricsAPIEndpoint")]
    public string? ExecutionClientPrometheusMetricsAPIEndpoint { get; set; }
}

/// <summary>Ethereum-specific blockchain node details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateEthereumDetails
{
    /// <summary>Output only. Ethereum-specific endpoint information.</summary>
    [JsonPropertyName("additionalEndpoints")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateEthereumDetailsAdditionalEndpoints? AdditionalEndpoints { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedState
{
    /// <summary>Output only. The connection information used to interact with a blockchain node.</summary>
    [JsonPropertyName("connectionInfo")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateConnectionInfo? ConnectionInfo { get; set; }

    /// <summary>Output only. The timestamp at which the blockchain node was first created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Ethereum-specific blockchain node details.</summary>
    [JsonPropertyName("ethereumDetails")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedStateEthereumDetails? EthereumDetails { get; set; }

    /// <summary>Output only. The fully qualified name of the blockchain node. e.g. `projects/my-project/locations/us-central1/blockchainNodes/my-node`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. A status representing the state of the node.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The timestamp at which the blockchain node was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BlockchainNodeEngineBlockchainNodeStatus defines the config connector machine state of BlockchainNodeEngineBlockchainNode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BlockchainNodeEngineBlockchainNodeStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BlockchainNodeEngineBlockchainNodeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BlockchainNodeEngineBlockchainNode resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeStatusObservedState? ObservedState { get; set; }
}

/// <summary>BlockchainNodeEngineBlockchainNode is the Schema for the BlockchainNodeEngineBlockchainNode API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BlockchainNodeEngineBlockchainNode : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BlockchainNodeEngineBlockchainNodeSpec>, IStatus<V1alpha1BlockchainNodeEngineBlockchainNodeStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BlockchainNodeEngineBlockchainNode";
    public const string KubeGroup = "blockchainnodeengine.cnrm.cloud.google.com";
    public const string KubePluralName = "blockchainnodeengineblockchainnodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "blockchainnodeengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BlockchainNodeEngineBlockchainNode";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BlockchainNodeEngineBlockchainNodeSpec defines the desired state of BlockchainNodeEngineBlockchainNode</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BlockchainNodeEngineBlockchainNodeSpec Spec { get; set; }

    /// <summary>BlockchainNodeEngineBlockchainNodeStatus defines the config connector machine state of BlockchainNodeEngineBlockchainNode</summary>
    [JsonPropertyName("status")]
    public V1alpha1BlockchainNodeEngineBlockchainNodeStatus? Status { get; set; }
}