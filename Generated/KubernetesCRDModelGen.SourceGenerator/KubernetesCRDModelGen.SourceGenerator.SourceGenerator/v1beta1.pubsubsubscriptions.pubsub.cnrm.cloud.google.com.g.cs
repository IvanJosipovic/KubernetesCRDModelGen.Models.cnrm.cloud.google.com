#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.cnrm.cloud.google.com;
/// <summary>PubSubSubscription is the Schema for the PubSubSubscription API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PubSubSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PubSubSubscription>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PubSubSubscriptionList";
    public const string KubeGroup = "pubsub.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsubsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PubSubSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PubSubSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PubSubSubscription> Items { get; set; }
}

/// <summary>The name of the table to which to write data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecBigqueryConfigTableRef
{
    /// <summary>A reference to an externally-managed BigQueryTable resource. Should be in the format &quot;projects/{{projectID}}/datasets/{{datasetID}}/tables/{{tableID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigQueryTable resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigQueryTable resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecBigqueryConfig
{
    /// <summary>When true and useTopicSchema is true, any fields that are a part of the topic schema that are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync and any messages with extra fields are not written and remain in the subscription&apos;s backlog.</summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>The name of the table to which to write data.</summary>
    [JsonPropertyName("tableRef")]
    public required V1beta1PubSubSubscriptionSpecBigqueryConfigTableRef TableRef { get; set; }

    /// <summary>When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table. The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>If set, message data will be written to Cloud Storage in Avro format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecCloudStorageConfigAvroConfig
{
    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey as additional fields in the output.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &quot;gs://&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecCloudStorageConfigBucketRef
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

/// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecCloudStorageConfig
{
    /// <summary>If set, message data will be written to Cloud Storage in Avro format.</summary>
    [JsonPropertyName("avroConfig")]
    public V1beta1PubSubSubscriptionSpecCloudStorageConfigAvroConfig? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &quot;gs://&quot;.</summary>
    [JsonPropertyName("bucketRef")]
    public required V1beta1PubSubSubscriptionSpecCloudStorageConfigBucketRef BucketRef { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in &quot;/&quot;.</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB. The maxBytes limit may be exceeded in cases where messages are larger than the limit.</summary>
    [JsonPropertyName("maxBytes")]
    public long? MaxBytes { get; set; }

    /// <summary>The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes. May not exceed the subscription&apos;s acknowledgement deadline. A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>An output-only field that indicates whether or not the subscription can receive messages.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The name of the topic to which dead letter messages should be published.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecDeadLetterPolicyDeadLetterTopicRef
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

/// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecDeadLetterPolicy
{
    /// <summary>The name of the topic to which dead letter messages should be published.</summary>
    [JsonPropertyName("deadLetterTopicRef")]
    public V1beta1PubSubSubscriptionSpecDeadLetterPolicyDeadLetterTopicRef? DeadLetterTopicRef { get; set; }

    /// <summary>The maximum number of delivery attempts for any message. The value must be between 5 and 100.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

/// <summary>A policy that specifies the conditions for this subscription&apos;s expiration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecExpirationPolicy
{
    /// <summary>Specifies the &quot;time-to-live&quot; duration for an associated resource. The resource expires if it is not active for a period of ttl. If ttl is set to &quot; &quot;, the associated resource never expires. A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example - &quot;3.5s&quot;.</summary>
    [JsonPropertyName("ttl")]
    public required string Ttl { get; set; }
}

/// <summary>When set, the payload to the push endpoint is not wrapped.Sets the &apos;data&apos; field as the HTTP body for delivery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecPushConfigNoWrapper
{
    /// <summary>When true, writes the Pub/Sub message metadata to &apos;x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; &apos; headers of the HTTP request. Writes the Pub/Sub message attributes to &apos; &lt;KEY&gt;:&lt;VAL&gt; &apos; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public required bool WriteMetadata { get; set; }
}

/// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecPushConfigOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values (array) for the audience field is not supported. More info about the OIDC JWT token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Service account email to be used for generating the OIDC token. The caller (for subscriptions.create, subscriptions.patch, and subscriptions.modifyPushConfig RPCs) must have the iam.serviceAccounts.actAs permission for the service account.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public required string ServiceAccountEmail { get; set; }
}

/// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecPushConfig
{
    /// <summary>Endpoint configuration attributes.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>When set, the payload to the push endpoint is not wrapped.Sets the &apos;data&apos; field as the HTTP body for delivery.</summary>
    [JsonPropertyName("noWrapper")]
    public V1beta1PubSubSubscriptionSpecPushConfigNoWrapper? NoWrapper { get; set; }

    /// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message.</summary>
    [JsonPropertyName("oidcToken")]
    public V1beta1PubSubSubscriptionSpecPushConfigOidcToken? OidcToken { get; set; }

    /// <summary>A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use &quot;https://example.com/push&quot;.</summary>
    [JsonPropertyName("pushEndpoint")]
    public required string PushEndpoint { get; set; }
}

/// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecRetryPolicy
{
    /// <summary>The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds. A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds. A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary>Reference to a PubSubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpecTopicRef
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

/// <summary>PubSubSubscriptionSpec defines the desired state of PubSubSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionSpec
{
    /// <summary>This value is the maximum time after a subscriber receives a message before the subscriber should acknowledge the message.</summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public int? AckDeadlineSeconds { get; set; }

    /// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
    [JsonPropertyName("bigqueryConfig")]
    public V1beta1PubSubSubscriptionSpecBigqueryConfig? BigqueryConfig { get; set; }

    /// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
    [JsonPropertyName("cloudStorageConfig")]
    public V1beta1PubSubSubscriptionSpecCloudStorageConfig? CloudStorageConfig { get; set; }

    /// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled.</summary>
    [JsonPropertyName("deadLetterPolicy")]
    public V1beta1PubSubSubscriptionSpecDeadLetterPolicy? DeadLetterPolicy { get; set; }

    /// <summary>If &apos;true&apos;, Pub/Sub provides the guarantees for the delivery of a message with a given value of messageId on this Subscriptions&apos;.</summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>Immutable. If &apos;true&apos;, messages published with the same orderingKey in PubsubMessage will be delivered to the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be delivered in any order.</summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>A policy that specifies the conditions for this subscription&apos;s expiration.</summary>
    [JsonPropertyName("expirationPolicy")]
    public V1beta1PubSubSubscriptionSpecExpirationPolicy? ExpirationPolicy { get; set; }

    /// <summary>Immutable. The subscription only delivers the messages that match the filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>How long to retain unacknowledged messages in the subscription&apos;s backlog, from the moment a message is published.</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods.</summary>
    [JsonPropertyName("pushConfig")]
    public V1beta1PubSubSubscriptionSpecPushConfig? PushConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Indicates whether to retain acknowledged messages. If &apos;true&apos;, then messages are not expunged from the subscription&apos;s backlog, even if they are acknowledged, until they fall out of the messageRetentionDuration window.</summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1PubSubSubscriptionSpecRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Reference to a PubSubTopic.</summary>
    [JsonPropertyName("topicRef")]
    public required V1beta1PubSubSubscriptionSpecTopicRef TopicRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionStatusConditions
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

/// <summary>PubSubSubscriptionStatus defines the config connector machine state of PubSubSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PubSubSubscriptionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PubSubSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PubSubSubscription is the Schema for the PubSubSubscription API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PubSubSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PubSubSubscriptionSpec>, IStatus<V1beta1PubSubSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PubSubSubscription";
    public const string KubeGroup = "pubsub.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsubsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PubSubSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PubSubSubscriptionSpec defines the desired state of PubSubSubscription</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PubSubSubscriptionSpec Spec { get; set; }

    /// <summary>PubSubSubscriptionStatus defines the config connector machine state of PubSubSubscription</summary>
    [JsonPropertyName("status")]
    public V1beta1PubSubSubscriptionStatus? Status { get; set; }
}