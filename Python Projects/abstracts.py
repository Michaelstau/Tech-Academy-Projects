class Igniter:
  def __init__(self, uses, fuelType):
    self.uses = uses
    self.fuelType = fuelType

  def restoreUses(self):
    """ Abstract method to be defined by child classes """
    pass

  def lightCampfire(self):
    """ Decrements uses by 1 and displays a success message to user, or displays failure message if no uses available """
    if self.uses > 0:
      print("you apply heat to a dry pile of wood, it ignites!")
      self.uses -= 1
    else:
      print("You're out of ignition material. Use restoreUses() to get more ignition material")

""" Defining Blowtorch child class """
class Blowtorch(Igniter):
  def __init__(self, uses, maxUses = 200, fuelType="Butane"):
    self.uses = uses
    self.maxUses = maxUses
    self.fuelType = fuelType

  def restoreUses(self):
    """ Defining abstract method from parent class """
    print("you take the fuel canister to be refilled")
    self.uses = self.maxUses

kitchenTorch = Blowtorch(140, 200)
kitchenTorch.restoreUses()
kitchenTorch.lightCampfire()
