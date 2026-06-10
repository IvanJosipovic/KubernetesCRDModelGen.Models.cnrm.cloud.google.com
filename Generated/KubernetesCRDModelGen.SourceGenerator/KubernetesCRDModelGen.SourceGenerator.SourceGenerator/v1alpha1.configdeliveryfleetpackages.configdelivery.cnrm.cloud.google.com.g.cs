#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.configdelivery.cnrm.cloud.google.com;
/// <summary>ConfigDeliveryFleetPackage is the Schema for the ConfigDeliveryFleetPackage API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ConfigDeliveryFleetPackageList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ConfigDeliveryFleetPackage>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ConfigDeliveryFleetPackageList";
    public const string KubeGroup = "configdelivery.cnrm.cloud.google.com";
    public const string KubePluralName = "configdeliveryfleetpackages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "configdelivery.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigDeliveryFleetPackageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ConfigDeliveryFleetPackage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ConfigDeliveryFleetPackage> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecProjectRef
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

/// <summary>Required. Name of the cloud build repository. Format is projects/{p}/locations/{l}/connections/{c}/repositories/{r}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorCloudBuildRepositoryRepositoryRef
{
    /// <summary>A reference to an externally managed CloudBuildRepository resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/connections/{{connectionID}}/repositories/{{RepositoryID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudBuildRepository resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudBuildRepository resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Google service account to use in CloudBuild triggers to fetch and store kubernetes configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorCloudBuildRepositoryServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Information specifying `CloudBuildRepository`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorCloudBuildRepository
{
    /// <summary>Optional. path to the directory or file within the repository that contains the kubernetes configuration. If unspecified, path is assumed to the top level root directory of the repository.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Name of the cloud build repository. Format is projects/{p}/locations/{l}/connections/{c}/repositories/{r}.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorCloudBuildRepositoryRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Required. Google service account to use in CloudBuild triggers to fetch and store kubernetes configuration.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorCloudBuildRepositoryServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Required. git tag of the underlying git repository. The git tag must be in the semantic version format `vX.Y.Z`.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Optional. variants_pattern is a glob pattern that will be used to find variants in the repository. Examples: `variants/*.yaml`, `us-*`</summary>
    [JsonPropertyName("variantsPattern")]
    public string? VariantsPattern { get; set; }
}

/// <summary>Required. Name of the `ResourceBundle`. Format is projects/{p}/locations/{l}/resourceBundles/{r}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorResourceBundleResourceBundleRef
{
    /// <summary>A reference to an externally managed ConfigDeliveryResourceBundle resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/resourceBundles/{{resourceBundleID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ConfigDeliveryResourceBundle resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ConfigDeliveryResourceBundle resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Information specifying `ResourceBundle`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorResourceBundle
{
    /// <summary>Required. Name of the `ResourceBundle`. Format is projects/{p}/locations/{l}/resourceBundles/{r}.</summary>
    [JsonPropertyName("resourceBundleRef")]
    public V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorResourceBundleResourceBundleRef? ResourceBundleRef { get; set; }

    /// <summary>Required. Tag refers to a version of the release in a `ResourceBundle`. This is a Git tag in the semantic version format `vX.Y.Z`.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Required. Information specifying the source of kubernetes configuration to deploy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelector
{
    /// <summary>Information specifying `CloudBuildRepository`.</summary>
    [JsonPropertyName("cloudBuildRepository")]
    public V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorCloudBuildRepository? CloudBuildRepository { get; set; }

    /// <summary>Information specifying `ResourceBundle`.</summary>
    [JsonPropertyName("resourceBundle")]
    public V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelectorResourceBundle? ResourceBundle { get; set; }
}

/// <summary>AllAtOnceStrategy causes all clusters to be updated concurrently.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecRolloutStrategyAllAtOnce
{
}

/// <summary>RollingStrategy causes a specified number of clusters to be updated concurrently until all clusters are updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecRolloutStrategyRolling
{
    /// <summary>Optional. Maximum number of clusters to update the resource bundle on concurrently.</summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }
}

/// <summary>Optional. The strategy to use to deploy kubernetes configuration to clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecRolloutStrategy
{
    /// <summary>AllAtOnceStrategy causes all clusters to be updated concurrently.</summary>
    [JsonPropertyName("allAtOnce")]
    public V1alpha1ConfigDeliveryFleetPackageSpecRolloutStrategyAllAtOnce? AllAtOnce { get; set; }

    /// <summary>RollingStrategy causes a specified number of clusters to be updated concurrently until all clusters are updated.</summary>
    [JsonPropertyName("rolling")]
    public V1alpha1ConfigDeliveryFleetPackageSpecRolloutStrategyRolling? Rolling { get; set; }
}

/// <summary>Required. The host project for the GKE fleet. Format is `projects/{project}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecTargetFleetProjectRef
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

/// <summary>Optional. selector allows targeting a subset of fleet members using their labels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecTargetFleetSelector
{
    /// <summary>Optional. match_labels is a map of {key,value} pairs. Each {key,value} pair must match an existing label key and value exactly in order to satisfy the match.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>The GKE fleet information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecTargetFleet
{
    /// <summary>Required. The host project for the GKE fleet. Format is `projects/{project}`.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ConfigDeliveryFleetPackageSpecTargetFleetProjectRef? ProjectRef { get; set; }

    /// <summary>Optional. selector allows targeting a subset of fleet members using their labels.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1ConfigDeliveryFleetPackageSpecTargetFleetSelector? Selector { get; set; }
}

/// <summary>Optional. Configuration to select target clusters to deploy kubernetes configuration to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecTarget
{
    /// <summary>The GKE fleet information.</summary>
    [JsonPropertyName("fleet")]
    public V1alpha1ConfigDeliveryFleetPackageSpecTargetFleet? Fleet { get; set; }
}

/// <summary>Required. Information specifying how to map a `ResourceBundle` variant to a target cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpecVariantSelector
{
    /// <summary>
    /// Required. variant_name_template is a template that can refer to
    ///  variables containing cluster membership metadata such as location,
    ///  name, and labels to generate the name of the variant for a target
    ///  cluster. The variable syntax is similar to the unix shell variables.
    /// 
    ///  Available variables are `${membership.name}`, `${membership.location}`,
    ///  `${membership.project}` and `${membership.labels[&apos;label_name&apos;]}`.
    /// 
    ///  If you want to deploy a specific variant, say &quot;default&quot; to all the
    ///  clusters, you can use &quot;default&quot; (string without any variables) as
    ///  the variant_name_template.
    /// </summary>
    [JsonPropertyName("variantNameTemplate")]
    public string? VariantNameTemplate { get; set; }
}

/// <summary>ConfigDeliveryFleetPackageSpec defines the desired state of ConfigDeliveryFleetPackage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageSpec
{
    /// <summary>Optional. Information around how to handle kubernetes resources at the target clusters when the `FleetPackage` is deleted.</summary>
    [JsonPropertyName("deletionPropagationPolicy")]
    public string? DeletionPropagationPolicy { get; set; }

    /// <summary>The location that this resource belongs to.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ConfigDeliveryFleetPackageSpecProjectRef ProjectRef { get; set; }

    /// <summary>Required. Information specifying the source of kubernetes configuration to deploy.</summary>
    [JsonPropertyName("resourceBundleSelector")]
    public V1alpha1ConfigDeliveryFleetPackageSpecResourceBundleSelector? ResourceBundleSelector { get; set; }

    /// <summary>The ConfigDeliveryFleetPackage name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The strategy to use to deploy kubernetes configuration to clusters.</summary>
    [JsonPropertyName("rolloutStrategy")]
    public V1alpha1ConfigDeliveryFleetPackageSpecRolloutStrategy? RolloutStrategy { get; set; }

    /// <summary>Optional. The desired state of the fleet package.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Optional. Configuration to select target clusters to deploy kubernetes configuration to.</summary>
    [JsonPropertyName("target")]
    public V1alpha1ConfigDeliveryFleetPackageSpecTarget? Target { get; set; }

    /// <summary>Required. Information specifying how to map a `ResourceBundle` variant to a target cluster.</summary>
    [JsonPropertyName("variantSelector")]
    public V1alpha1ConfigDeliveryFleetPackageSpecVariantSelector? VariantSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageStatusConditions
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
public partial class V1alpha1ConfigDeliveryFleetPackageStatusObservedStateInfoErrors
{
    /// <summary>Optional. A description of the error.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }
}

/// <summary>Output only. Information containing the rollout status of the `FleetPackage` across all the target clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageStatusObservedStateInfo
{
    /// <summary>Optional. The active rollout, if any. Format is `projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}`.</summary>
    [JsonPropertyName("activeRollout")]
    public string? ActiveRollout { get; set; }

    /// <summary>Optional. Output only. Errors encountered during configuration deployment (if any).</summary>
    [JsonPropertyName("errors")]
    public IList<V1alpha1ConfigDeliveryFleetPackageStatusObservedStateInfoErrors>? Errors { get; set; }

    /// <summary>Optional. The last completed rollout, if any. Format is `projects/{project}/locations/{location}/fleetPackages/{fleet_package}/rollouts/{rollout}`.</summary>
    [JsonPropertyName("lastCompletedRollout")]
    public string? LastCompletedRollout { get; set; }

    /// <summary>Optional. Output only. The current state of the `FleetPackage`.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageStatusObservedState
{
    /// <summary>Output only. Time at which the `FleetPackage` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Information containing the rollout status of the `FleetPackage` across all the target clusters.</summary>
    [JsonPropertyName("info")]
    public V1alpha1ConfigDeliveryFleetPackageStatusObservedStateInfo? Info { get; set; }

    /// <summary>Output only. Most recent time at which the `FleetPackage` was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ConfigDeliveryFleetPackageStatus defines the config connector machine state of ConfigDeliveryFleetPackage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConfigDeliveryFleetPackageStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ConfigDeliveryFleetPackageStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ConfigDeliveryFleetPackage resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ConfigDeliveryFleetPackageStatusObservedState? ObservedState { get; set; }
}

/// <summary>ConfigDeliveryFleetPackage is the Schema for the ConfigDeliveryFleetPackage API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ConfigDeliveryFleetPackage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ConfigDeliveryFleetPackageSpec>, IStatus<V1alpha1ConfigDeliveryFleetPackageStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ConfigDeliveryFleetPackage";
    public const string KubeGroup = "configdelivery.cnrm.cloud.google.com";
    public const string KubePluralName = "configdeliveryfleetpackages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "configdelivery.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigDeliveryFleetPackage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigDeliveryFleetPackageSpec defines the desired state of ConfigDeliveryFleetPackage</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ConfigDeliveryFleetPackageSpec Spec { get; set; }

    /// <summary>ConfigDeliveryFleetPackageStatus defines the config connector machine state of ConfigDeliveryFleetPackage</summary>
    [JsonPropertyName("status")]
    public V1alpha1ConfigDeliveryFleetPackageStatus? Status { get; set; }
}