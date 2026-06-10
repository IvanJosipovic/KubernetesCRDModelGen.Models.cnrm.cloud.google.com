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
/// <summary>APIHubPlugin is the Schema for the APIHubPlugin API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubPluginList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIHubPlugin>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubPluginList";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubplugins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubPluginList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIHubPlugin objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIHubPlugin> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginSpecProjectRef
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
public partial class V1alpha1APIHubPluginSpecTypeEnumValuesValues
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
public partial class V1alpha1APIHubPluginSpecTypeEnumValues
{
    /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1APIHubPluginSpecTypeEnumValuesValues>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginSpecTypeJsonValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginSpecTypeStringValues
{
    /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Required. The type of the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginSpecType
{
    /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1APIHubPluginSpecTypeEnumValues? EnumValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
    [JsonPropertyName("jsonValues")]
    public V1alpha1APIHubPluginSpecTypeJsonValues? JsonValues { get; set; }

    /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
    [JsonPropertyName("stringValues")]
    public V1alpha1APIHubPluginSpecTypeStringValues? StringValues { get; set; }
}

/// <summary>APIHubPluginSpec defines the desired state of APIHubPlugin</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginSpec
{
    /// <summary>Optional. The plugin description. Max length is 2000 characters (Unicode code points).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the plugin. Max length is 50 characters (Unicode code points).</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1APIHubPluginSpecProjectRef ProjectRef { get; set; }

    /// <summary>The APIHubPlugin name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The type of the API.</summary>
    [JsonPropertyName("type")]
    public required V1alpha1APIHubPluginSpecType Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginStatusConditions
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

/// <summary>Required. The type of the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginStatusObservedStateType
{
    /// <summary>Output only. The name of the attribute. Format: projects/{project}/locations/{location}/attributes/{attribute}</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginStatusObservedState
{
    /// <summary>Output only. Represents the state of the plugin.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Required. The type of the API.</summary>
    [JsonPropertyName("type")]
    public V1alpha1APIHubPluginStatusObservedStateType? Type { get; set; }
}

/// <summary>APIHubPluginStatus defines the config connector machine state of APIHubPlugin</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubPluginStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIHubPluginStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIHubPlugin resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIHubPluginStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIHubPlugin is the Schema for the APIHubPlugin API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubPlugin : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIHubPluginSpec>, IStatus<V1alpha1APIHubPluginStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubPlugin";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubplugins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubPlugin";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIHubPluginSpec defines the desired state of APIHubPlugin</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1APIHubPluginSpec Spec { get; set; }

    /// <summary>APIHubPluginStatus defines the config connector machine state of APIHubPlugin</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIHubPluginStatus? Status { get; set; }
}