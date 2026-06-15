#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalabeling.cnrm.cloud.google.com;
/// <summary>DataLabelingDataset is the Schema for the DataLabelingDataset API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingDatasetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataLabelingDataset>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingDatasetList";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelingdatasets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingDatasetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataLabelingDataset objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataLabelingDataset> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetSpecProjectRef
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

/// <summary>DataLabelingDatasetSpec defines the desired state of DataLabelingDataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetSpec
{
    /// <summary>Optional. User-provided description of the annotation specification set. The description can be up to 10000 characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the dataset. Maximum of 64 characters.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataLabelingDatasetSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataLabelingDataset name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusConditions
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

/// <summary>Source located in BigQuery. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsBigquerySource
{
    /// <summary>
    /// Required. BigQuery URI to a table, up to 2,000 characters long. If you
    ///  specify the URI of a table that does not exist, Data Labeling Service
    ///  creates a table at the URI with the correct schema when you create your
    ///  [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob]. If you specify the URI of a table that already exists,
    ///  it must have the
    ///  [correct
    ///  schema](/ml-engine/docs/continuous-evaluation/create-job#table-schema).
    /// 
    ///  Provide the table URI in the following format:
    /// 
    ///  &quot;bq://&lt;var&gt;{your_project_id}&lt;/var&gt;/&lt;var&gt;{your_dataset_name}&lt;/var&gt;/&lt;var&gt;{your_table_name}&lt;/var&gt; &quot;
    /// 
    ///  [Learn
    ///  more](/ml-engine/docs/continuous-evaluation/create-job#table-schema).
    /// </summary>
    [JsonPropertyName("inputURI")]
    public string? InputURI { get; set; }
}

/// <summary>Optional. Metadata about annotations for the input. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob] for a model version that performs classification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsClassificationMetadata
{
    /// <summary>Whether the classification task is multi-label or not.</summary>
    [JsonPropertyName("isMultiLabel")]
    public bool? IsMultiLabel { get; set; }
}

/// <summary>Source located in Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsGcsSource
{
    /// <summary>Required. The input URI of source file. This must be a Cloud Storage path (`gs://...`).</summary>
    [JsonPropertyName("inputURI")]
    public string? InputURI { get; set; }

    /// <summary>Required. The format of the source file. Only &quot;text/csv&quot; is supported.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }
}

/// <summary>Required for text import, as language code must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsTextMetadata
{
    /// <summary>The language of this text, as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). Default value is en-US.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusObservedStateInputConfigs
{
    /// <summary>Optional. The type of annotation to be performed on this data. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob].</summary>
    [JsonPropertyName("annotationType")]
    public string? AnnotationType { get; set; }

    /// <summary>Source located in BigQuery. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob].</summary>
    [JsonPropertyName("bigquerySource")]
    public V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsBigquerySource? BigquerySource { get; set; }

    /// <summary>Optional. Metadata about annotations for the input. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob] for a model version that performs classification.</summary>
    [JsonPropertyName("classificationMetadata")]
    public V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsClassificationMetadata? ClassificationMetadata { get; set; }

    /// <summary>Required. Data type must be specifed when user tries to import data.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Source located in Cloud Storage.</summary>
    [JsonPropertyName("gcsSource")]
    public V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsGcsSource? GcsSource { get; set; }

    /// <summary>Required for text import, as language code must be specified.</summary>
    [JsonPropertyName("textMetadata")]
    public V1alpha1DataLabelingDatasetStatusObservedStateInputConfigsTextMetadata? TextMetadata { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatusObservedState
{
    /// <summary>Output only. The names of any related resources that are blocking changes to the dataset.</summary>
    [JsonPropertyName("blockingResources")]
    public IList<string>? BlockingResources { get; set; }

    /// <summary>Output only. Time the dataset is created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The number of data items in the dataset.</summary>
    [JsonPropertyName("dataItemCount")]
    public long? DataItemCount { get; set; }

    /// <summary>Output only. This is populated with the original input configs where ImportData is called. It is available only after the clients import data to this dataset.</summary>
    [JsonPropertyName("inputConfigs")]
    public IList<V1alpha1DataLabelingDatasetStatusObservedStateInputConfigs>? InputConfigs { get; set; }
}

/// <summary>DataLabelingDatasetStatus defines the config connector machine state of DataLabelingDataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingDatasetStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataLabelingDatasetStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataLabelingDataset resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataLabelingDatasetStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataLabelingDataset is the Schema for the DataLabelingDataset API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingDataset : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataLabelingDatasetSpec>, IStatus<V1alpha1DataLabelingDatasetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingDataset";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelingdatasets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingDataset";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLabelingDatasetSpec defines the desired state of DataLabelingDataset</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataLabelingDatasetSpec Spec { get; set; }

    /// <summary>DataLabelingDatasetStatus defines the config connector machine state of DataLabelingDataset</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataLabelingDatasetStatus? Status { get; set; }
}