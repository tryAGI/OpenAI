#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The execution context that produced this tool call.
    /// </summary>
    public readonly partial struct ToolCallCallerParam : global::System.IEquatable<ToolCallCallerParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Direct { get; init; }
#else
        public global::tryAGI.OpenAI.DirectToolCallCallerParam? Direct { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Direct))]
#endif
        public bool IsDirect => Direct != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDirect(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.DirectToolCallCallerParam? value)
        {
            value = Direct;
            return IsDirect;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCallerParam PickDirect() => IsDirect
            ? Direct!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Direct' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Program { get; init; }
#else
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam? Program { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Program))]
#endif
        public bool IsProgram => Program != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProgram(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ProgramToolCallCallerParam? value)
        {
            value = Program;
            return IsProgram;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCallerParam PickProgram() => IsProgram
            ? Program!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Program' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolCallCallerParam(global::tryAGI.OpenAI.DirectToolCallCallerParam value) => new ToolCallCallerParam((global::tryAGI.OpenAI.DirectToolCallCallerParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DirectToolCallCallerParam?(ToolCallCallerParam @this) => @this.Direct;

        /// <summary>
        ///
        /// </summary>
        public ToolCallCallerParam(global::tryAGI.OpenAI.DirectToolCallCallerParam? value)
        {
            Direct = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolCallCallerParam FromDirect(global::tryAGI.OpenAI.DirectToolCallCallerParam? value) => new ToolCallCallerParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolCallCallerParam(global::tryAGI.OpenAI.ProgramToolCallCallerParam value) => new ToolCallCallerParam((global::tryAGI.OpenAI.ProgramToolCallCallerParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ProgramToolCallCallerParam?(ToolCallCallerParam @this) => @this.Program;

        /// <summary>
        ///
        /// </summary>
        public ToolCallCallerParam(global::tryAGI.OpenAI.ProgramToolCallCallerParam? value)
        {
            Program = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolCallCallerParam FromProgram(global::tryAGI.OpenAI.ProgramToolCallCallerParam? value) => new ToolCallCallerParam(value);

        /// <summary>
        ///
        /// </summary>
        public ToolCallCallerParam(
            global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType? type,
            global::tryAGI.OpenAI.DirectToolCallCallerParam? direct,
            global::tryAGI.OpenAI.ProgramToolCallCallerParam? program
            )
        {
            Type = type;

            Direct = direct;
            Program = program;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Program as object ??
            Direct as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Direct?.ToString() ??
            Program?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDirect && !IsProgram || !IsDirect && IsProgram;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.DirectToolCallCallerParam, TResult>? direct = null,
            global::System.Func<global::tryAGI.OpenAI.ProgramToolCallCallerParam, TResult>? program = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirect && direct != null)
            {
                return direct(Direct!);
            }
            else if (IsProgram && program != null)
            {
                return program(Program!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.DirectToolCallCallerParam>? direct = null,

            global::System.Action<global::tryAGI.OpenAI.ProgramToolCallCallerParam>? program = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirect)
            {
                direct?.Invoke(Direct!);
            }
            else if (IsProgram)
            {
                program?.Invoke(Program!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.DirectToolCallCallerParam>? direct = null,
            global::System.Action<global::tryAGI.OpenAI.ProgramToolCallCallerParam>? program = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirect)
            {
                direct?.Invoke(Direct!);
            }
            else if (IsProgram)
            {
                program?.Invoke(Program!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Direct,
                typeof(global::tryAGI.OpenAI.DirectToolCallCallerParam),
                Program,
                typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParam),
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
        public bool Equals(ToolCallCallerParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DirectToolCallCallerParam?>.Default.Equals(Direct, other.Direct) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ProgramToolCallCallerParam?>.Default.Equals(Program, other.Program)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolCallCallerParam obj1, ToolCallCallerParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallCallerParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolCallCallerParam obj1, ToolCallCallerParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallCallerParam o && Equals(o);
        }
    }
}
