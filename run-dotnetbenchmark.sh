#!/bin/bash
mode=$1
dump_path=$2

rm -rf out
docker rmi -f log-benchmark


if [ -z "$mode" ]
then
    rm -rf ./out
    dotnet publish -c Release -o ./out src/Logging.Benchmark.Console/ 
    dotnet ./out/Logging.Benchmark.Console.dll
    exit
fi

echo "Docker Mode"
./scripts/run-with-docker.sh "Logging.Benchmark.Console" "Dockerfile-Benchmark.Template" "--rm -v $dump_path:/app/out/BenchmarkDotNet.Artifacts"

