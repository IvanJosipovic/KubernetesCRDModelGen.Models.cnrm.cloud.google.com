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
/// <summary>NetworkSecurityBackendAuthenticationConfig is the Schema for the NetworkSecurityBackendAuthenticationConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecurityBackendAuthenticationConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityBackendAuthenticationConfigList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritybackendauthenticationconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityBackendAuthenticationConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecurityBackendAuthenticationConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecurityBackendAuthenticationConfig> Items { get; set; }
}

/// <summary>
/// Optional. A reference to a certificatemanager.googleapis.com.Certificate
///  resource. This is a relative resource path following the form
///  &quot;projects/{project}/locations/{location}/certificates/{certificate}&quot;.
/// 
///  Used by a BackendService to negotiate mTLS when the backend connection uses
///  TLS and the backend requests a client certificate. Must have a CLIENT_AUTH
///  scope.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigSpecClientCertificateRef
{
    /// <summary>A reference to an externally managed CertificateManagerCertificate resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/certificates/{{certificate}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CertificateManagerCertificate resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CertificateManagerCertificate resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigSpecProjectRef
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

/// <summary>
/// Optional. A reference to a TrustConfig resource from the
///  certificatemanager.googleapis.com namespace. This is a relative resource
///  path following the form
///  &quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}&quot;.
/// 
///  A BackendService uses the chain of trust represented by this TrustConfig,
///  if specified, to validate the server certificates presented by the backend.
///  Required unless wellKnownRoots is set to PUBLIC_ROOTS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigSpecTrustConfigRef
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

/// <summary>Well known roots to use for server certificate validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NetworkSecurityBackendAuthenticationConfigSpecWellKnownRootsEnum>))]
public enum V1alpha1NetworkSecurityBackendAuthenticationConfigSpecWellKnownRootsEnum
{
    [EnumMember(Value = "WELL_KNOWN_ROOTS_UNSPECIFIED"), JsonStringEnumMemberName("WELL_KNOWN_ROOTS_UNSPECIFIED")]
    WELLKNOWNROOTSUNSPECIFIED,
    [EnumMember(Value = "NONE"), JsonStringEnumMemberName("NONE")]
    NONE,
    [EnumMember(Value = "PUBLIC_ROOTS"), JsonStringEnumMemberName("PUBLIC_ROOTS")]
    PUBLICROOTS
}

/// <summary>NetworkSecurityBackendAuthenticationConfigSpec defines the desired state of NetworkSecurityBackendAuthenticationConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigSpec
{
    /// <summary>
    /// Optional. A reference to a certificatemanager.googleapis.com.Certificate
    ///  resource. This is a relative resource path following the form
    ///  &quot;projects/{project}/locations/{location}/certificates/{certificate}&quot;.
    /// 
    ///  Used by a BackendService to negotiate mTLS when the backend connection uses
    ///  TLS and the backend requests a client certificate. Must have a CLIENT_AUTH
    ///  scope.
    /// </summary>
    [JsonPropertyName("clientCertificateRef")]
    public V1alpha1NetworkSecurityBackendAuthenticationConfigSpecClientCertificateRef? ClientCertificateRef { get; set; }

    /// <summary>Optional. Free-text description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Set of label tags associated with the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecurityBackendAuthenticationConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecurityBackendAuthenticationConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Optional. A reference to a TrustConfig resource from the
    ///  certificatemanager.googleapis.com namespace. This is a relative resource
    ///  path following the form
    ///  &quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}&quot;.
    /// 
    ///  A BackendService uses the chain of trust represented by this TrustConfig,
    ///  if specified, to validate the server certificates presented by the backend.
    ///  Required unless wellKnownRoots is set to PUBLIC_ROOTS.
    /// </summary>
    [JsonPropertyName("trustConfigRef")]
    public V1alpha1NetworkSecurityBackendAuthenticationConfigSpecTrustConfigRef? TrustConfigRef { get; set; }

    /// <summary>Well known roots to use for server certificate validation.</summary>
    [JsonPropertyName("wellKnownRoots")]
    public V1alpha1NetworkSecurityBackendAuthenticationConfigSpecWellKnownRootsEnum? WellKnownRoots { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigStatusConditions
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
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigStatusObservedState
{
    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Etag of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityBackendAuthenticationConfigStatus defines the config connector machine state of NetworkSecurityBackendAuthenticationConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecurityBackendAuthenticationConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecurityBackendAuthenticationConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecurityBackendAuthenticationConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecurityBackendAuthenticationConfig is the Schema for the NetworkSecurityBackendAuthenticationConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityBackendAuthenticationConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecurityBackendAuthenticationConfigSpec>, IStatus<V1alpha1NetworkSecurityBackendAuthenticationConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityBackendAuthenticationConfig";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritybackendauthenticationconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityBackendAuthenticationConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityBackendAuthenticationConfigSpec defines the desired state of NetworkSecurityBackendAuthenticationConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkSecurityBackendAuthenticationConfigSpec Spec { get; set; }

    /// <summary>NetworkSecurityBackendAuthenticationConfigStatus defines the config connector machine state of NetworkSecurityBackendAuthenticationConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecurityBackendAuthenticationConfigStatus? Status { get; set; }
}