#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.contentwarehouse.cnrm.cloud.google.com;
/// <summary>ContentWarehouseSchema is the Schema for the ContentWarehouseSchema API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ContentWarehouseSchemaList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ContentWarehouseSchema>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContentWarehouseSchemaList";
    public const string KubeGroup = "contentwarehouse.cnrm.cloud.google.com";
    public const string KubePluralName = "contentwarehouseschemas";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contentwarehouse.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContentWarehouseSchemaList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ContentWarehouseSchema objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ContentWarehouseSchema> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaSpecProjectRef
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

/// <summary>Enum/categorical property.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaSpecPropertyDefinitionsEnumTypeOptions
{
    /// <summary>Required. List of possible enum values.</summary>
    [JsonPropertyName("possibleValues")]
    public required IList<string> PossibleValues { get; set; }

    /// <summary>Make sure the Enum property value provided in the document is in the possile value list during document creation. The validation check runs by default.</summary>
    [JsonPropertyName("validationCheckDisabled")]
    public bool? ValidationCheckDisabled { get; set; }
}

/// <summary>Nested structured data property.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaSpecPropertyDefinitionsPropertyTypeOptions
{
    /// <summary>Required. List of property definitions.</summary>
    [JsonPropertyName("propertyDefinitions")]
    public required JsonNode PropertyDefinitions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaSpecPropertyDefinitionsSchemaSources
{
    /// <summary>The schema name in the source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Doc AI processor type name.</summary>
    [JsonPropertyName("processorType")]
    public string? ProcessorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaSpecPropertyDefinitions
{
    /// <summary>Date time property. It is not supported by CMEK compliant deployment.</summary>
    [JsonPropertyName("dateTimeTypeOptions")]
    public JsonNode? DateTimeTypeOptions { get; set; }

    /// <summary>The display-name for the property, used for front-end.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Enum/categorical property.</summary>
    [JsonPropertyName("enumTypeOptions")]
    public V1alpha1ContentWarehouseSchemaSpecPropertyDefinitionsEnumTypeOptions? EnumTypeOptions { get; set; }

    /// <summary>Float property.</summary>
    [JsonPropertyName("floatTypeOptions")]
    public JsonNode? FloatTypeOptions { get; set; }

    /// <summary>Integer property.</summary>
    [JsonPropertyName("integerTypeOptions")]
    public JsonNode? IntegerTypeOptions { get; set; }

    /// <summary>Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked filterable.</summary>
    [JsonPropertyName("isFilterable")]
    public bool? IsFilterable { get; set; }

    /// <summary>Whether the property is user supplied metadata. This out-of-the box placeholder setting can be used to tag derived properties. Its value and interpretation logic should be implemented by API user.</summary>
    [JsonPropertyName("isMetadata")]
    public bool? IsMetadata { get; set; }

    /// <summary>Whether the property can have multiple values.</summary>
    [JsonPropertyName("isRepeatable")]
    public bool? IsRepeatable { get; set; }

    /// <summary>Whether the property is mandatory. Default is &apos;false&apos;, i.e. populating property value can be skipped. If &apos;true&apos; then user must populate the value for this property.</summary>
    [JsonPropertyName("isRequired")]
    public bool? IsRequired { get; set; }

    /// <summary>Indicates that the property should be included in a global search.</summary>
    [JsonPropertyName("isSearchable")]
    public bool? IsSearchable { get; set; }

    /// <summary>Map property.</summary>
    [JsonPropertyName("mapTypeOptions")]
    public JsonNode? MapTypeOptions { get; set; }

    /// <summary>Required. The name of the metadata property. Must be unique within a document schema and is case insensitive. Names must be non-blank, start with a letter, and can contain alphanumeric characters and: /, :, -, _, and .</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Nested structured data property.</summary>
    [JsonPropertyName("propertyTypeOptions")]
    public V1alpha1ContentWarehouseSchemaSpecPropertyDefinitionsPropertyTypeOptions? PropertyTypeOptions { get; set; }

    /// <summary>The retrieval importance of the property during search.</summary>
    [JsonPropertyName("retrievalImportance")]
    public string? RetrievalImportance { get; set; }

    /// <summary>The mapping information between this property to another schema source.</summary>
    [JsonPropertyName("schemaSources")]
    public IList<V1alpha1ContentWarehouseSchemaSpecPropertyDefinitionsSchemaSources>? SchemaSources { get; set; }

    /// <summary>Text/string property.</summary>
    [JsonPropertyName("textTypeOptions")]
    public JsonNode? TextTypeOptions { get; set; }

    /// <summary>Timestamp property. It is not supported by CMEK compliant deployment.</summary>
    [JsonPropertyName("timestampTypeOptions")]
    public JsonNode? TimestampTypeOptions { get; set; }
}

/// <summary>ContentWarehouseSchemaSpec defines the desired state of ContentWarehouseSchema</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaSpec
{
    /// <summary>Schema description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Name of the schema given by the user. Must be unique per project.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Document Type, true refers the document is a folder, otherwise it is a typical document.</summary>
    [JsonPropertyName("documentIsFolder")]
    public bool? DocumentIsFolder { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ContentWarehouseSchemaSpecProjectRef ProjectRef { get; set; }

    /// <summary>Document details.</summary>
    [JsonPropertyName("propertyDefinitions")]
    public IList<V1alpha1ContentWarehouseSchemaSpecPropertyDefinitions>? PropertyDefinitions { get; set; }

    /// <summary>The ContentWarehouseSchema name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaStatusConditions
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

/// <summary>ContentWarehouseSchemaStatus defines the config connector machine state of ContentWarehouseSchema</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseSchemaStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ContentWarehouseSchemaStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ContentWarehouseSchema resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public JsonNode? ObservedState { get; set; }
}

/// <summary>ContentWarehouseSchema is the Schema for the ContentWarehouseSchema API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ContentWarehouseSchema : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ContentWarehouseSchemaSpec>, IStatus<V1alpha1ContentWarehouseSchemaStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContentWarehouseSchema";
    public const string KubeGroup = "contentwarehouse.cnrm.cloud.google.com";
    public const string KubePluralName = "contentwarehouseschemas";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contentwarehouse.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContentWarehouseSchema";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContentWarehouseSchemaSpec defines the desired state of ContentWarehouseSchema</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ContentWarehouseSchemaSpec Spec { get; set; }

    /// <summary>ContentWarehouseSchemaStatus defines the config connector machine state of ContentWarehouseSchema</summary>
    [JsonPropertyName("status")]
    public V1alpha1ContentWarehouseSchemaStatus? Status { get; set; }
}