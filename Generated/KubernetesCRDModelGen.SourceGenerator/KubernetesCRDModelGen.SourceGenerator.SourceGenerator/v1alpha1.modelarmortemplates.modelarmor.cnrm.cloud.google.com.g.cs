#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.modelarmor.cnrm.cloud.google.com;
/// <summary>ModelArmorTemplate is the Schema for the ModelArmorTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelArmorTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ModelArmorTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelArmorTemplateList";
    public const string KubeGroup = "modelarmor.cnrm.cloud.google.com";
    public const string KubePluralName = "modelarmortemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "modelarmor.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelArmorTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ModelArmorTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ModelArmorTemplate> Items { get; set; }
}

/// <summary>Optional. Malicious URI filter settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigMaliciousURIFilterSettings
{
    /// <summary>Optional. Tells whether the Malicious URI filter is enabled or disabled.</summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>Optional. Prompt injection and Jailbreak filter settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigPiAndJailbreakFilterSettings
{
    /// <summary>Optional. Confidence level for this filter. Confidence level is used to determine the threshold for the filter. If detection confidence is equal to or greater than the specified level, a positive match is reported. Confidence level will only be used if the filter is enabled.</summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>Optional. Tells whether Prompt injection and Jailbreak filter is enabled or disabled.</summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigRaiSettingsRaiFilters
{
    /// <summary>Optional. Confidence level for this RAI filter. During data sanitization, if data is classified under this filter with a confidence level equal to or greater than the specified level, a positive match is reported. If the confidence level is unspecified (i.e., 0), the system will use a reasonable default level based on the `filter_type`.</summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>Required. Type of responsible AI filter.</summary>
    [JsonPropertyName("filterType")]
    public required string FilterType { get; set; }
}

/// <summary>Optional. Responsible AI settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigRaiSettings
{
    /// <summary>Required. List of Responsible AI filters enabled for template.</summary>
    [JsonPropertyName("raiFilters")]
    public required IList<V1alpha1ModelArmorTemplateSpecFilterConfigRaiSettingsRaiFilters> RaiFilters { get; set; }
}

/// <summary>
/// Optional. Optional Sensitive Data Protection Deidentify template resource
///  name.
/// 
///  If provided then DeidentifyContent action is performed during Sanitization
///  using this template and inspect template. The De-identified data will
///  be returned in SdpDeidentifyResult.
///  Note that all info-types present in the deidentify template must be present
///  in inspect template.
/// 
///  e.g.
///  `projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef
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

/// <summary>
/// Optional. Sensitive Data Protection inspect template resource name
/// 
///  If only inspect template is provided (de-identify template not provided),
///  then Sensitive Data Protection InspectContent action is performed during
///  Sanitization. All Sensitive Data Protection findings identified during
///  inspection will be returned as SdpFinding in SdpInsepctionResult.
/// 
///  e.g.
///  `projects/{project}/locations/{location}/inspectTemplates/{inspect_template}`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef
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

/// <summary>Optional. Advanced Sensitive Data Protection configuration which enables use of Sensitive Data Protection templates. Supports both Sensitive Data Protection inspection and de-identification operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsAdvancedConfig
{
    /// <summary>
    /// Optional. Optional Sensitive Data Protection Deidentify template resource
    ///  name.
    /// 
    ///  If provided then DeidentifyContent action is performed during Sanitization
    ///  using this template and inspect template. The De-identified data will
    ///  be returned in SdpDeidentifyResult.
    ///  Note that all info-types present in the deidentify template must be present
    ///  in inspect template.
    /// 
    ///  e.g.
    ///  `projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}`
    /// </summary>
    [JsonPropertyName("deidentifyTemplateRef")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef? DeidentifyTemplateRef { get; set; }

    /// <summary>
    /// Optional. Sensitive Data Protection inspect template resource name
    /// 
    ///  If only inspect template is provided (de-identify template not provided),
    ///  then Sensitive Data Protection InspectContent action is performed during
    ///  Sanitization. All Sensitive Data Protection findings identified during
    ///  inspection will be returned as SdpFinding in SdpInsepctionResult.
    /// 
    ///  e.g.
    ///  `projects/{project}/locations/{location}/inspectTemplates/{inspect_template}`
    /// </summary>
    [JsonPropertyName("inspectTemplateRef")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef? InspectTemplateRef { get; set; }
}

/// <summary>Optional. Basic Sensitive Data Protection configuration inspects the content for sensitive data using a fixed set of six info-types. Sensitive Data Protection templates cannot be used with basic configuration. Only Sensitive Data Protection inspection operation is supported with basic configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsBasicConfig
{
    /// <summary>Optional. Tells whether the Sensitive Data Protection basic config is enabled or disabled.</summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>Optional. Sensitive Data Protection settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettings
{
    /// <summary>Optional. Advanced Sensitive Data Protection configuration which enables use of Sensitive Data Protection templates. Supports both Sensitive Data Protection inspection and de-identification operations.</summary>
    [JsonPropertyName("advancedConfig")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>Optional. Basic Sensitive Data Protection configuration inspects the content for sensitive data using a fixed set of six info-types. Sensitive Data Protection templates cannot be used with basic configuration. Only Sensitive Data Protection inspection operation is supported with basic configuration.</summary>
    [JsonPropertyName("basicConfig")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>Required. filter configuration for this template</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecFilterConfig
{
    /// <summary>Optional. Malicious URI filter settings.</summary>
    [JsonPropertyName("maliciousURIFilterSettings")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigMaliciousURIFilterSettings? MaliciousURIFilterSettings { get; set; }

    /// <summary>Optional. Prompt injection and Jailbreak filter settings.</summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>Optional. Responsible AI settings.</summary>
    [JsonPropertyName("raiSettings")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>Optional. Sensitive Data Protection settings.</summary>
    [JsonPropertyName("sdpSettings")]
    public V1alpha1ModelArmorTemplateSpecFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecProjectRef
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

/// <summary>Optional. Metadata for multi language detection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecTemplateMetadataMultiLanguageDetection
{
    /// <summary>Required. If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public required bool EnableMultiLanguageDetection { get; set; }
}

/// <summary>Optional. metadata for this template</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpecTemplateMetadata
{
    /// <summary>Optional. Indicates the custom error code set by the user to be returned to the end user if the LLM response trips Model Armor filters.</summary>
    [JsonPropertyName("customLlmResponseSafetyErrorCode")]
    public int? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>Optional. Indicates the custom error message set by the user to be returned to the end user if the LLM response trips Model Armor filters.</summary>
    [JsonPropertyName("customLlmResponseSafetyErrorMessage")]
    public string? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>Optional. Indicates the custom error code set by the user to be returned to the end user by the service extension if the prompt trips Model Armor filters.</summary>
    [JsonPropertyName("customPromptSafetyErrorCode")]
    public int? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>Optional. Indicates the custom error message set by the user to be returned to the end user if the prompt trips Model Armor filters.</summary>
    [JsonPropertyName("customPromptSafetyErrorMessage")]
    public string? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>Optional. Enforcement type for Model Armor filters.</summary>
    [JsonPropertyName("enforcementType")]
    public string? EnforcementType { get; set; }

    /// <summary>Optional. If true, partial detector failures should be ignored.</summary>
    [JsonPropertyName("ignorePartialInvocationFailures")]
    public bool? IgnorePartialInvocationFailures { get; set; }

    /// <summary>Optional. If true, log sanitize operations.</summary>
    [JsonPropertyName("logSanitizeOperations")]
    public bool? LogSanitizeOperations { get; set; }

    /// <summary>Optional. If true, log template crud operations.</summary>
    [JsonPropertyName("logTemplateOperations")]
    public bool? LogTemplateOperations { get; set; }

    /// <summary>Optional. Metadata for multi language detection.</summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1alpha1ModelArmorTemplateSpecTemplateMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
}

/// <summary>ModelArmorTemplateSpec defines the desired state of ModelArmorTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateSpec
{
    /// <summary>Required. filter configuration for this template</summary>
    [JsonPropertyName("filterConfig")]
    public required V1alpha1ModelArmorTemplateSpecFilterConfig FilterConfig { get; set; }

    /// <summary>Optional. Labels as key value pairs</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ModelArmorTemplateSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ModelArmorTemplate name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. metadata for this template</summary>
    [JsonPropertyName("templateMetadata")]
    public V1alpha1ModelArmorTemplateSpecTemplateMetadata? TemplateMetadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateStatusConditions
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
public partial class V1alpha1ModelArmorTemplateStatusObservedState
{
    /// <summary>Output only. [Output only] Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. [Output only] Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ModelArmorTemplateStatus defines the config connector machine state of ModelArmorTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelArmorTemplateStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ModelArmorTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ModelArmorTemplate resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ModelArmorTemplateStatusObservedState? ObservedState { get; set; }
}

/// <summary>ModelArmorTemplate is the Schema for the ModelArmorTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelArmorTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ModelArmorTemplateSpec>, IStatus<V1alpha1ModelArmorTemplateStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelArmorTemplate";
    public const string KubeGroup = "modelarmor.cnrm.cloud.google.com";
    public const string KubePluralName = "modelarmortemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "modelarmor.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelArmorTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelArmorTemplateSpec defines the desired state of ModelArmorTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ModelArmorTemplateSpec Spec { get; set; }

    /// <summary>ModelArmorTemplateStatus defines the config connector machine state of ModelArmorTemplate</summary>
    [JsonPropertyName("status")]
    public V1alpha1ModelArmorTemplateStatus? Status { get; set; }
}