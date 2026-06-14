#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.contentwarehouse.cnrm.cloud.google.com;
/// <summary>ContentWarehouseRuleSet is the Schema for the ContentWarehouseRuleSet API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ContentWarehouseRuleSetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ContentWarehouseRuleSet>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContentWarehouseRuleSetList";
    public const string KubeGroup = "contentwarehouse.cnrm.cloud.google.com";
    public const string KubePluralName = "contentwarehouserulesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contentwarehouse.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContentWarehouseRuleSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ContentWarehouseRuleSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ContentWarehouseRuleSet> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecProjectRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyAuditConfigsAuditLogConfigs
{
    /// <summary>Specifies the identities that do not cause logging for this type of permission.</summary>
    [JsonPropertyName("exemptedMembers")]
    public IList<string>? ExemptedMembers { get; set; }

    /// <summary>The log type that this config enables.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyAuditConfigs
{
    /// <summary>The configuration for logging of each type of permission.</summary>
    [JsonPropertyName("auditLogConfigs")]
    public IList<V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyAuditConfigsAuditLogConfigs>? AuditLogConfigs { get; set; }

    /// <summary>Specifies a service that will be enabled for audit logging.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>The condition that is associated with this binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyBindingsCondition
{
    /// <summary>Optional. Description of the expression.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyBindings
{
    /// <summary>The condition that is associated with this binding.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyBindingsCondition? Condition { get; set; }

    /// <summary>Specifies the principals requesting access for a Google Cloud resource.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Role that is assigned to the list of `members`, or principals.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Represents the new policy from which bindings are added, removed or replaced based on the type of the operation. the policy is limited to a few 10s of KB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicy
{
    /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
    [JsonPropertyName("auditConfigs")]
    public IList<V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyAuditConfigs>? AuditConfigs { get; set; }

    /// <summary>Associates a list of `members`, or principals, with a `role`.</summary>
    [JsonPropertyName("bindings")]
    public IList<V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicyBindings>? Bindings { get; set; }

    /// <summary>Specifies the format of the policy.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>Action triggering access control operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControl
{
    /// <summary>Identifies the type of operation.</summary>
    [JsonPropertyName("operationType")]
    public string? OperationType { get; set; }

    /// <summary>Represents the new policy from which bindings are added, removed or replaced based on the type of the operation. the policy is limited to a few 10s of KB.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControlPolicy? Policy { get; set; }
}

/// <summary>Action triggering create document link operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsAddToFolder
{
    /// <summary>Names of the folder under which new document is to be added.</summary>
    [JsonPropertyName("folders")]
    public IList<string>? Folders { get; set; }
}

/// <summary>Action triggering data update operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsDataUpdate
{
    /// <summary>Map of (K, V) -&gt; (valid name of the field, new value of the field)</summary>
    [JsonPropertyName("entries")]
    public IDictionary<string, string>? Entries { get; set; }
}

/// <summary>Action triggering data validation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsDataValidation
{
    /// <summary>Map of (K, V) -&gt; (field, string condition to be evaluated on the field)</summary>
    [JsonPropertyName("conditions")]
    public IDictionary<string, string>? Conditions { get; set; }
}

/// <summary>Action deleting the document.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsDeleteDocumentAction
{
    /// <summary>Boolean field to select between hard vs soft delete options.</summary>
    [JsonPropertyName("enableHardDelete")]
    public bool? EnableHardDelete { get; set; }
}

/// <summary>Action publish to Pub/Sub operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsPublishToPubSub
{
    /// <summary>Messages to be published.</summary>
    [JsonPropertyName("messages")]
    public IList<string>? Messages { get; set; }

    /// <summary>The topic id in the Pub/Sub service for which messages will be published to.</summary>
    [JsonPropertyName("topicID")]
    public string? TopicID { get; set; }
}

/// <summary>Action removing a document from a folder.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActionsRemoveFromFolderAction
{
    /// <summary>Condition of the action to be executed.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Name of the folder under which new document is to be added.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRulesActions
{
    /// <summary>Action triggering access control operations.</summary>
    [JsonPropertyName("accessControl")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsAccessControl? AccessControl { get; set; }

    /// <summary>ID of the action. Managed internally.</summary>
    [JsonPropertyName("actionID")]
    public string? ActionID { get; set; }

    /// <summary>Action triggering create document link operation.</summary>
    [JsonPropertyName("addToFolder")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsAddToFolder? AddToFolder { get; set; }

    /// <summary>Action triggering data update operations.</summary>
    [JsonPropertyName("dataUpdate")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsDataUpdate? DataUpdate { get; set; }

    /// <summary>Action triggering data validation operations.</summary>
    [JsonPropertyName("dataValidation")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsDataValidation? DataValidation { get; set; }

    /// <summary>Action deleting the document.</summary>
    [JsonPropertyName("deleteDocumentAction")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsDeleteDocumentAction? DeleteDocumentAction { get; set; }

    /// <summary>Action publish to Pub/Sub operation.</summary>
    [JsonPropertyName("publishToPubSub")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsPublishToPubSub? PublishToPubSub { get; set; }

    /// <summary>Action removing a document from a folder.</summary>
    [JsonPropertyName("removeFromFolderAction")]
    public V1alpha1ContentWarehouseRuleSetSpecRulesActionsRemoveFromFolderAction? RemoveFromFolderAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpecRules
{
    /// <summary>List of actions that are executed when the rule is satisfied.</summary>
    [JsonPropertyName("actions")]
    public IList<V1alpha1ContentWarehouseRuleSetSpecRulesActions>? Actions { get; set; }

    /// <summary>Represents the conditional expression to be evaluated. Expression should evaluate to a boolean result. When the condition is true actions are executed. Example: user_role = &quot;hsbc_role_1&quot; AND doc.salary &gt; 20000</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Short description of the rule and its context.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ID of the rule. It has to be unique across all the examples. This is managed internally.</summary>
    [JsonPropertyName("ruleID")]
    public string? RuleID { get; set; }

    /// <summary>Identifies the trigger type for running the policy.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>ContentWarehouseRuleSetSpec defines the desired state of ContentWarehouseRuleSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetSpec
{
    /// <summary>Short description of the rule-set.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ContentWarehouseRuleSetSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ContentWarehouseRuleSet name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>List of rules given by the customer.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1ContentWarehouseRuleSetSpecRules>? Rules { get; set; }

    /// <summary>Source of the rules i.e., customer name.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetStatusConditions
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

/// <summary>ContentWarehouseRuleSetStatus defines the config connector machine state of ContentWarehouseRuleSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentWarehouseRuleSetStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ContentWarehouseRuleSetStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ContentWarehouseRuleSet resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public JsonNode? ObservedState { get; set; }
}

/// <summary>ContentWarehouseRuleSet is the Schema for the ContentWarehouseRuleSet API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ContentWarehouseRuleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ContentWarehouseRuleSetSpec>, IStatus<V1alpha1ContentWarehouseRuleSetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContentWarehouseRuleSet";
    public const string KubeGroup = "contentwarehouse.cnrm.cloud.google.com";
    public const string KubePluralName = "contentwarehouserulesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "contentwarehouse.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContentWarehouseRuleSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContentWarehouseRuleSetSpec defines the desired state of ContentWarehouseRuleSet</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ContentWarehouseRuleSetSpec Spec { get; set; }

    /// <summary>ContentWarehouseRuleSetStatus defines the config connector machine state of ContentWarehouseRuleSet</summary>
    [JsonPropertyName("status")]
    public V1alpha1ContentWarehouseRuleSetStatus? Status { get; set; }
}