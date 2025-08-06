#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputsItem : global::System.IEquatable<OutputsItem>
    {
        /// <summary>
        /// The logs output from the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? CodeInterpreterOutputLogs { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? CodeInterpreterOutputLogs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterOutputLogs))]
#endif
        public bool IsCodeInterpreterOutputLogs => CodeInterpreterOutputLogs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputsItem(global::tryAGI.OpenAI.CodeInterpreterOutputLogs value) => new OutputsItem((global::tryAGI.OpenAI.CodeInterpreterOutputLogs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterOutputLogs?(OutputsItem @this) => @this.CodeInterpreterOutputLogs;

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(global::tryAGI.OpenAI.CodeInterpreterOutputLogs? value)
        {
            CodeInterpreterOutputLogs = value;
        }

        /// <summary>
        /// The image output from the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? CodeInterpreterOutputImage { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? CodeInterpreterOutputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterOutputImage))]
#endif
        public bool IsCodeInterpreterOutputImage => CodeInterpreterOutputImage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputsItem(global::tryAGI.OpenAI.CodeInterpreterOutputImage value) => new OutputsItem((global::tryAGI.OpenAI.CodeInterpreterOutputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterOutputImage?(OutputsItem @this) => @this.CodeInterpreterOutputImage;

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(global::tryAGI.OpenAI.CodeInterpreterOutputImage? value)
        {
            CodeInterpreterOutputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(
            global::tryAGI.OpenAI.CodeInterpreterOutputLogs? codeInterpreterOutputLogs,
            global::tryAGI.OpenAI.CodeInterpreterOutputImage? codeInterpreterOutputImage
            )
        {
            CodeInterpreterOutputLogs = codeInterpreterOutputLogs;
            CodeInterpreterOutputImage = codeInterpreterOutputImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeInterpreterOutputImage as object ??
            CodeInterpreterOutputLogs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterOutputLogs?.ToString() ??
            CodeInterpreterOutputImage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreterOutputLogs || IsCodeInterpreterOutputImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterOutputLogs?, TResult>? codeInterpreterOutputLogs = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterOutputImage?, TResult>? codeInterpreterOutputImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterOutputLogs && codeInterpreterOutputLogs != null)
            {
                return codeInterpreterOutputLogs(CodeInterpreterOutputLogs!);
            }
            else if (IsCodeInterpreterOutputImage && codeInterpreterOutputImage != null)
            {
                return codeInterpreterOutputImage(CodeInterpreterOutputImage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterOutputLogs?>? codeInterpreterOutputLogs = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterOutputImage?>? codeInterpreterOutputImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterOutputLogs)
            {
                codeInterpreterOutputLogs?.Invoke(CodeInterpreterOutputLogs!);
            }
            else if (IsCodeInterpreterOutputImage)
            {
                codeInterpreterOutputImage?.Invoke(CodeInterpreterOutputImage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreterOutputLogs,
                typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogs),
                CodeInterpreterOutputImage,
                typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImage),
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
        public bool Equals(OutputsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterOutputLogs?>.Default.Equals(CodeInterpreterOutputLogs, other.CodeInterpreterOutputLogs) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterOutputImage?>.Default.Equals(CodeInterpreterOutputImage, other.CodeInterpreterOutputImage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputsItem obj1, OutputsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputsItem obj1, OutputsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputsItem o && Equals(o);
        }
    }
}
