#!/bin/bash
rm -rf out
project_name=$1
mode=$2


if [[ $mode = "docker" ]]; then
  echo "Docker Mode"
  ./scripts/run-with-docker.sh $project_name
else
  if [ ! -d "./out" ]
  then
      dotnet publish -o out -c Release src/$project_name/
  fi
  dotnet out/$project_name.dll --urls "http://0.0.0.0:80" &   
fi