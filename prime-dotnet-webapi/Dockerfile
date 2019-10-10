FROM dotnet-22-rhel7 AS build
SHELL [ "/bin/bash","-c" ]
WORKDIR /opt/app-root/app
ENV WORKDIR /opt/app-root/app
ENV ASPNETCORE_ENVIRONMENT Development
# Copy csproj and restore as distinct layers
RUN mkdir -p $WORKDIR
COPY *.csproj $WORKDIR
RUN dotnet restore
# Copy everything else and build
COPY . $WORKDIR
RUN dotnet publish -c Release -o out
# Build runtime image
FROM dotnet-22-runtime-rhel7 AS runtime
COPY --from=build $WORKDIR .
EXPOSE 8080 5001
ENV ASPNETCORE_ENVIRONMENT Development

ENTRYPOINT ["/usr/bin/dotnet", "prime.dll"]
