#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apihub.cnrm.cloud.google.com;
/// <summary>ApiHubDeployment is the Schema for the ApiHubDeployment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApiHubDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ApiHubDeployment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApiHubDeploymentList";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiHubDeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ApiHubDeployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ApiHubDeployment> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecDeploymentTypeEnumValuesValues
{
    /// <summary>Optional. The detailed description of the allowed value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the allowed value.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Required. The ID of the allowed value.
    ///  * If provided, the same will be used. The service will throw an error if
    ///  the specified id is already used by another allowed value in the same
    ///  attribute resource.
    ///  * If not provided, a system generated id derived from the display name
    ///  will be used. In this case, the service will handle conflict resolution
    ///  by adding a system generated suffix in case of duplicates.
    /// 
    ///  This value should be 4-63 characters, and valid characters
    ///  are /[a-z][0-9]-/.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. When set to true, the allowed value cannot be updated or deleted by the user. It can only be true for System defined attributes.</summary>
    [JsonPropertyName("immutable")]
    public bool? Immutable { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecDeploymentTypeEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1ApiHubDeploymentSpecDeploymentTypeEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecDeploymentTypeJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecDeploymentTypeStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Required. The type of deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-deployment-type` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecDeploymentType
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1ApiHubDeploymentSpecDeploymentTypeEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1ApiHubDeploymentSpecDeploymentTypeJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1ApiHubDeploymentSpecDeploymentTypeStringValues? StringValues { get; set; }
}

/// <summary>Optional. The documentation of the deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecDocumentation
{
    /// <summary>Optional. The uri of the externally hosted documentation.</summary>
    [JsonPropertyName("externalURI")]
    public string? ExternalURI { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecEnvironmentEnumValuesValues
{
    /// <summary>Optional. The detailed description of the allowed value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the allowed value.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Required. The ID of the allowed value.
    ///  * If provided, the same will be used. The service will throw an error if
    ///  the specified id is already used by another allowed value in the same
    ///  attribute resource.
    ///  * If not provided, a system generated id derived from the display name
    ///  will be used. In this case, the service will handle conflict resolution
    ///  by adding a system generated suffix in case of duplicates.
    /// 
    ///  This value should be 4-63 characters, and valid characters
    ///  are /[a-z][0-9]-/.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. When set to true, the allowed value cannot be updated or deleted by the user. It can only be true for System defined attributes.</summary>
    [JsonPropertyName("immutable")]
    public bool? Immutable { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecEnvironmentEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1ApiHubDeploymentSpecEnvironmentEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecEnvironmentJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecEnvironmentStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The environment mapping to this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-environment` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecEnvironment
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1ApiHubDeploymentSpecEnvironmentEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1ApiHubDeploymentSpecEnvironmentJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1ApiHubDeploymentSpecEnvironmentStringValues? StringValues { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecProjectRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecSloEnumValuesValues
{
    /// <summary>Optional. The detailed description of the allowed value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the allowed value.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Required. The ID of the allowed value.
    ///  * If provided, the same will be used. The service will throw an error if
    ///  the specified id is already used by another allowed value in the same
    ///  attribute resource.
    ///  * If not provided, a system generated id derived from the display name
    ///  will be used. In this case, the service will handle conflict resolution
    ///  by adding a system generated suffix in case of duplicates.
    /// 
    ///  This value should be 4-63 characters, and valid characters
    ///  are /[a-z][0-9]-/.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. When set to true, the allowed value cannot be updated or deleted by the user. It can only be true for System defined attributes.</summary>
    [JsonPropertyName("immutable")]
    public bool? Immutable { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecSloEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1ApiHubDeploymentSpecSloEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecSloJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecSloStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The SLO for this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-slo` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpecSlo
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1ApiHubDeploymentSpecSloEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1ApiHubDeploymentSpecSloJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1ApiHubDeploymentSpecSloStringValues? StringValues { get; set; }
}

/// <summary>ApiHubDeploymentSpec defines the desired state of ApiHubDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentSpec
{
    /// <summary>Required. The type of deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-deployment-type` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
    [JsonPropertyName("deploymentType")]
    public required V1alpha1ApiHubDeploymentSpecDeploymentType DeploymentType { get; set; }

    /// <summary>Optional. The description of the deployment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the deployment.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Optional. The documentation of the deployment.</summary>
    [JsonPropertyName("documentation")]
    public V1alpha1ApiHubDeploymentSpecDocumentation? Documentation { get; set; }

    /// <summary>Required. The endpoints at which this deployment resource is listening for API requests. This could be a list of complete URIs, hostnames or an IP addresses.</summary>
    [JsonPropertyName("endpoints")]
    public required IList<string> Endpoints { get; set; }

    /// <summary>Optional. The environment mapping to this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-environment` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
    [JsonPropertyName("environment")]
    public V1alpha1ApiHubDeploymentSpecEnvironment? Environment { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ApiHubDeploymentSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ApiHubDeployment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. A URI to the runtime resource. This URI can be used to manage the resource. For example, if the runtime resource is of type APIGEE_PROXY, then this field will contain the URI to the management UI of the proxy.</summary>
    [JsonPropertyName("resourceURI")]
    public required string ResourceURI { get; set; }

    /// <summary>Optional. The SLO for this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-slo` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
    [JsonPropertyName("slo")]
    public V1alpha1ApiHubDeploymentSpecSlo? Slo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentStatusConditions
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
public partial class V1alpha1ApiHubDeploymentStatusObservedState
{
    /// <summary>Output only. The API versions linked to this deployment. Note: A particular deployment could be linked to multiple different API versions (of same or different APIs).</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>Output only. The time at which the deployment was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which the deployment was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ApiHubDeploymentStatus defines the config connector machine state of ApiHubDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApiHubDeploymentStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApiHubDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ApiHubDeployment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ApiHubDeploymentStatusObservedState? ObservedState { get; set; }
}

/// <summary>ApiHubDeployment is the Schema for the ApiHubDeployment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApiHubDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApiHubDeploymentSpec>, IStatus<V1alpha1ApiHubDeploymentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApiHubDeployment";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiHubDeployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApiHubDeploymentSpec defines the desired state of ApiHubDeployment</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ApiHubDeploymentSpec Spec { get; set; }

    /// <summary>ApiHubDeploymentStatus defines the config connector machine state of ApiHubDeployment</summary>
    [JsonPropertyName("status")]
    public V1alpha1ApiHubDeploymentStatus? Status { get; set; }
}