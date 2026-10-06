#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Choice values are typed: a string and a boolean with the same text are distinct.
    /// </summary>
    public readonly partial struct ChoiceValueResource : global::System.IEquatable<ChoiceValueResource>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChoiceValueResourceVariant1 { get; init; }
#else
        public string? ChoiceValueResourceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceValueResourceVariant1))]
#endif
        public bool IsChoiceValueResourceVariant1 => ChoiceValueResourceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoiceValueResourceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChoiceValueResourceVariant1;
            return IsChoiceValueResourceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickChoiceValueResourceVariant1() => ChoiceValueResourceVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChoiceValueResourceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? ChoiceValueResourceVariant2 { get; init; }
#else
        public bool? ChoiceValueResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceValueResourceVariant2))]
#endif
        public bool IsChoiceValueResourceVariant2 => ChoiceValueResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoiceValueResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = ChoiceValueResourceVariant2;
            return IsChoiceValueResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickChoiceValueResourceVariant2() => ChoiceValueResourceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChoiceValueResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChoiceValueResource(string value) => new ChoiceValueResource((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ChoiceValueResource @this) => @this.ChoiceValueResourceVariant1;

        /// <summary>
        ///
        /// </summary>
        public ChoiceValueResource(string? value)
        {
            ChoiceValueResourceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChoiceValueResource FromChoiceValueResourceVariant1(string? value) => new ChoiceValueResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChoiceValueResource(bool value) => new ChoiceValueResource((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(ChoiceValueResource @this) => @this.ChoiceValueResourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChoiceValueResource(bool? value)
        {
            ChoiceValueResourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChoiceValueResource FromChoiceValueResourceVariant2(bool? value) => new ChoiceValueResource(value);

        /// <summary>
        ///
        /// </summary>
        public ChoiceValueResource(
            string? choiceValueResourceVariant1,
            bool? choiceValueResourceVariant2
            )
        {
            ChoiceValueResourceVariant1 = choiceValueResourceVariant1;
            ChoiceValueResourceVariant2 = choiceValueResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChoiceValueResourceVariant2 as object ??
            ChoiceValueResourceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChoiceValueResourceVariant1?.ToString() ??
            ChoiceValueResourceVariant2?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChoiceValueResourceVariant1 && !IsChoiceValueResourceVariant2 || !IsChoiceValueResourceVariant1 && IsChoiceValueResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? choiceValueResourceVariant1 = null,
            global::System.Func<bool?, TResult>? choiceValueResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChoiceValueResourceVariant1 is { } __value0 && choiceValueResourceVariant1 != null)
            {
                return choiceValueResourceVariant1(__value0);
            }
            else if (ChoiceValueResourceVariant2 is { } __value1 && choiceValueResourceVariant2 != null)
            {
                return choiceValueResourceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? choiceValueResourceVariant1 = null,

            global::System.Action<bool?>? choiceValueResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChoiceValueResourceVariant1 is { } __value0)
            {
                choiceValueResourceVariant1?.Invoke(__value0);
            }
            else if (ChoiceValueResourceVariant2 is { } __value1)
            {
                choiceValueResourceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? choiceValueResourceVariant1 = null,
            global::System.Action<bool?>? choiceValueResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChoiceValueResourceVariant1 is { } __value0)
            {
                choiceValueResourceVariant1?.Invoke(__value0);
            }
            else if (ChoiceValueResourceVariant2 is { } __value1)
            {
                choiceValueResourceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChoiceValueResourceVariant1,
                typeof(string),
                ChoiceValueResourceVariant2,
                typeof(bool),
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
        public bool Equals(ChoiceValueResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChoiceValueResourceVariant1, other.ChoiceValueResourceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(ChoiceValueResourceVariant2, other.ChoiceValueResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChoiceValueResource obj1, ChoiceValueResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChoiceValueResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChoiceValueResource obj1, ChoiceValueResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChoiceValueResource o && Equals(o);
        }
    }
}
