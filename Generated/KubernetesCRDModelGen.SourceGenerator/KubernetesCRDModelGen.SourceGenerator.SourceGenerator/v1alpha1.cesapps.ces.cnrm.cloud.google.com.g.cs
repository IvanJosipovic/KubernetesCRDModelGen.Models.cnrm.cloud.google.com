#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ces.cnrm.cloud.google.com;
/// <summary>CESApp is the Schema for the CESApp API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CESAppList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CESApp>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CESAppList";
    public const string KubeGroup = "ces.cnrm.cloud.google.com";
    public const string KubePluralName = "cesapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ces.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CESAppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CESApp objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CESApp> Items { get; set; }
}

/// <summary>Optional. Configuration for the ambient sound to be played with the synthesized agent response, to enhance the naturalness of the conversation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecAudioProcessingConfigAmbientSoundConfig
{
    /// <summary>
    /// Optional. Ambient noise as a mono-channel, 16kHz WAV file stored in
    ///  [Cloud Storage](https://cloud.google.com/storage).
    /// 
    ///  Note: Please make sure the CES service agent
    ///  `service-&lt;PROJECT-NUMBER&gt;@gcp-sa-ces.iam.gserviceaccount.com` has
    ///  `storage.objects.get` permission to the Cloud Storage object.
    /// </summary>
    [JsonPropertyName("gcsURI")]
    public string? GcsURI { get; set; }

    /// <summary>Optional. Deprecated: `prebuilt_ambient_noise` is deprecated in favor of `prebuilt_ambient_sound`.</summary>
    [JsonPropertyName("prebuiltAmbientNoise")]
    public string? PrebuiltAmbientNoise { get; set; }

    /// <summary>Optional. Name of the prebuilt ambient sound. Valid values are: - &quot;coffee_shop&quot; - &quot;keyboard&quot; - &quot;keypad&quot; - &quot;hum&quot; - &quot;office_1&quot; - &quot;office_2&quot; - &quot;office_3&quot; - &quot;room_1&quot; - &quot;room_2&quot; - &quot;room_3&quot; - &quot;room_4&quot; - &quot;room_5&quot; - &quot;air_conditioner&quot;</summary>
    [JsonPropertyName("prebuiltAmbientSound")]
    public string? PrebuiltAmbientSound { get; set; }

    /// <summary>Optional. Volume gain (in dB) of the normal native volume supported by ambient noise, in the range [-96.0, 16.0]. If unset, or set to a value of 0.0 (dB), will play at normal native signal amplitude. A value of -6.0 (dB) will play at approximately half the amplitude of the normal native signal amplitude. A value of +6.0 (dB) will play at approximately twice the amplitude of the normal native signal amplitude. We strongly recommend not to exceed +10 (dB) as there&apos;s usually no effective increase in loudness for any value greater than that.</summary>
    [JsonPropertyName("volumeGainDb")]
    public double? VolumeGainDb { get; set; }
}

/// <summary>Optional. Configures the agent behavior for the user barge-in activities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecAudioProcessingConfigBargeInConfig
{
    /// <summary>Optional. If enabled, the agent will adapt its next response based on the assumption that the user hasn&apos;t heard the full preceding agent message. This should not be used in scenarios where agent responses are displayed visually.</summary>
    [JsonPropertyName("bargeInAwareness")]
    public bool? BargeInAwareness { get; set; }

    /// <summary>
    /// Optional. Disables user barge-in while the agent is speaking. If true, user
    ///  input during agent response playback will be ignored.
    /// 
    ///  Deprecated: `disable_barge_in` is deprecated in favor of
    ///  [`disable_barge_in_control`][google.cloud.ces.v1beta.ChannelProfile.disable_barge_in_control]
    ///  in ChannelProfile.
    /// </summary>
    [JsonPropertyName("disableBargeIn")]
    public bool? DisableBargeIn { get; set; }
}

/// <summary>Optional. Audio processing configuration of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecAudioProcessingConfig
{
    /// <summary>Optional. Configuration for the ambient sound to be played with the synthesized agent response, to enhance the naturalness of the conversation.</summary>
    [JsonPropertyName("ambientSoundConfig")]
    public V1alpha1CESAppSpecAudioProcessingConfigAmbientSoundConfig? AmbientSoundConfig { get; set; }

    /// <summary>Optional. Configures the agent behavior for the user barge-in activities.</summary>
    [JsonPropertyName("bargeInConfig")]
    public V1alpha1CESAppSpecAudioProcessingConfigBargeInConfig? BargeInConfig { get; set; }

    /// <summary>Optional. The duration of user inactivity (no speech or interaction) before the agent prompts the user for reengagement. If not set, the agent will not prompt the user for reengagement.</summary>
    [JsonPropertyName("inactivityTimeout")]
    public string? InactivityTimeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecClientCertificateSettingsPassphraseRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecClientCertificateSettingsPrivateKeyRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The default client certificate settings for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecClientCertificateSettings
{
    [JsonPropertyName("passphraseRef")]
    public V1alpha1CESAppSpecClientCertificateSettingsPassphraseRef? PassphraseRef { get; set; }

    [JsonPropertyName("privateKeyRef")]
    public V1alpha1CESAppSpecClientCertificateSettingsPrivateKeyRef? PrivateKeyRef { get; set; }

    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }
}

