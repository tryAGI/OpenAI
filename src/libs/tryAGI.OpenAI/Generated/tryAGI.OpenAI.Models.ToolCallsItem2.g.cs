#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem2 : global::System.IEquatable<ToolCallsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem2(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?(ToolCallsItem2 @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem2(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?(ToolCallsItem2 @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Function { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem2(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?(ToolCallsItem2 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? codeInterpreter,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? fileSearch,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? function
            )
        {
            Type = type;

            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            FileSearch as object ??
            CodeInterpreter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreter && !IsFileSearch && !IsFunction || !IsCodeInterpreter && IsFileSearch && !IsFunction || !IsCodeInterpreter && !IsFileSearch && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?, TResult>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreter && codeInterpreter != null)
            {
                return codeInterpreter(CodeInterpreter!);
            }
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreter)
            {
                codeInterpreter?.Invoke(CodeInterpreter!);
            }
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject),
                FileSearch,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject),
                Function,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem2 obj1, ToolCallsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem2 obj1, ToolCallsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem2 o && Equals(o);
        }
    }
}
