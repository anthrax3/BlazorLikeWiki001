using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorLikeWiki001.Shared
{
    public class ControlTemplate
    {
        public enum ControlType
        {
            Input,
            P,
            Table
        }

        public ControlType Type { get; set; }

        public Dictionary<string, string> Values { get; set; } = new Dictionary<string, string>();
    }
}
