using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepStreamEvent : global::System.IEquatable<RunStepStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant1? Value1 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant1 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant1?(RunStepStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant2? Value2 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant2 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant2?(RunStepStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant3? Value3 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant3 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant3?(RunStepStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant4? Value4 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant4 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant4?(RunStepStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant5? Value5 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant5 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant5?(RunStepStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant6? Value6 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant6 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant6?(RunStepStreamEvent @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEventVariant7? Value7 { get; init; }
#else
        public global::OpenAI.RunStepStreamEventVariant7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant7 value) => new RunStepStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEventVariant7?(RunStepStreamEvent @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::OpenAI.RunStepStreamEventVariant7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(
            global::OpenAI.RunStepStreamEventVariant1? value1,
            global::OpenAI.RunStepStreamEventVariant2? value2,
            global::OpenAI.RunStepStreamEventVariant3? value3,
            global::OpenAI.RunStepStreamEventVariant4? value4,
            global::OpenAI.RunStepStreamEventVariant5? value5,
            global::OpenAI.RunStepStreamEventVariant6? value6,
            global::OpenAI.RunStepStreamEventVariant7? value7
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::OpenAI.RunStepStreamEventVariant1),
                Value2,
                typeof(global::OpenAI.RunStepStreamEventVariant2),
                Value3,
                typeof(global::OpenAI.RunStepStreamEventVariant3),
                Value4,
                typeof(global::OpenAI.RunStepStreamEventVariant4),
                Value5,
                typeof(global::OpenAI.RunStepStreamEventVariant5),
                Value6,
                typeof(global::OpenAI.RunStepStreamEventVariant6),
                Value7,
                typeof(global::OpenAI.RunStepStreamEventVariant7),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RunStepStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEventVariant7?>.Default.Equals(Value7, other.Value7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepStreamEvent obj1, RunStepStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepStreamEvent obj1, RunStepStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepStreamEvent o && Equals(o);
        }
    }
}
