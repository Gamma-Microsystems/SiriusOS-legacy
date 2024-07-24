#!/bin/bash
NVER=6.0
MVER=3

_increment_build_number() {
    if [ ! -f "build_number.txt" ]; then 
        echo 1 > build_number.txt
    else 
        read -r prev_build_num < build_number.txt
        new_build_num=$((prev_build_num + 1))
        echo $new_build_num > build_number.txt
    fi
}

_increment_build_number

cd sirius
cosmos -b
cp bin/cosmos/Debug/net$NVER/sirius.bin ../sysroot/
cd ..

# Define function that increments and returns current build number
increment_build_number() {
    if [ ! -f "build_number_sirpe.txt" ]; then 
        echo 1 > build_number_sirpe.txt # Initial setup for build counter
    else 
        # Read the previous build number, increment it by 1, and write back to file  
        read -r prev_build_num < build_number_sirpe.txt
        new_build_num=$((prev_build_num + 1))
        echo $new_build_num > build_number_sirpe.txt
    fi
}

# Call function to update/build number 
increment_build_number

cd sirpe
cosmos -b
cp bin/cosmos/Debug/net$NVER/sirpe.bin ../sysroot/
cd ..

cd tools
cc -g -O2 -pipe -Wall -Wextra -std=c99 limine.c -o limine.tool
cd ..

xorriso -as mkisofs -b sysroot/limine-bios-cd.bin \
	-no-emul-boot -boot-load-size 4 -boot-info-table \
	--efi-boot sysroot/limine-uefi-cd.bin \
	-efi-boot-part --efi-boot-image --protective-msdos-label \
	sysroot -o SiriusOS-dotnet$NVER-milestone$MVER.iso
    chmod +x tools/limine.tool
    ./tools/limine.tool bios-install SiriusOS-dotnet$NVER-milestone$MVER.iso