#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.developerconnect.cnrm.cloud.google.com;
/// <summary>DevConnectInsightsConfig is the Schema for the DevConnectInsightsConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DevConnectInsightsConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DevConnectInsightsConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DevConnectInsightsConfigList";
    public const string KubeGroup = "developerconnect.cnrm.cloud.google.com";
    public const string KubePluralName = "devconnectinsightsconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "developerconnect.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DevConnectInsightsConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DevConnectInsightsConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DevConnectInsightsConfig> Items { get; set; }
}

/// <summary>Optional. The name of the App Hub Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigSpecAppHubApplicationRef
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

/// <summary>Optional. Set if the artifact metadata is stored in Artifact analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigSpecArtifactConfigsGoogleArtifactAnalysis
{
    /// <summary>Required. The project id of the project where the provenance is stored.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>Optional. Set if the artifact is stored in Artifact regsitry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigSpecArtifactConfigsGoogleArtifactRegistry
{
    /// <summary>Required. Immutable. The name of the artifact registry package.</summary>
    [JsonPropertyName("artifactRegistryPackage")]
    public string? ArtifactRegistryPackage { get; set; }

    /// <summary>Required. The host project of Artifact Registry.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigSpecArtifactConfigs
{
    /// <summary>Optional. Set if the artifact metadata is stored in Artifact analysis.</summary>
    [JsonPropertyName("googleArtifactAnalysis")]
    public V1alpha1DevConnectInsightsConfigSpecArtifactConfigsGoogleArtifactAnalysis? GoogleArtifactAnalysis { get; set; }

    /// <summary>Optional. Set if the artifact is stored in Artifact regsitry.</summary>
    [JsonPropertyName("googleArtifactRegistry")]
    public V1alpha1DevConnectInsightsConfigSpecArtifactConfigsGoogleArtifactRegistry? GoogleArtifactRegistry { get; set; }

    /// <summary>Required. Immutable. The URI of the artifact that is deployed. e.g. `us-docker.pkg.dev/my-project/my-repo/image`. The URI does not include the tag / digest because it captures a lineage of artifacts.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigSpecProjectRef
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

/// <summary>DevConnectInsightsConfigSpec defines the desired state of DevConnectInsightsConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigSpec
{
    /// <summary>Optional. The name of the App Hub Application.</summary>
    [JsonPropertyName("appHubApplicationRef")]
    public V1alpha1DevConnectInsightsConfigSpecAppHubApplicationRef? AppHubApplicationRef { get; set; }

    /// <summary>Optional. The artifact configurations of the artifacts that are deployed.</summary>
    [JsonPropertyName("artifactConfigs")]
    public IList<V1alpha1DevConnectInsightsConfigSpecArtifactConfigs>? ArtifactConfigs { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DevConnectInsightsConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DevConnectInsightsConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatusObservedStateErrors
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Output only. App Hub Workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatusObservedStateRuntimeConfigsAppHubWorkload
{
    /// <summary>Output only. The criticality of the App Hub Workload.</summary>
    [JsonPropertyName("criticality")]
    public string? Criticality { get; set; }

    /// <summary>Output only. The environment of the App Hub Workload.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>Required. Output only. Immutable. The name of the App Hub Workload. Format: `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.</summary>
    [JsonPropertyName("workload")]
    public string? Workload { get; set; }
}

/// <summary>Output only. Google Kubernetes Engine runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatusObservedStateRuntimeConfigsGkeWorkload
{
    /// <summary>Required. Immutable. The name of the GKE cluster. Format: `projects/{project}/locations/{location}/clusters/{cluster}`.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Output only. The name of the GKE deployment. Format: `projects/{project}/locations/{location}/clusters/{cluster}/namespaces/{namespace}/deployments/{deployment}`.</summary>
    [JsonPropertyName("deployment")]
    public string? Deployment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatusObservedStateRuntimeConfigs
{
    /// <summary>Output only. App Hub Workload.</summary>
    [JsonPropertyName("appHubWorkload")]
    public V1alpha1DevConnectInsightsConfigStatusObservedStateRuntimeConfigsAppHubWorkload? AppHubWorkload { get; set; }

    /// <summary>Output only. Google Kubernetes Engine runtime.</summary>
    [JsonPropertyName("gkeWorkload")]
    public V1alpha1DevConnectInsightsConfigStatusObservedStateRuntimeConfigsGkeWorkload? GkeWorkload { get; set; }

    /// <summary>Output only. The state of the Runtime.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Required. Immutable. The URI of the runtime configuration. For GKE, this is the cluster name. For Cloud Run, this is the service name.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatusObservedState
{
    /// <summary>Output only. [Output only] Create timestamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Any errors that occurred while setting up the InsightsConfig. Each error will be in the format: `field_name: error_message`, e.g. GetAppHubApplication: Permission denied while getting App Hub application. Please grant permissions to the P4SA.</summary>
    [JsonPropertyName("errors")]
    public IList<V1alpha1DevConnectInsightsConfigStatusObservedStateErrors>? Errors { get; set; }

    /// <summary>Output only. Reconciling (https://google.aip.dev/128#reconciliation). Set to true if the current state of InsightsConfig does not match the user&apos;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The runtime configurations where the application is deployed.</summary>
    [JsonPropertyName("runtimeConfigs")]
    public IList<V1alpha1DevConnectInsightsConfigStatusObservedStateRuntimeConfigs>? RuntimeConfigs { get; set; }

    /// <summary>Output only. The state of the InsightsConfig.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. [Output only] Update timestamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DevConnectInsightsConfigStatus defines the config connector machine state of DevConnectInsightsConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectInsightsConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DevConnectInsightsConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DevConnectInsightsConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DevConnectInsightsConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>DevConnectInsightsConfig is the Schema for the DevConnectInsightsConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DevConnectInsightsConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DevConnectInsightsConfigSpec>, IStatus<V1alpha1DevConnectInsightsConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DevConnectInsightsConfig";
    public const string KubeGroup = "developerconnect.cnrm.cloud.google.com";
    public const string KubePluralName = "devconnectinsightsconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "developerconnect.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DevConnectInsightsConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DevConnectInsightsConfigSpec defines the desired state of DevConnectInsightsConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DevConnectInsightsConfigSpec Spec { get; set; }

    /// <summary>DevConnectInsightsConfigStatus defines the config connector machine state of DevConnectInsightsConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1DevConnectInsightsConfigStatus? Status { get; set; }
}