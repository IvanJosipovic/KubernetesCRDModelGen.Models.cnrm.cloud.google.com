#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataplex.cnrm.cloud.google.com;
/// <summary>DataplexAspectType is the Schema for the DataplexAspectType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexAspectTypeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexAspectType>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexAspectTypeList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexaspecttypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataplexAspectTypeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataplexAspectType objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataplexAspectType> Items { get; set; }
}

/// <summary>Immutable. Defines the Authorization for this type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpecAuthorization
{
    /// <summary>Immutable. The IAM permission grantable on the EntryGroup to allow access to instantiate Aspects of Dataplex owned AspectTypes, only settable for Dataplex owned Types.</summary>
    [JsonPropertyName("alternateUsePermission")]
    public string? AlternateUsePermission { get; set; }
}

/// <summary>Optional. Specifies annotations on this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpecMetadataTemplateAnnotations
{
    /// <summary>Optional. Marks a field as deprecated. You can include a deprecation message.</summary>
    [JsonPropertyName("deprecated")]
    public string? Deprecated { get; set; }

    /// <summary>Optional. Description for a field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Display name for a field.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Display order for a field. You can use this to reorder where a field is rendered.</summary>
    [JsonPropertyName("displayOrder")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Optional. You can use String Type annotations to specify special
    ///  meaning to string fields. The following values are supported:
    /// 
    ///  * richText: The field must be interpreted as a rich text field.
    ///  * url: A fully qualified URL link.
    ///  * resource: A service qualified resource reference.
    /// </summary>
    [JsonPropertyName("stringType")]
    public string? StringType { get; set; }

    /// <summary>Optional. Suggested hints for string fields. You can use them to suggest values to users through console.</summary>
    [JsonPropertyName("stringValues")]
    public IList<string>? StringValues { get; set; }
}

/// <summary>Optional. Specifies the constraints on this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpecMetadataTemplateConstraints
{
    /// <summary>Optional. Marks this field as optional or required.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpecMetadataTemplateEnumValues
{
    /// <summary>Optional. You can set this message if you need to deprecate an enum value.</summary>
    [JsonPropertyName("deprecated")]
    public string? Deprecated { get; set; }

    /// <summary>Required. Index for the enum value. It can&apos;t be modified.</summary>
    [JsonPropertyName("index")]
    public int? Index { get; set; }

    /// <summary>Required. Name of the enumvalue. This is the actual value that the aspect can contain.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Required. MetadataTemplate of the aspect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpecMetadataTemplate
{
    /// <summary>Optional. Specifies annotations on this field.</summary>
    [JsonPropertyName("annotations")]
    public V1alpha1DataplexAspectTypeSpecMetadataTemplateAnnotations? Annotations { get; set; }

    /// <summary>Optional. If the type is array, set array_items. array_items can refer to a primitive field or a complex (record only) field. To specify a primitive field, you only need to set name and type in the nested MetadataTemplate. The recommended value for the name field is item, as this isn&apos;t used in the actual payload.</summary>
    [JsonPropertyName("arrayItems")]
    public JsonNode? ArrayItems { get; set; }

    /// <summary>Optional. Specifies the constraints on this field.</summary>
    [JsonPropertyName("constraints")]
    public V1alpha1DataplexAspectTypeSpecMetadataTemplateConstraints? Constraints { get; set; }

    /// <summary>Optional. The list of values for an enum type. You must define it if the type is enum.</summary>
    [JsonPropertyName("enumValues")]
    public IList<V1alpha1DataplexAspectTypeSpecMetadataTemplateEnumValues>? EnumValues { get; set; }

    /// <summary>Optional. Index is used to encode Template messages. The value of index can range between 1 and 2,147,483,647. Index must be unique within all fields in a Template. (Nested Templates can reuse indexes). Once a Template is defined, the index cannot be changed, because it identifies the field in the actual storage format. Index is a mandatory field, but it is optional for top level fields, and map/array &quot;values&quot; definitions.</summary>
    [JsonPropertyName("index")]
    public int? Index { get; set; }

    /// <summary>Optional. If the type is map, set map_items. map_items can refer to a primitive field or a complex (record only) field. To specify a primitive field, you only need to set name and type in the nested MetadataTemplate. The recommended value for the name field is item, as this isn&apos;t used in the actual payload.</summary>
    [JsonPropertyName("mapItems")]
    public JsonNode? MapItems { get; set; }

    /// <summary>Required. The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Field definition. You must specify it if the type is record. It defines the nested fields.</summary>
    [JsonPropertyName("recordFields")]
    public IList<JsonNode>? RecordFields { get; set; }

    /// <summary>
    /// Required. The datatype of this field. The following values are supported:
    /// 
    ///  Primitive types:
    /// 
    ///  * string
    ///  * integer
    ///  * boolean
    ///  * double
    ///  * datetime. Must be of the format RFC3339 UTC &quot;Zulu&quot; (Examples:
    ///  &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;).
    /// 
    ///  Complex types:
    /// 
    ///  * enum
    ///  * array
    ///  * map
    ///  * record
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Optional. You can use type id if this definition of the field needs to be reused later. The type id must be unique across the entire template. You can only specify it if the field type is record.</summary>
    [JsonPropertyName("typeID")]
    public string? TypeID { get; set; }

    /// <summary>Optional. A reference to another field definition (not an inline definition). The value must be equal to the value of an id field defined elsewhere in the MetadataTemplate. Only fields with record type can refer to other fields.</summary>
    [JsonPropertyName("typeRef")]
    public string? TypeRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpecProjectRef
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

/// <summary>DataplexAspectTypeSpec defines the desired state of DataplexAspectType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeSpec
{
    /// <summary>Immutable. Defines the Authorization for this type.</summary>
    [JsonPropertyName("authorization")]
    public V1alpha1DataplexAspectTypeSpecAuthorization? Authorization { get; set; }

    /// <summary>Optional. Description of the AspectType.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The location that this resource belongs to.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Required. MetadataTemplate of the aspect.</summary>
    [JsonPropertyName("metadataTemplate")]
    public V1alpha1DataplexAspectTypeSpecMetadataTemplate? MetadataTemplate { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataplexAspectTypeSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataplexAspectType name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeStatusConditions
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
public partial class V1alpha1DataplexAspectTypeStatusObservedState
{
    /// <summary>Output only. The time when the AspectType was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. This checksum is computed by the service, and might be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Denotes the transfer status of the Aspect Type. It is unspecified for Aspect Types created from Dataplex API.</summary>
    [JsonPropertyName("transferStatus")]
    public string? TransferStatus { get; set; }

    /// <summary>Output only. System generated globally unique ID for the AspectType. If you delete and recreate the AspectType with the same name, then this ID will be different.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the AspectType was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataplexAspectTypeStatus defines the config connector machine state of DataplexAspectType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexAspectTypeStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexAspectTypeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexAspectType resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexAspectTypeStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataplexAspectType is the Schema for the DataplexAspectType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexAspectType : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexAspectTypeSpec>, IStatus<V1alpha1DataplexAspectTypeStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexAspectType";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexaspecttypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataplexAspectType";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexAspectTypeSpec defines the desired state of DataplexAspectType</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataplexAspectTypeSpec Spec { get; set; }

    /// <summary>DataplexAspectTypeStatus defines the config connector machine state of DataplexAspectType</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexAspectTypeStatus? Status { get; set; }
}