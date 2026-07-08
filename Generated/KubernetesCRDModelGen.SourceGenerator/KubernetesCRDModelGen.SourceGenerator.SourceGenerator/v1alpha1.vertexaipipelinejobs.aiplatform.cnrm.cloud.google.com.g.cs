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
/// <summary>VertexAIPipelineJob is the Schema for the VertexAIPipelineJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIPipelineJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIPipelineJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIPipelineJobList";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaipipelinejobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aiplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIPipelineJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAIPipelineJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAIPipelineJob> Items { get; set; }
}

/// <summary>Customer-managed encryption key spec for a pipelineJob. If set, this PipelineJob and all of its sub-resources will be secured by this key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Reference to a ComputeNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecNetworkRef
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

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecProjectRef
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

/// <summary>Required. The VPC network name in the target_project where the DNS zone specified by &apos;domain&apos; is visible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRef
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
public partial class V1alpha1VertexAIPipelineJobSpecPscInterfaceConfigDnsPeeringConfigs
{
    /// <summary>Required. The DNS name suffix of the zone being peered to, e.g., &quot;my-internal-domain.corp.&quot;. Must end with a dot.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Required. The VPC network name in the target_project where the DNS zone specified by &apos;domain&apos; is visible.</summary>
    [JsonPropertyName("targetNetworkRef")]
    public V1alpha1VertexAIPipelineJobSpecPscInterfaceConfigDnsPeeringConfigsTargetNetworkRef? TargetNetworkRef { get; set; }

    /// <summary>Required. The project ID hosting the Cloud DNS managed zone that contains the &apos;domain&apos;.</summary>
    [JsonPropertyName("targetProject")]
    public string? TargetProject { get; set; }
}

