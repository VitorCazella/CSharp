# first.py
#
# @ Author: Vitor Antunes Cazella
# Date: 02/03/2020

import random

print("---------------------------------------\n")
print ("Hello World!\n")

complexnum  = (2134 + 4j)

print(complexnum)
print(complexnum.real) # real part
print(complexnum.imag) # imaginary part 

my_string = "This is a string! wow"

random_number = random.randint(0, 1000)
print("\nRandom Number: ", random_number)

print("\nBoolen values")
print ("Test 1 ", bool(True))
print ("Test 2 ", bool(False))
print ("Test 3 ", bool("text"))
print ("Test 4 ", bool(""))
print ("Test 5 ", bool(" "))
print ("Test 6 ", bool(0))
print ("Test 7 ", bool())
print ("Test 8 ", bool(3))
print ("Test 9 ", bool(None))

print("\n---------------------------------------")