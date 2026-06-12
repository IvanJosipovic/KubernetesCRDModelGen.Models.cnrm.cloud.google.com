#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
/// <summary>DLPDiscoveryConfig is the Schema for the DLPDiscoveryConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DLPDiscoveryConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DLPDiscoveryConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DLPDiscoveryConfigList";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpdiscoveryconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dlp.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DLPDiscoveryConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DLPDiscoveryConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DLPDiscoveryConfig> Items { get; set; }
}

/// <summary>
/// Store all profiles to BigQuery.
/// 
///  * The system will create a new dataset and table for you if none are
///    are provided. The dataset will be named
///    `sensitive_data_protection_discovery` and table will be named
///    `discovery_profiles`. This table will be placed in the same project as
///    the container project running the scan. After the first profile is
///    generated and the dataset and table are created, the discovery scan
///    configuration will be updated with the dataset and table names.
///  * See [Analyze data profiles stored in
///  BigQuery](https://cloud.google.com/sensitive-data-protection/docs/analyze-data-profiles).
///  * See [Sample queries for your BigQuery
///  table](https://cloud.google.com/sensitive-data-protection/docs/analyze-data-profiles#sample_sql_queries).
///  *  Data is inserted using [streaming
///     insert](https://cloud.google.com/blog/products/bigquery/life-of-a-bigquery-streaming-insert)
///     and so data may be in the buffer for a period of time after the
///     profile has finished.
///   * The Pub/Sub notification is sent before the streaming buffer is
///     guaranteed to be written, so data may not be instantly
///     visible to queries by the time your topic receives the Pub/Sub
///     notification.
///   * The best practice is to use the same table for an entire organization
///     so that you can take advantage of the [provided Looker
///     reports](https://cloud.google.com/sensitive-data-protection/docs/analyze-data-profiles#use_a_premade_report).
///     If you use VPC Service Controls to define security perimeters, then
///     you must use a separate table for each boundary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsExportDataProfileTable
{
    /// <summary>Dataset ID of the table.</summary>
    [JsonPropertyName("datasetID")]
    public string? DatasetID { get; set; }

    /// <summary>The Google Cloud project ID of the project containing the table. If omitted, project ID is inferred from the API call.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("tableID")]
    public string? TableID { get; set; }
}

/// <summary>Store sample [data profile findings][google.privacy.dlp.v2.DataProfileFinding] in an existing table or a new table in an existing dataset. Each regeneration will result in new rows in BigQuery. Data is inserted using [streaming insert](https://cloud.google.com/blog/products/bigquery/life-of-a-bigquery-streaming-insert) and so data may be in the buffer for a period of time after the profile has finished.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsExportDataSampleFindingsTable
{
    /// <summary>Dataset ID of the table.</summary>
    [JsonPropertyName("datasetID")]
    public string? DatasetID { get; set; }

    /// <summary>The Google Cloud project ID of the project containing the table. If omitted, project ID is inferred from the API call.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("tableID")]
    public string? TableID { get; set; }
}

