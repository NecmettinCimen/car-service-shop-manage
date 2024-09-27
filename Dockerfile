FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App
ARG BUILD_NUMBER

# Copy everything
COPY ./aracyonetim.web/ ./aracyonetim.web/
COPY ./aracyonetim.database/ ./aracyonetim.database/
COPY ./aracyonetim.services/ ./aracyonetim.services/
COPY ./aracyonetim.entities/ ./aracyonetim.entities/

# Build and publish a release
RUN dotnet publish ./aracyonetim.web/aracyonetim.web.csproj -c Release -o out /p:Version=${BUILD_NUMBER}

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .

ENTRYPOINT ["dotnet", "aracyonetim.web.dll"]

