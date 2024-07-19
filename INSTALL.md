# Compiling SiriusOS

# Installing dependencies:

### openSUSE:
```sh
    sudo zypper in dotnet-host-7.0 dotnet-sdk-7.0 dotnet-runtime-7.0 dotnet-hostfxr-7.0 dotnet-host yasm xorriso make
```

# Using Linux:
Firstly build & install the COSMOS DevKit

```sh
    cd
    git clone https://github.com/CosmosOS/Cosmos.git
    cd Cosmos
    make # P.S if you have error 1064 remove the Common directory and start make again
```
Then [download](https://github.com/PratyushKing/cosmosCLI/releases/tag/v1.3.1-stable) cosmosCLI or [build](https://github.com/PratyushKing/cosmosCLI/archive/refs/heads/main.zip) it
and finally, run **bash make.sh** in the SiriusOS source directory, it is also recommended to run **bash make-sirpe.sh** for building installer

# Using Windows:
### Windows is not officialy supported :-(
But you can try to build it

# Using macOS
Same as in [linux](#using-linux) but you need to install docker for virtual environment

# Testing:

### VMWare
Create a virtual machine, import the Filesystem.vmdk as hard disk, and then import ISO file as CD/DVD

### Virtualbox
Same as in [vmware](#vmware)