#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerymigration.cnrm.cloud.google.com;
/// <summary>BigQueryMigrationMigrationWorkflow is the Schema for the BigQueryMigrationMigrationWorkflow API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigQueryMigrationMigrationWorkflow>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryMigrationMigrationWorkflowList";
    public const string KubeGroup = "bigquerymigration.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerymigrationmigrationworkflows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerymigration.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryMigrationMigrationWorkflowList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BigQueryMigrationMigrationWorkflow objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BigQueryMigrationMigrationWorkflow> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecProjectRef
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

/// <summary>Task configuration for Assessment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksAssessmentTaskDetails
{
    /// <summary>Required. The data source or data warehouse type (eg: TERADATA/REDSHIFT) from which the input data is extracted.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Required. The Cloud Storage path for assessment input files.</summary>
    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>Required. The BigQuery dataset for output.</summary>
    [JsonPropertyName("outputDataset")]
    public string? OutputDataset { get; set; }

    /// <summary>Optional. An optional Cloud Storage path to write the query logs (which is then used as an input path on the translation task)</summary>
    [JsonPropertyName("querylogsPath")]
    public string? QuerylogsPath { get; set; }
}

/// <summary>DEPRECATED! Use one of the task_details below. The details of the task. The type URL must be one of the supported task details messages and correspond to the Task&apos;s type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksDetails
{
    /// <summary>
    /// A URL/resource name that uniquely identifies the type of the serialized
    ///  protocol buffer message. This string must contain at least
    ///  one &quot;/&quot; character. The last segment of the URL&apos;s path must represent
    ///  the fully qualified name of the type (as in
    ///  `path/google.protobuf.Duration`). The name should be in a canonical form
    ///  (e.g., leading &quot;.&quot; is not accepted).
    /// 
    ///  In practice, teams usually precompile into the binary all types that they
    ///  expect it to use in the context of Any. However, for URLs which use the
    ///  scheme `http`, `https`, or no scheme, one can optionally set up a type
    ///  server that maps type URLs to message definitions as follows:
    /// 
    ///  * If no scheme is provided, `https` is assumed.
    ///  * An HTTP GET on the URL must yield a [google.protobuf.Type][]
    ///    value in binary format, or produce an error.
    ///  * Applications are allowed to cache lookup results based on the
    ///    URL, or have them precompiled into a binary to avoid any
    ///    lookup. Therefore, binary compatibility needs to be preserved
    ///    on changes to types. (Use versioned type names to manage
    ///    breaking changes.)
    /// 
    ///  Note: this functionality is not currently available in the official
    ///  protobuf release, and it is not used for type URLs beginning with
    ///  type.googleapis.com.
    /// 
    ///  Schemes other than `http`, `https` (or the empty scheme) might be
    ///  used with implementation specific semantics.
    /// </summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public byte[]? Value { get; set; }
}

