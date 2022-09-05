namespace ProcessoSeletivo.Utils.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }
            catch (Exception ex)
            {
                MeuLog.Instance().Log = ex.ToString();
                throw;
            }
        }
    }

    public class MeuLog
    {
        private MeuLog()
        {

        }

        public static MeuLog Instance()
        {
            if (instance == null)
            {
                instance = new MeuLog();
            }
            return instance;
        }

        private static MeuLog instance;
        public string Log { get; set; }
    }
}
