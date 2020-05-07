#!/bin/bash
windows_log_path="c:\\temp\\"
linux_log_path="/app/"

export K6_VIRTUAL_USERS=50
export K6_DURATION="1m"

rm -rf out
docker rmi -f log-benchmark

# Native
./scripts/run-scenario.sh "Native" "Information" "Console" "windows"
./scripts/run-scenario.sh "Native" "Debug" "Console" "windows"

./scripts/run-scenario.sh "Native" "Information" "Console" "docker"
./scripts/run-scenario.sh "Native" "Debug" "Console" "docker"

# Serilog
./scripts/run-scenario.sh "Serilog" "Information" "Console" "windows"
./scripts/run-scenario.sh "Serilog" "Information" "Console" "docker"

./scripts/run-scenario.sh "Serilog" "Debug" "Console" "windows"
./scripts/run-scenario.sh "Serilog" "Debug" "Console" "docker"

./scripts/run-scenario.sh "Serilog" "Information" "File" "windows"
./scripts/run-scenario.sh "Serilog" "Information" "File" "docker"

./scripts/run-scenario.sh "Serilog" "Debug" "File" "windows"
./scripts/run-scenario.sh "Serilog" "Debug" "File" "docker"

# Log4Net
./scripts/run-scenario.sh "Log4Net" "Information" "Console" "windows" 
./scripts/run-scenario.sh "Log4Net" "Information" "Console" "docker"

./scripts/run-scenario.sh "Log4Net" "Debug" "Console" "windows"
./scripts/run-scenario.sh "Log4Net" "Debug" "Console" "docker"

./scripts/run-scenario.sh "Log4Net" "Information" "File" "windows" $windows_log_path
./scripts/run-scenario.sh "Log4Net" "Information" "File" "docker" $linux_log_path

./scripts/run-scenario.sh "Log4Net" "Debug" "File" "windows" $windows_log_path
./scripts/run-scenario.sh "Log4Net" "Debug" "File" "docker" $linux_log_path

# NLog
./scripts/run-scenario.sh "NLog" "Information" "Console" "windows"
./scripts/run-scenario.sh "NLog" "Information" "Console" "docker"

./scripts/run-scenario.sh "NLog" "Debug" "Console" "windows"
./scripts/run-scenario.sh "NLog" "Debug" "Console" "docker"

./scripts/run-scenario.sh "NLog" "Information" "File" "windows" $windows_log_path
./scripts/run-scenario.sh "NLog" "Information" "File" "docker" $linux_log_path

./scripts/run-scenario.sh "NLog" "Debug" "File" "windows" $windows_log_path
./scripts/run-scenario.sh "NLog" "Debug" "File" "docker" $linux_log_path
