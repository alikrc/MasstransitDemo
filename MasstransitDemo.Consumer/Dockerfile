#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Masstransit.Consumer/Masstransit.Consumer.csproj", "Masstransit.Consumer/"]
COPY ["MasstransitDemo.Shared/MasstransitDemo.Shared.csproj", "MasstransitDemo.Shared/"]
RUN dotnet restore "Masstransit.Consumer/Masstransit.Consumer.csproj"
COPY . .
WORKDIR "/src/Masstransit.Consumer"
RUN dotnet build "Masstransit.Consumer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Masstransit.Consumer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Masstransit.Consumer.dll"]