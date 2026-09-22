#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client authentication credentials for OAuth token refresh.
    /// </summary>
    public readonly partial struct CreateMcpOauthTokenEndpointAuthParam : global::System.IEquatable<CreateMcpOauthTokenEndpointAuthParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Sends the client ID without a client secret.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? None { get; init; }
#else
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? None { get; }
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
            out global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// Sends the client ID and secret using HTTP Basic authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? ClientSecretBasic { get; init; }
#else
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? ClientSecretBasic { get; }
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
            out global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? value)
        {
            value = ClientSecretBasic;
            return IsClientSecretBasic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic PickClientSecretBasic() => IsClientSecretBasic
            ? ClientSecretBasic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientSecretBasic' but the value was {ToString()}.");

        /// <summary>
        /// Sends the client ID and secret in the token request body.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? ClientSecretPost { get; init; }
#else
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? ClientSecretPost { get; }
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
            out global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? value)
        {
            value = ClientSecretPost;
            return IsClientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost PickClientSecretPost() => IsClientSecretPost
            ? ClientSecretPost!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientSecretPost' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone value) => new CreateMcpOauthTokenEndpointAuthParam((global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone?(CreateMcpOauthTokenEndpointAuthParam @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParam FromNone(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? value) => new CreateMcpOauthTokenEndpointAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic value) => new CreateMcpOauthTokenEndpointAuthParam((global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic?(CreateMcpOauthTokenEndpointAuthParam @this) => @this.ClientSecretBasic;

        /// <summary>
        ///
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? value)
        {
            ClientSecretBasic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParam FromClientSecretBasic(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? value) => new CreateMcpOauthTokenEndpointAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost value) => new CreateMcpOauthTokenEndpointAuthParam((global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost?(CreateMcpOauthTokenEndpointAuthParam @this) => @this.ClientSecretPost;

        /// <summary>
        ///
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? value)
        {
            ClientSecretPost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateMcpOauthTokenEndpointAuthParam FromClientSecretPost(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? value) => new CreateMcpOauthTokenEndpointAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParam(
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType? type,
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? none,
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? clientSecretBasic,
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? clientSecretPost
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
            global::System.Func<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone, TResult>? none = null,
            global::System.Func<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic, TResult>? clientSecretBasic = null,
            global::System.Func<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost, TResult>? clientSecretPost = null,
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
            global::System.Action<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone>? none = null,

            global::System.Action<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic>? clientSecretBasic = null,

            global::System.Action<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost>? clientSecretPost = null,
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
            global::System.Action<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone>? none = null,
            global::System.Action<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic>? clientSecretBasic = null,
            global::System.Action<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost>? clientSecretPost = null,
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
                typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone),
                ClientSecretBasic,
                typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic),
                ClientSecretPost,
                typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost),
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
        public bool Equals(CreateMcpOauthTokenEndpointAuthParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic?>.Default.Equals(ClientSecretBasic, other.ClientSecretBasic) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost?>.Default.Equals(ClientSecretPost, other.ClientSecretPost)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateMcpOauthTokenEndpointAuthParam obj1, CreateMcpOauthTokenEndpointAuthParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateMcpOauthTokenEndpointAuthParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateMcpOauthTokenEndpointAuthParam obj1, CreateMcpOauthTokenEndpointAuthParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateMcpOauthTokenEndpointAuthParam o && Equals(o);
        }
    }
}
