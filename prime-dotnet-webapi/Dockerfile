FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /home/prime
ENV WORKDIR /home/prime
ENV ASPNETCORE_ENVIRONMENT Development
# Copy csproj and restore as distinct layers
USER 0
RUN useradd -m prime 
RUN mkdir -p $WORKDIR
COPY *.csproj $WORKDIR
RUN dotnet restore
# Copy everything else and build
COPY . $WORKDIR
RUN dotnet publish -c Release -o out
# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
COPY --from=build $WORKDIR .
EXPOSE 8080 5001
ENV ASPNETCORE_ENVIRONMENT Development
USER prime
ENTRYPOINT ["/usr/bin/dotnet", "prime.dll"]
