# -*- coding: utf-8 -*-
"""
Created on Wed Aug 28 19:48:25 2019

@author: acer
"""

# -*- coding: utf-8 -*-
"""
Created on Thu Aug  8 23:25:17 2019

@author: acer
"""

# -*- coding: utf-8 -*-
"""
Created on Thu Aug  8 23:05:22 2019

@author: acer
"""
# First letters of name and Age is must

import csv

with open("MedicinesDb.csv", "r") as data:
  reader = csv.reader(data)
  
  
  print("Age of the patient:")
  response1=input()
  checkAge=int(response1)
  
  checkfront=input("Enter start letters of the medicine : ")
  #checkmid=input("Enter any middle letters of the medicine :")
  checkback=input("Enter last letter of the medicine : ")
  checkdose=input("Enter the dose: ")
  
  if(checkAge>65):
      cage="Elderly"
  if(checkAge<=65 and checkAge>=18):
      cage="Adult"
  if(checkAge<18):
      cage="child"
  
  list1={}
  list2={}
  list3={}
  i=0
  j=0
  k=0
  l=0
  done='false'
  done2='false'
  done3='false'
  for row in reader:
      name=row[1]
      idM=row[0]
      dose=row[3]
      rowAge=row[8]

      l=len(name)
      
      for i in range(0,len(checkfront)):    # by first letters
          if (checkfront[i].casefold() == name[i].casefold()):
              i=i+1
              done='true'
          else:
              done='false'
              break
      if(done=='true'):
          if((checkback==name[l-1]) or (checkback=="")): # by last letter    
              if((checkdose==dose) or checkdose==""):   #By dose
                  if(cage==rowAge):                     #by age
                      list1[j]=row[1]
                      j=j+1
      list(set(list1))
           
for x1 in range(len(list1)):
    print(list1[x1])
    
print("____________")    

data.close()      