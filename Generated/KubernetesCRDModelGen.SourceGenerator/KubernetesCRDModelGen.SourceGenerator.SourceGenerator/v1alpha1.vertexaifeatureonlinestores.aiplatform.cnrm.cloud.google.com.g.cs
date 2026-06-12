#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aiplatform.cnrm.cloud.google.com;
/// <summary>VertexAIFeatureOnlineStore is the Schema for the VertexAIFeatureOnlineStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeatureOnlineStoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIFeatureOnlineStore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeatureOnlineStoreList";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeatureonlinestores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aiplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIFeatureOnlineStoreList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAIFeatureOnlineStore objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAIFeatureOnlineStore> Items { get; set; }
}

/// <summary>Required. Autoscaling config applied to Bigtable Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecBigtableAutoScaling
{
    /// <summary>Optional. A percentage of the cluster&apos;s CPU capacity. Can be from 10% to 80%. When a cluster&apos;s CPU utilization exceeds the target that you have set, Bigtable immediately adds nodes to the cluster. When CPU utilization is substantially lower than the target, Bigtable removes nodes. If not set will default to 50%.</summary>
    [JsonPropertyName("cpuUtilizationTarget")]
    public int? CpuUtilizationTarget { get; set; }

    /// <summary>Required. The maximum number of nodes to scale up to. Must be greater than or equal to min_node_count, and less than or equal to 10 times of &apos;min_node_count&apos;.</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>Required. The minimum number of nodes to scale down to. Must be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Contains settings for the Cloud Bigtable instance that will be created to serve featureValues for all FeatureViews under this FeatureOnlineStore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecBigtable
{
    /// <summary>Required. Autoscaling config applied to Bigtable Instance.</summary>
    [JsonPropertyName("autoScaling")]
    public V1alpha1VertexAIFeatureOnlineStoreSpecBigtableAutoScaling? AutoScaling { get; set; }
}

/// <summary>Required. The full name of the Google Compute Engine [network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/get): `projects/{project}/global/networks/{network}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpointPrivateServiceConnectConfigPscAutomationConfigsNetworkRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpointPrivateServiceConnectConfigPscAutomationConfigs
{
    /// <summary>Required. The full name of the Google Compute Engine [network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/get): `projects/{project}/global/networks/{network}`.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpointPrivateServiceConnectConfigPscAutomationConfigsNetworkRef? NetworkRef { get; set; }

    /// <summary>Required. Project id used to create forwarding rule.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>Optional. Private service connect config. The private service connection is available only for Optimized storage type, not for embedding management now. If [PrivateServiceConnectConfig.enable_private_service_connect][google.cloud.aiplatform.v1.PrivateServiceConnectConfig.enable_private_service_connect] set to true, customers will use private service connection to send request. Otherwise, the connection will set to public endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpointPrivateServiceConnectConfig
{
    /// <summary>Required. If true, expose the IndexEndpoint via private service connect.</summary>
    [JsonPropertyName("enablePrivateServiceConnect")]
    public bool? EnablePrivateServiceConnect { get; set; }

    /// <summary>A list of Projects from which the forwarding rule will target the service attachment.</summary>
    [JsonPropertyName("projectAllowlist")]
    public IList<string>? ProjectAllowlist { get; set; }

    /// <summary>Optional. List of projects and networks where the PSC endpoints will be created. This field is used by Online Inference(Prediction) only.</summary>
    [JsonPropertyName("pscAutomationConfigs")]
    public IList<V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpointPrivateServiceConnectConfigPscAutomationConfigs>? PscAutomationConfigs { get; set; }
}

/// <summary>Optional. The dedicated serving endpoint for this FeatureOnlineStore, which is different from common Vertex service endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpoint
{
    /// <summary>Optional. Private service connect config. The private service connection is available only for Optimized storage type, not for embedding management now. If [PrivateServiceConnectConfig.enable_private_service_connect][google.cloud.aiplatform.v1.PrivateServiceConnectConfig.enable_private_service_connect] set to true, customers will use private service connection to send request. Otherwise, the connection will set to public endpoint.</summary>
    [JsonPropertyName("privateServiceConnectConfig")]
    public V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpointPrivateServiceConnectConfig? PrivateServiceConnectConfig { get; set; }
}

/// <summary>Optional. Customer-managed encryption key spec for data storage. If set, online store will be secured by this key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpecProjectRef
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

/// <summary>VertexAIFeatureOnlineStoreSpec defines the desired state of VertexAIFeatureOnlineStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreSpec
{
    /// <summary>Contains settings for the Cloud Bigtable instance that will be created to serve featureValues for all FeatureViews under this FeatureOnlineStore.</summary>
    [JsonPropertyName("bigtable")]
    public V1alpha1VertexAIFeatureOnlineStoreSpecBigtable? Bigtable { get; set; }

    /// <summary>Optional. The dedicated serving endpoint for this FeatureOnlineStore, which is different from common Vertex service endpoint.</summary>
    [JsonPropertyName("dedicatedServingEndpoint")]
    public V1alpha1VertexAIFeatureOnlineStoreSpecDedicatedServingEndpoint? DedicatedServingEndpoint { get; set; }

    /// <summary>Optional. Customer-managed encryption key spec for data storage. If set, online store will be secured by this key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAIFeatureOnlineStoreSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>Optional. The labels with user-defined metadata to organize your FeatureOnlineStore.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Contains settings for the Optimized store that will be created to serve featureValues for all FeatureViews under this FeatureOnlineStore. When choose Optimized storage type, need to set [PrivateServiceConnectConfig.enable_private_service_connect][google.cloud.aiplatform.v1.PrivateServiceConnectConfig.enable_private_service_connect] to use private endpoint. Otherwise will use public endpoint by default.</summary>
    [JsonPropertyName("optimized")]
    public JsonNode? Optimized { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VertexAIFeatureOnlineStoreSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VertexAIFeatureOnlineStore name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreStatusConditions
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
public partial class V1alpha1VertexAIFeatureOnlineStoreStatusObservedState
{
    /// <summary>Output only. Timestamp when this FeatureOnlineStore was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Used to perform consistent read-modify-write updates. If not set, a blind &quot;overwrite&quot; update happens.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzi")]
    public bool? SatisfiesPzi { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzs")]
    public bool? SatisfiesPzs { get; set; }

    /// <summary>Output only. State of the featureOnlineStore.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Timestamp when this FeatureOnlineStore was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAIFeatureOnlineStoreStatus defines the config connector machine state of VertexAIFeatureOnlineStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureOnlineStoreStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIFeatureOnlineStoreStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIFeatureOnlineStore resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIFeatureOnlineStoreStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIFeatureOnlineStore is the Schema for the VertexAIFeatureOnlineStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeatureOnlineStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIFeatureOnlineStoreSpec>, IStatus<V1alpha1VertexAIFeatureOnlineStoreStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeatureOnlineStore";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeatureonlinestores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aiplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIFeatureOnlineStore";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIFeatureOnlineStoreSpec defines the desired state of VertexAIFeatureOnlineStore</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAIFeatureOnlineStoreSpec Spec { get; set; }

    /// <summary>VertexAIFeatureOnlineStoreStatus defines the config connector machine state of VertexAIFeatureOnlineStore</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIFeatureOnlineStoreStatus? Status { get; set; }
}