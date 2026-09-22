#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The client authentication method used for OAuth token refresh.
    /// </summary>
    public readonly partial struct McpOauthTokenEndpointAuthResource : global::System.IEquatable<McpOauthTokenEndpointAuthResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Sends the client ID without a client secret.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? None { get; init; }
#else
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? None { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// Sends the client ID and secret using HTTP Basic authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? ClientSecretBasic { get; init; }
#else
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? ClientSecretBasic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientSecretBasic))]
#endif
        public bool IsClientSecretBasic => ClientSecretBasic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientSecretBasic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? value)
        {
            value = ClientSecretBasic;
            return IsClientSecretBasic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic PickClientSecretBasic() => IsClientSecretBasic
            ? ClientSecretBasic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientSecretBasic' but the value was {ToString()}.");

        /// <summary>
        /// Sends the client ID and secret in the token request body.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? ClientSecretPost { get; init; }
#else
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? ClientSecretPost { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientSecretPost))]
#endif
        public bool IsClientSecretPost => ClientSecretPost != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientSecretPost(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? value)
        {
            value = ClientSecretPost;
            return IsClientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost PickClientSecretPost() => IsClientSecretPost
            ? ClientSecretPost!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientSecretPost' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpOauthTokenEndpointAuthResource(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone value) => new McpOauthTokenEndpointAuthResource((global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone?(McpOauthTokenEndpointAuthResource @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public McpOauthTokenEndpointAuthResource(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpOauthTokenEndpointAuthResource FromNone(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? value) => new McpOauthTokenEndpointAuthResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpOauthTokenEndpointAuthResource(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic value) => new McpOauthTokenEndpointAuthResource((global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic?(McpOauthTokenEndpointAuthResource @this) => @this.ClientSecretBasic;

        /// <summary>
        ///
        /// </summary>
        public McpOauthTokenEndpointAuthResource(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? value)
        {
            ClientSecretBasic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpOauthTokenEndpointAuthResource FromClientSecretBasic(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? value) => new McpOauthTokenEndpointAuthResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpOauthTokenEndpointAuthResource(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost value) => new McpOauthTokenEndpointAuthResource((global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost?(McpOauthTokenEndpointAuthResource @this) => @this.ClientSecretPost;

        /// <summary>
        ///
        /// </summary>
        public McpOauthTokenEndpointAuthResource(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? value)
        {
            ClientSecretPost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpOauthTokenEndpointAuthResource FromClientSecretPost(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? value) => new McpOauthTokenEndpointAuthResource(value);

        /// <summary>
        ///
        /// </summary>
        public McpOauthTokenEndpointAuthResource(
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? none,
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? clientSecretBasic,
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? clientSecretPost
            )
        {
            Type = type;

            None = none;
            ClientSecretBasic = clientSecretBasic;
            ClientSecretPost = clientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ClientSecretPost as object ??
            ClientSecretBasic as object ??
            None as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            None?.ToString() ??
            ClientSecretBasic?.ToString() ??
            ClientSecretPost?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsClientSecretBasic && !IsClientSecretPost || !IsNone && IsClientSecretBasic && !IsClientSecretPost || !IsNone && !IsClientSecretBasic && IsClientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone, TResult>? none = null,
            global::System.Func<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic, TResult>? clientSecretBasic = null,
            global::System.Func<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost, TResult>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsClientSecretBasic && clientSecretBasic != null)
            {
                return clientSecretBasic(ClientSecretBasic!);
            }
            else if (IsClientSecretPost && clientSecretPost != null)
            {
                return clientSecretPost(ClientSecretPost!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone>? none = null,

            global::System.Action<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic>? clientSecretBasic = null,

            global::System.Action<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsClientSecretBasic)
            {
                clientSecretBasic?.Invoke(ClientSecretBasic!);
            }
            else if (IsClientSecretPost)
            {
                clientSecretPost?.Invoke(ClientSecretPost!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone>? none = null,
            global::System.Action<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic>? clientSecretBasic = null,
            global::System.Action<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsClientSecretBasic)
            {
                clientSecretBasic?.Invoke(ClientSecretBasic!);
            }
            else if (IsClientSecretPost)
            {
                clientSecretPost?.Invoke(ClientSecretPost!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                None,
                typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone),
                ClientSecretBasic,
                typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic),
                ClientSecretPost,
                typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(McpOauthTokenEndpointAuthResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic?>.Default.Equals(ClientSecretBasic, other.ClientSecretBasic) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost?>.Default.Equals(ClientSecretPost, other.ClientSecretPost)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(McpOauthTokenEndpointAuthResource obj1, McpOauthTokenEndpointAuthResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpOauthTokenEndpointAuthResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpOauthTokenEndpointAuthResource obj1, McpOauthTokenEndpointAuthResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpOauthTokenEndpointAuthResource o && Equals(o);
        }
    }
}
