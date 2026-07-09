#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FiltersItem2 : global::System.IEquatable<FiltersItem2>
    {
        /// <summary>
        /// A filter used to compare a specified attribute key to a given value using a defined comparison operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComparisonFilter? ComparisonFilter { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComparisonFilter? ComparisonFilter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComparisonFilter))]
#endif
        public bool IsComparisonFilter => ComparisonFilter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComparisonFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComparisonFilter? value)
        {
            value = ComparisonFilter;
            return IsComparisonFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaComparisonFilter PickComparisonFilter() => IsComparisonFilter
            ? ComparisonFilter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComparisonFilter' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? BetaCompoundFilterVariant2 { get; init; }
#else
        public object? BetaCompoundFilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaCompoundFilterVariant2))]
#endif
        public bool IsBetaCompoundFilterVariant2 => BetaCompoundFilterVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaCompoundFilterVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = BetaCompoundFilterVariant2;
            return IsBetaCompoundFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickBetaCompoundFilterVariant2() => IsBetaCompoundFilterVariant2
            ? BetaCompoundFilterVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaCompoundFilterVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FiltersItem2(global::tryAGI.OpenAI.BetaComparisonFilter value) => new FiltersItem2((global::tryAGI.OpenAI.BetaComparisonFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComparisonFilter?(FiltersItem2 @this) => @this.ComparisonFilter;

        /// <summary>
        /// 
        /// </summary>
        public FiltersItem2(global::tryAGI.OpenAI.BetaComparisonFilter? value)
        {
            ComparisonFilter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FiltersItem2 FromComparisonFilter(global::tryAGI.OpenAI.BetaComparisonFilter? value) => new FiltersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public FiltersItem2(
            global::tryAGI.OpenAI.BetaComparisonFilter? comparisonFilter,
            object? betaCompoundFilterVariant2
            )
        {
            ComparisonFilter = comparisonFilter;
            BetaCompoundFilterVariant2 = betaCompoundFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaCompoundFilterVariant2 as object ??
            ComparisonFilter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComparisonFilter?.ToString() ??
            BetaCompoundFilterVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComparisonFilter && !IsBetaCompoundFilterVariant2 || !IsComparisonFilter && IsBetaCompoundFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaComparisonFilter, TResult>? comparisonFilter = null,
            global::System.Func<object, TResult>? betaCompoundFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter && comparisonFilter != null)
            {
                return comparisonFilter(ComparisonFilter!);
            }
            else if (IsBetaCompoundFilterVariant2 && betaCompoundFilterVariant2 != null)
            {
                return betaCompoundFilterVariant2(BetaCompoundFilterVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaComparisonFilter>? comparisonFilter = null,

            global::System.Action<object>? betaCompoundFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter)
            {
                comparisonFilter?.Invoke(ComparisonFilter!);
            }
            else if (IsBetaCompoundFilterVariant2)
            {
                betaCompoundFilterVariant2?.Invoke(BetaCompoundFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaComparisonFilter>? comparisonFilter = null,
            global::System.Action<object>? betaCompoundFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter)
            {
                comparisonFilter?.Invoke(ComparisonFilter!);
            }
            else if (IsBetaCompoundFilterVariant2)
            {
                betaCompoundFilterVariant2?.Invoke(BetaCompoundFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComparisonFilter,
                typeof(global::tryAGI.OpenAI.BetaComparisonFilter),
                BetaCompoundFilterVariant2,
                typeof(object),
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
        public bool Equals(FiltersItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComparisonFilter?>.Default.Equals(ComparisonFilter, other.ComparisonFilter) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(BetaCompoundFilterVariant2, other.BetaCompoundFilterVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FiltersItem2 obj1, FiltersItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FiltersItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FiltersItem2 obj1, FiltersItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FiltersItem2 o && Equals(o);
        }
    }
}