/// <summary>Export data profiles into a provided location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsExportData
{
    /// <summary>
    /// Store all profiles to BigQuery.
    /// 
    ///  * The system will create a new dataset and table for you if none are
    ///    are provided. The dataset will be named
    ///    `sensitive_data_protection_discovery` and table will be named
    ///    `discovery_profiles`. This table will be placed in the same project as
    ///    the container project running the scan. After the first profile is
    ///    generated and the dataset and table are created, the discovery scan
    ///    configuration will be updated with the dataset and table names.
    ///  * See [Analyze data profiles stored in
    ///  BigQuery](https://cloud.google.com/sensitive-data-protection/docs/analyze-data-profiles).
    ///  * See [Sample queries for your BigQuery
    ///  table](https://cloud.google.com/sensitive-data-protection/docs/analyze-data-profiles#sample_sql_queries).
    ///  *  Data is inserted using [streaming
    ///     insert](https://cloud.google.com/blog/products/bigquery/life-of-a-bigquery-streaming-insert)
    ///     and so data may be in the buffer for a period of time after the
    ///     profile has finished.
    ///   * The Pub/Sub notification is sent before the streaming buffer is
    ///     guaranteed to be written, so data may not be instantly
    ///     visible to queries by the time your topic receives the Pub/Sub
    ///     notification.
    ///   * The best practice is to use the same table for an entire organization
    ///     so that you can take advantage of the [provided Looker
    ///     reports](https://cloud.google.com/sensitive-data-protection/docs/analyze-data-profiles#use_a_premade_report).
    ///     If you use VPC Service Controls to define security perimeters, then
    ///     you must use a separate table for each boundary.
    /// </summary>
    [JsonPropertyName("profileTable")]
    public V1alpha1DLPDiscoveryConfigSpecActionsExportDataProfileTable? ProfileTable { get; set; }

    /// <summary>Store sample [data profile findings][google.privacy.dlp.v2.DataProfileFinding] in an existing table or a new table in an existing dataset. Each regeneration will result in new rows in BigQuery. Data is inserted using [streaming insert](https://cloud.google.com/blog/products/bigquery/life-of-a-bigquery-streaming-insert) and so data may be in the buffer for a period of time after the profile has finished.</summary>
    [JsonPropertyName("sampleFindingsTable")]
    public V1alpha1DLPDiscoveryConfigSpecActionsExportDataSampleFindingsTable? SampleFindingsTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationPubsubConditionExpressionsConditions
{
    /// <summary>The minimum data risk score that triggers the condition.</summary>
    [JsonPropertyName("minimumRiskScore")]
    public string? MinimumRiskScore { get; set; }

    /// <summary>The minimum sensitivity level that triggers the condition.</summary>
    [JsonPropertyName("minimumSensitivityScore")]
    public string? MinimumSensitivityScore { get; set; }
}

/// <summary>An expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationPubsubConditionExpressions
{
    /// <summary>Conditions to apply to the expression.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationPubsubConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the collection of conditions.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>Conditions (e.g., data risk or sensitivity level) for triggering a Pub/Sub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationPubsubCondition
{
    /// <summary>An expression.</summary>
    [JsonPropertyName("expressions")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationPubsubConditionExpressions? Expressions { get; set; }
}

/// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationTopicRef
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

/// <summary>Publish a message into the Pub/Sub topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotification
{
    /// <summary>How much data to include in the Pub/Sub message. If the user wishes to limit the size of the message, they can use resource_name and fetch the profile fields they wish to. Per table profile (not per column).</summary>
    [JsonPropertyName("detailOfMessage")]
    public string? DetailOfMessage { get; set; }

    /// <summary>The type of event that triggers a Pub/Sub. At most one `PubSubNotification` per EventType is permitted.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>Conditions (e.g., data risk or sensitivity level) for triggering a Pub/Sub.</summary>
    [JsonPropertyName("pubsubCondition")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationPubsubCondition? PubsubCondition { get; set; }

    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topicRef")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotificationTopicRef? TopicRef { get; set; }
}

/// <summary>Publishes generated data profiles to Google Security Operations. For more information, see [Use Sensitive Data Protection data in context-aware analytics](https://cloud.google.com/chronicle/docs/detection/usecase-dlp-high-risk-user-download).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPublishToChronicle
{
}

/// <summary>Publishes a portion of each profile to Dataplex Catalog with the aspect type Sensitive Data Protection Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPublishToDataplexCatalog
{
    /// <summary>Whether creating a Dataplex Catalog aspect for a profiled resource should lower the risk of the profile for that resource. This also lowers the data risk of resources at the lower levels of the resource hierarchy. For example, reducing the data risk of a table data profile also reduces the data risk of the constituent column data profiles.</summary>
    [JsonPropertyName("lowerDataRiskToLow")]
    public bool? LowerDataRiskToLow { get; set; }
}

/// <summary>Publishes findings to Security Command Center for each data profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsPublishToScc
{
}

/// <summary>Conditions attaching the tag to a resource on its profile having this sensitivity score.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsTagResourcesTagConditionsSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>The tag value to attach to resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsTagResourcesTagConditionsTag
{
    /// <summary>The namespaced name for the tag value to attach to resources. Must be in the format `{parent_id}/{tag_key_short_name}/{short_name}`, for example, &quot;123456/environment/prod&quot;.</summary>
    [JsonPropertyName("namespacedValue")]
    public string? NamespacedValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsTagResourcesTagConditions
{
    /// <summary>Conditions attaching the tag to a resource on its profile having this sensitivity score.</summary>
    [JsonPropertyName("sensitivityScore")]
    public V1alpha1DLPDiscoveryConfigSpecActionsTagResourcesTagConditionsSensitivityScore? SensitivityScore { get; set; }

    /// <summary>The tag value to attach to resources.</summary>
    [JsonPropertyName("tag")]
    public V1alpha1DLPDiscoveryConfigSpecActionsTagResourcesTagConditionsTag? Tag { get; set; }
}

/// <summary>Tags the profiled resources with the specified tag values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActionsTagResources
{
    /// <summary>Whether applying a tag to a resource should lower the risk of the profile for that resource. For example, in conjunction with an [IAM deny policy](https://cloud.google.com/iam/docs/deny-overview), you can deny all principals a permission if a tag value is present, mitigating the risk of the resource. This also lowers the data risk of resources at the lower levels of the resource hierarchy. For example, reducing the data risk of a table data profile also reduces the data risk of the constituent column data profiles.</summary>
    [JsonPropertyName("lowerDataRiskToLow")]
    public bool? LowerDataRiskToLow { get; set; }

    /// <summary>The profile generations for which the tag should be attached to resources. If you attach a tag to only new profiles, then if the sensitivity score of a profile subsequently changes, its tag doesn&apos;t change. By default, this field includes only new profiles. To include both new and updated profiles for tagging, this field should explicitly include both `PROFILE_GENERATION_NEW` and `PROFILE_GENERATION_UPDATE`.</summary>
    [JsonPropertyName("profileGenerationsToTag")]
    public IList<string>? ProfileGenerationsToTag { get; set; }

    /// <summary>The tags to associate with different conditions.</summary>
    [JsonPropertyName("tagConditions")]
    public IList<V1alpha1DLPDiscoveryConfigSpecActionsTagResourcesTagConditions>? TagConditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecActions
{
    /// <summary>Export data profiles into a provided location.</summary>
    [JsonPropertyName("exportData")]
    public V1alpha1DLPDiscoveryConfigSpecActionsExportData? ExportData { get; set; }

    /// <summary>Publish a message into the Pub/Sub topic.</summary>
    [JsonPropertyName("pubSubNotification")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPubSubNotification? PubSubNotification { get; set; }

    /// <summary>Publishes generated data profiles to Google Security Operations. For more information, see [Use Sensitive Data Protection data in context-aware analytics](https://cloud.google.com/chronicle/docs/detection/usecase-dlp-high-risk-user-download).</summary>
    [JsonPropertyName("publishToChronicle")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPublishToChronicle? PublishToChronicle { get; set; }

    /// <summary>Publishes a portion of each profile to Dataplex Catalog with the aspect type Sensitive Data Protection Profile.</summary>
    [JsonPropertyName("publishToDataplexCatalog")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPublishToDataplexCatalog? PublishToDataplexCatalog { get; set; }

    /// <summary>Publishes findings to Security Command Center for each data profile.</summary>
    [JsonPropertyName("publishToScc")]
    public V1alpha1DLPDiscoveryConfigSpecActionsPublishToScc? PublishToScc { get; set; }

    /// <summary>Tags the profiled resources with the specified tag values.</summary>
    [JsonPropertyName("tagResources")]
    public V1alpha1DLPDiscoveryConfigSpecActionsTagResources? TagResources { get; set; }
}

/// <summary>The data to scan: folder, org, or project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecOrgConfigLocation
{
    /// <summary>The ID of the folder within an organization to be scanned.</summary>
    [JsonPropertyName("folderID")]
    public long? FolderID { get; set; }

    /// <summary>The ID of an organization to scan.</summary>
    [JsonPropertyName("organizationID")]
    public long? OrganizationID { get; set; }
}

/// <summary>Only set when the parent is an org.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecOrgConfig
{
    /// <summary>The data to scan: folder, org, or project</summary>
    [JsonPropertyName("location")]
    public V1alpha1DLPDiscoveryConfigSpecOrgConfigLocation? Location { get; set; }

    /// <summary>The project that will run the scan. The DLP service account that exists within this project must have access to all resources that are profiled, and the DLP API must be enabled.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>The AWS starting location for discovery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecOtherCloudStartingLocationAwsLocation
{
    /// <summary>The AWS account ID that this discovery config applies to. Within an AWS organization, you can find the AWS account ID inside an AWS account ARN. Example: arn:{partition}:organizations::{management_account_id}:account/{org_id}/{account_id}</summary>
    [JsonPropertyName("accountID")]
    public string? AccountID { get; set; }

    /// <summary>All AWS assets stored in Asset Inventory that didn&apos;t match other AWS discovery configs.</summary>
    [JsonPropertyName("allAssetInventoryAssets")]
    public bool? AllAssetInventoryAssets { get; set; }
}

/// <summary>Must be set only when scanning other clouds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecOtherCloudStartingLocation
{
    /// <summary>The AWS starting location for discovery.</summary>
    [JsonPropertyName("awsLocation")]
    public V1alpha1DLPDiscoveryConfigSpecOtherCloudStartingLocationAwsLocation? AwsLocation { get; set; }
}

/// <summary>Processing will happen in the global region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecProcessingLocationImageFallbackLocationGlobalProcessing
{
}

/// <summary>Processing will happen in a multi-region that contains the current region if available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecProcessingLocationImageFallbackLocationMultiRegionProcessing
{
}

/// <summary>Image processing will fall back using this configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecProcessingLocationImageFallbackLocation
{
    /// <summary>Processing will happen in the global region.</summary>
    [JsonPropertyName("globalProcessing")]
    public V1alpha1DLPDiscoveryConfigSpecProcessingLocationImageFallbackLocationGlobalProcessing? GlobalProcessing { get; set; }

    /// <summary>Processing will happen in a multi-region that contains the current region if available.</summary>
    [JsonPropertyName("multiRegionProcessing")]
    public V1alpha1DLPDiscoveryConfigSpecProcessingLocationImageFallbackLocationMultiRegionProcessing? MultiRegionProcessing { get; set; }
}

/// <summary>Optional. Processing location configuration. Vertex AI dataset scanning will set processing_location.image_fallback_type to MultiRegionProcessing by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecProcessingLocation
{
    /// <summary>Image processing will fall back using this configuration.</summary>
    [JsonPropertyName("imageFallbackLocation")]
    public V1alpha1DLPDiscoveryConfigSpecProcessingLocationImageFallbackLocation? ImageFallbackLocation { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecProjectRef
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

/// <summary>Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadenceInspectTemplateModifiedCadence
{
    /// <summary>How frequently data profiles can be updated when the template is modified. Defaults to never.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
}

/// <summary>Governs when to update data profiles when a schema is modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadenceSchemaModifiedCadence
{
    /// <summary>How frequently profiles may be updated when schemas are modified. Defaults to monthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The type of events to consider when deciding if the table&apos;s schema has been modified and should have the profile updated. Defaults to NEW_COLUMNS.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>Governs when to update data profiles when a table is modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadenceTableModifiedCadence
{
    /// <summary>How frequently data profiles can be updated when tables are modified. Defaults to never.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The type of events to consider when deciding if the table has been modified and should have the profile updated. Defaults to MODIFIED_TIMESTAMP.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>How often and when to update profiles. New tables that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadence
{
    /// <summary>Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
    [JsonPropertyName("inspectTemplateModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadenceInspectTemplateModifiedCadence? InspectTemplateModifiedCadence { get; set; }

    /// <summary>Frequency at which profiles should be updated, regardless of whether the underlying resource has changed. Defaults to never.</summary>
    [JsonPropertyName("refreshFrequency")]
    public string? RefreshFrequency { get; set; }

    /// <summary>Governs when to update data profiles when a schema is modified.</summary>
    [JsonPropertyName("schemaModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadenceSchemaModifiedCadence? SchemaModifiedCadence { get; set; }

    /// <summary>Governs when to update data profiles when a table is modified.</summary>
    [JsonPropertyName("tableModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadenceTableModifiedCadence? TableModifiedCadence { get; set; }
}

/// <summary>At least one of the conditions must be true for a table to be scanned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetConditionsOrConditions
{
    /// <summary>Minimum age a table must have before Cloud DLP can profile it. Value must be 1 hour or greater.</summary>
    [JsonPropertyName("minAge")]
    public string? MinAge { get; set; }

    /// <summary>Minimum number of rows that should be present before Cloud DLP profiles a table</summary>
    [JsonPropertyName("minRowCount")]
    public int? MinRowCount { get; set; }
}

/// <summary>Restrict discovery to specific table types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetConditionsTypes
{
    /// <summary>A set of BigQuery table types.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetConditions
{
    /// <summary>BigQuery table must have been created after this date. Used to avoid backfilling.</summary>
    [JsonPropertyName("createdAfter")]
    public string? CreatedAfter { get; set; }

    /// <summary>At least one of the conditions must be true for a table to be scanned.</summary>
    [JsonPropertyName("orConditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetConditionsOrConditions? OrConditions { get; set; }

    /// <summary>Restrict discovery to categories of table types.</summary>
    [JsonPropertyName("typeCollection")]
    public string? TypeCollection { get; set; }

    /// <summary>Restrict discovery to specific table types.</summary>
    [JsonPropertyName("types")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetConditionsTypes? Types { get; set; }
}

/// <summary>Tables that match this filter will not have profiles created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetDisabled
{
}

/// <summary>Catch-all. This should always be the last filter in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterOtherTables
{
}

/// <summary>The table to scan. Discovery configurations including this can only include one DiscoveryTarget (the DiscoveryTarget with this TableReference).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTableReference
{
    /// <summary>Dataset ID of the table.</summary>
    [JsonPropertyName("datasetID")]
    public string? DatasetID { get; set; }

    /// <summary>The Google Cloud project ID of the project containing the table. If omitted, the project ID is inferred from the parent project. This field is required if the parent resource is an organization.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("tableID")]
    public string? TableID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTablesIncludeRegexesPatterns
{
    /// <summary>If unset, this property matches all datasets.</summary>
    [JsonPropertyName("datasetIDRegex")]
    public string? DatasetIDRegex { get; set; }

    /// <summary>For organizations, if unset, will match all projects. Has no effect for data profile configurations created within a project.</summary>
    [JsonPropertyName("projectIDRegex")]
    public string? ProjectIDRegex { get; set; }

    /// <summary>If unset, this property matches all tables.</summary>
    [JsonPropertyName("tableIDRegex")]
    public string? TableIDRegex { get; set; }
}

/// <summary>A collection of regular expressions to match a BigQuery table against.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTablesIncludeRegexes
{
    /// <summary>A single BigQuery regular expression pattern to match against one or more tables, datasets, or projects that contain BigQuery tables.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTablesIncludeRegexesPatterns>? Patterns { get; set; }
}

/// <summary>A specific set of tables for this filter to apply to. A table collection must be specified in only one filter per config. If a table id or dataset is empty, Cloud DLP assumes all tables in that collection must be profiled. Must specify a project ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTables
{
    /// <summary>A collection of regular expressions to match a BigQuery table against.</summary>
    [JsonPropertyName("includeRegexes")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTablesIncludeRegexes? IncludeRegexes { get; set; }
}

/// <summary>Required. The tables the discovery cadence applies to. The first target with a matching filter will be the one to apply to a table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilter
{
    /// <summary>Catch-all. This should always be the last filter in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
    [JsonPropertyName("otherTables")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterOtherTables? OtherTables { get; set; }

    /// <summary>The table to scan. Discovery configurations including this can only include one DiscoveryTarget (the DiscoveryTarget with this TableReference).</summary>
    [JsonPropertyName("tableReference")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTableReference? TableReference { get; set; }

    /// <summary>A specific set of tables for this filter to apply to. A table collection must be specified in only one filter per config. If a table id or dataset is empty, Cloud DLP assumes all tables in that collection must be profiled. Must specify a project ID.</summary>
    [JsonPropertyName("tables")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilterTables? Tables { get; set; }
}

/// <summary>BigQuery target for Discovery. The first target to match a table will be the one applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTarget
{
    /// <summary>How often and when to update profiles. New tables that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
    [JsonPropertyName("cadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetCadence? Cadence { get; set; }

    /// <summary>In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
    [JsonPropertyName("conditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetConditions? Conditions { get; set; }

    /// <summary>Tables that match this filter will not have profiles created.</summary>
    [JsonPropertyName("disabled")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetDisabled? Disabled { get; set; }

    /// <summary>Required. The tables the discovery cadence applies to. The first target with a matching filter will be the one to apply to a table.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTargetFilter? Filter { get; set; }
}

/// <summary>In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetConditions
{
    /// <summary>Optional. Database engines that should be profiled. Optional. Defaults to ALL_SUPPORTED_DATABASE_ENGINES if unspecified.</summary>
    [JsonPropertyName("databaseEngines")]
    public IList<string>? DatabaseEngines { get; set; }

    /// <summary>Data profiles will only be generated for the database resource types specified in this field. If not specified, defaults to [DATABASE_RESOURCE_TYPE_ALL_SUPPORTED_TYPES].</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>Disable profiling for database resources that match this filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetDisabled
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterCollectionIncludeRegexesPatterns
{
    /// <summary>Regex to test the database name against. If empty, all databases match.</summary>
    [JsonPropertyName("databaseRegex")]
    public string? DatabaseRegex { get; set; }

    /// <summary>Regex to test the database resource&apos;s name against. An example of a database resource name is a table&apos;s name. Other database resource names like view names could be included in the future. If empty, all database resources match.</summary>
    [JsonPropertyName("databaseResourceNameRegex")]
    public string? DatabaseResourceNameRegex { get; set; }

    /// <summary>Regex to test the instance name against. If empty, all instances match.</summary>
    [JsonPropertyName("instanceRegex")]
    public string? InstanceRegex { get; set; }

    /// <summary>For organizations, if unset, will match all projects. Has no effect for configurations created within a project.</summary>
    [JsonPropertyName("projectIDRegex")]
    public string? ProjectIDRegex { get; set; }
}

/// <summary>A collection of regular expressions to match a database resource against.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterCollectionIncludeRegexes
{
    /// <summary>A group of regular expression patterns to match against one or more database resources. Maximum of 100 entries. The sum of all regular expression&apos;s length can&apos;t exceed 10 KiB.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterCollectionIncludeRegexesPatterns>? Patterns { get; set; }
}

/// <summary>A specific set of database resources for this filter to apply to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterCollection
{
    /// <summary>A collection of regular expressions to match a database resource against.</summary>
    [JsonPropertyName("includeRegexes")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterCollectionIncludeRegexes? IncludeRegexes { get; set; }
}

/// <summary>The database resource to scan. Targets including this can only include one target (the target with this database resource reference).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterDatabaseResourceReference
{
    /// <summary>Required. Name of a database within the instance.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Required. Name of a database resource, for example, a table within the database.</summary>
    [JsonPropertyName("databaseResource")]
    public string? DatabaseResource { get; set; }

    /// <summary>Required. The instance where this resource is located. For example: Cloud SQL instance ID.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Required. If within a project-level config, then this must match the config&apos;s project ID.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterOthers
{
}

/// <summary>Required. The tables the discovery cadence applies to. The first target with a matching filter will be the one to apply to a table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilter
{
    /// <summary>A specific set of database resources for this filter to apply to.</summary>
    [JsonPropertyName("collection")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterCollection? Collection { get; set; }

    /// <summary>The database resource to scan. Targets including this can only include one target (the target with this database resource reference).</summary>
    [JsonPropertyName("databaseResourceReference")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterDatabaseResourceReference? DatabaseResourceReference { get; set; }

    /// <summary>Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
    [JsonPropertyName("others")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilterOthers? Others { get; set; }
}

/// <summary>Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetGenerationCadenceInspectTemplateModifiedCadence
{
    /// <summary>How frequently data profiles can be updated when the template is modified. Defaults to never.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
}

/// <summary>When to reprofile if the schema has changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetGenerationCadenceSchemaModifiedCadence
{
    /// <summary>Frequency to regenerate data profiles when the schema is modified. Defaults to monthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The types of schema modifications to consider. Defaults to NEW_COLUMNS.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>How often and when to update profiles. New tables that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetGenerationCadence
{
    /// <summary>Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
    [JsonPropertyName("inspectTemplateModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetGenerationCadenceInspectTemplateModifiedCadence? InspectTemplateModifiedCadence { get; set; }

    /// <summary>Data changes (non-schema changes) in Cloud SQL tables can&apos;t trigger reprofiling. If you set this field, profiles are refreshed at this frequency regardless of whether the underlying tables have changed. Defaults to never.</summary>
    [JsonPropertyName("refreshFrequency")]
    public string? RefreshFrequency { get; set; }

    /// <summary>When to reprofile if the schema has changed.</summary>
    [JsonPropertyName("schemaModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetGenerationCadenceSchemaModifiedCadence? SchemaModifiedCadence { get; set; }
}

/// <summary>Cloud SQL target for Discovery. The first target to match a table will be the one applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTarget
{
    /// <summary>In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
    [JsonPropertyName("conditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetConditions? Conditions { get; set; }

    /// <summary>Disable profiling for database resources that match this filter.</summary>
    [JsonPropertyName("disabled")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetDisabled? Disabled { get; set; }

    /// <summary>Required. The tables the discovery cadence applies to. The first target with a matching filter will be the one to apply to a table.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetFilter? Filter { get; set; }

    /// <summary>How often and when to update profiles. New tables that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
    [JsonPropertyName("generationCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTargetGenerationCadence? GenerationCadence { get; set; }
}

/// <summary>Optional. Cloud Storage conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetConditionsCloudStorageConditions
{
    /// <summary>Required. Only objects with the specified attributes will be scanned. Defaults to [ALL_SUPPORTED_BUCKETS] if unset.</summary>
    [JsonPropertyName("includedBucketAttributes")]
    public IList<string>? IncludedBucketAttributes { get; set; }

    /// <summary>Required. Only objects with the specified attributes will be scanned. If an object has one of the specified attributes but is inside an excluded bucket, it will not be scanned. Defaults to [ALL_SUPPORTED_OBJECTS]. A profile will be created even if no objects match the included_object_attributes.</summary>
    [JsonPropertyName("includedObjectAttributes")]
    public IList<string>? IncludedObjectAttributes { get; set; }
}

/// <summary>Optional. In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetConditions
{
    /// <summary>Optional. Cloud Storage conditions.</summary>
    [JsonPropertyName("cloudStorageConditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetConditionsCloudStorageConditions? CloudStorageConditions { get; set; }

    /// <summary>Optional. File store must have been created after this date. Used to avoid backfilling.</summary>
    [JsonPropertyName("createdAfter")]
    public string? CreatedAfter { get; set; }

    /// <summary>Optional. Minimum age a file store must have. If set, the value must be 1 hour or greater.</summary>
    [JsonPropertyName("minAge")]
    public string? MinAge { get; set; }
}

/// <summary>Optional. Disable profiling for buckets that match this filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetDisabled
{
}

/// <summary>Optional. The bucket to scan. Targets including this can only include one target (the target with this bucket). This enables profiling the contents of a single bucket, while the other options allow for easy profiling of many bucets within a project or an organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCloudStorageResourceReference
{
    /// <summary>Required. The bucket to scan.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Required. If within a project-level config, then this must match the config&apos;s project id.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>Optional. Regex for Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollectionIncludeRegexesPatternsCloudStorageRegex
{
    /// <summary>Optional. Regex to test the bucket name against. If empty, all buckets match. Example: &quot;marketing2021&quot; or &quot;(marketing)\d{4}&quot; will both match the bucket gs://marketing2021</summary>
    [JsonPropertyName("bucketNameRegex")]
    public string? BucketNameRegex { get; set; }

    /// <summary>Optional. For organizations, if unset, will match all projects.</summary>
    [JsonPropertyName("projectIDRegex")]
    public string? ProjectIDRegex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollectionIncludeRegexesPatterns
{
    /// <summary>Optional. Regex for Cloud Storage.</summary>
    [JsonPropertyName("cloudStorageRegex")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollectionIncludeRegexesPatternsCloudStorageRegex? CloudStorageRegex { get; set; }
}

/// <summary>Optional. A collection of regular expressions to match a file store against.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollectionIncludeRegexes
{
    /// <summary>Required. The group of regular expression patterns to match against one or more file stores. Maximum of 100 entries. The sum of all regular expression&apos;s length can&apos;t exceed 10 KiB.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollectionIncludeRegexesPatterns>? Patterns { get; set; }
}

/// <summary>Optional. A specific set of buckets for this filter to apply to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollection
{
    /// <summary>Optional. A collection of regular expressions to match a file store against.</summary>
    [JsonPropertyName("includeRegexes")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollectionIncludeRegexes? IncludeRegexes { get; set; }
}

/// <summary>Optional. Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterOthers
{
}

/// <summary>Required. The buckets the generation_cadence applies to. The first target with a matching filter will be the one to apply to a bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilter
{
    /// <summary>Optional. The bucket to scan. Targets including this can only include one target (the target with this bucket). This enables profiling the contents of a single bucket, while the other options allow for easy profiling of many bucets within a project or an organization.</summary>
    [JsonPropertyName("cloudStorageResourceReference")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCloudStorageResourceReference? CloudStorageResourceReference { get; set; }

    /// <summary>Optional. A specific set of buckets for this filter to apply to.</summary>
    [JsonPropertyName("collection")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterCollection? Collection { get; set; }

    /// <summary>Optional. Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
    [JsonPropertyName("others")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilterOthers? Others { get; set; }
}

/// <summary>Optional. Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetGenerationCadenceInspectTemplateModifiedCadence
{
    /// <summary>How frequently data profiles can be updated when the template is modified. Defaults to never.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
}

/// <summary>Optional. How often and when to update profiles. New buckets that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetGenerationCadence
{
    /// <summary>Optional. Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
    [JsonPropertyName("inspectTemplateModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetGenerationCadenceInspectTemplateModifiedCadence? InspectTemplateModifiedCadence { get; set; }

    /// <summary>Optional. Data changes in Cloud Storage can&apos;t trigger reprofiling. If you set this field, profiles are refreshed at this frequency regardless of whether the underlying buckets have changed. Defaults to never.</summary>
    [JsonPropertyName("refreshFrequency")]
    public string? RefreshFrequency { get; set; }
}

/// <summary>Cloud Storage target for Discovery. The first target to match a table will be the one applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTarget
{
    /// <summary>Optional. In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
    [JsonPropertyName("conditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetConditions? Conditions { get; set; }

    /// <summary>Optional. Disable profiling for buckets that match this filter.</summary>
    [JsonPropertyName("disabled")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetDisabled? Disabled { get; set; }

    /// <summary>Required. The buckets the generation_cadence applies to. The first target with a matching filter will be the one to apply to a bucket.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetFilter? Filter { get; set; }

    /// <summary>Optional. How often and when to update profiles. New buckets that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
    [JsonPropertyName("generationCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTargetGenerationCadence? GenerationCadence { get; set; }
}

/// <summary>Amazon S3 bucket conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetConditionsAmazonS3BucketConditions
{
    /// <summary>Optional. Bucket types that should be profiled. Optional. Defaults to TYPE_ALL_SUPPORTED if unspecified.</summary>
    [JsonPropertyName("bucketTypes")]
    public IList<string>? BucketTypes { get; set; }

    /// <summary>Optional. Object classes that should be profiled. Optional. Defaults to ALL_SUPPORTED_CLASSES if unspecified.</summary>
    [JsonPropertyName("objectStorageClasses")]
    public IList<string>? ObjectStorageClasses { get; set; }
}

/// <summary>Optional. In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetConditions
{
    /// <summary>Amazon S3 bucket conditions.</summary>
    [JsonPropertyName("amazonS3BucketConditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetConditionsAmazonS3BucketConditions? AmazonS3BucketConditions { get; set; }

    /// <summary>Minimum age a resource must be before Cloud DLP can profile it. Value must be 1 hour or greater.</summary>
    [JsonPropertyName("minAge")]
    public string? MinAge { get; set; }
}

/// <summary>Required. The type of data profiles generated by this discovery target. Supported values are: * aws/s3/bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetDataSourceType
{
}

/// <summary>Disable profiling for resources that match this filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetDisabled
{
}

/// <summary>The AWS account regex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexesPatternsAmazonS3BucketRegexAwsAccountRegex
{
    /// <summary>Optional. Regex to test the AWS account ID against. If empty, all accounts match.</summary>
    [JsonPropertyName("accountIDRegex")]
    public string? AccountIDRegex { get; set; }
}

/// <summary>Regex for Amazon S3 buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexesPatternsAmazonS3BucketRegex
{
    /// <summary>The AWS account regex.</summary>
    [JsonPropertyName("awsAccountRegex")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexesPatternsAmazonS3BucketRegexAwsAccountRegex? AwsAccountRegex { get; set; }

    /// <summary>Optional. Regex to test the bucket name against. If empty, all buckets match.</summary>
    [JsonPropertyName("bucketNameRegex")]
    public string? BucketNameRegex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexesPatterns
{
    /// <summary>Regex for Amazon S3 buckets.</summary>
    [JsonPropertyName("amazonS3BucketRegex")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexesPatternsAmazonS3BucketRegex? AmazonS3BucketRegex { get; set; }
}

/// <summary>A collection of regular expressions to match a resource against.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexes
{
    /// <summary>A group of regular expression patterns to match against one or more resources. Maximum of 100 entries. The sum of all regular expression&apos;s length can&apos;t exceed 10 KiB.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexesPatterns>? Patterns { get; set; }
}

/// <summary>A collection of resources for this filter to apply to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollection
{
    /// <summary>A collection of regular expressions to match a resource against.</summary>
    [JsonPropertyName("includeRegexes")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollectionIncludeRegexes? IncludeRegexes { get; set; }
}

/// <summary>Optional. Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterOthers
{
}

/// <summary>The AWS account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterSingleResourceAmazonS3BucketAwsAccount
{
    /// <summary>Required. AWS account ID.</summary>
    [JsonPropertyName("accountID")]
    public string? AccountID { get; set; }
}

/// <summary>Amazon S3 bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterSingleResourceAmazonS3Bucket
{
    /// <summary>The AWS account.</summary>
    [JsonPropertyName("awsAccount")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterSingleResourceAmazonS3BucketAwsAccount? AwsAccount { get; set; }

    /// <summary>Required. The bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }
}

/// <summary>The resource to scan. Configs using this filter can only have one target (the target with this single resource reference).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterSingleResource
{
    /// <summary>Amazon S3 bucket.</summary>
    [JsonPropertyName("amazonS3Bucket")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterSingleResourceAmazonS3Bucket? AmazonS3Bucket { get; set; }
}

/// <summary>Required. The resources that the discovery cadence applies to. The first target with a matching filter will be the one to apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilter
{
    /// <summary>A collection of resources for this filter to apply to.</summary>
    [JsonPropertyName("collection")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterCollection? Collection { get; set; }

    /// <summary>Optional. Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
    [JsonPropertyName("others")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterOthers? Others { get; set; }

    /// <summary>The resource to scan. Configs using this filter can only have one target (the target with this single resource reference).</summary>
    [JsonPropertyName("singleResource")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilterSingleResource? SingleResource { get; set; }
}

/// <summary>Optional. Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetGenerationCadenceInspectTemplateModifiedCadence
{
    /// <summary>How frequently data profiles can be updated when the template is modified. Defaults to never.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
}

/// <summary>How often and when to update data profiles. New resources that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetGenerationCadence
{
    /// <summary>Optional. Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to update.</summary>
    [JsonPropertyName("inspectTemplateModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetGenerationCadenceInspectTemplateModifiedCadence? InspectTemplateModifiedCadence { get; set; }

    /// <summary>Optional. Frequency to update profiles regardless of whether the underlying resource has changes. Defaults to never.</summary>
    [JsonPropertyName("refreshFrequency")]
    public string? RefreshFrequency { get; set; }
}

/// <summary>Other clouds target for discovery. The first target to match a resource will be the one applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTarget
{
    /// <summary>Optional. In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
    [JsonPropertyName("conditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetConditions? Conditions { get; set; }

    /// <summary>Required. The type of data profiles generated by this discovery target. Supported values are: * aws/s3/bucket</summary>
    [JsonPropertyName("dataSourceType")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetDataSourceType? DataSourceType { get; set; }

    /// <summary>Disable profiling for resources that match this filter.</summary>
    [JsonPropertyName("disabled")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetDisabled? Disabled { get; set; }

    /// <summary>Required. The resources that the discovery cadence applies to. The first target with a matching filter will be the one to apply to a resource.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetFilter? Filter { get; set; }

    /// <summary>How often and when to update data profiles. New resources that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
    [JsonPropertyName("generationCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTargetGenerationCadence? GenerationCadence { get; set; }
}

/// <summary>Discovery target that looks for credentials and secrets stored in cloud resource metadata and reports them as vulnerabilities to Security Command Center. Only one target of this type is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsSecretsTarget
{
}

/// <summary>In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetConditions
{
    /// <summary>Vertex AI dataset must have been created after this date. Used to avoid backfilling.</summary>
    [JsonPropertyName("createdAfter")]
    public string? CreatedAfter { get; set; }

    /// <summary>Minimum age a Vertex AI dataset must have. If set, the value must be 1 hour or greater.</summary>
    [JsonPropertyName("minAge")]
    public string? MinAge { get; set; }
}

/// <summary>Disable profiling for datasets that match this filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetDisabled
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterCollectionVertexDatasetRegexesPatterns
{
    /// <summary>For organizations, if unset, will match all projects. Has no effect for configurations created within a project.</summary>
    [JsonPropertyName("projectIDRegex")]
    public string? ProjectIDRegex { get; set; }
}

/// <summary>The regex used to filter dataset resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterCollectionVertexDatasetRegexes
{
    /// <summary>Required. The group of regular expression patterns to match against one or more datasets. Maximum of 100 entries. The sum of the lengths of all regular expressions can&apos;t exceed 10 KiB.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterCollectionVertexDatasetRegexesPatterns>? Patterns { get; set; }
}

/// <summary>A specific set of Vertex AI datasets for this filter to apply to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterCollection
{
    /// <summary>The regex used to filter dataset resources.</summary>
    [JsonPropertyName("vertexDatasetRegexes")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterCollectionVertexDatasetRegexes? VertexDatasetRegexes { get; set; }
}

/// <summary>Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterOthers
{
}

/// <summary>The dataset resource to scan. Targets including this can only include one target (the target with this dataset resource reference).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterVertexDatasetResourceReference
{
    /// <summary>Required. The name of the dataset resource. If set within a project-level configuration, the specified resource must be within the project.</summary>
    [JsonPropertyName("datasetResourceName")]
    public string? DatasetResourceName { get; set; }
}

/// <summary>Required. The datasets the discovery cadence applies to. The first target with a matching filter will be the one to apply to a dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilter
{
    /// <summary>A specific set of Vertex AI datasets for this filter to apply to.</summary>
    [JsonPropertyName("collection")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterCollection? Collection { get; set; }

    /// <summary>Catch-all. This should always be the last target in the list because anything above it will apply first. Should only appear once in a configuration. If none is specified, a default one will be added automatically.</summary>
    [JsonPropertyName("others")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterOthers? Others { get; set; }

    /// <summary>The dataset resource to scan. Targets including this can only include one target (the target with this dataset resource reference).</summary>
    [JsonPropertyName("vertexDatasetResourceReference")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilterVertexDatasetResourceReference? VertexDatasetResourceReference { get; set; }
}

/// <summary>Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetGenerationCadenceInspectTemplateModifiedCadence
{
    /// <summary>How frequently data profiles can be updated when the template is modified. Defaults to never.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
}

/// <summary>How often and when to update profiles. New datasets that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetGenerationCadence
{
    /// <summary>Governs when to update data profiles when the inspection rules defined by the `InspectTemplate` change. If not set, changing the template will not cause a data profile to be updated.</summary>
    [JsonPropertyName("inspectTemplateModifiedCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetGenerationCadenceInspectTemplateModifiedCadence? InspectTemplateModifiedCadence { get; set; }

    /// <summary>If you set this field, profiles are refreshed at this frequency regardless of whether the underlying datasets have changed. Defaults to never.</summary>
    [JsonPropertyName("refreshFrequency")]
    public string? RefreshFrequency { get; set; }
}

/// <summary>Vertex AI dataset target for Discovery. The first target to match a dataset will be the one applied. Note that discovery for Vertex AI can incur Cloud Storage Class B operation charges for storage.objects.get operations and retrieval fees. For more information, see [Cloud Storage pricing](https://cloud.google.com/storage/pricing#price-tables). Note that discovery for Vertex AI dataset will not be able to scan images unless DiscoveryConfig.processing_location.image_fallback_location has multi_region_processing or global_processing configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTarget
{
    /// <summary>In addition to matching the filter, these conditions must be true before a profile is generated.</summary>
    [JsonPropertyName("conditions")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetConditions? Conditions { get; set; }

    /// <summary>Disable profiling for datasets that match this filter.</summary>
    [JsonPropertyName("disabled")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetDisabled? Disabled { get; set; }

    /// <summary>Required. The datasets the discovery cadence applies to. The first target with a matching filter will be the one to apply to a dataset.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetFilter? Filter { get; set; }

    /// <summary>How often and when to update profiles. New datasets that match both the filter and conditions are scanned as quickly as possible depending on system capacity.</summary>
    [JsonPropertyName("generationCadence")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTargetGenerationCadence? GenerationCadence { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpecTargets
{
    /// <summary>BigQuery target for Discovery. The first target to match a table will be the one applied.</summary>
    [JsonPropertyName("bigQueryTarget")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsBigQueryTarget? BigQueryTarget { get; set; }

    /// <summary>Cloud SQL target for Discovery. The first target to match a table will be the one applied.</summary>
    [JsonPropertyName("cloudSQLTarget")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudSQLTarget? CloudSQLTarget { get; set; }

    /// <summary>Cloud Storage target for Discovery. The first target to match a table will be the one applied.</summary>
    [JsonPropertyName("cloudStorageTarget")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsCloudStorageTarget? CloudStorageTarget { get; set; }

    /// <summary>Other clouds target for discovery. The first target to match a resource will be the one applied.</summary>
    [JsonPropertyName("otherCloudTarget")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsOtherCloudTarget? OtherCloudTarget { get; set; }

    /// <summary>Discovery target that looks for credentials and secrets stored in cloud resource metadata and reports them as vulnerabilities to Security Command Center. Only one target of this type is allowed.</summary>
    [JsonPropertyName("secretsTarget")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsSecretsTarget? SecretsTarget { get; set; }

    /// <summary>Vertex AI dataset target for Discovery. The first target to match a dataset will be the one applied. Note that discovery for Vertex AI can incur Cloud Storage Class B operation charges for storage.objects.get operations and retrieval fees. For more information, see [Cloud Storage pricing](https://cloud.google.com/storage/pricing#price-tables). Note that discovery for Vertex AI dataset will not be able to scan images unless DiscoveryConfig.processing_location.image_fallback_location has multi_region_processing or global_processing configured.</summary>
    [JsonPropertyName("vertexDatasetTarget")]
    public V1alpha1DLPDiscoveryConfigSpecTargetsVertexDatasetTarget? VertexDatasetTarget { get; set; }
}

/// <summary>DLPDiscoveryConfigSpec defines the desired state of DLPDiscoveryConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigSpec
{
    /// <summary>Actions to execute at the completion of scanning.</summary>
    [JsonPropertyName("actions")]
    public IList<V1alpha1DLPDiscoveryConfigSpecActions>? Actions { get; set; }

    /// <summary>Display name (max 100 chars)</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Detection logic for profile generation.</summary>
    [JsonPropertyName("inspectTemplates")]
    public IList<string>? InspectTemplates { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Only set when the parent is an org.</summary>
    [JsonPropertyName("orgConfig")]
    public V1alpha1DLPDiscoveryConfigSpecOrgConfig? OrgConfig { get; set; }

    /// <summary>Must be set only when scanning other clouds.</summary>
    [JsonPropertyName("otherCloudStartingLocation")]
    public V1alpha1DLPDiscoveryConfigSpecOtherCloudStartingLocation? OtherCloudStartingLocation { get; set; }

    /// <summary>Optional. Processing location configuration. Vertex AI dataset scanning will set processing_location.image_fallback_type to MultiRegionProcessing by default.</summary>
    [JsonPropertyName("processingLocation")]
    public V1alpha1DLPDiscoveryConfigSpecProcessingLocation? ProcessingLocation { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DLPDiscoveryConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DLPDiscoveryConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. A status for this configuration.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Target to match against for determining what to scan and how frequently.</summary>
    [JsonPropertyName("targets")]
    public IList<V1alpha1DLPDiscoveryConfigSpecTargets>? Targets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusConditions
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

/// <summary>Detailed error codes and messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusObservedStateErrorsDetails
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusObservedStateErrors
{
    /// <summary>Detailed error codes and messages.</summary>
    [JsonPropertyName("details")]
    public V1alpha1DLPDiscoveryConfigStatusObservedStateErrorsDetails? Details { get; set; }

    /// <summary>Additional information about the error.</summary>
    [JsonPropertyName("extraInfo")]
    public string? ExtraInfo { get; set; }

    /// <summary>The times the error occurred. List includes the oldest timestamp and the last 9 timestamps.</summary>
    [JsonPropertyName("timestamps")]
    public IList<string>? Timestamps { get; set; }
}

/// <summary>Required. The type of data profiles generated by this discovery target. Supported values are: * aws/s3/bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusObservedStateTargetsOtherCloudTargetDataSourceType
{
    /// <summary>
    /// Output only. An identifying string to the type of resource being profiled.
    ///  Current values:
    /// 
    ///  * google/bigquery/table
    ///  * google/project
    ///  * google/sql/table
    ///  * google/gcs/bucket
    /// </summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }
}

/// <summary>Other clouds target for discovery. The first target to match a resource will be the one applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusObservedStateTargetsOtherCloudTarget
{
    /// <summary>Required. The type of data profiles generated by this discovery target. Supported values are: * aws/s3/bucket</summary>
    [JsonPropertyName("dataSourceType")]
    public V1alpha1DLPDiscoveryConfigStatusObservedStateTargetsOtherCloudTargetDataSourceType? DataSourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusObservedStateTargets
{
    /// <summary>Other clouds target for discovery. The first target to match a resource will be the one applied.</summary>
    [JsonPropertyName("otherCloudTarget")]
    public V1alpha1DLPDiscoveryConfigStatusObservedStateTargetsOtherCloudTarget? OtherCloudTarget { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatusObservedState
{
    /// <summary>Output only. The creation timestamp of a DiscoveryConfig.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. A stream of errors encountered when the config was activated. Repeated errors may result in the config automatically being paused. Output only field. Will return the last 100 errors. Whenever the config is modified this list will be cleared.</summary>
    [JsonPropertyName("errors")]
    public IList<V1alpha1DLPDiscoveryConfigStatusObservedStateErrors>? Errors { get; set; }

    /// <summary>Output only. The timestamp of the last time this config was executed.</summary>
    [JsonPropertyName("lastRunTime")]
    public string? LastRunTime { get; set; }

    /// <summary>Target to match against for determining what to scan and how frequently.</summary>
    [JsonPropertyName("targets")]
    public IList<V1alpha1DLPDiscoveryConfigStatusObservedStateTargets>? Targets { get; set; }

    /// <summary>Output only. The last update timestamp of a DiscoveryConfig.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DLPDiscoveryConfigStatus defines the config connector machine state of DLPDiscoveryConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPDiscoveryConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DLPDiscoveryConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DLPDiscoveryConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DLPDiscoveryConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>DLPDiscoveryConfig is the Schema for the DLPDiscoveryConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DLPDiscoveryConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DLPDiscoveryConfigSpec>, IStatus<V1alpha1DLPDiscoveryConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DLPDiscoveryConfig";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpdiscoveryconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dlp.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DLPDiscoveryConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DLPDiscoveryConfigSpec defines the desired state of DLPDiscoveryConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DLPDiscoveryConfigSpec Spec { get; set; }

    /// <summary>DLPDiscoveryConfigStatus defines the config connector machine state of DLPDiscoveryConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1DLPDiscoveryConfigStatus? Status { get; set; }
}