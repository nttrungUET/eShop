#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MISA.eShop.ProductApi.Host/NuGet.Config", "/root/.nuget/NuGet/"]
COPY ["MISA.eShop.ProductApi.Host/MISA.eShop.ProductApi.Host.csproj", "MISA.eShop.ProductApi.Host/"]
RUN dotnet restore "MISA.eShop.ProductApi.Host/MISA.eShop.ProductApi.Host.csproj"
COPY . .
WORKDIR "/src/MISA.eShop.ProductApi.Host"
RUN dotnet build "MISA.eShop.ProductApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MISA.eShop.ProductApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MISA.eShop.ProductApi.Host.dll"]