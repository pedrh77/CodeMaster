namespace Masters.DOMAIN.ViewModel
{
    public class ErrorResponseVm
    {
        public ErrorDetailViewModel Error { get; set; }
        public ErrorResponseVm(string code, string message)
        {
            Error = new ErrorDetailViewModel
            {
                Code = code,
                Message = message
            };
        }

        public ErrorResponseVm(string code, string message, object? data)
        {
            Error = new ErrorDetailViewModel
            {
                Code = code,
                Message = message,
                Data = data
            };
        }

        public ErrorResponseVm(string code, string message, ErrorDetailViewModel[] details)
        {
            Error = new ErrorDetailViewModel
            {
                Code = code,
                Message = message,
                Details = details
            };
        }

        public ErrorResponseVm(string code, string message, string target) : this(code, message)
        {
            Error.Target = target;
        }

        public class ErrorDetailViewModel

        {
            public string? Code { get; set; }
            public string? Message { get; set; }
            public string? Target { get; set; }
            public ErrorDetailViewModel[]? Details { get; set; }
            public object? Data { get; set; }
        }
    }
}

