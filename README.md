# Azure Container Instances demonstration

## Introduction

Demonstration of running a stateful application within the Azure Container Instances.

## Logic

Once the container is deployed, check the logs.

you will see a new information log every five seconds.

## Environment variables

At the start of the execution, two environment variables are read:

```
var envVar1 = Environment.GetEnvironmentVariable("envVar1");
var envVar2 = Environment.GetEnvironmentVariable("envVar2");
```

Please add these two variables to have the experience.

## Blog post

The full story of this container can be found at [this blog post](https://sandervandevelde.wordpress.com/2024/08/24/getting-started-with-azure-container-instances/). 

## MIT License

This application is made available under the MIT license. 
