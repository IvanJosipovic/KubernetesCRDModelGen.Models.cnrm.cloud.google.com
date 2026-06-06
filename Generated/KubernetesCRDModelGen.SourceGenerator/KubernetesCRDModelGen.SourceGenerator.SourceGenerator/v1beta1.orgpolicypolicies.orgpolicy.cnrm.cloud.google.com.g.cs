#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.orgpolicy.cnrm.cloud.google.com;
/// <summary>OrgPolicyPolicy is the Schema for the OrgPolicyPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrgPolicyPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OrgPolicyPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrgPolicyPolicyList";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "orgpolicy.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrgPolicyPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1OrgPolicyPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1OrgPolicyPolicy> Items { get; set; }
}

/// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos; &lt;ORG_ID&gt;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecDryRunSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Optional. Required for managed constraints if parameters are defined.
///  Passes parameter values when policy enforcement is enabled. Each
///  field corresponds to a known managed-constraint parameter key; the
///  value type matches the type defined in the constraint definition.
///  For example, the essentialcontacts.managed.allowedContactDomains
///  managed constraint takes:
/// 
///      parameters:
///        allowedDomains:
///          - &quot;@example.com&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecDryRunSpecRulesParameters
{
    /// <summary>When true, any Google Kubernetes Engine resource path is permitted.</summary>
    [JsonPropertyName("allowAnyGKEPath")]
    public bool? AllowAnyGKEPath { get; set; }

    /// <summary>Resource paths that are explicitly allowed by the managed constraint.</summary>
    [JsonPropertyName("allowPaths")]
    public IList<string>? AllowPaths { get; set; }

    /// <summary>AWS account IDs that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedAWSAccountIDs")]
    public IList<string>? AllowedAWSAccountIDs { get; set; }

    /// <summary>Data sources that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedDataSources")]
    public IList<string>? AllowedDataSources { get; set; }

    /// <summary>Contact domains that are allowed by the managed constraint (for example, email domains permitted by essentialcontacts.managed.allowedContactDomains).</summary>
    [JsonPropertyName("allowedDomains")]
    public IList<string>? AllowedDomains { get; set; }

    /// <summary>Fully qualified domain names that are allowed for egress traffic.</summary>
    [JsonPropertyName("allowedEgressFQDNs")]
    public IList<string>? AllowedEgressFQDNs { get; set; }

    /// <summary>Encryption types or modes that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedEncryptions")]
    public IList<string>? AllowedEncryptions { get; set; }

    /// <summary>Member subjects (for example, users or service accounts) that are allowed.</summary>
    [JsonPropertyName("allowedMemberSubjects")]
    public IList<string>? AllowedMemberSubjects { get; set; }

    /// <summary>Parent resources (organizations, folders, or projects) that are allowed.</summary>
    [JsonPropertyName("allowedParents")]
    public IList<string>? AllowedParents { get; set; }

    /// <summary>Preview features that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedPreviewFeatures")]
    public IList<string>? AllowedPreviewFeatures { get; set; }

    /// <summary>Principal sets that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedPrincipalSets")]
    public IList<string>? AllowedPrincipalSets { get; set; }

    /// <summary>Providers that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedProviders")]
    public IList<string>? AllowedProviders { get; set; }

    /// <summary>Retention durations (in seconds) that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedRetentionDurationSeconds")]
    public long? AllowedRetentionDurationSeconds { get; set; }

    /// <summary>Retention periods that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedRetentionPeriods")]
    public IList<string>? AllowedRetentionPeriods { get; set; }

    /// <summary>URI schemes that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedSchemes")]
    public IList<string>? AllowedSchemes { get; set; }

    /// <summary>Services that are allowed by the managed constraint (service list form).</summary>
    [JsonPropertyName("allowedServiceList")]
    public IList<string>? AllowedServiceList { get; set; }

    /// <summary>Services that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Default AWS provider used when no explicit provider is specified.</summary>
    [JsonPropertyName("defaultAWSProvider")]
    public string? DefaultAWSProvider { get; set; }

    /// <summary>Default XML service provider used when no explicit provider is specified.</summary>
    [JsonPropertyName("defaultXMLServiceProvider")]
    public string? DefaultXMLServiceProvider { get; set; }

    /// <summary>Editions that are denied by the managed constraint.</summary>
    [JsonPropertyName("deniedEditions")]
    public IList<string>? DeniedEditions { get; set; }

    /// <summary>Projects where the managed constraint is enforced.</summary>
    [JsonPropertyName("enforcedProjects")]
    public IList<string>? EnforcedProjects { get; set; }

    /// <summary>Minimum destroy schedule duration, in days, required by the managed constraint.</summary>
    [JsonPropertyName("minimumDestroyScheduleDurationInDays")]
    public long? MinimumDestroyScheduleDurationInDays { get; set; }

    /// <summary>Compute Engine machine types that are not FIPS-compliant but are allowed.</summary>
    [JsonPropertyName("nonFIPSMachineTypes")]
    public IList<string>? NonFIPSMachineTypes { get; set; }
}

/// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecDryRunSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecDryRunSpecRules
{
    /// <summary>Setting this to true means that all values are allowed. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public bool? AllowAll { get; set; }

    /// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos; &lt;ORG_ID&gt;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.</summary>
    [JsonPropertyName("condition")]
    public V1beta1OrgPolicyPolicySpecDryRunSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to true means that all values are denied. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public bool? DenyAll { get; set; }

    /// <summary>If `true`, then the policy is enforced. If `false`, then any configuration is acceptable. This field can be set only in policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>
    /// Optional. Required for managed constraints if parameters are defined.
    ///  Passes parameter values when policy enforcement is enabled. Each
    ///  field corresponds to a known managed-constraint parameter key; the
    ///  value type matches the type defined in the constraint definition.
    ///  For example, the essentialcontacts.managed.allowedContactDomains
    ///  managed constraint takes:
    /// 
    ///      parameters:
    ///        allowedDomains:
    ///          - &quot;@example.com&quot;
    /// </summary>
    [JsonPropertyName("parameters")]
    public V1beta1OrgPolicyPolicySpecDryRunSpecRulesParameters? Parameters { get; set; }

    /// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("values")]
    public V1beta1OrgPolicyPolicySpecDryRunSpecRulesValues? Values { get; set; }
}

/// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecDryRunSpec
{
    /// <summary>
    /// Determines the inheritance behavior for this policy.
    /// 
    ///  If `inherit_from_parent` is true, policy rules set higher up in the
    ///  hierarchy (up to the closest root) are inherited and present in the
    ///  effective policy. If it is false, then no rules are inherited, and this
    ///  policy becomes the new root for evaluation.
    ///  This field can be set only for policies which configure list constraints.
    /// </summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, `rules` must be empty and `inherit_from_parent` must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In policies for boolean constraints, the following requirements apply:
    /// 
    ///    - There must be one and only one policy rule where condition is unset.
    ///    - Boolean policy rules with conditions must set `enforced` to the
    ///      opposite of the policy rule without a condition.
    ///    - During policy evaluation, policy rules with conditions that are
    ///      true for a target resource take precedence.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1OrgPolicyPolicySpecDryRunSpecRules>? Rules { get; set; }
}