/// <summary>Specifies the project and dataset in BigQuery that will be used for external table creation during the translation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsBteqOptionsProjectDataset
{
    /// <summary>A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("datasetID")]
    public string? DatasetID { get; set; }

    /// <summary>The ID of the project containing this dataset.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>The BTEQ specific settings for the translation task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsBteqOptions
{
    /// <summary>The Cloud Storage location to be used as the default path for files that are not otherwise specified in the file replacement map.</summary>
    [JsonPropertyName("defaultPathURI")]
    public string? DefaultPathURI { get; set; }

    /// <summary>Maps the local paths that are used in BTEQ scripts (the keys) to the paths in Cloud Storage that should be used in their stead in the translation (the value).</summary>
    [JsonPropertyName("fileReplacementMap")]
    public IDictionary<string, string>? FileReplacementMap { get; set; }

    /// <summary>Specifies the project and dataset in BigQuery that will be used for external table creation during the translation.</summary>
    [JsonPropertyName("projectDataset")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsBteqOptionsProjectDataset? ProjectDataset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsFilePaths
{
    /// <summary>The Cloud Storage path for a file to translation in a subtask.</summary>
    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>The Cloud Storage path to write back the corresponding input file to.</summary>
    [JsonPropertyName("outputPath")]
    public string? OutputPath { get; set; }
}

/// <summary>The filter applied to translation details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsFilter
{
    /// <summary>The list of prefixes used to exclude processing for input files.</summary>
    [JsonPropertyName("inputFileExclusionPrefixes")]
    public IList<string>? InputFileExclusionPrefixes { get; set; }
}

/// <summary>The settings for SQL identifiers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsIdentifierSettings
{
    /// <summary>Specifies the rewrite mode for SQL identifiers.</summary>
    [JsonPropertyName("identifierRewriteMode")]
    public string? IdentifierRewriteMode { get; set; }

    /// <summary>The setting to control output queries&apos; identifier case.</summary>
    [JsonPropertyName("outputIdentifierCase")]
    public string? OutputIdentifierCase { get; set; }
}

/// <summary>The Teradata SQL specific settings for the translation task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsTeradataOptions
{
}

/// <summary>Task configuration for Batch/Offline SQL Translation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetails
{
    /// <summary>The BTEQ specific settings for the translation task.</summary>
    [JsonPropertyName("bteqOptions")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsBteqOptions? BteqOptions { get; set; }

    /// <summary>The file encoding type.</summary>
    [JsonPropertyName("fileEncoding")]
    public string? FileEncoding { get; set; }

    /// <summary>Cloud Storage files to be processed for translation.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsFilePaths>? FilePaths { get; set; }

    /// <summary>The filter applied to translation details.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsFilter? Filter { get; set; }

    /// <summary>The settings for SQL identifiers.</summary>
    [JsonPropertyName("identifierSettings")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsIdentifierSettings? IdentifierSettings { get; set; }

    /// <summary>The Cloud Storage path for translation input files.</summary>
    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>The Cloud Storage path for translation output files.</summary>
    [JsonPropertyName("outputPath")]
    public string? OutputPath { get; set; }

    /// <summary>The Cloud Storage path to DDL files as table schema to assist semantic translation.</summary>
    [JsonPropertyName("schemaPath")]
    public string? SchemaPath { get; set; }

    /// <summary>The Teradata SQL specific settings for the translation task.</summary>
    [JsonPropertyName("teradataOptions")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetailsTeradataOptions? TeradataOptions { get; set; }

    /// <summary>Specifies the exact name of the bigquery table (&quot;dataset.table&quot;) to be used for surfacing raw translation errors. If the table does not exist, we will create it. If it already exists and the schema is the same, we will re-use. If the table exists and the schema is different, we will throw an error.</summary>
    [JsonPropertyName("translationExceptionTable")]
    public string? TranslationExceptionTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpecTasks
{
    /// <summary>Task configuration for Assessment.</summary>
    [JsonPropertyName("assessmentTaskDetails")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksAssessmentTaskDetails? AssessmentTaskDetails { get; set; }

    /// <summary>Time when the task was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>DEPRECATED! Use one of the task_details below. The details of the task. The type URL must be one of the supported task details messages and correspond to the Task&apos;s type.</summary>
    [JsonPropertyName("details")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksDetails? Details { get; set; }

    /// <summary>Time when the task was last updated.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string? LastUpdateTime { get; set; }

    /// <summary>Task configuration for Batch/Offline SQL Translation.</summary>
    [JsonPropertyName("translationTaskDetails")]
    public V1alpha1BigQueryMigrationMigrationWorkflowSpecTasksTranslationTaskDetails? TranslationTaskDetails { get; set; }

    /// <summary>The type of the task. This must be a supported task type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>BigQueryMigrationMigrationWorkflowSpec defines the desired state of BigQueryMigrationMigrationWorkflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowSpec
{
    /// <summary>The display name of the workflow. This can be set to give a workflow a descriptive name. There is no guarantee or enforcement of uniqueness.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BigQueryMigrationMigrationWorkflowSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BigQueryMigrationMigrationWorkflow name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The tasks in a workflow in a named map. The name (i.e. key) has no meaning and is merely a convenient way to address a specific task in a workflow.</summary>
    [JsonPropertyName("tasks")]
    public IDictionary<string, V1alpha1BigQueryMigrationMigrationWorkflowSpecTasks>? Tasks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowStatusConditions
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
public partial class V1alpha1BigQueryMigrationMigrationWorkflowStatusObservedState
{
    /// <summary>Time when the workflow was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Time when the workflow was last updated.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string? LastUpdateTime { get; set; }

    /// <summary>
    /// Output only. Immutable. The unique identifier for the migration workflow. The ID is
    ///  server-generated.
    /// 
    ///  Example: `projects/123/locations/us/workflows/345`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. That status of the workflow.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>BigQueryMigrationMigrationWorkflowStatus defines the config connector machine state of BigQueryMigrationMigrationWorkflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryMigrationMigrationWorkflowStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryMigrationMigrationWorkflowStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryMigrationMigrationWorkflow resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryMigrationMigrationWorkflowStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigQueryMigrationMigrationWorkflow is the Schema for the BigQueryMigrationMigrationWorkflow API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryMigrationMigrationWorkflow : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryMigrationMigrationWorkflowSpec>, IStatus<V1alpha1BigQueryMigrationMigrationWorkflowStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryMigrationMigrationWorkflow";
    public const string KubeGroup = "bigquerymigration.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerymigrationmigrationworkflows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerymigration.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryMigrationMigrationWorkflow";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryMigrationMigrationWorkflowSpec defines the desired state of BigQueryMigrationMigrationWorkflow</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BigQueryMigrationMigrationWorkflowSpec Spec { get; set; }

    /// <summary>BigQueryMigrationMigrationWorkflowStatus defines the config connector machine state of BigQueryMigrationMigrationWorkflow</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryMigrationMigrationWorkflowStatus? Status { get; set; }
}