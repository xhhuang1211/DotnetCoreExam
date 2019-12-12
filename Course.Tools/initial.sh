# install dotnet-ef
dotnet tool install --global dotnet-ef --version 3.0.0
# install mysql db
docker run --name exam-mysql -p 3306:3306 -e MYSQL_ROOT_PASSWORD=password -d mysql
