#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.geminidataanalytics.cnrm.cloud.google.com;
/// <summary>GeminiDataAnalyticsConversation is the Schema for the GeminiDataAnalyticsConversation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GeminiDataAnalyticsConversationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GeminiDataAnalyticsConversation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GeminiDataAnalyticsConversationList";
    public const string KubeGroup = "geminidataanalytics.cnrm.cloud.google.com";
    public const string KubePluralName = "geminidataanalyticsconversations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "geminidataanalytics.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GeminiDataAnalyticsConversationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1GeminiDataAnalyticsConversation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1GeminiDataAnalyticsConversation> Items { get; set; }
}

/// <summary>GeminiDataAnalyticsDataAgentRef is a reference to a DataAgent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GeminiDataAnalyticsConversationSpecAgentRefs
{
    /// <summary>A reference to an externally managed DataAgent resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/dataAgents/{{dataAgentID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GeminiDataAnalyticsConversationSpecProjectRef
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

/// <summary>GeminiDataAnalyticsConversationSpec defines the desired state of GeminiDataAnalyticsConversation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GeminiDataAnalyticsConversationSpec
{
    /// <summary>Required. Agent(s) in the conversation. Currently, only one agent is supported. This field is repeated to allow for future support of multiple agents in a conversation.</summary>
    [JsonPropertyName("agentRefs")]
    public required IList<V1alpha1GeminiDataAnalyticsConversationSpecAgentRefs> AgentRefs { get; set; }

    /// <summary>Optional. Open-ended and user-defined labels that can be set by the client to tag a conversation.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1GeminiDataAnalyticsConversationSpecProjectRef ProjectRef { get; set; }

    /// <summary>The GeminiDataAnalyticsConversation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GeminiDataAnalyticsConversationStatusConditions
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
public partial class V1alpha1GeminiDataAnalyticsConversationStatusObservedState
{
    /// <summary>Output only. Creation timestamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Timestamp of the last used conversation.</summary>
    [JsonPropertyName("lastUsedTime")]
    public string? LastUsedTime { get; set; }
}

/// <summary>GeminiDataAnalyticsConversationStatus defines the config connector machine state of GeminiDataAnalyticsConversation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GeminiDataAnalyticsConversationStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GeminiDataAnalyticsConversationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the GeminiDataAnalyticsConversation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1GeminiDataAnalyticsConversationStatusObservedState? ObservedState { get; set; }
}

/// <summary>GeminiDataAnalyticsConversation is the Schema for the GeminiDataAnalyticsConversation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GeminiDataAnalyticsConversation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GeminiDataAnalyticsConversationSpec>, IStatus<V1alpha1GeminiDataAnalyticsConversationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GeminiDataAnalyticsConversation";
    public const string KubeGroup = "geminidataanalytics.cnrm.cloud.google.com";
    public const string KubePluralName = "geminidataanalyticsconversations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "geminidataanalytics.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GeminiDataAnalyticsConversation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GeminiDataAnalyticsConversationSpec defines the desired state of GeminiDataAnalyticsConversation</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1GeminiDataAnalyticsConversationSpec Spec { get; set; }

    /// <summary>GeminiDataAnalyticsConversationStatus defines the config connector machine state of GeminiDataAnalyticsConversation</summary>
    [JsonPropertyName("status")]
    public V1alpha1GeminiDataAnalyticsConversationStatus? Status { get; set; }
}