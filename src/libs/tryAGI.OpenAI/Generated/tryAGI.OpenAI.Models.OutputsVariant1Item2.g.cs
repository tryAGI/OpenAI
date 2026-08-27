#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputsVariant1Item2 : global::System.IEquatable<OutputsVariant1Item2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// The logs output from the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Logs { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? Logs { get; }
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
            out global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? value)
        {
            value = Logs;
            return IsLogs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs PickLogs() => IsLogs
            ? Logs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Logs' but the value was {ToString()}.");

        /// <summary>
        /// The image output from the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Image { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? Image { get; }
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
            out global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputsVariant1Item2(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs value) => new OutputsVariant1Item2((global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs?(OutputsVariant1Item2 @this) => @this.Logs;

        /// <summary>
        ///
        /// </summary>
        public OutputsVariant1Item2(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? value)
        {
            Logs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputsVariant1Item2 FromLogs(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? value) => new OutputsVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputsVariant1Item2(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage value) => new OutputsVariant1Item2((global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage?(OutputsVariant1Item2 @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public OutputsVariant1Item2(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputsVariant1Item2 FromImage(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? value) => new OutputsVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public OutputsVariant1Item2(
            global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs? logs,
            global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage? image
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
            global::System.Func<global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs, TResult>? logs = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage, TResult>? image = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs>? logs = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage>? image = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs>? logs = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage>? image = null,
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
                typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs),
                Image,
                typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage),
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
        public bool Equals(OutputsVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage?>.Default.Equals(Image, other.Image)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputsVariant1Item2 obj1, OutputsVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputsVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputsVariant1Item2 obj1, OutputsVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputsVariant1Item2 o && Equals(o);
        }
    }
}
