import clr

clr.AddReference("System.Drawing")
clr.AddReference("System.Windows.Forms")
from System.Drawing import *
from System.Windows.Forms import *

from itertools import product


class SNForm(Form):
	
	def __init__(self):
		self.Width = 480
		self.Text = "Password lock"
		self.FormBorderStyle = FormBorderStyle.FixedDialog
		self.MaximizeBox = False
		self.MinimizeBox = False


		self.label = Label()
		self.label.Text = "Enter correct password here:"
		self.label.Location = Point(30,30)
		self.label.Height = 20
		self.label.Width = 200

		self.passwordField = TextBox()
		self.passwordField.Location = Point(30,50)
		self.passwordField.Height = 20
		self.passwordField.Width = 400

		self.confirm = Button()
		self.confirm.Location = Point(30, 80)
		self.confirm.Height = 30
		self.confirm.Width = 80
		self.confirm.Text = "Confirm"
		self.confirm.Click += self.confirmPressed
		
		self.output = TextBox()
		self.output.Location = Point(30, 120)
		self.output.Height = 100
		self.output.Width = 400
		self.output.Multiline = True
		self.output.ReadOnly = True

		self.Controls.Add(self.label)
		self.Controls.Add(self.passwordField)
		self.Controls.Add(self.confirm)
		self.Controls.Add(self.output)

	def confirmPressed(self, sender, args):
		if (verifyPassword(self.passwordField.Text)):
			flag = computeFlag(int(self.passwordField.Text))
			self.output.Text = str(flag)
		else:
			self.output.Text ="Error!!!"
		return 0

def checkSquares(table):
	for i in range(9):
		l=[]
		for j in range(9):
			l.append(table[(i/3)*3 + (j/3)][(i%3) * 3 + (j%3)])
		for k in range(1,10):
			if k not in l: return False
	return True

def checkColumns(table):
	for i in range(9):
		#i column; j raw
		l=[]
		for j in range(9):
			l.append(table[j][i])
		for k in range(1,10):
			if k not in l: return False
	return True

def checkLines(table):
	for l in table:
		for k in range(1,10):
			if k not in l: return False
	return True

def verifyPassword(password):
	
	if len(password) != 0x51:
		return False

	table = []
	table.append([4, 0, 0, 0, 6, 0, 0, 0, 0 ])
	table.append([0, 0, 3, 0, 5, 0, 0, 0, 0 ])
	table.append([0, 0, 0, 0, 0, 0, 0, 2, 0 ])
	table.append([0, 0, 0, 2, 0, 1, 0, 7, 0 ])
	table.append([5, 0, 6, 0, 0, 0, 3, 0, 0 ])
	table.append([8, 0, 0, 0, 0, 0, 0, 0, 0 ])
	table.append([0, 9, 0, 7, 0, 0, 0, 0, 0 ])
	table.append([0, 0, 0, 0, 0, 0, 5, 0, 4 ])
	table.append([0, 1, 0, 0, 0, 0, 0, 0, 0 ])

	for i in range(81):
		raw,column = divmod(i,9)
		if table[raw][column] == 0:
			table[raw][column] = int(password[i])
		else:
			if table[raw][column] != int(password[i]):
				return False
	if (checkLines(table) == False): return False
	if (checkColumns(table) == False): return False
	if (checkSquares(table) == False): return False

	#http://www.sudoku-solutions.com/
	#482167953963852147157493826349281675526974381871536492694715238738629514215348769
	#ctfzone{1_v3ry_l1k3_5ud0ku_9am3!}


	return True

def computeFlag(key):
	cryptedflag = [0x42, 0xae, 0x22, 0x8f, 0xb8, 8, 0xd4, 0x19, 0x98, 11, 0x44, 0xb8, 0x9c, 0x1d, 0xe2, 0xeb,
	 0x45, 0x55, 0x1d, 40, 150, 0x5d, 230, 0x6d, 0xda, 0xc0, 0xac, 220, 0x6f, 190, 0x5d, 0x34, 0x39]
	flag = []
	bkey = []
	while key!=0:
		bkey.append(key%256)
		key=key/256
	for i in range(len(cryptedflag)):
		flag.append(cryptedflag[i]^bkey[i])
	return bytearray(flag)
	

Application.EnableVisualStyles()
Application.SetCompatibleTextRenderingDefault(False)
form = SNForm()
Application.Run(form)
