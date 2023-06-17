#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MasstransitDemo.Consumer/MasstransitDemo.Consumer.csproj", "MasstransitDemo.Consumer/"]
COPY ["MasstransitDemo.Shared/MasstransitDemo.Shared.csproj", "MasstransitDemo.Shared/"]
RUN dotnet restore "MasstransitDemo.Consumer/MasstransitDemo.Consumer.csproj"
COPY . .
WORKDIR "/src/MasstransitDemo.Consumer"
RUN dotnet build "MasstransitDemo.Consumer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MasstransitDemo.Consumer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MasstransitDemo.Consumer.dll"]