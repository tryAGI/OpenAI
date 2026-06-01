#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PersonalityEnum : global::System.IEquatable<PersonalityEnum>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? PersonalityEnumVariant1 { get; init; }
#else
        public string? PersonalityEnumVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PersonalityEnumVariant1))]
#endif
        public bool IsPersonalityEnumVariant1 => PersonalityEnumVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPersonalityEnumVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = PersonalityEnumVariant1;
            return IsPersonalityEnumVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickPersonalityEnumVariant1() => IsPersonalityEnumVariant1
            ? PersonalityEnumVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PersonalityEnumVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersonalityEnumEnum? PersonalityEnumEnum { get; init; }
#else
        public global::tryAGI.OpenAI.PersonalityEnumEnum? PersonalityEnumEnum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PersonalityEnumEnum))]
#endif
        public bool IsPersonalityEnumEnum => PersonalityEnumEnum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPersonalityEnumEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersonalityEnumEnum? value)
        {
            value = PersonalityEnumEnum;
            return IsPersonalityEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.PersonalityEnumEnum PickPersonalityEnumEnum() => IsPersonalityEnumEnum
            ? PersonalityEnumEnum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PersonalityEnumEnum' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PersonalityEnum(string value) => new PersonalityEnum((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(PersonalityEnum @this) => @this.PersonalityEnumVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PersonalityEnum(string? value)
        {
            PersonalityEnumVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PersonalityEnum FromPersonalityEnumVariant1(string? value) => new PersonalityEnum(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PersonalityEnum(global::tryAGI.OpenAI.PersonalityEnumEnum value) => new PersonalityEnum((global::tryAGI.OpenAI.PersonalityEnumEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersonalityEnumEnum?(PersonalityEnum @this) => @this.PersonalityEnumEnum;

        /// <summary>
        /// 
        /// </summary>
        public PersonalityEnum(global::tryAGI.OpenAI.PersonalityEnumEnum? value)
        {
            PersonalityEnumEnum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PersonalityEnum FromPersonalityEnumEnum(global::tryAGI.OpenAI.PersonalityEnumEnum? value) => new PersonalityEnum(value);

        /// <summary>
        /// 
        /// </summary>
        public PersonalityEnum(
            string? personalityEnumVariant1,
            global::tryAGI.OpenAI.PersonalityEnumEnum? personalityEnumEnum
            )
        {
            PersonalityEnumVariant1 = personalityEnumVariant1;
            PersonalityEnumEnum = personalityEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PersonalityEnumEnum as object ??
            PersonalityEnumVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PersonalityEnumVariant1?.ToString() ??
            PersonalityEnumEnum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPersonalityEnumVariant1 || IsPersonalityEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? personalityEnumVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.PersonalityEnumEnum?, TResult>? personalityEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPersonalityEnumVariant1 && personalityEnumVariant1 != null)
            {
                return personalityEnumVariant1(PersonalityEnumVariant1!);
            }
            else if (IsPersonalityEnumEnum && personalityEnumEnum != null)
            {
                return personalityEnumEnum(PersonalityEnumEnum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? personalityEnumVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.PersonalityEnumEnum?>? personalityEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPersonalityEnumVariant1)
            {
                personalityEnumVariant1?.Invoke(PersonalityEnumVariant1!);
            }
            else if (IsPersonalityEnumEnum)
            {
                personalityEnumEnum?.Invoke(PersonalityEnumEnum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? personalityEnumVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.PersonalityEnumEnum?>? personalityEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPersonalityEnumVariant1)
            {
                personalityEnumVariant1?.Invoke(PersonalityEnumVariant1!);
            }
            else if (IsPersonalityEnumEnum)
            {
                personalityEnumEnum?.Invoke(PersonalityEnumEnum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PersonalityEnumVariant1,
                typeof(string),
                PersonalityEnumEnum,
                typeof(global::tryAGI.OpenAI.PersonalityEnumEnum),
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
        public bool Equals(PersonalityEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(PersonalityEnumVariant1, other.PersonalityEnumVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersonalityEnumEnum?>.Default.Equals(PersonalityEnumEnum, other.PersonalityEnumEnum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PersonalityEnum obj1, PersonalityEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PersonalityEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PersonalityEnum obj1, PersonalityEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PersonalityEnum o && Equals(o);
        }
    }
}
