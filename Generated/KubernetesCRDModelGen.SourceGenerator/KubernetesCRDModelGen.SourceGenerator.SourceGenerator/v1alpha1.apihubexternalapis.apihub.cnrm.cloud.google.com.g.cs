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
/// <summary>APIHubExternalAPI is the Schema for the APIHubExternalAPI API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubExternalAPIList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIHubExternalAPI>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubExternalAPIList";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubexternalapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubExternalAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIHubExternalAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIHubExternalAPI> Items { get; set; }
}

/// <summary>Reference to the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecAttributeRefsAttributeRef
{
    /// <summary>The `id` of a `APIHubAttribute` resource, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecAttributeRefsValuesEnumValuesValues
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
public partial class V1alpha1APIHubExternalAPISpecAttributeRefsValuesEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1APIHubExternalAPISpecAttributeRefsValuesEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecAttributeRefsValuesJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecAttributeRefsValuesStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The value of the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecAttributeRefsValues
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1APIHubExternalAPISpecAttributeRefsValuesEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1APIHubExternalAPISpecAttributeRefsValuesJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1APIHubExternalAPISpecAttributeRefsValuesStringValues? StringValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecAttributeRefs
{
    /// <summary>Reference to the attribute.</summary>
    [JsonPropertyName("attributeRef")]
    public required V1alpha1APIHubExternalAPISpecAttributeRefsAttributeRef AttributeRef { get; set; }

    /// <summary>The value of the attribute.</summary>
    [JsonPropertyName("values")]
    public required V1alpha1APIHubExternalAPISpecAttributeRefsValues Values { get; set; }
}

/// <summary>Optional. Documentation of the external API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecDocumentation
{
    /// <summary>Optional. The uri of the externally hosted documentation.</summary>
    [JsonPropertyName("externalURI")]
    public string? ExternalURI { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpecProjectRef
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

/// <summary>APIHubExternalAPISpec defines the desired state of APIHubExternalAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPISpec
{
    /// <summary>Optional. The list of user defined attributes associated with the Version resource. The key is the attribute name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`. The value is the attribute values associated with the resource.</summary>
    [JsonPropertyName("attributeRefs")]
    public IList<V1alpha1APIHubExternalAPISpecAttributeRefs>? AttributeRefs { get; set; }

    /// <summary>Optional. Description of the external API. Max length is 2000 characters (Unicode Code Points).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Display name of the external API. Max length is 63 characters (Unicode Code Points).</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Optional. Documentation of the external API.</summary>
    [JsonPropertyName("documentation")]
    public V1alpha1APIHubExternalAPISpecDocumentation? Documentation { get; set; }

    /// <summary>Optional. List of endpoints on which this API is accessible.</summary>
    [JsonPropertyName("endpoints")]
    public IList<string>? Endpoints { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. List of paths served by this API.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1APIHubExternalAPISpecProjectRef ProjectRef { get; set; }

    /// <summary>The APIHubExternalAPI name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPIStatusConditions
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
public partial class V1alpha1APIHubExternalAPIStatusObservedState
{
    /// <summary>Output only. Creation timestamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Last update timestamp.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>APIHubExternalAPIStatus defines the config connector machine state of APIHubExternalAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubExternalAPIStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIHubExternalAPIStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIHubExternalAPI resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIHubExternalAPIStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIHubExternalAPI is the Schema for the APIHubExternalAPI API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubExternalAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIHubExternalAPISpec>, IStatus<V1alpha1APIHubExternalAPIStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubExternalAPI";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubexternalapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubExternalAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIHubExternalAPISpec defines the desired state of APIHubExternalAPI</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1APIHubExternalAPISpec Spec { get; set; }

    /// <summary>APIHubExternalAPIStatus defines the config connector machine state of APIHubExternalAPI</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIHubExternalAPIStatus? Status { get; set; }
}