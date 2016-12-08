import clr

clr.AddReference("System.Drawing")
clr.AddReference("System.Windows.Forms")
from System.Drawing import *
from System.Windows.Forms import *


class TestForm(Form):

     def __init__(self):
         self.Text = 'Hello, IronPython!'
         self.Name = 'Test Programm'

form = TestForm()
Application.Run(form)