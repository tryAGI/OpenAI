
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> : global::System.IEquatable<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
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
        public bool TryPickValue1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T1? value)
        {
            value = Value1;
            return IsValue1;
        }

        /// <summary>
        ///
        /// </summary>
        public T1 PickValue1() => IsValue1
            ? Value1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T2? Value2 { get; init; }
#else
        public T2? Value2 { get; }
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
        public bool TryPickValue2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T2? value)
        {
            value = Value2;
            return IsValue2;
        }

        /// <summary>
        ///
        /// </summary>
        public T2 PickValue2() => IsValue2
            ? Value2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T3? Value3 { get; init; }
#else
        public T3? Value3 { get; }
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
        public bool TryPickValue3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T3? value)
        {
            value = Value3;
            return IsValue3;
        }

        /// <summary>
        ///
        /// </summary>
        public T3 PickValue3() => IsValue3
            ? Value3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T4? Value4 { get; init; }
#else
        public T4? Value4 { get; }
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
        public bool TryPickValue4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T4? value)
        {
            value = Value4;
            return IsValue4;
        }

        /// <summary>
        ///
        /// </summary>
        public T4 PickValue4() => IsValue4
            ? Value4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T5? Value5 { get; init; }
#else
        public T5? Value5 { get; }
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
        public bool TryPickValue5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T5? value)
        {
            value = Value5;
            return IsValue5;
        }

        /// <summary>
        ///
        /// </summary>
        public T5 PickValue5() => IsValue5
            ? Value5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T6? Value6 { get; init; }
#else
        public T6? Value6 { get; }
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
        public bool TryPickValue6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T6? value)
        {
            value = Value6;
            return IsValue6;
        }

        /// <summary>
        ///
        /// </summary>
        public T6 PickValue6() => IsValue6
            ? Value6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T7? Value7 { get; init; }
#else
        public T7? Value7 { get; }
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
        public bool TryPickValue7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T7? value)
        {
            value = Value7;
            return IsValue7;
        }

        /// <summary>
        ///
        /// </summary>
        public T7 PickValue7() => IsValue7
            ? Value7!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T8? Value8 { get; init; }
#else
        public T8? Value8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T8? value)
        {
            value = Value8;
            return IsValue8;
        }

        /// <summary>
        ///
        /// </summary>
        public T8 PickValue8() => IsValue8
            ? Value8!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T9? Value9 { get; init; }
#else
        public T9? Value9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T9? value)
        {
            value = Value9;
            return IsValue9;
        }

        /// <summary>
        ///
        /// </summary>
        public T9 PickValue9() => IsValue9
            ? Value9!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T10? Value10 { get; init; }
#else
        public T10? Value10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T10? value)
        {
            value = Value10;
            return IsValue10;
        }

        /// <summary>
        ///
        /// </summary>
        public T10 PickValue10() => IsValue10
            ? Value10!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T11? Value11 { get; init; }
#else
        public T11? Value11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T11? value)
        {
            value = Value11;
            return IsValue11;
        }

        /// <summary>
        ///
        /// </summary>
        public T11 PickValue11() => IsValue11
            ? Value11!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T12? Value12 { get; init; }
#else
        public T12? Value12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T12? value)
        {
            value = Value12;
            return IsValue12;
        }

        /// <summary>
        ///
        /// </summary>
        public T12 PickValue12() => IsValue12
            ? Value12!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T13? Value13 { get; init; }
#else
        public T13? Value13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T13? value)
        {
            value = Value13;
            return IsValue13;
        }

        /// <summary>
        ///
        /// </summary>
        public T13 PickValue13() => IsValue13
            ? Value13!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value13' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T14? Value14 { get; init; }
#else
        public T14? Value14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T14? value)
        {
            value = Value14;
            return IsValue14;
        }

        /// <summary>
        ///
        /// </summary>
        public T14 PickValue14() => IsValue14
            ? Value14!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T15? Value15 { get; init; }
#else
        public T15? Value15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T15? value)
        {
            value = Value15;
            return IsValue15;
        }

        /// <summary>
        ///
        /// </summary>
        public T15 PickValue15() => IsValue15
            ? Value15!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T16? Value16 { get; init; }
#else
        public T16? Value16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T16? value)
        {
            value = Value16;
            return IsValue16;
        }

        /// <summary>
        ///
        /// </summary>
        public T16 PickValue16() => IsValue16
            ? Value16!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value16' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T17? Value17 { get; init; }
#else
        public T17? Value17 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T17? value)
        {
            value = Value17;
            return IsValue17;
        }

        /// <summary>
        ///
        /// </summary>
        public T17 PickValue17() => IsValue17
            ? Value17!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value17' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T18? Value18 { get; init; }
#else
        public T18? Value18 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T18? value)
        {
            value = Value18;
            return IsValue18;
        }

        /// <summary>
        ///
        /// </summary>
        public T18 PickValue18() => IsValue18
            ? Value18!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value18' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T19? Value19 { get; init; }
#else
        public T19? Value19 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T19? value)
        {
            value = Value19;
            return IsValue19;
        }

        /// <summary>
        ///
        /// </summary>
        public T19 PickValue19() => IsValue19
            ? Value19!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value19' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T20? Value20 { get; init; }
#else
        public T20? Value20 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value20))]
#endif
        public bool IsValue20 => Value20 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T20? value)
        {
            value = Value20;
            return IsValue20;
        }

        /// <summary>
        ///
        /// </summary>
        public T20 PickValue20() => IsValue20
            ? Value20!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value20' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T21? Value21 { get; init; }
#else
        public T21? Value21 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value21))]
#endif
        public bool IsValue21 => Value21 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T21? value)
        {
            value = Value21;
            return IsValue21;
        }

        /// <summary>
        ///
        /// </summary>
        public T21 PickValue21() => IsValue21
            ? Value21!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value21' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T22? Value22 { get; init; }
#else
        public T22? Value22 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value22))]
#endif
        public bool IsValue22 => Value22 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T22? value)
        {
            value = Value22;
            return IsValue22;
        }

        /// <summary>
        ///
        /// </summary>
        public T22 PickValue22() => IsValue22
            ? Value22!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value22' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T23? Value23 { get; init; }
#else
        public T23? Value23 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value23))]
#endif
        public bool IsValue23 => Value23 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue23(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T23? value)
        {
            value = Value23;
            return IsValue23;
        }

        /// <summary>
        ///
        /// </summary>
        public T23 PickValue23() => IsValue23
            ? Value23!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value23' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T24? Value24 { get; init; }
#else
        public T24? Value24 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value24))]
#endif
        public bool IsValue24 => Value24 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue24(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T24? value)
        {
            value = Value24;
            return IsValue24;
        }

        /// <summary>
        ///
        /// </summary>
        public T24 PickValue24() => IsValue24
            ? Value24!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value24' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T25? Value25 { get; init; }
