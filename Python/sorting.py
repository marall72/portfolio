#!/bin/python3

import math
import os
from pydoc import stripid
import random
import re
import sys



if __name__ == '__main__':
    nm = input().split()

    n = int(nm[0])

    m = int(nm[1])

    arr = []

    for _ in range(n):
        temp = []
        temp.extend(map(int, input().split(" ")))
        arr.append(temp)

    k = int(input())
    sortedList = sorted(arr, key=lambda x: x[k])
    for i in sortedList:
        print(*i)