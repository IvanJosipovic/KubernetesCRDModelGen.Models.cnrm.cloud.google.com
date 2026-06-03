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
/// <summary>APIHubAPI is the Schema for the APIHubAPI API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubAPIList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIHubAPI>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubAPIList";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIHubAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIHubAPI> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiFunctionalRequirementsEnumValuesValues
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
public partial class V1alpha1APIHubAPISpecApiFunctionalRequirementsEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1APIHubAPISpecApiFunctionalRequirementsEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiFunctionalRequirementsJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiFunctionalRequirementsStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The API functional requirements of the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiFunctionalRequirements
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1APIHubAPISpecApiFunctionalRequirementsEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1APIHubAPISpecApiFunctionalRequirementsJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1APIHubAPISpecApiFunctionalRequirementsStringValues? StringValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiRequirementsEnumValuesValues
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
public partial class V1alpha1APIHubAPISpecApiRequirementsEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1APIHubAPISpecApiRequirementsEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiRequirementsJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiRequirementsStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The API requirements of the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiRequirements
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1APIHubAPISpecApiRequirementsEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1APIHubAPISpecApiRequirementsJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1APIHubAPISpecApiRequirementsStringValues? StringValues { get; set; }
}

/// <summary>Optional. The style of the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-api-style`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiStyleRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
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
public partial class V1alpha1APIHubAPISpecApiTechnicalRequirementsEnumValuesValues
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
public partial class V1alpha1APIHubAPISpecApiTechnicalRequirementsEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1APIHubAPISpecApiTechnicalRequirementsEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiTechnicalRequirementsJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiTechnicalRequirementsStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The API technical requirements of the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecApiTechnicalRequirements
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1APIHubAPISpecApiTechnicalRequirementsEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1APIHubAPISpecApiTechnicalRequirementsJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1APIHubAPISpecApiTechnicalRequirementsStringValues? StringValues { get; set; }
}

/// <summary>Reference to the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecAttributeRefsAttributeRef
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
public partial class V1alpha1APIHubAPISpecAttributeRefsValuesEnumValuesValues
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
public partial class V1alpha1APIHubAPISpecAttributeRefsValuesEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1APIHubAPISpecAttributeRefsValuesEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecAttributeRefsValuesJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecAttributeRefsValuesStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The value of the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecAttributeRefsValues
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1APIHubAPISpecAttributeRefsValuesEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1APIHubAPISpecAttributeRefsValuesJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1APIHubAPISpecAttributeRefsValuesStringValues? StringValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecAttributeRefs
{
    /// <summary>Reference to the attribute.</summary>
    [JsonPropertyName("attributeRef")]
    public required V1alpha1APIHubAPISpecAttributeRefsAttributeRef AttributeRef { get; set; }

    /// <summary>The value of the attribute.</summary>
    [JsonPropertyName("values")]
    public required V1alpha1APIHubAPISpecAttributeRefsValues Values { get; set; }
}

/// <summary>Optional. The business unit owning the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-business-unit`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecBusinessUnitRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The documentation for the API resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecDocumentation
{
    /// <summary>Optional. The uri of the externally hosted documentation.</summary>
    [JsonPropertyName("externalURI")]
    public string? ExternalURI { get; set; }
}

