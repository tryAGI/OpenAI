#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Provider3 : global::System.IEquatable<Provider3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Aws { get; init; }
#else
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Aws { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAws(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AwsExternalStorageProviderParams? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Azure { get; init; }
#else
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Azure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AzureExternalStorageProviderParams? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams PickAzure() => Azure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Gcp { get; init; }
#else
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Gcp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcp))]
#endif
        public bool IsGcp => Gcp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GcpExternalStorageProviderParams? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams? Oci { get; init; }
#else
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams? Oci { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oci))]
#endif
        public bool IsOci => Oci != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOci(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.OciExternalStorageProviderParams? value)
        {
            value = Oci;
            return IsOci;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderParams PickOci() => Oci is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Oci' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.AwsExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.AwsExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AwsExternalStorageProviderParams?(Provider3 @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.AwsExternalStorageProviderParams? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromAws(global::tryAGI.OpenAI.AwsExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.AzureExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.AzureExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AzureExternalStorageProviderParams?(Provider3 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.AzureExternalStorageProviderParams? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromAzure(global::tryAGI.OpenAI.AzureExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.GcpExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.GcpExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GcpExternalStorageProviderParams?(Provider3 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.GcpExternalStorageProviderParams? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromGcp(global::tryAGI.OpenAI.GcpExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.OciExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.OciExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OciExternalStorageProviderParams?(Provider3 @this) => @this.Oci;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.OciExternalStorageProviderParams? value)
        {
            Oci = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromOci(global::tryAGI.OpenAI.OciExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public Provider3(
            global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? type,
            global::tryAGI.OpenAI.AwsExternalStorageProviderParams? aws,
            global::tryAGI.OpenAI.AzureExternalStorageProviderParams? azure,
            global::tryAGI.OpenAI.GcpExternalStorageProviderParams? gcp,
            global::tryAGI.OpenAI.OciExternalStorageProviderParams? oci
            )
        {
            Type = type;

            Aws = aws;
            Azure = azure;
            Gcp = gcp;
            Oci = oci;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Oci as object ??
            Gcp as object ??
            Azure as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Azure?.ToString() ??
            Gcp?.ToString() ??
            Oci?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsAzure && !IsGcp && !IsOci || !IsAws && IsAzure && !IsGcp && !IsOci || !IsAws && !IsAzure && IsGcp && !IsOci || !IsAws && !IsAzure && !IsGcp && IsOci;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AwsExternalStorageProviderParams, TResult>? aws = null,
            global::System.Func<global::tryAGI.OpenAI.AzureExternalStorageProviderParams, TResult>? azure = null,
            global::System.Func<global::tryAGI.OpenAI.GcpExternalStorageProviderParams, TResult>? gcp = null,
            global::System.Func<global::tryAGI.OpenAI.OciExternalStorageProviderParams, TResult>? oci = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0 && aws != null)
            {
                return aws(__value0);
            }
            else if (Azure is { } __value1 && azure != null)
            {
                return azure(__value1);
            }
            else if (Gcp is { } __value2 && gcp != null)
            {
                return gcp(__value2);
            }
            else if (Oci is { } __value3 && oci != null)
            {
                return oci(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderParams>? aws = null,

            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderParams>? azure = null,

            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderParams>? gcp = null,

            global::System.Action<global::tryAGI.OpenAI.OciExternalStorageProviderParams>? oci = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
            else if (Gcp is { } __value2)
            {
                gcp?.Invoke(__value2);
            }
            else if (Oci is { } __value3)
            {
                oci?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderParams>? aws = null,
            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderParams>? azure = null,
            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderParams>? gcp = null,
            global::System.Action<global::tryAGI.OpenAI.OciExternalStorageProviderParams>? oci = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
            else if (Gcp is { } __value2)
            {
                gcp?.Invoke(__value2);
            }
            else if (Oci is { } __value3)
            {
                oci?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aws,
                typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams),
                Azure,
                typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams),
                Gcp,
                typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams),
                Oci,
                typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParams),
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
        public bool Equals(Provider3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AwsExternalStorageProviderParams?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AzureExternalStorageProviderParams?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GcpExternalStorageProviderParams?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OciExternalStorageProviderParams?>.Default.Equals(Oci, other.Oci)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Provider3 obj1, Provider3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Provider3 obj1, Provider3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider3 o && Equals(o);
        }
    }
}
