#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
/// <summary>DataprocSessionTemplate is the Schema for the DataprocSessionTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocSessionTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataprocSessionTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocSessionTemplateList";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocsessiontemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataprocSessionTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataprocSessionTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataprocSessionTemplate> Items { get; set; }
}

/// <summary>Optional. The Cloud KMS key to use for encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfigKmsKeyRef
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

/// <summary>Optional. Service account that used to execute workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfigServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A Cloud Storage bucket used to stage workload dependencies, config files, and store workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running, and then create and manage project-level, per-location staging and temporary buckets. **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfigStagingBucketRef
{
    /// <summary>A reference to an externally-managed StorageBucket resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a StorageBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a StorageBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Execution configuration for a workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfig
{
    /// <summary>Optional. Applies to sessions only. The duration to keep the session alive while it&apos;s idling. Exceeding this threshold causes the session to terminate. This field cannot be set on a batch workload. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). Defaults to 1 hour if not set. If both `ttl` and `idle_ttl` are specified for an interactive session, the conditions are treated as `OR` conditions: the workload will be terminated when it has been idle for `idle_ttl` or when `ttl` has been exceeded, whichever occurs first.</summary>
    [JsonPropertyName("idleTTL")]
    public string? IdleTTL { get; set; }

    /// <summary>Optional. The Cloud KMS key to use for encryption.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Optional. Tags used for network traffic control.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Optional. Network URI to connect workload to.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Optional. Service account that used to execute workload.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. A Cloud Storage bucket used to stage workload dependencies, config files, and store workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running, and then create and manage project-level, per-location staging and temporary buckets. **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**</summary>
    [JsonPropertyName("stagingBucketRef")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfigStagingBucketRef? StagingBucketRef { get; set; }

    /// <summary>Optional. Subnetwork URI to connect workload to.</summary>
    [JsonPropertyName("subnetworkURI")]
    public string? SubnetworkURI { get; set; }

    /// <summary>Optional. The duration after which the workload will be terminated, specified as the JSON representation for [Duration](https://protobuf.dev/programming-guides/proto3/#json). When the workload exceeds this duration, it will be unconditionally terminated without waiting for ongoing work to finish. If `ttl` is not specified for a batch workload, the workload will be allowed to run until it exits naturally (or run forever without exiting). If `ttl` is not specified for an interactive session, it defaults to 24 hours. If `ttl` is not specified for a batch that uses 2.1+ runtime version, it defaults to 4 hours. Minimum value is 10 minutes; maximum value is 14 days. If both `ttl` and `idle_ttl` are specified (for an interactive session), the conditions are treated as `OR` conditions: the workload will be terminated when it has been idle for `idle_ttl` or when `ttl` has been exceeded, whichever occurs first.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>
/// Optional. Resource name of an existing Dataproc Cluster to act as a Spark
///  History Server for the workload.
/// 
///  Example:
/// 
///  * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>A reference to an externally managed DataprocCluster resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/clusters/{{clusterName}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataprocCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataprocCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfig
{
    /// <summary>
    /// Optional. Resource name of an existing Dataproc Cluster to act as a Spark
    ///  History Server for the workload.
    /// 
    ///  Example:
    /// 
    ///  * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`
    /// </summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }
}

/// <summary>Optional. Peripherals configuration that workload has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfigPeripheralsConfig
{
    /// <summary>
    /// Optional. Resource name of an existing Dataproc Metastore service.
    /// 
    ///  Example:
    /// 
    ///  * `projects/[project_id]/locations/[region]/services/[service_id]`
    /// </summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }

    /// <summary>Optional. The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>Optional. Environment configuration for session execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecEnvironmentConfig
{
    /// <summary>Optional. Execution configuration for a workload.</summary>
    [JsonPropertyName("executionConfig")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigExecutionConfig? ExecutionConfig { get; set; }

    /// <summary>Optional. Peripherals configuration that workload has access to.</summary>
    [JsonPropertyName("peripheralsConfig")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfigPeripheralsConfig? PeripheralsConfig { get; set; }
}

/// <summary>Optional. Jupyter session config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecJupyterSession
{
    /// <summary>Optional. Display name, shown in the Jupyter kernelspec card.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Kernel</summary>
    [JsonPropertyName("kernel")]
    public string? Kernel { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecProjectRef
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

/// <summary>Optional. Autotuning configuration of the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecRuntimeConfigAutotuningConfig
{
    /// <summary>Optional. Scenarios for which tunings are applied.</summary>
    [JsonPropertyName("scenarios")]
    public IList<string>? Scenarios { get; set; }
}

/// <summary>Optional. Configuration for PyPi repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecRuntimeConfigRepositoryConfigPypiRepositoryConfig
{
    /// <summary>Optional. PyPi repository address</summary>
    [JsonPropertyName("pypiRepository")]
    public string? PypiRepository { get; set; }
}

/// <summary>Optional. Dependency repository configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecRuntimeConfigRepositoryConfig
{
    /// <summary>Optional. Configuration for PyPi repository.</summary>
    [JsonPropertyName("pypiRepositoryConfig")]
    public V1alpha1DataprocSessionTemplateSpecRuntimeConfigRepositoryConfigPypiRepositoryConfig? PypiRepositoryConfig { get; set; }
}

/// <summary>Optional. Runtime configuration for session execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpecRuntimeConfig
{
    /// <summary>Optional. Autotuning configuration of the workload.</summary>
    [JsonPropertyName("autotuningConfig")]
    public V1alpha1DataprocSessionTemplateSpecRuntimeConfigAutotuningConfig? AutotuningConfig { get; set; }

    /// <summary>Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.</summary>
    [JsonPropertyName("cohort")]
    public string? Cohort { get; set; }

    /// <summary>Optional. Optional custom container image for the job runtime environment. If not specified, a default container image will be used.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>Optional. A mapping of property names to values, which are used to configure workload execution.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. Dependency repository configuration.</summary>
    [JsonPropertyName("repositoryConfig")]
    public V1alpha1DataprocSessionTemplateSpecRuntimeConfigRepositoryConfig? RepositoryConfig { get; set; }

    /// <summary>Optional. Version of the batch runtime.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>DataprocSessionTemplateSpec defines the desired state of DataprocSessionTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateSpec
{
    /// <summary>Optional. Brief description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Environment configuration for session execution.</summary>
    [JsonPropertyName("environmentConfig")]
    public V1alpha1DataprocSessionTemplateSpecEnvironmentConfig? EnvironmentConfig { get; set; }

    /// <summary>Optional. Jupyter session config.</summary>
    [JsonPropertyName("jupyterSession")]
    public V1alpha1DataprocSessionTemplateSpecJupyterSession? JupyterSession { get; set; }

    /// <summary>Optional. Labels to associate with sessions created using this template. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** can be empty, but, if present, must contain 1 to 63 characters and conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a session.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataprocSessionTemplateSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataprocSessionTemplate name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Runtime configuration for session execution.</summary>
    [JsonPropertyName("runtimeConfig")]
    public V1alpha1DataprocSessionTemplateSpecRuntimeConfig? RuntimeConfig { get; set; }

    /// <summary>Optional. Spark Connect session config.</summary>
    [JsonPropertyName("sparkConnectSession")]
    public JsonNode? SparkConnectSession { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateStatusConditions
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
public partial class V1alpha1DataprocSessionTemplateStatusObservedState
{
    /// <summary>Output only. The time when the template was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The email address of the user who created the template.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. The time the template was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. A session template UUID (Unique Universal Identifier). The service generates this value when it creates the session template.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>DataprocSessionTemplateStatus defines the config connector machine state of DataprocSessionTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionTemplateStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataprocSessionTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataprocSessionTemplate resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataprocSessionTemplateStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataprocSessionTemplate is the Schema for the DataprocSessionTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocSessionTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataprocSessionTemplateSpec>, IStatus<V1alpha1DataprocSessionTemplateStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocSessionTemplate";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocsessiontemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataprocSessionTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataprocSessionTemplateSpec defines the desired state of DataprocSessionTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataprocSessionTemplateSpec Spec { get; set; }

    /// <summary>DataprocSessionTemplateStatus defines the config connector machine state of DataprocSessionTemplate</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataprocSessionTemplateStatus? Status { get; set; }
}