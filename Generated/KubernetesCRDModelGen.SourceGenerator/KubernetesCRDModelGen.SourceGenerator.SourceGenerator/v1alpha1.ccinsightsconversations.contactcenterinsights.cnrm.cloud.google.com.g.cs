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
/// <summary>CCInsightsConversation is the Schema for the CCInsightsConversation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CCInsightsConversationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CCInsightsConversation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CCInsightsConversationList";
    public const string KubeGroup = "contactcenterinsights.cnrm.cloud.google.com";
    public const string KubePluralName = "ccinsightsconversations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contactcenterinsights.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CCInsightsConversationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CCInsightsConversation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CCInsightsConversation> Items { get; set; }
}

/// <summary>Call-specific metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpecCallMetadata
{
    /// <summary>The audio channel that contains the agent.</summary>
    [JsonPropertyName("agentChannel")]
    public int? AgentChannel { get; set; }

    /// <summary>The audio channel that contains the customer.</summary>
    [JsonPropertyName("customerChannel")]
    public int? CustomerChannel { get; set; }
}

/// <summary>The source when the conversation comes from Dialogflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpecDataSourceDialogflowSource
{
    /// <summary>Cloud Storage URI that points to a file that contains the conversation audio.</summary>
    [JsonPropertyName("audioURI")]
    public string? AudioURI { get; set; }
}

/// <summary>A Cloud Storage location specification for the audio and transcript.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpecDataSourceGcsSource
{
    /// <summary>Cloud Storage URI that points to a file that contains the conversation audio.</summary>
    [JsonPropertyName("audioURI")]
    public string? AudioURI { get; set; }

    /// <summary>Immutable. Cloud Storage URI that points to a file that contains the conversation transcript.</summary>
    [JsonPropertyName("transcriptURI")]
    public string? TranscriptURI { get; set; }
}

/// <summary>The source of the audio and transcription for the conversation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpecDataSource
{
    /// <summary>The source when the conversation comes from Dialogflow.</summary>
    [JsonPropertyName("dialogflowSource")]
    public V1alpha1CCInsightsConversationSpecDataSourceDialogflowSource? DialogflowSource { get; set; }

    /// <summary>A Cloud Storage location specification for the audio and transcript.</summary>
    [JsonPropertyName("gcsSource")]
    public V1alpha1CCInsightsConversationSpecDataSourceGcsSource? GcsSource { get; set; }
}

/// <summary>Immutable. The conversation medium, if unspecified will default to PHONE_CALL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1CCInsightsConversationSpecMediumEnum>))]
public enum V1alpha1CCInsightsConversationSpecMediumEnum
{
    [EnumMember(Value = "MEDIUM_UNSPECIFIED"), JsonStringEnumMemberName("MEDIUM_UNSPECIFIED")]
    MEDIUMUNSPECIFIED,
    [EnumMember(Value = "PHONE_CALL"), JsonStringEnumMemberName("PHONE_CALL")]
    PHONECALL,
    [EnumMember(Value = "CHAT"), JsonStringEnumMemberName("CHAT")]
    CHAT
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpecProjectRef
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
public partial class V1alpha1CCInsightsConversationSpecQualityMetadataAgentInfo
{
    /// <summary>A user-specified string representing the agent.</summary>
    [JsonPropertyName("agentID")]
    public string? AgentID { get; set; }

    /// <summary>The agent type, e.g. HUMAN_AGENT.</summary>
    [JsonPropertyName("agentType")]
    public string? AgentType { get; set; }

    /// <summary>The agent&apos;s name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A user-provided string indicating the outcome of the agent&apos;s segment of the call.</summary>
    [JsonPropertyName("dispositionCode")]
    public string? DispositionCode { get; set; }

