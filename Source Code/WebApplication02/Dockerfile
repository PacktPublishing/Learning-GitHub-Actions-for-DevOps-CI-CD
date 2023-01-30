#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
 
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApplication02/WebApplication02.csproj", "WebApplication02/"]
RUN dotnet restore "WebApplication02/WebApplication02.csproj"
COPY . .
WORKDIR "/src/WebApplication02"
RUN dotnet build "WebApplication02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication02.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication02.dll"]