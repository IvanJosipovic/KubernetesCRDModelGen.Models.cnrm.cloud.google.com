#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aiplatform.cnrm.cloud.google.com;
/// <summary>VertexAITuningJob is the Schema for the VertexAITuningJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAITuningJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAITuningJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAITuningJobList";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaituningjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aiplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAITuningJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAITuningJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAITuningJob> Items { get; set; }
}

/// <summary>Customer-managed encryption key options for a TuningJob. If this is set, then all resources created by the TuningJob will be encrypted with the provided encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobSpecProjectRef
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

/// <summary>
/// The service account that the tuningJob workload runs as.
///  If not specified, the Vertex AI Secure Fine-Tuned Service Agent in the
///  project will be used. See
///  https://cloud.google.com/iam/docs/service-agents#vertex-ai-secure-fine-tuning-service-agent
/// 
///  Users starting the pipeline must have the `iam.serviceAccounts.actAs`
///  permission on this service account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Hyperparameters for SFT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobSpecSupervisedTuningSpecHyperParameters
{
    /// <summary>Optional. Adapter size for tuning.</summary>
    [JsonPropertyName("adapterSize")]
    public string? AdapterSize { get; set; }

    /// <summary>Optional. Number of complete passes the model makes over the entire training dataset during training.</summary>
    [JsonPropertyName("epochCount")]
    public long? EpochCount { get; set; }

    /// <summary>Optional. Multiplier for adjusting the default learning rate.</summary>
    [JsonPropertyName("learningRateMultiplier")]
    public double? LearningRateMultiplier { get; set; }
}

/// <summary>Tuning Spec for Supervised Fine Tuning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobSpecSupervisedTuningSpec
{
    /// <summary>Optional. If set to true, disable intermediate checkpoints for SFT and only the last checkpoint will be exported. Otherwise, enable intermediate checkpoints for SFT. Default is false.</summary>
    [JsonPropertyName("exportLastCheckpointOnly")]
    public bool? ExportLastCheckpointOnly { get; set; }

    /// <summary>Optional. Hyperparameters for SFT.</summary>
    [JsonPropertyName("hyperParameters")]
    public V1alpha1VertexAITuningJobSpecSupervisedTuningSpecHyperParameters? HyperParameters { get; set; }

    /// <summary>Required. Cloud Storage path to file containing training dataset for tuning. The dataset must be formatted as a JSONL file.</summary>
    [JsonPropertyName("trainingDatasetURI")]
    public string? TrainingDatasetURI { get; set; }

    /// <summary>Optional. Cloud Storage path to file containing validation dataset for tuning. The dataset must be formatted as a JSONL file.</summary>
    [JsonPropertyName("validationDatasetURI")]
    public string? ValidationDatasetURI { get; set; }
}

