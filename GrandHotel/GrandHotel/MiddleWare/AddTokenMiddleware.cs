using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandHotel.MiddleWare
{
    public class AddTokenMiddleware
    {
        private readonly RequestDelegate _Next;
        public AddTokenMiddleware(RequestDelegate p_Next)
        {
            _Next = p_Next;
        }

        public async Task Invoke(HttpContext context /* other scoped dependencies */)
        {          
            try
            {
                string token = context.Session.GetString("token");
                if (string.IsNullOrEmpty(token) == false)
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + token);
                }
                
                await _Next(context);
            }
            catch (Exception ex)
            {
               
            }
        }
    }

}
