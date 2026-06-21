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
/// <summary>DataplexDataScan is the Schema for the DataplexDataScan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexDataScanList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexDataScan>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexDataScanList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexdatascans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataplexDataScanList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataplexDataScan objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataplexDataScan> Items { get; set; }
}

/// <summary>Immutable. The Dataplex entity that represents the data source (e.g. BigQuery table) for DataScan, of the form: `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataEntityRef
{
    /// <summary>A reference to an externally managed Dataplex Entity. Should be of the format `projects/{projectID}/locations/{location}/lakes/{lakeID}/zones/{zoneID}/entities/{entityID}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }
}

/// <summary>Required. The data source for DataScan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecData
{
    /// <summary>Immutable. The Dataplex entity that represents the data source (e.g. BigQuery table) for DataScan, of the form: `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.</summary>
    [JsonPropertyName("entityRef")]
    public V1alpha1DataplexDataScanSpecDataEntityRef? EntityRef { get; set; }

    /// <summary>Immutable. The service-qualified full resource name of the cloud resource for a DataScan job to scan against. The field could be: BigQuery table of type &quot;TABLE&quot; for DataProfileScan/DataQualityScan Format: //bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Optional. The BigQuery connection used to create BigLake tables. Must be in the form `projects/{project_id}/locations/{location_id}/connections/{connection_id}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataDiscoverySpecBigqueryPublishingConfigConnectionRef
{
    /// <summary>A reference to an externally managed BigQuery Connection. Should be of the format `projects/{projectID}/locations/{location}/connections/{connectionID}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `BigQueryConnectionConnection` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `BigQueryConnectionConnection` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for metadata publishing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataDiscoverySpecBigqueryPublishingConfig
{
    /// <summary>Optional. The BigQuery connection used to create BigLake tables. Must be in the form `projects/{project_id}/locations/{location_id}/connections/{connection_id}`</summary>
    [JsonPropertyName("connectionRef")]
    public V1alpha1DataplexDataScanSpecDataDiscoverySpecBigqueryPublishingConfigConnectionRef? ConnectionRef { get; set; }

    /// <summary>Optional. Determines whether to  publish discovered tables as BigLake external tables or non-BigLake external tables.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataDiscoverySpecStorageConfigCsvOptions
{
    /// <summary>Optional. The delimiter that is used to separate values. The default is `,` (comma).</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.</summary>
    [JsonPropertyName("headerRows")]
    public int? HeaderRows { get; set; }

    /// <summary>Optional. The character used to quote column values. Accepts `&quot;` (double quotation mark) or `&apos;` (single quotation mark). If unspecified, defaults to `&quot;` (double quotation mark).</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>Optional. Whether to disable the inference of data types for CSV data. If true, all columns are registered as strings.</summary>
    [JsonPropertyName("typeInferenceDisabled")]
    public bool? TypeInferenceDisabled { get; set; }
}

/// <summary>Optional. Configuration for JSON data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataDiscoverySpecStorageConfigJsonOptions
{
    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Optional. Whether to disable the inference of data types for JSON data. If true, all columns are registered as their primitive types (strings, number, or boolean).</summary>
    [JsonPropertyName("typeInferenceDisabled")]
    public bool? TypeInferenceDisabled { get; set; }
}

/// <summary>Cloud Storage related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataDiscoverySpecStorageConfig
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1alpha1DataplexDataScanSpecDataDiscoverySpecStorageConfigCsvOptions? CsvOptions { get; set; }

    /// <summary>Optional. Defines the data to exclude during discovery. Provide a list of patterns that identify the data to exclude. For Cloud Storage bucket assets, these patterns are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these patterns are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("excludePatterns")]
    public IList<string>? ExcludePatterns { get; set; }

    /// <summary>Optional. Defines the data to include during discovery when only a subset of the data should be considered. Provide a list of patterns that identify the data to include. For Cloud Storage bucket assets, these patterns are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these patterns are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("includePatterns")]
    public IList<string>? IncludePatterns { get; set; }

    /// <summary>Optional. Configuration for JSON data.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1alpha1DataplexDataScanSpecDataDiscoverySpecStorageConfigJsonOptions? JsonOptions { get; set; }
}

/// <summary>Settings for a data discovery scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataDiscoverySpec
{
    /// <summary>Optional. Configuration for metadata publishing.</summary>
    [JsonPropertyName("bigqueryPublishingConfig")]
    public V1alpha1DataplexDataScanSpecDataDiscoverySpecBigqueryPublishingConfig? BigqueryPublishingConfig { get; set; }

    /// <summary>Cloud Storage related configurations.</summary>
    [JsonPropertyName("storageConfig")]
    public V1alpha1DataplexDataScanSpecDataDiscoverySpecStorageConfig? StorageConfig { get; set; }
}

/// <summary>
/// Optional. The fields to exclude from data profile.
/// 
///  If specified, the fields will be excluded from data profile, regardless of
///  `include_fields` value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataProfileSpecExcludeFields
{
    /// <summary>
    /// Optional. Expected input is a list of fully qualified names of fields as
    ///  in the schema.
    /// 
    ///  Only top-level field names for nested fields are supported.
    ///  For instance, if &apos;x&apos; is of nested field type, listing &apos;x&apos; is supported
    ///  but &apos;x.y.z&apos; is not supported. Here &apos;y&apos; and &apos;y.z&apos; are nested fields of
    ///  &apos;x&apos;.
    /// </summary>
    [JsonPropertyName("fieldNames")]
    public IList<string>? FieldNames { get; set; }
}

/// <summary>
/// Optional. The fields to include in data profile.
/// 
///  If not specified, all fields at the time of profile scan job execution are
///  included, except for ones listed in `exclude_fields`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataProfileSpecIncludeFields
{
    /// <summary>
    /// Optional. Expected input is a list of fully qualified names of fields as
    ///  in the schema.
    /// 
    ///  Only top-level field names for nested fields are supported.
    ///  For instance, if &apos;x&apos; is of nested field type, listing &apos;x&apos; is supported
    ///  but &apos;x.y.z&apos; is not supported. Here &apos;y&apos; and &apos;y.z&apos; are nested fields of
    ///  &apos;x&apos;.
    /// </summary>
    [JsonPropertyName("fieldNames")]
    public IList<string>? FieldNames { get; set; }
}

/// <summary>Optional. The BigQuery table to export DataProfileScan results to. Format: //bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID or projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataProfileSpecPostScanActionsBigqueryExportResultsTableRef
{
    /// <summary>A reference to an externally managed BigQuery Table. Should be of the format `//bigquery.googleapis.com/projects/{projectID}/datasets/{datasetID}/tables/{tableID}` or `projects/{projectID}/datasets/{datasetID}/tables/{tableID}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. If set, results will be exported to the provided BigQuery table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataProfileSpecPostScanActionsBigqueryExport
{
    /// <summary>Optional. The BigQuery table to export DataProfileScan results to. Format: //bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID or projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID</summary>
    [JsonPropertyName("resultsTableRef")]
    public V1alpha1DataplexDataScanSpecDataProfileSpecPostScanActionsBigqueryExportResultsTableRef? ResultsTableRef { get; set; }
}

/// <summary>Optional. Actions to take upon job completion..</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataProfileSpecPostScanActions
{
    /// <summary>Optional. If set, results will be exported to the provided BigQuery table.</summary>
    [JsonPropertyName("bigqueryExport")]
    public V1alpha1DataplexDataScanSpecDataProfileSpecPostScanActionsBigqueryExport? BigqueryExport { get; set; }
}

/// <summary>Settings for a data profile scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataProfileSpec
{
    /// <summary>
    /// Optional. The fields to exclude from data profile.
    /// 
    ///  If specified, the fields will be excluded from data profile, regardless of
    ///  `include_fields` value.
    /// </summary>
    [JsonPropertyName("excludeFields")]
    public V1alpha1DataplexDataScanSpecDataProfileSpecExcludeFields? ExcludeFields { get; set; }

    /// <summary>
    /// Optional. The fields to include in data profile.
    /// 
    ///  If not specified, all fields at the time of profile scan job execution are
    ///  included, except for ones listed in `exclude_fields`.
    /// </summary>
    [JsonPropertyName("includeFields")]
    public V1alpha1DataplexDataScanSpecDataProfileSpecIncludeFields? IncludeFields { get; set; }

    /// <summary>Optional. Actions to take upon job completion..</summary>
    [JsonPropertyName("postScanActions")]
    public V1alpha1DataplexDataScanSpecDataProfileSpecPostScanActions? PostScanActions { get; set; }

    /// <summary>
    /// Optional. A filter applied to all rows in a single DataScan job.
    ///  The filter needs to be a valid SQL expression for a [WHERE clause in
    ///  GoogleSQL
    ///  syntax](https://cloud.google.com/bigquery/docs/reference/standard-sql/query-syntax#where_clause).
    /// 
    ///  Example: col1 &gt;= 0 AND col2 &lt; 10
    /// </summary>
    [JsonPropertyName("rowFilter")]
    public string? RowFilter { get; set; }

    /// <summary>
    /// Optional. The percentage of the records to be selected from the dataset for
    ///  DataScan.
    /// 
    ///  * Value can range between 0.0 and 100.0 with up to 3 significant decimal
    ///  digits.
    ///  * Sampling is not applied if `sampling_percent` is not specified, 0 or
    ///  100.
    /// </summary>
    [JsonPropertyName("samplingPercent")]
    public double? SamplingPercent { get; set; }
}

/// <summary>Optional. The BigQuery table to export DataQualityScan results to. Format: //bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID or projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsBigqueryExportResultsTableRef
{
    /// <summary>A reference to an externally managed BigQuery Table. Should be of the format `//bigquery.googleapis.com/projects/{projectID}/datasets/{datasetID}/tables/{tableID}` or `projects/{projectID}/datasets/{datasetID}/tables/{tableID}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. If set, results will be exported to the provided BigQuery table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsBigqueryExport
{
    /// <summary>Optional. The BigQuery table to export DataQualityScan results to. Format: //bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID or projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID</summary>
    [JsonPropertyName("resultsTableRef")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsBigqueryExportResultsTableRef? ResultsTableRef { get; set; }
}

/// <summary>Required. The recipients who will receive the notification report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsNotificationReportRecipients
{
    /// <summary>Optional. The email recipients who will receive the DataQualityScan results report.</summary>
    [JsonPropertyName("emails")]
    public IList<string>? Emails { get; set; }
}

/// <summary>Optional. If set, report will be sent when score threshold is met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsNotificationReportScoreThresholdTrigger
{
    /// <summary>Optional. The score range is in [0,100].</summary>
    [JsonPropertyName("scoreThreshold")]
    public double? ScoreThreshold { get; set; }
}

/// <summary>Optional. If set, results will be sent to the provided notification receipts upon triggers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsNotificationReport
{
    /// <summary>Optional. If set, report will be sent when a scan job ends.</summary>
    [JsonPropertyName("jobEndTrigger")]
    public JsonNode? JobEndTrigger { get; set; }

    /// <summary>Optional. If set, report will be sent when a scan job fails.</summary>
    [JsonPropertyName("jobFailureTrigger")]
    public JsonNode? JobFailureTrigger { get; set; }

    /// <summary>Required. The recipients who will receive the notification report.</summary>
    [JsonPropertyName("recipients")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsNotificationReportRecipients? Recipients { get; set; }

    /// <summary>Optional. If set, report will be sent when score threshold is met.</summary>
    [JsonPropertyName("scoreThresholdTrigger")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsNotificationReportScoreThresholdTrigger? ScoreThresholdTrigger { get; set; }
}

/// <summary>Optional. Actions to take upon job completion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActions
{
    /// <summary>Optional. If set, results will be exported to the provided BigQuery table.</summary>
    [JsonPropertyName("bigqueryExport")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsBigqueryExport? BigqueryExport { get; set; }

    /// <summary>Optional. If set, results will be sent to the provided notification receipts upon triggers.</summary>
    [JsonPropertyName("notificationReport")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActionsNotificationReport? NotificationReport { get; set; }
}

/// <summary>Row-level rule which evaluates whether each column value lies between a specified range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesRangeExpectation
{
    /// <summary>Optional. The maximum column value allowed for a row to pass this validation. At least one of `min_value` and `max_value` need to be provided.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Optional. The minimum column value allowed for a row to pass this validation. At least one of `min_value` and `max_value` need to be provided.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    /// <summary>
    /// Optional. Whether each value needs to be strictly lesser than (&apos; &lt; &apos;) the
    ///  maximum, or if equality is allowed.
    /// 
    ///  Only relevant if a `max_value` has been defined. Default = false.
    /// </summary>
    [JsonPropertyName("strictMaxEnabled")]
    public bool? StrictMaxEnabled { get; set; }

    /// <summary>
    /// Optional. Whether each value needs to be strictly greater than (&apos; &gt; &apos;) the
    ///  minimum, or if equality is allowed.
    /// 
    ///  Only relevant if a `min_value` has been defined. Default = false.
    /// </summary>
    [JsonPropertyName("strictMinEnabled")]
    public bool? StrictMinEnabled { get; set; }
}

/// <summary>Row-level rule which evaluates whether each column value matches a specified regex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesRegexExpectation
{
    /// <summary>Optional. A regular expression the column value is expected to match.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Row-level rule which evaluates whether each row in a table passes the specified condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesRowConditionExpectation
{
    /// <summary>Optional. The SQL expression.</summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>Row-level rule which evaluates whether each column value is contained by a specified set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesSetExpectation
{
    /// <summary>Optional. Expected values for the column value.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Aggregate rule which evaluates the number of rows returned for the provided statement. If any rows are returned, this rule fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesSqlAssertion
{
    /// <summary>Optional. The SQL statement.</summary>
    [JsonPropertyName("sqlStatement")]
    public string? SqlStatement { get; set; }
}

/// <summary>Aggregate rule which evaluates whether the column aggregate statistic lies between a specified range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesStatisticRangeExpectation
{
    /// <summary>
    /// Optional. The maximum column statistic value allowed for a row to pass
    ///  this validation.
    /// 
    ///  At least one of `min_value` and `max_value` need to be provided.
    /// </summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>
    /// Optional. The minimum column statistic value allowed for a row to pass
    ///  this validation.
    /// 
    ///  At least one of `min_value` and `max_value` need to be provided.
    /// </summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    /// <summary>Optional. The aggregate metric to evaluate.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>
    /// Optional. Whether column statistic needs to be strictly lesser than (&apos; &lt; &apos;)
    ///  the maximum, or if equality is allowed.
    /// 
    ///  Only relevant if a `max_value` has been defined. Default = false.
    /// </summary>
    [JsonPropertyName("strictMaxEnabled")]
    public bool? StrictMaxEnabled { get; set; }

    /// <summary>
    /// Optional. Whether column statistic needs to be strictly greater than
    ///  (&apos; &gt; &apos;) the minimum, or if equality is allowed.
    /// 
    ///  Only relevant if a `min_value` has been defined. Default = false.
    /// </summary>
    [JsonPropertyName("strictMinEnabled")]
    public bool? StrictMinEnabled { get; set; }
}

/// <summary>Aggregate rule which evaluates whether the provided expression is true for a table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRulesTableConditionExpectation
{
    /// <summary>Optional. The SQL expression.</summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpecRules
{
    /// <summary>Optional. The unnested column which this rule is evaluated against.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// Optional. Description of the rule.
    /// 
    ///  * The maximum length is 1,024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The dimension a rule belongs to. Results are also aggregated at the dimension level. Supported dimensions are **[&quot;COMPLETENESS&quot;, &quot;ACCURACY&quot;, &quot;CONSISTENCY&quot;, &quot;VALIDITY&quot;, &quot;UNIQUENESS&quot;, &quot;FRESHNESS&quot;, &quot;VOLUME&quot;]**</summary>
    [JsonPropertyName("dimension")]
    public string? Dimension { get; set; }

    /// <summary>
    /// Optional. Rows with `null` values will automatically fail a rule, unless
    ///  `ignore_null` is `true`. In that case, such `null` rows are trivially
    ///  considered passing.
    /// 
    ///  This field is only valid for the following type of rules:
    /// 
    ///  * RangeExpectation
    ///  * RegexExpectation
    ///  * SetExpectation
    ///  * UniquenessExpectation
    /// </summary>
    [JsonPropertyName("ignoreNull")]
    public bool? IgnoreNull { get; set; }

    /// <summary>
    /// Optional. A mutable name for the rule.
    /// 
    ///  * The name must contain only letters (a-z, A-Z), numbers (0-9), or
    ///  hyphens (-).
    ///  * The maximum length is 63 characters.
    ///  * Must start with a letter.
    ///  * Must end with a number or a letter.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Row-level rule which evaluates whether each column value is null.</summary>
    [JsonPropertyName("nonNullExpectation")]
    public JsonNode? NonNullExpectation { get; set; }

    /// <summary>Row-level rule which evaluates whether each column value lies between a specified range.</summary>
    [JsonPropertyName("rangeExpectation")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesRangeExpectation? RangeExpectation { get; set; }

    /// <summary>Row-level rule which evaluates whether each column value matches a specified regex.</summary>
    [JsonPropertyName("regexExpectation")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesRegexExpectation? RegexExpectation { get; set; }

    /// <summary>Row-level rule which evaluates whether each row in a table passes the specified condition.</summary>
    [JsonPropertyName("rowConditionExpectation")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesRowConditionExpectation? RowConditionExpectation { get; set; }

    /// <summary>Row-level rule which evaluates whether each column value is contained by a specified set.</summary>
    [JsonPropertyName("setExpectation")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesSetExpectation? SetExpectation { get; set; }

    /// <summary>Aggregate rule which evaluates the number of rows returned for the provided statement. If any rows are returned, this rule fails.</summary>
    [JsonPropertyName("sqlAssertion")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesSqlAssertion? SqlAssertion { get; set; }

    /// <summary>Aggregate rule which evaluates whether the column aggregate statistic lies between a specified range.</summary>
    [JsonPropertyName("statisticRangeExpectation")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesStatisticRangeExpectation? StatisticRangeExpectation { get; set; }

    /// <summary>Optional. Whether the Rule is active or suspended. Default is false.</summary>
    [JsonPropertyName("suspended")]
    public bool? Suspended { get; set; }

    /// <summary>Aggregate rule which evaluates whether the provided expression is true for a table.</summary>
    [JsonPropertyName("tableConditionExpectation")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecRulesTableConditionExpectation? TableConditionExpectation { get; set; }

    /// <summary>
    /// Optional. The minimum ratio of **passing_rows / total_rows** required to
    ///  pass this rule, with a range of [0.0, 1.0].
    /// 
    ///  0 indicates default value (i.e. 1.0).
    /// 
    ///  This field is only valid for row-level type rules.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Row-level rule which evaluates whether each column value is unique.</summary>
    [JsonPropertyName("uniquenessExpectation")]
    public JsonNode? UniquenessExpectation { get; set; }
}

/// <summary>Settings for a data quality scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecDataQualitySpec
{
    /// <summary>Optional. Actions to take upon job completion.</summary>
    [JsonPropertyName("postScanActions")]
    public V1alpha1DataplexDataScanSpecDataQualitySpecPostScanActions? PostScanActions { get; set; }

    /// <summary>
    /// Optional. A filter applied to all rows in a single DataScan job.
    ///  The filter needs to be a valid SQL expression for a [WHERE clause in
    ///  GoogleSQL
    ///  syntax](https://cloud.google.com/bigquery/docs/reference/standard-sql/query-syntax#where_clause).
    /// 
    ///  Example: col1 &gt;= 0 AND col2 &lt; 10
    /// </summary>
    [JsonPropertyName("rowFilter")]
    public string? RowFilter { get; set; }

    /// <summary>Required. The list of rules to evaluate against a data source. At least one rule is required.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1DataplexDataScanSpecDataQualitySpecRules>? Rules { get; set; }

    /// <summary>
    /// Optional. The percentage of the records to be selected from the dataset for
    ///  DataScan.
    /// 
    ///  * Value can range between 0.0 and 100.0 with up to 3 significant decimal
    ///  digits.
    ///  * Sampling is not applied if `sampling_percent` is not specified, 0 or
    ///  100.
    /// </summary>
    [JsonPropertyName("samplingPercent")]
    public double? SamplingPercent { get; set; }
}

/// <summary>The scan is scheduled to run periodically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecExecutionSpecTriggerSchedule
{
    /// <summary>
    /// Required. [Cron](https://en.wikipedia.org/wiki/Cron) schedule for running
    ///  scans periodically.
    /// 
    ///  To explicitly set a timezone in the cron tab, apply a prefix in the
    ///  cron tab: **&quot;CRON_TZ=${IANA_TIME_ZONE}&quot;** or **&quot;TZ=${IANA_TIME_ZONE}&quot;**.
    ///  The **${IANA_TIME_ZONE}** may only be a valid string from IANA time zone
    ///  database
    ///  ([wikipedia](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#List)).
    ///  For example, `CRON_TZ=America/New_York 1 * * * *`, or
    ///  `TZ=America/New_York 1 * * * *`.
    /// 
    ///  This field is required for Schedule scans.
    /// </summary>
    [JsonPropertyName("cron")]
    public string? Cron { get; set; }
}

/// <summary>
/// Optional. Spec related to how often and when a scan should be triggered.
/// 
///  If not specified, the default is `OnDemand`, which means the scan will
///  not run until the user calls `RunDataScan` API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecExecutionSpecTrigger
{
    /// <summary>The scan runs once via `RunDataScan` API.</summary>
    [JsonPropertyName("onDemand")]
    public JsonNode? OnDemand { get; set; }

    /// <summary>The scan is scheduled to run periodically.</summary>
    [JsonPropertyName("schedule")]
    public V1alpha1DataplexDataScanSpecExecutionSpecTriggerSchedule? Schedule { get; set; }
}

/// <summary>
/// Optional. DataScan execution settings.
/// 
/// If not specified, the fields in it will use their default values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecExecutionSpec
{
    /// <summary>
    /// Immutable. The unnested field (of type *Date* or *Timestamp*) that
    ///  contains values which monotonically increase over time.
    /// 
    ///  If not specified, a data scan will run for all data in the table.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>
    /// Optional. Spec related to how often and when a scan should be triggered.
    /// 
    ///  If not specified, the default is `OnDemand`, which means the scan will
    ///  not run until the user calls `RunDataScan` API.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1alpha1DataplexDataScanSpecExecutionSpecTrigger? Trigger { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpecProjectRef
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

/// <summary>DataplexDataScanSpec defines the desired state of DataplexDataScan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanSpec
{
    /// <summary>Required. The data source for DataScan.</summary>
    [JsonPropertyName("data")]
    public required V1alpha1DataplexDataScanSpecData Data { get; set; }

    /// <summary>Settings for a data discovery scan.</summary>
    [JsonPropertyName("dataDiscoverySpec")]
    public V1alpha1DataplexDataScanSpecDataDiscoverySpec? DataDiscoverySpec { get; set; }

    /// <summary>Settings for a data profile scan.</summary>
    [JsonPropertyName("dataProfileSpec")]
    public V1alpha1DataplexDataScanSpecDataProfileSpec? DataProfileSpec { get; set; }

    /// <summary>Settings for a data quality scan.</summary>
    [JsonPropertyName("dataQualitySpec")]
    public V1alpha1DataplexDataScanSpecDataQualitySpec? DataQualitySpec { get; set; }

    /// <summary>
    /// Optional. Description of the scan.
    /// 
    /// * Must be between 1-1024 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Optional. User friendly display name.
    /// 
    /// * Must be between 1-256 characters.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Optional. DataScan execution settings.
    /// 
    /// If not specified, the fields in it will use their default values.
    /// </summary>
    [JsonPropertyName("executionSpec")]
    public V1alpha1DataplexDataScanSpecExecutionSpec? ExecutionSpec { get; set; }

    /// <summary>Optional. User-defined labels for the scan.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataplexDataScanSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataplexDataScan name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusConditions
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

/// <summary>Output only. Describes result statistics of a data scan discovery job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataDiscoveryResultScanStatistics
{
    /// <summary>The data processed in bytes.</summary>
    [JsonPropertyName("dataProcessedBytes")]
    public long? DataProcessedBytes { get; set; }

    /// <summary>The number of files excluded.</summary>
    [JsonPropertyName("filesExcluded")]
    public int? FilesExcluded { get; set; }

    /// <summary>The number of filesets created.</summary>
    [JsonPropertyName("filesetsCreated")]
    public int? FilesetsCreated { get; set; }

    /// <summary>The number of filesets deleted.</summary>
    [JsonPropertyName("filesetsDeleted")]
    public int? FilesetsDeleted { get; set; }

    /// <summary>The number of filesets updated.</summary>
    [JsonPropertyName("filesetsUpdated")]
    public int? FilesetsUpdated { get; set; }

    /// <summary>The number of files scanned.</summary>
    [JsonPropertyName("scannedFileCount")]
    public int? ScannedFileCount { get; set; }

    /// <summary>The number of tables created.</summary>
    [JsonPropertyName("tablesCreated")]
    public int? TablesCreated { get; set; }

    /// <summary>The number of tables deleted.</summary>
    [JsonPropertyName("tablesDeleted")]
    public int? TablesDeleted { get; set; }

    /// <summary>The number of tables updated.</summary>
    [JsonPropertyName("tablesUpdated")]
    public int? TablesUpdated { get; set; }
}

/// <summary>Output only. The result of a data discovery scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataDiscoveryResult
{
    /// <summary>Output only. Configuration for metadata publishing.</summary>
    [JsonPropertyName("bigqueryPublishing")]
    public JsonNode? BigqueryPublishing { get; set; }

    /// <summary>Output only. Describes result statistics of a data scan discovery job.</summary>
    [JsonPropertyName("scanStatistics")]
    public V1alpha1DataplexDataScanStatusObservedStateDataDiscoveryResultScanStatistics? ScanStatistics { get; set; }
}

/// <summary>Double type field information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileDoubleProfile
{
    /// <summary>Average of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("average")]
    public double? Average { get; set; }

    /// <summary>Maximum of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>A quartile divides the number of data points into four parts, or quarters, of more-or-less equal size. Three main quartiles used are: The first quartile (Q1) splits off the lowest 25% of data from the highest 75%. It is also known as the lower or 25th empirical quartile, as 25% of the data is below this point. The second quartile (Q2) is the median of a data set. So, 50% of the data lies below this point. The third quartile (Q3) splits off the highest 25% of data from the lowest 75%. It is known as the upper or 75th empirical quartile, as 75% of the data lies below this point. Here, the quartiles is provided as an ordered list of quartile values for the scanned data, occurring in order Q1, median, Q3.</summary>
    [JsonPropertyName("quartiles")]
    public IList<double>? Quartiles { get; set; }

    /// <summary>Standard deviation of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("standardDeviation")]
    public double? StandardDeviation { get; set; }
}

/// <summary>Integer type field information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileIntegerProfile
{
    /// <summary>Average of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("average")]
    public double? Average { get; set; }

    /// <summary>Maximum of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    /// <summary>Minimum of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("min")]
    public long? Min { get; set; }

    /// <summary>A quartile divides the number of data points into four parts, or quarters, of more-or-less equal size. Three main quartiles used are: The first quartile (Q1) splits off the lowest 25% of data from the highest 75%. It is also known as the lower or 25th empirical quartile, as 25% of the data is below this point. The second quartile (Q2) is the median of a data set. So, 50% of the data lies below this point. The third quartile (Q3) splits off the highest 25% of data from the lowest 75%. It is known as the upper or 75th empirical quartile, as 75% of the data lies below this point. Here, the quartiles is provided as an ordered list of approximate quartile values for the scanned data, occurring in order Q1, median, Q3.</summary>
    [JsonPropertyName("quartiles")]
    public IList<long>? Quartiles { get; set; }

    /// <summary>Standard deviation of non-null values in the scanned data. NaN, if the field has a NaN.</summary>
    [JsonPropertyName("standardDeviation")]
    public double? StandardDeviation { get; set; }
}

/// <summary>String type field information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileStringProfile
{
    /// <summary>Average length of non-null values in the scanned data.</summary>
    [JsonPropertyName("averageLength")]
    public double? AverageLength { get; set; }

    /// <summary>Maximum length of non-null values in the scanned data.</summary>
    [JsonPropertyName("maxLength")]
    public long? MaxLength { get; set; }

    /// <summary>Minimum length of non-null values in the scanned data.</summary>
    [JsonPropertyName("minLength")]
    public long? MinLength { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileTopNValues
{
    /// <summary>Count of the corresponding value in the scanned data.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Ratio of the corresponding value in the field against the total number of rows in the scanned data.</summary>
    [JsonPropertyName("ratio")]
    public double? Ratio { get; set; }

    /// <summary>String value of a top N non-null value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Profile information for the corresponding field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfile
{
    /// <summary>Ratio of rows with distinct values against total scanned rows. Not available for complex non-groupable field type, including RECORD, ARRAY, GEOGRAPHY, and JSON, as well as fields with REPEATABLE mode.</summary>
    [JsonPropertyName("distinctRatio")]
    public double? DistinctRatio { get; set; }

    /// <summary>Double type field information.</summary>
    [JsonPropertyName("doubleProfile")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileDoubleProfile? DoubleProfile { get; set; }

    /// <summary>Integer type field information.</summary>
    [JsonPropertyName("integerProfile")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileIntegerProfile? IntegerProfile { get; set; }

    /// <summary>Ratio of rows with null value against total scanned rows.</summary>
    [JsonPropertyName("nullRatio")]
    public double? NullRatio { get; set; }

    /// <summary>String type field information.</summary>
    [JsonPropertyName("stringProfile")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileStringProfile? StringProfile { get; set; }

    /// <summary>The list of top N non-null values, frequency and ratio with which they occur in the scanned data. N is 10 or equal to the number of distinct values in the field, whichever is smaller. Not available for complex non-groupable field type, including RECORD, ARRAY, GEOGRAPHY, and JSON, as well as fields with REPEATABLE mode.</summary>
    [JsonPropertyName("topNValues")]
    public IList<V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfileTopNValues>? TopNValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFields
{
    /// <summary>
    /// The mode of the field. Possible values include:
    /// 
    ///  * REQUIRED, if it is a required field.
    ///  * NULLABLE, if it is an optional field.
    ///  * REPEATED, if it is a repeated field.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Profile information for the corresponding field.</summary>
    [JsonPropertyName("profile")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFieldsProfile? Profile { get; set; }

    /// <summary>The data type retrieved from the schema of the data source. For instance, for a BigQuery native table, it is the [BigQuery Table Schema](https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#tablefieldschema). For a Dataplex Entity, it is the [Entity Schema](https://cloud.google.com/dataplex/docs/reference/rpc/google.cloud.dataplex.v1#type_3).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The profile information per field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfile
{
    /// <summary>List of fields with structural and profile information for each field.</summary>
    [JsonPropertyName("fields")]
    public IList<V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfileFields>? Fields { get; set; }
}

/// <summary>The range denoted by values of an incremental field</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultScannedDataIncrementalField
{
    /// <summary>Value that marks the end of the range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The field that contains values which monotonically increases over time (e.g. a timestamp column).</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Value that marks the start of the range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>The data scanned for this result.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResultScannedData
{
    /// <summary>The range denoted by values of an incremental field</summary>
    [JsonPropertyName("incrementalField")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultScannedDataIncrementalField? IncrementalField { get; set; }
}

/// <summary>Output only. The result of a data profile scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataProfileResult
{
    /// <summary>Output only. The result of post scan actions.</summary>
    [JsonPropertyName("postScanActionsResult")]
    public JsonNode? PostScanActionsResult { get; set; }

    /// <summary>The profile information per field.</summary>
    [JsonPropertyName("profile")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultProfile? Profile { get; set; }

    /// <summary>The count of rows scanned.</summary>
    [JsonPropertyName("rowCount")]
    public long? RowCount { get; set; }

    /// <summary>The data scanned for this result.</summary>
    [JsonPropertyName("scannedData")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResultScannedData? ScannedData { get; set; }
}

/// <summary>The range denoted by values of an incremental field</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataQualityResultScannedDataIncrementalField
{
    /// <summary>Value that marks the end of the range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The field that contains values which monotonically increases over time (e.g. a timestamp column).</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Value that marks the start of the range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>Output only. The data scanned for this result.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataQualityResultScannedData
{
    /// <summary>The range denoted by values of an incremental field</summary>
    [JsonPropertyName("incrementalField")]
    public V1alpha1DataplexDataScanStatusObservedStateDataQualityResultScannedDataIncrementalField? IncrementalField { get; set; }
}

/// <summary>Output only. The result of a data quality scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateDataQualityResult
{
    /// <summary>
    /// Output only. A list of results at the column level.
    /// 
    ///  A column will have a corresponding `DataQualityColumnResult` if and only if
    ///  there is at least one rule with the &apos;column&apos; field set to it.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<JsonNode>? Columns { get; set; }

    /// <summary>
    /// Output only. A list of results at the dimension level.
    /// 
    ///  A dimension will have a corresponding `DataQualityDimensionResult` if and
    ///  only if there is at least one rule with the &apos;dimension&apos; field set to it.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public IList<JsonNode>? Dimensions { get; set; }

    /// <summary>Output only. Overall data quality result -- `true` if all rules passed.</summary>
    [JsonPropertyName("passed")]
    public bool? Passed { get; set; }

    /// <summary>Output only. The result of post scan actions.</summary>
    [JsonPropertyName("postScanActionsResult")]
    public JsonNode? PostScanActionsResult { get; set; }

    /// <summary>Output only. The count of rows processed.</summary>
    [JsonPropertyName("rowCount")]
    public long? RowCount { get; set; }

    /// <summary>Output only. A list of all the rules in a job, and their results.</summary>
    [JsonPropertyName("rules")]
    public IList<JsonNode>? Rules { get; set; }

    /// <summary>Output only. The data scanned for this result.</summary>
    [JsonPropertyName("scannedData")]
    public V1alpha1DataplexDataScanStatusObservedStateDataQualityResultScannedData? ScannedData { get; set; }

    /// <summary>
    /// Output only. The overall data quality score.
    /// 
    ///  The score ranges between [0, 100] (up to two decimal points).
    /// </summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

/// <summary>Output only. Status of the data scan execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedStateExecutionStatus
{
    /// <summary>Optional. The time when the DataScanJob execution was created.</summary>
    [JsonPropertyName("latestJobCreateTime")]
    public string? LatestJobCreateTime { get; set; }

    /// <summary>Optional. The time when the latest DataScanJob ended.</summary>
    [JsonPropertyName("latestJobEndTime")]
    public string? LatestJobEndTime { get; set; }

    /// <summary>Optional. The time when the latest DataScanJob started.</summary>
    [JsonPropertyName("latestJobStartTime")]
    public string? LatestJobStartTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatusObservedState
{
    /// <summary>Output only. The time when the scan was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The result of a data discovery scan.</summary>
    [JsonPropertyName("dataDiscoveryResult")]
    public V1alpha1DataplexDataScanStatusObservedStateDataDiscoveryResult? DataDiscoveryResult { get; set; }

    /// <summary>Output only. The result of a data profile scan.</summary>
    [JsonPropertyName("dataProfileResult")]
    public V1alpha1DataplexDataScanStatusObservedStateDataProfileResult? DataProfileResult { get; set; }

    /// <summary>Output only. The result of a data quality scan.</summary>
    [JsonPropertyName("dataQualityResult")]
    public V1alpha1DataplexDataScanStatusObservedStateDataQualityResult? DataQualityResult { get; set; }

    /// <summary>Output only. Status of the data scan execution.</summary>
    [JsonPropertyName("executionStatus")]
    public V1alpha1DataplexDataScanStatusObservedStateExecutionStatus? ExecutionStatus { get; set; }

    /// <summary>Output only. Current state of the DataScan.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The type of DataScan.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Output only. System generated globally unique ID for the scan. This ID will be different if the scan is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the scan was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataplexDataScanStatus defines the config connector machine state of DataplexDataScan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexDataScanStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexDataScanStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexDataScan resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexDataScanStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataplexDataScan is the Schema for the DataplexDataScan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexDataScan : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexDataScanSpec>, IStatus<V1alpha1DataplexDataScanStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexDataScan";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexdatascans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataplexDataScan";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexDataScanSpec defines the desired state of DataplexDataScan</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataplexDataScanSpec Spec { get; set; }

    /// <summary>DataplexDataScanStatus defines the config connector machine state of DataplexDataScan</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexDataScanStatus? Status { get; set; }
}