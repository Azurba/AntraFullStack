#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV RecruitmentDb = "Data Source=172.24.224.1,1433; Initial Catalog=RecruitmentDb; Integrated Security=True; TrustServerCertificate=True"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApplication1/Hrm.RecruitingAPILayer.csproj", "WebApplication1/"]
COPY ["Hrm.Recruiting.Infrastructure/Hrm.Recruiting.Infrastructure.csproj", "Hrm.Recruiting.Infrastructure/"]
COPY ["Hrm.Recruiting.ApplicationLayer/Hrm.Recruiting.ApplicationLayer.csproj", "Hrm.Recruiting.ApplicationLayer/"]
RUN dotnet restore "WebApplication1/Hrm.RecruitingAPILayer.csproj"
COPY . .
WORKDIR "/src/WebApplication1"
RUN dotnet build "Hrm.RecruitingAPILayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hrm.RecruitingAPILayer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hrm.RecruitingAPILayer.dll"]