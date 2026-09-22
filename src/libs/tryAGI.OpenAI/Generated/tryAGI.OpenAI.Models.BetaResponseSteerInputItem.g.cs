#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaResponseSteerInputItem : global::System.IEquatable<BetaResponseSteerInputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Message { get; init; }
#else
        public global::tryAGI.OpenAI.BetaUserMessageItemParam? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaUserMessageItemParam? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUserMessageItemParam PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? FunctionCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerInputItem(global::tryAGI.OpenAI.BetaUserMessageItemParam value) => new BetaResponseSteerInputItem((global::tryAGI.OpenAI.BetaUserMessageItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaUserMessageItemParam?(BetaResponseSteerInputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerInputItem(global::tryAGI.OpenAI.BetaUserMessageItemParam? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerInputItem FromMessage(global::tryAGI.OpenAI.BetaUserMessageItemParam? value) => new BetaResponseSteerInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerInputItem(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam value) => new BetaResponseSteerInputItem((global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam?(BetaResponseSteerInputItem @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerInputItem(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerInputItem FromFunctionCallOutput(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? value) => new BetaResponseSteerInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerInputItem(
            global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaUserMessageItemParam? message,
            global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? functionCallOutput
            )
        {
            Type = type;

            Message = message;
            FunctionCallOutput = functionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallOutput as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FunctionCallOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaUserMessageItemParam, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam, TResult>? functionCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaUserMessageItemParam>? message = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam>? functionCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaUserMessageItemParam>? message = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam>? functionCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::tryAGI.OpenAI.BetaUserMessageItemParam),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam),
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
        public bool Equals(BetaResponseSteerInputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaUserMessageItemParam?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseSteerInputItem obj1, BetaResponseSteerInputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseSteerInputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseSteerInputItem obj1, BetaResponseSteerInputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseSteerInputItem o && Equals(o);
        }
    }
}
