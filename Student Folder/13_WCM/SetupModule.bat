powershell -Command "& {.\DeleteExistingSites.ps1" -NoExit}
powershell -Command "& {.\SetupModulePubSite.ps1" -NoExit}
powershell -Command "& {.\SetupModuleAuthSite.ps1" -NoExit}

pause