/// <summary>VertexAITuningJobSpec defines the desired state of VertexAITuningJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobSpec
{
    /// <summary>The base model that is being tuned. See [Supported models](https://cloud.google.com/vertex-ai/generative-ai/docs/model-reference/tuning#supported_models).</summary>
    [JsonPropertyName("baseModel")]
    public string? BaseModel { get; set; }

    /// <summary>Optional. The description of the [TuningJob][google.cloud.aiplatform.v1.TuningJob].</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Customer-managed encryption key options for a TuningJob. If this is set, then all resources created by the TuningJob will be encrypted with the provided encryption key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAITuningJobSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>
    /// Optional. The labels with user-defined metadata to organize
    ///  [TuningJob][google.cloud.aiplatform.v1.TuningJob] and generated resources
    ///  such as [Model][google.cloud.aiplatform.v1.Model] and
    ///  [Endpoint][google.cloud.aiplatform.v1.Endpoint].
    /// 
    ///  Label keys and values can be no longer than 64 characters
    ///  (Unicode codepoints), can only contain lowercase letters, numeric
    ///  characters, underscores and dashes. International characters are allowed.
    /// 
    ///  See https://goo.gl/xmQnxf for more information and examples of labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VertexAITuningJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VertexAITuningJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// The service account that the tuningJob workload runs as.
    ///  If not specified, the Vertex AI Secure Fine-Tuned Service Agent in the
    ///  project will be used. See
    ///  https://cloud.google.com/iam/docs/service-agents#vertex-ai-secure-fine-tuning-service-agent
    /// 
    ///  Users starting the pipeline must have the `iam.serviceAccounts.actAs`
    ///  permission on this service account.
    /// </summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1VertexAITuningJobSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Tuning Spec for Supervised Fine Tuning.</summary>
    [JsonPropertyName("supervisedTuningSpec")]
    public V1alpha1VertexAITuningJobSpecSupervisedTuningSpec? SupervisedTuningSpec { get; set; }

    /// <summary>Optional. The display name of the [TunedModel][google.cloud.aiplatform.v1.Model]. The name can be up to 128 characters long and can consist of any UTF-8 characters.</summary>
    [JsonPropertyName("tunedModelDisplayName")]
    public string? TunedModelDisplayName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusConditions
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

/// <summary>Output only. Only populated when job&apos;s state is `JOB_STATE_FAILED` or `JOB_STATE_CANCELLED`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateError
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
public partial class V1alpha1VertexAITuningJobStatusObservedStateTunedModelCheckpoints
{
    /// <summary>The ID of the checkpoint.</summary>
    [JsonPropertyName("checkpointID")]
    public string? CheckpointID { get; set; }

    /// <summary>The Endpoint resource name that the checkpoint is deployed to. Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The epoch of the checkpoint.</summary>
    [JsonPropertyName("epoch")]
    public long? Epoch { get; set; }

    /// <summary>The step of the checkpoint.</summary>
    [JsonPropertyName("step")]
    public long? Step { get; set; }
}

/// <summary>Output only. The tuned model that is created as a result of this job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTunedModel
{
    /// <summary>Output only. The checkpoints associated with this TunedModel. This field is only populated for tuning jobs that enable intermediate checkpoints.</summary>
    [JsonPropertyName("checkpoints")]
    public IList<V1alpha1VertexAITuningJobStatusObservedStateTunedModelCheckpoints>? Checkpoints { get; set; }

    /// <summary>Output only. A resource name of an Endpoint. Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Output only. The resource name of the TunedModel. Format: `projects/{project}/locations/{location}/models/{model}`.</summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }
}

/// <summary>Optional. Result of executing the [ExecutableCode].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsCodeExecutionResult
{
    /// <summary>Required. Outcome of the code execution.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>Optional. Contains stdout when code execution is successful, stderr or other description otherwise.</summary>
    [JsonPropertyName("output")]
    public string? Output { get; set; }
}

/// <summary>Optional. Code generated by the model that is meant to be executed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsExecutableCode
{
    /// <summary>Required. The code to be executed.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Required. Programming language of the `code`.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>Optional. URI based data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsFileData
{
    /// <summary>Required. URI.</summary>
    [JsonPropertyName("fileURI")]
    public string? FileURI { get; set; }

    /// <summary>Required. The IANA standard MIME type of the source data.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }
}

/// <summary>Optional. A predicted [FunctionCall] returned from the model that contains a string representing the [FunctionDeclaration.name] with the parameters and their values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsFunctionCall
{
    /// <summary>Optional. Required. The function parameters and values in JSON object format. See [FunctionDeclaration.parameters] for parameter details.</summary>
    [JsonPropertyName("args")]
    public JsonNode? Args { get; set; }

    /// <summary>Required. The name of the function to call. Matches [FunctionDeclaration.name].</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Optional. The result output of a [FunctionCall] that contains a string representing the [FunctionDeclaration.name] and a structured JSON object containing any output from the function call. It is used as context to the model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsFunctionResponse
{
    /// <summary>Required. The name of the function to call. Matches [FunctionDeclaration.name] and [FunctionCall.name].</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The function response in JSON object format. Use &quot;output&quot; key to specify function output and &quot;error&quot; key to specify error details (if any). If &quot;output&quot; and &quot;error&quot; keys are not specified, then whole &quot;response&quot; is treated as function output.</summary>
    [JsonPropertyName("response")]
    public JsonNode? Response { get; set; }
}

/// <summary>Optional. Inlined bytes data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsInlineData
{
    /// <summary>Required. Raw bytes.</summary>
    [JsonPropertyName("data")]
    public byte[]? Data { get; set; }

    /// <summary>Required. The IANA standard MIME type of the source data.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }
}

/// <summary>Optional. Video metadata. The metadata should only be specified while the video data is presented in inline_data or file_data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsVideoMetadata
{
    /// <summary>Optional. The end offset of the video.</summary>
    [JsonPropertyName("endOffset")]
    public string? EndOffset { get; set; }

    /// <summary>Optional. The start offset of the video.</summary>
    [JsonPropertyName("startOffset")]
    public string? StartOffset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesParts
{
    /// <summary>Optional. Result of executing the [ExecutableCode].</summary>
    [JsonPropertyName("codeExecutionResult")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsCodeExecutionResult? CodeExecutionResult { get; set; }

    /// <summary>Optional. Code generated by the model that is meant to be executed.</summary>
    [JsonPropertyName("executableCode")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsExecutableCode? ExecutableCode { get; set; }

    /// <summary>Optional. URI based data.</summary>
    [JsonPropertyName("fileData")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsFileData? FileData { get; set; }

    /// <summary>Optional. A predicted [FunctionCall] returned from the model that contains a string representing the [FunctionDeclaration.name] with the parameters and their values.</summary>
    [JsonPropertyName("functionCall")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsFunctionCall? FunctionCall { get; set; }

    /// <summary>Optional. The result output of a [FunctionCall] that contains a string representing the [FunctionDeclaration.name] and a structured JSON object containing any output from the function call. It is used as context to the model.</summary>
    [JsonPropertyName("functionResponse")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsFunctionResponse? FunctionResponse { get; set; }

    /// <summary>Optional. Inlined bytes data.</summary>
    [JsonPropertyName("inlineData")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsInlineData? InlineData { get; set; }

    /// <summary>Optional. Text part (can be code).</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>Indicates if the part is thought from the model.</summary>
    [JsonPropertyName("thought")]
    public bool? Thought { get; set; }

    /// <summary>An opaque signature for the thought so it can be reused in subsequent requests.</summary>
    [JsonPropertyName("thoughtSignature")]
    public byte[]? ThoughtSignature { get; set; }

    /// <summary>Optional. Video metadata. The metadata should only be specified while the video data is presented in inline_data or file_data.</summary>
    [JsonPropertyName("videoMetadata")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesPartsVideoMetadata? VideoMetadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamples
{
    /// <summary>Required. Ordered `Parts` that constitute a single message. Parts may have different IANA MIME types.</summary>
    [JsonPropertyName("parts")]
    public IList<V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamplesParts>? Parts { get; set; }

    /// <summary>
    /// Optional. The producer of the content. Must be either &apos;user&apos; or &apos;model&apos;.
    /// 
    ///  Useful to set for multi-turn conversations, otherwise can be left blank
    ///  or unset.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserInputTokenDistributionBuckets
{
    /// <summary>Output only. Number of values in the bucket.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Output only. Left bound of the bucket.</summary>
    [JsonPropertyName("left")]
    public double? Left { get; set; }

    /// <summary>Output only. Right bound of the bucket.</summary>
    [JsonPropertyName("right")]
    public double? Right { get; set; }
}

/// <summary>Output only. Dataset distributions for the user input tokens.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserInputTokenDistribution
{
    /// <summary>Output only. Sum of a given population of values that are billable.</summary>
    [JsonPropertyName("billableSum")]
    public long? BillableSum { get; set; }

    /// <summary>Output only. Defines the histogram bucket.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserInputTokenDistributionBuckets>? Buckets { get; set; }

    /// <summary>Output only. The maximum of the population values.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Output only. The arithmetic mean of the values in the population.</summary>
    [JsonPropertyName("mean")]
    public double? Mean { get; set; }

    /// <summary>Output only. The median of the values in the population.</summary>
    [JsonPropertyName("median")]
    public double? Median { get; set; }

    /// <summary>Output only. The minimum of the population values.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>Output only. The 5th percentile of the values in the population.</summary>
    [JsonPropertyName("p5")]
    public double? P5 { get; set; }

    /// <summary>Output only. The 95th percentile of the values in the population.</summary>
    [JsonPropertyName("p95")]
    public double? P95 { get; set; }

    /// <summary>Output only. Sum of a given population of values.</summary>
    [JsonPropertyName("sum")]
    public long? Sum { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserMessagePerExampleDistributionBuckets
{
    /// <summary>Output only. Number of values in the bucket.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Output only. Left bound of the bucket.</summary>
    [JsonPropertyName("left")]
    public double? Left { get; set; }

    /// <summary>Output only. Right bound of the bucket.</summary>
    [JsonPropertyName("right")]
    public double? Right { get; set; }
}

/// <summary>Output only. Dataset distributions for the messages per example.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserMessagePerExampleDistribution
{
    /// <summary>Output only. Sum of a given population of values that are billable.</summary>
    [JsonPropertyName("billableSum")]
    public long? BillableSum { get; set; }

    /// <summary>Output only. Defines the histogram bucket.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserMessagePerExampleDistributionBuckets>? Buckets { get; set; }

    /// <summary>Output only. The maximum of the population values.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Output only. The arithmetic mean of the values in the population.</summary>
    [JsonPropertyName("mean")]
    public double? Mean { get; set; }

    /// <summary>Output only. The median of the values in the population.</summary>
    [JsonPropertyName("median")]
    public double? Median { get; set; }

    /// <summary>Output only. The minimum of the population values.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>Output only. The 5th percentile of the values in the population.</summary>
    [JsonPropertyName("p5")]
    public double? P5 { get; set; }

    /// <summary>Output only. The 95th percentile of the values in the population.</summary>
    [JsonPropertyName("p95")]
    public double? P95 { get; set; }

    /// <summary>Output only. Sum of a given population of values.</summary>
    [JsonPropertyName("sum")]
    public long? Sum { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserOutputTokenDistributionBuckets
{
    /// <summary>Output only. Number of values in the bucket.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Output only. Left bound of the bucket.</summary>
    [JsonPropertyName("left")]
    public double? Left { get; set; }

    /// <summary>Output only. Right bound of the bucket.</summary>
    [JsonPropertyName("right")]
    public double? Right { get; set; }
}

/// <summary>Output only. Dataset distributions for the user output tokens.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserOutputTokenDistribution
{
    /// <summary>Output only. Sum of a given population of values that are billable.</summary>
    [JsonPropertyName("billableSum")]
    public long? BillableSum { get; set; }

    /// <summary>Output only. Defines the histogram bucket.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserOutputTokenDistributionBuckets>? Buckets { get; set; }

    /// <summary>Output only. The maximum of the population values.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Output only. The arithmetic mean of the values in the population.</summary>
    [JsonPropertyName("mean")]
    public double? Mean { get; set; }

    /// <summary>Output only. The median of the values in the population.</summary>
    [JsonPropertyName("median")]
    public double? Median { get; set; }

    /// <summary>Output only. The minimum of the population values.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    /// <summary>Output only. The 5th percentile of the values in the population.</summary>
    [JsonPropertyName("p5")]
    public double? P5 { get; set; }

    /// <summary>Output only. The 95th percentile of the values in the population.</summary>
    [JsonPropertyName("p95")]
    public double? P95 { get; set; }

    /// <summary>Output only. Sum of a given population of values.</summary>
    [JsonPropertyName("sum")]
    public long? Sum { get; set; }
}

/// <summary>The SFT Tuning data stats.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStats
{
    /// <summary>Output only. For each index in `truncated_example_indices`, the user-facing reason why the example was dropped.</summary>
    [JsonPropertyName("droppedExampleReasons")]
    public IList<string>? DroppedExampleReasons { get; set; }

    /// <summary>Output only. Number of billable characters in the tuning dataset.</summary>
    [JsonPropertyName("totalBillableCharacterCount")]
    public long? TotalBillableCharacterCount { get; set; }

    /// <summary>Output only. Number of billable tokens in the tuning dataset.</summary>
    [JsonPropertyName("totalBillableTokenCount")]
    public long? TotalBillableTokenCount { get; set; }

    /// <summary>Output only. The number of examples in the dataset that have been dropped. An example can be dropped for reasons including: too many tokens, contains an invalid image, contains too many images, etc.</summary>
    [JsonPropertyName("totalTruncatedExampleCount")]
    public long? TotalTruncatedExampleCount { get; set; }

    /// <summary>Output only. Number of tuning characters in the tuning dataset.</summary>
    [JsonPropertyName("totalTuningCharacterCount")]
    public long? TotalTuningCharacterCount { get; set; }

    /// <summary>Output only. A partial sample of the indices (starting from 1) of the dropped examples.</summary>
    [JsonPropertyName("truncatedExampleIndices")]
    public IList<long>? TruncatedExampleIndices { get; set; }

    /// <summary>Output only. Number of examples in the tuning dataset.</summary>
    [JsonPropertyName("tuningDatasetExampleCount")]
    public long? TuningDatasetExampleCount { get; set; }

    /// <summary>Output only. Number of tuning steps for this Tuning Job.</summary>
    [JsonPropertyName("tuningStepCount")]
    public long? TuningStepCount { get; set; }

    /// <summary>Output only. Sample user messages in the training dataset uri.</summary>
    [JsonPropertyName("userDatasetExamples")]
    public IList<V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserDatasetExamples>? UserDatasetExamples { get; set; }

    /// <summary>Output only. Dataset distributions for the user input tokens.</summary>
    [JsonPropertyName("userInputTokenDistribution")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserInputTokenDistribution? UserInputTokenDistribution { get; set; }

    /// <summary>Output only. Dataset distributions for the messages per example.</summary>
    [JsonPropertyName("userMessagePerExampleDistribution")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserMessagePerExampleDistribution? UserMessagePerExampleDistribution { get; set; }

    /// <summary>Output only. Dataset distributions for the user output tokens.</summary>
    [JsonPropertyName("userOutputTokenDistribution")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStatsUserOutputTokenDistribution? UserOutputTokenDistribution { get; set; }
}

/// <summary>Output only. The tuning data statistics associated with this [TuningJob][google.cloud.aiplatform.v1.TuningJob].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedStateTuningDataStats
{
    /// <summary>The SFT Tuning data stats.</summary>
    [JsonPropertyName("supervisedTuningDataStats")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStatsSupervisedTuningDataStats? SupervisedTuningDataStats { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatusObservedState
{
    /// <summary>Output only. Time when the [TuningJob][google.cloud.aiplatform.v1.TuningJob] was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Time when the TuningJob entered any of the following [JobStates][google.cloud.aiplatform.v1.JobState]: `JOB_STATE_SUCCEEDED`, `JOB_STATE_FAILED`, `JOB_STATE_CANCELLED`, `JOB_STATE_EXPIRED`.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. Only populated when job&apos;s state is `JOB_STATE_FAILED` or `JOB_STATE_CANCELLED`.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VertexAITuningJobStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. The Experiment associated with this [TuningJob][google.cloud.aiplatform.v1.TuningJob].</summary>
    [JsonPropertyName("experiment")]
    public string? Experiment { get; set; }

    /// <summary>Output only. Identifier. Resource name of a TuningJob. Format: `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Time when the [TuningJob][google.cloud.aiplatform.v1.TuningJob] for the first time entered the `JOB_STATE_RUNNING` state.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. The detailed state of the job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The tuned model that is created as a result of this job.</summary>
    [JsonPropertyName("tunedModel")]
    public V1alpha1VertexAITuningJobStatusObservedStateTunedModel? TunedModel { get; set; }

    /// <summary>Output only. The tuning data statistics associated with this [TuningJob][google.cloud.aiplatform.v1.TuningJob].</summary>
    [JsonPropertyName("tuningDataStats")]
    public V1alpha1VertexAITuningJobStatusObservedStateTuningDataStats? TuningDataStats { get; set; }

    /// <summary>Output only. Time when the [TuningJob][google.cloud.aiplatform.v1.TuningJob] was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAITuningJobStatus defines the config connector machine state of VertexAITuningJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAITuningJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAITuningJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAITuningJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAITuningJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAITuningJob is the Schema for the VertexAITuningJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAITuningJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAITuningJobSpec>, IStatus<V1alpha1VertexAITuningJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAITuningJob";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaituningjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aiplatform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAITuningJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAITuningJobSpec defines the desired state of VertexAITuningJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAITuningJobSpec Spec { get; set; }

    /// <summary>VertexAITuningJobStatus defines the config connector machine state of VertexAITuningJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAITuningJobStatus? Status { get; set; }
}