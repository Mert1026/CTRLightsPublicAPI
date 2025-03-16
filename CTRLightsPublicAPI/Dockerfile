# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the .csproj file and restore the dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the app
COPY . ./

# Publish the app to a folder named 'out'
RUN dotnet publish -c Release -o out

# Use the runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
COPY --from=build /app/out ./

# Expose the port the app runs on (e.g., port 5000 for Kestrel)
EXPOSE 5000

# Define the entrypoint
ENTRYPOINT ["dotnet", "CTRLightsPublicAPI.dll"]  # Replace "MyApi.dll" with your actual .dll file name
