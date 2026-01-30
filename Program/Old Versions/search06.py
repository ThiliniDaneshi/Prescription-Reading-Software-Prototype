import csv

with open("MedicinesDb.csv", "r") as data:
  reader = csv.reader(data)
  checkfront=input("Enter start letters of the medicine : ")
  #checkmid=input("Enter any middle letters of the medicine :")
  checkback=input("Enter last letter of the medicine : ")
  checkdose=input("Enter the dose: ")
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
      age=row[8]
      l=len(name)
      #while (done==false):
      # filter by first letters
      for i in range(0,len(checkfront)):
          if (checkfront[i]==name[i]):
              i=i+1
              done='true'
          else:
              done='false'
              break
      if(done=='true'):
          if((checkback==name[l-1])):     # Filter by last letter
              if(checkdose==dose):
                  list1[j]=row
                  j=j+1
      
for x1 in range(len(list1)):
    print(list1[x1])
print("____________")    


        
    
data.close()      