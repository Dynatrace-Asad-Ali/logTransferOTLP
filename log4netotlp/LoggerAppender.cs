using log4net;
using log4net.Appender;
using log4net.Core;
using Microsoft.Extensions.Logging;

namespace log4netotlp
{
    public class LoggerAppender : TraceAppender
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            var factory = LogManager.GetRepository().Properties["ILoggerFactory"] as ILoggerFactory;
            if ((factory == null) || (loggingEvent == null) || (loggingEvent.LoggerName == null) || (loggingEvent.MessageObject == null)) {
                return;
            }
            var logger = factory.CreateLogger(loggingEvent.LoggerName);

            var level = loggingEvent.Level;
            var message = loggingEvent.MessageObject.ToString();

            if (level >= Level.Error)
            {
                logger.LogError(message);
            }
            else if (level >= Level.Warn)
            {
                logger.LogWarning(message);
            }
            else if (level >= Level.Info)
            {
                logger.LogInformation(message);
            }
            else
            {
                logger.LogTrace(message);
            }
        }
    }
}