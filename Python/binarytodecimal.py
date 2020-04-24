# binarytodecimal.py
#
# @ Author: Vitor Antunes Cazella
# Date: 22/04/2020

def BiToDec(num):
    sum = 0
    print(num)
    str=num # initial string
    stringlength=len(str) # calculate length of the list
    numInverted=str[stringlength::-1] # slicing 
    print (numInverted[1]) # print the reversed string
    for i in numInverted:
        num = int(i)
        if i == '1':
            sum += numInverted[num] * 1
        elif i == '2':
            sum += numInverted[num] * 2
        elif i == '3':
            sum += numInverted[num] * 4
        elif i == '4':
            sum += numInverted[num] * 8
        elif i == '5':
            sum += numInverted[num] * 16
        elif i == '6':
            sum += numInverted[num] * 32
        elif i == '7':
            sum += numInverted[num] * 64
        elif i == '8':
            sum += numInverted[num] * 128
    print (sum)
    return sum
    

def main():
    BiToDec(input("number binary: "))

main()
input("\n\nPress the enter key to exit.")