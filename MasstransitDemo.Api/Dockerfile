#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MasstransitDemo.Api/MasstransitDemo.Api.csproj", "MasstransitDemo.Api/"]
COPY ["MasstransitDemo.Shared/MasstransitDemo.Shared.csproj", "MasstransitDemo.Shared/"]
RUN dotnet restore "MasstransitDemo.Api/MasstransitDemo.Api.csproj"
COPY . .
WORKDIR "/src/MasstransitDemo.Api"
RUN dotnet build "MasstransitDemo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MasstransitDemo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MasstransitDemo.Api.dll"]
