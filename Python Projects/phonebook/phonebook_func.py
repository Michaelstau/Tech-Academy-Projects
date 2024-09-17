import os
from tkinter import *
import tkinter as tk
import sqlite3
from tkinter import messagebox

import phonebook_main
import phonebook_gui

def center_window(self, w, h):
  """ Finds the center of the user's window and returns a string we can use with tkinter to center our main window """
  screen_width = self.master.winfo_screenwidth()
  screen_height = self.master.winfo_screenheight()
  x = int((screen_width/2) - (w/2))
  y = int((screen_height/2) - (h/2))
  centerGeo = self.master.geometry(f'{w}x{h}+{x}+{y}')
  return centerGeo


def ask_quit(self):
  """ Gives users a prompt if they really want to exit the app, then exits and releases app info from memory if they confirm """
  if messagebox.askokcancel('Exit program', 'Okay to exit application?'):
    self.master.destroy()
    os._exit(0)


def create_db(self):
  """ Sets up tbl_phonebook table for the first time """
  conn = sqlite3.connect('db_phonebook.db')
  with conn:
    cur = conn.cursor()
    cur.execute('CREATE TABLE if not exists tbl_phonebook( \
      ID INTEGER PRIMARY KEY AUTOINCREMENT, \
      col_fname TEXT, \
      col_lname TEXT, \
      col_fullname TEX,T \
      col_phone TEXT, \
      col_email TEXT \
      );')
    conn.commit()
  conn.close()
  first_run(self)


def first_run(self):
  """ Inserts a row of data into tbl_phonebook if there are no rows yet """
  conn = sqlite3.connect('db_phonebook.db')
  with conn:
    cur = conn.cursor()
    cur,count = count_records(cur)
    if count < 1:
      cur.execute("""INSERT INTO tbl_phonebook (col_fname,col_lname,col_fullname,col_phone,col_email) VALUES (?,?,?,?,?)""", ('John','Doe','John Doe','111-111-1111','jdoe@email.com'))
      conn.commit()
  conn.close()


def count_records(cur):
  """ Uses cursor to count rows in tbl_phonebook, then returns the cursor, and count """
  count = ''
  cur.execute("""SELECT COUNT(*) FROM tbl_phonebook""")
  count = cur.fetchone()[0]
  return cur, count


def onSelect(self,event):
  """ Fetches a row from tbl_phonebook when corresponding item is selected in the listbox. Clears current textboxes, and fills them with data from selected row. """
  varList = event.widget
  select = varList.curselection()[0]
  value = varList.get(select)
  conn = sqlite3.connect('db_phonebook.db')
  with conn:
    cursor = conn.cursor()
    cursor.execute("""SELECT col_fname,col_lname,col_phone,col_email FROM tbl_phonebook WHERE col_fullname = (?)""",(value))
    varBody = cursor.fetchall()
    for data in varBody:
      self.txt_fname.delete(0,END)
      self.txt_fname.insert(0,data[0])
      self.txt_lname.delete(0,END)
      self.txt_lname.insert(0,data[1])
      self.txt_phone.delete(0,END)
      self.txt_phone.insert(0,data[2])
      self.txt_email.delete(0,END)
      self.txt_email.insert(0,data[3])


def addToList(self):
  """ Takes user input, formats it, makes sure fields are filled and valid, and adds the row to tbl_phonebook (or gives useful error messages) """
  var_fname = self.txt_fname.get().strip().title()
  var_lname = self.txt_lname.get().strip().title()
  var_fullname = (f"{var_fname} {var_lname}")
  print(f"var_fullname: {var_fullname}")
  var_phone = self.txt_phone.get().strip()
  var_email = self.txt_email.get().strip()
  if not "@" or not "." in var_email:
    print("incorrect email format!!!")
  if (len(var_fname) > 0) and (len(var_lname) > 0) and (len(var_phone) > 0) and (len(var_email) > 0):
    conn = sqlite3.connect('db_phonebook.db')
    with conn:
      cur = conn.cursor()
      cur.execute(f"""SELECT COUNT(col_fullname) FROM tbl_phonebook WHERE col_fullname = '{var_fullname}'""")
      count = cur.fetchone()[0]
      chkName = count
      if chkName == 0:
        print(f"chkName: {chkName}")
        cur.execute(f"""INSERT INTO tbl_phonebook (col_fname,col_lname,col_fullname,col_phone,col_email) VALUES {var_fname},{var_lname},{var_fullname},{var_phone},{var_email}""")
        self.lstList1.insert(END, var_fullname)
        onClear(self)
      else:
        messagebox.showerror("NameError",f"'{var_fullname}' already exists in the database! Please choose a different name")
        onClear(self)
    conn.commit()
    conn.close()
  else:
    messagebox.showerror("Missing text Error","Please ensure that there is data in all four fields.")


