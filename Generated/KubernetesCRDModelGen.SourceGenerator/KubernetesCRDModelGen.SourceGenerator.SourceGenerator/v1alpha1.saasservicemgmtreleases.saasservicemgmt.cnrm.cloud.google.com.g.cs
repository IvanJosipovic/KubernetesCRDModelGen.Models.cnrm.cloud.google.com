#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.saasservicemgmt.cnrm.cloud.google.com;
/// <summary>SaasServiceMgmtRelease is the Schema for the SaasServiceMgmtRelease API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SaasServiceMgmtReleaseList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SaasServiceMgmtRelease>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SaasServiceMgmtReleaseList";
    public const string KubeGroup = "saasservicemgmt.cnrm.cloud.google.com";
    public const string KubePluralName = "saasservicemgmtreleases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "saasservicemgmt.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SaasServiceMgmtReleaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SaasServiceMgmtRelease objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SaasServiceMgmtRelease> Items { get; set; }
}

/// <summary>Optional. Blueprints are OCI Images that contain all of the artifacts needed to provision a unit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseSpecBlueprint
{
    /// <summary>Optional. Immutable. URI to a blueprint used by the Unit (required unless unitKind or release is set).</summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseSpecInputVariableDefaults
{
    /// <summary>Optional. Immutable. Name of a supported variable type. Supported types are string, int, bool.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Optional. String encoded value for the variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Required. Immutable. Name of the variable from actuation configs.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseSpecProjectRef
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

/// <summary>Optional. Set of requirements to be fulfilled on the Unit when using this Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseSpecReleaseRequirements
{
    /// <summary>Optional. A list of releases from which a unit can be upgraded to this one (optional). If left empty no constraints will be applied. When provided, unit upgrade requests to this release will check and enforce this constraint.</summary>
    [JsonPropertyName("upgradeableFromReleases")]
    public IList<string>? UpgradeableFromReleases { get; set; }
}

/// <summary>SaasServiceMgmtReleaseSpec defines the desired state of SaasServiceMgmtRelease</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseSpec
{
    /// <summary>Optional. Blueprints are OCI Images that contain all of the artifacts needed to provision a unit.</summary>
    [JsonPropertyName("blueprint")]
    public V1alpha1SaasServiceMgmtReleaseSpecBlueprint? Blueprint { get; set; }

    /// <summary>Optional. Mapping of input variables to default values. Maximum 100</summary>
    [JsonPropertyName("inputVariableDefaults")]
    public IList<V1alpha1SaasServiceMgmtReleaseSpecInputVariableDefaults>? InputVariableDefaults { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1SaasServiceMgmtReleaseSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Set of requirements to be fulfilled on the Unit when using this Release.</summary>
    [JsonPropertyName("releaseRequirements")]
    public V1alpha1SaasServiceMgmtReleaseSpecReleaseRequirements? ReleaseRequirements { get; set; }

    /// <summary>The SaasServiceMgmtRelease name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Immutable. Reference to the UnitKind this Release corresponds to (required and immutable once created).</summary>
    [JsonPropertyName("unitKind")]
    public required string UnitKind { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseStatusConditions
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

/// <summary>Optional. Blueprints are OCI Images that contain all of the artifacts needed to provision a unit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseStatusObservedStateBlueprint
{
    /// <summary>Output only. Type of the engine used to actuate the blueprint. e.g. terraform, helm etc.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Output only. Version metadata if present on the blueprint.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseStatusObservedStateInputVariables
{
    /// <summary>Optional. Immutable. Name of a supported variable type. Supported types are string, int, bool.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Optional. String encoded value for the variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Required. Immutable. Name of the variable from actuation configs.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseStatusObservedStateOutputVariables
{
    /// <summary>Optional. Immutable. Name of a supported variable type. Supported types are string, int, bool.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Optional. String encoded value for the variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Required. Immutable. Name of the variable from actuation configs.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseStatusObservedState
{
    /// <summary>Optional. Blueprints are OCI Images that contain all of the artifacts needed to provision a unit.</summary>
    [JsonPropertyName("blueprint")]
    public V1alpha1SaasServiceMgmtReleaseStatusObservedStateBlueprint? Blueprint { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used to confirm that the client and server agree on the ordering of a resource being written.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Optional. Output only. List of input variables declared on the blueprint and can be present with their values on the unit spec</summary>
    [JsonPropertyName("inputVariables")]
    public IList<V1alpha1SaasServiceMgmtReleaseStatusObservedStateInputVariables>? InputVariables { get; set; }

    /// <summary>Optional. Output only. List of output variables declared on the blueprint and can be present with their values on the unit status</summary>
    [JsonPropertyName("outputVariables")]
    public IList<V1alpha1SaasServiceMgmtReleaseStatusObservedStateOutputVariables>? OutputVariables { get; set; }

    /// <summary>Output only. The unique identifier of the resource. UID is unique in the time and space for this resource within the scope of the service. It is typically generated by the server on successful creation of a resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This should be a UUID4.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The timestamp when the resource was last updated. Any change to the resource made by users must refresh this value. Changes to a resource made by the service should refresh this value.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>SaasServiceMgmtReleaseStatus defines the config connector machine state of SaasServiceMgmtRelease</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SaasServiceMgmtReleaseStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SaasServiceMgmtReleaseStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SaasServiceMgmtRelease resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1SaasServiceMgmtReleaseStatusObservedState? ObservedState { get; set; }
}

/// <summary>SaasServiceMgmtRelease is the Schema for the SaasServiceMgmtRelease API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SaasServiceMgmtRelease : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SaasServiceMgmtReleaseSpec>, IStatus<V1alpha1SaasServiceMgmtReleaseStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SaasServiceMgmtRelease";
    public const string KubeGroup = "saasservicemgmt.cnrm.cloud.google.com";
    public const string KubePluralName = "saasservicemgmtreleases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "saasservicemgmt.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SaasServiceMgmtRelease";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SaasServiceMgmtReleaseSpec defines the desired state of SaasServiceMgmtRelease</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SaasServiceMgmtReleaseSpec Spec { get; set; }

    /// <summary>SaasServiceMgmtReleaseStatus defines the config connector machine state of SaasServiceMgmtRelease</summary>
    [JsonPropertyName("status")]
    public V1alpha1SaasServiceMgmtReleaseStatus? Status { get; set; }
}