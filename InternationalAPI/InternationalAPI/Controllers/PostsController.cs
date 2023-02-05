﻿using InternationalAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace InternationalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IStringLocalizer<PostsController> _stringLocalizer;
        private readonly IStringLocalizer<SharedResource> _sharedResourceLocalizer;
    
        public PostsController(IStringLocalizer<PostsController> stringLocalizer, IStringLocalizer<SharedResource> sharedResourceLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _sharedResourceLocalizer = sharedResourceLocalizer;
        }
        [HttpGet]
        [Route("PostControllerResource")]
        public IActionResult GetUsingControllerResource() {
            var article = _stringLocalizer["Article"];
            var postName = _stringLocalizer.GetString("Welcome").Value ?? String.Empty;
            return Ok(new
            {
                Postype= article.Value, 
                PostName=postName,
            });
        }
        [HttpGet]
        [Route("SharedResource")]
        public IActionResult GetUsingSharedResource()
        {
            var article = _stringLocalizer["Article"];
            var postName = _stringLocalizer.GetString("Welcome").Value ?? String.Empty;
            var todayIs= string.Format(_sharedResourceLocalizer.GetString("TodayIs"),DateTime.Now.ToLongDateString());
            return Ok(new
            {
                Postype = article.Value,
                PostName = postName,
                TodayIs=todayIs,
            });
        }
    }
}
