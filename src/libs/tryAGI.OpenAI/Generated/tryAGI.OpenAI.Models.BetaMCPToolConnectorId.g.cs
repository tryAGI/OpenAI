
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifier for service connectors, like those available in ChatGPT. One of<br/>
    /// `server_url`, `connector_id`, or `tunnel_id` must be provided. Learn more<br/>
    /// about service connectors [here](/docs/guides/tools-remote-mcp#connectors).<br/>
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
    public enum BetaMCPToolConnectorId
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
    public static class BetaMCPToolConnectorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPToolConnectorId value)
        {
            return value switch
            {
                BetaMCPToolConnectorId.ConnectorDropbox => "connector_dropbox",
                BetaMCPToolConnectorId.ConnectorGmail => "connector_gmail",
                BetaMCPToolConnectorId.ConnectorGooglecalendar => "connector_googlecalendar",
                BetaMCPToolConnectorId.ConnectorGoogledrive => "connector_googledrive",
                BetaMCPToolConnectorId.ConnectorMicrosoftteams => "connector_microsoftteams",
                BetaMCPToolConnectorId.ConnectorOutlookcalendar => "connector_outlookcalendar",
                BetaMCPToolConnectorId.ConnectorOutlookemail => "connector_outlookemail",
                BetaMCPToolConnectorId.ConnectorSharepoint => "connector_sharepoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPToolConnectorId? ToEnum(string value)
        {
            return value switch
            {
                "connector_dropbox" => BetaMCPToolConnectorId.ConnectorDropbox,
                "connector_gmail" => BetaMCPToolConnectorId.ConnectorGmail,
                "connector_googlecalendar" => BetaMCPToolConnectorId.ConnectorGooglecalendar,
                "connector_googledrive" => BetaMCPToolConnectorId.ConnectorGoogledrive,
                "connector_microsoftteams" => BetaMCPToolConnectorId.ConnectorMicrosoftteams,
                "connector_outlookcalendar" => BetaMCPToolConnectorId.ConnectorOutlookcalendar,
                "connector_outlookemail" => BetaMCPToolConnectorId.ConnectorOutlookemail,
                "connector_sharepoint" => BetaMCPToolConnectorId.ConnectorSharepoint,
                _ => null,
            };
        }
    }
}