/// <summary>Immutable. The Folder that this resource belongs to. One and only one of &apos;projectRef&apos;, &apos;folderRef&apos;, or &apos;organizationRef&apos; must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecFolderRef
{
    /// <summary>The &apos;name&apos; field of a folder, when not managed by Config Connector. This field must be set when &apos;name&apos; field is not set.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The &apos;name&apos; field of a &apos;Folder&apos; resource. This field must be set when &apos;external&apos; field is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The &apos;namespace&apos; field of a &apos;Folder&apos; resource. If unset, the namespace is defaulted to the namespace of the referencer resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Organization that this resource belongs to. One and only one of &apos;projectRef&apos;, &apos;folderRef&apos;, or &apos;organizationRef&apos; must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public required string External { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to. One and only one of &apos;projectRef&apos;, &apos;folderRef&apos;, or &apos;organizationRef&apos; must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecProjectRef
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

/// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos; &lt;ORG_ID&gt;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Optional. Required for managed constraints if parameters are defined.
///  Passes parameter values when policy enforcement is enabled. Each
///  field corresponds to a known managed-constraint parameter key; the
///  value type matches the type defined in the constraint definition.
///  For example, the essentialcontacts.managed.allowedContactDomains
///  managed constraint takes:
/// 
///      parameters:
///        allowedDomains:
///          - &quot;@example.com&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecSpecRulesParameters
{
    /// <summary>When true, any Google Kubernetes Engine resource path is permitted.</summary>
    [JsonPropertyName("allowAnyGKEPath")]
    public bool? AllowAnyGKEPath { get; set; }

    /// <summary>Resource paths that are explicitly allowed by the managed constraint.</summary>
    [JsonPropertyName("allowPaths")]
    public IList<string>? AllowPaths { get; set; }

    /// <summary>AWS account IDs that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedAWSAccountIDs")]
    public IList<string>? AllowedAWSAccountIDs { get; set; }

    /// <summary>Data sources that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedDataSources")]
    public IList<string>? AllowedDataSources { get; set; }

    /// <summary>Contact domains that are allowed by the managed constraint (for example, email domains permitted by essentialcontacts.managed.allowedContactDomains).</summary>
    [JsonPropertyName("allowedDomains")]
    public IList<string>? AllowedDomains { get; set; }

    /// <summary>Fully qualified domain names that are allowed for egress traffic.</summary>
    [JsonPropertyName("allowedEgressFQDNs")]
    public IList<string>? AllowedEgressFQDNs { get; set; }

    /// <summary>Encryption types or modes that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedEncryptions")]
    public IList<string>? AllowedEncryptions { get; set; }

    /// <summary>Member subjects (for example, users or service accounts) that are allowed.</summary>
    [JsonPropertyName("allowedMemberSubjects")]
    public IList<string>? AllowedMemberSubjects { get; set; }

    /// <summary>Parent resources (organizations, folders, or projects) that are allowed.</summary>
    [JsonPropertyName("allowedParents")]
    public IList<string>? AllowedParents { get; set; }

    /// <summary>Preview features that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedPreviewFeatures")]
    public IList<string>? AllowedPreviewFeatures { get; set; }

    /// <summary>Principal sets that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedPrincipalSets")]
    public IList<string>? AllowedPrincipalSets { get; set; }

    /// <summary>Providers that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedProviders")]
    public IList<string>? AllowedProviders { get; set; }

    /// <summary>Retention durations (in seconds) that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedRetentionDurationSeconds")]
    public long? AllowedRetentionDurationSeconds { get; set; }

    /// <summary>Retention periods that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedRetentionPeriods")]
    public IList<string>? AllowedRetentionPeriods { get; set; }

    /// <summary>URI schemes that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedSchemes")]
    public IList<string>? AllowedSchemes { get; set; }

    /// <summary>Services that are allowed by the managed constraint (service list form).</summary>
    [JsonPropertyName("allowedServiceList")]
    public IList<string>? AllowedServiceList { get; set; }

    /// <summary>Services that are allowed by the managed constraint.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Default AWS provider used when no explicit provider is specified.</summary>
    [JsonPropertyName("defaultAWSProvider")]
    public string? DefaultAWSProvider { get; set; }

    /// <summary>Default XML service provider used when no explicit provider is specified.</summary>
    [JsonPropertyName("defaultXMLServiceProvider")]
    public string? DefaultXMLServiceProvider { get; set; }

    /// <summary>Editions that are denied by the managed constraint.</summary>
    [JsonPropertyName("deniedEditions")]
    public IList<string>? DeniedEditions { get; set; }

    /// <summary>Projects where the managed constraint is enforced.</summary>
    [JsonPropertyName("enforcedProjects")]
    public IList<string>? EnforcedProjects { get; set; }

    /// <summary>Minimum destroy schedule duration, in days, required by the managed constraint.</summary>
    [JsonPropertyName("minimumDestroyScheduleDurationInDays")]
    public long? MinimumDestroyScheduleDurationInDays { get; set; }

    /// <summary>Compute Engine machine types that are not FIPS-compliant but are allowed.</summary>
    [JsonPropertyName("nonFIPSMachineTypes")]
    public IList<string>? NonFIPSMachineTypes { get; set; }
}

/// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecSpecRules
{
    /// <summary>Setting this to true means that all values are allowed. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public bool? AllowAll { get; set; }

    /// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos; &lt;ORG_ID&gt;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.</summary>
    [JsonPropertyName("condition")]
    public V1beta1OrgPolicyPolicySpecSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to true means that all values are denied. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public bool? DenyAll { get; set; }

    /// <summary>If `true`, then the policy is enforced. If `false`, then any configuration is acceptable. This field can be set only in policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>
    /// Optional. Required for managed constraints if parameters are defined.
    ///  Passes parameter values when policy enforcement is enabled. Each
    ///  field corresponds to a known managed-constraint parameter key; the
    ///  value type matches the type defined in the constraint definition.
    ///  For example, the essentialcontacts.managed.allowedContactDomains
    ///  managed constraint takes:
    /// 
    ///      parameters:
    ///        allowedDomains:
    ///          - &quot;@example.com&quot;
    /// </summary>
    [JsonPropertyName("parameters")]
    public V1beta1OrgPolicyPolicySpecSpecRulesParameters? Parameters { get; set; }

    /// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("values")]
    public V1beta1OrgPolicyPolicySpecSpecRulesValues? Values { get; set; }
}

/// <summary>Basic information about the Organization Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpecSpec
{
    /// <summary>
    /// Determines the inheritance behavior for this policy.
    /// 
    ///  If `inherit_from_parent` is true, policy rules set higher up in the
    ///  hierarchy (up to the closest root) are inherited and present in the
    ///  effective policy. If it is false, then no rules are inherited, and this
    ///  policy becomes the new root for evaluation.
    ///  This field can be set only for policies which configure list constraints.
    /// </summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, `rules` must be empty and `inherit_from_parent` must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In policies for boolean constraints, the following requirements apply:
    /// 
    ///    - There must be one and only one policy rule where condition is unset.
    ///    - Boolean policy rules with conditions must set `enforced` to the
    ///      opposite of the policy rule without a condition.
    ///    - During policy evaluation, policy rules with conditions that are
    ///      true for a target resource take precedence.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1OrgPolicyPolicySpecSpecRules>? Rules { get; set; }
}

/// <summary>OrgPolicyPolicySpec defines the desired state of OrgPolicyPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicySpec
{
    /// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.</summary>
    [JsonPropertyName("dryRunSpec")]
    public V1beta1OrgPolicyPolicySpecDryRunSpec? DryRunSpec { get; set; }

    /// <summary>Immutable. The Folder that this resource belongs to. One and only one of &apos;projectRef&apos;, &apos;folderRef&apos;, or &apos;organizationRef&apos; must be set.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1OrgPolicyPolicySpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. One and only one of &apos;projectRef&apos;, &apos;folderRef&apos;, or &apos;organizationRef&apos; must be set.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1OrgPolicyPolicySpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. One and only one of &apos;projectRef&apos;, &apos;folderRef&apos;, or &apos;organizationRef&apos; must be set.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1OrgPolicyPolicySpecProjectRef? ProjectRef { get; set; }

    /// <summary>The OrgPolicyPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Basic information about the Organization Policy.</summary>
    [JsonPropertyName("spec")]
    public V1beta1OrgPolicyPolicySpecSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicyStatusConditions
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

/// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicyStatusObservedStateDryRunSpec
{
    /// <summary>Output only. The time stamp this was previously updated. This represents the last time a call to `CreatePolicy` or `UpdatePolicy` was made for that policy.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Basic information about the Organization Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicyStatusObservedStateSpec
{
    /// <summary>Output only. The time stamp this was previously updated. This represents the last time a call to `CreatePolicy` or `UpdatePolicy` was made for that policy.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicyStatusObservedState
{
    /// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.</summary>
    [JsonPropertyName("dryRunSpec")]
    public V1beta1OrgPolicyPolicyStatusObservedStateDryRunSpec? DryRunSpec { get; set; }

    /// <summary>Basic information about the Organization Policy.</summary>
    [JsonPropertyName("spec")]
    public V1beta1OrgPolicyPolicyStatusObservedStateSpec? Spec { get; set; }
}

/// <summary>OrgPolicyPolicyStatus defines the config connector machine state of OrgPolicyPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrgPolicyPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OrgPolicyPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the OrgPolicyPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1OrgPolicyPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>OrgPolicyPolicy is the Schema for the OrgPolicyPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrgPolicyPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OrgPolicyPolicySpec>, IStatus<V1beta1OrgPolicyPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrgPolicyPolicy";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "orgpolicy.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrgPolicyPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrgPolicyPolicySpec defines the desired state of OrgPolicyPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1OrgPolicyPolicySpec Spec { get; set; }

    /// <summary>OrgPolicyPolicyStatus defines the config connector machine state of OrgPolicyPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1OrgPolicyPolicyStatus? Status { get; set; }
}