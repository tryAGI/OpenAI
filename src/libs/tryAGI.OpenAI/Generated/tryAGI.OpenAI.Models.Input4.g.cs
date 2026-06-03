#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Moderation for the response input.
    /// </summary>
    public readonly partial struct Input4 : global::System.IEquatable<Input4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ModerationInputDiscriminatorType? Type { get; }

        /// <summary>
        /// A moderation result produced for the response input or output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModerationResultBody? ModerationResult { get; init; }
#else
        public global::tryAGI.OpenAI.ModerationResultBody? ModerationResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModerationResult))]
#endif
        public bool IsModerationResult => ModerationResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModerationResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ModerationResultBody? value)
        {
            value = ModerationResult;
            return IsModerationResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ModerationResultBody PickModerationResult() => IsModerationResult
            ? ModerationResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModerationResult' but the value was {ToString()}.");

        /// <summary>
        /// An error produced while attempting moderation for the response input or output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModerationErrorBody? Error { get; init; }
#else
        public global::tryAGI.OpenAI.ModerationErrorBody? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ModerationErrorBody? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ModerationErrorBody PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input4(global::tryAGI.OpenAI.ModerationResultBody value) => new Input4((global::tryAGI.OpenAI.ModerationResultBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModerationResultBody?(Input4 @this) => @this.ModerationResult;

        /// <summary>
        /// 
        /// </summary>
        public Input4(global::tryAGI.OpenAI.ModerationResultBody? value)
        {
            ModerationResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Input4 FromModerationResult(global::tryAGI.OpenAI.ModerationResultBody? value) => new Input4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input4(global::tryAGI.OpenAI.ModerationErrorBody value) => new Input4((global::tryAGI.OpenAI.ModerationErrorBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModerationErrorBody?(Input4 @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public Input4(global::tryAGI.OpenAI.ModerationErrorBody? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Input4 FromError(global::tryAGI.OpenAI.ModerationErrorBody? value) => new Input4(value);

        /// <summary>
        /// 
        /// </summary>
        public Input4(
            global::tryAGI.OpenAI.ModerationInputDiscriminatorType? type,
            global::tryAGI.OpenAI.ModerationResultBody? moderationResult,
            global::tryAGI.OpenAI.ModerationErrorBody? error
            )
        {
            Type = type;

            ModerationResult = moderationResult;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ModerationResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModerationResult?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModerationResult && !IsError || !IsModerationResult && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ModerationResultBody, TResult>? moderationResult = null,
            global::System.Func<global::tryAGI.OpenAI.ModerationErrorBody, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResult && moderationResult != null)
            {
                return moderationResult(ModerationResult!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ModerationResultBody>? moderationResult = null,

            global::System.Action<global::tryAGI.OpenAI.ModerationErrorBody>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResult)
            {
                moderationResult?.Invoke(ModerationResult!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ModerationResultBody>? moderationResult = null,
            global::System.Action<global::tryAGI.OpenAI.ModerationErrorBody>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResult)
            {
                moderationResult?.Invoke(ModerationResult!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModerationResult,
                typeof(global::tryAGI.OpenAI.ModerationResultBody),
                Error,
                typeof(global::tryAGI.OpenAI.ModerationErrorBody),
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
        public bool Equals(Input4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModerationResultBody?>.Default.Equals(ModerationResult, other.ModerationResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModerationErrorBody?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Input4 obj1, Input4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Input4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Input4 obj1, Input4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Input4 o && Equals(o);
        }
    }
}
