# Compiling SiriusOS

Firstly install docker.
Then follow instructions bellow

### POSIX-like systems
```sh
    sudo sh prepare.sh && sudo sh make-universal.sh
```
After you see new console write ```sh make.sh``` and exit, you should recive an ISO in SiriusOS directory

### Windows
Double click to the prepare.bat, and then double click to the make-universal.bat and write ```sh make.sh``` and exit, you should recive an ISO in SiriusOS directory

### SiriusOS
Soon in M4/M5...

# Testing:

### VMWare
Create a virtual machine, import the Filesystem.vmdk as hard disk, and then import ISO file as CD/DVD

### Virtualbox
Same as in [vmware](#vmware)