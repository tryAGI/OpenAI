#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Multi-modal input and output contents.
    /// </summary>
    public readonly partial struct Content5 : global::System.IEquatable<Content5>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputContent? InputContentTypes { get; init; }
#else
        public global::tryAGI.OpenAI.InputContent? InputContentTypes { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputContent? OutputContentTypes { get; init; }
#else
        public global::tryAGI.OpenAI.OutputContent? OutputContentTypes { get; }
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
        public static implicit operator Content5(global::tryAGI.OpenAI.InputContent value) => new Content5((global::tryAGI.OpenAI.InputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputContent?(Content5 @this) => @this.InputContentTypes;

        /// <summary>
        /// 
        /// </summary>
        public Content5(global::tryAGI.OpenAI.InputContent? value)
        {
            InputContentTypes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content5(global::tryAGI.OpenAI.OutputContent value) => new Content5((global::tryAGI.OpenAI.OutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputContent?(Content5 @this) => @this.OutputContentTypes;

        /// <summary>
        /// 
        /// </summary>
        public Content5(global::tryAGI.OpenAI.OutputContent? value)
        {
            OutputContentTypes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Content5(
            global::tryAGI.OpenAI.InputContent? inputContentTypes,
            global::tryAGI.OpenAI.OutputContent? outputContentTypes
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
            global::System.Func<global::tryAGI.OpenAI.InputContent?, TResult>? inputContentTypes = null,
            global::System.Func<global::tryAGI.OpenAI.OutputContent?, TResult>? outputContentTypes = null,
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
            global::System.Action<global::tryAGI.OpenAI.InputContent?>? inputContentTypes = null,
            global::System.Action<global::tryAGI.OpenAI.OutputContent?>? outputContentTypes = null,
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
                typeof(global::tryAGI.OpenAI.InputContent),
                OutputContentTypes,
                typeof(global::tryAGI.OpenAI.OutputContent),
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
        public bool Equals(Content5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputContent?>.Default.Equals(InputContentTypes, other.InputContentTypes) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputContent?>.Default.Equals(OutputContentTypes, other.OutputContentTypes) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content5 obj1, Content5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content5 obj1, Content5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content5 o && Equals(o);
        }
    }
}
