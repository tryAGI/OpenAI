
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifier for service connectors, like those available in ChatGPT. One of<br/>
    /// `server_url` or `connector_id` must be provided. Learn more about service<br/>
    /// connectors [here](https://platform.openai.com/docs/guides/tools-remote-mcp#connectors).<br/>
    /// Currently supported `connector_id` values are:<br/>
    /// - Dropbox: `connector_dropbox`<br/>
    /// - Gmail: `connector_gmail`<br/>
    /// - Google Calendar: `connector_googlecalendar`<br/>
    /// - Google Drive: `connector_googledrive`<br/>
    /// - Microsoft Teams: `connector_microsoftteams`<br/>
    /// - Outlook Calendar: `connector_outlookcalendar`<br/>
    /// - Outlook Email: `connector_outlookemail`<br/>
    /// - SharePoint: `connector_sharepoint`
    /// </summary>
    public enum MCPToolConnectorId
    {
        /// <summary>
        /// `connector_dropbox`
        /// </summary>
        ConnectorDropbox,
        /// <summary>
        /// `connector_gmail`
        /// </summary>
        ConnectorGmail,
        /// <summary>
        /// `connector_googlecalendar`
        /// </summary>
        ConnectorGooglecalendar,
        /// <summary>
        /// `connector_googledrive`
        /// </summary>
        ConnectorGoogledrive,
        /// <summary>
        /// `connector_microsoftteams`
        /// </summary>
        ConnectorMicrosoftteams,
        /// <summary>
        /// `connector_outlookcalendar`
        /// </summary>
        ConnectorOutlookcalendar,
        /// <summary>
        /// `connector_outlookemail`
        /// </summary>
        ConnectorOutlookemail,
        /// <summary>
        /// `connector_sharepoint`
        /// </summary>
        ConnectorSharepoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolConnectorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConnectorId value)
        {
            return value switch
            {
                MCPToolConnectorId.ConnectorDropbox => "connector_dropbox",
                MCPToolConnectorId.ConnectorGmail => "connector_gmail",
                MCPToolConnectorId.ConnectorGooglecalendar => "connector_googlecalendar",
                MCPToolConnectorId.ConnectorGoogledrive => "connector_googledrive",
                MCPToolConnectorId.ConnectorMicrosoftteams => "connector_microsoftteams",
                MCPToolConnectorId.ConnectorOutlookcalendar => "connector_outlookcalendar",
                MCPToolConnectorId.ConnectorOutlookemail => "connector_outlookemail",
                MCPToolConnectorId.ConnectorSharepoint => "connector_sharepoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConnectorId? ToEnum(string value)
        {
            return value switch
            {
                "connector_dropbox" => MCPToolConnectorId.ConnectorDropbox,
                "connector_gmail" => MCPToolConnectorId.ConnectorGmail,
                "connector_googlecalendar" => MCPToolConnectorId.ConnectorGooglecalendar,
                "connector_googledrive" => MCPToolConnectorId.ConnectorGoogledrive,
                "connector_microsoftteams" => MCPToolConnectorId.ConnectorMicrosoftteams,
                "connector_outlookcalendar" => MCPToolConnectorId.ConnectorOutlookcalendar,
                "connector_outlookemail" => MCPToolConnectorId.ConnectorOutlookemail,
                "connector_sharepoint" => MCPToolConnectorId.ConnectorSharepoint,
                _ => null,
            };
        }
    }
}