#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputsVariant1Item : global::System.IEquatable<OutputsVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// The logs output from the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? Logs { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs? Logs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Logs))]
#endif
        public bool IsLogs => Logs != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLogs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CodeInterpreterOutputLogs? value)
        {
            value = Logs;
            return IsLogs;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogs PickLogs() => IsLogs
            ? Logs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Logs' but the value was {ToString()}.");

        /// <summary>
        /// The image output from the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? Image { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CodeInterpreterOutputImage? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.CodeInterpreterOutputImage PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputsVariant1Item(global::tryAGI.OpenAI.CodeInterpreterOutputLogs value) => new OutputsVariant1Item((global::tryAGI.OpenAI.CodeInterpreterOutputLogs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterOutputLogs?(OutputsVariant1Item @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public OutputsVariant1Item(global::tryAGI.OpenAI.CodeInterpreterOutputLogs? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputsVariant1Item FromLogs(global::tryAGI.OpenAI.CodeInterpreterOutputLogs? value) => new OutputsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputsVariant1Item(global::tryAGI.OpenAI.CodeInterpreterOutputImage value) => new OutputsVariant1Item((global::tryAGI.OpenAI.CodeInterpreterOutputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterOutputImage?(OutputsVariant1Item @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public OutputsVariant1Item(global::tryAGI.OpenAI.CodeInterpreterOutputImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputsVariant1Item FromImage(global::tryAGI.OpenAI.CodeInterpreterOutputImage? value) => new OutputsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputsVariant1Item(
            global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.CodeInterpreterOutputLogs? logs,
            global::tryAGI.OpenAI.CodeInterpreterOutputImage? image
            )
        {
            Type = type;

            Logs = logs;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Logs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Logs?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLogs && !IsImage || !IsLogs && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterOutputLogs, TResult>? logs = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterOutputImage, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs && logs != null)
            {
                return logs(Logs!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterOutputLogs>? logs = null,

            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterOutputImage>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs)
            {
                logs?.Invoke(Logs!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterOutputLogs>? logs = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterOutputImage>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs)
            {
                logs?.Invoke(Logs!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Logs,
                typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogs),
                Image,
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
        public bool Equals(OutputsVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterOutputLogs?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterOutputImage?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputsVariant1Item obj1, OutputsVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputsVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputsVariant1Item obj1, OutputsVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputsVariant1Item o && Equals(o);
        }
    }
}
