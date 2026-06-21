#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeBackendServiceSignedURLKey is the Schema for the ComputeBackendServiceSignedURLKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeBackendServiceSignedURLKeyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeBackendServiceSignedURLKey>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeBackendServiceSignedURLKeyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computebackendservicesignedurlkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeBackendServiceSignedURLKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ComputeBackendServiceSignedURLKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ComputeBackendServiceSignedURLKey> Items { get; set; }
}

/// <summary>ComputeBackendServiceRef is a reference to a ComputeBackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeySpecBackendServiceRef
{
    /// <summary>The value of an externally managed ComputeBackendService resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeBackendService resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeBackendService resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeySpecKeyValueValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeySpecKeyValueValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ComputeBackendServiceSignedURLKeySpecKeyValueValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeySpecKeyValue
{
    /// <summary>Value of the field. Cannot be used if &apos;valueFrom&apos; is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ComputeBackendServiceSignedURLKeySpecKeyValueValueFrom? ValueFrom { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ComputeBackendServiceSignedURLKeySpec defines the desired state of ComputeBackendServiceSignedURLKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeySpec
{
    /// <summary>ComputeBackendServiceRef is a reference to a ComputeBackendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public required V1alpha1ComputeBackendServiceSignedURLKeySpecBackendServiceRef BackendServiceRef { get; set; }

    /// <summary>Immutable. 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.</summary>
    [JsonPropertyName("keyValue")]
    public required V1alpha1ComputeBackendServiceSignedURLKeySpecKeyValue KeyValue { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ComputeBackendServiceSignedURLKeySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeyStatusConditions
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

/// <summary>ComputeBackendServiceSignedURLKeyStatus defines the config connector machine state of ComputeBackendServiceSignedURLKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeBackendServiceSignedURLKeyStatus
{
    /// <summary>Conditions represent the latest available observations of the ComputeBackendServiceSignedURLKey&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeBackendServiceSignedURLKeyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ComputeBackendServiceSignedURLKey is the Schema for the ComputeBackendServiceSignedURLKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeBackendServiceSignedURLKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeBackendServiceSignedURLKeySpec>, IStatus<V1alpha1ComputeBackendServiceSignedURLKeyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeBackendServiceSignedURLKey";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computebackendservicesignedurlkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeBackendServiceSignedURLKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeBackendServiceSignedURLKeySpec defines the desired state of ComputeBackendServiceSignedURLKey</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ComputeBackendServiceSignedURLKeySpec Spec { get; set; }

    /// <summary>ComputeBackendServiceSignedURLKeyStatus defines the config connector machine state of ComputeBackendServiceSignedURLKey</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeBackendServiceSignedURLKeyStatus? Status { get; set; }
}