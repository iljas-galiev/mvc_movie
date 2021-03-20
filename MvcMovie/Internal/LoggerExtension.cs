using System;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Internal
{
    public static class LoggerExtension
    {
        private static readonly Action<ILogger, Exception> _indexPageRequested;

        static LoggerExtension()
        {
            _indexPageRequested = LoggerMessage.Define(
                LogLevel.Warning,
                new EventId(1, nameof(IndexPageRequested)),
                "GET request for Index page");
        }

        public static void IndexPageRequested(this ILogger logger)
        {
            _indexPageRequested(logger, null);
        }
    }
}
