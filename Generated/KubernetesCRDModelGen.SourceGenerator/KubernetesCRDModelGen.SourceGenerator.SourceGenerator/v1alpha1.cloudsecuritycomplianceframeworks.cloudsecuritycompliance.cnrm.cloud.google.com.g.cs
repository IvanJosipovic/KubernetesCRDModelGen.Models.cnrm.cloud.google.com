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
/// <summary>CloudSecurityComplianceFramework is the Schema for the CloudSecurityComplianceFramework API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudSecurityComplianceFrameworkList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudSecurityComplianceFramework>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudSecurityComplianceFrameworkList";
    public const string KubeGroup = "cloudsecuritycompliance.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudsecuritycomplianceframeworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudsecuritycompliance.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudSecurityComplianceFrameworkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudSecurityComplianceFramework objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudSecurityComplianceFramework> Items { get; set; }
}

/// <summary>Required. The name of the CloudControl in the format: “organizations/{organization}/locations/{location}/ cloudControls/{cloud-control}”</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlDetailsCloudControlRef
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
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlDetailsParameters
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
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlDetails
{
    /// <summary>Required. The name of the CloudControl in the format: “organizations/{organization}/locations/{location}/ cloudControls/{cloud-control}”</summary>
    [JsonPropertyName("cloudControlRef")]
    public V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlDetailsCloudControlRef? CloudControlRef { get; set; }

    /// <summary>Required. Major revision of cloudcontrol</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }

    /// <summary>Optional. Parameters is a key-value pair that is required by the CloudControl. The specification of these parameters will be present in cloudcontrol.Eg: { &quot;name&quot;: &quot;location&quot;,&quot;value&quot;: &quot;us-west-1&quot;}.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlDetailsParameters>? Parameters { get; set; }
}

/// <summary>Required. The name of the CloudControl in the format: “organizations/{organization}/locations/{location}/ cloudControls/{cloud-control}”</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlDetailsCloudControlRef
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
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlDetailsParameters
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
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlDetails
{
    /// <summary>Required. The name of the CloudControl in the format: “organizations/{organization}/locations/{location}/ cloudControls/{cloud-control}”</summary>
    [JsonPropertyName("cloudControlRef")]
    public V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlDetailsCloudControlRef? CloudControlRef { get; set; }

    /// <summary>Required. Major revision of cloudcontrol</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }

    /// <summary>Optional. Parameters is a key-value pair that is required by the CloudControl. The specification of these parameters will be present in cloudcontrol.Eg: { &quot;name&quot;: &quot;location&quot;,&quot;value&quot;: &quot;us-west-1&quot;}.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlDetailsParameters>? Parameters { get; set; }
}

