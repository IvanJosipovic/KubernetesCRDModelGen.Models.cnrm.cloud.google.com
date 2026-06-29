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
/// <summary>DataplexMetadataJob is the Schema for the DataplexMetadataJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexMetadataJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexMetadataJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexMetadataJobList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexmetadatajobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataplexMetadataJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataplexMetadataJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataplexMetadataJob> Items { get; set; }
}

/// <summary>AspectTypeRef is a reference to a DataplexAspectType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecExportSpecScopeAspectTypeRefs
{
    /// <summary>A reference to an externally managed DataplexAspectType resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/aspectTypes/{{aspecttypeID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexAspectType resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexAspectType resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EntryGroupRef is a reference to a DataplexEntryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecExportSpecScopeEntryGroupRefs
{
    /// <summary>A reference to an externally managed DataplexEntryGroup resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/entryGroups/{{entrygroupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexEntryGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexEntryGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EntryTypeRef is a reference to a DataplexEntryType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecExportSpecScopeEntryTypeRefs
{
    /// <summary>A reference to an externally managed DataplexEntryType resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/entryTypes/{{entrytypeID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexEntryType resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexEntryType resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecExportSpecScopeProjectRefs
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

/// <summary>Required. The scope of the export job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecExportSpecScope
{
    /// <summary>Optional. The aspect types that are in scope for the export job.</summary>
    [JsonPropertyName("aspectTypeRefs")]
    public IList<V1alpha1DataplexMetadataJobSpecExportSpecScopeAspectTypeRefs>? AspectTypeRefs { get; set; }

    /// <summary>Optional. The entry groups whose metadata you want to export.</summary>
    [JsonPropertyName("entryGroupRefs")]
    public IList<V1alpha1DataplexMetadataJobSpecExportSpecScopeEntryGroupRefs>? EntryGroupRefs { get; set; }

    /// <summary>Optional. The entry types that are in scope for the export job.</summary>
    [JsonPropertyName("entryTypeRefs")]
    public IList<V1alpha1DataplexMetadataJobSpecExportSpecScopeEntryTypeRefs>? EntryTypeRefs { get; set; }

    /// <summary>Optional. Whether the metadata export job is an organization-level export job.</summary>
    [JsonPropertyName("organizationLevel")]
    public bool? OrganizationLevel { get; set; }

    /// <summary>Optional. The projects whose metadata you want to export.</summary>
    [JsonPropertyName("projectRefs")]
    public IList<V1alpha1DataplexMetadataJobSpecExportSpecScopeProjectRefs>? ProjectRefs { get; set; }
}

/// <summary>Export job specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecExportSpec
{
    /// <summary>Required. The root path of the Cloud Storage bucket to export the metadata to, in the format `gs://{bucket}/`.</summary>
    [JsonPropertyName("outputPath")]
    public required string OutputPath { get; set; }

    /// <summary>Required. The scope of the export job.</summary>
    [JsonPropertyName("scope")]
    public required V1alpha1DataplexMetadataJobSpecExportSpecScope Scope { get; set; }
}

/// <summary>AspectTypeRef is a reference to a DataplexAspectType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecImportSpecScopeAspectTypeRefs
{
    /// <summary>A reference to an externally managed DataplexAspectType resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/aspectTypes/{{aspecttypeID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexAspectType resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexAspectType resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EntryGroupRef is a reference to a DataplexEntryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecImportSpecScopeEntryGroupRefs
{
    /// <summary>A reference to an externally managed DataplexEntryGroup resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/entryGroups/{{entrygroupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexEntryGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexEntryGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EntryTypeRef is a reference to a DataplexEntryType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecImportSpecScopeEntryTypeRefs
{
    /// <summary>A reference to an externally managed DataplexEntryType resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/entryTypes/{{entrytypeID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexEntryType resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexEntryType resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. A boundary on the scope of impact that the metadata import job can have.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecImportSpecScope
{
    /// <summary>Optional. The aspect types that are in scope for the import job. The job modifies only the aspects that belong to these aspect types.</summary>
    [JsonPropertyName("aspectTypeRefs")]
    public IList<V1alpha1DataplexMetadataJobSpecImportSpecScopeAspectTypeRefs>? AspectTypeRefs { get; set; }

    /// <summary>Required. The entry group that is in scope for the import job. Must contain exactly one element. The entry group and the job must be in the same location.</summary>
    [JsonPropertyName("entryGroupRefs")]
    public required IList<V1alpha1DataplexMetadataJobSpecImportSpecScopeEntryGroupRefs> EntryGroupRefs { get; set; }

    /// <summary>Required. The entry types that are in scope for the import job. The job modifies only the entries and aspects that belong to these entry types.</summary>
    [JsonPropertyName("entryTypeRefs")]
    public required IList<V1alpha1DataplexMetadataJobSpecImportSpecScopeEntryTypeRefs> EntryTypeRefs { get; set; }
}

/// <summary>Import job specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecImportSpec
{
    /// <summary>Required. The sync mode for aspects.</summary>
    [JsonPropertyName("aspectSyncMode")]
    public required string AspectSyncMode { get; set; }

    /// <summary>Required. The sync mode for entries.</summary>
    [JsonPropertyName("entrySyncMode")]
    public required string EntrySyncMode { get; set; }

    /// <summary>Optional. The level of logs to write to Cloud Logging for this job.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Required. A boundary on the scope of impact that the metadata import job can have.</summary>
    [JsonPropertyName("scope")]
    public required V1alpha1DataplexMetadataJobSpecImportSpecScope Scope { get; set; }

    /// <summary>Optional. The time when the process that created the metadata import files began.</summary>
    [JsonPropertyName("sourceCreateTime")]
    public string? SourceCreateTime { get; set; }

    /// <summary>Optional. The URI of a Cloud Storage bucket or folder (beginning with `gs://` and ending with `/`) that contains the metadata import files for this job.</summary>
    [JsonPropertyName("sourceStorageURI")]
    public string? SourceStorageURI { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpecProjectRef
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

/// <summary>DataplexMetadataJobSpec defines the desired state of DataplexMetadataJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobSpec
{
    /// <summary>Export job specification.</summary>
    [JsonPropertyName("exportSpec")]
    public V1alpha1DataplexMetadataJobSpecExportSpec? ExportSpec { get; set; }

    /// <summary>Import job specification.</summary>
    [JsonPropertyName("importSpec")]
    public V1alpha1DataplexMetadataJobSpecImportSpec? ImportSpec { get; set; }

    /// <summary>Optional. User-defined labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataplexMetadataJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataplexMetadataJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Metadata job type.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobStatusConditions
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

/// <summary>Output only. Results from the export job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobStatusObservedStateExportResult
{
    /// <summary>Output only. The error message if the metadata export job failed.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Output only. The number of entries that were exported.</summary>
    [JsonPropertyName("exportedEntries")]
    public long? ExportedEntries { get; set; }
}

/// <summary>Output only. Results from the import job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobStatusObservedStateImportResult
{
    /// <summary>Output only. The total number of entries that were created.</summary>
    [JsonPropertyName("createdEntries")]
    public long? CreatedEntries { get; set; }

    /// <summary>Output only. The total number of entries that were deleted.</summary>
    [JsonPropertyName("deletedEntries")]
    public long? DeletedEntries { get; set; }

    /// <summary>Output only. The total number of entries that were recreated.</summary>
    [JsonPropertyName("recreatedEntries")]
    public long? RecreatedEntries { get; set; }

    /// <summary>Output only. The total number of entries that were unchanged.</summary>
    [JsonPropertyName("unchangedEntries")]
    public long? UnchangedEntries { get; set; }

    /// <summary>Output only. The time when the status was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The total number of entries that were updated.</summary>
    [JsonPropertyName("updatedEntries")]
    public long? UpdatedEntries { get; set; }
}

/// <summary>Output only. Status of the job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobStatusObservedStateStatus
{
    /// <summary>Output only. Progress tracking.</summary>
    [JsonPropertyName("completionPercent")]
    public int? CompletionPercent { get; set; }

    /// <summary>Output only. Message relating to the progression of a metadata job.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Output only. State of the metadata job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the status was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobStatusObservedState
{
    /// <summary>Output only. The time when the job was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Results from the export job.</summary>
    [JsonPropertyName("exportResult")]
    public V1alpha1DataplexMetadataJobStatusObservedStateExportResult? ExportResult { get; set; }

    /// <summary>Output only. Results from the import job.</summary>
    [JsonPropertyName("importResult")]
    public V1alpha1DataplexMetadataJobStatusObservedStateImportResult? ImportResult { get; set; }

    /// <summary>Output only. Status of the job.</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexMetadataJobStatusObservedStateStatus? Status { get; set; }

    /// <summary>Output only. System generated globally unique ID for the job.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the job was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataplexMetadataJobStatus defines the config connector machine state of DataplexMetadataJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexMetadataJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexMetadataJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexMetadataJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexMetadataJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataplexMetadataJob is the Schema for the DataplexMetadataJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexMetadataJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexMetadataJobSpec>, IStatus<V1alpha1DataplexMetadataJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexMetadataJob";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexmetadatajobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataplexMetadataJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexMetadataJobSpec defines the desired state of DataplexMetadataJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataplexMetadataJobSpec Spec { get; set; }

    /// <summary>DataplexMetadataJobStatus defines the config connector machine state of DataplexMetadataJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexMetadataJobStatus? Status { get; set; }
}