/// <summary>Optional. The name of the Compute Engine network attachment to attach to the resource within the region and user project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecPscInterfaceConfigNetworkAttachmentRef
{
    /// <summary>A reference to an externally managed ComputeNetworkAttachment resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/networkAttachments/{{networkattachmentID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetworkAttachment resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetworkAttachment resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for PSC-I for PipelineJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecPscInterfaceConfig
{
    /// <summary>Optional. DNS peering configurations.</summary>
    [JsonPropertyName("dnsPeeringConfigs")]
    public IList<V1alpha1VertexAIPipelineJobSpecPscInterfaceConfigDnsPeeringConfigs>? DnsPeeringConfigs { get; set; }

    /// <summary>Optional. The name of the Compute Engine network attachment to attach to the resource within the region and user project.</summary>
    [JsonPropertyName("networkAttachmentRef")]
    public V1alpha1VertexAIPipelineJobSpecPscInterfaceConfigNetworkAttachmentRef? NetworkAttachmentRef { get; set; }
}

/// <summary>Runtime config of the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecRuntimeConfig
{
    /// <summary>Represents the failure policy of a pipeline.</summary>
    [JsonPropertyName("failurePolicy")]
    public string? FailurePolicy { get; set; }

    /// <summary>Required. A path in a Cloud Storage bucket, which will be treated as the root output directory of the pipeline.</summary>
    [JsonPropertyName("gcsOutputDirectory")]
    public string? GcsOutputDirectory { get; set; }
}

/// <summary>The service account that the pipeline workload runs as.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpecServiceAccountRef
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

/// <summary>VertexAIPipelineJobSpec defines the desired state of VertexAIPipelineJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobSpec
{
    /// <summary>The display name of the Pipeline. The name can be up to 128 characters long and can consist of any UTF-8 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Customer-managed encryption key spec for a pipelineJob. If set, this PipelineJob and all of its sub-resources will be secured by this key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAIPipelineJobSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>The labels with user-defined metadata to organize PipelineJob.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Reference to a ComputeNetwork.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1VertexAIPipelineJobSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The spec of the pipeline.</summary>
    [JsonPropertyName("pipelineSpec")]
    public JsonNode? PipelineSpec { get; set; }

    /// <summary>Optional. Whether to do component level validations before job creation.</summary>
    [JsonPropertyName("preflightValidations")]
    public bool? PreflightValidations { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VertexAIPipelineJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Configuration for PSC-I for PipelineJob.</summary>
    [JsonPropertyName("pscInterfaceConfig")]
    public V1alpha1VertexAIPipelineJobSpecPscInterfaceConfig? PscInterfaceConfig { get; set; }

    /// <summary>A list of names for the reserved ip ranges under the VPC network that can be used for this Pipeline Job&apos;s workload.</summary>
    [JsonPropertyName("reservedIPRanges")]
    public IList<string>? ReservedIPRanges { get; set; }

    /// <summary>The VertexAIPipelineJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Runtime config of the pipeline.</summary>
    [JsonPropertyName("runtimeConfig")]
    public V1alpha1VertexAIPipelineJobSpecRuntimeConfig? RuntimeConfig { get; set; }

    /// <summary>The service account that the pipeline workload runs as.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1VertexAIPipelineJobSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>A template uri from where the PipelineJob.pipeline_spec, if empty, will be downloaded.</summary>
    [JsonPropertyName("templateURI")]
    public string? TemplateURI { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusConditions
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

/// <summary>Output only. The error that occurred during pipeline execution. Only populated when the pipeline&apos;s state is FAILED or CANCELLED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Output only. The context of the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailPipelineContext
{
    /// <summary>Output only. Timestamp when this Context was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the Context</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User provided display name of the Context. May be up to 128 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An eTag used to perform consistent read-modify-write updates. If not set, a blind &quot;overwrite&quot; update happens.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The labels with user-defined metadata to organize your Contexts.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Properties of the Context.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>Immutable. The resource name of the Context.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. A list of resource names of Contexts that are parents of this Context.</summary>
    [JsonPropertyName("parentContexts")]
    public IList<string>? ParentContexts { get; set; }

    /// <summary>The title of the schema describing the metadata.</summary>
    [JsonPropertyName("schemaTitle")]
    public string? SchemaTitle { get; set; }

    /// <summary>The version of the schema in schema_name to use.</summary>
    [JsonPropertyName("schemaVersion")]
    public string? SchemaVersion { get; set; }

    /// <summary>Output only. Timestamp when this Context was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Output only. The context of the current pipeline run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailPipelineRunContext
{
    /// <summary>Output only. Timestamp when this Context was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the Context</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User provided display name of the Context. May be up to 128 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An eTag used to perform consistent read-modify-write updates. If not set, a blind &quot;overwrite&quot; update happens.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The labels with user-defined metadata to organize your Contexts.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Properties of the Context.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>Immutable. The resource name of the Context.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. A list of resource names of Contexts that are parents of this Context.</summary>
    [JsonPropertyName("parentContexts")]
    public IList<string>? ParentContexts { get; set; }

    /// <summary>The title of the schema describing the metadata.</summary>
    [JsonPropertyName("schemaTitle")]
    public string? SchemaTitle { get; set; }

    /// <summary>The version of the schema in schema_name to use.</summary>
    [JsonPropertyName("schemaVersion")]
    public string? SchemaVersion { get; set; }

    /// <summary>Output only. Timestamp when this Context was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Output only. The error that occurred during task execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Output only. The execution metadata of the task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecution
{
    /// <summary>Output only. Timestamp when this Execution was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the Execution</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User provided display name of the Execution.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An eTag used to perform consistent read-modify-write updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The labels with user-defined metadata to organize your Executions.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Properties of the Execution.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>Output only. The resource name of the Execution.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The title of the schema describing the metadata.</summary>
    [JsonPropertyName("schemaTitle")]
    public string? SchemaTitle { get; set; }

    /// <summary>The version of the schema in `schema_title` to use.</summary>
    [JsonPropertyName("schemaVersion")]
    public string? SchemaVersion { get; set; }

    /// <summary>The state of this Execution.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Timestamp when this Execution was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Output only. The detailed info for a container executor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecutorDetailContainerDetail
{
    /// <summary>Output only. The names of the previously failed CustomJob for the main container executions.</summary>
    [JsonPropertyName("failedMainJobs")]
    public IList<string>? FailedMainJobs { get; set; }

    /// <summary>Output only. The names of the previously failed CustomJob for the pre-caching-check container executions.</summary>
    [JsonPropertyName("failedPreCachingCheckJobs")]
    public IList<string>? FailedPreCachingCheckJobs { get; set; }

    /// <summary>Output only. The name of the CustomJob for the main container execution.</summary>
    [JsonPropertyName("mainJob")]
    public string? MainJob { get; set; }

    /// <summary>Output only. The name of the CustomJob for the pre-caching-check container execution.</summary>
    [JsonPropertyName("preCachingCheckJob")]
    public string? PreCachingCheckJob { get; set; }
}

/// <summary>Output only. The detailed info for a custom job executor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecutorDetailCustomJobDetail
{
    /// <summary>Output only. The names of the previously failed CustomJob.</summary>
    [JsonPropertyName("failedJobs")]
    public IList<string>? FailedJobs { get; set; }

    /// <summary>Output only. The name of the CustomJob.</summary>
    [JsonPropertyName("job")]
    public string? Job { get; set; }
}

/// <summary>Output only. The detailed execution info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecutorDetail
{
    /// <summary>Output only. The detailed info for a container executor.</summary>
    [JsonPropertyName("containerDetail")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecutorDetailContainerDetail? ContainerDetail { get; set; }

    /// <summary>Output only. The detailed info for a custom job executor.</summary>
    [JsonPropertyName("customJobDetail")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecutorDetailCustomJobDetail? CustomJobDetail { get; set; }
}

/// <summary>Output only. The error that occurred during the state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsPipelineTaskStatusError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsPipelineTaskStatus
{
    /// <summary>Output only. The error that occurred during the state.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsPipelineTaskStatusError? Error { get; set; }

    /// <summary>Output only. The state of the task.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Update time of this status.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetails
{
    /// <summary>Output only. Task create time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Task end time.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The error that occurred during task execution.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsError? Error { get; set; }

    /// <summary>Output only. The execution metadata of the task.</summary>
    [JsonPropertyName("execution")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecution? Execution { get; set; }

    /// <summary>Output only. The detailed execution info.</summary>
    [JsonPropertyName("executorDetail")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsExecutorDetail? ExecutorDetail { get; set; }

    /// <summary>Output only. The id of the parent task if the task is within a component scope.</summary>
    [JsonPropertyName("parentTaskID")]
    public long? ParentTaskID { get; set; }

    /// <summary>Output only. A list of task status.</summary>
    [JsonPropertyName("pipelineTaskStatus")]
    public IList<V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetailsPipelineTaskStatus>? PipelineTaskStatus { get; set; }

    /// <summary>Output only. Task start time.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. State of the task.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The system generated ID of the task.</summary>
    [JsonPropertyName("taskID")]
    public long? TaskID { get; set; }

    /// <summary>Output only. The user specified name of the task.</summary>
    [JsonPropertyName("taskName")]
    public string? TaskName { get; set; }

    /// <summary>Output only. The unique name of a task.</summary>
    [JsonPropertyName("taskUniqueName")]
    public string? TaskUniqueName { get; set; }
}

/// <summary>Output only. The details of pipeline run. Not available in the list view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateJobDetail
{
    /// <summary>Output only. The context of the pipeline.</summary>
    [JsonPropertyName("pipelineContext")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailPipelineContext? PipelineContext { get; set; }

    /// <summary>Output only. The context of the current pipeline run.</summary>
    [JsonPropertyName("pipelineRunContext")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailPipelineRunContext? PipelineRunContext { get; set; }

    /// <summary>Output only. The runtime details of the tasks under the pipeline.</summary>
    [JsonPropertyName("taskDetails")]
    public IList<V1alpha1VertexAIPipelineJobStatusObservedStateJobDetailTaskDetails>? TaskDetails { get; set; }
}

/// <summary>Output only. Pipeline template metadata. Will fill up fields if [PipelineJob.template_uri][google.cloud.aiplatform.v1.PipelineJob.template_uri] is from supported template registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedStateTemplateMetadata
{
    /// <summary>The version_name in artifact registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatusObservedState
{
    /// <summary>Output only. Pipeline creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Pipeline end time.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The error that occurred during pipeline execution. Only populated when the pipeline&apos;s state is FAILED or CANCELLED.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. The details of pipeline run. Not available in the list view.</summary>
    [JsonPropertyName("jobDetail")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateJobDetail? JobDetail { get; set; }

    /// <summary>Output only. The resource name of the PipelineJob.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The schedule resource name. Only returned if the Pipeline is created by Schedule API.</summary>
    [JsonPropertyName("scheduleName")]
    public string? ScheduleName { get; set; }

    /// <summary>Output only. Pipeline start time.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. The detailed state of the job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Pipeline template metadata. Will fill up fields if [PipelineJob.template_uri][google.cloud.aiplatform.v1.PipelineJob.template_uri] is from supported template registry.</summary>
    [JsonPropertyName("templateMetadata")]
    public V1alpha1VertexAIPipelineJobStatusObservedStateTemplateMetadata? TemplateMetadata { get; set; }

    /// <summary>Output only. Timestamp when this PipelineJob was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAIPipelineJobStatus defines the config connector machine state of VertexAIPipelineJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIPipelineJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIPipelineJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIPipelineJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIPipelineJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIPipelineJob is the Schema for the VertexAIPipelineJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIPipelineJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIPipelineJobSpec>, IStatus<V1alpha1VertexAIPipelineJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIPipelineJob";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaipipelinejobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aiplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIPipelineJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIPipelineJobSpec defines the desired state of VertexAIPipelineJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAIPipelineJobSpec Spec { get; set; }

    /// <summary>VertexAIPipelineJobStatus defines the config connector machine state of VertexAIPipelineJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIPipelineJobStatus? Status { get; set; }
}