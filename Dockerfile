FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /SearchProductListDemo

COPY . ./
RUN dotnet restore -s "https://api.nuget.org/v3/index.json"
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
EXPOSE 80
COPY --from=build /app ./
ENTRYPOINT ["dotnet","SearchProductList.dll"]