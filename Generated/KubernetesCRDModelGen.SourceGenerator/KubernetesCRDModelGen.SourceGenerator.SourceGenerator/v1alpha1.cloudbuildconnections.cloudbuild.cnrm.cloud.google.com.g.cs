#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.cnrm.cloud.google.com;
/// <summary>CloudBuildConnection is the Schema for the CloudBuildConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudBuildConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudBuildConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudBuildConnectionList";
    public const string KubeGroup = "cloudbuild.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbuildconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudBuildConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudBuildConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudBuildConnection> Items { get; set; }
}

/// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigAuthorizerCredentialUserTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. An access token with the `webhook`, `repository`, `repository:admin` and `pullrequest` scope access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate these credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigAuthorizerCredentialUserTokenSecretVersionRef UserTokenSecretVersionRef { get; set; }
}

/// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigReadAuthorizerCredentialUserTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. An access token with the `repository` access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate the credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigReadAuthorizerCredentialUserTokenSecretVersionRef UserTokenSecretVersionRef { get; set; }
}

/// <summary>Required. SecretManager resource containing the webhook secret used to verify webhook events, formatted as `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigWebhookSecretSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for connections to Bitbucket Cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketCloudConfig
{
    /// <summary>Required. An access token with the `webhook`, `repository`, `repository:admin` and `pullrequest` scope access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate these credentials.</summary>
    [JsonPropertyName("authorizerCredential")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigAuthorizerCredential AuthorizerCredential { get; set; }

    /// <summary>Required. An access token with the `repository` access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate the credentials.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigReadAuthorizerCredential ReadAuthorizerCredential { get; set; }

    /// <summary>Required. SecretManager resource containing the webhook secret used to verify webhook events, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("webhookSecretSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketCloudConfigWebhookSecretSecretVersionRef WebhookSecretSecretVersionRef { get; set; }

    /// <summary>Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.</summary>
    [JsonPropertyName("workspace")]
    public required string Workspace { get; set; }
}

/// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigAuthorizerCredentialUserTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. A http access token with the `REPO_ADMIN` scope access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigAuthorizerCredentialUserTokenSecretVersionRef UserTokenSecretVersionRef { get; set; }
}

/// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigReadAuthorizerCredentialUserTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. A http access token with the `REPO_READ` access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigReadAuthorizerCredentialUserTokenSecretVersionRef UserTokenSecretVersionRef { get; set; }
}

/// <summary>Required. The Service Directory service name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfigServiceRef
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

/// <summary>Optional. Configuration for using Service Directory to privately connect to a Bitbucket Data Center. This should only be set if the Bitbucket Data Center is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the Bitbucket Data Center will be made over the public internet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfig
{
    /// <summary>Required. The Service Directory service name.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfigServiceRef? ServiceRef { get; set; }
}

