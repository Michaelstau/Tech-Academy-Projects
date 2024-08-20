class Book:
  #Book attributes
  pageCount = int
  genre = 'Undocumented'
  hardCover = False

  #Book methods
  def __init__(self, pageCount, genre, hardCover):
    self.pageCount = pageCount
    self.genre = genre
    self.hardCover = hardCover

  def read(self):
    print('You read through the book')

class Diary:
  #Diary attributes
  genre = 'Autobiography'
  pagesFilled = int
  locked = True

#Diary polymorphic methods
def __init__(self, pageCount, hardCover, pagesFilled, locked):
  self.pageCount = pageCount
  self.genre = 'Autobiography'
  self.hardCover = hardCover
  self.pagesFilled = pagesFilled
  self.locked = locked

def read(self):
  if self.locked == True:
    print("you can't read this diary, it's locked.")
  else:
    print("You read over the private events of someone's past.")

class Manual:
  #Manual attributes
  genre = 'guidebook'
  subject = 'undocumented'
  level = 'beginner'

  #manual polymorphic methods
  def __init__(self, pageCount, hardCover, subject, level):
    self.pageCount = pageCount
    self.genre = 'guidebook'
    self.hardCover = hardCover
    self.subject = subject
    self.level = level

  def read(self):
    print(f'You read the manual and learn much about {self.subject}.')