#else
        public T25? Value25 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value25))]
#endif
        public bool IsValue25 => Value25 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T25? value)
        {
            value = Value25;
            return IsValue25;
        }

        /// <summary>
        ///
        /// </summary>
        public T25 PickValue25() => IsValue25
            ? Value25!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value25' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T26? Value26 { get; init; }
#else
        public T26? Value26 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value26))]
#endif
        public bool IsValue26 => Value26 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue26(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T26? value)
        {
            value = Value26;
            return IsValue26;
        }

        /// <summary>
        ///
        /// </summary>
        public T26 PickValue26() => IsValue26
            ? Value26!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value26' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T27? Value27 { get; init; }
#else
        public T27? Value27 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value27))]
#endif
        public bool IsValue27 => Value27 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue27(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T27? value)
        {
            value = Value27;
            return IsValue27;
        }

        /// <summary>
        ///
        /// </summary>
        public T27 PickValue27() => IsValue27
            ? Value27!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value27' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T28? Value28 { get; init; }
#else
        public T28? Value28 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value28))]
#endif
        public bool IsValue28 => Value28 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue28(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T28? value)
        {
            value = Value28;
            return IsValue28;
        }

        /// <summary>
        ///
        /// </summary>
        public T28 PickValue28() => IsValue28
            ? Value28!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value28' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T29? Value29 { get; init; }
#else
        public T29? Value29 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value29))]
#endif
        public bool IsValue29 => Value29 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue29(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T29? value)
        {
            value = Value29;
            return IsValue29;
        }

        /// <summary>
        ///
        /// </summary>
        public T29 PickValue29() => IsValue29
            ? Value29!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value29' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T30? Value30 { get; init; }
#else
        public T30? Value30 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value30))]
#endif
        public bool IsValue30 => Value30 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue30(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T30? value)
        {
            value = Value30;
            return IsValue30;
        }

        /// <summary>
        ///
        /// </summary>
        public T30 PickValue30() => IsValue30
            ? Value30!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value30' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T31? Value31 { get; init; }
#else
        public T31? Value31 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value31))]
#endif
        public bool IsValue31 => Value31 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue31(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T31? value)
        {
            value = Value31;
            return IsValue31;
        }

        /// <summary>
        ///
        /// </summary>
        public T31 PickValue31() => IsValue31
            ? Value31!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value31' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T32? Value32 { get; init; }
#else
        public T32? Value32 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value32))]
#endif
        public bool IsValue32 => Value32 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue32(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T32? value)
        {
            value = Value32;
            return IsValue32;
        }

        /// <summary>
        ///
        /// </summary>
        public T32 PickValue32() => IsValue32
            ? Value32!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value32' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T33? Value33 { get; init; }
#else
        public T33? Value33 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value33))]
#endif
        public bool IsValue33 => Value33 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue33(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T33? value)
        {
            value = Value33;
            return IsValue33;
        }

        /// <summary>
        ///
        /// </summary>
        public T33 PickValue33() => IsValue33
            ? Value33!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value33' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T34? Value34 { get; init; }
#else
        public T34? Value34 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value34))]
#endif
        public bool IsValue34 => Value34 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue34(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T34? value)
        {
            value = Value34;
            return IsValue34;
        }

        /// <summary>
        ///
        /// </summary>
        public T34 PickValue34() => IsValue34
            ? Value34!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value34' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T35? Value35 { get; init; }
#else
        public T35? Value35 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value35))]
#endif
        public bool IsValue35 => Value35 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue35(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T35? value)
        {
            value = Value35;
            return IsValue35;
        }

        /// <summary>
        ///
        /// </summary>
        public T35 PickValue35() => IsValue35
            ? Value35!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value35' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T36? Value36 { get; init; }
#else
        public T36? Value36 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value36))]
#endif
        public bool IsValue36 => Value36 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue36(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T36? value)
        {
            value = Value36;
            return IsValue36;
        }

        /// <summary>
        ///
        /// </summary>
        public T36 PickValue36() => IsValue36
            ? Value36!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value36' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T37? Value37 { get; init; }
#else
        public T37? Value37 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value37))]
#endif
        public bool IsValue37 => Value37 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue37(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T37? value)
        {
            value = Value37;
            return IsValue37;
        }

        /// <summary>
        ///
        /// </summary>
        public T37 PickValue37() => IsValue37
            ? Value37!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value37' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T38? Value38 { get; init; }
#else
        public T38? Value38 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value38))]
#endif
        public bool IsValue38 => Value38 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue38(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T38? value)
        {
            value = Value38;
            return IsValue38;
        }

        /// <summary>
        ///
        /// </summary>
        public T38 PickValue38() => IsValue38
            ? Value38!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value38' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T39? Value39 { get; init; }
#else
        public T39? Value39 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value39))]
#endif
        public bool IsValue39 => Value39 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue39(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T39? value)
        {
            value = Value39;
            return IsValue39;
        }

        /// <summary>
        ///
        /// </summary>
        public T39 PickValue39() => IsValue39
            ? Value39!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value39' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T40? Value40 { get; init; }
#else
        public T40? Value40 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value40))]
#endif
        public bool IsValue40 => Value40 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue40(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T40? value)
        {
            value = Value40;
            return IsValue40;
        }

        /// <summary>
        ///
        /// </summary>
        public T40 PickValue40() => IsValue40
            ? Value40!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value40' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T41? Value41 { get; init; }
#else
        public T41? Value41 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value41))]
#endif
        public bool IsValue41 => Value41 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue41(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T41? value)
        {
            value = Value41;
            return IsValue41;
        }

        /// <summary>
        ///
        /// </summary>
        public T41 PickValue41() => IsValue41
            ? Value41!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value41' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T42? Value42 { get; init; }
#else
        public T42? Value42 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value42))]
#endif
        public bool IsValue42 => Value42 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue42(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T42? value)
        {
            value = Value42;
            return IsValue42;
        }

        /// <summary>
        ///
        /// </summary>
        public T42 PickValue42() => IsValue42
            ? Value42!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value42' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T43? Value43 { get; init; }
#else
        public T43? Value43 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value43))]
#endif
        public bool IsValue43 => Value43 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue43(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T43? value)
        {
            value = Value43;
            return IsValue43;
        }

        /// <summary>
        ///
        /// </summary>
        public T43 PickValue43() => IsValue43
            ? Value43!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value43' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T44? Value44 { get; init; }
#else
        public T44? Value44 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value44))]
#endif
        public bool IsValue44 => Value44 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue44(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T44? value)
        {
            value = Value44;
            return IsValue44;
        }

        /// <summary>
        ///
        /// </summary>
        public T44 PickValue44() => IsValue44
            ? Value44!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value44' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T45? Value45 { get; init; }
#else
        public T45? Value45 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value45))]
