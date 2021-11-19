using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IIDentifiable
    {
        public string Model { get; set; }
        public string Id { get; set; }

        public Robot(string id)
        {
            Id = id;
        }
    }
}
