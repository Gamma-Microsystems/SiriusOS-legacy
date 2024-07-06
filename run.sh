#!/bin/bash

helpFunction()
{
   echo ""
   echo "Usage: $0 -i <ISO> -m <memory size> -h <hdd image>"
   echo "\t-i ISO path to be used"
   echo "\t-m Memory size to allocate to the Virtual Machine"
   echo "\t-h Hard disk image location, can be created with qemu-img"
   exit 1 # Exit script after printing help
}

while getopts "i:m:h:" opt
do
   case "$opt" in
      i ) ISO="$OPTARG" ;;
      m ) MEMORY_SIZE="$OPTARG" ;;
      h ) HDD_IMAGE="$OPTARG" ;;
      ? ) helpFunction ;; # Print helpFunction in case parameter is non-existent
   esac
done

# Print helpFunction in case parameters are empty
if [ -z "$ISO" ] || [ -z "$MEMORY_SIZE" ] || [ -z "$HDD_IMAGE" ]
then
   echo "Some or all of the parameters are empty";
   helpFunction
fi

# Build the project
bash make.sh

# Emulate the ISO
qemu-system-x86_64 -boot d -cdrom $ISO -m $MEMORY_SIZE -hda $HDD_IMAGE