using Microsoft.AspNetCore.Mvc;

namespace HR.LeaveManagement.Api.Models {
    public class CustomProblemDetail : ProblemDetails {

        public IDictionary<string, string[]> Errors {  get; set; }


    }
}
