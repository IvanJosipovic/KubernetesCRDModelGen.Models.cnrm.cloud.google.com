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
/// <summary>DataLabelingEvaluationJob is the Schema for the DataLabelingEvaluationJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingEvaluationJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataLabelingEvaluationJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingEvaluationJobList";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelingevaluationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingEvaluationJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataLabelingEvaluationJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataLabelingEvaluationJob> Items { get; set; }
}

/// <summary>
/// Specify this field if your model version performs image object detection
///  (bounding box detection).
/// 
///  `annotationSpecSet` in this configuration must match
///  [EvaluationJob.annotationSpecSet][google.cloud.datalabeling.v1beta1.EvaluationJob.annotation_spec_set].
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigBoundingPolyConfig
{
    /// <summary>Required. Annotation spec set resource name.</summary>
    [JsonPropertyName("annotationSpecSet")]
    public string? AnnotationSpecSet { get; set; }

    /// <summary>Optional. Instruction message showed on contributors UI.</summary>
    [JsonPropertyName("instructionMessage")]
    public string? InstructionMessage { get; set; }
}

/// <summary>Only specify this field if the related model performs image object detection (`IMAGE_BOUNDING_BOX_ANNOTATION`). Describes how to evaluate bounding boxes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigEvaluationConfigBoundingBoxEvaluationOptions
{
    /// <summary>
    /// Minimum
    ///  [intersection-over-union
    /// 
    ///  (IOU)](/vision/automl/object-detection/docs/evaluate#intersection-over-union)
    ///  required for 2 bounding boxes to be considered a match. This must be a
    ///  number between 0 and 1.
    /// </summary>
    [JsonPropertyName("iouThreshold")]
    public double? IouThreshold { get; set; }
}

