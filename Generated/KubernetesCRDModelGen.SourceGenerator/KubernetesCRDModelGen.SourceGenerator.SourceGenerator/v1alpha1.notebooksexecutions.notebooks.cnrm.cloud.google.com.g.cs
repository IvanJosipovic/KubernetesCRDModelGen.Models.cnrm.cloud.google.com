#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notebooks.cnrm.cloud.google.com;
/// <summary>NotebooksExecution is the Schema for the NotebooksExecution API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotebooksExecutionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NotebooksExecution>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebooksExecutionList";
    public const string KubeGroup = "notebooks.cnrm.cloud.google.com";
    public const string KubePluralName = "notebooksexecutions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notebooks.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotebooksExecutionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NotebooksExecution objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NotebooksExecution> Items { get; set; }
}

/// <summary>Configuration (count and accelerator type) for hardware running notebook execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateAcceleratorConfig
{
    /// <summary>Count of cores of this accelerator.</summary>
    [JsonPropertyName("coreCount")]
    public long? CoreCount { get; set; }

    /// <summary>Type of this accelerator.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Dataproc cluster used to run Dataproc execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateDataprocParametersClusterRef
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

/// <summary>Parameters used in Dataproc JobType executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateDataprocParameters
{
    /// <summary>The Dataproc cluster used to run Dataproc execution.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateDataprocParametersClusterRef? ClusterRef { get; set; }
}

/// <summary>The service account to use when running the execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateServiceAccountRef
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

/// <summary>The Vertex AI [Tensorboard] resource to which this execution will upload Tensorboard logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateTensorboardRef
{
    /// <summary>A reference to an externally managed VertexAITensorboard resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/tensorboards/{{tensorboardID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VertexAITensorboard resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VertexAITensorboard resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Compute Engine network to which the Job should be peered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateVertexAiParametersNetworkRef
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

/// <summary>Parameters used in Vertex AI JobType executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplateVertexAiParameters
{
    /// <summary>Environment variables.</summary>
    [JsonPropertyName("env")]
    public IDictionary<string, string>? Env { get; set; }

    /// <summary>The Compute Engine network to which the Job should be peered.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateVertexAiParametersNetworkRef? NetworkRef { get; set; }
}

/// <summary>execute metadata including name, hardware spec, region, labels, etc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecExecutionTemplate
{
    /// <summary>Configuration (count and accelerator type) for hardware running notebook execution.</summary>
    [JsonPropertyName("acceleratorConfig")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateAcceleratorConfig? AcceleratorConfig { get; set; }

    /// <summary>Container Image URI to a DLVM</summary>
    [JsonPropertyName("containerImageURI")]
    public string? ContainerImageURI { get; set; }

    /// <summary>Parameters used in Dataproc JobType executions.</summary>
    [JsonPropertyName("dataprocParameters")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateDataprocParameters? DataprocParameters { get; set; }

    /// <summary>Path to the notebook file to execute.</summary>
    [JsonPropertyName("inputNotebookFile")]
    public string? InputNotebookFile { get; set; }

    /// <summary>The type of Job to be used on this execution.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>Name of the kernel spec to use.</summary>
    [JsonPropertyName("kernelSpec")]
    public string? KernelSpec { get; set; }

    /// <summary>Labels for execution.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the type of virtual machine to use for your training job&apos;s master worker. You must specify this field when `scaleTier` is set to `CUSTOM`.</summary>
    [JsonPropertyName("masterType")]
    public string? MasterType { get; set; }

    /// <summary>Path to the notebook folder to write to.</summary>
    [JsonPropertyName("outputNotebookFolder")]
    public string? OutputNotebookFolder { get; set; }

    /// <summary>Parameters used within the &apos;input_notebook_file&apos; notebook.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>Parameters to be overridden in the notebook during execution.</summary>
    [JsonPropertyName("paramsYamlFile")]
    public string? ParamsYamlFile { get; set; }

    /// <summary>Required. Scale tier of the hardware used for notebook execution. DEPRECATED Will be discontinued. As right now only CUSTOM is supported.</summary>
    [JsonPropertyName("scaleTier")]
    public string? ScaleTier { get; set; }

    /// <summary>The service account to use when running the execution.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The Vertex AI [Tensorboard] resource to which this execution will upload Tensorboard logs.</summary>
    [JsonPropertyName("tensorboardRef")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateTensorboardRef? TensorboardRef { get; set; }

    /// <summary>Parameters used in Vertex AI JobType executions.</summary>
    [JsonPropertyName("vertexAiParameters")]
    public V1alpha1NotebooksExecutionSpecExecutionTemplateVertexAiParameters? VertexAiParameters { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpecProjectRef
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

/// <summary>NotebooksExecutionSpec defines the desired state of NotebooksExecution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionSpec
{
    /// <summary>A brief description of this execution.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>execute metadata including name, hardware spec, region, labels, etc.</summary>
    [JsonPropertyName("executionTemplate")]
    public required V1alpha1NotebooksExecutionSpecExecutionTemplate ExecutionTemplate { get; set; }

    /// <summary>The location for the resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Output notebook file generated by this execution</summary>
    [JsonPropertyName("outputNotebookFile")]
    public string? OutputNotebookFile { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NotebooksExecutionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NotebooksExecution name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionStatusConditions
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
public partial class V1alpha1NotebooksExecutionStatusObservedState
{
    /// <summary>Output only. Time the Execution was instantiated.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Name used for UI purposes. Name can only contain alphanumeric characters and underscores &apos;_&apos;.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Output only. The URI of the external job used to execute the notebook.</summary>
    [JsonPropertyName("jobURI")]
    public string? JobURI { get; set; }

    /// <summary>Output only. State of the underlying AI Platform job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Time the Execution was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NotebooksExecutionStatus defines the config connector machine state of NotebooksExecution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebooksExecutionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NotebooksExecutionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NotebooksExecution resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NotebooksExecutionStatusObservedState? ObservedState { get; set; }
}

/// <summary>NotebooksExecution is the Schema for the NotebooksExecution API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotebooksExecution : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NotebooksExecutionSpec>, IStatus<V1alpha1NotebooksExecutionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebooksExecution";
    public const string KubeGroup = "notebooks.cnrm.cloud.google.com";
    public const string KubePluralName = "notebooksexecutions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notebooks.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotebooksExecution";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotebooksExecutionSpec defines the desired state of NotebooksExecution</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NotebooksExecutionSpec Spec { get; set; }

    /// <summary>NotebooksExecutionStatus defines the config connector machine state of NotebooksExecution</summary>
    [JsonPropertyName("status")]
    public V1alpha1NotebooksExecutionStatus? Status { get; set; }
}