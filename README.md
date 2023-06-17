Using MassTransit with dotnet 6 api app as a producer and a console app consumer

Generate certificate and configure local machine:

```PowerShell
dotnet dev-certs https --clean
dotnet dev-certs https -ep "$env:USERPROFILE\.aspnet\https\aspnetapp.pfx" -p password
dotnet dev-certs https --trust
```

Read more here:
https://learn.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-6.0#starting-a-container-with-https-support-using-docker-compose