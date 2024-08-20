class Snack:
  #class attributes
  category = "Unknown snack"
  isFilling = True
  numServings = 1
  brand = 'unknown'

  #methods for Snack objects
  def __init__(self, category, isFilling, numServings, brand):
    self.category = category
    self.isFilling = isFilling
    self.numServings = numServings
    self.brand = brand

  def eat(self):
    self.numServings -= 1

class Chip(Snack):
  #additional chip attributes
  bagAirPercent = 75
  chipVariety = 'potato'

  def __init__(self, isFilling, numServings, brand, bagAirPercent, chipVariety):
    self.category = 'chip'
    self.isFilling = isFilling
    self.numServings = numServings
    self.brand = brand
    self.bagAirPercent = bagAirPercent
    self.chipVariety = chipVariety

class Cookie(Snack):
  #additional cookie attributes
  isSandwich = bool
  hasChocolate = bool
  isSoft = bool

  def __init__(self, isFilling, numServings, brand, isSandwich, hasChocolate, isSoft):
    self.category = 'cookie'
    self.isFilling = isFilling
    self.numServings = numServings
    self.brand = brand
    self.isSandwich = isSandwich
    self.hasChocolate = hasChocolate
    self.isSoft = isSoft


new_snack = Cookie(True, 1, 'Old Maa', False, True, True)
new_snack.eat()
print(new_snack.category, new_snack.isFilling, new_snack.numServings, new_snack.isSandwich)

"""
Create two classes that inherit from another class.

1. Ensure each child has at least two of their own attributes.

2. Add comments throughout your Python explaining your code.

Upload your code to GitHub and submit your link below.
"""
