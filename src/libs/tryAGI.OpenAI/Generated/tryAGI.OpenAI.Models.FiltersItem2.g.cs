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
        public global::tryAGI.OpenAI.BetaComparisonFilter PickComparisonFilter() => ComparisonFilter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComparisonFilter' but the value was {ToString()}.");

        /// <summary>
        /// Combine multiple filters using `and` or `or`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCompoundFilter? CompoundFilter { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCompoundFilter? CompoundFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompoundFilter))]
#endif
        public bool IsCompoundFilter => CompoundFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompoundFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCompoundFilter? value)
        {
            value = CompoundFilter;
            return IsCompoundFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompoundFilter PickCompoundFilter() => CompoundFilter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompoundFilter' but the value was {ToString()}.");
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
        public static implicit operator FiltersItem2(global::tryAGI.OpenAI.BetaCompoundFilter value) => new FiltersItem2((global::tryAGI.OpenAI.BetaCompoundFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCompoundFilter?(FiltersItem2 @this) => @this.CompoundFilter;

        /// <summary>
        ///
        /// </summary>
        public FiltersItem2(global::tryAGI.OpenAI.BetaCompoundFilter? value)
        {
            CompoundFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FiltersItem2 FromCompoundFilter(global::tryAGI.OpenAI.BetaCompoundFilter? value) => new FiltersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public FiltersItem2(
            global::tryAGI.OpenAI.BetaComparisonFilter? comparisonFilter,
            global::tryAGI.OpenAI.BetaCompoundFilter? compoundFilter
            )
        {
            ComparisonFilter = comparisonFilter;
            CompoundFilter = compoundFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CompoundFilter as object ??
            ComparisonFilter as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ComparisonFilter?.ToString() ??
            CompoundFilter?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsComparisonFilter && !IsCompoundFilter || !IsComparisonFilter && IsCompoundFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaComparisonFilter, TResult>? comparisonFilter = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCompoundFilter, TResult>? compoundFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ComparisonFilter is { } __value0 && comparisonFilter != null)
            {
                return comparisonFilter(__value0);
            }
            else if (CompoundFilter is { } __value1 && compoundFilter != null)
            {
                return compoundFilter(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaComparisonFilter>? comparisonFilter = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCompoundFilter>? compoundFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ComparisonFilter is { } __value0)
            {
                comparisonFilter?.Invoke(__value0);
            }
            else if (CompoundFilter is { } __value1)
            {
                compoundFilter?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaComparisonFilter>? comparisonFilter = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCompoundFilter>? compoundFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ComparisonFilter is { } __value0)
            {
                comparisonFilter?.Invoke(__value0);
            }
            else if (CompoundFilter is { } __value1)
            {
                compoundFilter?.Invoke(__value1);
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
                CompoundFilter,
                typeof(global::tryAGI.OpenAI.BetaCompoundFilter),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCompoundFilter?>.Default.Equals(CompoundFilter, other.CompoundFilter)
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
