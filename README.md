# Log Transfer Using OTLP
This repository contain sample Java and dotNet application that uses log4j and log4net libraries respectively to write to log files. Additionally, it contains sample to show how to transfer logs from these applications to Dynatrace end point using OTLP.

### dotNet setup instructions
For log4net, these 4 environment variables are needed to ship the logs to Dynatrace
set OTEL_EXPORTER_OTLP_ENDPOINT=<Dynatrace end point>

set OTEL_EXPORTER_OTLP_PROTOCOL=http/protobuf

set OTEL_BLRP_MAX_EXPORT_BATCH_SIZE=1

set OTEL_EXPORTER_OTLP_HEADERS=”Authorization: Api-Token <token>”


### Java setup instructions
For Java, please update the tenant in the file logTransferOTLP/log4jotlp/src/main/resources/log4j2.xml
