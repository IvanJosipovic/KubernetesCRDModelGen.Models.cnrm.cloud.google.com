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
/// <summary>CCInsightsPhraseMatcher is the Schema for the CCInsightsPhraseMatcher API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CCInsightsPhraseMatcherList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CCInsightsPhraseMatcher>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CCInsightsPhraseMatcherList";
    public const string KubeGroup = "contactcenterinsights.cnrm.cloud.google.com";
    public const string KubePluralName = "ccinsightsphrasematchers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contactcenterinsights.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CCInsightsPhraseMatcherList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CCInsightsPhraseMatcher objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CCInsightsPhraseMatcher> Items { get; set; }
}

/// <summary>The configuration for the exact match rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsPhraseMatchRulesConfigExactMatchConfig
{
    /// <summary>Whether to consider case sensitivity when performing an exact match.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary>Provides additional information about the rule that specifies how to apply the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsPhraseMatchRulesConfig
{
    /// <summary>The configuration for the exact match rule.</summary>
    [JsonPropertyName("exactMatchConfig")]
    public V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsPhraseMatchRulesConfigExactMatchConfig? ExactMatchConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsPhraseMatchRules
{
    /// <summary>Provides additional information about the rule that specifies how to apply the rule.</summary>
    [JsonPropertyName("config")]
    public V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsPhraseMatchRulesConfig? Config { get; set; }

    /// <summary>Specifies whether the phrase must be missing from the transcript segment or present in the transcript segment.</summary>
    [JsonPropertyName("negated")]
    public bool? Negated { get; set; }

    /// <summary>Required. The phrase to be matched.</summary>
    [JsonPropertyName("query")]
    public required string Query { get; set; }
}

/// <summary>Required. The type of this phrase match rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsTypeEnum>))]
public enum V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsTypeEnum
{
    [EnumMember(Value = "PHRASE_MATCH_RULE_GROUP_TYPE_UNSPECIFIED"), JsonStringEnumMemberName("PHRASE_MATCH_RULE_GROUP_TYPE_UNSPECIFIED")]
    PHRASEMATCHRULEGROUPTYPEUNSPECIFIED,
    [EnumMember(Value = "ALL_OF"), JsonStringEnumMemberName("ALL_OF")]
    ALLOF,
    [EnumMember(Value = "ANY_OF"), JsonStringEnumMemberName("ANY_OF")]
    ANYOF
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroups
{
    /// <summary>A list of phrase match rules that are included in this group.</summary>
    [JsonPropertyName("phraseMatchRules")]
    public IList<V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsPhraseMatchRules>? PhraseMatchRules { get; set; }

    /// <summary>Required. The type of this phrase match rule group.</summary>
    [JsonPropertyName("type")]
    public required V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroupsTypeEnum Type { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherSpecProjectRef
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

/// <summary>The role whose utterances the phrase matcher should be matched against. If the role is ROLE_UNSPECIFIED it will be matched against any utterances in the transcript.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1CCInsightsPhraseMatcherSpecRoleMatchEnum>))]
public enum V1alpha1CCInsightsPhraseMatcherSpecRoleMatchEnum
{
    [EnumMember(Value = "ROLE_UNSPECIFIED"), JsonStringEnumMemberName("ROLE_UNSPECIFIED")]
    ROLEUNSPECIFIED,
    [EnumMember(Value = "HUMAN_AGENT"), JsonStringEnumMemberName("HUMAN_AGENT")]
    HUMANAGENT,
    [EnumMember(Value = "AUTOMATED_AGENT"), JsonStringEnumMemberName("AUTOMATED_AGENT")]
    AUTOMATEDAGENT,
    [EnumMember(Value = "END_USER"), JsonStringEnumMemberName("END_USER")]
    ENDUSER,
    [EnumMember(Value = "ANY_AGENT"), JsonStringEnumMemberName("ANY_AGENT")]
    ANYAGENT
}

/// <summary>Required. The type of this phrase matcher.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1CCInsightsPhraseMatcherSpecTypeEnum>))]
public enum V1alpha1CCInsightsPhraseMatcherSpecTypeEnum
{
    [EnumMember(Value = "PHRASE_MATCHER_TYPE_UNSPECIFIED"), JsonStringEnumMemberName("PHRASE_MATCHER_TYPE_UNSPECIFIED")]
    PHRASEMATCHERTYPEUNSPECIFIED,
    [EnumMember(Value = "ALL_OF"), JsonStringEnumMemberName("ALL_OF")]
    ALLOF,
    [EnumMember(Value = "ANY_OF"), JsonStringEnumMemberName("ANY_OF")]
    ANYOF
}

/// <summary>CCInsightsPhraseMatcherSpec defines the desired state of CCInsightsPhraseMatcher</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherSpec
{
    /// <summary>Applies the phrase matcher only when it is active.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>The human-readable name of the phrase matcher.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>A list of phase match rule groups that are included in this matcher.</summary>
    [JsonPropertyName("phraseMatchRuleGroups")]
    public IList<V1alpha1CCInsightsPhraseMatcherSpecPhraseMatchRuleGroups>? PhraseMatchRuleGroups { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CCInsightsPhraseMatcherSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CCInsightsPhraseMatcher name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The role whose utterances the phrase matcher should be matched against. If the role is ROLE_UNSPECIFIED it will be matched against any utterances in the transcript.</summary>
    [JsonPropertyName("roleMatch")]
    public V1alpha1CCInsightsPhraseMatcherSpecRoleMatchEnum? RoleMatch { get; set; }

    /// <summary>Required. The type of this phrase matcher.</summary>
    [JsonPropertyName("type")]
    public required V1alpha1CCInsightsPhraseMatcherSpecTypeEnum Type { get; set; }

    /// <summary>The customized version tag to use for the phrase matcher. If not specified, it will default to `revision_id`.</summary>
    [JsonPropertyName("versionTag")]
    public string? VersionTag { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherStatusConditions
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
public partial class V1alpha1CCInsightsPhraseMatcherStatusObservedState
{
    /// <summary>Output only. The most recent time at which the activation status was updated.</summary>
    [JsonPropertyName("activationUpdateTime")]
    public string? ActivationUpdateTime { get; set; }

    /// <summary>Output only. The timestamp of when the revision was created. It is also the create time when a new matcher is added.</summary>
    [JsonPropertyName("revisionCreateTime")]
    public string? RevisionCreateTime { get; set; }

    /// <summary>Output only. Immutable. The revision ID of the phrase matcher. A new revision is committed whenever the matcher is changed, except when it is activated or deactivated. A server generated random ID will be used. Example: locations/global/phraseMatchers/my-first-matcher@1234567</summary>
    [JsonPropertyName("revisionID")]
    public string? RevisionID { get; set; }

    /// <summary>Output only. The most recent time at which the phrase matcher was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CCInsightsPhraseMatcherStatus defines the config connector machine state of CCInsightsPhraseMatcher</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CCInsightsPhraseMatcherStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CCInsightsPhraseMatcherStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CCInsightsPhraseMatcher resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CCInsightsPhraseMatcherStatusObservedState? ObservedState { get; set; }
}

/// <summary>CCInsightsPhraseMatcher is the Schema for the CCInsightsPhraseMatcher API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CCInsightsPhraseMatcher : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CCInsightsPhraseMatcherSpec>, IStatus<V1alpha1CCInsightsPhraseMatcherStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CCInsightsPhraseMatcher";
    public const string KubeGroup = "contactcenterinsights.cnrm.cloud.google.com";
    public const string KubePluralName = "ccinsightsphrasematchers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contactcenterinsights.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CCInsightsPhraseMatcher";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CCInsightsPhraseMatcherSpec defines the desired state of CCInsightsPhraseMatcher</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CCInsightsPhraseMatcherSpec Spec { get; set; }

    /// <summary>CCInsightsPhraseMatcherStatus defines the config connector machine state of CCInsightsPhraseMatcher</summary>
    [JsonPropertyName("status")]
    public V1alpha1CCInsightsPhraseMatcherStatus? Status { get; set; }
}