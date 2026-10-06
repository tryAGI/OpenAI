#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Choice values are typed: a string and a boolean with the same text are distinct.
    /// </summary>
    public readonly partial struct ChoiceValueParam : global::System.IEquatable<ChoiceValueParam>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChoiceValueParamVariant1 { get; init; }
#else
        public string? ChoiceValueParamVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceValueParamVariant1))]
#endif
        public bool IsChoiceValueParamVariant1 => ChoiceValueParamVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoiceValueParamVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChoiceValueParamVariant1;
            return IsChoiceValueParamVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickChoiceValueParamVariant1() => ChoiceValueParamVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChoiceValueParamVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? ChoiceValueParamVariant2 { get; init; }
#else
        public bool? ChoiceValueParamVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceValueParamVariant2))]
#endif
        public bool IsChoiceValueParamVariant2 => ChoiceValueParamVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoiceValueParamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = ChoiceValueParamVariant2;
            return IsChoiceValueParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickChoiceValueParamVariant2() => ChoiceValueParamVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChoiceValueParamVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChoiceValueParam(string value) => new ChoiceValueParam((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ChoiceValueParam @this) => @this.ChoiceValueParamVariant1;

        /// <summary>
        ///
        /// </summary>
        public ChoiceValueParam(string? value)
        {
            ChoiceValueParamVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChoiceValueParam FromChoiceValueParamVariant1(string? value) => new ChoiceValueParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChoiceValueParam(bool value) => new ChoiceValueParam((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(ChoiceValueParam @this) => @this.ChoiceValueParamVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChoiceValueParam(bool? value)
        {
            ChoiceValueParamVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChoiceValueParam FromChoiceValueParamVariant2(bool? value) => new ChoiceValueParam(value);

        /// <summary>
        ///
        /// </summary>
        public ChoiceValueParam(
            string? choiceValueParamVariant1,
            bool? choiceValueParamVariant2
            )
        {
            ChoiceValueParamVariant1 = choiceValueParamVariant1;
            ChoiceValueParamVariant2 = choiceValueParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChoiceValueParamVariant2 as object ??
            ChoiceValueParamVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChoiceValueParamVariant1?.ToString() ??
            ChoiceValueParamVariant2?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChoiceValueParamVariant1 && !IsChoiceValueParamVariant2 || !IsChoiceValueParamVariant1 && IsChoiceValueParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? choiceValueParamVariant1 = null,
            global::System.Func<bool?, TResult>? choiceValueParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChoiceValueParamVariant1 is { } __value0 && choiceValueParamVariant1 != null)
            {
                return choiceValueParamVariant1(__value0);
            }
            else if (ChoiceValueParamVariant2 is { } __value1 && choiceValueParamVariant2 != null)
            {
                return choiceValueParamVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? choiceValueParamVariant1 = null,

            global::System.Action<bool?>? choiceValueParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChoiceValueParamVariant1 is { } __value0)
            {
                choiceValueParamVariant1?.Invoke(__value0);
            }
            else if (ChoiceValueParamVariant2 is { } __value1)
            {
                choiceValueParamVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? choiceValueParamVariant1 = null,
            global::System.Action<bool?>? choiceValueParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChoiceValueParamVariant1 is { } __value0)
            {
                choiceValueParamVariant1?.Invoke(__value0);
            }
            else if (ChoiceValueParamVariant2 is { } __value1)
            {
                choiceValueParamVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChoiceValueParamVariant1,
                typeof(string),
                ChoiceValueParamVariant2,
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
        public bool Equals(ChoiceValueParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChoiceValueParamVariant1, other.ChoiceValueParamVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(ChoiceValueParamVariant2, other.ChoiceValueParamVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChoiceValueParam obj1, ChoiceValueParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChoiceValueParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChoiceValueParam obj1, ChoiceValueParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChoiceValueParam o && Equals(o);
        }
    }
}
