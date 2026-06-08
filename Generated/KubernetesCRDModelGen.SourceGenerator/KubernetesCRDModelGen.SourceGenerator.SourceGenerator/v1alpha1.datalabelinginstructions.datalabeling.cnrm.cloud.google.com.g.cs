#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalabeling.cnrm.cloud.google.com;
/// <summary>DataLabelingInstruction is the Schema for the DataLabelingInstruction API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingInstructionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataLabelingInstruction>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingInstructionList";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelinginstructions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingInstructionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataLabelingInstruction objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataLabelingInstruction> Items { get; set; }
}

/// <summary>
/// Deprecated: this instruction format is not supported any more.
///  Instruction from a CSV file, such as for classification task.
///  The CSV file should have exact two columns, in the following format:
/// 
///  * The first column is labeled data, such as an image reference, text.
///  * The second column is comma separated labels associated with data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingInstructionSpecCsvInstruction
{
    /// <summary>CSV file for the instruction. Only gcs path is allowed.</summary>
    [JsonPropertyName("gcsFileURI")]
    public required string GcsFileURI { get; set; }
}

/// <summary>Required. The data type of this instruction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1DataLabelingInstructionSpecDataTypeEnum>))]
public enum V1alpha1DataLabelingInstructionSpecDataTypeEnum
{
    [EnumMember(Value = "DATA_TYPE_UNSPECIFIED"), JsonStringEnumMemberName("DATA_TYPE_UNSPECIFIED")]
    DATATYPEUNSPECIFIED,
    [EnumMember(Value = "IMAGE"), JsonStringEnumMemberName("IMAGE")]
    IMAGE,
    [EnumMember(Value = "VIDEO"), JsonStringEnumMemberName("VIDEO")]
    VIDEO,
    [EnumMember(Value = "TEXT"), JsonStringEnumMemberName("TEXT")]
    TEXT,
    [EnumMember(Value = "GENERAL_DATA"), JsonStringEnumMemberName("GENERAL_DATA")]
    GENERALDATA
}

/// <summary>Instruction from a PDF document. The PDF should be in a Cloud Storage bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingInstructionSpecPdfInstruction
{
    /// <summary>PDF file for the instruction. Only gcs path is allowed.</summary>
    [JsonPropertyName("gcsFileURI")]
    public required string GcsFileURI { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingInstructionSpecProjectRef
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

/// <summary>DataLabelingInstructionSpec defines the desired state of DataLabelingInstruction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingInstructionSpec
{
    /// <summary>
    /// Deprecated: this instruction format is not supported any more.
    ///  Instruction from a CSV file, such as for classification task.
    ///  The CSV file should have exact two columns, in the following format:
    /// 
    ///  * The first column is labeled data, such as an image reference, text.
    ///  * The second column is comma separated labels associated with data.
    /// </summary>
    [JsonPropertyName("csvInstruction")]
    public V1alpha1DataLabelingInstructionSpecCsvInstruction? CsvInstruction { get; set; }

    /// <summary>Required. The data type of this instruction.</summary>
    [JsonPropertyName("dataType")]
    public required V1alpha1DataLabelingInstructionSpecDataTypeEnum DataType { get; set; }

    /// <summary>Optional. User-provided description of the instruction. The description can be up to 10000 characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the instruction. Maximum of 64 characters.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Instruction from a PDF document. The PDF should be in a Cloud Storage bucket.</summary>
    [JsonPropertyName("pdfInstruction")]
    public V1alpha1DataLabelingInstructionSpecPdfInstruction? PdfInstruction { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataLabelingInstructionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataLabelingInstruction name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingInstructionStatusConditions
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
public partial class V1alpha1DataLabelingInstructionStatusObservedState
{
    /// <summary>Output only. The names of any related resources that are blocking changes to the instruction.</summary>
    [JsonPropertyName("blockingResources")]
    public IList<string>? BlockingResources { get; set; }

    /// <summary>Output only. Creation time of instruction.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Last update time of instruction.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataLabelingInstructionStatus defines the config connector machine state of DataLabelingInstruction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingInstructionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataLabelingInstructionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataLabelingInstruction resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataLabelingInstructionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataLabelingInstruction is the Schema for the DataLabelingInstruction API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingInstruction : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataLabelingInstructionSpec>, IStatus<V1alpha1DataLabelingInstructionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingInstruction";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelinginstructions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingInstruction";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLabelingInstructionSpec defines the desired state of DataLabelingInstruction</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataLabelingInstructionSpec Spec { get; set; }

    /// <summary>DataLabelingInstructionStatus defines the config connector machine state of DataLabelingInstruction</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataLabelingInstructionStatus? Status { get; set; }
}