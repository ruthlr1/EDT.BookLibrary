Education Development Trust - Software Developer Technical Assessment

Setup instructions when running with Visual Studio. 

1. Open Sql Management sudio and create an empty database
2. Update the DefaultConnection in the appsettings.json to point to your newly created database
"ConnectionStrings": {
  "DefaultConnection": "Server={SqlInstance};Database={DatabaseName};Integrated Security=TRUE;MultipleActiveResultSets=True;TrustServerCertificate=true;"
}

3. In Visual Studio, open Package Manager Console and type 'update-database'
4. Run solution

