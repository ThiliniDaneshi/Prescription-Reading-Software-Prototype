# -*- coding: utf-8 -*-
"""
Created on Tue Sep 24 10:22:39 2019

@author: acer
"""

# First letters of name is must
import csv

def showname(nlist):
    names={} 
    m=0
    for m1 in range(len(nlist)):
        names[m]=nlist[m1][0]
        m=m+1
    return names 
   
def noduplicates(alist):
    for x in range(1, len(alist)):      #remove duplicate names
        if(alist[x] == alist[x-1]):
            alist.pop(x-1)       
    return alist      

def printlist(plist):
    for p in plist:
        print (plist[p])
        
'''
    names = list(dict.fromkeys(names))
    print(names)
'''   
isnew='true' 
if(isnew=='false'):
    print("Search for next Medicine")
    isnew='true'
while(isnew=='true'):
    with open("MedicinesDb.csv", "r") as data:
        reader = csv.reader(data)
        #checkmid=input("Enter any middle letters of the medicine :") 
        list0={}
        list1={}
        list2={}
        list3={}
        j0=0
        j1=0
        j2=0
        j3=0
        done='false'
        checkfront=input("Enter start letters of the medicine : ")
  
     
        for row in reader:
            name=row[0]
            for i in range(0,len(checkfront)):    #by first letters
                if (checkfront[i].casefold() == name[i].casefold()):
                    i=i+1
                    done='true'
                else:
                    done='false'
                    break
            if(done=='true'):
                list0[j0]=row
                j0=j0+1
        print(list0)
        print("_______________________________________________________")
        list00=showname(list0)
        print(list00)
        print("_______________________________________________________")
        list00=noduplicates(list00)
        print(list00)
        print("_______________________________________________________")
        print("By first few letters")
        printlist(list00)            

        if(len(list0)>1): 
            checkback=input("Enter last letter of the medicine : ")
            if(checkback !=" "):
                for inlist0 in list0:
                    name=list0[inlist0][0]
                    l=len(name)
                    if(checkback==name[l-1]): # by last letter
                        list1[j1]=list0[inlist0]
                        j1=j1+1  
                    else:
                        continue
            else:
                list1=list0
            print(list1)    
            print("_______________________________________________________")
            list11=showname(list1) 
            print(list11)
            print("_______________________________________________________")
            list11=noduplicates(list11)
            print("By last few letters")
            printlist(list11)   
            print("_______________________________________________________")
        else:
            printlist(list00)
            isnew='false'
            print("search complete")
            break
  
        if(len(list1)>1):
            checkdose=input("Enter the dose: ")
            if(checkdose!=""):
                for inlist in list1:
                    dose=list1[inlist][2]
                    if(checkdose==dose):   #By dose
                        list2[j2]=list1[inlist]
                        j2=j2+1
                    else:
                        continue
            else:
                list2=list1
            list22=showname(list2)
            list22=noduplicates(list22)
            print("By dose")
            printlist(list22) 
        else:     
            printlist(list11)
            isnew='false'
            print("search complete")
            break

        if(len(list2)>1):
            checkAge=int(input("Age of the patient:"))
            if(checkAge!=""):
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
                        continue
            else:
                list3=list2
            list33=showname(list3)
            list33=noduplicates(list33)
            print("By age")
            printlist(list33)
        else:
            printlist(list22)
            isnew='false'
            print("Search complete")
            break            
    
print("____________")    

data.close()      