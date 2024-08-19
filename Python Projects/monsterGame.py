def start(left=0,right=0,name=""):
  """ First function of monsterGame. Calls describe_game(), left_right(), and assigns variables"""
  print("\n************* Monster Quest ************")
  name = describe_game(name)
  left,right,name = left_right(left,right,name)


def describe_game(name):
  """ Introduces the player to the game (or greets them if playing again), and returns the player's name. """
  if name != "":
    print(f"\nWelcome, {name}, a year has passed \nsince you last entered this dungeon.")
    return name
  while True:
    name = input("\nWhat is your name? \n").capitalize()
    if name != "":
      print(f"\nWelcome, {name}, a year has passed \nsince you last entered this dungeon.")
      print("\nIn this game, you will navigate a maze \nand avoid a monster. You can choose \nto turn left or right at intersections.")
      print("Hopefully you can escape alive!")
      return name


def left_right(left,right,name):
  """ Lets the player choose to go left or right, describes the result, and adds 1 to player’s chosen choice. Calls score() """
  stop = True
  while stop:
    print(f"\nDistance to your fate: \n({left}, Exit) and ({right}, Monster)")
    pick = input("\nYou arrive at an intersection. \nWill you turn left or right? (L/R) \n").lower()
    if pick == "l":
      print("\n************************************\n\nYou continue on the path and catch the \nscent of fresh air")
      left += 1
      stop = False
    if pick == "r":
      print("\n************************************\n\nYou continue on the path, but hear a \nmonster up ahead")
      right += 1
      stop = False
  score(left,right,name)


def score(left,right,name):
  """ Checks if the player has finished the game and calls escape(), monster(), or left_right accordingly"""
  if left > 2:
    escape(name)
  elif right > 2:
    monster(name)
  else:
    left_right(left,right,name)


def escape(name):
  """ Describes the result of their choices to the player and calls again(). """
  print(f"\nWell done! You escaped the maze! Some \nof your friends are still in there, \nbut at least you survived!")
  again(name)


def monster(name):
  """ Describes the result of their choices to the player and calls again(). """
  print(f"\nThe monster greets you and invites you \nto it's magical maze birthday party. \nYou party all night with your friends \nand promise the monster to return next year!")
  again(name)


def again(name):
  """ Asks player if they want to play again and calls reset(), or quit() accordingly """
  choice = ""
  while choice != "y" or "n":
    choice = input("\nDo you want to play again? (y/n): \n").lower()
    if choice == "y":
      reset(name)
    if choice == "n":
      print("\nOh, so sad, sorry to see you go")
      quit()
    else:
      print('\nEnter ( Y ) for "YES", ( N ) for "NO":\n')


def reset(name):
  """ resets the game """
  start(0,0,name)


""" starts the game """
if __name__ == "__main__":
  start()
