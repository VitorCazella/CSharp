# Quotation Manipulation
# Demonstrates string methods
# quote from IBM Chairman, Thomas Watson, in 1943

quote = "   I think There is a World market for Maybe five computers."


print("Original quote:")
print(quote)

print("\nIn uppercase:")
print(quote.upper())

print("\nIn lowercase:")
print(quote.lower())

print("\nAs a title:")
print(quote.title())

print("\nWith a minor replacement:")
print(quote.replace("five", "millions of"))

print("\nFirst letter uppercsase:")
print(quote.capitalize())

print("\nSwiching uppercase and lowercase:")
print(quote.swapcase())

print("\nRemoving spaces from beginnig and end:")
print(quote.strip())

print("\nOriginal quote is still:")
print(quote)