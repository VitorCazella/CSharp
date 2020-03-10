# Bingo Game
#
# @ Author: Vitor Antunes Cazella
# Date: 04/03/2020

import random

bingo_card = [7, 26, 40, 58, 73, 14, 34, 55, 68]
'''
while len(bingo_card) < 10: #generates a random bingo card
    count = 0
    random_number = int(random.randint(1, 100))
    for item in bingo_card: #check if the number generated already exist on the card
        if random_number == item:
            count = 1
    if count == 0:
        bingo_card.append(random_number)
'''

while len(bingo_card) != 0: #ask the user to type a number and if this number is on the card it is removed. This goes on until the card is empty.
    print("\n________________________")
    for item in bingo_card:  #used for printing the all numbers in the list
        print(item)
    try:                    #using in case the user types other data type
        num = int(input("Type a number: "))
    except:
        print("Only whole numbers!")
    count = 0
    for item in bingo_card:
        if item == num:
            bingo_card.remove(item)
            print("\n________________________")
            print("Number was crossed out")
            count = 1
    if count == 0:
        print("\n________________________")
        print("Number is not on the bingo card")

if len(bingo_card) == 0:
    print("\n\n\n________\n")
    print("BINGO!!!")
    print("________\n")
    try:
        exit()
    except:
        print("")