#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.videostitcher.cnrm.cloud.google.com;
/// <summary>VideoStitcherCDNKey is the Schema for the VideoStitcherCDNKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VideoStitcherCDNKeyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VideoStitcherCDNKey>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VideoStitcherCDNKeyList";
    public const string KubeGroup = "videostitcher.cnrm.cloud.google.com";
    public const string KubePluralName = "videostitchercdnkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "videostitcher.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VideoStitcherCDNKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VideoStitcherCDNKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VideoStitcherCDNKey> Items { get; set; }
}

/// <summary>The configuration for an Akamai CDN key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeySpecAkamaiCDNKey
{
    /// <summary>Input only. Token key for the Akamai CDN edge configuration.</summary>
    [JsonPropertyName("tokenKey")]
    public byte[]? TokenKey { get; set; }
}

/// <summary>The configuration for a Google Cloud CDN key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeySpecGoogleCDNKey
{
    /// <summary>The public name of the Google Cloud CDN key.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Input only. Secret for this Google Cloud CDN key.</summary>
    [JsonPropertyName("privateKey")]
    public byte[]? PrivateKey { get; set; }
}

/// <summary>Optional. If set, the URL will be signed using the Media CDN token. Otherwise, the URL would be signed using the standard Media CDN signature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeySpecMediaCDNKeyTokenConfig
{
    /// <summary>
    /// Optional. The query parameter in which to find the token.
    /// 
    ///  The name must be 1-64 characters long and match
    ///  the regular expression `[a-zA-Z]([a-zA-Z0-9_-])*` which means the
    ///  first character must be a letter, and all following characters
    ///  must be a dash, underscore, letter or digit.
    /// 
    ///  Defaults to `edge-cache-token`.
    /// </summary>
    [JsonPropertyName("queryParameter")]
    public string? QueryParameter { get; set; }
}

/// <summary>The configuration for a Media CDN key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeySpecMediaCDNKey
{
    /// <summary>The keyset name of the Media CDN key.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Input only. 64-byte ed25519 private key for this Media CDN key.</summary>
    [JsonPropertyName("privateKey")]
    public byte[]? PrivateKey { get; set; }

    /// <summary>Optional. If set, the URL will be signed using the Media CDN token. Otherwise, the URL would be signed using the standard Media CDN signature.</summary>
    [JsonPropertyName("tokenConfig")]
    public V1alpha1VideoStitcherCDNKeySpecMediaCDNKeyTokenConfig? TokenConfig { get; set; }
}

/// <summary>Immutable. The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeySpecProjectRef
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

/// <summary>VideoStitcherCDNKeySpec defines the desired state of VideoStitcherCDNKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeySpec
{
    /// <summary>The configuration for an Akamai CDN key.</summary>
    [JsonPropertyName("akamaiCDNKey")]
    public V1alpha1VideoStitcherCDNKeySpecAkamaiCDNKey? AkamaiCDNKey { get; set; }

    /// <summary>The configuration for a Google Cloud CDN key.</summary>
    [JsonPropertyName("googleCDNKey")]
    public V1alpha1VideoStitcherCDNKeySpecGoogleCDNKey? GoogleCDNKey { get; set; }

    /// <summary>The hostname this key applies to.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The configuration for a Media CDN key.</summary>
    [JsonPropertyName("mediaCDNKey")]
    public V1alpha1VideoStitcherCDNKeySpecMediaCDNKey? MediaCDNKey { get; set; }

    /// <summary>Immutable. The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VideoStitcherCDNKeySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The VideoStitcherCDNKey name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeyStatusConditions
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
public partial class V1alpha1VideoStitcherCDNKeyStatusObservedState
{
}

/// <summary>VideoStitcherCDNKeyStatus defines the config connector machine state of VideoStitcherCDNKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VideoStitcherCDNKeyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VideoStitcherCDNKeyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VideoStitcherCDNKey resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VideoStitcherCDNKeyStatusObservedState? ObservedState { get; set; }
}

/// <summary>VideoStitcherCDNKey is the Schema for the VideoStitcherCDNKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VideoStitcherCDNKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VideoStitcherCDNKeySpec>, IStatus<V1alpha1VideoStitcherCDNKeyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VideoStitcherCDNKey";
    public const string KubeGroup = "videostitcher.cnrm.cloud.google.com";
    public const string KubePluralName = "videostitchercdnkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "videostitcher.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VideoStitcherCDNKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VideoStitcherCDNKeySpec defines the desired state of VideoStitcherCDNKey</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VideoStitcherCDNKeySpec Spec { get; set; }

    /// <summary>VideoStitcherCDNKeyStatus defines the config connector machine state of VideoStitcherCDNKey</summary>
    [JsonPropertyName("status")]
    public V1alpha1VideoStitcherCDNKeyStatus? Status { get; set; }
}