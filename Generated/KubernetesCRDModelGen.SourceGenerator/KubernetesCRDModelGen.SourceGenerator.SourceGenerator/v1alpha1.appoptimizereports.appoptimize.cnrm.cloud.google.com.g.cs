#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appoptimize.cnrm.cloud.google.com;
/// <summary>AppOptimizeReport is the Schema for the AppOptimizeReport API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppOptimizeReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AppOptimizeReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppOptimizeReportList";
    public const string KubeGroup = "appoptimize.cnrm.cloud.google.com";
    public const string KubePluralName = "appoptimizereports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appoptimize.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppOptimizeReportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AppOptimizeReport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AppOptimizeReport> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportSpecProjectRef
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

/// <summary>Optional. An App Hub Application to fetch data from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportSpecScopesApplicationRef
{
    /// <summary>A reference to an externally managed AppHubApplication resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/applications/{{applicationID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of an AppHubApplication resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of an AppHubApplication resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A Google Cloud Platform project to fetch data from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportSpecScopesProjectRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportSpecScopes
{
    /// <summary>Optional. An App Hub Application to fetch data from.</summary>
    [JsonPropertyName("applicationRef")]
    public V1alpha1AppOptimizeReportSpecScopesApplicationRef? ApplicationRef { get; set; }

    /// <summary>Optional. A Google Cloud Platform project to fetch data from.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AppOptimizeReportSpecScopesProjectRef? ProjectRef { get; set; }
}

/// <summary>AppOptimizeReportSpec defines the desired state of AppOptimizeReport</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportSpec
{
    /// <summary>Required. A list of dimensions to include in the report. Supported values: * `project` * `application` * `service_or_workload` * `resource` * `resource_type` * `location` * `product_display_name` * `sku` * `month` * `day` * `hour`</summary>
    [JsonPropertyName("dimensions")]
    public required IList<string> Dimensions { get; set; }

    /// <summary>Optional. A Common Expression Language (CEL) expression used to filter the data for the report.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Required. A list of metrics to include in the report. Supported values: * `cost` * `cpu_mean_utilization` * `cpu_usage_core_seconds` * `cpu_allocation_core_seconds` * `cpu_p95_utilization` * `memory_mean_utilization` * `memory_usage_byte_seconds` * `memory_allocation_byte_seconds` * `memory_p95_utilization`</summary>
    [JsonPropertyName("metrics")]
    public required IList<string> Metrics { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1AppOptimizeReportSpecProjectRef ProjectRef { get; set; }

    /// <summary>The AppOptimizeReport name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The resource containers for which to fetch data. Default is the project specified in the report&apos;s parent.</summary>
    [JsonPropertyName("scopes")]
    public IList<V1alpha1AppOptimizeReportSpecScopes>? Scopes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportStatusConditions
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
public partial class V1alpha1AppOptimizeReportStatusObservedState
{
    /// <summary>Output only. Timestamp in UTC of when this report expires. Once the report expires, it will no longer be accessible and the report&apos;s underlying data will be deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }
}

/// <summary>AppOptimizeReportStatus defines the config connector machine state of AppOptimizeReport</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppOptimizeReportStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppOptimizeReportStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AppOptimizeReport resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AppOptimizeReportStatusObservedState? ObservedState { get; set; }
}

/// <summary>AppOptimizeReport is the Schema for the AppOptimizeReport API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppOptimizeReport : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppOptimizeReportSpec>, IStatus<V1alpha1AppOptimizeReportStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppOptimizeReport";
    public const string KubeGroup = "appoptimize.cnrm.cloud.google.com";
    public const string KubePluralName = "appoptimizereports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appoptimize.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppOptimizeReport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppOptimizeReportSpec defines the desired state of AppOptimizeReport</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AppOptimizeReportSpec Spec { get; set; }

    /// <summary>AppOptimizeReportStatus defines the config connector machine state of AppOptimizeReport</summary>
    [JsonPropertyName("status")]
    public V1alpha1AppOptimizeReportStatus? Status { get; set; }
}