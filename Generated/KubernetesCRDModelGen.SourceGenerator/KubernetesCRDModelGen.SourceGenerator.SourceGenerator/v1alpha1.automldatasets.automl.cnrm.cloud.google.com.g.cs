#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.automl.cnrm.cloud.google.com;
/// <summary>AutoMLDataset is the Schema for the AutoMLDataset API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AutoMLDatasetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AutoMLDataset>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AutoMLDatasetList";
    public const string KubeGroup = "automl.cnrm.cloud.google.com";
    public const string KubePluralName = "automldatasets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "automl.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoMLDatasetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AutoMLDataset objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AutoMLDataset> Items { get; set; }
}

/// <summary>Metadata for a dataset used for image classification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetSpecImageClassificationDatasetMetadata
{
    /// <summary>Required. Type of the classification problem.</summary>
    [JsonPropertyName("classificationType")]
    public required string ClassificationType { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetSpecProjectRef
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

/// <summary>Metadata for a dataset used for text classification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetSpecTextClassificationDatasetMetadata
{
    /// <summary>Required. Type of the classification problem.</summary>
    [JsonPropertyName("classificationType")]
    public required string ClassificationType { get; set; }
}

/// <summary>Metadata for a dataset used for text sentiment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetSpecTextSentimentDatasetMetadata
{
    /// <summary>Required. A sentiment is expressed as an integer ordinal, where higher value means a more positive sentiment. The range of sentiments that will be used is between 0 and sentiment_max (inclusive on both ends), and all the values in the range must be represented in the dataset before a model can be created. sentiment_max value must be between 1 and 10 (inclusive).</summary>
    [JsonPropertyName("sentimentMax")]
    public required int SentimentMax { get; set; }
}

/// <summary>Metadata for a dataset used for translation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetSpecTranslationDatasetMetadata
{
    /// <summary>Required. The BCP-47 language code of the source language.</summary>
    [JsonPropertyName("sourceLanguageCode")]
    public required string SourceLanguageCode { get; set; }

    /// <summary>Required. The BCP-47 language code of the target language.</summary>
    [JsonPropertyName("targetLanguageCode")]
    public required string TargetLanguageCode { get; set; }
}

/// <summary>AutoMLDatasetSpec defines the desired state of AutoMLDataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetSpec
{
    /// <summary>User-provided description of the dataset. The description can be up to 25000 characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The name of the dataset to show in the interface. The name can be up to 32 characters long and can consist only of ASCII Latin letters A-Z and a-z, underscores (_), and ASCII digits 0-9.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Metadata for a dataset used for image classification.</summary>
    [JsonPropertyName("imageClassificationDatasetMetadata")]
    public V1alpha1AutoMLDatasetSpecImageClassificationDatasetMetadata? ImageClassificationDatasetMetadata { get; set; }

    /// <summary>Metadata for a dataset used for image object detection.</summary>
    [JsonPropertyName("imageObjectDetectionDatasetMetadata")]
    public JsonNode? ImageObjectDetectionDatasetMetadata { get; set; }

    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your dataset.
    /// 
    ///  Label keys and values can be no longer than 64 characters
    ///  (Unicode codepoints), can only contain lowercase letters, numeric
    ///  characters, underscores and dashes. International characters are allowed.
    ///  Label values are optional. Label keys must start with a letter.
    /// 
    ///  See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1AutoMLDatasetSpecProjectRef ProjectRef { get; set; }

    /// <summary>The AutoMLDataset name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Metadata for a dataset used for text classification.</summary>
    [JsonPropertyName("textClassificationDatasetMetadata")]
    public V1alpha1AutoMLDatasetSpecTextClassificationDatasetMetadata? TextClassificationDatasetMetadata { get; set; }

    /// <summary>Metadata for a dataset used for text extraction.</summary>
    [JsonPropertyName("textExtractionDatasetMetadata")]
    public JsonNode? TextExtractionDatasetMetadata { get; set; }

    /// <summary>Metadata for a dataset used for text sentiment.</summary>
    [JsonPropertyName("textSentimentDatasetMetadata")]
    public V1alpha1AutoMLDatasetSpecTextSentimentDatasetMetadata? TextSentimentDatasetMetadata { get; set; }

    /// <summary>Metadata for a dataset used for translation.</summary>
    [JsonPropertyName("translationDatasetMetadata")]
    public V1alpha1AutoMLDatasetSpecTranslationDatasetMetadata? TranslationDatasetMetadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetStatusConditions
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
public partial class V1alpha1AutoMLDatasetStatusObservedState
{
    /// <summary>Output only. Timestamp when this dataset was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Used to perform consistent read-modify-write updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The number of examples in the dataset.</summary>
    [JsonPropertyName("exampleCount")]
    public int? ExampleCount { get; set; }
}

/// <summary>AutoMLDatasetStatus defines the config connector machine state of AutoMLDataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AutoMLDatasetStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AutoMLDatasetStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AutoMLDataset resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AutoMLDatasetStatusObservedState? ObservedState { get; set; }
}

/// <summary>AutoMLDataset is the Schema for the AutoMLDataset API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AutoMLDataset : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AutoMLDatasetSpec>, IStatus<V1alpha1AutoMLDatasetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AutoMLDataset";
    public const string KubeGroup = "automl.cnrm.cloud.google.com";
    public const string KubePluralName = "automldatasets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "automl.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoMLDataset";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AutoMLDatasetSpec defines the desired state of AutoMLDataset</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AutoMLDatasetSpec Spec { get; set; }

    /// <summary>AutoMLDatasetStatus defines the config connector machine state of AutoMLDataset</summary>
    [JsonPropertyName("status")]
    public V1alpha1AutoMLDatasetStatus? Status { get; set; }
}