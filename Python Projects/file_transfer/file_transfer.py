import tkinter as tk
from tkinter import *
import tkinter.filedialog
import os
import shutil
import datetime

#setting up our window class as a child of Frame class
class ParentWindow(Frame):
  """ setting up our window class as a child of Frame class """
  def __init__(self, master):
    """ Initialization paramaters for ParentWindow Objects """
    Frame.__init__(self)
    self.master.title("File Transfer")
    #Select Source button, position, and sourceDir call
    self.sourceDir_btn = Button(text="Select Source", width=20, command=self.sourceDir)
    self.sourceDir_btn.grid(row=0, column=0, padx=(20,10), pady=(30,0))
    #Source textbox
    self.source_dir = Entry(width=75)
    self.source_dir.grid(row=0, column=1, columnspan=2, padx=(20,10), pady=(30,0))
    #destination Source button, position, and destDir call
    self.destDir_btn = Button(text="Select Destination", width=20, command=self.destDir)
    self.destDir_btn.grid(row=1, column=0, padx=(20,10), pady=(15,10))
    #destination textbox
    self.destination_dir = Entry(width=75)
    self.destination_dir.grid(row=1, column=1, columnspan=2, padx=(20,10), pady=(15,10))
    #Transfer button, position, and transferFiles call
    self.transfer_btn = Button(text="Transfer Files", width=20, command=self.transferFiles)
    self.transfer_btn.grid(row=2, column=1, padx=(200,0), pady=(0,15))
    #exit button, position, and exit_program call
    self.exit_btn = Button(text="Exit", width=20, command=self.exit_program)
    self.exit_btn.grid(row=2, column=2, padx=(10,40), pady=(0,15))


  def sourceDir(self):
    """ Ask user to select source directory, delete what was already in the source_dir
        textbox, and insert selected directory into source_dir """
    selectSourceDir = tkinter.filedialog.askdirectory()
    self.source_dir.delete(0,END)
    self.source_dir.insert(0, selectSourceDir)

  def destDir(self):
    """ Ask user to select dource directory, delete what was already in the destination_dir
        textbox, and insert selected directory into destination_dir """
    selectDestDir = tkinter.filedialog.askdirectory()
    self.destination_dir.delete(0,END)
    self.destination_dir.insert(0, selectDestDir)

  def transferFiles(self):
    """ grabs file paths from source_dir and destination_dir, makes a list of files present
        in source_dir, then loops through the list comparing each files modification date to
        the current date. If difference is a day or greater, the file is moved from the path
        in source_dir to path in destination_dir (and prints a message about it). """
    source = self.source_dir.get()
    destination = self.destination_dir.get()
    source_files = os.listdir(source)
    now = datetime.datetime.now()
    for i in source_files:
      editTime = os.path.getmtime(source + '/' + i)
      timeSinceEdit = now - datetime.datetime.fromtimestamp(editTime)
      if timeSinceEdit.days > 0:
        shutil.move(source + '/' + i, destination)
        print(i + ' was successfully transferred')

  def exit_program(self):
    root.destroy()

#making an instance of our class, and setting up a loop that'll keep it displayed.
if __name__ == "__main__":
  root = tk.Tk()
  App = ParentWindow(root)
  root.mainloop()
