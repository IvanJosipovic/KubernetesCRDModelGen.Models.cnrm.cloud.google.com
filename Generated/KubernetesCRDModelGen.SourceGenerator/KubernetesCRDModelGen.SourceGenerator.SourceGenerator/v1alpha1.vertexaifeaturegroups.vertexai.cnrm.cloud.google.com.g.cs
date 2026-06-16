#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary>VertexAIFeatureGroup is the Schema for the VertexAIFeatureGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeatureGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIFeatureGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeatureGroupList";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeaturegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIFeatureGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAIFeatureGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAIFeatureGroup> Items { get; set; }
}

/// <summary>Required. Immutable. The BigQuery source URI that points to either a BigQuery Table or View.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupSpecBigQueryBigQuerySource
{
    /// <summary>
    /// Required. BigQuery URI to a table, up to 2000 characters long.
    ///  Accepted forms:
    /// 
    ///  *  BigQuery path. For example: `bq://projectId.bqDatasetId.bqTableId`.
    /// </summary>
    [JsonPropertyName("inputURI")]
    public string? InputURI { get; set; }
}

/// <summary>Optional. If the source is a time-series source, this can be set to control how downstream sources (ex: [FeatureView][google.cloud.aiplatform.v1beta1.FeatureView] ) will treat time-series sources. If not set, will treat the source as a time-series source with `feature_timestamp` as timestamp column and no scan boundary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupSpecBigQueryTimeSeries
{
    /// <summary>Optional. Column hosting timestamp values for a time-series source. Will be used to determine the latest `feature_values` for each entity. Optional. If not provided, column named `feature_timestamp` of type `TIMESTAMP` will be used.</summary>
    [JsonPropertyName("timestampColumn")]
    public string? TimestampColumn { get; set; }
}

/// <summary>Indicates that that the source of this FeatureGroup is BigQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupSpecBigQuery
{
    /// <summary>Required. Immutable. The BigQuery source URI that points to either a BigQuery Table or View.</summary>
    [JsonPropertyName("bigQuerySource")]
    public V1alpha1VertexAIFeatureGroupSpecBigQueryBigQuerySource? BigQuerySource { get; set; }

    /// <summary>Optional. If set, all feature values will be fetched from a single row per unique entityId including nulls. If not set, will collapse all rows for each unique entityId into a singe row with any non-null values if present, if no non-null values are present will sync null. ex: If source has schema `(entity_id, feature_timestamp, f0, f1)` and the following rows: `(e1, 2020-01-01T10:00:00.123Z, 10, 15)` `(e1, 2020-02-01T10:00:00.123Z, 20, null)` If dense is set, `(e1, 20, null)` is synced to online stores. If dense is not set, `(e1, 20, 15)` is synced to online stores.</summary>
    [JsonPropertyName("dense")]
    public bool? Dense { get; set; }

    /// <summary>Optional. Columns to construct entity_id / row keys. If not provided defaults to `entity_id`.</summary>
    [JsonPropertyName("entityIDColumns")]
    public IList<string>? EntityIDColumns { get; set; }

    /// <summary>Optional. Set if the data source is not a time-series.</summary>
    [JsonPropertyName("staticDataSource")]
    public bool? StaticDataSource { get; set; }

    /// <summary>Optional. If the source is a time-series source, this can be set to control how downstream sources (ex: [FeatureView][google.cloud.aiplatform.v1beta1.FeatureView] ) will treat time-series sources. If not set, will treat the source as a time-series source with `feature_timestamp` as timestamp column and no scan boundary.</summary>
    [JsonPropertyName("timeSeries")]
    public V1alpha1VertexAIFeatureGroupSpecBigQueryTimeSeries? TimeSeries { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupSpecProjectRef
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

/// <summary>VertexAIFeatureGroupSpec defines the desired state of VertexAIFeatureGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupSpec
{
    /// <summary>Indicates that that the source of this FeatureGroup is BigQuery.</summary>
    [JsonPropertyName("bigQuery")]
    public V1alpha1VertexAIFeatureGroupSpecBigQuery? BigQuery { get; set; }

    /// <summary>Optional. Description of the FeatureGroup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The labels with user-defined metadata to organize your FeatureGroup.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VertexAIFeatureGroupSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VertexAIFeatureGroup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. A service account type for BigQuery data reading.</summary>
    [JsonPropertyName("serviceAgentType")]
    public string? ServiceAgentType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupStatusConditions
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
public partial class V1alpha1VertexAIFeatureGroupStatusObservedState
{
    /// <summary>Output only. Timestamp when this FeatureGroup was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The email of the service account used to read the BigQuery data.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Output only. Timestamp when this FeatureGroup was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAIFeatureGroupStatus defines the config connector machine state of VertexAIFeatureGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeatureGroupStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIFeatureGroupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIFeatureGroup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIFeatureGroupStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIFeatureGroup is the Schema for the VertexAIFeatureGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeatureGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIFeatureGroupSpec>, IStatus<V1alpha1VertexAIFeatureGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeatureGroup";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeaturegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIFeatureGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIFeatureGroupSpec defines the desired state of VertexAIFeatureGroup</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAIFeatureGroupSpec Spec { get; set; }

    /// <summary>VertexAIFeatureGroupStatus defines the config connector machine state of VertexAIFeatureGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIFeatureGroupStatus? Status { get; set; }
}