/// <summary>Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigWebhookSecretSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for connections to Bitbucket Data Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfig
{
    /// <summary>Required. A http access token with the `REPO_ADMIN` scope access.</summary>
    [JsonPropertyName("authorizerCredential")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigAuthorizerCredential AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the Bitbucket Data Center instance or cluster this connection is for.</summary>
    [JsonPropertyName("hostURI")]
    public required string HostURI { get; set; }

    /// <summary>Required. A http access token with the `REPO_READ` access.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigReadAuthorizerCredential ReadAuthorizerCredential { get; set; }

    /// <summary>Optional. Configuration for using Service Directory to privately connect to a Bitbucket Data Center. This should only be set if the Bitbucket Data Center is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the Bitbucket Data Center will be made over the public internet.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL certificate to use for requests to the Bitbucket Data Center.</summary>
    [JsonPropertyName("sslCA")]
    public string? SslCA { get; set; }

    /// <summary>Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("webhookSecretSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfigWebhookSecretSecretVersionRef WebhookSecretSecretVersionRef { get; set; }
}

/// <summary>A SecretManager resource containing the OAuth token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubConfigAuthorizerCredentialOauthTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>OAuth credential of the account that authorized the Cloud Build GitHub App. It is recommended to use a robot account instead of a human user account. The OAuth token must be tied to the Cloud Build GitHub App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubConfigAuthorizerCredential
{
    /// <summary>A SecretManager resource containing the OAuth token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("oauthTokenSecretVersionRef")]
    public V1alpha1CloudBuildConnectionSpecGithubConfigAuthorizerCredentialOauthTokenSecretVersionRef? OauthTokenSecretVersionRef { get; set; }
}

/// <summary>Configuration for connections to github.com.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubConfig
{
    /// <summary>GitHub App installation id.</summary>
    [JsonPropertyName("appInstallationID")]
    public long? AppInstallationID { get; set; }

    /// <summary>OAuth credential of the account that authorized the Cloud Build GitHub App. It is recommended to use a robot account instead of a human user account. The OAuth token must be tied to the Cloud Build GitHub App.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1CloudBuildConnectionSpecGithubConfigAuthorizerCredential? AuthorizerCredential { get; set; }
}

/// <summary>SecretManager resource containing the private key of the GitHub App, formatted as `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigPrivateKeySecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The Service Directory service name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigServiceDirectoryConfigServiceRef
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

/// <summary>Configuration for using Service Directory to privately connect to a GitHub Enterprise server. This should only be set if the GitHub Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitHub Enterprise server will be made over the public internet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>Required. The Service Directory service name.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigServiceDirectoryConfigServiceRef? ServiceRef { get; set; }
}

/// <summary>SecretManager resource containing the webhook secret of the GitHub App, formatted as `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigWebhookSecretSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfig
{
    /// <summary>Required. API Key used for authentication of webhook events.</summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

    /// <summary>Id of the GitHub App created from the manifest.</summary>
    [JsonPropertyName("appID")]
    public long? AppID { get; set; }

    /// <summary>ID of the installation of the GitHub App.</summary>
    [JsonPropertyName("appInstallationID")]
    public long? AppInstallationID { get; set; }

    /// <summary>The URL-friendly name of the GitHub App.</summary>
    [JsonPropertyName("appSlug")]
    public string? AppSlug { get; set; }

    /// <summary>Required. The URI of the GitHub Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostURI")]
    public required string HostURI { get; set; }

    /// <summary>SecretManager resource containing the private key of the GitHub App, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("privateKeySecretVersionRef")]
    public V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigPrivateKeySecretVersionRef? PrivateKeySecretVersionRef { get; set; }

    /// <summary>Configuration for using Service Directory to privately connect to a GitHub Enterprise server. This should only be set if the GitHub Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitHub Enterprise server will be made over the public internet.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>SSL certificate to use for requests to GitHub Enterprise.</summary>
    [JsonPropertyName("sslCA")]
    public string? SslCA { get; set; }

    /// <summary>SecretManager resource containing the webhook secret of the GitHub App, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("webhookSecretSecretVersionRef")]
    public V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfigWebhookSecretSecretVersionRef? WebhookSecretSecretVersionRef { get; set; }
}

/// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigAuthorizerCredentialUserTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. A GitLab personal access token with the `api` scope access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecGitlabConfigAuthorizerCredentialUserTokenSecretVersionRef UserTokenSecretVersionRef { get; set; }
}

/// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigReadAuthorizerCredentialUserTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigReadAuthorizerCredential
{
    /// <summary>Required. A SecretManager resource containing the user token that authorizes the Cloud Build connection. Format: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("userTokenSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecGitlabConfigReadAuthorizerCredentialUserTokenSecretVersionRef UserTokenSecretVersionRef { get; set; }
}

/// <summary>Required. The Service Directory service name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigServiceDirectoryConfigServiceRef
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

/// <summary>Configuration for using Service Directory to privately connect to a GitLab Enterprise server. This should only be set if the GitLab Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitLab Enterprise server will be made over the public internet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigServiceDirectoryConfig
{
    /// <summary>Required. The Service Directory service name.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1CloudBuildConnectionSpecGitlabConfigServiceDirectoryConfigServiceRef? ServiceRef { get; set; }
}

