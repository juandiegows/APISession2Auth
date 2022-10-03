using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace APISession2Auth.Controllers
{
    public class AuthAPI : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;

            if (request.Headers.TryGetValues("tokenTowersGerencia", out IEnumerable<string> values))
            {
                if (values.Contains("fb29e141-7b39-46a0-a36d-e5ae3c828da9"))
                {
                    PutPrincipal(new GenericPrincipal(new GenericIdentity(values.First()), null));
                }

                return base.SendAsync(request, cancellationToken);

            }

            return Task.Factory.StartNew(() => new HttpResponseMessage(statusCode));
        }
        private void PutPrincipal(IPrincipal principal)

        {
            Thread.CurrentPrincipal = principal;
            if (HttpContext.Current != null)
                HttpContext.Current.User = principal;

        }
    }
}