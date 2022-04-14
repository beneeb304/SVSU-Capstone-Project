@echo off
set /p username="Enter your SVSU username: "
plink -ssh %username%@csis.svsu.edu pkill -u %username%