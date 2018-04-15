using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLikeWiki001.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorLikeWiki001.Server.Controllers
{
    [Route("api/[controller]")]
    public class TemplateController : Controller
    {
        [HttpPost("GetTemplateByName")]
        public async Task<WikiTemplate> GetTemplateByName([FromBody]string name)
        {
            var rt = new WikiTemplate();

            await Task.Delay(500);
            rt.Id = Guid.NewGuid();
            rt.Name = name;
            //ほんまはDBから取得してくるんやけど、まずは動きを作りたいので直にテンプレを作んねん
            {
                var item = new ControlTemplate { Type = ControlTemplate.ControlType.Input };
                item.Values.Add("Type", "textbox");
                item.Values.Add("Text", "てすと");
                rt.ControlList.Add(item);
            }
            {
                var item = new ControlTemplate { Type = ControlTemplate.ControlType.P };
                item.Values.Add("Text", "何か文章");
                rt.ControlList.Add(item);
            }
            {
                var item = new ControlTemplate { Type = ControlTemplate.ControlType.Table };
                item.Values.Add("ColmunCount", "3");
                item.Values.Add("RowCount", "5");
                rt.ControlList.Add(item);
            }

            return rt;
        }
    }
}