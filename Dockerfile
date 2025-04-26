# 1. Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY . .

WORKDIR /src/E-Ticaret
RUN dotnet restore ../ETicaret.sln
RUN dotnet publish ETicaret.csproj -c Release -o /app/out

# 2. Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "ETicaret.dll"]
