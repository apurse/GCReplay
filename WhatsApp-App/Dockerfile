FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["WhatsApp-App/WhatsApp-App.csproj", "."]
RUN dotnet restore "WhatsApp-App.csproj"
COPY . .
RUN dotnet build "WhatsApp-App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WhatsApp-App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WhatsApp-App.dll"]

