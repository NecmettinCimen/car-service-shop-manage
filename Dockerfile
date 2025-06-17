FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /App
ARG BUILD_NUMBER

# Copy everything
COPY ./CarServiceShopManage.Web/ ./CarServiceShopManage.Web/
COPY ./CarServiceShopManage.Database/ ./CarServiceShopManage.Database/
COPY ./CarServiceShopManage.Services/ ./CarServiceShopManage.Services/
COPY ./CarServiceShopManage.Entities/ ./CarServiceShopManage.Entities/

# Build and publish a release
RUN dotnet publish ./CarServiceShopManage.Web/CarServiceShopManage.Web.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /App
COPY --from=build-env /App/out .

ENTRYPOINT ["dotnet", "CarServiceShopManage.Web.dll"]

