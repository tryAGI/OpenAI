#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The configuration for the data source used for the evaluation runs. Dictates the schema of the data used in the evaluation.
    /// </summary>
    public readonly partial struct CreateEvalRequestDataSourceConfig : global::System.IEquatable<CreateEvalRequestDataSourceConfig>
    {
        /// <summary>
        /// A CustomDataSourceConfig object that defines the schema for the data source used for the evaluation runs.<br/>
        /// This schema is used to define the shape of the data that will be:<br/>
        /// - Used to define your testing criteria and<br/>
        /// - What data is required when creating a run
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? Custom { get; }
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
        public static implicit operator CreateEvalRequestDataSourceConfig(global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig value) => new CreateEvalRequestDataSourceConfig((global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig?(CreateEvalRequestDataSourceConfig @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public CreateEvalRequestDataSourceConfig(global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? value)
        {
            Custom = value;
        }

        /// <summary>
        /// A data source config which specifies the metadata property of your logs query.<br/>
        /// This is usually metadata like `usecase=chatbot` or `prompt-version=v2`, etc.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? Logs { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? Logs { get; }
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
        public static implicit operator CreateEvalRequestDataSourceConfig(global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig value) => new CreateEvalRequestDataSourceConfig((global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig?(CreateEvalRequestDataSourceConfig @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public CreateEvalRequestDataSourceConfig(global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? value)
        {
            Logs = value;
        }

        /// <summary>
        /// Deprecated in favor of LogsDataSourceConfig.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? StoredCompletions { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? StoredCompletions { get; }
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
        public static implicit operator CreateEvalRequestDataSourceConfig(global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig value) => new CreateEvalRequestDataSourceConfig((global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig?(CreateEvalRequestDataSourceConfig @this) => @this.StoredCompletions;

        /// <summary>
        /// 
        /// </summary>
        public CreateEvalRequestDataSourceConfig(global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? value)
        {
            StoredCompletions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateEvalRequestDataSourceConfig(
            global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig? custom,
            global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig? logs,
            global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig? storedCompletions
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
            global::System.Func<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig?, TResult>? custom = null,
            global::System.Func<global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig?, TResult>? logs = null,
            global::System.Func<global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig?, TResult>? storedCompletions = null,
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
            global::System.Action<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig?>? custom = null,
            global::System.Action<global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig?>? logs = null,
            global::System.Action<global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig?>? storedCompletions = null,
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
                typeof(global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig),
                Logs,
                typeof(global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig),
                StoredCompletions,
                typeof(global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig),
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
        public bool Equals(CreateEvalRequestDataSourceConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfig?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalLogsDataSourceConfig?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfig?>.Default.Equals(StoredCompletions, other.StoredCompletions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateEvalRequestDataSourceConfig obj1, CreateEvalRequestDataSourceConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEvalRequestDataSourceConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateEvalRequestDataSourceConfig obj1, CreateEvalRequestDataSourceConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEvalRequestDataSourceConfig o && Equals(o);
        }
    }
}
