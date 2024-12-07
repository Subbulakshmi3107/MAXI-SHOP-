using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.ApplicationConstants
{
    public class ApplicationConstants
    {
    }

    public class CommonMessage
    {
        public const string RegistrationSuccess = "Registration Success";
        public const string RegistrationFailed = "Registration Failed";

        public const string LoginSuccess = "Login Success";
        public const string LoginFailed = "Login Failed";
        public const string CreateOperationSuccess = "Record Created Successfully";
        public const string UpdateOperationSuccess = "Record Created Successfully";
        public const string DeleteOperationSuccess = "Record Created Successfully";

        public const string CreateOperationFailed = "Record Created Failed ";
        public const string UpdateOperationFailed = "Record Created Failed ";
        public const string DeleteOperationFailed = "Record Created Failed ";

        public const string RecordNotFound  = "Record Not Found";
        public const string SystemError = "Something went wrong";
    }
}
