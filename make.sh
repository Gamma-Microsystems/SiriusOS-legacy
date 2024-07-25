#!/bin/bash
NVER=6.0

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

grub-mkrescue /usr/lib/grub/i386-pc -o SiriusOS.iso sysroot