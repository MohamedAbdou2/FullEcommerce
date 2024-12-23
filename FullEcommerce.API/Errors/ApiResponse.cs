namespace FullEcommerce.API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ApiResponse(int statuscode, string message = null)
        {
            StatusCode = statuscode;
            Message = message ?? GetDefaultMessageForStatusCode(statuscode);
        }

        public string GetDefaultMessageForStatusCode(int statuscode)
        {
            return statuscode switch
            {
                400 => "Bad Request , You made",
                401 => "Not Authorized",
                404 => "Not Found",
                500 => "Internal Server Error",
                _ => null
            };
        }

    }
}
