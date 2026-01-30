# -*- coding: utf-8 -*-
"""
Created on Thu Aug  8 21:20:49 2019

@author: acer
"""


import csv

with open("MedicinesDb.csv", "r") as data:
  reader = csv.reader(data)
  print("Age of the patient:")
  response1=input()
  checkAge=int(response1)
  checkfront=input("Enter start letters of the medicine : ")
  checkmid=input("Enter any middle letters of the medicine :")
  checkback=input("Enter last letter of the medicine : ")
  if(checkAge>65):
      age="Elderly"
  if(checkAge<=65 and checkAge>=18):
      age="Adult"
  if(checkAge<18):
      age="child"
  
  t=0  
  t2=0
  list1={} 
  list2={}
  list3={}
  for row in reader:
      idM=row[0]
      fname=row[1]
      sname=row[2]
      dose=row[3]
      dform=row[5]
      route=row[4]
      freq=row[6]
      usetime=row[7]
      age=row[8]
      
      for i in range(len(checkfront)):
          if(checkfront[i]==fname[i]):
              list1[t]=idM
              t=t+1
              
  for rows in reader:
      idMs=rows[0]
      for x in range(0,len(list1)):
          if(list1[x]==idMs):
              print(rows)  
        
print("Search complete") 
data.close()      