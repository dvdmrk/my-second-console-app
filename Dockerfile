FROM mcr.microsoft.com/dotnet/core/runtime:3.1
COPY container/bin/Release/netcoreapp3.1/publish/ container/
ENTRYPOINT ["dotnet", "container/app.dll"]