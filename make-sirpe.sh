#!/bin/bash

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