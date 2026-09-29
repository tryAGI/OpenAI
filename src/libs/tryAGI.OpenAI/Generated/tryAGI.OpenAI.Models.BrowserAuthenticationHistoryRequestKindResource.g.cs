#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BrowserAuthenticationHistoryRequestKindResource : global::System.IEquatable<BrowserAuthenticationHistoryRequestKindResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A registered form awaiting the application's response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? BrowserAuthentication { get; init; }
#else
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? BrowserAuthentication { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserAuthentication))]
#endif
        public bool IsBrowserAuthentication => BrowserAuthentication != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserAuthentication(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? value)
        {
            value = BrowserAuthentication;
            return IsBrowserAuthentication;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication PickBrowserAuthentication() => BrowserAuthentication is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserAuthentication' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserAuthenticationHistoryRequestKindResource(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication value) => new BrowserAuthenticationHistoryRequestKindResource((global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication?(BrowserAuthenticationHistoryRequestKindResource @this) => @this.BrowserAuthentication;

        /// <summary>
        ///
        /// </summary>
        public BrowserAuthenticationHistoryRequestKindResource(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? value)
        {
            BrowserAuthentication = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserAuthenticationHistoryRequestKindResource FromBrowserAuthentication(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? value) => new BrowserAuthenticationHistoryRequestKindResource(value);

        /// <summary>
        ///
        /// </summary>
        public BrowserAuthenticationHistoryRequestKindResource(
            global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication? browserAuthentication
            )
        {
            Type = type;

            BrowserAuthentication = browserAuthentication;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BrowserAuthentication as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BrowserAuthentication?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBrowserAuthentication;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication, TResult>? browserAuthentication = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserAuthentication is { } __value0 && browserAuthentication != null)
            {
                return browserAuthentication(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication>? browserAuthentication = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserAuthentication is { } __value0)
            {
                browserAuthentication?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication>? browserAuthentication = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserAuthentication is { } __value0)
            {
                browserAuthentication?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BrowserAuthentication,
                typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication),
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
        public bool Equals(BrowserAuthenticationHistoryRequestKindResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication?>.Default.Equals(BrowserAuthentication, other.BrowserAuthentication)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BrowserAuthenticationHistoryRequestKindResource obj1, BrowserAuthenticationHistoryRequestKindResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowserAuthenticationHistoryRequestKindResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BrowserAuthenticationHistoryRequestKindResource obj1, BrowserAuthenticationHistoryRequestKindResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowserAuthenticationHistoryRequestKindResource o && Equals(o);
        }
    }
}
