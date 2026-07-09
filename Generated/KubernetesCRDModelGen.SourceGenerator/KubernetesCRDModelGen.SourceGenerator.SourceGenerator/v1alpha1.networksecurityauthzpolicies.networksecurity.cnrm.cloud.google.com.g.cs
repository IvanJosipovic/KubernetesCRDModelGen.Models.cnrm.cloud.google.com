#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecurityAuthzPolicy is the Schema for the NetworkSecurityAuthzPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityAuthzPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecurityAuthzPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityAuthzPolicyList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityauthzpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityAuthzPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecurityAuthzPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecurityAuthzPolicy> Items { get; set; }
}

/// <summary>Optional. Delegate authorization decision to user authored Service Extension. Only one of cloudIap or authzExtension can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecCustomProviderAuthzExtension
{
    /// <summary>Required. A list of references to authorization extensions that will be invoked for requests matching this policy. Limited to 1 custom provider.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }
}

/// <summary>Optional. Delegates authorization decisions to Cloud IAP. Applicable only for managed load balancers. Enabling Cloud IAP at the AuthzPolicy level is not compatible with Cloud IAP settings in the BackendService. Enabling IAP in both places will result in request failure. Ensure that IAP is enabled in either the AuthzPolicy or the BackendService but not in both places.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecCustomProviderCloudIAP
{
    /// <summary>Optional. If True, Cloud IAP is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Optional. Required if the action is `CUSTOM`. Allows delegating authorization decisions to Cloud IAP or to Service Extensions. One of `cloudIap` or `authzExtension` must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecCustomProvider
{
    /// <summary>Optional. Delegate authorization decision to user authored Service Extension. Only one of cloudIap or authzExtension can be specified.</summary>
    [JsonPropertyName("authzExtension")]
    public V1alpha1NetworkSecurityAuthzPolicySpecCustomProviderAuthzExtension? AuthzExtension { get; set; }

    /// <summary>Optional. Delegates authorization decisions to Cloud IAP. Applicable only for managed load balancers. Enabling Cloud IAP at the AuthzPolicy level is not compatible with Cloud IAP settings in the BackendService. Enabling IAP in both places will result in request failure. Ensure that IAP is enabled in either the AuthzPolicy or the BackendService but not in both places.</summary>
    [JsonPropertyName("cloudIAP")]
    public V1alpha1NetworkSecurityAuthzPolicySpecCustomProviderCloudIAP? CloudIAP { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesIpBlocks
{
    /// <summary>Required. The length of the address range.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Required. The address prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesPrincipalsPrincipal
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesPrincipals
{
    /// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
    [JsonPropertyName("principal")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesPrincipalsPrincipal? Principal { get; set; }

    /// <summary>Optional. An enum to decide what principal value the principal rule will match against. If not specified, the PrincipalSelector is CLIENT_CERT_URI_SAN.</summary>
    [JsonPropertyName("principalSelector")]
    public string? PrincipalSelector { get; set; }
}

/// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResourcesIamServiceAccount
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>TagsTagValueRef is a reference to a TagsTagValue resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResourcesTagValueIDSetTagValues
{
    /// <summary>A reference to an externally managed TagsTagValue resource. Should be in the format &quot;tagValues/{{tagValueID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a TagsTagValue resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a TagsTagValue resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResourcesTagValueIDSet
{
    /// <summary>Optional. References to TagsTagValue resources.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResourcesTagValueIDSetTagValues>? TagValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResources
{
    /// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
    [JsonPropertyName("iamServiceAccount")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResourcesIamServiceAccount? IamServiceAccount { get; set; }

    /// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
    [JsonPropertyName("tagValueIDSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResourcesTagValueIDSet? TagValueIDSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSources
{
    /// <summary>Optional. A list of IP addresses or IP address ranges to match against the source IP address of the request. Limited to 10 ip_blocks per Authorization Policy</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesIpBlocks>? IpBlocks { get; set; }

    /// <summary>Optional. A list of identities derived from the client&apos;s certificate. This field will not match on a request unless frontend mutual TLS is enabled for the forwarding rule or Gateway and the client certificate has been successfully validated by mTLS. Each identity is a string whose value is matched against a list of URI SANs, DNS Name SANs, or the common name in the client&apos;s certificate. A match happens when any principal matches with the rule. Limited to 50 principals per Authorization Policy for regional internal Application Load Balancers, regional external Application Load Balancers, cross-region internal Application Load Balancers, and Cloud Service Mesh. This field is not supported for global external Application Load Balancers.</summary>
    [JsonPropertyName("principals")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesPrincipals>? Principals { get; set; }

    /// <summary>Optional. A list of resources to match against the resource of the source VM of a request. Limited to 10 resources per Authorization Policy.</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSourcesResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesIpBlocks
{
    /// <summary>Required. The length of the address range.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Required. The address prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesPrincipalsPrincipal
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesPrincipals
{
    /// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
    [JsonPropertyName("principal")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesPrincipalsPrincipal? Principal { get; set; }

    /// <summary>Optional. An enum to decide what principal value the principal rule will match against. If not specified, the PrincipalSelector is CLIENT_CERT_URI_SAN.</summary>
    [JsonPropertyName("principalSelector")]
    public string? PrincipalSelector { get; set; }
}

/// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResourcesIamServiceAccount
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>TagsTagValueRef is a reference to a TagsTagValue resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResourcesTagValueIDSetTagValues
{
    /// <summary>A reference to an externally managed TagsTagValue resource. Should be in the format &quot;tagValues/{{tagValueID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a TagsTagValue resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a TagsTagValue resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResourcesTagValueIDSet
{
    /// <summary>Optional. References to TagsTagValue resources.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResourcesTagValueIDSetTagValues>? TagValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResources
{
    /// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
    [JsonPropertyName("iamServiceAccount")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResourcesIamServiceAccount? IamServiceAccount { get; set; }

    /// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
    [JsonPropertyName("tagValueIDSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResourcesTagValueIDSet? TagValueIDSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSources
{
    /// <summary>Optional. A list of IP addresses or IP address ranges to match against the source IP address of the request. Limited to 10 ip_blocks per Authorization Policy</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesIpBlocks>? IpBlocks { get; set; }

    /// <summary>Optional. A list of identities derived from the client&apos;s certificate. This field will not match on a request unless frontend mutual TLS is enabled for the forwarding rule or Gateway and the client certificate has been successfully validated by mTLS. Each identity is a string whose value is matched against a list of URI SANs, DNS Name SANs, or the common name in the client&apos;s certificate. A match happens when any principal matches with the rule. Limited to 50 principals per Authorization Policy for regional internal Application Load Balancers, regional external Application Load Balancers, cross-region internal Application Load Balancers, and Cloud Service Mesh. This field is not supported for global external Application Load Balancers.</summary>
    [JsonPropertyName("principals")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesPrincipals>? Principals { get; set; }

    /// <summary>Optional. A list of resources to match against the resource of the source VM of a request. Limited to 10 resources per Authorization Policy.</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSourcesResources>? Resources { get; set; }
}

/// <summary>Optional. Describes properties of a source of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFrom
{
    /// <summary>Optional. Describes the negated properties of request sources. Matches requests from sources that do not match the criteria specified in this field. At least one of sources or notSources must be specified.</summary>
    [JsonPropertyName("notSources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromNotSources>? NotSources { get; set; }

    /// <summary>Optional. Describes the properties of a request&apos;s sources. At least one of sources or notSources must be specified. Limited to 1 source. A match occurs when ANY source (in sources or notSources) matches the request. Within a single source, the match follows AND semantics across fields and OR semantics within a single field, i.e. a match occurs when ANY principal matches AND ANY ipBlocks match.</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFromSources>? Sources { get; set; }
}

/// <summary>Optional. Specifies how the header match will be performed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHeaderSetHeadersValue
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHeaderSetHeaders
{
    /// <summary>Optional. Specifies the name of the header in the request.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Specifies how the header match will be performed.</summary>
    [JsonPropertyName("value")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHeaderSetHeadersValue? Value { get; set; }
}

/// <summary>Optional. A list of headers to match against in http header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHeaderSet
{
    /// <summary>Required. A list of headers to match against in http header. The match can be one of exact, prefix, suffix, or contains (substring match). The match follows AND semantics which means all the headers must match. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 headers per Authorization Policy.</summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHeaderSetHeaders>? Headers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHosts
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsMcpMethodsParams
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsMcpMethods
{
    /// <summary>Required. The MCP method to match against. Allowed values are as follows: 1. `tools`, `prompts`, `resources` - these will match against all sub methods under the respective methods. 2. `prompts/list`, `tools/list`, `resources/list`, `resources/templates/list` 3. `prompts/get`, `tools/call`, `resources/subscribe`, `resources/unsubscribe`, `resources/read` Params cannot be specified for categories 1 and 2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. A list of MCP method parameters to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 MCP method parameters per Authorization Policy.</summary>
    [JsonPropertyName("params")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsMcpMethodsParams>? Params { get; set; }
}

/// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsMcp
{
    /// <summary>Optional. If specified, matches on the MCP protocol’s non-access specific methods namely: * initialize * completion/ * logging/ * notifications/ * ping Defaults to SKIP_BASE_PROTOCOL_METHODS if not specified.</summary>
    [JsonPropertyName("baseProtocolMethodsOption")]
    public string? BaseProtocolMethodsOption { get; set; }

    /// <summary>Optional. A list of MCP methods and associated parameters to match on. It is recommended to use this field to match on tools, prompts and resource accesses while setting the baseProtocolMethodsOption to MATCH_BASE_PROTOCOL_METHODS to match on all the other MCP protocol methods. Limited to 10 MCP methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsMcpMethods>? Methods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsPaths
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsSnis
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperations
{
    /// <summary>Optional. A list of headers to match against in http header.</summary>
    [JsonPropertyName("headerSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHeaderSet? HeaderSet { get; set; }

    /// <summary>Optional. A list of HTTP Hosts to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 hosts per Authorization Policy.</summary>
    [JsonPropertyName("hosts")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsHosts>? Hosts { get; set; }

    /// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
    [JsonPropertyName("mcp")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsMcp? Mcp { get; set; }

    /// <summary>Optional. A list of HTTP methods to match against. Each entry must be a valid HTTP method name (GET, PUT, POST, HEAD, PATCH, DELETE, OPTIONS). It only allows exact match and is always case sensitive. Limited to 10 methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Optional. A list of paths to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 paths per Authorization Policy. Note that this path match includes the query parameters. For gRPC services, this should be a fully-qualified name of the form /package.service/method.</summary>
    [JsonPropertyName("paths")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsPaths>? Paths { get; set; }

    /// <summary>Optional. A list of SNIs to match against. The match can be one of exact, prefix, suffix, or contains (substring match). If there is no SNI (i.e. plaintext HTTP traffic), the request will be denied. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 SNIs per Authorization Policy.</summary>
    [JsonPropertyName("snis")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperationsSnis>? Snis { get; set; }
}

/// <summary>Optional. Specifies how the header match will be performed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHeaderSetHeadersValue
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHeaderSetHeaders
{
    /// <summary>Optional. Specifies the name of the header in the request.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Specifies how the header match will be performed.</summary>
    [JsonPropertyName("value")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHeaderSetHeadersValue? Value { get; set; }
}

/// <summary>Optional. A list of headers to match against in http header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHeaderSet
{
    /// <summary>Required. A list of headers to match against in http header. The match can be one of exact, prefix, suffix, or contains (substring match). The match follows AND semantics which means all the headers must match. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 headers per Authorization Policy.</summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHeaderSetHeaders>? Headers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHosts
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsMcpMethodsParams
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsMcpMethods
{
    /// <summary>Required. The MCP method to match against. Allowed values are as follows: 1. `tools`, `prompts`, `resources` - these will match against all sub methods under the respective methods. 2. `prompts/list`, `tools/list`, `resources/list`, `resources/templates/list` 3. `prompts/get`, `tools/call`, `resources/subscribe`, `resources/unsubscribe`, `resources/read` Params cannot be specified for categories 1 and 2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. A list of MCP method parameters to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 MCP method parameters per Authorization Policy.</summary>
    [JsonPropertyName("params")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsMcpMethodsParams>? Params { get; set; }
}

/// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsMcp
{
    /// <summary>Optional. If specified, matches on the MCP protocol’s non-access specific methods namely: * initialize * completion/ * logging/ * notifications/ * ping Defaults to SKIP_BASE_PROTOCOL_METHODS if not specified.</summary>
    [JsonPropertyName("baseProtocolMethodsOption")]
    public string? BaseProtocolMethodsOption { get; set; }

    /// <summary>Optional. A list of MCP methods and associated parameters to match on. It is recommended to use this field to match on tools, prompts and resource accesses while setting the baseProtocolMethodsOption to MATCH_BASE_PROTOCOL_METHODS to match on all the other MCP protocol methods. Limited to 10 MCP methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsMcpMethods>? Methods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsPaths
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsSnis
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperations
{
    /// <summary>Optional. A list of headers to match against in http header.</summary>
    [JsonPropertyName("headerSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHeaderSet? HeaderSet { get; set; }

    /// <summary>Optional. A list of HTTP Hosts to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 hosts per Authorization Policy.</summary>
    [JsonPropertyName("hosts")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsHosts>? Hosts { get; set; }

    /// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
    [JsonPropertyName("mcp")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsMcp? Mcp { get; set; }

    /// <summary>Optional. A list of HTTP methods to match against. Each entry must be a valid HTTP method name (GET, PUT, POST, HEAD, PATCH, DELETE, OPTIONS). It only allows exact match and is always case sensitive. Limited to 10 methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Optional. A list of paths to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 paths per Authorization Policy. Note that this path match includes the query parameters. For gRPC services, this should be a fully-qualified name of the form /package.service/method.</summary>
    [JsonPropertyName("paths")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsPaths>? Paths { get; set; }

    /// <summary>Optional. A list of SNIs to match against. The match can be one of exact, prefix, suffix, or contains (substring match). If there is no SNI (i.e. plaintext HTTP traffic), the request will be denied. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 SNIs per Authorization Policy.</summary>
    [JsonPropertyName("snis")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperationsSnis>? Snis { get; set; }
}

/// <summary>Optional. Describes properties of a target of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesTo
{
    /// <summary>Optional. Describes the negated properties of the targets of a request. Matches requests for operations that do not match the criteria specified in this field. At least one of operations or notOperations must be specified.</summary>
    [JsonPropertyName("notOperations")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToNotOperations>? NotOperations { get; set; }

    /// <summary>Optional. Describes properties of one or more targets of a request. At least one of operations or notOperations must be specified. Limited to 1 operation. A match occurs when ANY operation (in operations or notOperations) matches. Within an operation, the match follows AND semantics across fields and OR semantics within a field, i.e. a match occurs when ANY path matches AND ANY header matches and ANY method matches.</summary>
    [JsonPropertyName("operations")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesToOperations>? Operations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecHttpRules
{
    /// <summary>Optional. Describes properties of a source of a request.</summary>
    [JsonPropertyName("from")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesFrom? From { get; set; }

    /// <summary>Optional. Describes properties of a target of a request.</summary>
    [JsonPropertyName("to")]
    public V1alpha1NetworkSecurityAuthzPolicySpecHttpRulesTo? To { get; set; }

    /// <summary>Optional. CEL expression that describes the conditions to be satisfied for the action. The result of the CEL expression is ANDed with the from and to. Refer to the CEL language reference for a list of available attributes.</summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesIpBlocks
{
    /// <summary>Required. The length of the address range.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Required. The address prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesPrincipalsPrincipal
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesPrincipals
{
    /// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
    [JsonPropertyName("principal")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesPrincipalsPrincipal? Principal { get; set; }

    /// <summary>Optional. An enum to decide what principal value the principal rule will match against. If not specified, the PrincipalSelector is CLIENT_CERT_URI_SAN.</summary>
    [JsonPropertyName("principalSelector")]
    public string? PrincipalSelector { get; set; }
}

/// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResourcesIamServiceAccount
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>TagsTagValueRef is a reference to a TagsTagValue resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResourcesTagValueIDSetTagValues
{
    /// <summary>A reference to an externally managed TagsTagValue resource. Should be in the format &quot;tagValues/{{tagValueID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a TagsTagValue resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a TagsTagValue resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResourcesTagValueIDSet
{
    /// <summary>Optional. References to TagsTagValue resources.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResourcesTagValueIDSetTagValues>? TagValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResources
{
    /// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
    [JsonPropertyName("iamServiceAccount")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResourcesIamServiceAccount? IamServiceAccount { get; set; }

    /// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
    [JsonPropertyName("tagValueIDSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResourcesTagValueIDSet? TagValueIDSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSources
{
    /// <summary>Optional. A list of IP addresses or IP address ranges to match against the source IP address of the request. Limited to 10 ip_blocks per Authorization Policy</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesIpBlocks>? IpBlocks { get; set; }

    /// <summary>Optional. A list of identities derived from the client&apos;s certificate. This field will not match on a request unless frontend mutual TLS is enabled for the forwarding rule or Gateway and the client certificate has been successfully validated by mTLS. Each identity is a string whose value is matched against a list of URI SANs, DNS Name SANs, or the common name in the client&apos;s certificate. A match happens when any principal matches with the rule. Limited to 50 principals per Authorization Policy for regional internal Application Load Balancers, regional external Application Load Balancers, cross-region internal Application Load Balancers, and Cloud Service Mesh. This field is not supported for global external Application Load Balancers.</summary>
    [JsonPropertyName("principals")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesPrincipals>? Principals { get; set; }

    /// <summary>Optional. A list of resources to match against the resource of the source VM of a request. Limited to 10 resources per Authorization Policy.</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSourcesResources>? Resources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesIpBlocks
{
    /// <summary>Required. The length of the address range.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Required. The address prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesPrincipalsPrincipal
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesPrincipals
{
    /// <summary>Required. A non-empty string whose value is matched against the principal value based on the principal_selector. Only exact match can be applied for CLIENT_CERT_URI_SAN, CLIENT_CERT_DNS_NAME_SAN, CLIENT_CERT_COMMON_NAME selectors.</summary>
    [JsonPropertyName("principal")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesPrincipalsPrincipal? Principal { get; set; }

    /// <summary>Optional. An enum to decide what principal value the principal rule will match against. If not specified, the PrincipalSelector is CLIENT_CERT_URI_SAN.</summary>
    [JsonPropertyName("principalSelector")]
    public string? PrincipalSelector { get; set; }
}

/// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResourcesIamServiceAccount
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>TagsTagValueRef is a reference to a TagsTagValue resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResourcesTagValueIDSetTagValues
{
    /// <summary>A reference to an externally managed TagsTagValue resource. Should be in the format &quot;tagValues/{{tagValueID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a TagsTagValue resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a TagsTagValue resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResourcesTagValueIDSet
{
    /// <summary>Optional. References to TagsTagValue resources.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResourcesTagValueIDSetTagValues>? TagValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResources
{
    /// <summary>Optional. An IAM service account to match against the source service account of the VM sending the request.</summary>
    [JsonPropertyName("iamServiceAccount")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResourcesIamServiceAccount? IamServiceAccount { get; set; }

    /// <summary>Optional. A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request.</summary>
    [JsonPropertyName("tagValueIDSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResourcesTagValueIDSet? TagValueIDSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSources
{
    /// <summary>Optional. A list of IP addresses or IP address ranges to match against the source IP address of the request. Limited to 10 ip_blocks per Authorization Policy</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesIpBlocks>? IpBlocks { get; set; }

    /// <summary>Optional. A list of identities derived from the client&apos;s certificate. This field will not match on a request unless frontend mutual TLS is enabled for the forwarding rule or Gateway and the client certificate has been successfully validated by mTLS. Each identity is a string whose value is matched against a list of URI SANs, DNS Name SANs, or the common name in the client&apos;s certificate. A match happens when any principal matches with the rule. Limited to 50 principals per Authorization Policy for regional internal Application Load Balancers, regional external Application Load Balancers, cross-region internal Application Load Balancers, and Cloud Service Mesh. This field is not supported for global external Application Load Balancers.</summary>
    [JsonPropertyName("principals")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesPrincipals>? Principals { get; set; }

    /// <summary>Optional. A list of resources to match against the resource of the source VM of a request. Limited to 10 resources per Authorization Policy.</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSourcesResources>? Resources { get; set; }
}

/// <summary>Optional. Describes properties of a source of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFrom
{
    /// <summary>Optional. Describes the negated properties of request sources. Matches requests from sources that do not match the criteria specified in this field. At least one of sources or notSources must be specified.</summary>
    [JsonPropertyName("notSources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromNotSources>? NotSources { get; set; }

    /// <summary>Optional. Describes the properties of a request&apos;s sources. At least one of sources or notSources must be specified. Limited to 1 source. A match occurs when ANY source (in sources or notSources) matches the request. Within a single source, the match follows AND semantics across fields and OR semantics within a single field, i.e. a match occurs when ANY principal matches AND ANY ipBlocks match.</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFromSources>? Sources { get; set; }
}

/// <summary>Optional. Specifies how the header match will be performed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHeaderSetHeadersValue
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHeaderSetHeaders
{
    /// <summary>Optional. Specifies the name of the header in the request.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Specifies how the header match will be performed.</summary>
    [JsonPropertyName("value")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHeaderSetHeadersValue? Value { get; set; }
}

/// <summary>Optional. A list of headers to match against in http header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHeaderSet
{
    /// <summary>Required. A list of headers to match against in http header. The match can be one of exact, prefix, suffix, or contains (substring match). The match follows AND semantics which means all the headers must match. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 headers per Authorization Policy.</summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHeaderSetHeaders>? Headers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHosts
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsMcpMethodsParams
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsMcpMethods
{
    /// <summary>Required. The MCP method to match against. Allowed values are as follows: 1. `tools`, `prompts`, `resources` - these will match against all sub methods under the respective methods. 2. `prompts/list`, `tools/list`, `resources/list`, `resources/templates/list` 3. `prompts/get`, `tools/call`, `resources/subscribe`, `resources/unsubscribe`, `resources/read` Params cannot be specified for categories 1 and 2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. A list of MCP method parameters to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 MCP method parameters per Authorization Policy.</summary>
    [JsonPropertyName("params")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsMcpMethodsParams>? Params { get; set; }
}

/// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsMcp
{
    /// <summary>Optional. If specified, matches on the MCP protocol’s non-access specific methods namely: * initialize * completion/ * logging/ * notifications/ * ping Defaults to SKIP_BASE_PROTOCOL_METHODS if not specified.</summary>
    [JsonPropertyName("baseProtocolMethodsOption")]
    public string? BaseProtocolMethodsOption { get; set; }

    /// <summary>Optional. A list of MCP methods and associated parameters to match on. It is recommended to use this field to match on tools, prompts and resource accesses while setting the baseProtocolMethodsOption to MATCH_BASE_PROTOCOL_METHODS to match on all the other MCP protocol methods. Limited to 10 MCP methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsMcpMethods>? Methods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsPaths
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsSnis
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperations
{
    /// <summary>Optional. A list of headers to match against in http header.</summary>
    [JsonPropertyName("headerSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHeaderSet? HeaderSet { get; set; }

    /// <summary>Optional. A list of HTTP Hosts to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 hosts per Authorization Policy.</summary>
    [JsonPropertyName("hosts")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsHosts>? Hosts { get; set; }

    /// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
    [JsonPropertyName("mcp")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsMcp? Mcp { get; set; }

    /// <summary>Optional. A list of HTTP methods to match against. Each entry must be a valid HTTP method name (GET, PUT, POST, HEAD, PATCH, DELETE, OPTIONS). It only allows exact match and is always case sensitive. Limited to 10 methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Optional. A list of paths to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 paths per Authorization Policy. Note that this path match includes the query parameters. For gRPC services, this should be a fully-qualified name of the form /package.service/method.</summary>
    [JsonPropertyName("paths")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsPaths>? Paths { get; set; }

    /// <summary>Optional. A list of SNIs to match against. The match can be one of exact, prefix, suffix, or contains (substring match). If there is no SNI (i.e. plaintext HTTP traffic), the request will be denied. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 SNIs per Authorization Policy.</summary>
    [JsonPropertyName("snis")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperationsSnis>? Snis { get; set; }
}

/// <summary>Optional. Specifies how the header match will be performed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHeaderSetHeadersValue
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHeaderSetHeaders
{
    /// <summary>Optional. Specifies the name of the header in the request.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Specifies how the header match will be performed.</summary>
    [JsonPropertyName("value")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHeaderSetHeadersValue? Value { get; set; }
}

/// <summary>Optional. A list of headers to match against in http header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHeaderSet
{
    /// <summary>Required. A list of headers to match against in http header. The match can be one of exact, prefix, suffix, or contains (substring match). The match follows AND semantics which means all the headers must match. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 headers per Authorization Policy.</summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHeaderSetHeaders>? Headers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHosts
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsMcpMethodsParams
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsMcpMethods
{
    /// <summary>Required. The MCP method to match against. Allowed values are as follows: 1. `tools`, `prompts`, `resources` - these will match against all sub methods under the respective methods. 2. `prompts/list`, `tools/list`, `resources/list`, `resources/templates/list` 3. `prompts/get`, `tools/call`, `resources/subscribe`, `resources/unsubscribe`, `resources/read` Params cannot be specified for categories 1 and 2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. A list of MCP method parameters to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 MCP method parameters per Authorization Policy.</summary>
    [JsonPropertyName("params")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsMcpMethodsParams>? Params { get; set; }
}

/// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsMcp
{
    /// <summary>Optional. If specified, matches on the MCP protocol’s non-access specific methods namely: * initialize * completion/ * logging/ * notifications/ * ping Defaults to SKIP_BASE_PROTOCOL_METHODS if not specified.</summary>
    [JsonPropertyName("baseProtocolMethodsOption")]
    public string? BaseProtocolMethodsOption { get; set; }

    /// <summary>Optional. A list of MCP methods and associated parameters to match on. It is recommended to use this field to match on tools, prompts and resource accesses while setting the baseProtocolMethodsOption to MATCH_BASE_PROTOCOL_METHODS to match on all the other MCP protocol methods. Limited to 10 MCP methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsMcpMethods>? Methods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsPaths
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsSnis
{
    /// <summary>
    /// The input string must have the substring specified here.
    ///  Note: empty contains match is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc.def``
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` only matches the value ``abc``.
    /// </summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher ``data`` will match both input string ``Data`` and ``data`` if set to true.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// The input string must have the prefix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``abc.xyz``
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The input string must have the suffix specified here.
    ///  Note: empty prefix is not allowed, please use regex instead.
    /// 
    ///  Examples:
    /// 
    ///  * ``abc`` matches the value ``xyz.abc``
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperations
{
    /// <summary>Optional. A list of headers to match against in http header.</summary>
    [JsonPropertyName("headerSet")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHeaderSet? HeaderSet { get; set; }

    /// <summary>Optional. A list of HTTP Hosts to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 hosts per Authorization Policy.</summary>
    [JsonPropertyName("hosts")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsHosts>? Hosts { get; set; }

    /// <summary>Optional. Defines the MCP protocol attributes to match on. If the MCP payload in the request body cannot be successfully parsed, the request will be denied. This field can be set only for AuthzPolicies targeting AgentGateway resources.</summary>
    [JsonPropertyName("mcp")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsMcp? Mcp { get; set; }

    /// <summary>Optional. A list of HTTP methods to match against. Each entry must be a valid HTTP method name (GET, PUT, POST, HEAD, PATCH, DELETE, OPTIONS). It only allows exact match and is always case sensitive. Limited to 10 methods per Authorization Policy.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Optional. A list of paths to match against. The match can be one of exact, prefix, suffix, or contains (substring match). Matches are always case sensitive unless the ignoreCase is set. Limited to 10 paths per Authorization Policy. Note that this path match includes the query parameters. For gRPC services, this should be a fully-qualified name of the form /package.service/method.</summary>
    [JsonPropertyName("paths")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsPaths>? Paths { get; set; }

    /// <summary>Optional. A list of SNIs to match against. The match can be one of exact, prefix, suffix, or contains (substring match). If there is no SNI (i.e. plaintext HTTP traffic), the request will be denied. Matches are always case sensitive unless the ignoreCase is set. Limited to 10 SNIs per Authorization Policy.</summary>
    [JsonPropertyName("snis")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperationsSnis>? Snis { get; set; }
}

/// <summary>Optional. Describes properties of a target of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesTo
{
    /// <summary>Optional. Describes the negated properties of the targets of a request. Matches requests for operations that do not match the criteria specified in this field. At least one of operations or notOperations must be specified.</summary>
    [JsonPropertyName("notOperations")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToNotOperations>? NotOperations { get; set; }

    /// <summary>Optional. Describes properties of one or more targets of a request. At least one of operations or notOperations must be specified. Limited to 1 operation. A match occurs when ANY operation (in operations or notOperations) matches. Within an operation, the match follows AND semantics across fields and OR semantics within a field, i.e. a match occurs when ANY path matches AND ANY header matches and ANY method matches.</summary>
    [JsonPropertyName("operations")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesToOperations>? Operations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecNetworkRules
{
    /// <summary>Optional. Describes properties of a source of a request.</summary>
    [JsonPropertyName("from")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesFrom? From { get; set; }

    /// <summary>Optional. Describes properties of a target of a request.</summary>
    [JsonPropertyName("to")]
    public V1alpha1NetworkSecurityAuthzPolicySpecNetworkRulesTo? To { get; set; }

    /// <summary>Optional. CEL expression that describes the conditions to be satisfied for the action. The result of the CEL expression is ANDed with the from and to. Refer to the CEL language reference for a list of available attributes.</summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecProjectRef
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

/// <summary>ForwardingRuleRef is a reference to a ComputeForwardingRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecTargetResources
{
    /// <summary>A reference to an externally managed ComputeForwardingRule resource. Should be in the format &quot;projects/{{projectID}}/global/forwardingRules/{{forwardingRuleID}}&quot; or &quot;projects/{{projectID}}/regions/{{region}}/forwardingRules/{{forwardingRuleID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeForwardingRule resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeForwardingRule resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Specifies the set of resources to which this policy should be applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpecTarget
{
    /// <summary>Optional. All gateways and forwarding rules referenced by this policy and extensions must share the same load balancing scheme. Required only when targeting forwarding rules. If targeting Secure Web Proxy, this field must be `INTERNAL_MANAGED` or not specified. Must not be specified when targeting Agent Gateway. Supported values: `INTERNAL_MANAGED` and `EXTERNAL_MANAGED`. For more information, refer to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service).</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>Required. A list of references to the Forwarding Rules, Secure Web Proxy Gateways, or Agent Gateways on which this policy will be applied.</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecTargetResources>? Resources { get; set; }
}

/// <summary>NetworkSecurityAuthzPolicySpec defines the desired state of NetworkSecurityAuthzPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicySpec
{
    /// <summary>
    /// Required. Can be one of `ALLOW`, `DENY`, `CUSTOM`.
    /// 
    ///  When the action is `CUSTOM`, `customProvider` must be specified.
    /// 
    ///  When the action is `ALLOW`, only requests matching the policy will
    ///  be allowed.
    /// 
    ///  When the action is `DENY`, only requests matching the policy will be
    ///  denied.
    /// 
    ///  When a request arrives, the policies are evaluated in the following order:
    /// 
    ///  1. If there is a `CUSTOM` policy that matches the request, the `CUSTOM`
    ///  policy is evaluated using the custom authorization providers and the
    ///  request is denied if the provider rejects the request.
    /// 
    ///  2. If there are any `DENY` policies that match the request, the request
    ///  is denied.
    /// 
    ///  3. If there are no `ALLOW` policies for the resource or if any of the
    ///  `ALLOW` policies match the request, the request is allowed.
    /// 
    ///  4. Else the request is denied by default if none of the configured
    ///  AuthzPolicies with `ALLOW` action match the request.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Optional. Required if the action is `CUSTOM`. Allows delegating authorization decisions to Cloud IAP or to Service Extensions. One of `cloudIap` or `authzExtension` must be specified.</summary>
    [JsonPropertyName("customProvider")]
    public V1alpha1NetworkSecurityAuthzPolicySpecCustomProvider? CustomProvider { get; set; }

    /// <summary>Optional. A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. A list of authorization HTTP rules to match against the incoming request. A policy match occurs when at least one HTTP rule matches the request or when no HTTP rules are specified in the policy. At least one HTTP Rule is required for Allow or Deny Action. Limited to 5 rules.</summary>
    [JsonPropertyName("httpRules")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecHttpRules>? HttpRules { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. A list of authorization network rules to match against the incoming request. A policy match occurs when at least one network rule matches the request. At least one network rule is required for Allow or Deny Action if no HTTP rules are provided. Network rules are mutually exclusive with HTTP rules. Limited to 5 rules.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1alpha1NetworkSecurityAuthzPolicySpecNetworkRules>? NetworkRules { get; set; }

    /// <summary>Optional. Immutable. Defines the type of authorization being performed. If not specified, `REQUEST_AUTHZ` is applied. This field cannot be changed once AuthzPolicy is created.</summary>
    [JsonPropertyName("policyProfile")]
    public string? PolicyProfile { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecurityAuthzPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecurityAuthzPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Specifies the set of resources to which this policy should be applied to.</summary>
    [JsonPropertyName("target")]
    public V1alpha1NetworkSecurityAuthzPolicySpecTarget? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicyStatusConditions
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
public partial class V1alpha1NetworkSecurityAuthzPolicyStatusObservedState
{
    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityAuthzPolicyStatus defines the config connector machine state of NetworkSecurityAuthzPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityAuthzPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecurityAuthzPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecurityAuthzPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecurityAuthzPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecurityAuthzPolicy is the Schema for the NetworkSecurityAuthzPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityAuthzPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecurityAuthzPolicySpec>, IStatus<V1alpha1NetworkSecurityAuthzPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityAuthzPolicy";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityauthzpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityAuthzPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityAuthzPolicySpec defines the desired state of NetworkSecurityAuthzPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkSecurityAuthzPolicySpec Spec { get; set; }

    /// <summary>NetworkSecurityAuthzPolicyStatus defines the config connector machine state of NetworkSecurityAuthzPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecurityAuthzPolicyStatus? Status { get; set; }
}