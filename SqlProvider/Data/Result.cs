using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProvider.Data
{
    public class Result:BaseResult
    {
        public Result Success()
        {
            Result result = new Result();
            result.Status = 1;
            result.Message = "Request Is Added";

            return result;
        }
        public Result Duplicate()
        {
            Result result = new Result();
            result.Status = 2;
            result.Message = "MobileNumber was added before";

            return result;
        }
        public Result Failed()
        {
            Result result = new Result();
            result.Status = 3;
            result.Message = "Faild";

            return result;
        }
    }
}
