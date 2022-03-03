#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MISA.eShop.OrderApi.Host/NuGet.Config", "/root/.nuget/NuGet/"]
COPY ["MISA.eShop.OrderApi.Host/MISA.eShop.OrderApi.Host.csproj", "MISA.eShop.OrderApi.Host/"]
RUN dotnet restore "MISA.eShop.OrderApi.Host/MISA.eShop.OrderApi.Host.csproj"
COPY . .
WORKDIR "/src/MISA.eShop.OrderApi.Host"
RUN dotnet build "MISA.eShop.OrderApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MISA.eShop.OrderApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MISA.eShop.OrderApi.Host.dll"]