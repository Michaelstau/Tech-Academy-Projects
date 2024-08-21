""" existance class with a private attribute _life and a protected attribute __meaning.  """
class Exist:
  def __init__(self):
    self._life = True
    self.__meaning = 42


  def ponder(self):
    """ prints ponderings based on the objects values of _life and __meaning """
    if self._life and self.__meaning == 42:
      print(f'Your existance is {self._life}, and strangely drawn to the number {self.__meaning}.')
    elif not self._life:
      print(f'Your existance is {self._life}. No pondering can occur... probably shouldn\'t have changed those variables.')
    else:
      print(f'Your existance is {self._life}, but you find {self.__meaning} kind of meaningless.')

  def dies(self):
    """ changes _life to False for the object """
    self._life = False

  def meaningless(self, meaning):
    """ sets the objects __meaning to whatever the meaning property is """
    self.__meaning = meaning

I = Exist()
I.ponder()
I.meaningless(45)
I.ponder()
I.dies()
I.ponder()
