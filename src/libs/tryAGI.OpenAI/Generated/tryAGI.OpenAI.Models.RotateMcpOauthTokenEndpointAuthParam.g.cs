#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client-secret updates that preserve the credential's OAuth authentication method.
    /// </summary>
    public readonly partial struct RotateMcpOauthTokenEndpointAuthParam : global::System.IEquatable<RotateMcpOauthTokenEndpointAuthParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Updates credentials sent using HTTP Basic authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? ClientSecretBasic { get; init; }
#else
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? ClientSecretBasic { get; }
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
            out global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? value)
        {
            value = ClientSecretBasic;
            return IsClientSecretBasic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic PickClientSecretBasic() => IsClientSecretBasic
            ? ClientSecretBasic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientSecretBasic' but the value was {ToString()}.");

        /// <summary>
        /// Updates credentials sent in the token request body.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? ClientSecretPost { get; init; }
#else
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? ClientSecretPost { get; }
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
            out global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? value)
        {
            value = ClientSecretPost;
            return IsClientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost PickClientSecretPost() => IsClientSecretPost
            ? ClientSecretPost!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientSecretPost' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RotateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic value) => new RotateMcpOauthTokenEndpointAuthParam((global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic?(RotateMcpOauthTokenEndpointAuthParam @this) => @this.ClientSecretBasic;

        /// <summary>
        ///
        /// </summary>
        public RotateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? value)
        {
            ClientSecretBasic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RotateMcpOauthTokenEndpointAuthParam FromClientSecretBasic(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? value) => new RotateMcpOauthTokenEndpointAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RotateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost value) => new RotateMcpOauthTokenEndpointAuthParam((global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost?(RotateMcpOauthTokenEndpointAuthParam @this) => @this.ClientSecretPost;

        /// <summary>
        ///
        /// </summary>
        public RotateMcpOauthTokenEndpointAuthParam(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? value)
        {
            ClientSecretPost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RotateMcpOauthTokenEndpointAuthParam FromClientSecretPost(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? value) => new RotateMcpOauthTokenEndpointAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public RotateMcpOauthTokenEndpointAuthParam(
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType? type,
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? clientSecretBasic,
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? clientSecretPost
            )
        {
            Type = type;

            ClientSecretBasic = clientSecretBasic;
            ClientSecretPost = clientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ClientSecretPost as object ??
            ClientSecretBasic as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ClientSecretBasic?.ToString() ??
            ClientSecretPost?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsClientSecretBasic && !IsClientSecretPost || !IsClientSecretBasic && IsClientSecretPost;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic, TResult>? clientSecretBasic = null,
            global::System.Func<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost, TResult>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientSecretBasic && clientSecretBasic != null)
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
            global::System.Action<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic>? clientSecretBasic = null,

            global::System.Action<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientSecretBasic)
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
            global::System.Action<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic>? clientSecretBasic = null,
            global::System.Action<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientSecretBasic)
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
                ClientSecretBasic,
                typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic),
                ClientSecretPost,
                typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost),
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
        public bool Equals(RotateMcpOauthTokenEndpointAuthParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic?>.Default.Equals(ClientSecretBasic, other.ClientSecretBasic) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost?>.Default.Equals(ClientSecretPost, other.ClientSecretPost)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RotateMcpOauthTokenEndpointAuthParam obj1, RotateMcpOauthTokenEndpointAuthParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RotateMcpOauthTokenEndpointAuthParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RotateMcpOauthTokenEndpointAuthParam obj1, RotateMcpOauthTokenEndpointAuthParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RotateMcpOauthTokenEndpointAuthParam o && Equals(o);
        }
    }
}
