# Use official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
COPY . .

# Use SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CTRLightsPublicAPI.csproj", "./"]
RUN dotnet restore

# Copy everything and build
COPY . .
RUN dotnet build --no-restore -c Release -o /app/build
RUN dotnet publish -c Release -o /app/publish

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CTRLightsPublicAPI.dll"]
