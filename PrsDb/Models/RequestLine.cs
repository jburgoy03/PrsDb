﻿using System.Text.Json.Serialization;

namespace PrsDb.Models
{
    public class RequestLine
    {
        public int Id { get; set; } = 0;
        public int RequestId { get; set; }
        [JsonIgnore]
        public virtual Request? Request { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public virtual Product? Product { get; set; }
        public int Quantity { get; set; } = 1;

    }
}
