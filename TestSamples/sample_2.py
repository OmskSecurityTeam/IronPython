import sys, System
from itertools import product
from binascii import *

def HelloWorld():
	return "Hello, World!"

class Myclass:
	var_a  = var_b = 0
	
	def __init__(self, init_num=251):
		self.var_a, self.var_b = divmod(init_num,47)

	def mysum(self, a, b):
		c=50
		return (a+b)*c

if __name__=="__main__":
	obj_my_class = Myclass()
	obj_my_class.mysum(100,200)
	for i in xrange(5): HelloWorld()
	l=[i for i in xrange(1,5)]
	l.append(8)
	print l.index(4)
	print l[2]
	
	