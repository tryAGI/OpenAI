#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The execution context that produced this tool call.
    /// </summary>
    public readonly partial struct ToolCallCaller : global::System.IEquatable<ToolCallCaller>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DirectToolCallCaller? Direct { get; init; }
#else
        public global::tryAGI.OpenAI.DirectToolCallCaller? Direct { get; }
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
            out global::tryAGI.OpenAI.DirectToolCallCaller? value)
        {
            value = Direct;
            return IsDirect;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.DirectToolCallCaller PickDirect() => IsDirect
            ? Direct!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Direct' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Program { get; init; }
#else
        public global::tryAGI.OpenAI.ProgramToolCallCaller? Program { get; }
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
            out global::tryAGI.OpenAI.ProgramToolCallCaller? value)
        {
            value = Program;
            return IsProgram;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ProgramToolCallCaller PickProgram() => IsProgram
            ? Program!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Program' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallCaller(global::tryAGI.OpenAI.DirectToolCallCaller value) => new ToolCallCaller((global::tryAGI.OpenAI.DirectToolCallCaller?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DirectToolCallCaller?(ToolCallCaller @this) => @this.Direct;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallCaller(global::tryAGI.OpenAI.DirectToolCallCaller? value)
        {
            Direct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolCallCaller FromDirect(global::tryAGI.OpenAI.DirectToolCallCaller? value) => new ToolCallCaller(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallCaller(global::tryAGI.OpenAI.ProgramToolCallCaller value) => new ToolCallCaller((global::tryAGI.OpenAI.ProgramToolCallCaller?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ProgramToolCallCaller?(ToolCallCaller @this) => @this.Program;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallCaller(global::tryAGI.OpenAI.ProgramToolCallCaller? value)
        {
            Program = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolCallCaller FromProgram(global::tryAGI.OpenAI.ProgramToolCallCaller? value) => new ToolCallCaller(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolCallCaller(
            global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType? type,
            global::tryAGI.OpenAI.DirectToolCallCaller? direct,
            global::tryAGI.OpenAI.ProgramToolCallCaller? program
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
            global::System.Func<global::tryAGI.OpenAI.DirectToolCallCaller, TResult>? direct = null,
            global::System.Func<global::tryAGI.OpenAI.ProgramToolCallCaller, TResult>? program = null,
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
            global::System.Action<global::tryAGI.OpenAI.DirectToolCallCaller>? direct = null,

            global::System.Action<global::tryAGI.OpenAI.ProgramToolCallCaller>? program = null,
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
            global::System.Action<global::tryAGI.OpenAI.DirectToolCallCaller>? direct = null,
            global::System.Action<global::tryAGI.OpenAI.ProgramToolCallCaller>? program = null,
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
                typeof(global::tryAGI.OpenAI.DirectToolCallCaller),
                Program,
                typeof(global::tryAGI.OpenAI.ProgramToolCallCaller),
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
        public bool Equals(ToolCallCaller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DirectToolCallCaller?>.Default.Equals(Direct, other.Direct) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ProgramToolCallCaller?>.Default.Equals(Program, other.Program) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallCaller obj1, ToolCallCaller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallCaller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallCaller obj1, ToolCallCaller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallCaller o && Equals(o);
        }
    }
}
