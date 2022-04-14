title CSIS-Connect
set username=%1
set password=%2
plink.exe -v -x -a -T -C -noagent -ssh -L 127.0.0.1:1433:10.8.30.150:1433 %username% -pw %password%