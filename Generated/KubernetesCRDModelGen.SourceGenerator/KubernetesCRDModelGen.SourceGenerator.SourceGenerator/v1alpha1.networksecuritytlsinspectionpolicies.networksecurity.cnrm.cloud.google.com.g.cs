#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecurityTLSInspectionPolicy is the Schema for the NetworkSecurityTLSInspectionPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecurityTLSInspectionPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityTLSInspectionPolicyList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritytlsinspectionpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityTLSInspectionPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecurityTLSInspectionPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecurityTLSInspectionPolicy> Items { get; set; }
}

/// <summary>Required. A CA pool resource used to issue interception certificates. The CA pool string has a relative resource path following the form &quot;projects/{project}/locations/{location}/caPools/{ca_pool}&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicySpecCaPoolRef
{
    /// <summary>A reference to an externally managed PrivateCACAPool resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/caPools/{{caPoolID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PrivateCACAPool resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PrivateCACAPool resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Minimum TLS version that is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NetworkSecurityTLSInspectionPolicySpecMinTLSVersionEnum>))]
public enum V1alpha1NetworkSecurityTLSInspectionPolicySpecMinTLSVersionEnum
{
    [EnumMember(Value = "TLS_VERSION_UNSPECIFIED"), JsonStringEnumMemberName("TLS_VERSION_UNSPECIFIED")]
    TLSVERSIONUNSPECIFIED,
    [EnumMember(Value = "TLS_1_0"), JsonStringEnumMemberName("TLS_1_0")]
    TLS10,
    [EnumMember(Value = "TLS_1_1"), JsonStringEnumMemberName("TLS_1_1")]
    TLS11,
    [EnumMember(Value = "TLS_1_2"), JsonStringEnumMemberName("TLS_1_2")]
    TLS12,
    [EnumMember(Value = "TLS_1_3"), JsonStringEnumMemberName("TLS_1_3")]
    TLS13
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicySpecProjectRef
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

/// <summary>Optional. TLS feature profile that is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NetworkSecurityTLSInspectionPolicySpecTlsFeatureProfileEnum>))]
public enum V1alpha1NetworkSecurityTLSInspectionPolicySpecTlsFeatureProfileEnum
{
    [EnumMember(Value = "PROFILE_UNSPECIFIED"), JsonStringEnumMemberName("PROFILE_UNSPECIFIED")]
    PROFILEUNSPECIFIED,
    [EnumMember(Value = "PROFILE_COMPATIBLE"), JsonStringEnumMemberName("PROFILE_COMPATIBLE")]
    PROFILECOMPATIBLE,
    [EnumMember(Value = "PROFILE_MODERN"), JsonStringEnumMemberName("PROFILE_MODERN")]
    PROFILEMODERN,
    [EnumMember(Value = "PROFILE_RESTRICTED"), JsonStringEnumMemberName("PROFILE_RESTRICTED")]
    PROFILERESTRICTED,
    [EnumMember(Value = "PROFILE_CUSTOM"), JsonStringEnumMemberName("PROFILE_CUSTOM")]
    PROFILECUSTOM
}

/// <summary>Optional. A TrustConfig resource that contains the trust store for validation of client credentials. The TrustConfig resource must be in the format &quot;projects/{project}/locations/{location}/trustConfigs/{trustConfig}&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicySpecTrustConfigRef
{
    /// <summary>A reference to an externally managed CertificateManagerTrustConfig resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/trustConfigs/{{trustConfig}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CertificateManagerTrustConfig resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CertificateManagerTrustConfig resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>NetworkSecurityTLSInspectionPolicySpec defines the desired state of NetworkSecurityTLSInspectionPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicySpec
{
    /// <summary>Required. A CA pool resource used to issue interception certificates. The CA pool string has a relative resource path following the form &quot;projects/{project}/locations/{location}/caPools/{ca_pool}&quot;.</summary>
    [JsonPropertyName("caPoolRef")]
    public required V1alpha1NetworkSecurityTLSInspectionPolicySpecCaPoolRef CaPoolRef { get; set; }

    /// <summary>Optional. Custom TLS features that are allowed.</summary>
    [JsonPropertyName("customTLSFeatures")]
    public IList<string>? CustomTLSFeatures { get; set; }

    /// <summary>Optional. Free-text description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. If True, then the TrustConfig will exclude public CA certificates.</summary>
    [JsonPropertyName("excludePublicCASet")]
    public bool? ExcludePublicCASet { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Minimum TLS version that is allowed.</summary>
    [JsonPropertyName("minTLSVersion")]
    public V1alpha1NetworkSecurityTLSInspectionPolicySpecMinTLSVersionEnum? MinTLSVersion { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecurityTLSInspectionPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecurityTLSInspectionPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. TLS feature profile that is allowed.</summary>
    [JsonPropertyName("tlsFeatureProfile")]
    public V1alpha1NetworkSecurityTLSInspectionPolicySpecTlsFeatureProfileEnum? TlsFeatureProfile { get; set; }

    /// <summary>Optional. A TrustConfig resource that contains the trust store for validation of client credentials. The TrustConfig resource must be in the format &quot;projects/{project}/locations/{location}/trustConfigs/{trustConfig}&quot;.</summary>
    [JsonPropertyName("trustConfigRef")]
    public V1alpha1NetworkSecurityTLSInspectionPolicySpecTrustConfigRef? TrustConfigRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicyStatusConditions
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

/// <summary>ObservedState contains the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicyStatusObservedState
{
    /// <summary>Output only. The time when the TLS inspection policy was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time when the TLS inspection policy was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityTLSInspectionPolicyStatus defines the observed state of NetworkSecurityTLSInspectionPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the NetworkSecurityTLSInspectionPolicy&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecurityTLSInspectionPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecurityTLSInspectionPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState contains the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecurityTLSInspectionPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecurityTLSInspectionPolicy is the Schema for the NetworkSecurityTLSInspectionPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityTLSInspectionPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecurityTLSInspectionPolicySpec?>, IStatus<V1alpha1NetworkSecurityTLSInspectionPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityTLSInspectionPolicy";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritytlsinspectionpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityTLSInspectionPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityTLSInspectionPolicySpec defines the desired state of NetworkSecurityTLSInspectionPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NetworkSecurityTLSInspectionPolicySpec? Spec { get; set; }

    /// <summary>NetworkSecurityTLSInspectionPolicyStatus defines the observed state of NetworkSecurityTLSInspectionPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecurityTLSInspectionPolicyStatus? Status { get; set; }
}