/// <summary>Optional. The persona property of the channel profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecDefaultChannelProfilePersonaProperty
{
    /// <summary>Optional. The persona of the channel.</summary>
    [JsonPropertyName("persona")]
    public string? Persona { get; set; }
}

/// <summary>Optional. The security settings of the web widget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecDefaultChannelProfileWebWidgetConfigSecuritySettings
{
    /// <summary>Optional. The origins that are allowed to host the web widget. An origin is defined by RFC 6454. If empty, all origins are allowed. A maximum of 100 origins is allowed. Example: &quot;https://example.com&quot;</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Optional. Indicates whether origin check for the web widget is enabled. If `true`, the web widget will check the origin of the website that loads the web widget and only allow it to be loaded in the same origin or any of the allowed origins.</summary>
    [JsonPropertyName("enableOriginCheck")]
    public bool? EnableOriginCheck { get; set; }

    /// <summary>Optional. Indicates whether public access to the web widget is enabled. If `true`, the web widget will be publicly accessible. If `false`, the web widget must be integrated with your own authentication and authorization system to return valid credentials for accessing the CES agent.</summary>
    [JsonPropertyName("enablePublicAccess")]
    public bool? EnablePublicAccess { get; set; }

    /// <summary>Optional. Indicates whether reCAPTCHA verification for the web widget is enabled.</summary>
    [JsonPropertyName("enableRecaptcha")]
    public bool? EnableRecaptcha { get; set; }
}

/// <summary>Optional. The configuration for the web widget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecDefaultChannelProfileWebWidgetConfig
{
    /// <summary>Optional. The modality of the web widget.</summary>
    [JsonPropertyName("modality")]
    public string? Modality { get; set; }

    /// <summary>Optional. The security settings of the web widget.</summary>
    [JsonPropertyName("securitySettings")]
    public V1alpha1CESAppSpecDefaultChannelProfileWebWidgetConfigSecuritySettings? SecuritySettings { get; set; }

    /// <summary>Optional. The theme of the web widget.</summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>Optional. The title of the web widget.</summary>
    [JsonPropertyName("webWidgetTitle")]
    public string? WebWidgetTitle { get; set; }
}

/// <summary>Optional. The default channel profile used by the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecDefaultChannelProfile
{
    /// <summary>Optional. The type of the channel profile.</summary>
    [JsonPropertyName("channelType")]
    public string? ChannelType { get; set; }

    /// <summary>Optional. Whether to disable user barge-in control in the conversation. - **true**: User interruptions are disabled while the agent is speaking. - **false**: The agent retains automatic control over when the user can interrupt.</summary>
    [JsonPropertyName("disableBargeInControl")]
    public bool? DisableBargeInControl { get; set; }

    /// <summary>Optional. Whether to disable DTMF (dual-tone multi-frequency).</summary>
    [JsonPropertyName("disableDtmf")]
    public bool? DisableDtmf { get; set; }

    /// <summary>Optional. The noise suppression level of the channel profile. Available values are &quot;low&quot;, &quot;moderate&quot;, &quot;high&quot;, &quot;very_high&quot;.</summary>
    [JsonPropertyName("noiseSuppressionLevel")]
    public string? NoiseSuppressionLevel { get; set; }

    /// <summary>Optional. The persona property of the channel profile.</summary>
    [JsonPropertyName("personaProperty")]
    public V1alpha1CESAppSpecDefaultChannelProfilePersonaProperty? PersonaProperty { get; set; }

    /// <summary>Optional. The unique identifier of the channel profile.</summary>
    [JsonPropertyName("profileID")]
    public string? ProfileID { get; set; }

    /// <summary>Optional. The configuration for the web widget.</summary>
    [JsonPropertyName("webWidgetConfig")]
    public V1alpha1CESAppSpecDefaultChannelProfileWebWidgetConfig? WebWidgetConfig { get; set; }
}

/// <summary>Optional. Configuration for ending the session in case of system errors (e.g. LLM errors).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecErrorHandlingSettingsEndSessionConfig
{
    /// <summary>Optional. Whether to escalate the session in [EndSession][google.cloud.ces.v1beta.EndSession]. If session is escalated, [metadata in EndSession][google.cloud.ces.v1beta.EndSession.metadata] will contain `session_escalated = true`. See https://docs.cloud.google.com/customer-engagement-ai/conversational-agents/ps/deploy/google-telephony-platform#transfer_a_call_to_a_human_agent for details.</summary>
    [JsonPropertyName("escalateSession")]
    public bool? EscalateSession { get; set; }
}

