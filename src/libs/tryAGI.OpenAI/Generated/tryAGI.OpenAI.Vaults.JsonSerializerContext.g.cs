
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorBodyResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrderParam), TypeInfoPropertyName = "ListOrderParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultStatusParam), TypeInfoPropertyName = "VaultStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultStatusFilterParam), TypeInfoPropertyName = "VaultStatusFilterParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultResourceObject), TypeInfoPropertyName = "VaultResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultListResourceObject), TypeInfoPropertyName = "VaultListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVaultResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVaultResourceObject), TypeInfoPropertyName = "DeletedVaultResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType), TypeInfoPropertyName = "McpOauthTokenEndpointAuthResourceNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType), TypeInfoPropertyName = "McpOauthTokenEndpointAuthResourceClientSecretBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType), TypeInfoPropertyName = "McpOauthTokenEndpointAuthResourceClientSecretPostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource), TypeInfoPropertyName = "McpOauthTokenEndpointAuthResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType), TypeInfoPropertyName = "McpOauthTokenEndpointAuthResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthRefreshResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType), TypeInfoPropertyName = "VaultCredentialAuthResourceMcpOauthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType), TypeInfoPropertyName = "VaultCredentialAuthResourceStaticBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType), TypeInfoPropertyName = "VaultCredentialNetworkingResourceUnrestrictedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType), TypeInfoPropertyName = "VaultCredentialNetworkingResourceLimitedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResource), TypeInfoPropertyName = "VaultCredentialNetworkingResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType), TypeInfoPropertyName = "VaultCredentialNetworkingResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType), TypeInfoPropertyName = "VaultCredentialAuthResourceEnvironmentVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResource), TypeInfoPropertyName = "VaultCredentialAuthResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType), TypeInfoPropertyName = "VaultCredentialAuthResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject), TypeInfoPropertyName = "VaultCredentialResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject), TypeInfoPropertyName = "VaultCredentialListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType), TypeInfoPropertyName = "CreateMcpOauthTokenEndpointAuthParamNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType), TypeInfoPropertyName = "CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType), TypeInfoPropertyName = "CreateMcpOauthTokenEndpointAuthParamClientSecretPostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam), TypeInfoPropertyName = "CreateMcpOauthTokenEndpointAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType), TypeInfoPropertyName = "CreateMcpOauthTokenEndpointAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthRefreshParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType), TypeInfoPropertyName = "CreateVaultCredentialAuthParamMcpOauthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType), TypeInfoPropertyName = "CreateVaultCredentialAuthParamStaticBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType), TypeInfoPropertyName = "VaultCredentialNetworkingParamUnrestrictedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType), TypeInfoPropertyName = "VaultCredentialNetworkingParamLimitedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParam), TypeInfoPropertyName = "VaultCredentialNetworkingParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType), TypeInfoPropertyName = "VaultCredentialNetworkingParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType), TypeInfoPropertyName = "CreateVaultCredentialAuthParamEnvironmentVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParam), TypeInfoPropertyName = "CreateVaultCredentialAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType), TypeInfoPropertyName = "CreateVaultCredentialAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType), TypeInfoPropertyName = "RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType), TypeInfoPropertyName = "RotateMcpOauthTokenEndpointAuthParamClientSecretPostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam), TypeInfoPropertyName = "RotateMcpOauthTokenEndpointAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType), TypeInfoPropertyName = "RotateMcpOauthTokenEndpointAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthRefreshParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType), TypeInfoPropertyName = "RotateVaultCredentialAuthParamMcpOauthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType), TypeInfoPropertyName = "RotateVaultCredentialAuthParamStaticBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType), TypeInfoPropertyName = "RotateVaultCredentialAuthParamEnvironmentVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParam), TypeInfoPropertyName = "RotateVaultCredentialAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType), TypeInfoPropertyName = "RotateVaultCredentialAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject), TypeInfoPropertyName = "DeletedVaultCredentialResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrderParam?), TypeInfoPropertyName = "NullableListOrderParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultStatusParam?), TypeInfoPropertyName = "NullableVaultStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultStatusFilterParam?), TypeInfoPropertyName = "NullableVaultStatusFilterParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultResourceObject?), TypeInfoPropertyName = "NullableVaultResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultListResourceObject?), TypeInfoPropertyName = "NullableVaultListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVaultResourceObject?), TypeInfoPropertyName = "NullableDeletedVaultResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType?), TypeInfoPropertyName = "NullableMcpOauthTokenEndpointAuthResourceNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType?), TypeInfoPropertyName = "NullableMcpOauthTokenEndpointAuthResourceClientSecretBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType?), TypeInfoPropertyName = "NullableMcpOauthTokenEndpointAuthResourceClientSecretPostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource?), TypeInfoPropertyName = "NullableMcpOauthTokenEndpointAuthResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType?), TypeInfoPropertyName = "NullableMcpOauthTokenEndpointAuthResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType?), TypeInfoPropertyName = "NullableVaultCredentialAuthResourceMcpOauthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType?), TypeInfoPropertyName = "NullableVaultCredentialAuthResourceStaticBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingResourceUnrestrictedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingResourceLimitedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResource?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType?), TypeInfoPropertyName = "NullableVaultCredentialAuthResourceEnvironmentVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResource?), TypeInfoPropertyName = "NullableVaultCredentialAuthResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType?), TypeInfoPropertyName = "NullableVaultCredentialAuthResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject?), TypeInfoPropertyName = "NullableVaultCredentialResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject?), TypeInfoPropertyName = "NullableVaultCredentialListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType?), TypeInfoPropertyName = "NullableCreateMcpOauthTokenEndpointAuthParamNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType?), TypeInfoPropertyName = "NullableCreateMcpOauthTokenEndpointAuthParamClientSecretBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType?), TypeInfoPropertyName = "NullableCreateMcpOauthTokenEndpointAuthParamClientSecretPostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam?), TypeInfoPropertyName = "NullableCreateMcpOauthTokenEndpointAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType?), TypeInfoPropertyName = "NullableCreateMcpOauthTokenEndpointAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType?), TypeInfoPropertyName = "NullableCreateVaultCredentialAuthParamMcpOauthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType?), TypeInfoPropertyName = "NullableCreateVaultCredentialAuthParamStaticBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingParamUnrestrictedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingParamLimitedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParam?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType?), TypeInfoPropertyName = "NullableVaultCredentialNetworkingParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType?), TypeInfoPropertyName = "NullableCreateVaultCredentialAuthParamEnvironmentVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParam?), TypeInfoPropertyName = "NullableCreateVaultCredentialAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType?), TypeInfoPropertyName = "NullableCreateVaultCredentialAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType?), TypeInfoPropertyName = "NullableRotateMcpOauthTokenEndpointAuthParamClientSecretBasicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType?), TypeInfoPropertyName = "NullableRotateMcpOauthTokenEndpointAuthParamClientSecretPostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam?), TypeInfoPropertyName = "NullableRotateMcpOauthTokenEndpointAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType?), TypeInfoPropertyName = "NullableRotateMcpOauthTokenEndpointAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType?), TypeInfoPropertyName = "NullableRotateVaultCredentialAuthParamMcpOauthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType?), TypeInfoPropertyName = "NullableRotateVaultCredentialAuthParamStaticBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType?), TypeInfoPropertyName = "NullableRotateVaultCredentialAuthParamEnvironmentVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParam?), TypeInfoPropertyName = "NullableRotateVaultCredentialAuthParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType?), TypeInfoPropertyName = "NullableRotateVaultCredentialAuthParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject?), TypeInfoPropertyName = "NullableDeletedVaultCredentialResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultStatusParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultCredentialResource>))]
    internal sealed partial class VaultsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VaultsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VaultsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultStatusFilterParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrderParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrderParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedVaultResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedVaultResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretPostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretPostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceMcpOauthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceMcpOauthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceStaticBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceStaticBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceUnrestrictedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceUnrestrictedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceLimitedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceLimitedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceEnvironmentVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceEnvironmentVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretPostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretPostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamMcpOauthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamMcpOauthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamStaticBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamStaticBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamUnrestrictedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamUnrestrictedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamLimitedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamLimitedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamEnvironmentVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamEnvironmentVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretPostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretPostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamMcpOauthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamMcpOauthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamStaticBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamStaticBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamEnvironmentVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamEnvironmentVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedVaultCredentialResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVaultCredentialResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedVaultCredentialResourceObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VaultsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}