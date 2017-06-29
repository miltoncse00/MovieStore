using System;
using System.Web.Http;

namespace MoveStore.WebApi.Controllers
{
    public class BaseController : ApiController
    {
        public void ValidateApiVersionAndState(int version)
        {
            if (!ModelState.IsValid)
                throw new ArgumentException("ModelState is not valid");
            if (version != 1)
            {
                throw new BusinessException($"The API version {version} is not longer supported")
            }

        }
    }

    public class BusinessException : Exception
    {
        public BusinessException(string message)
        {
            throw new NotImplementedException();
        }
    }
}
