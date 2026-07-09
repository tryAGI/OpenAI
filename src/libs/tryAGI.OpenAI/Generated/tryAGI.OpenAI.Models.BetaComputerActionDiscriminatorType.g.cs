
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaComputerActionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Click,
        /// <summary>
        /// 
        /// </summary>
        DoubleClick,
        /// <summary>
        /// 
        /// </summary>
        Drag,
        /// <summary>
        /// 
        /// </summary>
        Keypress,
        /// <summary>
        /// 
        /// </summary>
        Move,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        Scroll,
        /// <summary>
        /// 
        /// </summary>
        Type,
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerActionDiscriminatorType value)
        {
            return value switch
            {
                BetaComputerActionDiscriminatorType.Click => "click",
                BetaComputerActionDiscriminatorType.DoubleClick => "double_click",
                BetaComputerActionDiscriminatorType.Drag => "drag",
                BetaComputerActionDiscriminatorType.Keypress => "keypress",
                BetaComputerActionDiscriminatorType.Move => "move",
                BetaComputerActionDiscriminatorType.Screenshot => "screenshot",
                BetaComputerActionDiscriminatorType.Scroll => "scroll",
                BetaComputerActionDiscriminatorType.Type => "type",
                BetaComputerActionDiscriminatorType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "click" => BetaComputerActionDiscriminatorType.Click,
                "double_click" => BetaComputerActionDiscriminatorType.DoubleClick,
                "drag" => BetaComputerActionDiscriminatorType.Drag,
                "keypress" => BetaComputerActionDiscriminatorType.Keypress,
                "move" => BetaComputerActionDiscriminatorType.Move,
                "screenshot" => BetaComputerActionDiscriminatorType.Screenshot,
                "scroll" => BetaComputerActionDiscriminatorType.Scroll,
                "type" => BetaComputerActionDiscriminatorType.Type,
                "wait" => BetaComputerActionDiscriminatorType.Wait,
                _ => null,
            };
        }
    }
}