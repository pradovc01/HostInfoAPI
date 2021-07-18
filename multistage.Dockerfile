#Get base ASPNET image from Microsoft, first stage
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

#all tools and files are on sdk image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore "HostNameInfoAPI.csproj"
COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
VOLUME /app
ENTRYPOINT ["dotnet", "HostNameInfoAPI.dll"]
