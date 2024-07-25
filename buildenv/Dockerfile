FROM ubuntu

RUN apt-get update
RUN apt-get upgrade -y
RUN apt-get install -y software-properties-common
RUN add-apt-repository -y ppa:dotnet/backports
RUN apt install -y make yasm xorriso dotnet-sdk-6.0 git grub-common grub-pc-bin mtools wget binutils
RUN git clone https://github.com/CosmosOS/Cosmos.git
RUN cd Cosmos && rm -f Makefile && wget http://gamma63.w10.site/soft/Cosmos/Makefile && make -f Makefile && cd ..
RUN wget https://github.com/PratyushKing/cosmosCLI/releases/download/v1.3.1-stable/cosmos.deb
RUN dpkg -i cosmos.deb
RUN cosmos --setup

VOLUME /root/env
WORKDIR /root/env