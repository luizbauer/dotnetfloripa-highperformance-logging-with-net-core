#!/bin/bash
provider=$1
log_level=$2
output_mode=$3
mode=$4
log_path=$5

export Logging__Provider=$provider
export Logging__LogLevel=$log_level
export Logging__OutputMode=$output_mode
export LOG_PATH=$log_path

if [ -z "$mode" ]
then
    $mode="local"
fi

if [ -z "$provider" ]
then
    echo "Please select a valid provider: Native, Log4Net, NLog, Serilog"
    exit
fi

if [ -z "$log_level" ]
then
    echo "Please select a valid LOG LEVEL: Trace, Debug, Information, Warning, Error, Critical, None"
    exit
fi

if [ -z "$output_mode" ]
then
    echo "Please select a valid LOG LEVEL: Console, File"
    exit
fi

echo "Provider: $provider"
echo "Log Level: $log_level"
echo "Output Mode: $output_mode"

./scripts/run-webapi.sh Logging.Benchmark.WebApi $mode

sleep 2s

echo "Start K6 Load Test"

if [ ! -d "benchmarks" ]
then
    mkdir "benchmarks"
fi

k6 run -e provider=$provider -e logLevel=$log_level -e outputMode=$output_mode -q -u $K6_VIRTUAL_USERS -d $K6_DURATION ./k6/test.js >> benchmarks/${mode}_${provider}_${output_mode}_${log_level}.txt


if [ "$mode" = "windows" ]
then
    kill $(ps aux | grep 'dotnet' | awk '{print $1}')
else
    docker rm -f $(docker ps -aq --no-trunc --filter name=log-benchmark) || true
fi

