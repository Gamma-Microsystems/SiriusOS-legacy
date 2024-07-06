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

# Using Windows:
Windows is not officialy supported :-(
But you can try to build it

Then [download](https://github.com/PratyushKing/cosmosCLI/releases/tag/v1.3.1-stable) cosmosCLI or [build](https://github.com/PratyushKing/cosmosCLI/archive/refs/heads/main.zip) it

and finally, run **bash make.sh** in the SiriusOS source directory

# Testing:
### Qemu
run **sh mkqemu.sh** to convert vmdk to the QemuIMG (If you want filesystem testing of course)
then run **sh autorun.sh** or use **bash run.sh** with your custom args

### VMWare
Create a virtual machine, import the Filesystem.vmdk as hard disk, and then import ISO file as CD/DVD