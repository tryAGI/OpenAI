#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem : global::System.IEquatable<ToolCallsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? CodeInterpreter { get; }
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
        public static implicit operator ToolCallsItem(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?(ToolCallsItem @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? FileSearch { get; }
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
        public static implicit operator ToolCallsItem(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?(ToolCallsItem @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Function { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? Function { get; }
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
        public static implicit operator ToolCallsItem(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?(ToolCallsItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? codeInterpreter,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? fileSearch,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? function
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
            global::System.Func<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?, TResult>? function = null,
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
            global::System.Action<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?>? function = null,
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
                typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject),
                FileSearch,
                typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject),
                Function,
                typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem o && Equals(o);
        }
    }
}
