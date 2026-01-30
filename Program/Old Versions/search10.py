# First letters of name is must
import csv

def printme(nlist):  
    names={}
    n=0        
      # get names only
    medname=nlist[0]
    while(n<len(nlist)):
        names[n]=medname
        n=n+1
        
    for x in range(1, len(names)):      #remove duplicate names
        if(names[x] == names[x-1]):
            names.pop(x-1)
    for x0 in range(len(names)):
        print(names)    

with open("MedicinesDb.csv", "r") as data:
  reader = csv.reader(data)
  #checkmid=input("Enter any middle letters of the medicine :") 
  list1={}
  list2={}
  list3={}
  j1=0
  j2=0
  j3=0
  done='false'
  checkfront=input("Enter start letters of the medicine : ")
  checkback=input("Enter last letter of the medicine : ")
 
  for row in reader:
      name=row[0]
      l=len(name)
      for i in range(0,len(checkfront)):    #by first letters
          if (checkfront[i].casefold() == name[i].casefold()):
              i=i+1
              done='true'
          else:
              done='false'
              break
      if(done=='true'):
          if((checkback==name[l-1]) or (checkback=="")): # by last letter
              list1[j1]=row
              j1=j1+1
              
  print("First")
  for y1 in list1:
      printme(list1[y1])  
  
  if(len(list1)>1):
      checkdose=input("Enter the dose: ")
      for inlist in list1:
          dose=list1[inlist][2]
          if((checkdose==dose) or checkdose==""):   #By dose
              list2[j2]=list1[inlist]
              j2=j2+1
              print(inlist)
  else:
      printme(list1)
  
  print("Second")    
  for y2 in list2:
      printme(list2[y2])      
  
  if(len(list2)>1):
      checkAge=int(input("Age of the patient:"))
      if(checkAge>65):
          cAge="Elderly"
      if(checkAge<=65 and checkAge>=18):
          cAge="Adult"
      if(checkAge<18):
          cAge="child"  
      for inlist2 in list2:
          rowAge=list2[inlist2][7]       
          if(cAge==rowAge):             #by age    
            list3[j3]=list2[inlist2]
            j3=j3+1
  else:
      printme(list2)            
  
  print("Third")  
  for y3 in list3:
      printme(list3[y3])    
    
print("____________")    

data.close()      