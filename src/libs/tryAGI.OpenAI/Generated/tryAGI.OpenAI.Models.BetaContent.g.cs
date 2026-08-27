#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Multi-modal input and output contents.
    /// </summary>
    public readonly partial struct BetaContent : global::System.IEquatable<BetaContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputContent? InputContentTypes { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputContent? InputContentTypes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputContentTypes))]
#endif
        public bool IsInputContentTypes => InputContentTypes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputContentTypes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputContent? value)
        {
            value = InputContentTypes;
            return IsInputContentTypes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContent PickInputContentTypes() => IsInputContentTypes
            ? InputContentTypes!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputContentTypes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaOutputContent? OutputContentTypes { get; init; }
#else
        public global::tryAGI.OpenAI.BetaOutputContent? OutputContentTypes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputContentTypes))]
#endif
        public bool IsOutputContentTypes => OutputContentTypes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputContentTypes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaOutputContent? value)
        {
            value = OutputContentTypes;
            return IsOutputContentTypes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContent PickOutputContentTypes() => IsOutputContentTypes
            ? OutputContentTypes!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputContentTypes' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaContent(global::tryAGI.OpenAI.BetaInputContent value) => new BetaContent((global::tryAGI.OpenAI.BetaInputContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputContent?(BetaContent @this) => @this.InputContentTypes;

        /// <summary>
        ///
        /// </summary>
        public BetaContent(global::tryAGI.OpenAI.BetaInputContent? value)
        {
            InputContentTypes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaContent FromInputContentTypes(global::tryAGI.OpenAI.BetaInputContent? value) => new BetaContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaContent(global::tryAGI.OpenAI.BetaOutputContent value) => new BetaContent((global::tryAGI.OpenAI.BetaOutputContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaOutputContent?(BetaContent @this) => @this.OutputContentTypes;

        /// <summary>
        ///
        /// </summary>
        public BetaContent(global::tryAGI.OpenAI.BetaOutputContent? value)
        {
            OutputContentTypes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaContent FromOutputContentTypes(global::tryAGI.OpenAI.BetaOutputContent? value) => new BetaContent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaContent(
            global::tryAGI.OpenAI.BetaInputContent? inputContentTypes,
            global::tryAGI.OpenAI.BetaOutputContent? outputContentTypes
            )
        {
            InputContentTypes = inputContentTypes;
            OutputContentTypes = outputContentTypes;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputContentTypes as object ??
            InputContentTypes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputContentTypes?.ToString() ??
            OutputContentTypes?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputContentTypes && !IsOutputContentTypes || !IsInputContentTypes && IsOutputContentTypes;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaInputContent?, TResult>? inputContentTypes = null,
            global::System.Func<global::tryAGI.OpenAI.BetaOutputContent?, TResult>? outputContentTypes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContentTypes && inputContentTypes != null)
            {
                return inputContentTypes(InputContentTypes!);
            }
            else if (IsOutputContentTypes && outputContentTypes != null)
            {
                return outputContentTypes(OutputContentTypes!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaInputContent?>? inputContentTypes = null,

            global::System.Action<global::tryAGI.OpenAI.BetaOutputContent?>? outputContentTypes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContentTypes)
            {
                inputContentTypes?.Invoke(InputContentTypes!);
            }
            else if (IsOutputContentTypes)
            {
                outputContentTypes?.Invoke(OutputContentTypes!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaInputContent?>? inputContentTypes = null,
            global::System.Action<global::tryAGI.OpenAI.BetaOutputContent?>? outputContentTypes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContentTypes)
            {
                inputContentTypes?.Invoke(InputContentTypes!);
            }
            else if (IsOutputContentTypes)
            {
                outputContentTypes?.Invoke(OutputContentTypes!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputContentTypes,
                typeof(global::tryAGI.OpenAI.BetaInputContent),
                OutputContentTypes,
                typeof(global::tryAGI.OpenAI.BetaOutputContent),
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
        public bool Equals(BetaContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputContent?>.Default.Equals(InputContentTypes, other.InputContentTypes) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaOutputContent?>.Default.Equals(OutputContentTypes, other.OutputContentTypes)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaContent obj1, BetaContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaContent obj1, BetaContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaContent o && Equals(o);
        }
    }
}
