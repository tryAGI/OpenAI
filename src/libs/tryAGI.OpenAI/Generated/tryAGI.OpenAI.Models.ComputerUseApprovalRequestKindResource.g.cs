#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ComputerUseApprovalRequestKindResource : global::System.IEquatable<ComputerUseApprovalRequestKindResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A registered form awaiting the application's response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? BrowserAuthentication { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? BrowserAuthentication { get; }
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
            out global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? value)
        {
            value = BrowserAuthentication;
            return IsBrowserAuthentication;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication PickBrowserAuthentication() => BrowserAuthentication is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserAuthentication' but the value was {ToString()}.");

        /// <summary>
        /// A browser origin awaiting the application's approval decision.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? BrowserOriginAccess { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? BrowserOriginAccess { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserOriginAccess))]
#endif
        public bool IsBrowserOriginAccess => BrowserOriginAccess != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserOriginAccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? value)
        {
            value = BrowserOriginAccess;
            return IsBrowserOriginAccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess PickBrowserOriginAccess() => BrowserOriginAccess is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserOriginAccess' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerUseApprovalRequestKindResource(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication value) => new ComputerUseApprovalRequestKindResource((global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication?(ComputerUseApprovalRequestKindResource @this) => @this.BrowserAuthentication;

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalRequestKindResource(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? value)
        {
            BrowserAuthentication = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseApprovalRequestKindResource FromBrowserAuthentication(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? value) => new ComputerUseApprovalRequestKindResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerUseApprovalRequestKindResource(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess value) => new ComputerUseApprovalRequestKindResource((global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess?(ComputerUseApprovalRequestKindResource @this) => @this.BrowserOriginAccess;

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalRequestKindResource(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? value)
        {
            BrowserOriginAccess = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseApprovalRequestKindResource FromBrowserOriginAccess(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? value) => new ComputerUseApprovalRequestKindResource(value);

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalRequestKindResource(
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? browserAuthentication,
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? browserOriginAccess
            )
        {
            Type = type;

            BrowserAuthentication = browserAuthentication;
            BrowserOriginAccess = browserOriginAccess;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BrowserOriginAccess as object ??
            BrowserAuthentication as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BrowserAuthentication?.ToString() ??
            BrowserOriginAccess?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBrowserAuthentication && !IsBrowserOriginAccess || !IsBrowserAuthentication && IsBrowserOriginAccess;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication, TResult>? browserAuthentication = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess, TResult>? browserOriginAccess = null,
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
            else if (BrowserOriginAccess is { } __value1 && browserOriginAccess != null)
            {
                return browserOriginAccess(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication>? browserAuthentication = null,

            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess>? browserOriginAccess = null,
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
            else if (BrowserOriginAccess is { } __value1)
            {
                browserOriginAccess?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication>? browserAuthentication = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess>? browserOriginAccess = null,
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
            else if (BrowserOriginAccess is { } __value1)
            {
                browserOriginAccess?.Invoke(__value1);
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
                typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication),
                BrowserOriginAccess,
                typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess),
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
        public bool Equals(ComputerUseApprovalRequestKindResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication?>.Default.Equals(BrowserAuthentication, other.BrowserAuthentication) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess?>.Default.Equals(BrowserOriginAccess, other.BrowserOriginAccess)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ComputerUseApprovalRequestKindResource obj1, ComputerUseApprovalRequestKindResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerUseApprovalRequestKindResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComputerUseApprovalRequestKindResource obj1, ComputerUseApprovalRequestKindResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerUseApprovalRequestKindResource o && Equals(o);
        }
    }
}