/// <summary>Required. Immutable. SecretManager resource containing the webhook secret of a GitLab Enterprise project, formatted as `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfigWebhookSecretSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for connections to gitlab.com or an instance of GitLab Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecGitlabConfig
{
    /// <summary>Required. A GitLab personal access token with the `api` scope access.</summary>
    [JsonPropertyName("authorizerCredential")]
    public required V1alpha1CloudBuildConnectionSpecGitlabConfigAuthorizerCredential AuthorizerCredential { get; set; }

    /// <summary>The URI of the GitLab Enterprise host this connection is for. If not specified, the default value is https://gitlab.com.</summary>
    [JsonPropertyName("hostURI")]
    public string? HostURI { get; set; }

    /// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public required V1alpha1CloudBuildConnectionSpecGitlabConfigReadAuthorizerCredential ReadAuthorizerCredential { get; set; }

    /// <summary>Configuration for using Service Directory to privately connect to a GitLab Enterprise server. This should only be set if the GitLab Enterprise server is hosted on-premises and not reachable by public internet. If this field is left empty, calls to the GitLab Enterprise server will be made over the public internet.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1alpha1CloudBuildConnectionSpecGitlabConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>SSL certificate to use for requests to GitLab Enterprise.</summary>
    [JsonPropertyName("sslCA")]
    public string? SslCA { get; set; }

    /// <summary>Required. Immutable. SecretManager resource containing the webhook secret of a GitLab Enterprise project, formatted as `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("webhookSecretSecretVersionRef")]
    public required V1alpha1CloudBuildConnectionSpecGitlabConfigWebhookSecretSecretVersionRef WebhookSecretSecretVersionRef { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpecProjectRef
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

/// <summary>CloudBuildConnectionSpec defines the desired state of CloudBuildConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionSpec
{
    /// <summary>Allows clients to store small amounts of arbitrary data.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration for connections to Bitbucket Cloud.</summary>
    [JsonPropertyName("bitbucketCloudConfig")]
    public V1alpha1CloudBuildConnectionSpecBitbucketCloudConfig? BitbucketCloudConfig { get; set; }

    /// <summary>Configuration for connections to Bitbucket Data Center.</summary>
    [JsonPropertyName("bitbucketDataCenterConfig")]
    public V1alpha1CloudBuildConnectionSpecBitbucketDataCenterConfig? BitbucketDataCenterConfig { get; set; }

    /// <summary>If disabled is set to true, functionality is disabled for this connection. Repository based API methods and webhooks processing for repositories in this connection will be disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Configuration for connections to github.com.</summary>
    [JsonPropertyName("githubConfig")]
    public V1alpha1CloudBuildConnectionSpecGithubConfig? GithubConfig { get; set; }

    /// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public V1alpha1CloudBuildConnectionSpecGithubEnterpriseConfig? GithubEnterpriseConfig { get; set; }

    /// <summary>Configuration for connections to gitlab.com or an instance of GitLab Enterprise.</summary>
    [JsonPropertyName("gitlabConfig")]
    public V1alpha1CloudBuildConnectionSpecGitlabConfig? GitlabConfig { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudBuildConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CloudBuildConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusConditions
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

/// <summary>Required. An access token with the `webhook`, `repository`, `repository:admin` and `pullrequest` scope access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate these credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateBitbucketCloudConfigAuthorizerCredential
{
    /// <summary>Output only. The username associated to this token.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Required. An access token with the `repository` access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate the credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateBitbucketCloudConfigReadAuthorizerCredential
{
    /// <summary>Output only. The username associated to this token.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Configuration for connections to Bitbucket Cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateBitbucketCloudConfig
{
    /// <summary>Required. An access token with the `webhook`, `repository`, `repository:admin` and `pullrequest` scope access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate these credentials.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1CloudBuildConnectionStatusObservedStateBitbucketCloudConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. An access token with the `repository` access. It can be either a workspace, project or repository access token. It&apos;s recommended to use a system account to generate the credentials.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1alpha1CloudBuildConnectionStatusObservedStateBitbucketCloudConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }
}

/// <summary>Configuration for connections to Bitbucket Data Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateBitbucketDataCenterConfig
{
    /// <summary>Output only. Version of the Bitbucket Data Center running on the `host_uri`.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>OAuth credential of the account that authorized the Cloud Build GitHub App. It is recommended to use a robot account instead of a human user account. The OAuth token must be tied to the Cloud Build GitHub App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateGithubConfigAuthorizerCredential
{
    /// <summary>Output only. The username associated to this token.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Configuration for connections to github.com.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateGithubConfig
{
    /// <summary>OAuth credential of the account that authorized the Cloud Build GitHub App. It is recommended to use a robot account instead of a human user account. The OAuth token must be tied to the Cloud Build GitHub App.</summary>
    [JsonPropertyName("authorizerCredential")]
    public V1alpha1CloudBuildConnectionStatusObservedStateGithubConfigAuthorizerCredential? AuthorizerCredential { get; set; }
}

/// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateGithubEnterpriseConfig
{
    /// <summary>Output only. GitHub Enterprise version installed at the host_uri.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateGitlabConfigReadAuthorizerCredential
{
    /// <summary>Output only. The username associated to this token.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Configuration for connections to gitlab.com or an instance of GitLab Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateGitlabConfig
{
    /// <summary>Required. A GitLab personal access token with the minimum `read_api` scope access.</summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1alpha1CloudBuildConnectionStatusObservedStateGitlabConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>Output only. Version of the GitLab Enterprise server running on the `host_uri`.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>Output only. Installation state of the Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatusObservedStateInstallationState
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
public partial class V1alpha1CloudBuildConnectionStatusObservedState
{
    /// <summary>Configuration for connections to Bitbucket Cloud.</summary>
    [JsonPropertyName("bitbucketCloudConfig")]
    public V1alpha1CloudBuildConnectionStatusObservedStateBitbucketCloudConfig? BitbucketCloudConfig { get; set; }

    /// <summary>Configuration for connections to Bitbucket Data Center.</summary>
    [JsonPropertyName("bitbucketDataCenterConfig")]
    public V1alpha1CloudBuildConnectionStatusObservedStateBitbucketDataCenterConfig? BitbucketDataCenterConfig { get; set; }

    /// <summary>Output only. Server assigned timestamp for when the connection was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Configuration for connections to github.com.</summary>
    [JsonPropertyName("githubConfig")]
    public V1alpha1CloudBuildConnectionStatusObservedStateGithubConfig? GithubConfig { get; set; }

    /// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public V1alpha1CloudBuildConnectionStatusObservedStateGithubEnterpriseConfig? GithubEnterpriseConfig { get; set; }

    /// <summary>Configuration for connections to gitlab.com or an instance of GitLab Enterprise.</summary>
    [JsonPropertyName("gitlabConfig")]
    public V1alpha1CloudBuildConnectionStatusObservedStateGitlabConfig? GitlabConfig { get; set; }

    /// <summary>Output only. Installation state of the Connection.</summary>
    [JsonPropertyName("installationState")]
    public V1alpha1CloudBuildConnectionStatusObservedStateInstallationState? InstallationState { get; set; }

    /// <summary>Output only. Set to true when the connection is being set up or updated in the background.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. Server assigned timestamp for when the connection was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CloudBuildConnectionStatus defines the config connector machine state of CloudBuildConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudBuildConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudBuildConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudBuildConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudBuildConnection is the Schema for the CloudBuildConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudBuildConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudBuildConnectionSpec>, IStatus<V1alpha1CloudBuildConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudBuildConnection";
    public const string KubeGroup = "cloudbuild.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbuildconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudBuildConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudBuildConnectionSpec defines the desired state of CloudBuildConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudBuildConnectionSpec Spec { get; set; }

    /// <summary>CloudBuildConnectionStatus defines the config connector machine state of CloudBuildConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudBuildConnectionStatus? Status { get; set; }
}