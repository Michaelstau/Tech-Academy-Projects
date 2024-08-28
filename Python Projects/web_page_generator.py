import tkinter as tk
from tkinter import *
import webbrowser

class ParentWindow(Frame):
  def __init__(self, master):
    """ Initializes a window titled Web PAge Generator, with instructions,
        a fillable text field, and two buttons to create either a default
        webpage, or one that displays the contents of the text field. """
    Frame.__init__(self, master)
    self.master.title("Web Page Generator")

    self.label = Label(self.master, text="Enter custom text or click the Default HTML page button")
    self.label.grid(row=0, column=0, padx=(10,10), pady=(10,10))
    self.text_Custom = Entry(width=135)
    self.text_Custom.grid(row=1, column=0, columnspan=3, padx=(10,10), pady=(10,10))
    self.btn = Button(self.master, text="Default HTML Page", width=30, height=2, command= lambda: self.defaultHTML(False))
    self.btn.grid(row=2, column=1, padx=(55,10), pady=(10,10))
    self.btn_Custom = Button(self.master, text="Submit Custom Text", width=30, height=2, command= lambda: self.defaultHTML(True))
    self.btn_Custom.grid(row=2, column=2, padx=(10,10), pady=(10,10))


  def defaultHTML(self, custom):
    """ generates index.html with either default or custom text,
        then opens it in the browser """
    if custom == True:
      htmlText = self.text_Custom.get()
    else:
      htmlText = "Stay tuned for our amazing summer sale!"
    htmlFile = open("index.html", "w")
    htmlContent = "<html>\n<body>\n<h1>" + htmlText + "</h1>\n</body>\n</html>"
    htmlFile.write(htmlContent)
    htmlFile.close()
    webbrowser.open_new_tab("index.html")

if __name__ == "__main__":
  root = tk.Tk()
  App = ParentWindow(root)
  root.mainloop()