/// <summary>Optional. Configuration for handling fallback responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecErrorHandlingSettingsFallbackResponseConfig
{
    /// <summary>Optional. The fallback messages in case of system errors (e.g. LLM errors), mapped by [supported language code](https://docs.cloud.google.com/customer-engagement-ai/conversational-agents/ps/reference/language).</summary>
    [JsonPropertyName("customFallbackMessages")]
    public IDictionary<string, string>? CustomFallbackMessages { get; set; }

    /// <summary>Optional. The maximum number of fallback attempts to make before the agent emitting [EndSession][google.cloud.ces.v1beta.EndSession] Signal.</summary>
    [JsonPropertyName("maxFallbackAttempts")]
    public int? MaxFallbackAttempts { get; set; }
}

/// <summary>Optional. Error handling settings of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecErrorHandlingSettings
{
    /// <summary>Optional. Configuration for ending the session in case of system errors (e.g. LLM errors).</summary>
    [JsonPropertyName("endSessionConfig")]
    public V1alpha1CESAppSpecErrorHandlingSettingsEndSessionConfig? EndSessionConfig { get; set; }

    /// <summary>Optional. The strategy to use for error handling.</summary>
    [JsonPropertyName("errorHandlingStrategy")]
    public string? ErrorHandlingStrategy { get; set; }

    /// <summary>Optional. Configuration for handling fallback responses.</summary>
    [JsonPropertyName("fallbackResponseConfig")]
    public V1alpha1CESAppSpecErrorHandlingSettingsFallbackResponseConfig? FallbackResponseConfig { get; set; }
}

/// <summary>Optional. The expectation level metrics thresholds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsExpectationLevelMetricsThresholds
{
    /// <summary>Optional. The success threshold for individual tool invocation parameter correctness. Must be a float between 0 and 1. Default is 1.0.</summary>
    [JsonPropertyName("toolInvocationParameterCorrectnessThreshold")]
    public double? ToolInvocationParameterCorrectnessThreshold { get; set; }
}

/// <summary>Optional. The tool matching settings. An extra tool call is a tool call that is present in the execution but does not match any tool call in the golden expectation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsToolMatchingSettings
{
    /// <summary>Optional. Behavior for extra tool calls. Defaults to FAIL.</summary>
    [JsonPropertyName("extraToolCallBehavior")]
    public string? ExtraToolCallBehavior { get; set; }
}

/// <summary>Optional. The turn level metrics thresholds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsTurnLevelMetricsThresholds
{
    /// <summary>Optional. The success threshold for overall tool invocation correctness. Must be a float between 0 and 1. Default is 1.0.</summary>
    [JsonPropertyName("overallToolInvocationCorrectnessThreshold")]
    public double? OverallToolInvocationCorrectnessThreshold { get; set; }

    /// <summary>Optional. The semantic similarity channel to use for evaluation.</summary>
    [JsonPropertyName("semanticSimilarityChannel")]
    public string? SemanticSimilarityChannel { get; set; }

    /// <summary>Optional. The success threshold for semantic similarity. Must be an integer between 0 and 4. Default is &gt;= 3.</summary>
    [JsonPropertyName("semanticSimilaritySuccessThreshold")]
    public int? SemanticSimilaritySuccessThreshold { get; set; }
}

/// <summary>Optional. The golden evaluation metrics thresholds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholds
{
    /// <summary>Optional. The expectation level metrics thresholds.</summary>
    [JsonPropertyName("expectationLevelMetricsThresholds")]
    public V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsExpectationLevelMetricsThresholds? ExpectationLevelMetricsThresholds { get; set; }

    /// <summary>Optional. The tool matching settings. An extra tool call is a tool call that is present in the execution but does not match any tool call in the golden expectation.</summary>
    [JsonPropertyName("toolMatchingSettings")]
    public V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsToolMatchingSettings? ToolMatchingSettings { get; set; }

    /// <summary>Optional. The turn level metrics thresholds.</summary>
    [JsonPropertyName("turnLevelMetricsThresholds")]
    public V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsTurnLevelMetricsThresholds? TurnLevelMetricsThresholds { get; set; }
}

/// <summary>Optional. The evaluation thresholds for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationMetricsThresholds
{
    /// <summary>Optional. The golden evaluation metrics thresholds.</summary>
    [JsonPropertyName("goldenEvaluationMetricsThresholds")]
    public V1alpha1CESAppSpecEvaluationMetricsThresholdsGoldenEvaluationMetricsThresholds? GoldenEvaluationMetricsThresholds { get; set; }

    /// <summary>Optional. The hallucination metric behavior for golden evaluations.</summary>
    [JsonPropertyName("goldenHallucinationMetricBehavior")]
    public string? GoldenHallucinationMetricBehavior { get; set; }

    /// <summary>Optional. Deprecated: Use `golden_hallucination_metric_behavior` instead. The hallucination metric behavior is currently used for golden evaluations.</summary>
    [JsonPropertyName("hallucinationMetricBehavior")]
    public string? HallucinationMetricBehavior { get; set; }

    /// <summary>Optional. The hallucination metric behavior for scenario evaluations.</summary>
    [JsonPropertyName("scenarioHallucinationMetricBehavior")]
    public string? ScenarioHallucinationMetricBehavior { get; set; }
}

