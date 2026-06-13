#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
/// <summary>LoggingLogSink is the Schema for the LoggingLogSink API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLogSinkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LoggingLogSink>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogSinkList";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogsinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoggingLogSinkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1LoggingLogSink objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1LoggingLogSink> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecBigqueryOptions
{
    /// <summary>Whether to use BigQuery&apos;s partition tables. By default, Logging creates dated tables based on the log entries&apos; timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.</summary>
    [JsonPropertyName("usePartitionedTables")]
    public required bool UsePartitionedTables { get; set; }
}

/// <summary>DatasetRef is a reference to a BigQueryDataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecDestinationBigQueryDatasetRef
{
    /// <summary>A reference to an externally-managed BigQueryDataset resource. Should be in the format &quot;projects/{{projectID}}/datasets/{{datasetID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigQueryDataset resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigQueryDataset resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>LoggingLogBucketRef is a reference to a LoggingLogBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecDestinationLoggingLogBucketRef
{
    /// <summary>A reference to an externally managed LoggingLogBucket resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/buckets/{{bucketID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the LoggingLogBucket resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The name of a LoggingLogBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a LoggingLogBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PubSubTopicRef is a reference to a PubSubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecDestinationPubSubTopicRef
{
    /// <summary>A reference to an externally managed PubSubTopic resource. Should be in the format &quot;projects/{{projectID}}/topics/{{topicID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PubSubTopic resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PubSubTopic resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>StorageBucketRef is a reference to a GCP StorageBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecDestinationStorageBucketRef
{
    /// <summary>A reference to an externally managed StorageBucket resource. Should be in the format &quot;projects/{{projectID}}/buckets/{{bucketID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a StorageBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a StorageBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecDestination
{
    /// <summary>DatasetRef is a reference to a BigQueryDataset.</summary>
    [JsonPropertyName("bigQueryDatasetRef")]
    public V1beta1LoggingLogSinkSpecDestinationBigQueryDatasetRef? BigQueryDatasetRef { get; set; }

    /// <summary>LoggingLogBucketRef is a reference to a LoggingLogBucket.</summary>
    [JsonPropertyName("loggingLogBucketRef")]
    public V1beta1LoggingLogSinkSpecDestinationLoggingLogBucketRef? LoggingLogBucketRef { get; set; }

    /// <summary>PubSubTopicRef is a reference to a PubSubTopic.</summary>
    [JsonPropertyName("pubSubTopicRef")]
    public V1beta1LoggingLogSinkSpecDestinationPubSubTopicRef? PubSubTopicRef { get; set; }

    /// <summary>StorageBucketRef is a reference to a GCP StorageBucket.</summary>
    [JsonPropertyName("storageBucketRef")]
    public V1beta1LoggingLogSinkSpecDestinationStorageBucketRef? StorageBucketRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries.</summary>
    [JsonPropertyName("filter")]
    public required string Filter { get; set; }

    /// <summary>A client-assigned identifier, such as &quot;load-balancer-exclusion&quot;. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Immutable. The folder in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecFolderRef
{
    /// <summary>The &apos;name&apos; field of a folder, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The &apos;name&apos; field of a &apos;Folder&apos; resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The &apos;namespace&apos; field of a &apos;Folder&apos; resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The organization in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The &apos;name&apos; field of an &apos;Organization&apos; resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The &apos;namespace&apos; field of an &apos;Organization&apos; resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The project in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>LoggingLogSinkSpec defines the desired state of LoggingLogSink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkSpec
{
    [JsonPropertyName("bigqueryOptions")]
    public V1beta1LoggingLogSinkSpecBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destination")]
    public required V1beta1LoggingLogSinkSpecDestination Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion&apos;s filters, it will not be exported.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta1LoggingLogSinkSpecExclusions>? Exclusions { get; set; }

    /// <summary>The filter to apply when exporting logs. Only log entries that match the filter are exported.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Immutable. The folder in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1LoggingLogSinkSpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. Whether or not to include children organizations in the sink export. If true, logs associated with child projects are also exported; otherwise only logs relating to the provided organization are included.</summary>
    [JsonPropertyName("includeChildren")]
    public bool? IncludeChildren { get; set; }

    /// <summary>Immutable. The organization in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1LoggingLogSinkSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The project in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1LoggingLogSinkSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Whether or not to create a unique identity associated with this sink. If false (the default), then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true, then a unique service account is created and used for this sink. If you wish to publish logs across projects, you must set unique_writer_identity to true.</summary>
    [JsonPropertyName("uniqueWriterIdentity")]
    public bool? UniqueWriterIdentity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkStatusConditions
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

/// <summary>LoggingLogSinkStatus defines the config connector machine state of LoggingLogSink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogSinkStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingLogSinkStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The identity associated with this sink. This identity must be granted write access to the configured destination.</summary>
    [JsonPropertyName("writerIdentity")]
    public string? WriterIdentity { get; set; }
}

/// <summary>LoggingLogSink is the Schema for the LoggingLogSink API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLogSink : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingLogSinkSpec>, IStatus<V1beta1LoggingLogSinkStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogSink";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogsinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoggingLogSink";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LoggingLogSinkSpec defines the desired state of LoggingLogSink</summary>
    [JsonPropertyName("spec")]
    public required V1beta1LoggingLogSinkSpec Spec { get; set; }

    /// <summary>LoggingLogSinkStatus defines the config connector machine state of LoggingLogSink</summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingLogSinkStatus? Status { get; set; }
}