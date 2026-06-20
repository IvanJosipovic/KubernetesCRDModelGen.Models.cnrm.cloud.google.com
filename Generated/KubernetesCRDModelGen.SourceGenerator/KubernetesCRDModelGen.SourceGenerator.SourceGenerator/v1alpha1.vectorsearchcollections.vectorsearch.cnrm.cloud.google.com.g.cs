#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vectorsearch.cnrm.cloud.google.com;
/// <summary>VectorSearchCollection is the Schema for the VectorSearchCollection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VectorSearchCollectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VectorSearchCollection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VectorSearchCollectionList";
    public const string KubeGroup = "vectorsearch.cnrm.cloud.google.com";
    public const string KubePluralName = "vectorsearchcollections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vectorsearch.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchCollectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VectorSearchCollection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VectorSearchCollection> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionSpecProjectRef
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

/// <summary>Optional. Configuration for generating embeddings for the vector field. If not specified, the embedding field must be populated in the DataObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionSpecVectorSchemaDenseVectorVertexEmbeddingConfig
{
    /// <summary>Required. Required: ID of the embedding model to use. See https://cloud.google.com/vertex-ai/generative-ai/docs/learn/models#embeddings-models for the list of supported models.</summary>
    [JsonPropertyName("modelID")]
    public required string ModelID { get; set; }

    /// <summary>Required. Required: Task type for the embeddings.</summary>
    [JsonPropertyName("taskType")]
    public required string TaskType { get; set; }

    /// <summary>Required. Required: Text template for the input to the model. The template must contain one or more references to fields in the DataObject, e.g.: &quot;Movie Title: {title} ---- Movie Plot: {plot}&quot;.</summary>
    [JsonPropertyName("textTemplate")]
    public required string TextTemplate { get; set; }
}

/// <summary>Dense vector field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionSpecVectorSchemaDenseVector
{
    /// <summary>Dimensionality of the vector field.</summary>
    [JsonPropertyName("dimensions")]
    public int? Dimensions { get; set; }

    /// <summary>Optional. Configuration for generating embeddings for the vector field. If not specified, the embedding field must be populated in the DataObject.</summary>
    [JsonPropertyName("vertexEmbeddingConfig")]
    public V1alpha1VectorSearchCollectionSpecVectorSchemaDenseVectorVertexEmbeddingConfig? VertexEmbeddingConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionSpecVectorSchema
{
    /// <summary>Dense vector field.</summary>
    [JsonPropertyName("denseVector")]
    public V1alpha1VectorSearchCollectionSpecVectorSchemaDenseVector? DenseVector { get; set; }

    /// <summary>Sparse vector field.</summary>
    [JsonPropertyName("sparseVector")]
    public JsonNode? SparseVector { get; set; }
}

/// <summary>VectorSearchCollectionSpec defines the desired state of VectorSearchCollection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionSpec
{
    /// <summary>Optional. JSON Schema for data. Field names must contain only alphanumeric characters, underscores, and hyphens.</summary>
    [JsonPropertyName("dataSchema")]
    public JsonNode? DataSchema { get; set; }

    /// <summary>Optional. User-specified description of the collection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. User-specified display name of the collection</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Labels as key value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VectorSearchCollectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VectorSearchCollection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Schema for vector fields. Only vector fields in this schema will be searchable. Field names must contain only alphanumeric characters, underscores, and hyphens.</summary>
    [JsonPropertyName("vectorSchema")]
    public IDictionary<string, V1alpha1VectorSearchCollectionSpecVectorSchema>? VectorSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionStatusConditions
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
public partial class V1alpha1VectorSearchCollectionStatusObservedState
{
    /// <summary>Output only. [Output only] Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. [Output only] Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VectorSearchCollectionStatus defines the config connector machine state of VectorSearchCollection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchCollectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VectorSearchCollectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VectorSearchCollection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VectorSearchCollectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>VectorSearchCollection is the Schema for the VectorSearchCollection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VectorSearchCollection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VectorSearchCollectionSpec>, IStatus<V1alpha1VectorSearchCollectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VectorSearchCollection";
    public const string KubeGroup = "vectorsearch.cnrm.cloud.google.com";
    public const string KubePluralName = "vectorsearchcollections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vectorsearch.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchCollection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VectorSearchCollectionSpec defines the desired state of VectorSearchCollection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VectorSearchCollectionSpec Spec { get; set; }

    /// <summary>VectorSearchCollectionStatus defines the config connector machine state of VectorSearchCollection</summary>
    [JsonPropertyName("status")]
    public V1alpha1VectorSearchCollectionStatus? Status { get; set; }
}