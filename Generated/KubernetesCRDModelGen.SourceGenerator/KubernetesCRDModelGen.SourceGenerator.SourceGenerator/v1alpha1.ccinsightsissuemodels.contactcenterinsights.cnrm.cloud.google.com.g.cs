#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.contactcenterinsights.cnrm.cloud.google.com;
/// <summary>CCInsightsIssueModel is the Schema for the CCInsightsIssueModel API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CCInsightsIssueModelList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CCInsightsIssueModel>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CCInsightsIssueModelList";
    public const string KubeGroup = "contactcenterinsights.cnrm.cloud.google.com";
    public const string KubePluralName = "ccinsightsissuemodels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contactcenterinsights.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CCInsightsIssueModelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CCInsightsIssueModel objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CCInsightsIssueModel> Items { get; set; }
}

/// <summary>Configs for the input data that used to create the issue model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelSpecInputDataConfig
{
    /// <summary>A filter to reduce the conversations used for training the model to a specific subset.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Medium of conversations used in training data. This field is being deprecated. To specify the medium to be used in training a new issue model, set the `medium` field on `filter`.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelSpecProjectRef
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

/// <summary>CCInsightsIssueModelSpec defines the desired state of CCInsightsIssueModel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelSpec
{
    /// <summary>The representative name for the issue model.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Configs for the input data that used to create the issue model.</summary>
    [JsonPropertyName("inputDataConfig")]
    public V1alpha1CCInsightsIssueModelSpecInputDataConfig? InputDataConfig { get; set; }

    /// <summary>Language of the model.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Type of the model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CCInsightsIssueModelSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CCInsightsIssueModel name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelStatusConditions
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

/// <summary>Configs for the input data that used to create the issue model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelStatusObservedStateInputDataConfig
{
    /// <summary>Output only. Number of conversations used in training. Output only.</summary>
    [JsonPropertyName("trainingConversationsCount")]
    public long? TrainingConversationsCount { get; set; }
}

/// <summary>Output only. Immutable. The issue model&apos;s label statistics on its training data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelStatusObservedStateTrainingStats
{
    /// <summary>Number of conversations the issue model has analyzed at this point in time.</summary>
    [JsonPropertyName("analyzedConversationsCount")]
    public long? AnalyzedConversationsCount { get; set; }

    /// <summary>Number of analyzed conversations for which no issue was applicable at this point in time.</summary>
    [JsonPropertyName("unclassifiedConversationsCount")]
    public long? UnclassifiedConversationsCount { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelStatusObservedState
{
    /// <summary>Output only. The time at which this issue model was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Configs for the input data that used to create the issue model.</summary>
    [JsonPropertyName("inputDataConfig")]
    public V1alpha1CCInsightsIssueModelStatusObservedStateInputDataConfig? InputDataConfig { get; set; }

    /// <summary>Output only. Number of issues in this issue model.</summary>
    [JsonPropertyName("issueCount")]
    public long? IssueCount { get; set; }

    /// <summary>Output only. State of the model.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Immutable. The issue model&apos;s label statistics on its training data.</summary>
    [JsonPropertyName("trainingStats")]
    public V1alpha1CCInsightsIssueModelStatusObservedStateTrainingStats? TrainingStats { get; set; }

    /// <summary>Output only. The most recent time at which the issue model was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CCInsightsIssueModelStatus defines the config connector machine state of CCInsightsIssueModel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsIssueModelStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CCInsightsIssueModelStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CCInsightsIssueModel resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CCInsightsIssueModelStatusObservedState? ObservedState { get; set; }
}

/// <summary>CCInsightsIssueModel is the Schema for the CCInsightsIssueModel API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CCInsightsIssueModel : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CCInsightsIssueModelSpec>, IStatus<V1alpha1CCInsightsIssueModelStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CCInsightsIssueModel";
    public const string KubeGroup = "contactcenterinsights.cnrm.cloud.google.com";
    public const string KubePluralName = "ccinsightsissuemodels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contactcenterinsights.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CCInsightsIssueModel";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CCInsightsIssueModelSpec defines the desired state of CCInsightsIssueModel</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CCInsightsIssueModelSpec Spec { get; set; }

    /// <summary>CCInsightsIssueModelStatus defines the config connector machine state of CCInsightsIssueModel</summary>
    [JsonPropertyName("status")]
    public V1alpha1CCInsightsIssueModelStatus? Status { get; set; }
}