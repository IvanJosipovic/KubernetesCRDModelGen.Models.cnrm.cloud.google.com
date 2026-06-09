#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.discoveryengine.cnrm.cloud.google.com;
/// <summary>DiscoveryEngineConversation is the Schema for the DiscoveryEngineConversation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineConversationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DiscoveryEngineConversation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineConversationList";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryengineconversations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "discoveryengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiscoveryEngineConversationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DiscoveryEngineConversation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DiscoveryEngineConversation> Items { get; set; }
}

/// <summary>The DataStore this conversation belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecDataStoreRef
{
    /// <summary>A reference to an externally managed DiscoveryEngineDataStore resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/datastores/{{datastoreID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A collection of Safety Attribute categories and their associated confidence scores.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySafetyAttributes
{
    /// <summary>The display names of Safety Attribute categories associated with the generated content. Order matches the Scores.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The confidence scores of the each category, higher value means higher confidence. Order matches the Categories.</summary>
    [JsonPropertyName("scores")]
    public IList<double>? Scores { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataCitationMetadataCitationsSources
{
    /// <summary>Document reference index from SummaryWithMetadata.references. It is 0-indexed and the value will be zero if the reference_index is not set explicitly.</summary>
    [JsonPropertyName("referenceIndex")]
    public long? ReferenceIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataCitationMetadataCitations
{
    /// <summary>End of the attributed segment, exclusive.</summary>
    [JsonPropertyName("endIndex")]
    public long? EndIndex { get; set; }

    /// <summary>Citation sources for the attributed segment.</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataCitationMetadataCitationsSources>? Sources { get; set; }

    /// <summary>Index indicates the start of the segment, measured in bytes/unicode.</summary>
    [JsonPropertyName("startIndex")]
    public long? StartIndex { get; set; }
}

/// <summary>Citation metadata for given summary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataCitationMetadata
{
    /// <summary>Citations for segments.</summary>
    [JsonPropertyName("citations")]
    public IList<V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataCitationMetadataCitations>? Citations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataReferencesChunkContents
{
    /// <summary>Chunk textual content.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Page identifier.</summary>
    [JsonPropertyName("pageIdentifier")]
    public string? PageIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataReferences
{
    /// <summary>List of cited chunk contents derived from document content.</summary>
    [JsonPropertyName("chunkContents")]
    public IList<V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataReferencesChunkContents>? ChunkContents { get; set; }

    /// <summary>Required. [Document.name][google.cloud.discoveryengine.v1.Document.name] of the document. Full resource name of the referenced document, in the format `projects/*/locations/*/collections/*/dataStores/*/branches/*/documents/*`.</summary>
    [JsonPropertyName("document")]
    public string? Document { get; set; }

    /// <summary>Title of the document.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Cloud Storage or HTTP uri for the document.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Summary with metadata information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadata
{
    /// <summary>Citation metadata for given summary.</summary>
    [JsonPropertyName("citationMetadata")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataCitationMetadata? CitationMetadata { get; set; }

    /// <summary>Document References.</summary>
    [JsonPropertyName("references")]
    public IList<V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadataReferences>? References { get; set; }

    /// <summary>Summary text with no citation information.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }
}

/// <summary>Summary based on search results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReplySummary
{
    /// <summary>A collection of Safety Attribute categories and their associated confidence scores.</summary>
    [JsonPropertyName("safetyAttributes")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySafetyAttributes? SafetyAttributes { get; set; }

    /// <summary>Additional summary-skipped reasons. This provides the reason for ignored cases. If nothing is skipped, this field is not set.</summary>
    [JsonPropertyName("summarySkippedReasons")]
    public IList<string>? SummarySkippedReasons { get; set; }

    /// <summary>The summary content.</summary>
    [JsonPropertyName("summaryText")]
    public string? SummaryText { get; set; }

    /// <summary>Summary with metadata information.</summary>
    [JsonPropertyName("summaryWithMetadata")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesReplySummarySummaryWithMetadata? SummaryWithMetadata { get; set; }
}

/// <summary>Search reply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesReply
{
    /// <summary>Summary based on search results.</summary>
    [JsonPropertyName("summary")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesReplySummary? Summary { get; set; }
}

/// <summary>Conversation context of the input.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesUserInputContext
{
    /// <summary>The current active document the user opened. It contains the document resource reference.</summary>
    [JsonPropertyName("activeDocument")]
    public string? ActiveDocument { get; set; }

    /// <summary>The current list of documents the user is seeing. It contains the document resource references.</summary>
    [JsonPropertyName("contextDocuments")]
    public IList<string>? ContextDocuments { get; set; }
}

/// <summary>User text input.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessagesUserInput
{
    /// <summary>Conversation context of the input.</summary>
    [JsonPropertyName("context")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesUserInputContext? Context { get; set; }

    /// <summary>Text input.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecMessages
{
    /// <summary>Search reply.</summary>
    [JsonPropertyName("reply")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesReply? Reply { get; set; }

    /// <summary>User text input.</summary>
    [JsonPropertyName("userInput")]
    public V1alpha1DiscoveryEngineConversationSpecMessagesUserInput? UserInput { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpecProjectRef
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

/// <summary>The state of the Conversation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1DiscoveryEngineConversationSpecStateEnum>))]
public enum V1alpha1DiscoveryEngineConversationSpecStateEnum
{
    [EnumMember(Value = "STATE_UNSPECIFIED"), JsonStringEnumMemberName("STATE_UNSPECIFIED")]
    STATEUNSPECIFIED,
    [EnumMember(Value = "IN_PROGRESS"), JsonStringEnumMemberName("IN_PROGRESS")]
    INPROGRESS,
    [EnumMember(Value = "COMPLETED"), JsonStringEnumMemberName("COMPLETED")]
    COMPLETED
}

/// <summary>DiscoveryEngineConversationSpec defines the desired state of DiscoveryEngineConversation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationSpec
{
    /// <summary>The DataStore this conversation belongs to.</summary>
    [JsonPropertyName("dataStoreRef")]
    public required V1alpha1DiscoveryEngineConversationSpecDataStoreRef DataStoreRef { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Conversation messages.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DiscoveryEngineConversationSpecMessages>? Messages { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DiscoveryEngineConversationSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DiscoveryEngineConversation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The state of the Conversation.</summary>
    [JsonPropertyName("state")]
    public V1alpha1DiscoveryEngineConversationSpecStateEnum? State { get; set; }

    /// <summary>A unique identifier for tracking users.</summary>
    [JsonPropertyName("userPseudoID")]
    public string? UserPseudoID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationStatusConditions
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
public partial class V1alpha1DiscoveryEngineConversationStatusObservedState
{
    /// <summary>Output only. The time the conversation finished.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The time the conversation started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>DiscoveryEngineConversationStatus defines the config connector machine state of DiscoveryEngineConversation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineConversationStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineConversationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DiscoveryEngineConversation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DiscoveryEngineConversationStatusObservedState? ObservedState { get; set; }
}

/// <summary>DiscoveryEngineConversation is the Schema for the DiscoveryEngineConversation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineConversation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DiscoveryEngineConversationSpec>, IStatus<V1alpha1DiscoveryEngineConversationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineConversation";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryengineconversations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "discoveryengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiscoveryEngineConversation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiscoveryEngineConversationSpec defines the desired state of DiscoveryEngineConversation</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DiscoveryEngineConversationSpec Spec { get; set; }

    /// <summary>DiscoveryEngineConversationStatus defines the config connector machine state of DiscoveryEngineConversation</summary>
    [JsonPropertyName("status")]
    public V1alpha1DiscoveryEngineConversationStatus? Status { get; set; }
}