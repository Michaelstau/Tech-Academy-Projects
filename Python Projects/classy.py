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
