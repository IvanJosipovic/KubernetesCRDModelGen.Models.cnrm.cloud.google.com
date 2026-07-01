#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sqladmin.cnrm.cloud.google.com;
/// <summary>SQLAdminBackup is the Schema for the SQLAdminBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLAdminBackupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SQLAdminBackup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLAdminBackupList";
    public const string KubeGroup = "sqladmin.cnrm.cloud.google.com";
    public const string KubePluralName = "sqladminbackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sqladmin.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SQLAdminBackupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SQLAdminBackup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SQLAdminBackup> Items { get; set; }
}

/// <summary>KMS key used to encrypt the backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupSpecDiskEncryptionConfigurationKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Encryption configuration specific to a backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupSpecDiskEncryptionConfiguration
{
    /// <summary>KMS key used to encrypt the backup.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1SQLAdminBackupSpecDiskEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>The SQLInstance that this backup belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupSpecInstanceRef
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupSpecProjectRef
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

/// <summary>SQLAdminBackupSpec defines the desired state of SQLAdminBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupSpec
{
    /// <summary>Specifies the kind of backup, PHYSICAL or DEFAULT_SNAPSHOT.</summary>
    [JsonPropertyName("backupKind")]
    public string? BackupKind { get; set; }

    /// <summary>The description of this backup, only applicable to on-demand backups.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encryption configuration specific to a backup.</summary>
    [JsonPropertyName("diskEncryptionConfiguration")]
    public V1alpha1SQLAdminBackupSpecDiskEncryptionConfiguration? DiskEncryptionConfiguration { get; set; }

    /// <summary>The SQLInstance that this backup belongs to.</summary>
    [JsonPropertyName("instanceRef")]
    public required V1alpha1SQLAdminBackupSpecInstanceRef InstanceRef { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1SQLAdminBackupSpecProjectRef ProjectRef { get; set; }

    /// <summary>The SQLAdminBackup name (ID). If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupStatusConditions
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

/// <summary>Encryption status specific to a backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupStatusObservedStateDiskEncryptionStatus
{
    /// <summary>This is always `sql#diskEncryptionStatus`.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>KMS key version used to encrypt the Cloud SQL instance resource</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }
}

/// <summary>Information about why the backup operation failed. This is only present if the run has the FAILED status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupStatusObservedStateError
{
    /// <summary>Identifies the specific error that occurred.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>This is always `sql#operationError`.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Additional information about the error encountered.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupStatusObservedState
{
    /// <summary>Encryption status specific to a backup.</summary>
    [JsonPropertyName("diskEncryptionStatus")]
    public V1alpha1SQLAdminBackupStatusObservedStateDiskEncryptionStatus? DiskEncryptionStatus { get; set; }

    /// <summary>The time the backup operation completed in UTC timezone in RFC 3339 format.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The time the run was enqueued in UTC timezone in RFC 3339 format.</summary>
    [JsonPropertyName("enqueuedTime")]
    public string? EnqueuedTime { get; set; }

    /// <summary>Information about why the backup operation failed. This is only present if the run has the FAILED status.</summary>
    [JsonPropertyName("error")]
    public V1alpha1SQLAdminBackupStatusObservedStateError? Error { get; set; }

    /// <summary>The identifier for this backup run. Unique only for a specific Cloud SQL instance.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>The time the backup operation actually started in UTC timezone in RFC 3339 format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The status of this run.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Backup time zone to prevent restores to an instance with a different time zone. Now relevant only for SQL Server.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The type of this run; can be either &quot;AUTOMATED&quot; or &quot;ON_DEMAND&quot; or &quot;FINAL&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The start time of the backup window during which this the backup was attempted in RFC 3339 format.</summary>
    [JsonPropertyName("windowStartTime")]
    public string? WindowStartTime { get; set; }
}

/// <summary>SQLAdminBackupStatus defines the config connector machine state of SQLAdminBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAdminBackupStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SQLAdminBackupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SQLAdminBackup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1SQLAdminBackupStatusObservedState? ObservedState { get; set; }
}

/// <summary>SQLAdminBackup is the Schema for the SQLAdminBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLAdminBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SQLAdminBackupSpec>, IStatus<V1alpha1SQLAdminBackupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLAdminBackup";
    public const string KubeGroup = "sqladmin.cnrm.cloud.google.com";
    public const string KubePluralName = "sqladminbackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sqladmin.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SQLAdminBackup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLAdminBackupSpec defines the desired state of SQLAdminBackup</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SQLAdminBackupSpec Spec { get; set; }

    /// <summary>SQLAdminBackupStatus defines the config connector machine state of SQLAdminBackup</summary>
    [JsonPropertyName("status")]
    public V1alpha1SQLAdminBackupStatus? Status { get; set; }
}