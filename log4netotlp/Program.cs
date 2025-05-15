using System;
using System.ComponentModel;
using log4net;
using log4net.Config;
using Microsoft.Extensions.Logging;
using OpenTelemetry.Logs;

namespace log4netotlp
{

    class Program
    {
        static Program()
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
                builder.AddOpenTelemetry(logging => { logging.AddOtlpExporter(); });
            });
            LogManager.GetRepository().Properties["ILoggerFactory"] = loggerFactory;
        }        

        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(typeof(Program));
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            for (;;) {
                log.Info("This is an info log message.");
                Thread.Sleep(5000);
            }
        }
    }
}