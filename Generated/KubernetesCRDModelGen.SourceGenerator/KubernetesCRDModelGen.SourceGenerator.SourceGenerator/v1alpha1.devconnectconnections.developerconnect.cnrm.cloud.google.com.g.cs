#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.developerconnect.cnrm.cloud.google.com;
/// <summary>DevConnectConnection is the Schema for the DevConnectConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DevConnectConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DevConnectConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DevConnectConnectionList";
    public const string KubeGroup = "developerconnect.cnrm.cloud.google.com";
    public const string KubePluralName = "devconnectconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "developerconnect.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DevConnectConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DevConnectConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DevConnectConnection> Items { get; set; }
}

/// <summary>Required. An access token with the minimum `repository`, `pullrequest` and `webhook` scope access. It can either be a workspace, project or repository access token. This is needed to create webhooks. It&apos;s recommended to use a system account to generate these credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketCloudConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>Required. An access token with the minimum `repository` access. It can either be a workspace, project or repository access token. It&apos;s recommended to use a system account to generate the credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketCloudConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>Configuration for connections to an instance of Bitbucket Clouds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketCloudConfig
{
    /// <summary>Required. An access token with the minimum `repository`, `pullrequest` and `webhook` scope access. It can either be a workspace, project or repository access token. This is needed to create webhooks. It&apos;s recommended to use a system account to generate these credentials.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1DevConnectConnectionSpecBitbucketCloudConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. An access token with the minimum `repository` access. It can either be a workspace, project or repository access token. It&apos;s recommended to use a system account to generate the credentials.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1alpha1DevConnectConnectionSpecBitbucketCloudConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as `projects/*/secrets/*/versions/*`. This is used to validate and create webhooks.</summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }

    /// <summary>Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.</summary>
    [JsonPropertyName("workspace")]
    public string? Workspace { get; set; }
}