/// <summary>Optional. The maturity level of the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-maturity-level`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecMaturityLevelRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Owner details for the API resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecOwner
{
    /// <summary>Optional. The name of the owner.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. The email of the owner.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecProjectRef
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

/// <summary>Optional. The selected version for an API resource. This can be used when special handling is needed on client side for particular version of the API. Format is `projects/{project}/locations/{location}/apis/{api}/versions/{version}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecSelectedVersionRef
{
    /// <summary>The `id` of a `APIHubVersion` resource, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The target users for the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-target-user`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecTargetUserRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The team owning the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-team`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpecTeamRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>APIHubAPISpec defines the desired state of APIHubAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPISpec
{
    /// <summary>Optional. The API functional requirements of the API.</summary>
    [JsonPropertyName("apiFunctionalRequirements")]
    public V1alpha1APIHubAPISpecApiFunctionalRequirements? ApiFunctionalRequirements { get; set; }

    /// <summary>Optional. The API requirements of the API.</summary>
    [JsonPropertyName("apiRequirements")]
    public V1alpha1APIHubAPISpecApiRequirements? ApiRequirements { get; set; }

    /// <summary>Optional. The style of the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-api-style`</summary>
    [JsonPropertyName("apiStyleRef")]
    public V1alpha1APIHubAPISpecApiStyleRef? ApiStyleRef { get; set; }

    /// <summary>Optional. The API technical requirements of the API.</summary>
    [JsonPropertyName("apiTechnicalRequirements")]
    public V1alpha1APIHubAPISpecApiTechnicalRequirements? ApiTechnicalRequirements { get; set; }

    /// <summary>Optional. The list of user defined attributes associated with the API resource. The key is the attribute name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`.</summary>
    [JsonPropertyName("attributeRefs")]
    public IList<V1alpha1APIHubAPISpecAttributeRefs>? AttributeRefs { get; set; }

    /// <summary>Optional. The business unit owning the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-business-unit`</summary>
    [JsonPropertyName("businessUnitRef")]
    public V1alpha1APIHubAPISpecBusinessUnitRef? BusinessUnitRef { get; set; }

    /// <summary>Optional. The description of the API resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the API resource.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Optional. The documentation for the API resource.</summary>
    [JsonPropertyName("documentation")]
    public V1alpha1APIHubAPISpecDocumentation? Documentation { get; set; }

    /// <summary>Optional. The base64-encoded fingerprint of the API resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. The maturity level of the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-maturity-level`</summary>
    [JsonPropertyName("maturityLevelRef")]
    public V1alpha1APIHubAPISpecMaturityLevelRef? MaturityLevelRef { get; set; }

    /// <summary>Optional. Owner details for the API resource.</summary>
    [JsonPropertyName("owner")]
    public V1alpha1APIHubAPISpecOwner? Owner { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1APIHubAPISpecProjectRef ProjectRef { get; set; }

    /// <summary>The APIHubAPI name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The selected version for an API resource. This can be used when special handling is needed on client side for particular version of the API. Format is `projects/{project}/locations/{location}/apis/{api}/versions/{version}`</summary>
    [JsonPropertyName("selectedVersionRef")]
    public V1alpha1APIHubAPISpecSelectedVersionRef? SelectedVersionRef { get; set; }

    /// <summary>Optional. The target users for the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-target-user`</summary>
    [JsonPropertyName("targetUserRef")]
    public V1alpha1APIHubAPISpecTargetUserRef? TargetUserRef { get; set; }

    /// <summary>Optional. The team owning the API. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-team`</summary>
    [JsonPropertyName("teamRef")]
    public V1alpha1APIHubAPISpecTeamRef? TeamRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPIStatusConditions
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
public partial class V1alpha1APIHubAPIStatusObservedStateSourceMetadata
{
    /// <summary>Output only. The time at which the resource was created at the source.</summary>
    [JsonPropertyName("originalResourceCreateTime")]
    public string? OriginalResourceCreateTime { get; set; }

    /// <summary>Output only. The unique identifier of the resource at the source.</summary>
    [JsonPropertyName("originalResourceID")]
    public string? OriginalResourceID { get; set; }

    /// <summary>Output only. The time at which the resource was last updated at the source.</summary>
    [JsonPropertyName("originalResourceUpdateTime")]
    public string? OriginalResourceUpdateTime { get; set; }

    /// <summary>Output only. The type of the source.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPIStatusObservedState
{
    /// <summary>Output only. The time at which the API resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The metadata describing the source of the API resource.</summary>
    [JsonPropertyName("sourceMetadata")]
    public IList<V1alpha1APIHubAPIStatusObservedStateSourceMetadata>? SourceMetadata { get; set; }

    /// <summary>Output only. The time at which the API resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The list of versions present in an API resource. Note: An API resource can be associated with more than 1 version. Format is `projects/{project}/locations/{location}/apis/{api}/versions/{version}`</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

/// <summary>APIHubAPIStatus defines the config connector machine state of APIHubAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubAPIStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIHubAPIStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIHubAPI resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIHubAPIStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIHubAPI is the Schema for the APIHubAPI API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIHubAPISpec>, IStatus<V1alpha1APIHubAPIStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubAPI";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIHubAPISpec defines the desired state of APIHubAPI</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1APIHubAPISpec Spec { get; set; }

    /// <summary>APIHubAPIStatus defines the config connector machine state of APIHubAPI</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIHubAPIStatus? Status { get; set; }
}