# i3D_MappingExporter
i3D Mapping exporter for Farming Simulator
This tool exports the i3D Mappings from a Farming Simulator i3D File to xml so you can use it in your ModNameHere.xml .
You can ether install it like a regular programm (Default is: C:\Program Files\i3D_MappingExporter) or use the Portable version which you can start by double clicking the .exe file.

Installer: https://github.com/LuckyLars32/i3D_MappingExporter/releases/download/v1.0/i3D_MappingExporter_setup.exe

Portable: https://github.com/LuckyLars32/i3D_MappingExporter/releases/download/v1.0/i3D_MappingExporter.exe
# compile yourself:
You need:
- VS2017 or higher (https://visualstudio.microsoft.com)
- NSIS 3.08 or higher (https://nsis.sourceforge.io/Download)

Compile the source:
- copy the "i3D_MappingExporter" and "i3D_MappingExporter.sln" folder into your repos folder (Default: C:\Users\<username>\Source\Repos)
- open "i3D_MappingExporter.sln"

Create the installer (not needed for portable version)
- open NSIS and click "compile NSIS Script"
- open "i3D_MappingExporter.nsi" from the subdirectory "i3D_MappingExporter\i3D_MappingExporter\bin\Installer\"in your repos.
- click "Compile" at the bottom
- you can edit the "i3D_MappingExporter.nsi" with notepad++ if you want to change anyting.
