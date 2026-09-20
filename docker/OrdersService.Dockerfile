FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY src/OrdersService/OrdersService.csproj src/OrdersService/
RUN dotnet restore src/OrdersService/OrdersService.csproj
COPY src/OrdersService/ src/OrdersService/
RUN dotnet publish src/OrdersService/OrdersService.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "OrdersService.dll"]
