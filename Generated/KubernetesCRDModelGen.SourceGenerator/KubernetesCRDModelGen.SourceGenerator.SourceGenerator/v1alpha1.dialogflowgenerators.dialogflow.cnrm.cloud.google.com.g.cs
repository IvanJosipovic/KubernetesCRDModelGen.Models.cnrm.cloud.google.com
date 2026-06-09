#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflow.cnrm.cloud.google.com;
/// <summary>DialogflowGenerator is the Schema for the DialogflowGenerator API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowGeneratorList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DialogflowGenerator>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowGeneratorList";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowgenerators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowGeneratorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DialogflowGenerator objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DialogflowGenerator> Items { get; set; }
}

/// <summary>Input of free from generator to LLM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecFreeFormContext
{
    /// <summary>Optional. Free form text input to LLM.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Optional. Inference parameters for this generator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecInferenceParameter
{
    /// <summary>Optional. Maximum number of the output tokens for the generator.</summary>
    [JsonPropertyName("maxOutputTokens")]
    public int? MaxOutputTokens { get; set; }

    /// <summary>Optional. Controls the randomness of LLM predictions. Low temperature = less random. High temperature = more random. If unset (or 0), uses a default value of 0.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Optional. Top-k changes how the model selects tokens for output. A top-k of 1 means the selected token is the most probable among all tokens in the model&apos;s vocabulary (also called greedy decoding), while a top-k of 3 means that the next token is selected from among the 3 most probable tokens (using temperature). For each token selection step, the top K tokens with the highest probabilities are sampled. Then tokens are further filtered based on topP with the final token selected using temperature sampling. Specify a lower value for less random responses and a higher value for more random responses. Acceptable value is [1, 40], default to 40.</summary>
    [JsonPropertyName("topK")]
    public int? TopK { get; set; }

    /// <summary>Optional. Top-p changes how the model selects tokens for output. Tokens are selected from most K (see topK parameter) probable to least until the sum of their probabilities equals the top-p value. For example, if tokens A, B, and C have a probability of 0.3, 0.2, and 0.1 and the top-p value is 0.5, then the model will select either A or B as the next token (using temperature) and doesn&apos;t consider C. The default top-p value is 0.95. Specify a lower value for less random responses and a higher value for more random responses. Acceptable value is [0.0, 1.0], default to 0.95.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecProjectRef
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
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesConversationContextMessageEntries
{
    /// <summary>Optional. Create time of the message entry.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. The language of the text. See [Language Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported language codes.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Optional. Participant role of the message.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Optional. Transcript content of the message.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Optional. Conversation transcripts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesConversationContext
{
    /// <summary>Optional. List of message transcripts in the conversation.</summary>
    [JsonPropertyName("messageEntries")]
    public IList<V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesConversationContextMessageEntries>? MessageEntries { get; set; }
}

/// <summary>Optional. Free form suggestion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutputFreeFormSuggestion
{
    /// <summary>Required. Free form suggestion.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutputSummarySuggestionSummarySections
{
    /// <summary>Required. Name of the section.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Required. Summary text for the section.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }
}

/// <summary>Optional. Suggested summary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutputSummarySuggestion
{
    /// <summary>Required. All the parts of generated summary.</summary>
    [JsonPropertyName("summarySections")]
    public IList<V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutputSummarySuggestionSummarySections>? SummarySections { get; set; }
}

/// <summary>Required. Example output of the model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutput
{
    /// <summary>Optional. Free form suggestion.</summary>
    [JsonPropertyName("freeFormSuggestion")]
    public V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutputFreeFormSuggestion? FreeFormSuggestion { get; set; }

    /// <summary>Optional. Suggested summary.</summary>
    [JsonPropertyName("summarySuggestion")]
    public V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutputSummarySuggestion? SummarySuggestion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesSummarizationSectionListSummarizationSections
{
    /// <summary>Optional. Definition of the section, for example, &quot;what the customer needs help with or has question about.&quot;</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Optional. Name of the section, for example, &quot;situation&quot;.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Optional. Type of the summarization section.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Summarization sections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesSummarizationSectionList
{
    /// <summary>Optional. Summarization sections.</summary>
    [JsonPropertyName("summarizationSections")]
    public IList<V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesSummarizationSectionListSummarizationSections>? SummarizationSections { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamples
{
    /// <summary>Optional. Conversation transcripts.</summary>
    [JsonPropertyName("conversationContext")]
    public V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesConversationContext? ConversationContext { get; set; }

    /// <summary>Optional. Key is the placeholder field name in input, value is the value of the placeholder. E.g. instruction contains &quot;@price&quot;, and ingested data has &lt; &quot;price&quot;, &quot;10&quot; &gt;</summary>
    [JsonPropertyName("extraInfo")]
    public IDictionary<string, string>? ExtraInfo { get; set; }

    /// <summary>Required. Example output of the model.</summary>
    [JsonPropertyName("output")]
    public V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesOutput? Output { get; set; }

    /// <summary>Summarization sections.</summary>
    [JsonPropertyName("summarizationSectionList")]
    public V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamplesSummarizationSectionList? SummarizationSectionList { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContextSummarizationSections
{
    /// <summary>Optional. Definition of the section, for example, &quot;what the customer needs help with or has question about.&quot;</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Optional. Name of the section, for example, &quot;situation&quot;.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Optional. Type of the summarization section.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Input of prebuilt Summarization feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpecSummarizationContext
{
    /// <summary>Optional. List of few shot examples.</summary>
    [JsonPropertyName("fewShotExamples")]
    public IList<V1alpha1DialogflowGeneratorSpecSummarizationContextFewShotExamples>? FewShotExamples { get; set; }

    /// <summary>Optional. The target language of the generated summary. The language code for conversation will be used if this field is empty. Supported 2.0 and later versions.</summary>
    [JsonPropertyName("outputLanguageCode")]
    public string? OutputLanguageCode { get; set; }

    /// <summary>Optional. List of sections. Note it contains both predefined section sand customer defined sections.</summary>
    [JsonPropertyName("summarizationSections")]
    public IList<V1alpha1DialogflowGeneratorSpecSummarizationContextSummarizationSections>? SummarizationSections { get; set; }

    /// <summary>Optional. Version of the feature. If not set, default to latest version. Current candidates are [&quot;1.0&quot;].</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>DialogflowGeneratorSpec defines the desired state of DialogflowGenerator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorSpec
{
    /// <summary>Optional. Human readable description of the generator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input of free from generator to LLM.</summary>
    [JsonPropertyName("freeFormContext")]
    public V1alpha1DialogflowGeneratorSpecFreeFormContext? FreeFormContext { get; set; }

    /// <summary>Optional. Inference parameters for this generator.</summary>
    [JsonPropertyName("inferenceParameter")]
    public V1alpha1DialogflowGeneratorSpecInferenceParameter? InferenceParameter { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DialogflowGeneratorSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. The published Large Language Model name.</summary>
    [JsonPropertyName("publishedModel")]
    public string? PublishedModel { get; set; }

    /// <summary>The DialogflowGenerator name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Input of prebuilt Summarization feature.</summary>
    [JsonPropertyName("summarizationContext")]
    public V1alpha1DialogflowGeneratorSpecSummarizationContext? SummarizationContext { get; set; }

    /// <summary>Optional. The trigger event of the generator. It defines when the generator is triggered in a conversation.</summary>
    [JsonPropertyName("triggerEvent")]
    public string? TriggerEvent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorStatusConditions
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
public partial class V1alpha1DialogflowGeneratorStatusObservedState
{
    /// <summary>Output only. Creation time of this generator.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Update time of this generator.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DialogflowGeneratorStatus defines the config connector machine state of DialogflowGenerator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowGeneratorStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowGeneratorStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DialogflowGenerator resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DialogflowGeneratorStatusObservedState? ObservedState { get; set; }
}

/// <summary>DialogflowGenerator is the Schema for the DialogflowGenerator API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowGenerator : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowGeneratorSpec>, IStatus<V1alpha1DialogflowGeneratorStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowGenerator";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowgenerators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowGenerator";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DialogflowGeneratorSpec defines the desired state of DialogflowGenerator</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DialogflowGeneratorSpec Spec { get; set; }

    /// <summary>DialogflowGeneratorStatus defines the config connector machine state of DialogflowGenerator</summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowGeneratorStatus? Status { get; set; }
}