FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MassTransit.Consumer/MassTransit.Consumer.csproj", "MassTransit.Consumer/"]
RUN dotnet restore "MassTransit.Consumer/MassTransit.Consumer.csproj"
COPY . .
WORKDIR "/src/MassTransit.Consumer"
RUN dotnet build "MassTransit.Consumer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MassTransit.Consumer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MassTransit.Consumer.dll"]
