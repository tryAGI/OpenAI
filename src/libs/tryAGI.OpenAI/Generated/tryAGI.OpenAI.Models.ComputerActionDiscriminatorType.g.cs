
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerActionDiscriminatorType
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
    public static class ComputerActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerActionDiscriminatorType value)
        {
            return value switch
            {
                ComputerActionDiscriminatorType.Click => "click",
                ComputerActionDiscriminatorType.DoubleClick => "double_click",
                ComputerActionDiscriminatorType.Drag => "drag",
                ComputerActionDiscriminatorType.Keypress => "keypress",
                ComputerActionDiscriminatorType.Move => "move",
                ComputerActionDiscriminatorType.Screenshot => "screenshot",
                ComputerActionDiscriminatorType.Scroll => "scroll",
                ComputerActionDiscriminatorType.Type => "type",
                ComputerActionDiscriminatorType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "click" => ComputerActionDiscriminatorType.Click,
                "double_click" => ComputerActionDiscriminatorType.DoubleClick,
                "drag" => ComputerActionDiscriminatorType.Drag,
                "keypress" => ComputerActionDiscriminatorType.Keypress,
                "move" => ComputerActionDiscriminatorType.Move,
                "screenshot" => ComputerActionDiscriminatorType.Screenshot,
                "scroll" => ComputerActionDiscriminatorType.Scroll,
                "type" => ComputerActionDiscriminatorType.Type,
                "wait" => ComputerActionDiscriminatorType.Wait,
                _ => null,
            };
        }
    }
}