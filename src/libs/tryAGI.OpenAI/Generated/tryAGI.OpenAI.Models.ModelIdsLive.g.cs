#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live model. Required in the session configuration for every transport; do not pass it as a URL query parameter.<br/>
    /// Example: gpt-live-1
    /// </summary>
    public readonly partial struct ModelIdsLive : global::System.IEquatable<ModelIdsLive>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ModelIdsLiveVariant1 { get; init; }
#else
        public string? ModelIdsLiveVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelIdsLiveVariant1))]
#endif
        public bool IsModelIdsLiveVariant1 => ModelIdsLiveVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelIdsLiveVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ModelIdsLiveVariant1;
            return IsModelIdsLiveVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickModelIdsLiveVariant1() => IsModelIdsLiveVariant1
            ? ModelIdsLiveVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelIdsLiveVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.ModelIdsLiveEnum? Enum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ModelIdsLiveEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ModelIdsLiveEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelIdsLive(string value) => new ModelIdsLive((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ModelIdsLive @this) => @this.ModelIdsLiveVariant1;

        /// <summary>
        ///
        /// </summary>
        public ModelIdsLive(string? value)
        {
            ModelIdsLiveVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelIdsLive FromModelIdsLiveVariant1(string? value) => new ModelIdsLive(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelIdsLive(global::tryAGI.OpenAI.ModelIdsLiveEnum value) => new ModelIdsLive((global::tryAGI.OpenAI.ModelIdsLiveEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsLiveEnum?(ModelIdsLive @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public ModelIdsLive(global::tryAGI.OpenAI.ModelIdsLiveEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelIdsLive FromEnum(global::tryAGI.OpenAI.ModelIdsLiveEnum? value) => new ModelIdsLive(value);

        /// <summary>
        ///
        /// </summary>
        public ModelIdsLive(
            string? modelIdsLiveVariant1,
            global::tryAGI.OpenAI.ModelIdsLiveEnum? @enum
            )
        {
            ModelIdsLiveVariant1 = modelIdsLiveVariant1;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            ModelIdsLiveVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ModelIdsLiveVariant1?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsModelIdsLiveVariant1 || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? modelIdsLiveVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.ModelIdsLiveEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelIdsLiveVariant1 && modelIdsLiveVariant1 != null)
            {
                return modelIdsLiveVariant1(ModelIdsLiveVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? modelIdsLiveVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.ModelIdsLiveEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelIdsLiveVariant1)
            {
                modelIdsLiveVariant1?.Invoke(ModelIdsLiveVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? modelIdsLiveVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.ModelIdsLiveEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelIdsLiveVariant1)
            {
                modelIdsLiveVariant1?.Invoke(ModelIdsLiveVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelIdsLiveVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.ModelIdsLiveEnum),
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
        public bool Equals(ModelIdsLive other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ModelIdsLiveVariant1, other.ModelIdsLiveVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsLiveEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelIdsLive obj1, ModelIdsLive obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIdsLive>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelIdsLive obj1, ModelIdsLive obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIdsLive o && Equals(o);
        }
    }
}