/// <summary>Required. The name of the cloud control group in the format: “organizations/{organization}/locations/{location}/ cloudControlGroups/{cloud-control-group}”</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlGroupRef
{
    /// <summary>A reference to an externally managed CloudSecurityComplianceCloudControlGroup resource. Should be in the format &quot;organizations/{{organizationID}}/locations/{{location}}/cloudControlGroups/{{cloudControlGroupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudSecurityComplianceCloudControlGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudSecurityComplianceCloudControlGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The industry-defined Control assciated with the cloud controls in this group. organizations/{organization}/locations/{location}/controls/{control_id}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupControlRef
{
    /// <summary>A reference to an externally managed CloudSecurityComplianceControl resource. Should be in the format &quot;organizations/{{organizationID}}/locations/{{location}}/controls/{{controlID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudSecurityComplianceControl resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudSecurityComplianceControl resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The cloud control group included in the framework.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroup
{
    /// <summary>Required. The details of the cloud controls to be referred to in the framework.</summary>
    [JsonPropertyName("cloudControlDetails")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlDetails>? CloudControlDetails { get; set; }

    /// <summary>Required. The name of the cloud control group in the format: “organizations/{organization}/locations/{location}/ cloudControlGroups/{cloud-control-group}”</summary>
    [JsonPropertyName("cloudControlGroupRef")]
    public V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupCloudControlGroupRef? CloudControlGroupRef { get; set; }

    /// <summary>Optional. The control identifier used to fetch the findings. This is same as the control report name.</summary>
    [JsonPropertyName("controlID")]
    public string? ControlID { get; set; }

    /// <summary>Optional. The industry-defined Control assciated with the cloud controls in this group. organizations/{organization}/locations/{location}/controls/{control_id}</summary>
    [JsonPropertyName("controlRef")]
    public V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroupControlRef? ControlRef { get; set; }

    /// <summary>Optional. The description of the cloud control group.The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Major revision of the cloud control group.</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetails
{
    /// <summary>The cloud control group included in the framework.</summary>
    [JsonPropertyName("cloudControlGroup")]
    public V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetailsCloudControlGroup? CloudControlGroup { get; set; }
}

/// <summary>The organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public required string External { get; set; }
}

/// <summary>CloudSecurityComplianceFrameworkSpec defines the desired state of CloudSecurityComplianceFramework</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkSpec
{
    /// <summary>Optional. The category of the framework.</summary>
    [JsonPropertyName("category")]
    public IList<string>? Category { get; set; }

    /// <summary>Optional. The details of the cloud controls directly added without any grouping in the framework.</summary>
    [JsonPropertyName("cloudControlDetails")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlDetails>? CloudControlDetails { get; set; }

    /// <summary>Optional. The details of the cloud control groups included in the framework.</summary>
    [JsonPropertyName("cloudControlGroupDetails")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkSpecCloudControlGroupDetails>? CloudControlGroupDetails { get; set; }

    /// <summary>Optional. The description of the framework. The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Display name of the framework. The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public required V1alpha1CloudSecurityComplianceFrameworkSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>The CloudSecurityComplianceFramework name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkStatusConditions
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

/// <summary>The cloud control group included in the framework.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkStatusObservedStateCloudControlGroupDetailsCloudControlGroup
{
    /// <summary>Optional. Output only. The type of the cloud control group. Default is TYPE_CUSTOM.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkStatusObservedStateCloudControlGroupDetails
{
    /// <summary>The cloud control group included in the framework.</summary>
    [JsonPropertyName("cloudControlGroup")]
    public V1alpha1CloudSecurityComplianceFrameworkStatusObservedStateCloudControlGroupDetailsCloudControlGroup? CloudControlGroup { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkStatusObservedState
{
    /// <summary>Optional. The details of the cloud control groups included in the framework.</summary>
    [JsonPropertyName("cloudControlGroupDetails")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkStatusObservedStateCloudControlGroupDetails>? CloudControlGroupDetails { get; set; }

    /// <summary>Output only. Major revision of the framework incremented in ascending order.</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }

    /// <summary>Output only. cloud providers supported.</summary>
    [JsonPropertyName("supportedCloudProviders")]
    public IList<string>? SupportedCloudProviders { get; set; }

    /// <summary>Output only. target resource types supported by the Framework.</summary>
    [JsonPropertyName("supportedTargetResourceTypes")]
    public IList<string>? SupportedTargetResourceTypes { get; set; }

    /// <summary>Output only. The type of the framework. The default is TYPE_CUSTOM.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>CloudSecurityComplianceFrameworkStatus defines the config connector machine state of CloudSecurityComplianceFramework</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceFrameworkStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudSecurityComplianceFrameworkStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudSecurityComplianceFramework resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudSecurityComplianceFrameworkStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudSecurityComplianceFramework is the Schema for the CloudSecurityComplianceFramework API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudSecurityComplianceFramework : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudSecurityComplianceFrameworkSpec>, IStatus<V1alpha1CloudSecurityComplianceFrameworkStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudSecurityComplianceFramework";
    public const string KubeGroup = "cloudsecuritycompliance.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudsecuritycomplianceframeworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudsecuritycompliance.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudSecurityComplianceFramework";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudSecurityComplianceFrameworkSpec defines the desired state of CloudSecurityComplianceFramework</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudSecurityComplianceFrameworkSpec Spec { get; set; }

    /// <summary>CloudSecurityComplianceFrameworkStatus defines the config connector machine state of CloudSecurityComplianceFramework</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudSecurityComplianceFrameworkStatus? Status { get; set; }
}