#endif
        public bool IsValue45 => Value45 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue45(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T45? value)
        {
            value = Value45;
            return IsValue45;
        }

        /// <summary>
        ///
        /// </summary>
        public T45 PickValue45() => IsValue45
            ? Value45!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value45' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T46? Value46 { get; init; }
#else
        public T46? Value46 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value46))]
#endif
        public bool IsValue46 => Value46 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue46(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T46? value)
        {
            value = Value46;
            return IsValue46;
        }

        /// <summary>
        ///
        /// </summary>
        public T46 PickValue46() => IsValue46
            ? Value46!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value46' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T47? Value47 { get; init; }
#else
        public T47? Value47 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value47))]
#endif
        public bool IsValue47 => Value47 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue47(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T47? value)
        {
            value = Value47;
            return IsValue47;
        }

        /// <summary>
        ///
        /// </summary>
        public T47 PickValue47() => IsValue47
            ? Value47!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value47' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T48? Value48 { get; init; }
#else
        public T48? Value48 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value48))]
#endif
        public bool IsValue48 => Value48 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue48(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T48? value)
        {
            value = Value48;
            return IsValue48;
        }

        /// <summary>
        ///
        /// </summary>
        public T48 PickValue48() => IsValue48
            ? Value48!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value48' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T49? Value49 { get; init; }
#else
        public T49? Value49 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value49))]
#endif
        public bool IsValue49 => Value49 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue49(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T49? value)
        {
            value = Value49;
            return IsValue49;
        }

        /// <summary>
        ///
        /// </summary>
        public T49 PickValue49() => IsValue49
            ? Value49!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value49' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T50? Value50 { get; init; }
#else
        public T50? Value50 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value50))]
#endif
        public bool IsValue50 => Value50 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue50(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T50? value)
        {
            value = Value50;
            return IsValue50;
        }

        /// <summary>
        ///
        /// </summary>
        public T50 PickValue50() => IsValue50
            ? Value50!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value50' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T51? Value51 { get; init; }
#else
        public T51? Value51 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value51))]
#endif
        public bool IsValue51 => Value51 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue51(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T51? value)
        {
            value = Value51;
            return IsValue51;
        }

        /// <summary>
        ///
        /// </summary>
        public T51 PickValue51() => IsValue51
            ? Value51!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value51' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T52? Value52 { get; init; }
#else
        public T52? Value52 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value52))]
#endif
        public bool IsValue52 => Value52 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue52(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T52? value)
        {
            value = Value52;
            return IsValue52;
        }

        /// <summary>
        ///
        /// </summary>
        public T52 PickValue52() => IsValue52
            ? Value52!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value52' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T53? Value53 { get; init; }
#else
        public T53? Value53 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value53))]
#endif
        public bool IsValue53 => Value53 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue53(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T53? value)
        {
            value = Value53;
            return IsValue53;
        }

        /// <summary>
        ///
        /// </summary>
        public T53 PickValue53() => IsValue53
            ? Value53!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value53' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T54? Value54 { get; init; }
#else
        public T54? Value54 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value54))]
#endif
        public bool IsValue54 => Value54 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue54(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T54? value)
        {
            value = Value54;
            return IsValue54;
        }

        /// <summary>
        ///
        /// </summary>
        public T54 PickValue54() => IsValue54
            ? Value54!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value54' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T55? Value55 { get; init; }
#else
        public T55? Value55 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value55))]
#endif
        public bool IsValue55 => Value55 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue55(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T55? value)
        {
            value = Value55;
            return IsValue55;
        }

        /// <summary>
        ///
        /// </summary>
        public T55 PickValue55() => IsValue55
            ? Value55!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value55' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T56? Value56 { get; init; }
#else
        public T56? Value56 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value56))]
#endif
        public bool IsValue56 => Value56 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue56(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T56? value)
        {
            value = Value56;
            return IsValue56;
        }

        /// <summary>
        ///
        /// </summary>
        public T56 PickValue56() => IsValue56
            ? Value56!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value56' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T57? Value57 { get; init; }
#else
        public T57? Value57 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value57))]
#endif
        public bool IsValue57 => Value57 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue57(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T57? value)
        {
            value = Value57;
            return IsValue57;
        }

        /// <summary>
        ///
        /// </summary>
        public T57 PickValue57() => IsValue57
            ? Value57!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value57' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public T58? Value58 { get; init; }
#else
        public T58? Value58 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value58))]
