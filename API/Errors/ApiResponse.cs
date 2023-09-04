namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null){
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        public int StatusCode {get; set;}
        public string Message {get; set;}

        public string GetDefaultMessageForStatusCode(int statusCode){
            return statusCode switch {
                400 => "Sorry!!! You have made a bad request.",
                401 => "Hey, You are not authorized to access this data.",
                404 => "Sorry !!! Requested resource could not be found.",
                500 => "Just an error i guess. Go check yourself.",
                _ => null
            };
        }
    }
}