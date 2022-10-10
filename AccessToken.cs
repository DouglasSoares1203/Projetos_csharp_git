using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_csharp_git
{
    public class AccessToken
    {
        public bool Authenticated { get; set; }
        public string Expiration { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}