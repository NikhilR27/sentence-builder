FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Admin@123
ENV MSSQL_PID=Developer

EXPOSE 1433

COPY ./init.sql /docker-entrypoint-initdb.d/
CMD [ "/opt/mssql/bin/sqlservr" ]