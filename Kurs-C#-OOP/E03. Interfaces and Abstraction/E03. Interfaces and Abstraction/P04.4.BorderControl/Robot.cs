using System;
using System.Collections.Generic;
using System.Text;

namespace P04._4.BorderControl
{
    public class Robot : IIdentifiable
    {
        private string model;
        public Robot(string model,string id)
        {
            this.model = model;
            this.Id = id;
        }
        public string Id {get; private set;}
    }
}
