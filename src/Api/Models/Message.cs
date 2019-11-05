namespace Api.Models
{
  using System.Collections.Generic;

  public sealed class Message
  {
    public string RoomId { get; set; }

    public string EventType { get; set; }

    public IDictionary<string, object> Payload { get; set;  }
  }
}