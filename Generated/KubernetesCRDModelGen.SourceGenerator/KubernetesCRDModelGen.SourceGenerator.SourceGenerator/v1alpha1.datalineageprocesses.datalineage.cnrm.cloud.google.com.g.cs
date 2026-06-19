#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalineage.cnrm.cloud.google.com;
/// <summary>DataLineageProcess is the Schema for the DataLineageProcess API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLineageProcessList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataLineageProcess>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLineageProcessList";
    public const string KubeGroup = "datalineage.cnrm.cloud.google.com";
    public const string KubePluralName = "datalineageprocesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalineage.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLineageProcessList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataLineageProcess objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataLineageProcess> Items { get; set; }
}

/// <summary>Optional. The origin of this process and its runs and lineage events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLineageProcessSpecOrigin
{
    /// <summary>
    /// If the source_type isn&apos;t CUSTOM, the value of this field should be a GCP
    ///  resource name of the system, which reports lineage. The project and
    ///  location parts of the resource name must match the project and location of
    ///  the lineage resource being created. Examples:
    /// 
    ///  - `{source_type: COMPOSER, name:
    ///    &quot;projects/foo/locations/us/environments/bar&quot;}`
    ///  - `{source_type: BIGQUERY, name: &quot;projects/foo/locations/eu&quot;}`
    ///  - `{source_type: CUSTOM,   name: &quot;myCustomIntegration&quot;}`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of the source.
    /// 
    ///  Use of a sourceType other than CUSTOM for process creation
    ///  or updating is highly discouraged. It might be restricted in the future
    ///  without notice. There will be increase in cost if you use any of the
    ///  source types other than CUSTOM.
    /// </summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLineageProcessSpecProjectRef
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

/// <summary>DataLineageProcessSpec defines the desired state of DataLineageProcess</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLineageProcessSpec
{
    /// <summary>
    /// Optional. The attributes of the process. Should only be used for the purpose of
    ///  non-semantic management (classifying, describing or labeling the process).
    /// 
    ///  Up to 100 attributes are allowed.
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, JsonNode>? Attributes { get; set; }

    /// <summary>Optional. A human-readable name you can set to display in a user interface. Must be not longer than 200 characters and only contain UTF-8 letters or numbers, spaces or characters like `_-:&amp;.`</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. The origin of this process and its runs and lineage events.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1DataLineageProcessSpecOrigin? Origin { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataLineageProcessSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataLineageProcess name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLineageProcessStatusConditions
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

/// <summary>DataLineageProcessStatus defines the config connector machine state of DataLineageProcess</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLineageProcessStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataLineageProcessStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataLineageProcess resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataLineageProcess is the Schema for the DataLineageProcess API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLineageProcess : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataLineageProcessSpec?>, IStatus<V1alpha1DataLineageProcessStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLineageProcess";
    public const string KubeGroup = "datalineage.cnrm.cloud.google.com";
    public const string KubePluralName = "datalineageprocesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalineage.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLineageProcess";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLineageProcessSpec defines the desired state of DataLineageProcess</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataLineageProcessSpec? Spec { get; set; }

    /// <summary>DataLineageProcessStatus defines the config connector machine state of DataLineageProcess</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataLineageProcessStatus? Status { get; set; }
}