def start(left=0,right=0,name=""):
  name = describe_game(name)
  left,right,name = left_mean(left,right,name)

def describe_game(name):
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


def left_mean(left,right,name):
  stop = True
  while stop:
    show_score(left,right,name)
    pick = input("\nYou arrive at an intersection. \nWill you turn left or right? (L/R) \n").lower()
    if pick == "l":
      print("\nYou continue on the path and catch the \nscent of fresh air")
      left += 1
      stop = False
    if pick == "r":
      print("\nYou continue on the path, but hear a \nmonster up ahead")
      right += 1
      stop = False
  score(left,right,name)

def show_score(left,right,name):
  print(f"\nDistance to your fate: \n({left}, Exit) and ({right}, Monster)")

def score(left,right,name):
  if left > 2:
    win(left,right,name)
  elif right > 2:
    lose(left,right,name)
  else:
    left_mean(left,right,name)


def win(left,right,name):
  print(f"\nWell done! You escaped the maze! Some \nof your friends are still in there, \nbut at least you survived!")
  again(left,right,name)

def lose(left,right,name):
  print(f"\nThe monster greets you and invites you \nto it's magical maze birthday party. \nYou party all night with your friends \nand promise the monster to return next year!")
  again(left,right,name)

def again(left,right,name):
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
  start(0,0,name)

if __name__ == "__main__":
  start()