/// <summary>CESEvaluationPersonaRef defines the resource reference to CESEvaluationPersona.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationPersonasNameRef
{
    [JsonPropertyName("external")]
    public string? External { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationPersonas
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>CESEvaluationPersonaRef defines the resource reference to CESEvaluationPersona.</summary>
    [JsonPropertyName("nameRef")]
    public V1alpha1CESAppSpecEvaluationPersonasNameRef? NameRef { get; set; }
}

/// <summary>Optional. Global configuration for semantic similarity metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfigSemanticSimilarityMetricsConfig
{
    /// <summary>Optional. Whether to calculate semantic similarity metrics for the evaluation.</summary>
    [JsonPropertyName("enableSemanticSimilarityMetrics")]
    public bool? EnableSemanticSimilarityMetrics { get; set; }
}

/// <summary>Optional. Configuration for step level tool correctness metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfigStepToolCorrectnessMetricsConfig
{
    /// <summary>Optional. Whether to calculate tool correctness metrics for the evaluation.</summary>
    [JsonPropertyName("enableToolCorrectnessMetrics")]
    public bool? EnableToolCorrectnessMetrics { get; set; }
}

/// <summary>Optional. Configuration for turn level tool correctness metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfigToolCorrectnessMetricsConfig
{
    /// <summary>Optional. Whether to calculate tool correctness metrics for the evaluation.</summary>
    [JsonPropertyName("enableToolCorrectnessMetrics")]
    public bool? EnableToolCorrectnessMetrics { get; set; }
}

/// <summary>Optional. Configuration for the golden metrics for the evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfig
{
    /// <summary>Optional. Global configuration for semantic similarity metrics.</summary>
    [JsonPropertyName("semanticSimilarityMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfigSemanticSimilarityMetricsConfig? SemanticSimilarityMetricsConfig { get; set; }

    /// <summary>Optional. Configuration for step level tool correctness metrics.</summary>
    [JsonPropertyName("stepToolCorrectnessMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfigStepToolCorrectnessMetricsConfig? StepToolCorrectnessMetricsConfig { get; set; }

    /// <summary>Optional. Configuration for turn level tool correctness metrics.</summary>
    [JsonPropertyName("toolCorrectnessMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfigToolCorrectnessMetricsConfig? ToolCorrectnessMetricsConfig { get; set; }
}

/// <summary>Optional. Configuration for expectation level metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigScenarioMetricsConfigExpectationsMetMetricsConfig
{
    /// <summary>Optional. Whether to calculate the expectation level metrics for the evaluation.</summary>
    [JsonPropertyName("enableExpectationsMetMetrics")]
    public bool? EnableExpectationsMetMetrics { get; set; }
}

/// <summary>Optional. Configuration for user goal met metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigScenarioMetricsConfigUserGoalMetMetricsConfig
{
    /// <summary>Optional. Whether to calculate the user goal met metrics for the evaluation.</summary>
    [JsonPropertyName("enableUserGoalMetMetrics")]
    public bool? EnableUserGoalMetMetrics { get; set; }
}

/// <summary>Optional. Configuration for the scenario metrics for the evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfigScenarioMetricsConfig
{
    /// <summary>Optional. Configuration for expectation level metrics.</summary>
    [JsonPropertyName("expectationsMetMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigScenarioMetricsConfigExpectationsMetMetricsConfig? ExpectationsMetMetricsConfig { get; set; }

    /// <summary>Optional. Configuration for user goal met metrics.</summary>
    [JsonPropertyName("userGoalMetMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigScenarioMetricsConfigUserGoalMetMetricsConfig? UserGoalMetMetricsConfig { get; set; }
}

/// <summary>Optional. Configures the default metrics for evaluations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettingsMetricsConfig
{
    /// <summary>Optional. Configuration for the golden metrics for the evaluation.</summary>
    [JsonPropertyName("goldenMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigGoldenMetricsConfig? GoldenMetricsConfig { get; set; }

    /// <summary>Optional. Configuration for the scenario metrics for the evaluation.</summary>
    [JsonPropertyName("scenarioMetricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfigScenarioMetricsConfig? ScenarioMetricsConfig { get; set; }
}

/// <summary>Optional. The evaluation settings for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecEvaluationSettings
{
    /// <summary>Optional. Configures the default tool call behaviour for golden evaluations.</summary>
    [JsonPropertyName("goldenEvaluationToolCallBehaviour")]
    public string? GoldenEvaluationToolCallBehaviour { get; set; }

    /// <summary>Optional. The default method used to run golden evaluations. This will be used if no golden_run_method is specified in the RunEvaluationRequest.</summary>
    [JsonPropertyName("goldenRunMethod")]
    public string? GoldenRunMethod { get; set; }

    /// <summary>Optional. Configures the default metrics for evaluations.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1alpha1CESAppSpecEvaluationSettingsMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Optional. Who starts the conversation in a scenario evaluation.</summary>
    [JsonPropertyName("scenarioConversationInitiator")]
    public string? ScenarioConversationInitiator { get; set; }

    /// <summary>Optional. Configures the default tool call behaviour for scenario evaluations.</summary>
    [JsonPropertyName("scenarioEvaluationToolCallBehaviour")]
    public string? ScenarioEvaluationToolCallBehaviour { get; set; }

    /// <summary>Optional. The execution mode for scenario evaluations. If not provided, will default to QUALITY_OPTIMIZED.</summary>
    [JsonPropertyName("scenarioExecutionMode")]
    public string? ScenarioExecutionMode { get; set; }
}

/// <summary>CESGuardrailRef defines the resource reference to CESGuardrail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecGuardrailRefs
{
    /// <summary>A reference to an externally managed CES Guardrail. Format: `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `CESGuardrail` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `CESGuardrail` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Language settings of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLanguageSettings
{
    /// <summary>Optional. The default language code of the app.</summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>Optional. Enables multilingual support. If true, agents in the app will use pre-built instructions to improve handling of multilingual input.</summary>
    [JsonPropertyName("enableMultilingualSupport")]
    public bool? EnableMultilingualSupport { get; set; }

    /// <summary>
    /// Optional. Deprecated: This feature is no longer supported. Use
    ///  `enable_multilingual_support` instead to improve handling of multilingual
    ///  input.
    ///  The action to perform when an agent receives input in an unsupported
    ///  language.
    /// 
    ///  This can be a predefined action or a custom tool call.
    ///  Valid values are:
    ///  - A tool&apos;s full resource name, which triggers a specific tool execution.
    ///  - A predefined system action, such as &quot;escalate&quot; or &quot;exit&quot;, which triggers
    ///  an [EndSession][google.cloud.ces.v1beta.EndSession] signal with
    ///  corresponding [metadata][google.cloud.ces.v1beta.EndSession.metadata] to
    ///  terminate the conversation.
    /// </summary>
    [JsonPropertyName("fallbackAction")]
    public string? FallbackAction { get; set; }

    /// <summary>Optional. List of languages codes supported by the app, in addition to the `default_language_code`.</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }
}

/// <summary>Optional. Configuration for how audio interactions should be recorded. The audio is subject to redaction as configured in [RedactionConfig][google.cloud.ces.v1beta.LoggingSettings.redaction_config].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsAudioRecordingConfig
{
    /// <summary>
    /// Optional. The [Cloud Storage](https://cloud.google.com/storage) bucket to
    ///  store the session audio recordings. The URI must start with &quot;gs://&quot;.
    /// 
    ///  Please choose a bucket location that meets your data residency
    ///  requirements.
    /// 
    ///  Note: If the Cloud Storage bucket is in a different project from the app,
    ///  you should grant `storage.objects.create` permission to the CES service
    ///  agent `service-&lt;PROJECT-NUMBER&gt;@gcp-sa-ces.iam.gserviceaccount.com`.
    /// </summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>
    /// Optional. The Cloud Storage path prefix for audio recordings.
    /// 
    ///  This prefix can include the following placeholders, which will be
    ///  dynamically substituted at serving time:
    ///    - $project:   project ID
    ///    - $location:  app location
    ///    - $app:       app ID
    ///    - $date:      session date in YYYY-MM-DD format
    ///    - $session:   session ID
    /// 
    ///  If the path prefix is not specified, the default prefix
    ///  `$project/$location/$app/$date/$session/` will be used.
    /// </summary>
    [JsonPropertyName("gcsPathPrefix")]
    public string? GcsPathPrefix { get; set; }
}

/// <summary>Optional. Configures the BigQuery export behaviors for the app. The conversation data is subject to redaction as configured in [RedactionConfig][google.cloud.ces.v1beta.LoggingSettings.redaction_config].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsBigqueryExportSettings
{
    /// <summary>Optional. The BigQuery **dataset ID** to export the data to.</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Optional. Indicates whether the BigQuery export is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Optional. The **project ID** of the BigQuery dataset to export the data to.
    /// 
    ///  Note: If the BigQuery dataset is in a different project from the app,
    ///  you should grant `roles/bigquery.admin` role to the CES service agent
    ///  `service-&lt;PROJECT-NUMBER&gt;@gcp-sa-ces.iam.gserviceaccount.com`.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>Optional. Settings to describe the Cloud Logging behaviors for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsCloudLoggingSettings
{
    /// <summary>Optional. Whether to enable Cloud Logging for the sessions.</summary>
    [JsonPropertyName("enableCloudLogging")]
    public bool? EnableCloudLogging { get; set; }
}

/// <summary>Optional. Settings to describe the conversation logging behaviors for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsConversationLoggingSettings
{
    /// <summary>Optional. Whether to disable conversation logging for the sessions.</summary>
    [JsonPropertyName("disableConversationLogging")]
    public bool? DisableConversationLogging { get; set; }

    /// <summary>Optional. Controls the retention window for the conversation. If not set, the conversation will be retained for 365 days.</summary>
    [JsonPropertyName("retentionWindow")]
    public string? RetentionWindow { get; set; }
}

/// <summary>Optional. Configuration for how audio interactions should be recorded for the evaluation. By default, audio recording is not enabled for evaluation sessions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsEvaluationAudioRecordingConfig
{
    /// <summary>
    /// Optional. The [Cloud Storage](https://cloud.google.com/storage) bucket to
    ///  store the session audio recordings. The URI must start with &quot;gs://&quot;.
    /// 
    ///  Please choose a bucket location that meets your data residency
    ///  requirements.
    /// 
    ///  Note: If the Cloud Storage bucket is in a different project from the app,
    ///  you should grant `storage.objects.create` permission to the CES service
    ///  agent `service-&lt;PROJECT-NUMBER&gt;@gcp-sa-ces.iam.gserviceaccount.com`.
    /// </summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>
    /// Optional. The Cloud Storage path prefix for audio recordings.
    /// 
    ///  This prefix can include the following placeholders, which will be
    ///  dynamically substituted at serving time:
    ///    - $project:   project ID
    ///    - $location:  app location
    ///    - $app:       app ID
    ///    - $date:      session date in YYYY-MM-DD format
    ///    - $session:   session ID
    /// 
    ///  If the path prefix is not specified, the default prefix
    ///  `$project/$location/$app/$date/$session/` will be used.
    /// </summary>
    [JsonPropertyName("gcsPathPrefix")]
    public string? GcsPathPrefix { get; set; }
}

/// <summary>Optional. Settings to describe the conversation data collection behaviors for the LLM analysis pipeline for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsMetricAnalysisSettings
{
    /// <summary>Optional. Whether to collect conversation data for llm analysis metrics. If true, conversation data will not be collected for llm analysis metrics; otherwise, conversation data will be collected.</summary>
    [JsonPropertyName("llmMetricsOptedOut")]
    public bool? LlmMetricsOptedOut { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsRedactionConfigDeidentifyTemplateRef
{
    /// <summary>A reference to an externally managed DLP Deidentify Template. Should be in the format `projects/[project_id]/locations/[location]/deidentifyTemplates/[deidentify_template]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `DLPDeidentifyTemplate` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `DLPDeidentifyTemplate` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsRedactionConfigInspectTemplateRef
{
    /// <summary>A reference to an externally managed DLP Inspect Template. Should be in the format `projects/[project_id]/locations/[location]/inspectTemplates/[inspect_template]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `DLPInspectTemplate` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `DLPInspectTemplate` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for how sensitive data should be redacted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsRedactionConfig
{
    [JsonPropertyName("deidentifyTemplateRef")]
    public V1alpha1CESAppSpecLoggingSettingsRedactionConfigDeidentifyTemplateRef? DeidentifyTemplateRef { get; set; }

    [JsonPropertyName("enableRedaction")]
    public bool? EnableRedaction { get; set; }

    [JsonPropertyName("inspectTemplateRef")]
    public V1alpha1CESAppSpecLoggingSettingsRedactionConfigInspectTemplateRef? InspectTemplateRef { get; set; }
}

/// <summary>Optional. Configures an additional recording of unredacted audio. This can be used to maintain a raw audio copy when audio redaction is [enabled][google.cloud.ces.v1beta.RedactionConfig.enable_redaction], typically for auditing or monitoring purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettingsUnredactedAudioRecordingConfig
{
    /// <summary>
    /// Optional. The [Cloud Storage](https://cloud.google.com/storage) bucket to
    ///  store the session audio recordings. The URI must start with &quot;gs://&quot;.
    /// 
    ///  Please choose a bucket location that meets your data residency
    ///  requirements.
    /// 
    ///  Note: If the Cloud Storage bucket is in a different project from the app,
    ///  you should grant `storage.objects.create` permission to the CES service
    ///  agent `service-&lt;PROJECT-NUMBER&gt;@gcp-sa-ces.iam.gserviceaccount.com`.
    /// </summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>
    /// Optional. The Cloud Storage path prefix for audio recordings.
    /// 
    ///  This prefix can include the following placeholders, which will be
    ///  dynamically substituted at serving time:
    ///    - $project:   project ID
    ///    - $location:  app location
    ///    - $app:       app ID
    ///    - $date:      session date in YYYY-MM-DD format
    ///    - $session:   session ID
    /// 
    ///  If the path prefix is not specified, the default prefix
    ///  `$project/$location/$app/$date/$session/` will be used.
    /// </summary>
    [JsonPropertyName("gcsPathPrefix")]
    public string? GcsPathPrefix { get; set; }
}

/// <summary>Optional. Logging settings of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecLoggingSettings
{
    /// <summary>Optional. Configuration for how audio interactions should be recorded. The audio is subject to redaction as configured in [RedactionConfig][google.cloud.ces.v1beta.LoggingSettings.redaction_config].</summary>
    [JsonPropertyName("audioRecordingConfig")]
    public V1alpha1CESAppSpecLoggingSettingsAudioRecordingConfig? AudioRecordingConfig { get; set; }

    /// <summary>Optional. Configures the BigQuery export behaviors for the app. The conversation data is subject to redaction as configured in [RedactionConfig][google.cloud.ces.v1beta.LoggingSettings.redaction_config].</summary>
    [JsonPropertyName("bigqueryExportSettings")]
    public V1alpha1CESAppSpecLoggingSettingsBigqueryExportSettings? BigqueryExportSettings { get; set; }

    /// <summary>Optional. Settings to describe the Cloud Logging behaviors for the app.</summary>
    [JsonPropertyName("cloudLoggingSettings")]
    public V1alpha1CESAppSpecLoggingSettingsCloudLoggingSettings? CloudLoggingSettings { get; set; }

    /// <summary>Optional. Settings to describe the conversation logging behaviors for the app.</summary>
    [JsonPropertyName("conversationLoggingSettings")]
    public V1alpha1CESAppSpecLoggingSettingsConversationLoggingSettings? ConversationLoggingSettings { get; set; }

    /// <summary>Optional. Configuration for how audio interactions should be recorded for the evaluation. By default, audio recording is not enabled for evaluation sessions.</summary>
    [JsonPropertyName("evaluationAudioRecordingConfig")]
    public V1alpha1CESAppSpecLoggingSettingsEvaluationAudioRecordingConfig? EvaluationAudioRecordingConfig { get; set; }

    /// <summary>Optional. Settings to describe the conversation data collection behaviors for the LLM analysis pipeline for the app.</summary>
    [JsonPropertyName("metricAnalysisSettings")]
    public V1alpha1CESAppSpecLoggingSettingsMetricAnalysisSettings? MetricAnalysisSettings { get; set; }

    /// <summary>Optional. Configuration for how sensitive data should be redacted.</summary>
    [JsonPropertyName("redactionConfig")]
    public V1alpha1CESAppSpecLoggingSettingsRedactionConfig? RedactionConfig { get; set; }

    /// <summary>Optional. Configures an additional recording of unredacted audio. This can be used to maintain a raw audio copy when audio redaction is [enabled][google.cloud.ces.v1beta.RedactionConfig.enable_redaction], typically for auditing or monitoring purposes.</summary>
    [JsonPropertyName("unredactedAudioRecordingConfig")]
    public V1alpha1CESAppSpecLoggingSettingsUnredactedAudioRecordingConfig? UnredactedAudioRecordingConfig { get; set; }
}

/// <summary>Optional. The default LLM model settings for the app. Individual resources (e.g. agents, guardrails) can override these configurations as needed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecModelSettings
{
    /// <summary>Optional. The LLM model that the agent should use. If not set, the agent will inherit the model from its parent agent.</summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Optional. If set, this temperature will be used for the LLM model. Temperature controls the randomness of the model&apos;s responses. Lower temperatures produce responses that are more predictable. Higher temperatures produce responses that are more creative.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecProjectRef
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

/// <summary>Optional. The root agent is the entry point of the app. Format: `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecRootAgentRef
{
    /// <summary>A reference to an externally managed CES Agent. Format: `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `CESAgent` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `CESAgent` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. TimeZone settings of the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecTimeZoneSettings
{
    /// <summary>Optional. The time zone of the app from the [time zone database](https://www.iana.org/time-zones), e.g., America/Los_Angeles, Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpecVariableDeclarations
{
    /// <summary>Required. The description of the variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The name of the variable. The name must start with a letter or underscore and contain only letters, numbers, or underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The schema of the variable.</summary>
    [JsonPropertyName("schema")]
    public JsonNode? Schema { get; set; }
}

/// <summary>CESAppSpec defines the desired state of CESApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppSpec
{
    /// <summary>Optional. Audio processing configuration of the app.</summary>
    [JsonPropertyName("audioProcessingConfig")]
    public V1alpha1CESAppSpecAudioProcessingConfig? AudioProcessingConfig { get; set; }

    /// <summary>Optional. The default client certificate settings for the app.</summary>
    [JsonPropertyName("clientCertificateSettings")]
    public V1alpha1CESAppSpecClientCertificateSettings? ClientCertificateSettings { get; set; }

    /// <summary>Optional. The data store settings for the app.</summary>
    [JsonPropertyName("dataStoreSettings")]
    public JsonNode? DataStoreSettings { get; set; }

    /// <summary>Optional. The default channel profile used by the app.</summary>
    [JsonPropertyName("defaultChannelProfile")]
    public V1alpha1CESAppSpecDefaultChannelProfile? DefaultChannelProfile { get; set; }

    /// <summary>Optional. Human-readable description of the app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Display name of the app.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Error handling settings of the app.</summary>
    [JsonPropertyName("errorHandlingSettings")]
    public V1alpha1CESAppSpecErrorHandlingSettings? ErrorHandlingSettings { get; set; }

    /// <summary>Optional. The evaluation thresholds for the app.</summary>
    [JsonPropertyName("evaluationMetricsThresholds")]
    public V1alpha1CESAppSpecEvaluationMetricsThresholds? EvaluationMetricsThresholds { get; set; }

    /// <summary>Optional. The evaluation personas for the app. This field is used to define the personas that can be used for evaluation. Maximum of 30 personas can be defined.</summary>
    [JsonPropertyName("evaluationPersonas")]
    public IList<V1alpha1CESAppSpecEvaluationPersonas>? EvaluationPersonas { get; set; }

    /// <summary>Optional. The evaluation settings for the app.</summary>
    [JsonPropertyName("evaluationSettings")]
    public V1alpha1CESAppSpecEvaluationSettings? EvaluationSettings { get; set; }

    /// <summary>Optional. Instructions for all the agents in the app. You can use this instruction to set up a stable identity or personality across all the agents.</summary>
    [JsonPropertyName("globalInstruction")]
    public string? GlobalInstruction { get; set; }

    /// <summary>Optional. List of guardrails for the app. Format: `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`</summary>
    [JsonPropertyName("guardrailRefs")]
    public IList<V1alpha1CESAppSpecGuardrailRefs>? GuardrailRefs { get; set; }

    /// <summary>Optional. Language settings of the app.</summary>
    [JsonPropertyName("languageSettings")]
    public V1alpha1CESAppSpecLanguageSettings? LanguageSettings { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Indicates whether the app is locked for changes. If the app is locked, modifications to the app resources will be rejected.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary>Optional. Logging settings of the app.</summary>
    [JsonPropertyName("loggingSettings")]
    public V1alpha1CESAppSpecLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Optional. Metadata about the app. This field can be used to store additional information relevant to the app&apos;s details or intended usages.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Optional. The default LLM model settings for the app. Individual resources (e.g. agents, guardrails) can override these configurations as needed.</summary>
    [JsonPropertyName("modelSettings")]
    public V1alpha1CESAppSpecModelSettings? ModelSettings { get; set; }

    /// <summary>Optional. Whether the app is pinned in the app list.</summary>
    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CESAppSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CESApp name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The root agent is the entry point of the app. Format: `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`</summary>
    [JsonPropertyName("rootAgentRef")]
    public V1alpha1CESAppSpecRootAgentRef? RootAgentRef { get; set; }

    /// <summary>Optional. TimeZone settings of the app.</summary>
    [JsonPropertyName("timeZoneSettings")]
    public V1alpha1CESAppSpecTimeZoneSettings? TimeZoneSettings { get; set; }

    /// <summary>Optional. The tool execution mode for the app. If not provided, will default to PARALLEL.</summary>
    [JsonPropertyName("toolExecutionMode")]
    public string? ToolExecutionMode { get; set; }

    /// <summary>Optional. The declarations of the variables.</summary>
    [JsonPropertyName("variableDeclarations")]
    public IList<V1alpha1CESAppSpecVariableDeclarations>? VariableDeclarations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppStatusConditions
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
public partial class V1alpha1CESAppStatusObservedStateDataStoreSettingsEngines
{
    /// <summary>Output only. The resource name of the engine. Format: `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The type of the engine.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Optional. The data store settings for the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppStatusObservedStateDataStoreSettings
{
    /// <summary>Output only. The engines for the app.</summary>
    [JsonPropertyName("engines")]
    public IList<V1alpha1CESAppStatusObservedStateDataStoreSettingsEngines>? Engines { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppStatusObservedStatePredefinedVariableDeclarations
{
    /// <summary>Required. The description of the variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The name of the variable. The name must start with a letter or underscore and contain only letters, numbers, or underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The schema of the variable.</summary>
    [JsonPropertyName("schema")]
    public JsonNode? Schema { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppStatusObservedState
{
    /// <summary>Output only. Timestamp when the app was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. The data store settings for the app.</summary>
    [JsonPropertyName("dataStoreSettings")]
    public V1alpha1CESAppStatusObservedStateDataStoreSettings? DataStoreSettings { get; set; }

    /// <summary>Output only. Number of deployments in the app.</summary>
    [JsonPropertyName("deploymentCount")]
    public int? DeploymentCount { get; set; }

    /// <summary>Output only. Etag used to ensure the object hasn&apos;t changed during a read-modify-write operation. If the etag is empty, the update will overwrite any concurrent changes.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The declarations of predefined variables for the app.</summary>
    [JsonPropertyName("predefinedVariableDeclarations")]
    public IList<V1alpha1CESAppStatusObservedStatePredefinedVariableDeclarations>? PredefinedVariableDeclarations { get; set; }

    /// <summary>Output only. Timestamp when the app was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CESAppStatus defines the config connector machine state of CESApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CESAppStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CESAppStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CESApp resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CESAppStatusObservedState? ObservedState { get; set; }
}

/// <summary>CESApp is the Schema for the CESApp API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CESApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CESAppSpec>, IStatus<V1alpha1CESAppStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CESApp";
    public const string KubeGroup = "ces.cnrm.cloud.google.com";
    public const string KubePluralName = "cesapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ces.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CESApp";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CESAppSpec defines the desired state of CESApp</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CESAppSpec Spec { get; set; }

    /// <summary>CESAppStatus defines the config connector machine state of CESApp</summary>
    [JsonPropertyName("status")]
    public V1alpha1CESAppStatus? Status { get; set; }
}