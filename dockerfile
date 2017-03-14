FROM windowsservercore
ADD RestService/bin/debug /app
WORKDIR /app
ENTRYPOINT ["cmd.exe", "/k", "RestService.exe"]