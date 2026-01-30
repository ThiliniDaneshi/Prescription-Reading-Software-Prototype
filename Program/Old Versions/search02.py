# -*- coding: utf-8 -*-
"""
Created on Sun Jun 30 19:17:22 2019

@author: acer
"""

import csv

with open("Medicines.csv", "r") as data:
  reader = csv.reader(data)
  checkfront=input("Enter start letters of the medicine : ")
  checkmid=input("Enter any middle letters of the medicine :")
  checkback=input("Enter last letters of the medicine : ")
  for row in reader:
      name=row[1]
      l=len(name)
      print(name[0]) 
      print(name[1:l]) #and checkback in name[l-1]):
      print(name)
              #print(l)
  print("Search complete")            
data.close()      
    
    