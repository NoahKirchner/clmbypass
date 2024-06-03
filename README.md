# clmbypass
Simple C# binary that can be compiled on linux and bypass CLM and other stuff by abusing installutil

Yeah I know that the build.sh script just makes a bunch of duplicate binaries without actually targeting a different version of dotnet, but I'll be honest I was doing this on linux and ended up just using mono anyway


anyway usage instructions are pretty simple. replace the content of command.ps1 with any sort of powershell script you want to run, by default it's a reverse shell. From there, run the build.sh script (make sure you have mono installed and all of its dependencies, I don't know what they are figure it out), and then the bin directory gets filled with a bunch of executable copies and then a bunch of base64's copies if you want to decode it in a macro or something. This bypasses CLM and also throws you into a 64 bit powershell session as opposed to 32 bit because it deals with runspaces.

also here's the installutil.exe command

```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe /logfile= /LogToConsole=false /U C:\Windows\tasks\pwned.exe
```

where pwned is whatever you named the executable. Throw this mfer into C:\Windows\tasks\ and name it system32.exe to bypass applocker btw

have fun
