# Bingo Game Full Version
#
# @ Author: Vitor Antunes Cazella
# Date: 05/03/2020

import random

bingo_card = []
drawnNumbers = []

def init():
    cardGenerator()
    showCards()
    keepPlaying()

def cardGenerator():

    while len(bingo_card) < 10: #generates a random bingo card
        count = 0
        random_number = int(random.randint(1, 100))
        for item in bingo_card: #check if the number generated already exist on the card
            if random_number == item:
                count = 1
        if count == 0:
            bingo_card.append(random_number)

def showCards():
    print("This is your card:")
    for item in bingo_card:  #go through the list
        print(item)

def showDrawnNumbers():
    print("\nNumbers Drawn:")
    drawnNumbers.sort()
    for item in drawnNumbers:
        print(item)

def drawnNumber():
    exist = False
    while exist != True:
        count = 0
        random_number = int(random.randint(1,100))
        if len(drawnNumbers) == 0:
            drawnNumbers.append(random_number)
            exist += 1
            return random_number
        for item in drawnNumbers: #check if the number generated was already drawn
            if random_number == item:
                count = 1
        if count == 0:
            drawnNumbers.append(random_number)
            exist += 1
            return random_number


def play():
    input("Press any key to Draw next number")
    num = drawnNumber()
    return num

def keepPlaying():
    
    while len(bingo_card) != 0: #ask the user to type a number and if this number is on the card it is removed. This goes on until the card is empty.
        num = play()
        showDrawnNumbers()
        count = 0
        for item in bingo_card:
            if item == num:
                bingo_card.remove(item)
                print("\n________________________")
                print(num," was crossed out")
                print("________________________\n")
                count = 1
        if count == 0:
            print("\n________________________")
            print(num," is not on the bingo card")
            print("________________________\n")

    if len(bingo_card) == 0:
        print("________")
        print("BINGO!!!")
        print("________")
        try:
            exit()
        except:
            print("Bye bye")

init()