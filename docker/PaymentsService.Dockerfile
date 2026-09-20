FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY src/PaymentsService/PaymentsService.csproj src/PaymentsService/
RUN dotnet restore src/PaymentsService/PaymentsService.csproj
COPY src/PaymentsService/ src/PaymentsService/
RUN dotnet publish src/PaymentsService/PaymentsService.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "PaymentsService.dll"]
