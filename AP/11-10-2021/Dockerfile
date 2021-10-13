FROM mcr.microsoft.com/dotnet/runtime:6.0-focal AS base
WORKDIR /app

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["DictionaryApp.csproj", "./"]
RUN dotnet restore "DictionaryApp.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "DictionaryApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DictionaryApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DictionaryApp.dll"]
#Build image with name dictionary-app:latest
#docker build -t dictionary-app .
#Start comtainer from image
#docker run -it --rm --name dictionary-app-c2009l dictionary-app:latest
#push image to Docker registry
#docker image tag dictionary-app:latest sunlight4d/dictionary-app:latest
#docker image push sunlight4d/dictionary-app:latest
#another computer pull and run:
#docker run -it --rm --name dictionary-app-c2009l sunlight4d/dictionary-app:latest