/// <summary>Required. Details for calculating evaluation metrics and creating [Evaulations][google.cloud.datalabeling.v1beta1.Evaluation]. If your model version performs image object detection, you must specify the `boundingBoxEvaluationOptions` field within this configuration. Otherwise, provide an empty object for this configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigEvaluationConfig
{
    /// <summary>Only specify this field if the related model performs image object detection (`IMAGE_BOUNDING_BOX_ANNOTATION`). Describes how to evaluate bounding boxes.</summary>
    [JsonPropertyName("boundingBoxEvaluationOptions")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigEvaluationConfigBoundingBoxEvaluationOptions? BoundingBoxEvaluationOptions { get; set; }
}

/// <summary>Optional. Configuration details for evaluation job alerts. Specify this field if you want to receive email alerts if the evaluation job finds that your predictions have low mean average precision during a run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigEvaluationJobAlertConfig
{
    /// <summary>Required. An email address to send alerts to.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Required. A number between 0 and 1 that describes a minimum mean average precision threshold. When the evaluation job runs, if it calculates that your model version&apos;s predictions from the recent interval have [meanAveragePrecision][google.cloud.datalabeling.v1beta1.PrCurve.mean_average_precision] below this threshold, then it sends an alert to your specified email.</summary>
    [JsonPropertyName("minAcceptableMeanAveragePrecision")]
    public double? MinAcceptableMeanAveragePrecision { get; set; }
}

/// <summary>
/// Optional. Details for human annotation of your data. If you set
///  [labelMissingGroundTruth][google.cloud.datalabeling.v1beta1.EvaluationJob.label_missing_ground_truth] to
///  `true` for this evaluation job, then you must specify this field. If you
///  plan to provide your own ground truth labels, then omit this field.
/// 
///  Note that you must create an [Instruction][google.cloud.datalabeling.v1beta1.Instruction] resource before you can
///  specify this field. Provide the name of the instruction resource in the
///  `instruction` field within this configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigHumanAnnotationConfig
{
    /// <summary>Optional. A human-readable description for AnnotatedDataset. The description can be up to 10000 characters long.</summary>
    [JsonPropertyName("annotatedDatasetDescription")]
    public string? AnnotatedDatasetDescription { get; set; }

    /// <summary>Required. A human-readable name for AnnotatedDataset defined by users. Maximum of 64 characters .</summary>
    [JsonPropertyName("annotatedDatasetDisplayName")]
    public string? AnnotatedDatasetDisplayName { get; set; }

    /// <summary>Optional. If you want your own labeling contributors to manage and work on this labeling request, you can set these contributors here. We will give them access to the question types in crowdcompute. Note that these emails must be registered in crowdcompute worker UI: https://crowd-compute.appspot.com/</summary>
    [JsonPropertyName("contributorEmails")]
    public IList<string>? ContributorEmails { get; set; }

    /// <summary>Required. Instruction resource name.</summary>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>Optional. A human-readable label used to logically group labeling tasks. This string must match the regular expression `[a-zA-Z\\d_-]{0,128}`.</summary>
    [JsonPropertyName("labelGroup")]
    public string? LabelGroup { get; set; }

    /// <summary>Optional. The Language of this question, as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). Default value is en-US. Only need to set this when task is language related. For example, French text classification.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Optional. Maximum duration for contributors to answer a question. Maximum is 3600 seconds. Default is 3600 seconds.</summary>
    [JsonPropertyName("questionDuration")]
    public string? QuestionDuration { get; set; }

    /// <summary>Optional. Replication of questions. Each question will be sent to up to this number of contributors to label. Aggregated answers will be returned. Default is set to 1. For image related labeling, valid values are 1, 3, 5.</summary>
    [JsonPropertyName("replicaCount")]
    public int? ReplicaCount { get; set; }

    /// <summary>Email of the user who started the labeling task and should be notified by email. If empty no notification will be sent.</summary>
    [JsonPropertyName("userEmailAddress")]
    public string? UserEmailAddress { get; set; }
}

/// <summary>
/// Specify this field if your model version performs image classification or
///  general classification.
/// 
///  `annotationSpecSet` in this configuration must match
///  [EvaluationJob.annotationSpecSet][google.cloud.datalabeling.v1beta1.EvaluationJob.annotation_spec_set].
///  `allowMultiLabel` in this configuration must match
///  `classificationMetadata.isMultiLabel` in [input_config][google.cloud.datalabeling.v1beta1.EvaluationJobConfig.input_config].
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigImageClassificationConfig
{
    /// <summary>Optional. If allow_multi_label is true, contributors are able to choose multiple labels for one image.</summary>
    [JsonPropertyName("allowMultiLabel")]
    public bool? AllowMultiLabel { get; set; }

    /// <summary>Required. Annotation spec set resource name.</summary>
    [JsonPropertyName("annotationSpecSet")]
    public string? AnnotationSpecSet { get; set; }

    /// <summary>Optional. The type of how to aggregate answers.</summary>
    [JsonPropertyName("answerAggregationType")]
    public string? AnswerAggregationType { get; set; }
}

/// <summary>Source located in BigQuery. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigBigquerySource
{
    /// <summary>
    /// Required. BigQuery URI to a table, up to 2,000 characters long. If you
    ///  specify the URI of a table that does not exist, Data Labeling Service
    ///  creates a table at the URI with the correct schema when you create your
    ///  [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob]. If you specify the URI of a table that already exists,
    ///  it must have the
    ///  [correct
    ///  schema](/ml-engine/docs/continuous-evaluation/create-job#table-schema).
    /// 
    ///  Provide the table URI in the following format:
    /// 
    ///  &quot;bq://&lt;var&gt;{your_project_id}&lt;/var&gt;/&lt;var&gt;{your_dataset_name}&lt;/var&gt;/&lt;var&gt;{your_table_name}&lt;/var&gt; &quot;
    /// 
    ///  [Learn
    ///  more](/ml-engine/docs/continuous-evaluation/create-job#table-schema).
    /// </summary>
    [JsonPropertyName("inputURI")]
    public string? InputURI { get; set; }
}

/// <summary>Optional. Metadata about annotations for the input. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob] for a model version that performs classification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigClassificationMetadata
{
    /// <summary>Whether the classification task is multi-label or not.</summary>
    [JsonPropertyName("isMultiLabel")]
    public bool? IsMultiLabel { get; set; }
}

/// <summary>Source located in Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigGcsSource
{
    /// <summary>Required. The input URI of source file. This must be a Cloud Storage path (`gs://...`).</summary>
    [JsonPropertyName("inputURI")]
    public string? InputURI { get; set; }

    /// <summary>Required. The format of the source file. Only &quot;text/csv&quot; is supported.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }
}

/// <summary>Required for text import, as language code must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigTextMetadata
{
    /// <summary>The language of this text, as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). Default value is en-US.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// Rquired. Details for the sampled prediction input. Within this
///  configuration, there are requirements for several fields:
/// 
///  * `dataType` must be one of `IMAGE`, `TEXT`, or `GENERAL_DATA`.
///  * `annotationType` must be one of `IMAGE_CLASSIFICATION_ANNOTATION`,
///    `TEXT_CLASSIFICATION_ANNOTATION`, `GENERAL_CLASSIFICATION_ANNOTATION`,
///    or `IMAGE_BOUNDING_BOX_ANNOTATION` (image object detection).
///  * If your machine learning model performs classification, you must specify
///    `classificationMetadata.isMultiLabel`.
///  * You must specify `bigquerySource` (not `gcsSource`).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfig
{
    /// <summary>Optional. The type of annotation to be performed on this data. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob].</summary>
    [JsonPropertyName("annotationType")]
    public string? AnnotationType { get; set; }

    /// <summary>Source located in BigQuery. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob].</summary>
    [JsonPropertyName("bigquerySource")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigBigquerySource? BigquerySource { get; set; }

    /// <summary>Optional. Metadata about annotations for the input. You must specify this field if you are using this InputConfig in an [EvaluationJob][google.cloud.datalabeling.v1beta1.EvaluationJob] for a model version that performs classification.</summary>
    [JsonPropertyName("classificationMetadata")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigClassificationMetadata? ClassificationMetadata { get; set; }

    /// <summary>Required. Data type must be specifed when user tries to import data.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Source located in Cloud Storage.</summary>
    [JsonPropertyName("gcsSource")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigGcsSource? GcsSource { get; set; }

    /// <summary>Required for text import, as language code must be specified.</summary>
    [JsonPropertyName("textMetadata")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfigTextMetadata? TextMetadata { get; set; }
}

/// <summary>Optional. Configs for sentiment selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigTextClassificationConfigSentimentConfig
{
    /// <summary>If set to true, contributors will have the option to select sentiment of the label they selected, to mark it as negative or positive label. Default is false.</summary>
    [JsonPropertyName("enableLabelSentimentSelection")]
    public bool? EnableLabelSentimentSelection { get; set; }
}

/// <summary>
/// Specify this field if your model version performs text classification.
/// 
///  `annotationSpecSet` in this configuration must match
///  [EvaluationJob.annotationSpecSet][google.cloud.datalabeling.v1beta1.EvaluationJob.annotation_spec_set].
///  `allowMultiLabel` in this configuration must match
///  `classificationMetadata.isMultiLabel` in [input_config][google.cloud.datalabeling.v1beta1.EvaluationJobConfig.input_config].
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigTextClassificationConfig
{
    /// <summary>Optional. If allow_multi_label is true, contributors are able to choose multiple labels for one text segment.</summary>
    [JsonPropertyName("allowMultiLabel")]
    public bool? AllowMultiLabel { get; set; }

    /// <summary>Required. Annotation spec set resource name.</summary>
    [JsonPropertyName("annotationSpecSet")]
    public string? AnnotationSpecSet { get; set; }

    /// <summary>Optional. Configs for sentiment selection.</summary>
    [JsonPropertyName("sentimentConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigTextClassificationConfigSentimentConfig? SentimentConfig { get; set; }
}

/// <summary>Required. Configuration details for the evaluation job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfig
{
    /// <summary>
    /// Required. Prediction keys that tell Data Labeling Service where to find the
    ///  data for evaluation in your BigQuery table. When the service samples
    ///  prediction input and output from your model version and saves it to
    ///  BigQuery, the data gets stored as JSON strings in the BigQuery table. These
    ///  keys tell Data Labeling Service how to parse the JSON.
    /// 
    ///  You can provide the following entries in this field:
    /// 
    ///  * `data_json_key`: the data key for prediction input. You must provide
    ///    either this key or `reference_json_key`.
    ///  * `reference_json_key`: the data reference key for prediction input. You
    ///    must provide either this key or `data_json_key`.
    ///  * `label_json_key`: the label key for prediction output. Required.
    ///  * `label_score_json_key`: the score key for prediction output. Required.
    ///  * `bounding_box_json_key`: the bounding box key for prediction output.
    ///    Required if your model version perform image object detection.
    /// 
    ///  Learn [how to configure prediction
    ///  keys](/ml-engine/docs/continuous-evaluation/create-job#prediction-keys).
    /// </summary>
    [JsonPropertyName("bigqueryImportKeys")]
    public IDictionary<string, string>? BigqueryImportKeys { get; set; }

    /// <summary>
    /// Specify this field if your model version performs image object detection
    ///  (bounding box detection).
    /// 
    ///  `annotationSpecSet` in this configuration must match
    ///  [EvaluationJob.annotationSpecSet][google.cloud.datalabeling.v1beta1.EvaluationJob.annotation_spec_set].
    /// </summary>
    [JsonPropertyName("boundingPolyConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigBoundingPolyConfig? BoundingPolyConfig { get; set; }

    /// <summary>Required. Details for calculating evaluation metrics and creating [Evaulations][google.cloud.datalabeling.v1beta1.Evaluation]. If your model version performs image object detection, you must specify the `boundingBoxEvaluationOptions` field within this configuration. Otherwise, provide an empty object for this configuration.</summary>
    [JsonPropertyName("evaluationConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigEvaluationConfig? EvaluationConfig { get; set; }

    /// <summary>Optional. Configuration details for evaluation job alerts. Specify this field if you want to receive email alerts if the evaluation job finds that your predictions have low mean average precision during a run.</summary>
    [JsonPropertyName("evaluationJobAlertConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigEvaluationJobAlertConfig? EvaluationJobAlertConfig { get; set; }

    /// <summary>Required. The maximum number of predictions to sample and save to BigQuery during each [evaluation interval][google.cloud.datalabeling.v1beta1.EvaluationJob.schedule]. This limit overrides `example_sample_percentage`: even if the service has not sampled enough predictions to fulfill `example_sample_perecentage` during an interval, it stops sampling predictions when it meets this limit.</summary>
    [JsonPropertyName("exampleCount")]
    public int? ExampleCount { get; set; }

    /// <summary>Required. Fraction of predictions to sample and save to BigQuery during each [evaluation interval][google.cloud.datalabeling.v1beta1.EvaluationJob.schedule]. For example, 0.1 means 10% of predictions served by your model version get saved to BigQuery.</summary>
    [JsonPropertyName("exampleSamplePercentage")]
    public double? ExampleSamplePercentage { get; set; }

    /// <summary>
    /// Optional. Details for human annotation of your data. If you set
    ///  [labelMissingGroundTruth][google.cloud.datalabeling.v1beta1.EvaluationJob.label_missing_ground_truth] to
    ///  `true` for this evaluation job, then you must specify this field. If you
    ///  plan to provide your own ground truth labels, then omit this field.
    /// 
    ///  Note that you must create an [Instruction][google.cloud.datalabeling.v1beta1.Instruction] resource before you can
    ///  specify this field. Provide the name of the instruction resource in the
    ///  `instruction` field within this configuration.
    /// </summary>
    [JsonPropertyName("humanAnnotationConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigHumanAnnotationConfig? HumanAnnotationConfig { get; set; }

    /// <summary>
    /// Specify this field if your model version performs image classification or
    ///  general classification.
    /// 
    ///  `annotationSpecSet` in this configuration must match
    ///  [EvaluationJob.annotationSpecSet][google.cloud.datalabeling.v1beta1.EvaluationJob.annotation_spec_set].
    ///  `allowMultiLabel` in this configuration must match
    ///  `classificationMetadata.isMultiLabel` in [input_config][google.cloud.datalabeling.v1beta1.EvaluationJobConfig.input_config].
    /// </summary>
    [JsonPropertyName("imageClassificationConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigImageClassificationConfig? ImageClassificationConfig { get; set; }

    /// <summary>
    /// Rquired. Details for the sampled prediction input. Within this
    ///  configuration, there are requirements for several fields:
    /// 
    ///  * `dataType` must be one of `IMAGE`, `TEXT`, or `GENERAL_DATA`.
    ///  * `annotationType` must be one of `IMAGE_CLASSIFICATION_ANNOTATION`,
    ///    `TEXT_CLASSIFICATION_ANNOTATION`, `GENERAL_CLASSIFICATION_ANNOTATION`,
    ///    or `IMAGE_BOUNDING_BOX_ANNOTATION` (image object detection).
    ///  * If your machine learning model performs classification, you must specify
    ///    `classificationMetadata.isMultiLabel`.
    ///  * You must specify `bigquerySource` (not `gcsSource`).
    /// </summary>
    [JsonPropertyName("inputConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigInputConfig? InputConfig { get; set; }

    /// <summary>
    /// Specify this field if your model version performs text classification.
    /// 
    ///  `annotationSpecSet` in this configuration must match
    ///  [EvaluationJob.annotationSpecSet][google.cloud.datalabeling.v1beta1.EvaluationJob.annotation_spec_set].
    ///  `allowMultiLabel` in this configuration must match
    ///  `classificationMetadata.isMultiLabel` in [input_config][google.cloud.datalabeling.v1beta1.EvaluationJobConfig.input_config].
    /// </summary>
    [JsonPropertyName("textClassificationConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfigTextClassificationConfig? TextClassificationConfig { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpecProjectRef
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

/// <summary>DataLabelingEvaluationJobSpec defines the desired state of DataLabelingEvaluationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobSpec
{
    /// <summary>Required. Name of the AnnotationSpecSet describing all the labels that your machine learning model outputs.</summary>
    [JsonPropertyName("annotationSpecSet")]
    public string? AnnotationSpecSet { get; set; }

    /// <summary>Required. Description of the job. The description can be up to 25,000 characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Configuration details for the evaluation job.</summary>
    [JsonPropertyName("evaluationJobConfig")]
    public V1alpha1DataLabelingEvaluationJobSpecEvaluationJobConfig? EvaluationJobConfig { get; set; }

    /// <summary>Required. Whether you want Data Labeling Service to provide ground truth labels for prediction input.</summary>
    [JsonPropertyName("labelMissingGroundTruth")]
    public bool? LabelMissingGroundTruth { get; set; }

    /// <summary>Required. The AI Platform Prediction model version to be evaluated.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataLabelingEvaluationJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataLabelingEvaluationJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Describes the interval at which the job runs. This interval must be at least 1 day, and it is rounded to the nearest day.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobStatusObservedStateAttemptsPartialFailures
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
public partial class V1alpha1DataLabelingEvaluationJobStatusObservedStateAttempts
{
    [JsonPropertyName("attemptTime")]
    public string? AttemptTime { get; set; }

    /// <summary>Details of errors that occurred.</summary>
    [JsonPropertyName("partialFailures")]
    public IList<V1alpha1DataLabelingEvaluationJobStatusObservedStateAttemptsPartialFailures>? PartialFailures { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobStatusObservedState
{
    /// <summary>Output only. Every time the evaluation job runs and an error occurs, the failed attempt is appended to this array.</summary>
    [JsonPropertyName("attempts")]
    public IList<V1alpha1DataLabelingEvaluationJobStatusObservedStateAttempts>? Attempts { get; set; }

    /// <summary>Output only. Timestamp of when this evaluation job was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Describes the current state of the job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>DataLabelingEvaluationJobStatus defines the config connector machine state of DataLabelingEvaluationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataLabelingEvaluationJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataLabelingEvaluationJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataLabelingEvaluationJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataLabelingEvaluationJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataLabelingEvaluationJob is the Schema for the DataLabelingEvaluationJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataLabelingEvaluationJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataLabelingEvaluationJobSpec>, IStatus<V1alpha1DataLabelingEvaluationJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataLabelingEvaluationJob";
    public const string KubeGroup = "datalabeling.cnrm.cloud.google.com";
    public const string KubePluralName = "datalabelingevaluationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalabeling.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataLabelingEvaluationJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLabelingEvaluationJobSpec defines the desired state of DataLabelingEvaluationJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataLabelingEvaluationJobSpec Spec { get; set; }

    /// <summary>DataLabelingEvaluationJobStatus defines the config connector machine state of DataLabelingEvaluationJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataLabelingEvaluationJobStatus? Status { get; set; }
}