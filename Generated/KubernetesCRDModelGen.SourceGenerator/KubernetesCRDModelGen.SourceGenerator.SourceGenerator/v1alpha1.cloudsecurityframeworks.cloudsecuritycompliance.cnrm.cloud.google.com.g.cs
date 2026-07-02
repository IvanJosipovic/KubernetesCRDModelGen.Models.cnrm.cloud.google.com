#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudsecuritycompliance.cnrm.cloud.google.com;
/// <summary>CloudSecurityFramework is the Schema for the CloudSecurityFramework API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudSecurityFrameworkList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudSecurityFramework>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudSecurityFrameworkList";
    public const string KubeGroup = "cloudsecuritycompliance.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudsecurityframeworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudsecuritycompliance.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudSecurityFrameworkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudSecurityFramework objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudSecurityFramework> Items { get; set; }
}

/// <summary>Required. The name of the CloudControl in the format: “organizations/{organization}/locations/{location}/ cloudControls/{cloud-control}”</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkSpecCloudControlDetailsCloudControlRef
{
    /// <summary>A reference to an externally managed CloudSecurityComplianceCloudControl resource. Should be in the format &quot;organizations/{{organizationID}}/locations/{{location}}/cloudControls/{{cloudControlID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudSecurityComplianceCloudControl resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudSecurityComplianceCloudControl resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkSpecCloudControlDetailsParameters
{
    /// <summary>Required. The name or key of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The value of the parameter.</summary>
    [JsonPropertyName("parameterValue")]
    public JsonNode? ParameterValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkSpecCloudControlDetails
{
    /// <summary>Required. The name of the CloudControl in the format: “organizations/{organization}/locations/{location}/ cloudControls/{cloud-control}”</summary>
    [JsonPropertyName("cloudControlRef")]
    public V1alpha1CloudSecurityFrameworkSpecCloudControlDetailsCloudControlRef? CloudControlRef { get; set; }

    /// <summary>Required. Major revision of cloudcontrol</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }

    /// <summary>Optional. Parameters is a key-value pair that is required by the CloudControl. The specification of these parameters will be present in cloudcontrol.Eg: { &quot;name&quot;: &quot;location&quot;,&quot;value&quot;: &quot;us-west-1&quot;}.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1CloudSecurityFrameworkSpecCloudControlDetailsParameters>? Parameters { get; set; }
}

/// <summary>The organization that this resource belongs to. Only one of organizationRef or projectRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkSpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public required string External { get; set; }
}

/// <summary>The project that this resource belongs to. Only one of organizationRef or projectRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkSpecProjectRef
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

/// <summary>CloudSecurityFrameworkSpec defines the desired state of CloudSecurityFramework</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkSpec
{
    /// <summary>Optional. The category of the framework.</summary>
    [JsonPropertyName("category")]
    public IList<string>? Category { get; set; }

    /// <summary>Optional. The cloud control details that are directly added without any grouping in the framework.</summary>
    [JsonPropertyName("cloudControlDetails")]
    public IList<V1alpha1CloudSecurityFrameworkSpecCloudControlDetails>? CloudControlDetails { get; set; }

    /// <summary>Optional. The description of the framework. The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The friendly name of the framework. The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. The labels with user-defined metadata to organize your frameworks.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The organization that this resource belongs to. Only one of organizationRef or projectRef may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1CloudSecurityFrameworkSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The project that this resource belongs to. Only one of organizationRef or projectRef may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudSecurityFrameworkSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Optional. The CloudSecurityFramework name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkStatusConditions
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
public partial class V1alpha1CloudSecurityFrameworkStatusObservedState
{
    /// <summary>Output only. The major version of the framework, which is incremented in ascending order.</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }

    /// <summary>Output only. The cloud providers that are supported by the framework.</summary>
    [JsonPropertyName("supportedCloudProviders")]
    public IList<string>? SupportedCloudProviders { get; set; }

    /// <summary>Output only. The supported enforcement modes of the framework.</summary>
    [JsonPropertyName("supportedEnforcementModes")]
    public IList<string>? SupportedEnforcementModes { get; set; }

    /// <summary>Output only. The target resource types that are supported by the framework.</summary>
    [JsonPropertyName("supportedTargetResourceTypes")]
    public IList<string>? SupportedTargetResourceTypes { get; set; }

    /// <summary>Output only. The type of framework.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>CloudSecurityFrameworkStatus defines the config connector machine state of CloudSecurityFramework</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityFrameworkStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudSecurityFrameworkStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudSecurityFramework resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudSecurityFrameworkStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudSecurityFramework is the Schema for the CloudSecurityFramework API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudSecurityFramework : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudSecurityFrameworkSpec>, IStatus<V1alpha1CloudSecurityFrameworkStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudSecurityFramework";
    public const string KubeGroup = "cloudsecuritycompliance.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudsecurityframeworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudsecuritycompliance.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudSecurityFramework";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudSecurityFrameworkSpec defines the desired state of CloudSecurityFramework</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudSecurityFrameworkSpec Spec { get; set; }

    /// <summary>CloudSecurityFrameworkStatus defines the config connector machine state of CloudSecurityFramework</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudSecurityFrameworkStatus? Status { get; set; }
}