#endif
        public bool IsValue58 => Value58 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickValue58(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out T58? value)
        {
            value = Value58;
            return IsValue58;
        }

        /// <summary>
        ///
        /// </summary>
        public T58 PickValue58() => IsValue58
            ? Value58!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Value58' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T1 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T1?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value1;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T1? value)
        {
            Value1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue1(T1? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T2 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T2?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value2;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T2? value)
        {
            Value2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue2(T2? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T3 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T3?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value3;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T3? value)
        {
            Value3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue3(T3? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T4 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T4?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value4;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T4? value)
        {
            Value4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue4(T4? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T5 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T5?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value5;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T5? value)
        {
            Value5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue5(T5? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T6 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T6?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value6;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T6? value)
        {
            Value6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue6(T6? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T7 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T7?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value7;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T7? value)
        {
            Value7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue7(T7? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T8 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T8?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value8;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T8? value)
        {
            Value8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue8(T8? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T9 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T9?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value9;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T9? value)
        {
            Value9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue9(T9? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T10 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T10?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value10;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T10? value)
        {
            Value10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue10(T10? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T11 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T11?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value11;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T11? value)
        {
            Value11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue11(T11? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T12 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T12?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value12;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T12? value)
        {
            Value12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue12(T12? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T13 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T13?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T13?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value13;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T13? value)
        {
            Value13 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue13(T13? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T14 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T14?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T14?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value14;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T14? value)
        {
            Value14 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue14(T14? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T15 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T15?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value15;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T15? value)
        {
            Value15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue15(T15? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T16 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T16?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T16?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value16;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T16? value)
        {
            Value16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue16(T16? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T17 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T17?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T17?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value17;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T17? value)
        {
            Value17 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue17(T17? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T18 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T18?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T18?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value18;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T18? value)
        {
            Value18 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue18(T18? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T19 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T19?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T19?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value19;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T19? value)
        {
            Value19 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue19(T19? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T20 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T20?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T20?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value20;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T20? value)
        {
            Value20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue20(T20? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T21 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T21?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T21?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value21;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T21? value)
        {
            Value21 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue21(T21? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T22 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T22?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T22?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value22;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T22? value)
        {
            Value22 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue22(T22? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T23 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T23?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T23?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value23;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T23? value)
        {
            Value23 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue23(T23? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T24 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T24?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T24?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value24;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T24? value)
        {
            Value24 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue24(T24? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T25 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T25?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T25?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value25;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T25? value)
        {
            Value25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue25(T25? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T26 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T26?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T26?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value26;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T26? value)
        {
            Value26 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue26(T26? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T27 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T27?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T27?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value27;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T27? value)
        {
            Value27 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue27(T27? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T28 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T28?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T28?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value28;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T28? value)
        {
            Value28 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue28(T28? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T29 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T29?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T29?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value29;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T29? value)
        {
            Value29 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue29(T29? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T30 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T30?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T30?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value30;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T30? value)
        {
            Value30 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue30(T30? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T31 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T31?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T31?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value31;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T31? value)
        {
            Value31 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue31(T31? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T32 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T32?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T32?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value32;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T32? value)
        {
            Value32 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue32(T32? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T33 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T33?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T33?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value33;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T33? value)
        {
            Value33 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue33(T33? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T34 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T34?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T34?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value34;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T34? value)
        {
            Value34 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue34(T34? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T35 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T35?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T35?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value35;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T35? value)
        {
            Value35 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue35(T35? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T36 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T36?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T36?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value36;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T36? value)
        {
            Value36 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue36(T36? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T37 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T37?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T37?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value37;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T37? value)
        {
            Value37 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue37(T37? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T38 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T38?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T38?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value38;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T38? value)
        {
            Value38 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue38(T38? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T39 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T39?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T39?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value39;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T39? value)
        {
            Value39 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue39(T39? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T40 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T40?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T40?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value40;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T40? value)
        {
            Value40 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue40(T40? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T41 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T41?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T41?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value41;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T41? value)
        {
            Value41 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue41(T41? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T42 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T42?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T42?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value42;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T42? value)
        {
            Value42 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue42(T42? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T43 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T43?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T43?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value43;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T43? value)
        {
            Value43 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue43(T43? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T44 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T44?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T44?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value44;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T44? value)
        {
            Value44 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue44(T44? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T45 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T45?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T45?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value45;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T45? value)
        {
            Value45 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue45(T45? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T46 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T46?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T46?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value46;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T46? value)
        {
            Value46 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue46(T46? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T47 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T47?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T47?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value47;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T47? value)
        {
            Value47 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue47(T47? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T48 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T48?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T48?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value48;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T48? value)
        {
            Value48 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue48(T48? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T49 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T49?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T49?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value49;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T49? value)
        {
            Value49 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue49(T49? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T50 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T50?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T50?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value50;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T50? value)
        {
            Value50 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue50(T50? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T51 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T51?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T51?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value51;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T51? value)
        {
            Value51 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue51(T51? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T52 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T52?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T52?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value52;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T52? value)
        {
            Value52 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue52(T52? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T53 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T53?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T53?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value53;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T53? value)
        {
            Value53 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue53(T53? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T54 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T54?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T54?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value54;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T54? value)
        {
            Value54 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue54(T54? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T55 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T55?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T55?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value55;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T55? value)
        {
            Value55 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue55(T55? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T56 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T56?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T56?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value56;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T56? value)
        {
            Value56 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue56(T56? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T57 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T57?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T57?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value57;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T57? value)
        {
            Value57 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue57(T57? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T58 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>((T58?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator T58?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> @this) => @this.Value58;

        /// <summary>
        ///
        /// </summary>
        public AnyOf(T58? value)
        {
            Value58 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> FromValue58(T58? value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(value);

        /// <summary>
        ///
        /// </summary>
        public AnyOf(
            T1? value1,
            T2? value2,
            T3? value3,
            T4? value4,
            T5? value5,
            T6? value6,
            T7? value7,
            T8? value8,
            T9? value9,
            T10? value10,
            T11? value11,
            T12? value12,
            T13? value13,
            T14? value14,
            T15? value15,
            T16? value16,
            T17? value17,
            T18? value18,
            T19? value19,
            T20? value20,
            T21? value21,
            T22? value22,
            T23? value23,
            T24? value24,
            T25? value25,
            T26? value26,
            T27? value27,
            T28? value28,
            T29? value29,
            T30? value30,
            T31? value31,
            T32? value32,
            T33? value33,
            T34? value34,
            T35? value35,
            T36? value36,
            T37? value37,
            T38? value38,
            T39? value39,
            T40? value40,
            T41? value41,
            T42? value42,
            T43? value43,
            T44? value44,
            T45? value45,
            T46? value46,
            T47? value47,
            T48? value48,
            T49? value49,
            T50? value50,
            T51? value51,
            T52? value52,
            T53? value53,
            T54? value54,
            T55? value55,
            T56? value56,
            T57? value57,
            T58? value58
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
            Value17 = value17;
            Value18 = value18;
            Value19 = value19;
            Value20 = value20;
            Value21 = value21;
            Value22 = value22;
            Value23 = value23;
            Value24 = value24;
            Value25 = value25;
            Value26 = value26;
            Value27 = value27;
            Value28 = value28;
            Value29 = value29;
            Value30 = value30;
            Value31 = value31;
            Value32 = value32;
            Value33 = value33;
            Value34 = value34;
            Value35 = value35;
            Value36 = value36;
            Value37 = value37;
            Value38 = value38;
            Value39 = value39;
            Value40 = value40;
            Value41 = value41;
            Value42 = value42;
            Value43 = value43;
            Value44 = value44;
            Value45 = value45;
            Value46 = value46;
            Value47 = value47;
            Value48 = value48;
            Value49 = value49;
            Value50 = value50;
            Value51 = value51;
            Value52 = value52;
            Value53 = value53;
            Value54 = value54;
            Value55 = value55;
            Value56 = value56;
            Value57 = value57;
            Value58 = value58;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Value58 as object ??
            Value57 as object ??
            Value56 as object ??
            Value55 as object ??
            Value54 as object ??
            Value53 as object ??
            Value52 as object ??
            Value51 as object ??
            Value50 as object ??
            Value49 as object ??
            Value48 as object ??
            Value47 as object ??
            Value46 as object ??
            Value45 as object ??
            Value44 as object ??
            Value43 as object ??
            Value42 as object ??
            Value41 as object ??
            Value40 as object ??
            Value39 as object ??
            Value38 as object ??
            Value37 as object ??
            Value36 as object ??
            Value35 as object ??
            Value34 as object ??
            Value33 as object ??
            Value32 as object ??
            Value31 as object ??
            Value30 as object ??
            Value29 as object ??
            Value28 as object ??
            Value27 as object ??
            Value26 as object ??
            Value25 as object ??
            Value24 as object ??
            Value23 as object ??
            Value22 as object ??
            Value21 as object ??
            Value20 as object ??
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
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
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() ??
            Value14?.ToString() ??
            Value15?.ToString() ??
            Value16?.ToString() ??
            Value17?.ToString() ??
            Value18?.ToString() ??
            Value19?.ToString() ??
            Value20?.ToString() ??
            Value21?.ToString() ??
            Value22?.ToString() ??
            Value23?.ToString() ??
            Value24?.ToString() ??
            Value25?.ToString() ??
            Value26?.ToString() ??
            Value27?.ToString() ??
            Value28?.ToString() ??
            Value29?.ToString() ??
            Value30?.ToString() ??
            Value31?.ToString() ??
            Value32?.ToString() ??
            Value33?.ToString() ??
            Value34?.ToString() ??
            Value35?.ToString() ??
            Value36?.ToString() ??
            Value37?.ToString() ??
            Value38?.ToString() ??
            Value39?.ToString() ??
            Value40?.ToString() ??
            Value41?.ToString() ??
            Value42?.ToString() ??
            Value43?.ToString() ??
            Value44?.ToString() ??
            Value45?.ToString() ??
            Value46?.ToString() ??
            Value47?.ToString() ??
            Value48?.ToString() ??
            Value49?.ToString() ??
            Value50?.ToString() ??
            Value51?.ToString() ??
            Value52?.ToString() ??
            Value53?.ToString() ??
            Value54?.ToString() ??
            Value55?.ToString() ??
            Value56?.ToString() ??
            Value57?.ToString() ??
            Value58?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13 || IsValue14 || IsValue15 || IsValue16 || IsValue17 || IsValue18 || IsValue19 || IsValue20 || IsValue21 || IsValue22 || IsValue23 || IsValue24 || IsValue25 || IsValue26 || IsValue27 || IsValue28 || IsValue29 || IsValue30 || IsValue31 || IsValue32 || IsValue33 || IsValue34 || IsValue35 || IsValue36 || IsValue37 || IsValue38 || IsValue39 || IsValue40 || IsValue41 || IsValue42 || IsValue43 || IsValue44 || IsValue45 || IsValue46 || IsValue47 || IsValue48 || IsValue49 || IsValue50 || IsValue51 || IsValue52 || IsValue53 || IsValue54 || IsValue55 || IsValue56 || IsValue57 || IsValue58;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<T1, TResult>? value1 = null,
            global::System.Func<T2, TResult>? value2 = null,
            global::System.Func<T3, TResult>? value3 = null,
            global::System.Func<T4, TResult>? value4 = null,
            global::System.Func<T5, TResult>? value5 = null,
            global::System.Func<T6, TResult>? value6 = null,
            global::System.Func<T7, TResult>? value7 = null,
            global::System.Func<T8, TResult>? value8 = null,
            global::System.Func<T9, TResult>? value9 = null,
            global::System.Func<T10, TResult>? value10 = null,
            global::System.Func<T11, TResult>? value11 = null,
            global::System.Func<T12, TResult>? value12 = null,
            global::System.Func<T13, TResult>? value13 = null,
            global::System.Func<T14, TResult>? value14 = null,
            global::System.Func<T15, TResult>? value15 = null,
            global::System.Func<T16, TResult>? value16 = null,
            global::System.Func<T17, TResult>? value17 = null,
            global::System.Func<T18, TResult>? value18 = null,
            global::System.Func<T19, TResult>? value19 = null,
            global::System.Func<T20, TResult>? value20 = null,
            global::System.Func<T21, TResult>? value21 = null,
            global::System.Func<T22, TResult>? value22 = null,
            global::System.Func<T23, TResult>? value23 = null,
            global::System.Func<T24, TResult>? value24 = null,
            global::System.Func<T25, TResult>? value25 = null,
            global::System.Func<T26, TResult>? value26 = null,
            global::System.Func<T27, TResult>? value27 = null,
            global::System.Func<T28, TResult>? value28 = null,
            global::System.Func<T29, TResult>? value29 = null,
            global::System.Func<T30, TResult>? value30 = null,
            global::System.Func<T31, TResult>? value31 = null,
            global::System.Func<T32, TResult>? value32 = null,
            global::System.Func<T33, TResult>? value33 = null,
            global::System.Func<T34, TResult>? value34 = null,
            global::System.Func<T35, TResult>? value35 = null,
            global::System.Func<T36, TResult>? value36 = null,
            global::System.Func<T37, TResult>? value37 = null,
            global::System.Func<T38, TResult>? value38 = null,
            global::System.Func<T39, TResult>? value39 = null,
            global::System.Func<T40, TResult>? value40 = null,
            global::System.Func<T41, TResult>? value41 = null,
            global::System.Func<T42, TResult>? value42 = null,
            global::System.Func<T43, TResult>? value43 = null,
            global::System.Func<T44, TResult>? value44 = null,
            global::System.Func<T45, TResult>? value45 = null,
            global::System.Func<T46, TResult>? value46 = null,
            global::System.Func<T47, TResult>? value47 = null,
            global::System.Func<T48, TResult>? value48 = null,
            global::System.Func<T49, TResult>? value49 = null,
            global::System.Func<T50, TResult>? value50 = null,
            global::System.Func<T51, TResult>? value51 = null,
            global::System.Func<T52, TResult>? value52 = null,
            global::System.Func<T53, TResult>? value53 = null,
            global::System.Func<T54, TResult>? value54 = null,
            global::System.Func<T55, TResult>? value55 = null,
            global::System.Func<T56, TResult>? value56 = null,
            global::System.Func<T57, TResult>? value57 = null,
            global::System.Func<T58, TResult>? value58 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }
            else if (IsValue20 && value20 != null)
            {
                return value20(Value20!);
            }
            else if (IsValue21 && value21 != null)
            {
                return value21(Value21!);
            }
            else if (IsValue22 && value22 != null)
            {
                return value22(Value22!);
            }
            else if (IsValue23 && value23 != null)
            {
                return value23(Value23!);
            }
            else if (IsValue24 && value24 != null)
            {
                return value24(Value24!);
            }
            else if (IsValue25 && value25 != null)
            {
                return value25(Value25!);
            }
            else if (IsValue26 && value26 != null)
            {
                return value26(Value26!);
            }
            else if (IsValue27 && value27 != null)
            {
                return value27(Value27!);
            }
            else if (IsValue28 && value28 != null)
            {
                return value28(Value28!);
            }
            else if (IsValue29 && value29 != null)
            {
                return value29(Value29!);
            }
            else if (IsValue30 && value30 != null)
            {
                return value30(Value30!);
            }
            else if (IsValue31 && value31 != null)
            {
                return value31(Value31!);
            }
            else if (IsValue32 && value32 != null)
            {
                return value32(Value32!);
            }
            else if (IsValue33 && value33 != null)
            {
                return value33(Value33!);
            }
            else if (IsValue34 && value34 != null)
            {
                return value34(Value34!);
            }
            else if (IsValue35 && value35 != null)
            {
                return value35(Value35!);
            }
            else if (IsValue36 && value36 != null)
            {
                return value36(Value36!);
            }
            else if (IsValue37 && value37 != null)
            {
                return value37(Value37!);
            }
            else if (IsValue38 && value38 != null)
            {
                return value38(Value38!);
            }
            else if (IsValue39 && value39 != null)
            {
                return value39(Value39!);
            }
            else if (IsValue40 && value40 != null)
            {
                return value40(Value40!);
            }
            else if (IsValue41 && value41 != null)
            {
                return value41(Value41!);
            }
            else if (IsValue42 && value42 != null)
            {
                return value42(Value42!);
            }
            else if (IsValue43 && value43 != null)
            {
                return value43(Value43!);
            }
            else if (IsValue44 && value44 != null)
            {
                return value44(Value44!);
            }
            else if (IsValue45 && value45 != null)
            {
                return value45(Value45!);
            }
            else if (IsValue46 && value46 != null)
            {
                return value46(Value46!);
            }
            else if (IsValue47 && value47 != null)
            {
                return value47(Value47!);
            }
            else if (IsValue48 && value48 != null)
            {
                return value48(Value48!);
            }
            else if (IsValue49 && value49 != null)
            {
                return value49(Value49!);
            }
            else if (IsValue50 && value50 != null)
            {
                return value50(Value50!);
            }
            else if (IsValue51 && value51 != null)
            {
                return value51(Value51!);
            }
            else if (IsValue52 && value52 != null)
            {
                return value52(Value52!);
            }
            else if (IsValue53 && value53 != null)
            {
                return value53(Value53!);
            }
            else if (IsValue54 && value54 != null)
            {
                return value54(Value54!);
            }
            else if (IsValue55 && value55 != null)
            {
                return value55(Value55!);
            }
            else if (IsValue56 && value56 != null)
            {
                return value56(Value56!);
            }
            else if (IsValue57 && value57 != null)
            {
                return value57(Value57!);
            }
            else if (IsValue58 && value58 != null)
            {
                return value58(Value58!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<T1>? value1 = null,

            global::System.Action<T2>? value2 = null,

            global::System.Action<T3>? value3 = null,

            global::System.Action<T4>? value4 = null,

            global::System.Action<T5>? value5 = null,

            global::System.Action<T6>? value6 = null,

            global::System.Action<T7>? value7 = null,

            global::System.Action<T8>? value8 = null,

            global::System.Action<T9>? value9 = null,

            global::System.Action<T10>? value10 = null,

            global::System.Action<T11>? value11 = null,

            global::System.Action<T12>? value12 = null,

            global::System.Action<T13>? value13 = null,

            global::System.Action<T14>? value14 = null,

            global::System.Action<T15>? value15 = null,

            global::System.Action<T16>? value16 = null,

            global::System.Action<T17>? value17 = null,

            global::System.Action<T18>? value18 = null,

            global::System.Action<T19>? value19 = null,

            global::System.Action<T20>? value20 = null,

            global::System.Action<T21>? value21 = null,

            global::System.Action<T22>? value22 = null,

            global::System.Action<T23>? value23 = null,

            global::System.Action<T24>? value24 = null,

            global::System.Action<T25>? value25 = null,

            global::System.Action<T26>? value26 = null,

            global::System.Action<T27>? value27 = null,

            global::System.Action<T28>? value28 = null,

            global::System.Action<T29>? value29 = null,

            global::System.Action<T30>? value30 = null,

            global::System.Action<T31>? value31 = null,

            global::System.Action<T32>? value32 = null,

            global::System.Action<T33>? value33 = null,

            global::System.Action<T34>? value34 = null,

            global::System.Action<T35>? value35 = null,

            global::System.Action<T36>? value36 = null,

            global::System.Action<T37>? value37 = null,

            global::System.Action<T38>? value38 = null,

            global::System.Action<T39>? value39 = null,

            global::System.Action<T40>? value40 = null,

            global::System.Action<T41>? value41 = null,

            global::System.Action<T42>? value42 = null,

            global::System.Action<T43>? value43 = null,

            global::System.Action<T44>? value44 = null,

            global::System.Action<T45>? value45 = null,

            global::System.Action<T46>? value46 = null,

            global::System.Action<T47>? value47 = null,

            global::System.Action<T48>? value48 = null,

            global::System.Action<T49>? value49 = null,

            global::System.Action<T50>? value50 = null,

            global::System.Action<T51>? value51 = null,

            global::System.Action<T52>? value52 = null,

            global::System.Action<T53>? value53 = null,

            global::System.Action<T54>? value54 = null,

            global::System.Action<T55>? value55 = null,

            global::System.Action<T56>? value56 = null,

            global::System.Action<T57>? value57 = null,

            global::System.Action<T58>? value58 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
            else if (IsValue20)
            {
                value20?.Invoke(Value20!);
            }
            else if (IsValue21)
            {
                value21?.Invoke(Value21!);
            }
            else if (IsValue22)
            {
                value22?.Invoke(Value22!);
            }
            else if (IsValue23)
            {
                value23?.Invoke(Value23!);
            }
            else if (IsValue24)
            {
                value24?.Invoke(Value24!);
            }
            else if (IsValue25)
            {
                value25?.Invoke(Value25!);
            }
            else if (IsValue26)
            {
                value26?.Invoke(Value26!);
            }
            else if (IsValue27)
            {
                value27?.Invoke(Value27!);
            }
            else if (IsValue28)
            {
                value28?.Invoke(Value28!);
            }
            else if (IsValue29)
            {
                value29?.Invoke(Value29!);
            }
            else if (IsValue30)
            {
                value30?.Invoke(Value30!);
            }
            else if (IsValue31)
            {
                value31?.Invoke(Value31!);
            }
            else if (IsValue32)
            {
                value32?.Invoke(Value32!);
            }
            else if (IsValue33)
            {
                value33?.Invoke(Value33!);
            }
            else if (IsValue34)
            {
                value34?.Invoke(Value34!);
            }
            else if (IsValue35)
            {
                value35?.Invoke(Value35!);
            }
            else if (IsValue36)
            {
                value36?.Invoke(Value36!);
            }
            else if (IsValue37)
            {
                value37?.Invoke(Value37!);
            }
            else if (IsValue38)
            {
                value38?.Invoke(Value38!);
            }
            else if (IsValue39)
            {
                value39?.Invoke(Value39!);
            }
            else if (IsValue40)
            {
                value40?.Invoke(Value40!);
            }
            else if (IsValue41)
            {
                value41?.Invoke(Value41!);
            }
            else if (IsValue42)
            {
                value42?.Invoke(Value42!);
            }
            else if (IsValue43)
            {
                value43?.Invoke(Value43!);
            }
            else if (IsValue44)
            {
                value44?.Invoke(Value44!);
            }
            else if (IsValue45)
            {
                value45?.Invoke(Value45!);
            }
            else if (IsValue46)
            {
                value46?.Invoke(Value46!);
            }
            else if (IsValue47)
            {
                value47?.Invoke(Value47!);
            }
            else if (IsValue48)
            {
                value48?.Invoke(Value48!);
            }
            else if (IsValue49)
            {
                value49?.Invoke(Value49!);
            }
            else if (IsValue50)
            {
                value50?.Invoke(Value50!);
            }
            else if (IsValue51)
            {
                value51?.Invoke(Value51!);
            }
            else if (IsValue52)
            {
                value52?.Invoke(Value52!);
            }
            else if (IsValue53)
            {
                value53?.Invoke(Value53!);
            }
            else if (IsValue54)
            {
                value54?.Invoke(Value54!);
            }
            else if (IsValue55)
            {
                value55?.Invoke(Value55!);
            }
            else if (IsValue56)
            {
                value56?.Invoke(Value56!);
            }
            else if (IsValue57)
            {
                value57?.Invoke(Value57!);
            }
            else if (IsValue58)
            {
                value58?.Invoke(Value58!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<T1>? value1 = null,
            global::System.Action<T2>? value2 = null,
            global::System.Action<T3>? value3 = null,
            global::System.Action<T4>? value4 = null,
            global::System.Action<T5>? value5 = null,
            global::System.Action<T6>? value6 = null,
            global::System.Action<T7>? value7 = null,
            global::System.Action<T8>? value8 = null,
            global::System.Action<T9>? value9 = null,
            global::System.Action<T10>? value10 = null,
            global::System.Action<T11>? value11 = null,
            global::System.Action<T12>? value12 = null,
            global::System.Action<T13>? value13 = null,
            global::System.Action<T14>? value14 = null,
            global::System.Action<T15>? value15 = null,
            global::System.Action<T16>? value16 = null,
            global::System.Action<T17>? value17 = null,
            global::System.Action<T18>? value18 = null,
            global::System.Action<T19>? value19 = null,
            global::System.Action<T20>? value20 = null,
            global::System.Action<T21>? value21 = null,
            global::System.Action<T22>? value22 = null,
            global::System.Action<T23>? value23 = null,
            global::System.Action<T24>? value24 = null,
            global::System.Action<T25>? value25 = null,
            global::System.Action<T26>? value26 = null,
            global::System.Action<T27>? value27 = null,
            global::System.Action<T28>? value28 = null,
            global::System.Action<T29>? value29 = null,
            global::System.Action<T30>? value30 = null,
            global::System.Action<T31>? value31 = null,
            global::System.Action<T32>? value32 = null,
            global::System.Action<T33>? value33 = null,
            global::System.Action<T34>? value34 = null,
            global::System.Action<T35>? value35 = null,
            global::System.Action<T36>? value36 = null,
            global::System.Action<T37>? value37 = null,
            global::System.Action<T38>? value38 = null,
            global::System.Action<T39>? value39 = null,
            global::System.Action<T40>? value40 = null,
            global::System.Action<T41>? value41 = null,
            global::System.Action<T42>? value42 = null,
            global::System.Action<T43>? value43 = null,
            global::System.Action<T44>? value44 = null,
            global::System.Action<T45>? value45 = null,
            global::System.Action<T46>? value46 = null,
            global::System.Action<T47>? value47 = null,
            global::System.Action<T48>? value48 = null,
            global::System.Action<T49>? value49 = null,
            global::System.Action<T50>? value50 = null,
            global::System.Action<T51>? value51 = null,
            global::System.Action<T52>? value52 = null,
            global::System.Action<T53>? value53 = null,
            global::System.Action<T54>? value54 = null,
            global::System.Action<T55>? value55 = null,
            global::System.Action<T56>? value56 = null,
            global::System.Action<T57>? value57 = null,
            global::System.Action<T58>? value58 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
            else if (IsValue20)
            {
                value20?.Invoke(Value20!);
            }
            else if (IsValue21)
            {
                value21?.Invoke(Value21!);
            }
            else if (IsValue22)
            {
                value22?.Invoke(Value22!);
            }
            else if (IsValue23)
            {
                value23?.Invoke(Value23!);
            }
            else if (IsValue24)
            {
                value24?.Invoke(Value24!);
            }
            else if (IsValue25)
            {
                value25?.Invoke(Value25!);
            }
            else if (IsValue26)
            {
                value26?.Invoke(Value26!);
            }
            else if (IsValue27)
            {
                value27?.Invoke(Value27!);
            }
            else if (IsValue28)
            {
                value28?.Invoke(Value28!);
            }
            else if (IsValue29)
            {
                value29?.Invoke(Value29!);
            }
            else if (IsValue30)
            {
                value30?.Invoke(Value30!);
            }
            else if (IsValue31)
            {
                value31?.Invoke(Value31!);
            }
            else if (IsValue32)
            {
                value32?.Invoke(Value32!);
            }
            else if (IsValue33)
            {
                value33?.Invoke(Value33!);
            }
            else if (IsValue34)
            {
                value34?.Invoke(Value34!);
            }
            else if (IsValue35)
            {
                value35?.Invoke(Value35!);
            }
            else if (IsValue36)
            {
                value36?.Invoke(Value36!);
            }
            else if (IsValue37)
            {
                value37?.Invoke(Value37!);
            }
            else if (IsValue38)
            {
                value38?.Invoke(Value38!);
            }
            else if (IsValue39)
            {
                value39?.Invoke(Value39!);
            }
            else if (IsValue40)
            {
                value40?.Invoke(Value40!);
            }
            else if (IsValue41)
            {
                value41?.Invoke(Value41!);
            }
            else if (IsValue42)
            {
                value42?.Invoke(Value42!);
            }
            else if (IsValue43)
            {
                value43?.Invoke(Value43!);
            }
            else if (IsValue44)
            {
                value44?.Invoke(Value44!);
            }
            else if (IsValue45)
            {
                value45?.Invoke(Value45!);
            }
            else if (IsValue46)
            {
                value46?.Invoke(Value46!);
            }
            else if (IsValue47)
            {
                value47?.Invoke(Value47!);
            }
            else if (IsValue48)
            {
                value48?.Invoke(Value48!);
            }
            else if (IsValue49)
            {
                value49?.Invoke(Value49!);
            }
            else if (IsValue50)
            {
                value50?.Invoke(Value50!);
            }
            else if (IsValue51)
            {
                value51?.Invoke(Value51!);
            }
            else if (IsValue52)
            {
                value52?.Invoke(Value52!);
            }
            else if (IsValue53)
            {
                value53?.Invoke(Value53!);
            }
            else if (IsValue54)
            {
                value54?.Invoke(Value54!);
            }
            else if (IsValue55)
            {
                value55?.Invoke(Value55!);
            }
            else if (IsValue56)
            {
                value56?.Invoke(Value56!);
            }
            else if (IsValue57)
            {
                value57?.Invoke(Value57!);
            }
            else if (IsValue58)
            {
                value58?.Invoke(Value58!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(T1),
                Value2,
                typeof(T2),
                Value3,
                typeof(T3),
                Value4,
                typeof(T4),
                Value5,
                typeof(T5),
                Value6,
                typeof(T6),
                Value7,
                typeof(T7),
                Value8,
                typeof(T8),
                Value9,
                typeof(T9),
                Value10,
                typeof(T10),
                Value11,
                typeof(T11),
                Value12,
                typeof(T12),
                Value13,
                typeof(T13),
                Value14,
                typeof(T14),
                Value15,
                typeof(T15),
                Value16,
                typeof(T16),
                Value17,
                typeof(T17),
                Value18,
                typeof(T18),
                Value19,
                typeof(T19),
                Value20,
                typeof(T20),
                Value21,
                typeof(T21),
                Value22,
                typeof(T22),
                Value23,
                typeof(T23),
                Value24,
                typeof(T24),
                Value25,
                typeof(T25),
                Value26,
                typeof(T26),
                Value27,
                typeof(T27),
                Value28,
                typeof(T28),
                Value29,
                typeof(T29),
                Value30,
                typeof(T30),
                Value31,
                typeof(T31),
                Value32,
                typeof(T32),
                Value33,
                typeof(T33),
                Value34,
                typeof(T34),
                Value35,
                typeof(T35),
                Value36,
                typeof(T36),
                Value37,
                typeof(T37),
                Value38,
                typeof(T38),
                Value39,
                typeof(T39),
                Value40,
                typeof(T40),
                Value41,
                typeof(T41),
                Value42,
                typeof(T42),
                Value43,
                typeof(T43),
                Value44,
                typeof(T44),
                Value45,
                typeof(T45),
                Value46,
                typeof(T46),
                Value47,
                typeof(T47),
                Value48,
                typeof(T48),
                Value49,
                typeof(T49),
                Value50,
                typeof(T50),
                Value51,
                typeof(T51),
                Value52,
                typeof(T52),
                Value53,
                typeof(T53),
                Value54,
                typeof(T54),
                Value55,
                typeof(T55),
                Value56,
                typeof(T56),
                Value57,
                typeof(T57),
                Value58,
                typeof(T58),
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
        public bool Equals(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<T3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<T4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<T5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<T6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<T7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<T8?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<T9?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<T10?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<T11?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<T12?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<T13?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<T14?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<T15?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<T16?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<T17?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<T18?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<T19?>.Default.Equals(Value19, other.Value19) &&
                global::System.Collections.Generic.EqualityComparer<T20?>.Default.Equals(Value20, other.Value20) &&
                global::System.Collections.Generic.EqualityComparer<T21?>.Default.Equals(Value21, other.Value21) &&
                global::System.Collections.Generic.EqualityComparer<T22?>.Default.Equals(Value22, other.Value22) &&
                global::System.Collections.Generic.EqualityComparer<T23?>.Default.Equals(Value23, other.Value23) &&
                global::System.Collections.Generic.EqualityComparer<T24?>.Default.Equals(Value24, other.Value24) &&
                global::System.Collections.Generic.EqualityComparer<T25?>.Default.Equals(Value25, other.Value25) &&
                global::System.Collections.Generic.EqualityComparer<T26?>.Default.Equals(Value26, other.Value26) &&
                global::System.Collections.Generic.EqualityComparer<T27?>.Default.Equals(Value27, other.Value27) &&
                global::System.Collections.Generic.EqualityComparer<T28?>.Default.Equals(Value28, other.Value28) &&
                global::System.Collections.Generic.EqualityComparer<T29?>.Default.Equals(Value29, other.Value29) &&
                global::System.Collections.Generic.EqualityComparer<T30?>.Default.Equals(Value30, other.Value30) &&
                global::System.Collections.Generic.EqualityComparer<T31?>.Default.Equals(Value31, other.Value31) &&
                global::System.Collections.Generic.EqualityComparer<T32?>.Default.Equals(Value32, other.Value32) &&
                global::System.Collections.Generic.EqualityComparer<T33?>.Default.Equals(Value33, other.Value33) &&
                global::System.Collections.Generic.EqualityComparer<T34?>.Default.Equals(Value34, other.Value34) &&
                global::System.Collections.Generic.EqualityComparer<T35?>.Default.Equals(Value35, other.Value35) &&
                global::System.Collections.Generic.EqualityComparer<T36?>.Default.Equals(Value36, other.Value36) &&
                global::System.Collections.Generic.EqualityComparer<T37?>.Default.Equals(Value37, other.Value37) &&
                global::System.Collections.Generic.EqualityComparer<T38?>.Default.Equals(Value38, other.Value38) &&
                global::System.Collections.Generic.EqualityComparer<T39?>.Default.Equals(Value39, other.Value39) &&
                global::System.Collections.Generic.EqualityComparer<T40?>.Default.Equals(Value40, other.Value40) &&
                global::System.Collections.Generic.EqualityComparer<T41?>.Default.Equals(Value41, other.Value41) &&
                global::System.Collections.Generic.EqualityComparer<T42?>.Default.Equals(Value42, other.Value42) &&
                global::System.Collections.Generic.EqualityComparer<T43?>.Default.Equals(Value43, other.Value43) &&
                global::System.Collections.Generic.EqualityComparer<T44?>.Default.Equals(Value44, other.Value44) &&
                global::System.Collections.Generic.EqualityComparer<T45?>.Default.Equals(Value45, other.Value45) &&
                global::System.Collections.Generic.EqualityComparer<T46?>.Default.Equals(Value46, other.Value46) &&
                global::System.Collections.Generic.EqualityComparer<T47?>.Default.Equals(Value47, other.Value47) &&
                global::System.Collections.Generic.EqualityComparer<T48?>.Default.Equals(Value48, other.Value48) &&
                global::System.Collections.Generic.EqualityComparer<T49?>.Default.Equals(Value49, other.Value49) &&
                global::System.Collections.Generic.EqualityComparer<T50?>.Default.Equals(Value50, other.Value50) &&
                global::System.Collections.Generic.EqualityComparer<T51?>.Default.Equals(Value51, other.Value51) &&
                global::System.Collections.Generic.EqualityComparer<T52?>.Default.Equals(Value52, other.Value52) &&
                global::System.Collections.Generic.EqualityComparer<T53?>.Default.Equals(Value53, other.Value53) &&
                global::System.Collections.Generic.EqualityComparer<T54?>.Default.Equals(Value54, other.Value54) &&
                global::System.Collections.Generic.EqualityComparer<T55?>.Default.Equals(Value55, other.Value55) &&
                global::System.Collections.Generic.EqualityComparer<T56?>.Default.Equals(Value56, other.Value56) &&
                global::System.Collections.Generic.EqualityComparer<T57?>.Default.Equals(Value57, other.Value57) &&
                global::System.Collections.Generic.EqualityComparer<T58?>.Default.Equals(Value58, other.Value58)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> obj1, AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> obj1, AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58> o && Equals(o);
        }
    }
}
