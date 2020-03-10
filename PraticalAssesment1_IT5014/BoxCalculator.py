# BoxCalculator.py
#
# @ Author: Vitor Antunes Cazella
# Date: 04/03/2020

def calculateBoxes(num):
    ''' Calculates the number of boxes needed '''
    bigBox = 5
    medBox = 3
    smallBox = 1

    bigBoxCount = 0
    medBoxCout = 0
    smallBoxCount = 0

    while num > 0:
        if num >= bigBox:
            num -= bigBox
            bigBoxCount += 1
        elif num >= medBox:
            num -= medBox
            medBoxCout += 1
        elif num >= smallBox:
            num -= smallBox
            smallBoxCount += 1
        else:
            break

    totalCount = bigBoxCount + medBoxCout + smallBoxCount

    print(calculateBoxes.__doc__)
    print("Big Boxes: ", bigBoxCount)
    print("Medium Boxes: ", medBoxCout)
    print("Small Boxes: ", smallBoxCount)
    print("Total of Boxes: ".upper(), totalCount)

calculateBoxes(int(input("Number of items:")))