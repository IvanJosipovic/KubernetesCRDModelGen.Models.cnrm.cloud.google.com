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
/// <summary>DiscoveryEngineIdentityMappingStore is the Schema for the DiscoveryEngineIdentityMappingStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DiscoveryEngineIdentityMappingStore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineIdentityMappingStoreList";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryengineidentitymappingstores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "discoveryengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiscoveryEngineIdentityMappingStoreList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DiscoveryEngineIdentityMappingStore objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DiscoveryEngineIdentityMappingStore> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreSpecProjectRef
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

/// <summary>DiscoveryEngineIdentityMappingStoreSpec defines the desired state of DiscoveryEngineIdentityMappingStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreSpec
{
    /// <summary>
    /// Input only. The KMS key to be used to protect this Identity Mapping Store
    /// at creation time.
    /// 
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// 
    /// If this field is set and processed successfully, the Identity Mapping Store
    /// will be protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DiscoveryEngineIdentityMappingStoreSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DiscoveryEngineIdentityMappingStore name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreStatusConditions
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
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreStatusObservedStateCmekConfigSingleRegionKeys
{
    /// <summary>Required. Single-regional kms key resource name which will be used to encrypt resources `projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}`.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Output only. CMEK-related information for the Identity Mapping Store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreStatusObservedStateCmekConfig
{
    /// <summary>KMS key resource name which will be used to encrypt resources `projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}`.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>KMS key version resource name which will be used to encrypt resources `&lt;kms_key&gt;/cryptoKeyVersions/{keyVersion}`.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }

    /// <summary>Required. The name of the CmekConfig of the form `projects/{project}/locations/{location}/cmekConfig` or `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Single-regional CMEKs that are required for some VAIS features.</summary>
    [JsonPropertyName("singleRegionKeys")]
    public IList<V1alpha1DiscoveryEngineIdentityMappingStoreStatusObservedStateCmekConfigSingleRegionKeys>? SingleRegionKeys { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreStatusObservedState
{
    /// <summary>Output only. CMEK-related information for the Identity Mapping Store.</summary>
    [JsonPropertyName("cmekConfig")]
    public V1alpha1DiscoveryEngineIdentityMappingStoreStatusObservedStateCmekConfig? CmekConfig { get; set; }
}

/// <summary>DiscoveryEngineIdentityMappingStoreStatus defines the config connector machine state of DiscoveryEngineIdentityMappingStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineIdentityMappingStoreStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineIdentityMappingStoreStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DiscoveryEngineIdentityMappingStore resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DiscoveryEngineIdentityMappingStoreStatusObservedState? ObservedState { get; set; }
}

/// <summary>DiscoveryEngineIdentityMappingStore is the Schema for the DiscoveryEngineIdentityMappingStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineIdentityMappingStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DiscoveryEngineIdentityMappingStoreSpec>, IStatus<V1alpha1DiscoveryEngineIdentityMappingStoreStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineIdentityMappingStore";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryengineidentitymappingstores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "discoveryengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiscoveryEngineIdentityMappingStore";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiscoveryEngineIdentityMappingStoreSpec defines the desired state of DiscoveryEngineIdentityMappingStore</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DiscoveryEngineIdentityMappingStoreSpec Spec { get; set; }

    /// <summary>DiscoveryEngineIdentityMappingStoreStatus defines the config connector machine state of DiscoveryEngineIdentityMappingStore</summary>
    [JsonPropertyName("status")]
    public V1alpha1DiscoveryEngineIdentityMappingStoreStatus? Status { get; set; }
}