using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Service1
{
    public static class Class1
    {
        public static async Task<string> Test()
        {
            await Task.Delay(500);
            return JsonConvert.SerializeObject(new {Test = 100});
        }
    }
}
