#!/bin/bash
project_name=$1
docker_template=$2
docker_extra_commands=$3
container_name="log-benchmark"

if [ -z $docker_template ]
then
    docker_template="Dockerfile.Template"
fi

if [ -z $(docker images  | grep log-benchmark) ] 
then 
    rm Dockerfile || true

    # Replace to project name
    sed "s/{{PROJECT_NAME}}/$project_name/g" templates/$docker_template > Dockerfile
    docker build -t $container_name .

    rm Dockerfile
fi

docker rm -f $(docker ps -aq --no-trunc --filter name=$container_name)

docker run -d -it  \
    -e Logging__Provider=$Logging__Provider \
    -e Logging__LogLevel=$Logging__LogLevel \
    -e Logging__OutputMode=$Logging__OutputMode \
    -e LOG_PATH=$LOG_PATH \
    $docker_extra_commands \
    -p 80:80 --name=$container_name $container_name
