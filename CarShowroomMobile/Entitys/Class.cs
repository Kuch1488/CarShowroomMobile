﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Class
    {
        public Class()
        {
            Models = new HashSet<Model>();
        }

        public int IdClass { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
