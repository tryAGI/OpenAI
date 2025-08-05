#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration of data sources used in runs of the evaluation.
    /// </summary>
    public readonly partial struct EvalDataSourceConfig : global::System.IEquatable<EvalDataSourceConfig>
    {
        /// <summary>
        /// A CustomDataSourceConfig which specifies the schema of your `item` and optionally `sample` namespaces.<br/>
        /// The response schema defines the shape of the data that will be:<br/>
        /// - Used to define your testing criteria and<br/>
        /// - What data is required when creating a run
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfig? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.EvalCustomDataSourceConfig? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalDataSourceConfig(global::tryAGI.OpenAI.EvalCustomDataSourceConfig value) => new EvalDataSourceConfig((global::tryAGI.OpenAI.EvalCustomDataSourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalCustomDataSourceConfig?(EvalDataSourceConfig @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public EvalDataSourceConfig(global::tryAGI.OpenAI.EvalCustomDataSourceConfig? value)
        {
            Custom = value;
        }

        /// <summary>
        /// A LogsDataSourceConfig which specifies the metadata property of your logs query.<br/>
        /// This is usually metadata like `usecase=chatbot` or `prompt-version=v2`, etc.<br/>
        /// The schema returned by this data source config is used to defined what variables are available in your evals.<br/>
        /// `item` and `sample` are both defined when using this data source config.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfig? Logs { get; init; }
#else
        public global::tryAGI.OpenAI.EvalLogsDataSourceConfig? Logs { get; }
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
        public static implicit operator EvalDataSourceConfig(global::tryAGI.OpenAI.EvalLogsDataSourceConfig value) => new EvalDataSourceConfig((global::tryAGI.OpenAI.EvalLogsDataSourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalLogsDataSourceConfig?(EvalDataSourceConfig @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public EvalDataSourceConfig(global::tryAGI.OpenAI.EvalLogsDataSourceConfig? value)
        {
            Logs = value;
        }

        /// <summary>
        /// Deprecated in favor of LogsDataSourceConfig.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? StoredCompletions { get; init; }
#else
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? StoredCompletions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StoredCompletions))]
#endif
        public bool IsStoredCompletions => StoredCompletions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalDataSourceConfig(global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig value) => new EvalDataSourceConfig((global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig?(EvalDataSourceConfig @this) => @this.StoredCompletions;

        /// <summary>
        /// 
        /// </summary>
        public EvalDataSourceConfig(global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? value)
        {
            StoredCompletions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalDataSourceConfig(
            global::tryAGI.OpenAI.EvalCustomDataSourceConfig? custom,
            global::tryAGI.OpenAI.EvalLogsDataSourceConfig? logs,
            global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig? storedCompletions
            )
        {
            Custom = custom;
            Logs = logs;
            StoredCompletions = storedCompletions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StoredCompletions as object ??
            Logs as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Custom?.ToString() ??
            Logs?.ToString() ??
            StoredCompletions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom || IsLogs || IsStoredCompletions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.EvalCustomDataSourceConfig?, TResult>? custom = null,
            global::System.Func<global::tryAGI.OpenAI.EvalLogsDataSourceConfig?, TResult>? logs = null,
            global::System.Func<global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig?, TResult>? storedCompletions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsLogs && logs != null)
            {
                return logs(Logs!);
            }
            else if (IsStoredCompletions && storedCompletions != null)
            {
                return storedCompletions(StoredCompletions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.EvalCustomDataSourceConfig?>? custom = null,
            global::System.Action<global::tryAGI.OpenAI.EvalLogsDataSourceConfig?>? logs = null,
            global::System.Action<global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig?>? storedCompletions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsLogs)
            {
                logs?.Invoke(Logs!);
            }
            else if (IsStoredCompletions)
            {
                storedCompletions?.Invoke(StoredCompletions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::tryAGI.OpenAI.EvalCustomDataSourceConfig),
                Logs,
                typeof(global::tryAGI.OpenAI.EvalLogsDataSourceConfig),
                StoredCompletions,
                typeof(global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig),
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
        public bool Equals(EvalDataSourceConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalCustomDataSourceConfig?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalLogsDataSourceConfig?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfig?>.Default.Equals(StoredCompletions, other.StoredCompletions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalDataSourceConfig obj1, EvalDataSourceConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalDataSourceConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalDataSourceConfig obj1, EvalDataSourceConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalDataSourceConfig o && Equals(o);
        }
    }
}
