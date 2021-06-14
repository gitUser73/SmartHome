#!/bin/bash

SCRIPTPATH="$( cd -- "$(dirname "$0")" >/dev/null 2>&1 ; pwd -P )"

rsync -avz $SCRIPTPATH/../OpenHab3/test.things -e ssh openhabian@192.168.178.67:/etc/openhab/things