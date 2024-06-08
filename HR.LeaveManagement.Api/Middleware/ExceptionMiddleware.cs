using HR.LeaveManagement.Api.Models;
using HR.LeaveManagement.Application.Exceptions;
using SendGrid.Helpers.Errors.Model;
using System.Net;

namespace HR.LeaveManagement.Api.Middleware {
    public class ExceptionMiddleware {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next) {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext) {
            try {
                await _next(httpContext);
            }
            catch (Exception ex) {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext, Exception ex) {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            CustomProblemDetail problem = new();

            switch (ex) {
                case Application.Exceptions.BadRequestException BadRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                    problem = new CustomProblemDetail {
                        Title = BadRequestException.Message, 
                        Status = (int) statusCode, 
                        Detail = BadRequestException.InnerException?.Message, 
                        Type = nameof(BadRequestException), 
                        Errors = BadRequestException.ValidationErrors 
                    };

                    break;
                case Application.Exceptions.NotFoundException NotFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    problem = new CustomProblemDetail {
                        Title = NotFoundException.Message,
                        Status = (int)statusCode,
                        Type = nameof(Application.Exceptions.NotFoundException),
                        Detail = NotFoundException.InnerException?.Message,
                    };
                    break;
                default:
                    problem = new CustomProblemDetail {
                        Title = ex.Message,
                        Status = (int)statusCode,
                        Type = nameof(HttpStatusCode.InternalServerError),
                        Detail = ex.StackTrace,
                    };
                    break;
            }

            httpContext.Response.StatusCode = (int)statusCode;
            await httpContext.Response.WriteAsJsonAsync(problem);
        }
    }
}