def onDelete(self):
  var_select = self.lstList1.get(self.lstList1.surselection())
  conn = sqlite3.connect('db_phonebook.db')
  with conn:
    cur = conn.cursor()
    cur.execute("""SELECT COUNT(*) FROM tbl_phonebook""")
    count = cur.fetchone()[0]
    if count > 1:
      confirm = messagebox.askokcancel("Delete Confirmation", f"All information associated with, ({var_select}) \nwill be permenantly deleted from the database. \n\nProceed with the deletion request?")
      if confirm:
        conn = sqlite3.connect('db_phonebook.db')
        with conn:
          cursor = conn.cursor()
          cursor.execute(f"""DELETE FROM tbl_phonebook WHERE col_fullname = '{var_select}'""")
        onDeleted(self)
        conn.commit()
    else:
      confirm = messagebox.showerror("Last Record Error", f"({var_select}) if the last record in the database and cannot be deleted at this time. \n\nPlease add another record first before you can delete ({var_select})")
  conn.close()


def onDeleted(self):
  """ Clears out all txt boxes, and removes deleted item from lstList1 """
  self.txt_fname.delete(0,END)
  self.txt_lname.delete(0,END)
  self.txt_phone.delete(0,END)
  self.txt_email.delete(0,END)
  try:
    index = self.lstList1.curselection()[0]
    self.lstList1.delete(index)
  except IndexError:
    pass


def onClear(self):
  """ Clears out all txt boxes """
  self.txt_fname.delete(0,END)
  self.txt_lname.delete(0,END)
  self.txt_phone.delete(0,END)
  self.txt_email.delete(0,END)


def onRefresh(self):
  """ clears out lstList1, then checks tbl_phonebook for all entries in col_fullname and populates the lstList1 box with them """
  self.lstList1.delete(0,END)
  conn = sqlite3.connect('db_phonebook.db')
  with conn:
    cursor = conn.cursor()
    cursor.execute("""SELECT COUNT(*) FROM tbl_phonebook""")
    count = cursor.fetchone()[0]
    i = 0
    while i < count:
      cursor.execute("""SELECT col_fullname FROM tbl_phonebook""")
      varList = cursor.fetchall()[i]
      for item in varList:
        self.lstList1.insert(0,str(item))
        i += 1
  conn.close()


def onUpdate(self):
  try:
    var_select = self.lstList1.curselection()[0]
    var_value = self.lstList1.get(var_select)
  except:
    messagebox.showinfo("Missing selection","No name was selected from the list box. \nCancelling the Update request")
    return
  var_phone = self.txt_phone.get().strip()
  var_email = self.txt_email.get().strip()
  if (len(var_phone) > 0) and (len(var_email) > 0):
    conn = sqlite3.connect('db_phonebook.db')
    with conn:
      cur = conn.cursor()
      cur.execute("""SELECT COUNT (col_phone) FROM tbl_phonebook WHERE col_phone = '{}'""".format(var_phone))
      count = cur.fetchone()[0]
      print(count)
      cur.execute("""SELECT COUNT (col_email) FROM tbl_phonebook WHERE col_phone = '{}'""".format(var_email))
      count2 = cur.fetchone()[0]
      print(count2)
      if count == 0 or count2 == 0:
        response = messagebox.askokcancel("Update request","The following changes ({}) and ({}) will be implemented for ({}). \n\nProceed with the update request?")
        print(response)
        if response:
          with conn:
            cursor = conn.cursor()
            cursor.execute("""UPDATE tbl_phonebook SET col_phone = '{0}',col_email = '{1}' WHERE col_fullname = '{2}'""".format(var_phone,var_email,var_value))
            onClear(self)
            conn.commit()
        else:
          messagebox.showinfo("Cancel request","No changes have been made to ({}).".format(var_value))
      else:
        messagebox.showinfo("No changes detected","Both ({}) and ({}) \nalready exist in the database for this name. \n\nYour update request has been cancelled.".format(var_phone, var_email))
      onClear(self)
    conn.close()
  else:
    messagebox.showerror("Missing information","Please select a name from the list. \nThen edit the phone or email information.")
  onClear(self)


if __name__ == "__main__":
    pass
