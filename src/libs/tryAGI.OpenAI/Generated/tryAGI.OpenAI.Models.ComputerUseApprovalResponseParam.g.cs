#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ComputerUseApprovalResponseParam : global::System.IEquatable<ComputerUseApprovalResponseParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? BrowserAuthentication { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? BrowserAuthentication { get; }
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
            out global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? value)
        {
            value = BrowserAuthentication;
            return IsBrowserAuthentication;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication PickBrowserAuthentication() => BrowserAuthentication is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserAuthentication' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? BrowserOriginAccess { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? BrowserOriginAccess { get; }
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
            out global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? value)
        {
            value = BrowserOriginAccess;
            return IsBrowserOriginAccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam PickBrowserOriginAccess() => BrowserOriginAccess is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserOriginAccess' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerUseApprovalResponseParam(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication value) => new ComputerUseApprovalResponseParam((global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication?(ComputerUseApprovalResponseParam @this) => @this.BrowserAuthentication;

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalResponseParam(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? value)
        {
            BrowserAuthentication = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseApprovalResponseParam FromBrowserAuthentication(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? value) => new ComputerUseApprovalResponseParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerUseApprovalResponseParam(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam value) => new ComputerUseApprovalResponseParam((global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam?(ComputerUseApprovalResponseParam @this) => @this.BrowserOriginAccess;

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalResponseParam(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? value)
        {
            BrowserOriginAccess = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseApprovalResponseParam FromBrowserOriginAccess(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? value) => new ComputerUseApprovalResponseParam(value);

        /// <summary>
        ///
        /// </summary>
        public ComputerUseApprovalResponseParam(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType? type,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? browserAuthentication,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? browserOriginAccess
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
            global::System.Func<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication, TResult>? browserAuthentication = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam, TResult>? browserOriginAccess = null,
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
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication>? browserAuthentication = null,

            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam>? browserOriginAccess = null,
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
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication>? browserAuthentication = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam>? browserOriginAccess = null,
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
                typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication),
                BrowserOriginAccess,
                typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam),
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
        public bool Equals(ComputerUseApprovalResponseParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication?>.Default.Equals(BrowserAuthentication, other.BrowserAuthentication) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam?>.Default.Equals(BrowserOriginAccess, other.BrowserOriginAccess)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ComputerUseApprovalResponseParam obj1, ComputerUseApprovalResponseParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerUseApprovalResponseParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComputerUseApprovalResponseParam obj1, ComputerUseApprovalResponseParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerUseApprovalResponseParam o && Equals(o);
        }
    }
}
