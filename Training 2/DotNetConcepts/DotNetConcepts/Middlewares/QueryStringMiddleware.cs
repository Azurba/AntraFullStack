namespace DotNetConcepts.Middlewares
{
    public class QueryStringMiddleware
    {
        private RequestDelegate next;

        public QueryStringMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Remember that HttpContext will handle the Http request and response for us
            //HTTP Methods: GET, POST, DELETE, PATCH and etc

            //Let's begin handling the request
            //If the request is a get...
            if (context.Request.Method == HttpMethods.Get)
            {
                //If the response of the request has not yet been processed and sent out...
                if (!context.Response.HasStarted)
                {
                    //Let's manipulate the response before it is sent back
                    //It will be of type text/plain
                    context.Response.ContentType = "text/plain";
                }
                //Await makes the compiler wait for something to finish before proceeding
                //Wait until we write "Class Middleware" to the response and then proceed
                await context.Response.WriteAsync("This is the response - Class Middleware");
            }
            //Wait for the current Middleware be done and then go to the next.
            await next(context);

            //Even though the current Middelware had been done and we moved to the next one,
            //eventually we will return
            await context.Response.WriteAsync("This is the response - trip back");
        }
    }
}
