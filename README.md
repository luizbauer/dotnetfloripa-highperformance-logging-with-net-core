# .NET Core 3.1 Logger Providers benchmarking comparison

# Pre Requirements

- bash
- [k6](https://k6.io/)
- Docker
- .Net Core 3.1

# Scenarios

**Over Head**

- .NET Core Logging
    - Console Logging in `Information` Level;
    - Console Logging in `Debug` Level;
- Serilog
    - Console Logging in `Information` Level;
    - Console Logging in `Debug` Level;
    - File (Sink) Logging in `Information` Level;
    - File (Sink) Logging in `Debug` Level;
- Log4Net
    - Console Logging in `Information` Level;
    - Console Logging in `Debug` Level;
    - File (Sink) Logging in `Information` Level;
    - File (Sink) Logging in `Debug` Level;
- NLog
    - Console Logging in `Information` Level;
    - Console Logging in `Debug` Level;
    - File (Sink) Logging in `Information` Level;
    - File (Sink) Logging in `Debug` Level;

## Results

<table>
<tr><th>Windows </th><th>Docker (Linux)</th></tr>
<tr><td>

|Provider   | Output Mode | Log Level   | Request Per Second (RPS) |
|-----------|-------------|-------------|--------------------------|
| .NET Core | Console     | Information |   569                    |
| .NET Core | Console     | Debug       |   353                    |
| Serilog   | File        | Information |   3.448                  |
| Serilog   | File        | Debug       |   3.466                  |
| Serilog   | Console     | Information |   527                    |
| Serilog   | Console     | Debug       |   543                    |
| Log4Net   | File        | Information |   4.684                  |
| Log4Net   | File        | Debug       |   1.723                  |
| Log4Net   | Console     | Information |   1.219                  |
| Log4Net   | Console     | Debug       |   379                    |
| NLog      | File        | Information |   376                    |
| NLog      | File        | Debug       |   99                     |
| NLog      | Console     | Information |   748                    |
| NLog      | Console     | Debug       |   230                    |

</td><td>

|Provider   | Output Mode | Log Level   | Request Per Second (RPS) |
|-----------|-------------|-------------|--------------------------|
| .NET Core | Console     | Information |      2.994               |
| .NET Core | Console     | Debug       |      1.479               |
| Serilog   | File        | Information |      2.043               |
| Serilog   | File        | Debug       |      2.069               |
| Serilog   | Console     | Information |      1.550               |
| Serilog   | Console     | Debug       |      1.587               |
| Log4Net   | File        | Information |      2.474               |
| Log4Net   | File        | Debug       |      1.270               |
| Log4Net   | Console     | Information |      2.372               |
| Log4Net   | Console     | Debug       |      1.445               |
| NLog      | File        | Information |      1.437               |
| NLog      | File        | Debug       |      563                 |
| NLog      | Console     | Information |      2.057               |
| NLog      | Console     | Debug       |      1.098               |
</td></tr> </table>


# How to execute

## Request Per Second Sample
Run `./run-rps-benchmark.sh`

## Benchmark Dotnet Sample
Run `./run-dotnetbenchmark.sh`
