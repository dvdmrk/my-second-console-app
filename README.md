# my-second-console-app
Step 1) dotnet publish -c release
c:\Source\my-second-console-app\container>dotnet publish -c release
Microsoft (R) Build Engine version 16.4.0+e901037fe for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 154.8 ms for c:\Source\my-second-console-app\container\app.csproj.
  app -> c:\Source\my-second-console-app\container\bin\release\netcoreapp3.1\app.dll
  app -> c:\Source\my-second-console-app\container\bin\release\netcoreapp3.1\publish\

Step 2) docker build -t containerimage -f Dockerfile .
c:\Source\my-second-console-app>docker build -t containerimage -f Dockerfile .
Sending build context to Docker daemon  728.1kB
Step 1/3 : FROM mcr.microsoft.com/dotnet/core/runtime:3.1
3.1: Pulling from dotnet/core/runtime
59db842963e6: Pull complete                                                                                          c73aea2c082a: Pull complete                                                                                          82e5346d5403: Pull complete                                                                                          87d9a89e067f: Pull complete                                                                                          82d6d8f0d407: Pull complete                                                                                          add89cde8d33: Pull complete                                                                                          Digest: sha256:814490388507af9003abd961d62b5c542ebb5defd98151c6a1092550359b8c46
Status: Downloaded newer image for mcr.microsoft.com/dotnet/core/runtime:3.1
 ---> f869f4c5aba7
Step 2/3 : COPY container/bin/Release/netcoreapp3.1/publish/ container/
 ---> 80e8cb02afa4
Step 3/3 : ENTRYPOINT ["dotnet", "container/app.dll"]
 ---> Running in 7ae92ed6b3e6
Removing intermediate container 7ae92ed6b3e6
 ---> 426e8d7300d5
Successfully built 426e8d7300d5
Successfully tagged containerimage:latest

Step 3) docker run -it --rm containerimage
Counter: 1
Counter: 2
Counter: 3
Counter: 4
Counter: 5
^C
