using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CurrentStatus {
    NotApplicable,
    Created,
    InProgress,
    Complete,
    Canceled
}