    /// <summary>A user-specified string representing the agent&apos;s team.</summary>
    [JsonPropertyName("team")]
    public string? Team { get; set; }
}

/// <summary>Conversation metadata related to quality management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpecQualityMetadata
{
    /// <summary>Information about agents involved in the call.</summary>
    [JsonPropertyName("agentInfo")]
    public IList<V1alpha1CCInsightsConversationSpecQualityMetadataAgentInfo>? AgentInfo { get; set; }

    /// <summary>An arbitrary integer value indicating the customer&apos;s satisfaction rating.</summary>
    [JsonPropertyName("customerSatisfactionRating")]
    public int? CustomerSatisfactionRating { get; set; }

    /// <summary>An arbitrary string value specifying the menu path the customer took.</summary>
    [JsonPropertyName("menuPath")]
    public string? MenuPath { get; set; }

    /// <summary>The amount of time the customer waited to connect with an agent.</summary>
    [JsonPropertyName("waitDuration")]
    public string? WaitDuration { get; set; }
}

/// <summary>CCInsightsConversationSpec defines the desired state of CCInsightsConversation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationSpec
{
    /// <summary>An opaque, user-specified string representing the human agent who handled the conversation.</summary>
    [JsonPropertyName("agentID")]
    public string? AgentID { get; set; }

    /// <summary>Call-specific metadata.</summary>
    [JsonPropertyName("callMetadata")]
    public V1alpha1CCInsightsConversationSpecCallMetadata? CallMetadata { get; set; }

    /// <summary>The source of the audio and transcription for the conversation.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1CCInsightsConversationSpecDataSource? DataSource { get; set; }

    /// <summary>The time at which this conversation should expire. After this time, the conversation data and any associated analyses will be deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>A map for the user to specify any custom fields. A maximum of 100 labels per conversation is allowed, with a maximum of 256 characters per entry.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A user-specified language code for the conversation.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Immutable. The conversation medium, if unspecified will default to PHONE_CALL.</summary>
    [JsonPropertyName("medium")]
    public V1alpha1CCInsightsConversationSpecMediumEnum? Medium { get; set; }

    /// <summary>Input only. JSON metadata encoded as a string. This field is primarily used by Insights integrations with various telephony systems and must be in one of Insight&apos;s supported formats.</summary>
    [JsonPropertyName("metadataJson")]
    public string? MetadataJson { get; set; }

    /// <summary>Obfuscated user ID which the customer sent to us.</summary>
    [JsonPropertyName("obfuscatedUserID")]
    public string? ObfuscatedUserID { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CCInsightsConversationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Conversation metadata related to quality management.</summary>
    [JsonPropertyName("qualityMetadata")]
    public V1alpha1CCInsightsConversationSpecQualityMetadata? QualityMetadata { get; set; }

    /// <summary>The CCInsightsConversation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The time at which the conversation started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Input only. The TTL for this resource. If specified, then this TTL will be used to calculate the expire time.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusConditions
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

/// <summary>A manual list of scorecards to score.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelectorQaConfigScorecardList
{
    /// <summary>List of QaScorecardRevisions.</summary>
    [JsonPropertyName("qaScorecardRevisions")]
    public IList<string>? QaScorecardRevisions { get; set; }
}

/// <summary>Configuration for the QA annotator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelectorQaConfig
{
    /// <summary>A manual list of scorecards to score.</summary>
    [JsonPropertyName("scorecardList")]
    public V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelectorQaConfigScorecardList? ScorecardList { get; set; }
}

/// <summary>Configuration for the summarization annotator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelectorSummarizationConfig
{
    /// <summary>Resource name of the Dialogflow conversation profile. Format: projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</summary>
    [JsonPropertyName("conversationProfile")]
    public string? ConversationProfile { get; set; }

    /// <summary>Default summarization model to be used.</summary>
    [JsonPropertyName("summarizationModel")]
    public string? SummarizationModel { get; set; }
}

/// <summary>To select the annotators to run and the phrase matchers to use (if any). If not specified, all annotators will be run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelector
{
    /// <summary>The issue model to run. If not provided, the most recently deployed topic model will be used. The provided issue model will only be used for inference if the issue model is deployed and if run_issue_model_annotator is set to true. If more than one issue model is provided, only the first provided issue model will be used for inference.</summary>
    [JsonPropertyName("issueModels")]
    public IList<string>? IssueModels { get; set; }

    /// <summary>The list of phrase matchers to run. If not provided, all active phrase matchers will be used. If inactive phrase matchers are provided, they will not be used. Phrase matchers will be run only if run_phrase_matcher_annotator is set to true. Format: projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</summary>
    [JsonPropertyName("phraseMatchers")]
    public IList<string>? PhraseMatchers { get; set; }

    /// <summary>Configuration for the QA annotator.</summary>
    [JsonPropertyName("qaConfig")]
    public V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelectorQaConfig? QaConfig { get; set; }

    /// <summary>Whether to run the entity annotator.</summary>
    [JsonPropertyName("runEntityAnnotator")]
    public bool? RunEntityAnnotator { get; set; }

    /// <summary>Whether to run the intent annotator.</summary>
    [JsonPropertyName("runIntentAnnotator")]
    public bool? RunIntentAnnotator { get; set; }

    /// <summary>Whether to run the interruption annotator.</summary>
    [JsonPropertyName("runInterruptionAnnotator")]
    public bool? RunInterruptionAnnotator { get; set; }

    /// <summary>Whether to run the issue model annotator. A model should have already been deployed for this to take effect.</summary>
    [JsonPropertyName("runIssueModelAnnotator")]
    public bool? RunIssueModelAnnotator { get; set; }

    /// <summary>Whether to run the active phrase matcher annotator(s).</summary>
    [JsonPropertyName("runPhraseMatcherAnnotator")]
    public bool? RunPhraseMatcherAnnotator { get; set; }

    /// <summary>Whether to run the QA annotator.</summary>
    [JsonPropertyName("runQaAnnotator")]
    public bool? RunQaAnnotator { get; set; }

    /// <summary>Whether to run the sentiment annotator.</summary>
    [JsonPropertyName("runSentimentAnnotator")]
    public bool? RunSentimentAnnotator { get; set; }

    /// <summary>Whether to run the silence annotator.</summary>
    [JsonPropertyName("runSilenceAnnotator")]
    public bool? RunSilenceAnnotator { get; set; }

    /// <summary>Whether to run the summarization annotator.</summary>
    [JsonPropertyName("runSummarizationAnnotator")]
    public bool? RunSummarizationAnnotator { get; set; }

    /// <summary>Configuration for the summarization annotator.</summary>
    [JsonPropertyName("summarizationConfig")]
    public V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelectorSummarizationConfig? SummarizationConfig { get; set; }
}

/// <summary>Output only. The conversation&apos;s latest analysis, if one exists.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysis
{
    /// <summary>To select the annotators to run and the phrase matchers to use (if any). If not specified, all annotators will be run.</summary>
    [JsonPropertyName("annotatorSelector")]
    public V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysisAnnotatorSelector? AnnotatorSelector { get; set; }

    /// <summary>Immutable. The resource name of the analysis. Format: projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Output only. Latest summary of the conversation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateLatestSummary
{
    /// <summary>The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}</summary>
    [JsonPropertyName("answerRecord")]
    public string? AnswerRecord { get; set; }

    /// <summary>The confidence score of the summarization.</summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>The name of the model that generates this summary. Format: projects/{project}/locations/{location}/conversationModels/{conversation_model}</summary>
    [JsonPropertyName("conversationModel")]
    public string? ConversationModel { get; set; }

    /// <summary>A map that contains metadata about the summarization and the document from which it originates.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The summarization content that is concatenated into one string.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>The summarization content that is divided into sections. The key is the section&apos;s name and the value is the section&apos;s content. There is no specific format for the key or value.</summary>
    [JsonPropertyName("textSections")]
    public IDictionary<string, string>? TextSections { get; set; }
}

/// <summary>The feedback that the customer has about the answer in `data`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsAnswerFeedback
{
    /// <summary>Indicates whether an answer or item was clicked by the human agent.</summary>
    [JsonPropertyName("clicked")]
    public bool? Clicked { get; set; }

    /// <summary>The correctness level of an answer.</summary>
    [JsonPropertyName("correctnessLevel")]
    public string? CorrectnessLevel { get; set; }

    /// <summary>Indicates whether an answer or item was displayed to the human agent in the agent desktop UI.</summary>
    [JsonPropertyName("displayed")]
    public bool? Displayed { get; set; }
}

/// <summary>Agent Assist Article Suggestion data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsArticleSuggestion
{
    /// <summary>The system&apos;s confidence score that this article is a good match for this conversation, ranging from 0.0 (completely uncertain) to 1.0 (completely certain).</summary>
    [JsonPropertyName("confidenceScore")]
    public double? ConfidenceScore { get; set; }

    /// <summary>Map that contains metadata about the Article Suggestion and the document that it originates from.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}</summary>
    [JsonPropertyName("queryRecord")]
    public string? QueryRecord { get; set; }

    /// <summary>The knowledge document that this answer was extracted from. Format: projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Article title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Article URI.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Conversation summarization suggestion data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsConversationSummarizationSuggestion
{
    /// <summary>The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}</summary>
    [JsonPropertyName("answerRecord")]
    public string? AnswerRecord { get; set; }

    /// <summary>The confidence score of the summarization.</summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>The name of the model that generates this summary. Format: projects/{project}/locations/{location}/conversationModels/{conversation_model}</summary>
    [JsonPropertyName("conversationModel")]
    public string? ConversationModel { get; set; }

    /// <summary>A map that contains metadata about the summarization and the document from which it originates.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The summarization content that is concatenated into one string.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>The summarization content that is divided into sections. The key is the section&apos;s name and the value is the section&apos;s content. There is no specific format for the key or value.</summary>
    [JsonPropertyName("textSections")]
    public IDictionary<string, string>? TextSections { get; set; }
}

/// <summary>Dialogflow interaction data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsDialogflowInteraction
{
    /// <summary>The confidence of the match ranging from 0.0 (completely uncertain) to 1.0 (completely certain).</summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>The Dialogflow intent resource path. Format: projects/{project}/agent/{agent}/intents/{intent}</summary>
    [JsonPropertyName("dialogflowIntentID")]
    public string? DialogflowIntentID { get; set; }
}

/// <summary>The boundary in the conversation where the annotation ends, inclusive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsEndBoundary
{
    /// <summary>The index in the sequence of transcribed pieces of the conversation where the boundary is located. This index starts at zero.</summary>
    [JsonPropertyName("transcriptIndex")]
    public int? TranscriptIndex { get; set; }

    /// <summary>The word index of this boundary with respect to the first word in the transcript piece. This index starts at zero.</summary>
    [JsonPropertyName("wordIndex")]
    public int? WordIndex { get; set; }
}

/// <summary>Agent Assist FAQ answer data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsFaqAnswer
{
    /// <summary>The piece of text from the `source` knowledge base document.</summary>
    [JsonPropertyName("answer")]
    public string? Answer { get; set; }

    /// <summary>The system&apos;s confidence score that this answer is a good match for this conversation, ranging from 0.0 (completely uncertain) to 1.0 (completely certain).</summary>
    [JsonPropertyName("confidenceScore")]
    public double? ConfidenceScore { get; set; }

    /// <summary>Map that contains metadata about the FAQ answer and the document that it originates from.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}</summary>
    [JsonPropertyName("queryRecord")]
    public string? QueryRecord { get; set; }

    /// <summary>The corresponding FAQ question.</summary>
    [JsonPropertyName("question")]
    public string? Question { get; set; }

    /// <summary>The knowledge document that this answer was extracted from. Format: projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>Agent Assist Smart Compose suggestion data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsSmartComposeSuggestion
{
    /// <summary>The system&apos;s confidence score that this suggestion is a good match for this conversation, ranging from 0.0 (completely uncertain) to 1.0 (completely certain).</summary>
    [JsonPropertyName("confidenceScore")]
    public double? ConfidenceScore { get; set; }

    /// <summary>Map that contains metadata about the Smart Compose suggestion and the document from which it originates.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}</summary>
    [JsonPropertyName("queryRecord")]
    public string? QueryRecord { get; set; }

    /// <summary>The content of the suggestion.</summary>
    [JsonPropertyName("suggestion")]
    public string? Suggestion { get; set; }
}

/// <summary>Agent Assist Smart Reply data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsSmartReply
{
    /// <summary>The system&apos;s confidence score that this reply is a good match for this conversation, ranging from 0.0 (completely uncertain) to 1.0 (completely certain).</summary>
    [JsonPropertyName("confidenceScore")]
    public double? ConfidenceScore { get; set; }

    /// <summary>Map that contains metadata about the Smart Reply and the document from which it originates.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}</summary>
    [JsonPropertyName("queryRecord")]
    public string? QueryRecord { get; set; }

    /// <summary>The content of the reply.</summary>
    [JsonPropertyName("reply")]
    public string? Reply { get; set; }
}

/// <summary>The boundary in the conversation where the annotation starts, inclusive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsStartBoundary
{
    /// <summary>The index in the sequence of transcribed pieces of the conversation where the boundary is located. This index starts at zero.</summary>
    [JsonPropertyName("transcriptIndex")]
    public int? TranscriptIndex { get; set; }

    /// <summary>The word index of this boundary with respect to the first word in the transcript piece. This index starts at zero.</summary>
    [JsonPropertyName("wordIndex")]
    public int? WordIndex { get; set; }
}

/// <summary>Explicit input used for generating the answer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsUserInput
{
    /// <summary>The resource name of associated generator. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`</summary>
    [JsonPropertyName("generatorName")]
    public string? GeneratorName { get; set; }

    /// <summary>Query text. Article Search uses this to store the input query used to generate the search results.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Query source for the answer.</summary>
    [JsonPropertyName("querySource")]
    public string? QuerySource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotations
{
    /// <summary>The unique identifier of the annotation. Format: projects/{project}/locations/{location}/conversationDatasets/{dataset}/conversationDataItems/{data_item}/conversationAnnotations/{annotation}</summary>
    [JsonPropertyName("annotationID")]
    public string? AnnotationID { get; set; }

    /// <summary>The feedback that the customer has about the answer in `data`.</summary>
    [JsonPropertyName("answerFeedback")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsAnswerFeedback? AnswerFeedback { get; set; }

    /// <summary>Agent Assist Article Suggestion data.</summary>
    [JsonPropertyName("articleSuggestion")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsArticleSuggestion? ArticleSuggestion { get; set; }

    /// <summary>Conversation summarization suggestion data.</summary>
    [JsonPropertyName("conversationSummarizationSuggestion")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsConversationSummarizationSuggestion? ConversationSummarizationSuggestion { get; set; }

    /// <summary>The time at which this annotation was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Dialogflow interaction data.</summary>
    [JsonPropertyName("dialogflowInteraction")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsDialogflowInteraction? DialogflowInteraction { get; set; }

    /// <summary>The boundary in the conversation where the annotation ends, inclusive.</summary>
    [JsonPropertyName("endBoundary")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsEndBoundary? EndBoundary { get; set; }

    /// <summary>Agent Assist FAQ answer data.</summary>
    [JsonPropertyName("faqAnswer")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsFaqAnswer? FaqAnswer { get; set; }

    /// <summary>Agent Assist Smart Compose suggestion data.</summary>
    [JsonPropertyName("smartComposeSuggestion")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsSmartComposeSuggestion? SmartComposeSuggestion { get; set; }

    /// <summary>Agent Assist Smart Reply data.</summary>
    [JsonPropertyName("smartReply")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsSmartReply? SmartReply { get; set; }

    /// <summary>The boundary in the conversation where the annotation starts, inclusive.</summary>
    [JsonPropertyName("startBoundary")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsStartBoundary? StartBoundary { get; set; }

    /// <summary>Explicit input used for generating the answer</summary>
    [JsonPropertyName("userInput")]
    public V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotationsUserInput? UserInput { get; set; }
}

/// <summary>CCAI metadata relating to the current transcript segment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsDialogflowSegmentMetadata
{
    /// <summary>Whether the transcript segment was covered under the configured smart reply allowlist in Agent Assist.</summary>
    [JsonPropertyName("smartReplyAllowlistCovered")]
    public bool? SmartReplyAllowlistCovered { get; set; }
}

/// <summary>The participant of this segment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsSegmentParticipant
{
    /// <summary>Deprecated. Use `dialogflow_participant_name` instead. The name of the Dialogflow participant. Format: projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</summary>
    [JsonPropertyName("dialogflowParticipant")]
    public string? DialogflowParticipant { get; set; }

    /// <summary>The name of the participant provided by Dialogflow. Format: projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</summary>
    [JsonPropertyName("dialogflowParticipantName")]
    public string? DialogflowParticipantName { get; set; }

    /// <summary>Obfuscated user ID from Dialogflow.</summary>
    [JsonPropertyName("obfuscatedExternalUserID")]
    public string? ObfuscatedExternalUserID { get; set; }

    /// <summary>The role of the participant.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A user-specified ID representing the participant.</summary>
    [JsonPropertyName("userID")]
    public string? UserID { get; set; }
}

/// <summary>The sentiment for this transcript segment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsSentiment
{
    /// <summary>A non-negative number from 0 to infinity which represents the abolute magnitude of sentiment regardless of score.</summary>
    [JsonPropertyName("magnitude")]
    public double? Magnitude { get; set; }

    /// <summary>The sentiment score between -1.0 (negative) and 1.0 (positive).</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsWords
{
    /// <summary>A confidence estimate between 0.0 and 1.0 of the fidelity of this word. A default value of 0.0 indicates that the value is unset.</summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>Time offset of the end of this word relative to the beginning of the total conversation.</summary>
    [JsonPropertyName("endOffset")]
    public string? EndOffset { get; set; }

    /// <summary>Time offset of the start of this word relative to the beginning of the total conversation.</summary>
    [JsonPropertyName("startOffset")]
    public string? StartOffset { get; set; }

    /// <summary>The word itself. Includes punctuation marks that surround the word.</summary>
    [JsonPropertyName("word")]
    public string? Word { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegments
{
    /// <summary>For conversations derived from multi-channel audio, this is the channel number corresponding to the audio from that channel. For audioChannelCount = N, its output values can range from &apos;1&apos; to &apos;N&apos;. A channel tag of 0 indicates that the audio is mono.</summary>
    [JsonPropertyName("channelTag")]
    public int? ChannelTag { get; set; }

    /// <summary>A confidence estimate between 0.0 and 1.0 of the fidelity of this segment. A default value of 0.0 indicates that the value is unset.</summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>CCAI metadata relating to the current transcript segment.</summary>
    [JsonPropertyName("dialogflowSegmentMetadata")]
    public V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsDialogflowSegmentMetadata? DialogflowSegmentMetadata { get; set; }

    /// <summary>The language code of this segment as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. Example: &quot;en-US&quot;.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>The time that the message occurred, if provided.</summary>
    [JsonPropertyName("messageTime")]
    public string? MessageTime { get; set; }

    /// <summary>The participant of this segment.</summary>
    [JsonPropertyName("segmentParticipant")]
    public V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsSegmentParticipant? SegmentParticipant { get; set; }

    /// <summary>The sentiment for this transcript segment.</summary>
    [JsonPropertyName("sentiment")]
    public V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsSentiment? Sentiment { get; set; }

    /// <summary>The text of this segment.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>A list of the word-specific information for each word in the segment.</summary>
    [JsonPropertyName("words")]
    public IList<V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegmentsWords>? Words { get; set; }
}

/// <summary>Output only. The conversation transcript.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedStateTranscript
{
    /// <summary>A list of sequential transcript segments that comprise the conversation.</summary>
    [JsonPropertyName("transcriptSegments")]
    public IList<V1alpha1CCInsightsConversationStatusObservedStateTranscriptTranscriptSegments>? TranscriptSegments { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatusObservedState
{
    /// <summary>Output only. The time at which the conversation was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The duration of the conversation.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Output only. The conversation&apos;s latest analysis, if one exists.</summary>
    [JsonPropertyName("latestAnalysis")]
    public V1alpha1CCInsightsConversationStatusObservedStateLatestAnalysis? LatestAnalysis { get; set; }

    /// <summary>Output only. Latest summary of the conversation.</summary>
    [JsonPropertyName("latestSummary")]
    public V1alpha1CCInsightsConversationStatusObservedStateLatestSummary? LatestSummary { get; set; }

    /// <summary>Output only. The annotations that were generated during the customer and agent interaction.</summary>
    [JsonPropertyName("runtimeAnnotations")]
    public IList<V1alpha1CCInsightsConversationStatusObservedStateRuntimeAnnotations>? RuntimeAnnotations { get; set; }

    /// <summary>Output only. The conversation transcript.</summary>
    [JsonPropertyName("transcript")]
    public V1alpha1CCInsightsConversationStatusObservedStateTranscript? Transcript { get; set; }

    /// <summary>Output only. The number of turns in the conversation.</summary>
    [JsonPropertyName("turnCount")]
    public int? TurnCount { get; set; }

    /// <summary>Output only. The most recent time at which the conversation was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CCInsightsConversationStatus defines the config connector machine state of CCInsightsConversation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsConversationStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CCInsightsConversationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CCInsightsConversation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CCInsightsConversationStatusObservedState? ObservedState { get; set; }
}

/// <summary>CCInsightsConversation is the Schema for the CCInsightsConversation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CCInsightsConversation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CCInsightsConversationSpec>, IStatus<V1alpha1CCInsightsConversationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CCInsightsConversation";
    public const string KubeGroup = "contactcenterinsights.cnrm.cloud.google.com";
    public const string KubePluralName = "ccinsightsconversations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contactcenterinsights.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CCInsightsConversation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CCInsightsConversationSpec defines the desired state of CCInsightsConversation</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CCInsightsConversationSpec Spec { get; set; }

    /// <summary>CCInsightsConversationStatus defines the config connector machine state of CCInsightsConversation</summary>
    [JsonPropertyName("status")]
    public V1alpha1CCInsightsConversationStatus? Status { get; set; }
}