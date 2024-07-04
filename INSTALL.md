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

and finally, run **sh make.sh** in the SiriusOS source directory