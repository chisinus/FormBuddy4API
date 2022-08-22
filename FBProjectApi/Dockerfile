#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FBProjectApi/FBProjectApi.csproj", "FBProjectApi/"]
RUN dotnet restore "FBProjectApi/FBProjectApi.csproj"
COPY . .
WORKDIR "/src/FBProjectApi"
RUN dotnet build "FBProjectApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FBProjectApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FBProjectApi.dll"]