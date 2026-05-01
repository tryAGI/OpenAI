#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AdminApiKeyCreateResponse : global::System.IEquatable<AdminApiKeyCreateResponse>
    {
        /// <summary>
        /// Represents an individual Admin API key in an org.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AdminApiKey? AdminApiKey { get; init; }
#else
        public global::tryAGI.OpenAI.AdminApiKey? AdminApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdminApiKey))]
#endif
        public bool IsAdminApiKey => AdminApiKey != null;

        /// <summary>
        /// The newly created admin API key. The `value` field is only returned once, when the key is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2? AdminApiKeyCreateResponseVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2? AdminApiKeyCreateResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdminApiKeyCreateResponseVariant2))]
#endif
        public bool IsAdminApiKeyCreateResponseVariant2 => AdminApiKeyCreateResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdminApiKeyCreateResponse(global::tryAGI.OpenAI.AdminApiKey value) => new AdminApiKeyCreateResponse((global::tryAGI.OpenAI.AdminApiKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AdminApiKey?(AdminApiKeyCreateResponse @this) => @this.AdminApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AdminApiKeyCreateResponse(global::tryAGI.OpenAI.AdminApiKey? value)
        {
            AdminApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdminApiKeyCreateResponse(global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2 value) => new AdminApiKeyCreateResponse((global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2?(AdminApiKeyCreateResponse @this) => @this.AdminApiKeyCreateResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AdminApiKeyCreateResponse(global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2? value)
        {
            AdminApiKeyCreateResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AdminApiKeyCreateResponse(
            global::tryAGI.OpenAI.AdminApiKey? adminApiKey,
            global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2? adminApiKeyCreateResponseVariant2
            )
        {
            AdminApiKey = adminApiKey;
            AdminApiKeyCreateResponseVariant2 = adminApiKeyCreateResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AdminApiKeyCreateResponseVariant2 as object ??
            AdminApiKey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AdminApiKey?.ToString() ??
            AdminApiKeyCreateResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAdminApiKey && IsAdminApiKeyCreateResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AdminApiKey?, TResult>? adminApiKey = null,
            global::System.Func<global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2?, TResult>? adminApiKeyCreateResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdminApiKey && adminApiKey != null)
            {
                return adminApiKey(AdminApiKey!);
            }
            else if (IsAdminApiKeyCreateResponseVariant2 && adminApiKeyCreateResponseVariant2 != null)
            {
                return adminApiKeyCreateResponseVariant2(AdminApiKeyCreateResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AdminApiKey?>? adminApiKey = null,
            global::System.Action<global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2?>? adminApiKeyCreateResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdminApiKey)
            {
                adminApiKey?.Invoke(AdminApiKey!);
            }
            else if (IsAdminApiKeyCreateResponseVariant2)
            {
                adminApiKeyCreateResponseVariant2?.Invoke(AdminApiKeyCreateResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AdminApiKey,
                typeof(global::tryAGI.OpenAI.AdminApiKey),
                AdminApiKeyCreateResponseVariant2,
                typeof(global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2),
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
        public bool Equals(AdminApiKeyCreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AdminApiKey?>.Default.Equals(AdminApiKey, other.AdminApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AdminApiKeyCreateResponseVariant2?>.Default.Equals(AdminApiKeyCreateResponseVariant2, other.AdminApiKeyCreateResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AdminApiKeyCreateResponse obj1, AdminApiKeyCreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AdminApiKeyCreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AdminApiKeyCreateResponse obj1, AdminApiKeyCreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AdminApiKeyCreateResponse o && Equals(o);
        }
    }
}
