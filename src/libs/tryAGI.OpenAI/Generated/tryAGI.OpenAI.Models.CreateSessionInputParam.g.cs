#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Initial input submitted when creating a session.
    /// </summary>
    public readonly partial struct CreateSessionInputParam : global::System.IEquatable<CreateSessionInputParam>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CreateSessionInputParamVariant1 { get; init; }
#else
        public string? CreateSessionInputParamVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSessionInputParamVariant1))]
#endif
        public bool IsCreateSessionInputParamVariant1 => CreateSessionInputParamVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSessionInputParamVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = CreateSessionInputParamVariant1;
            return IsCreateSessionInputParamVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickCreateSessionInputParamVariant1() => IsCreateSessionInputParamVariant1
            ? CreateSessionInputParamVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSessionInputParamVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? CreateSessionInputParamVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? CreateSessionInputParamVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSessionInputParamVariant2))]
#endif
        public bool IsCreateSessionInputParamVariant2 => CreateSessionInputParamVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSessionInputParamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? value)
        {
            value = CreateSessionInputParamVariant2;
            return IsCreateSessionInputParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam> PickCreateSessionInputParamVariant2() => IsCreateSessionInputParamVariant2
            ? CreateSessionInputParamVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSessionInputParamVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSessionInputParam(string value) => new CreateSessionInputParam((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(CreateSessionInputParam @this) => @this.CreateSessionInputParamVariant1;

        /// <summary>
        ///
        /// </summary>
        public CreateSessionInputParam(string? value)
        {
            CreateSessionInputParamVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSessionInputParam FromCreateSessionInputParamVariant1(string? value) => new CreateSessionInputParam(value);

        /// <summary>
        ///
        /// </summary>
        public CreateSessionInputParam(
            string? createSessionInputParamVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>? createSessionInputParamVariant2
            )
        {
            CreateSessionInputParamVariant1 = createSessionInputParamVariant1;
            CreateSessionInputParamVariant2 = createSessionInputParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateSessionInputParamVariant2 as object ??
            CreateSessionInputParamVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateSessionInputParamVariant1?.ToString() ??
            CreateSessionInputParamVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateSessionInputParamVariant1 && !IsCreateSessionInputParamVariant2 || !IsCreateSessionInputParamVariant1 && IsCreateSessionInputParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? createSessionInputParamVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>, TResult>? createSessionInputParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateSessionInputParamVariant1 && createSessionInputParamVariant1 != null)
            {
                return createSessionInputParamVariant1(CreateSessionInputParamVariant1!);
            }
            else if (IsCreateSessionInputParamVariant2 && createSessionInputParamVariant2 != null)
            {
                return createSessionInputParamVariant2(CreateSessionInputParamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? createSessionInputParamVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>>? createSessionInputParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateSessionInputParamVariant1)
            {
                createSessionInputParamVariant1?.Invoke(CreateSessionInputParamVariant1!);
            }
            else if (IsCreateSessionInputParamVariant2)
            {
                createSessionInputParamVariant2?.Invoke(CreateSessionInputParamVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? createSessionInputParamVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>>? createSessionInputParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateSessionInputParamVariant1)
            {
                createSessionInputParamVariant1?.Invoke(CreateSessionInputParamVariant1!);
            }
            else if (IsCreateSessionInputParamVariant2)
            {
                createSessionInputParamVariant2?.Invoke(CreateSessionInputParamVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateSessionInputParamVariant1,
                typeof(string),
                CreateSessionInputParamVariant2,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>),
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
        public bool Equals(CreateSessionInputParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CreateSessionInputParamVariant1, other.CreateSessionInputParamVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>?>.Default.Equals(CreateSessionInputParamVariant2, other.CreateSessionInputParamVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateSessionInputParam obj1, CreateSessionInputParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSessionInputParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateSessionInputParam obj1, CreateSessionInputParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSessionInputParam o && Equals(o);
        }
    }
}
