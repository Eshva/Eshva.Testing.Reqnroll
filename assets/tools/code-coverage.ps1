dotnet-coverage collect "dotnet test --solution Eshva.Testing.Reqnroll.slnx" --output-format cobertura --output cobertura.xml
reportgenerator -reports:cobertura.xml -targetdir:coverage -reporttypes:Html_Dark -assemblyfilters:+Eshva.Testing.Reqnroll -classfilters:-*Settings
./coverage/index.html
