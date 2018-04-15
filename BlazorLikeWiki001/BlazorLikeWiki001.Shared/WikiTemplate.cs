using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorLikeWiki001.Shared
{
    public class WikiTemplate
    {
        /// <summary>
        /// テンプレートのID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ページ名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// コントロールのリスト
        /// </summary>
        public List<ControlTemplate> ControlList { get; set; } = new List<ControlTemplate>();
    }
}
