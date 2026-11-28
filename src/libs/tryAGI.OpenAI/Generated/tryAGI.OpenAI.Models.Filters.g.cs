#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Filters : global::System.IEquatable<Filters>
    {
        /// <summary>
        /// A filter used to compare a specified attribute key to a given value using a defined comparison operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComparisonFilter? ComparisonFilter { get; init; }
#else
        public global::tryAGI.OpenAI.ComparisonFilter? ComparisonFilter { get; }
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
            out global::tryAGI.OpenAI.ComparisonFilter? value)
        {
            value = ComparisonFilter;
            return IsComparisonFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ComparisonFilter PickComparisonFilter() => ComparisonFilter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComparisonFilter' but the value was {ToString()}.");

        /// <summary>
        /// Combine multiple filters using `and` or `or`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CompoundFilter? CompoundFilter { get; init; }
#else
        public global::tryAGI.OpenAI.CompoundFilter? CompoundFilter { get; }
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
            out global::tryAGI.OpenAI.CompoundFilter? value)
        {
            value = CompoundFilter;
            return IsCompoundFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CompoundFilter PickCompoundFilter() => CompoundFilter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompoundFilter' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filters(global::tryAGI.OpenAI.ComparisonFilter value) => new Filters((global::tryAGI.OpenAI.ComparisonFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComparisonFilter?(Filters @this) => @this.ComparisonFilter;

        /// <summary>
        ///
        /// </summary>
        public Filters(global::tryAGI.OpenAI.ComparisonFilter? value)
        {
            ComparisonFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filters FromComparisonFilter(global::tryAGI.OpenAI.ComparisonFilter? value) => new Filters(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filters(global::tryAGI.OpenAI.CompoundFilter value) => new Filters((global::tryAGI.OpenAI.CompoundFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CompoundFilter?(Filters @this) => @this.CompoundFilter;

        /// <summary>
        ///
        /// </summary>
        public Filters(global::tryAGI.OpenAI.CompoundFilter? value)
        {
            CompoundFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filters FromCompoundFilter(global::tryAGI.OpenAI.CompoundFilter? value) => new Filters(value);

        /// <summary>
        ///
        /// </summary>
        public Filters(
            global::tryAGI.OpenAI.ComparisonFilter? comparisonFilter,
            global::tryAGI.OpenAI.CompoundFilter? compoundFilter
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
            return IsComparisonFilter || IsCompoundFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ComparisonFilter, TResult>? comparisonFilter = null,
            global::System.Func<global::tryAGI.OpenAI.CompoundFilter, TResult>? compoundFilter = null,
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
            global::System.Action<global::tryAGI.OpenAI.ComparisonFilter>? comparisonFilter = null,

            global::System.Action<global::tryAGI.OpenAI.CompoundFilter>? compoundFilter = null,
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
            global::System.Action<global::tryAGI.OpenAI.ComparisonFilter>? comparisonFilter = null,
            global::System.Action<global::tryAGI.OpenAI.CompoundFilter>? compoundFilter = null,
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
                typeof(global::tryAGI.OpenAI.ComparisonFilter),
                CompoundFilter,
                typeof(global::tryAGI.OpenAI.CompoundFilter),
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
        public bool Equals(Filters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComparisonFilter?>.Default.Equals(ComparisonFilter, other.ComparisonFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CompoundFilter?>.Default.Equals(CompoundFilter, other.CompoundFilter)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Filters obj1, Filters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Filters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Filters obj1, Filters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Filters o && Equals(o);
        }
    }
}
