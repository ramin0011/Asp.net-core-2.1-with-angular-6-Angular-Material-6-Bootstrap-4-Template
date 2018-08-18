using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Template.ApiController
{
    public class BaseController : Controller
    {
        private readonly IMemoryCache _cache;

        public BaseController(IMemoryCache cache)
        {
            this._cache = cache;
        }


        protected bool GetCache<TItem>( object keyObj, out TItem value)
        {
            return _cache.TryGetValue(Newtonsoft.Json.JsonConvert.SerializeObject(keyObj), out value);
        }

        protected void SetCache<T>(object keyObj, T data, TimeSpan timeSpan=default(TimeSpan))
        {
            if (timeSpan == default(TimeSpan))
                timeSpan = TimeSpan.FromDays(1);
            this._cache.Set(Newtonsoft.Json.JsonConvert.SerializeObject(keyObj), data,timeSpan);
        }
    }
}
