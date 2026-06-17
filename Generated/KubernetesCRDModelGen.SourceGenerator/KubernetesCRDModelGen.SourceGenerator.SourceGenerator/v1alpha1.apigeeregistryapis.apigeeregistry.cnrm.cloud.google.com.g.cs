#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigeeregistry.cnrm.cloud.google.com;
/// <summary>ApigeeRegistryAPI is the Schema for the ApigeeRegistryAPI API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeRegistryAPIList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ApigeeRegistryAPI>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeRegistryAPIList";
    public const string KubeGroup = "apigeeregistry.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeregistryapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigeeregistry.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApigeeRegistryAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ApigeeRegistryAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ApigeeRegistryAPI> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeRegistryAPISpecProjectRef
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

/// <summary>ApigeeRegistryAPISpec defines the desired state of ApigeeRegistryAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeRegistryAPISpec
{
    /// <summary>
    /// Annotations attach non-identifying metadata to resources.
    /// 
    ///  Annotation keys and values are less restricted than those of labels, but
    ///  should be generally used for small values of broad interest. Larger, topic-
    ///  specific metadata should be stored in Artifacts.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>A user-definable description of the availability of this service. Format: free-form, but we expect single words that describe availability, e.g., &quot;NONE&quot;, &quot;TESTING&quot;, &quot;PREVIEW&quot;, &quot;GENERAL&quot;, &quot;DEPRECATED&quot;, &quot;SHUTDOWN&quot;.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>A detailed description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-meaningful name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Labels attach identifying metadata to resources. Identifying metadata can
    ///  be used to filter list operations.
    /// 
    ///  Label keys and values can be no longer than 64 characters
    ///  (Unicode codepoints), can only contain lowercase letters, numeric
    ///  characters, underscores, and dashes. International characters are allowed.
    ///  No more than 64 user labels can be associated with one resource (System
    ///  labels are excluded).
    /// 
    ///  See https://goo.gl/xmQnxf for more information and examples of labels.
    ///  System reserved label keys are prefixed with
    ///  `apigeeregistry.googleapis.com/` and cannot be changed.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ApigeeRegistryAPISpecProjectRef ProjectRef { get; set; }

    /// <summary>The recommended deployment of the API. Format: `apis/{api}/deployments/{deployment}`</summary>
    [JsonPropertyName("recommendedDeployment")]
    public string? RecommendedDeployment { get; set; }

    /// <summary>The recommended version of the API. Format: `apis/{api}/versions/{version}`</summary>
    [JsonPropertyName("recommendedVersion")]
    public string? RecommendedVersion { get; set; }

    /// <summary>The ApigeeRegistryAPI name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeRegistryAPIStatusConditions
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
public partial class V1alpha1ApigeeRegistryAPIStatusObservedState
{
    /// <summary>Output only. Creation timestamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Last update timestamp.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ApigeeRegistryAPIStatus defines the config connector machine state of ApigeeRegistryAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeRegistryAPIStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApigeeRegistryAPIStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ApigeeRegistryAPI resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ApigeeRegistryAPIStatusObservedState? ObservedState { get; set; }
}

/// <summary>ApigeeRegistryAPI is the Schema for the ApigeeRegistryAPI API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeRegistryAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApigeeRegistryAPISpec>, IStatus<V1alpha1ApigeeRegistryAPIStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeRegistryAPI";
    public const string KubeGroup = "apigeeregistry.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeregistryapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigeeregistry.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApigeeRegistryAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApigeeRegistryAPISpec defines the desired state of ApigeeRegistryAPI</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ApigeeRegistryAPISpec Spec { get; set; }

    /// <summary>ApigeeRegistryAPIStatus defines the config connector machine state of ApigeeRegistryAPI</summary>
    [JsonPropertyName("status")]
    public V1alpha1ApigeeRegistryAPIStatus? Status { get; set; }
}