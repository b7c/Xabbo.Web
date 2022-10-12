﻿namespace Xabbo.Web;

// {"errors":[{"param":"id","msg":"user.invalid_id","value":"hr-679-42.hd-180-1.ch-3110-64-1408.lg-275-64.ha-1003-64.ea-1406.fa-1212"}]}

public class ErrorInfo
{
    [JsonPropertyName("param")]
    public string Parameter { get; set; } = string.Empty;

    [JsonPropertyName("msg")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;
}
