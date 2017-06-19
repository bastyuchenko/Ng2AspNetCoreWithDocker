FROM microsoft/aspnetcore:1.1
ARG source=.
WORKDIR /app
EXPOSE 80
COPY $source .
ENTRYPOINT ["dotnet", "Ng2AspCore_FinalOnLinux.dll"]