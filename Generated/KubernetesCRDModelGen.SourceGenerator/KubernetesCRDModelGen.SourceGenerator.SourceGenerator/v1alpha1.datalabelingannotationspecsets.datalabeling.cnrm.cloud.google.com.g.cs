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
/// <summary>DataLabelingAnnotationSpecSet is the Schema for the DataLabelingAnnotationSpecSet API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingAnnotationSpecSetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataLabelingAnnotationSpecSet>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingAnnotationSpecSetList";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelingannotationspecsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingAnnotationSpecSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataLabelingAnnotationSpecSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataLabelingAnnotationSpecSet> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingAnnotationSpecSetSpecAnnotationSpecs
{
    /// <summary>Optional. User-provided description of the annotation specification. The description can be up to 10,000 characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the AnnotationSpec. Maximum of 64 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingAnnotationSpecSetSpecProjectRef
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

/// <summary>DataLabelingAnnotationSpecSetSpec defines the desired state of DataLabelingAnnotationSpecSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingAnnotationSpecSetSpec
{
    /// <summary>Required. The array of AnnotationSpecs that you define when you create the AnnotationSpecSet. These are the possible labels for the labeling task.</summary>
    [JsonPropertyName("annotationSpecs")]
    public required IList<V1alpha1DataLabelingAnnotationSpecSetSpecAnnotationSpecs> AnnotationSpecs { get; set; }

    /// <summary>Optional. User-provided description of the annotation specification set. The description can be up to 10,000 characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name for AnnotationSpecSet that you define when you create it. Maximum of 64 characters.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataLabelingAnnotationSpecSetSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataLabelingAnnotationSpecSet name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingAnnotationSpecSetStatusConditions
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
public partial class V1alpha1DataLabelingAnnotationSpecSetStatusObservedState
{
    /// <summary>Output only. The names of any related resources that are blocking changes to the annotation spec set.</summary>
    [JsonPropertyName("blockingResources")]
    public IList<string>? BlockingResources { get; set; }
}

/// <summary>DataLabelingAnnotationSpecSetStatus defines the config connector machine state of DataLabelingAnnotationSpecSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingAnnotationSpecSetStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataLabelingAnnotationSpecSetStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataLabelingAnnotationSpecSet resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataLabelingAnnotationSpecSetStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataLabelingAnnotationSpecSet is the Schema for the DataLabelingAnnotationSpecSet API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingAnnotationSpecSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataLabelingAnnotationSpecSetSpec>, IStatus<V1alpha1DataLabelingAnnotationSpecSetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingAnnotationSpecSet";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelingannotationspecsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingAnnotationSpecSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLabelingAnnotationSpecSetSpec defines the desired state of DataLabelingAnnotationSpecSet</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataLabelingAnnotationSpecSetSpec Spec { get; set; }

    /// <summary>DataLabelingAnnotationSpecSetStatus defines the config connector machine state of DataLabelingAnnotationSpecSet</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataLabelingAnnotationSpecSetStatus? Status { get; set; }
}