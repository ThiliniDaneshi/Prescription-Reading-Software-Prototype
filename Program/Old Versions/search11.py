# First letters of name is must
import csv

def showname(nlist):
    names={}        
    for n in range(len(nlist)):
        medrow=nlist[n]
        for m in range(len(medrow)):
            names[n]=medrow[0]
    return names 
   
def noduplicates(alist):
    alist1=showname(alist)
    for x in range(1, len(alist1)):      #remove duplicate names
        if(alist1[x] == alist1[x-1]):
            alist.pop(x-1)       
    return alist      

def printlist(plist):
    for p in plist:
        print (plist[p])
        
'''
    names = list(dict.fromkeys(names))
    print(names)
'''    

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
'''  
  list11=showname(list1) 
  printlist(list11)           
'''  
  list1=noduplicates(list1)
  list11=showname(list1)  
  printlist(list11)
  if(len(list1)>1):
      checkdose=input("Enter the dose: ")
      for inlist in list1:
          dose=list1[inlist][2]
          if((checkdose==dose) or checkdose==""):   #By dose
              list2[j2]=list1[inlist]
              j2=j2+1        
  else:     
      names1=showname(list1)
      printlist(names1)
  
#test
  list22=showname(list2)
  printlist(list22)          
  
  list2=noduplicates(list2)
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
      names2=showname(list2)
      printlist(names2)            
  #test
  list33=showname(list3)
  printlist(list33)    
    
print("____________")    

data.close()      