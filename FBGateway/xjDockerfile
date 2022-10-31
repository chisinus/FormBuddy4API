#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

ENV ASPNETCORE_URLS http://+:80
EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
#COPY ["FBGateway/FBGateway.csproj", "FBGateway/"]
COPY ["FBGateway.csproj", "FBGateway/"]
RUN dotnet restore "FBGateway/FBGateway.csproj"
COPY . .
WORKDIR "/src/FBGateway"
RUN dotnet build "FBGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FBGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FBGateway.dll"]