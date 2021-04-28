FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GraphqlAPI/GraphqlAPI.csproj", "GraphqlAPI/"]
RUN dotnet restore "GraphqlAPI/GraphqlAPI.csproj"
COPY . .
WORKDIR "/src/GraphqlAPI"
RUN dotnet build "GraphqlAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GraphqlAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GraphqlAPI.dll"]