/// <summary>Required. An http access token with the minimum `Repository admin` scope access. This is needed to create webhooks. It&apos;s recommended to use a system account to generate these credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>Required. An http access token with the minimum `Repository read` access. It&apos;s recommended to use a system account to generate the credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>The Service Directory service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfigServiceRef
{
    /// <summary>A reference to an externally managed DataprocJob resource. Should be in the format &quot;/projects/*/locations/*/namespaces/*/services/*&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataprocJob resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataprocJob resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for using Service Directory to privately connect to a Bitbucket Data Center instance. This should only be set if the Bitbucket Data Center is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the Bitbucket Data Center will be made over the public internet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfig
{
    /// <summary>The Service Directory service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfigServiceRef? ServiceRef { get; set; }
}

/// <summary>Configuration for connections to an instance of Bitbucket Data Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfig
{
    /// <summary>Required. An http access token with the minimum `Repository admin` scope access. This is needed to create webhooks. It&apos;s recommended to use a system account to generate these credentials.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the Bitbucket Data Center host this connection is for.</summary>
    [JsonPropertyName("hostURI")]
    public string? HostURI { get; set; }

    /// <summary>Required. An http access token with the minimum `Repository read` access. It&apos;s recommended to use a system account to generate the credentials.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>Optional. Configuration for using Service Directory to privately connect to a Bitbucket Data Center instance. This should only be set if the Bitbucket Data Center is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the Bitbucket Data Center will be made over the public internet.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL certificate authority to trust when making requests to Bitbucket Data Center.</summary>
    [JsonPropertyName("sslCACertificate")]
    public string? SslCACertificate { get; set; }

    /// <summary>Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as `projects/*/secrets/*/versions/*`. This is used to validate webhooks.</summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>Optional. The crypto key configuration. This field is used by the Customer-Managed Encryption Keys (CMEK) feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecCryptoKeyConfig
{
    /// <summary>Required. The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key should be in the format of `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
    [JsonPropertyName("keyReference")]
    public string? KeyReference { get; set; }
}

/// <summary>Optional. Configuration for the git proxy feature. Enabling the git proxy allows clients to perform git operations on the repositories linked in the connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitProxyConfig
{
    /// <summary>Optional. Setting this to true allows the git proxy to be used for performing git operations on the repositories linked in the connection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Optional. OAuth credential of the account that authorized the GitHub App. It is recommended to use a robot account instead of a human user account. The OAuth token must be tied to the GitHub App of this config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGithubConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the OAuth token that authorizes the connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("oauthTokenSecretVersion")]
    public string? OauthTokenSecretVersion { get; set; }
}

/// <summary>Configuration for connections to github.com.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGithubConfig
{
    /// <summary>Optional. GitHub App installation id.</summary>
    [JsonPropertyName("appInstallationID")]
    public long? AppInstallationID { get; set; }

    /// <summary>Optional. OAuth credential of the account that authorized the GitHub App. It is recommended to use a robot account instead of a human user account. The OAuth token must be tied to the GitHub App of this config.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1DevConnectConnectionSpecGithubConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. Immutable. The GitHub Application that was installed to the GitHub user or organization.</summary>
    [JsonPropertyName("githubApp")]
    public string? GithubApp { get; set; }
}

/// <summary>The Service Directory service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGithubEnterpriseConfigServiceDirectoryConfigServiceRef
{
    /// <summary>A reference to an externally managed DataprocJob resource. Should be in the format &quot;/projects/*/locations/*/namespaces/*/services/*&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataprocJob resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataprocJob resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for using Service Directory to privately connect to a GitHub Enterprise server. This should only be set if the GitHub Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitHub Enterprise server will be made over the public internet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGithubEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>The Service Directory service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1DevConnectConnectionSpecGithubEnterpriseConfigServiceDirectoryConfigServiceRef? ServiceRef { get; set; }
}

/// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGithubEnterpriseConfig
{
    /// <summary>Optional. ID of the GitHub App created from the manifest.</summary>
    [JsonPropertyName("appID")]
    public long? AppID { get; set; }

    /// <summary>Optional. ID of the installation of the GitHub App.</summary>
    [JsonPropertyName("appInstallationID")]
    public long? AppInstallationID { get; set; }

    /// <summary>Required. The URI of the GitHub Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostURI")]
    public string? HostURI { get; set; }

    /// <summary>Optional. SecretManager resource containing the private key of the GitHub App, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("privateKeySecretVersion")]
    public string? PrivateKeySecretVersion { get; set; }

    /// <summary>Optional. Configuration for using Service Directory to privately connect to a GitHub Enterprise server. This should only be set if the GitHub Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitHub Enterprise server will be made over the public internet.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1alpha1DevConnectConnectionSpecGithubEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL certificate to use for requests to GitHub Enterprise.</summary>
    [JsonPropertyName("sslCACertificate")]
    public string? SslCACertificate { get; set; }

    /// <summary>Optional. SecretManager resource containing the webhook secret of the GitHub App, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>Required. A GitLab personal access token with the minimum `api` scope access and a minimum role of `maintainer`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access and a minimum role of `reporter`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>Configuration for connections to gitlab.com.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabConfig
{
    /// <summary>Required. A GitLab personal access token with the minimum `api` scope access and a minimum role of `maintainer`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1DevConnectConnectionSpecGitlabConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access and a minimum role of `reporter`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1alpha1DevConnectConnectionSpecGitlabConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project, formatted as `projects/*/secrets/*/versions/*`. This is used to validate webhooks.</summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>Required. A GitLab personal access token with the minimum `api` scope access and a minimum role of `maintainer`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access and a minimum role of `reporter`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Developer Connect connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>The Service Directory service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigServiceDirectoryConfigServiceRef
{
    /// <summary>A reference to an externally managed DataprocJob resource. Should be in the format &quot;/projects/*/locations/*/namespaces/*/services/*&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataprocJob resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataprocJob resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for using Service Directory to privately connect to a GitLab Enterprise instance. This should only be set if the GitLab Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitLab Enterprise server will be made over the public internet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>The Service Directory service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigServiceDirectoryConfigServiceRef? ServiceRef { get; set; }
}

/// <summary>Configuration for connections to an instance of GitLab Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfig
{
    /// <summary>Required. A GitLab personal access token with the minimum `api` scope access and a minimum role of `maintainer`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the GitLab Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostURI")]
    public string? HostURI { get; set; }

    /// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access and a minimum role of `reporter`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer Connect has access to.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>Optional. Configuration for using Service Directory to privately connect to a GitLab Enterprise instance. This should only be set if the GitLab Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitLab Enterprise server will be made over the public internet.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL Certificate Authority certificate to use for requests to GitLab Enterprise instance.</summary>
    [JsonPropertyName("sslCACertificate")]
    public string? SslCACertificate { get; set; }

    /// <summary>Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project, formatted as `projects/*/secrets/*/versions/*`. This is used to validate webhooks.</summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpecProjectRef
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

/// <summary>DevConnectConnectionSpec defines the desired state of DevConnectConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionSpec
{
    /// <summary>Optional. Allows clients to store small amounts of arbitrary data.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration for connections to an instance of Bitbucket Clouds.</summary>
    [JsonPropertyName("bitbucketCloudConfig")]
    public V1alpha1DevConnectConnectionSpecBitbucketCloudConfig? BitbucketCloudConfig { get; set; }

    /// <summary>Configuration for connections to an instance of Bitbucket Data Center.</summary>
    [JsonPropertyName("bitbucketDataCenterConfig")]
    public V1alpha1DevConnectConnectionSpecBitbucketDataCenterConfig? BitbucketDataCenterConfig { get; set; }

    /// <summary>Optional. The crypto key configuration. This field is used by the Customer-Managed Encryption Keys (CMEK) feature.</summary>
    [JsonPropertyName("cryptoKeyConfig")]
    public V1alpha1DevConnectConnectionSpecCryptoKeyConfig? CryptoKeyConfig { get; set; }

    /// <summary>Optional. If disabled is set to true, functionality is disabled for this connection. Repository based API methods and webhooks processing for repositories in this connection will be disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Optional. Configuration for the git proxy feature. Enabling the git proxy allows clients to perform git operations on the repositories linked in the connection.</summary>
    [JsonPropertyName("gitProxyConfig")]
    public V1alpha1DevConnectConnectionSpecGitProxyConfig? GitProxyConfig { get; set; }

    /// <summary>Configuration for connections to github.com.</summary>
    [JsonPropertyName("githubConfig")]
    public V1alpha1DevConnectConnectionSpecGithubConfig? GithubConfig { get; set; }

    /// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public V1alpha1DevConnectConnectionSpecGithubEnterpriseConfig? GithubEnterpriseConfig { get; set; }

    /// <summary>Configuration for connections to gitlab.com.</summary>
    [JsonPropertyName("gitlabConfig")]
    public V1alpha1DevConnectConnectionSpecGitlabConfig? GitlabConfig { get; set; }

    /// <summary>Configuration for connections to an instance of GitLab Enterprise.</summary>
    [JsonPropertyName("gitlabEnterpriseConfig")]
    public V1alpha1DevConnectConnectionSpecGitlabEnterpriseConfig? GitlabEnterpriseConfig { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DevConnectConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DevConnectConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionStatusConditions
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

/// <summary>Output only. Installation state of the Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionStatusObservedStateInstallationState
{
    /// <summary>Output only. Link to follow for next action. Empty string if the installation is already complete.</summary>
    [JsonPropertyName("actionURI")]
    public string? ActionURI { get; set; }

    /// <summary>Output only. Message of what the user should do next to continue the installation. Empty string if the installation is already complete.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Output only. Current step of the installation process.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionStatusObservedState
{
    /// <summary>Output only. [Output only] Create timestamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. [Output only] Delete timestamp</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. Installation state of the Connection.</summary>
    [JsonPropertyName("installationState")]
    public V1alpha1DevConnectConnectionStatusObservedStateInstallationState? InstallationState { get; set; }

    /// <summary>Output only. Set to true when the connection is being set up or updated in the background.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. A system-assigned unique identifier for the Connection.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. [Output only] Update timestamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DevConnectConnectionStatus defines the config connector machine state of DevConnectConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DevConnectConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DevConnectConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DevConnectConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DevConnectConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DevConnectConnection is the Schema for the DevConnectConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DevConnectConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DevConnectConnectionSpec>, IStatus<V1alpha1DevConnectConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DevConnectConnection";
    public const string KubeGroup = "developerconnect.cnrm.cloud.google.com";
    public const string KubePluralName = "devconnectconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "developerconnect.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DevConnectConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DevConnectConnectionSpec defines the desired state of DevConnectConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DevConnectConnectionSpec Spec { get; set; }

    /// <summary>DevConnectConnectionStatus defines the config connector machine state of DevConnectConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1DevConnectConnectionStatus? Status { get; set; }
}