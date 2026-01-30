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
        s=nlist[m1][0]  # + " " + nlist[m1][1]
        names[m]=s
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
        print()
        
'''
    names = list(dict.fromkeys(names))
    print(names)
'''   
searchnext='true'
finish='false' 

while(searchnext=='true'):
    with open("MedicinesDb.csv", "r") as data:
        reader = csv.reader(data)
        #checkmid=input("Enter any middle letters of the medicine :") 
        list0={}
        list1={}
        list2={}
        list3={}
        list4={}
        j0=0
        j1=0
        j2=0
        j3=0
        j4=0
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

        list00=showname(list0)
        list00=noduplicates(list00)
        #print("By first few letters")
        print()
        printlist(list00)            

        if(len(list00)>1): 
            finish='false'
            checkback=input("Enter last letter of the medicine : ")
            if(checkback !=""):
                for inlist0 in list0:
                    name=list0[inlist0][0]
                    l=len(name)
                    if(checkback.casefold()==name[l-1].casefold()): # by last letter
                        list1[j1]=list0[inlist0]
                        j1=j1+1  
                    else:
                        continue
            else:
                list1=list0
        else:
            finish='true'
            printlist(list00)    
            printlist(list0) 

            #print("search complete")
            #break
               
        print("_______________________________________________________")
        list11=showname(list1) 
        #print(list1)
        list11=noduplicates(list11)
        #print("By last letter")
        print()
        printlist(list11) 
        printlist(list1)
      
       
        if(len(list11)>1):
            finish='false'
            checkdose=input("Enter the dose: ")
            if(checkdose!=""):
                for inlist in list1:
                    dose=list1[inlist][2]
                    if(checkdose==dose or dose==""):   #By dose
                        list2[j2]=list1[inlist]
                        j2=j2+1
                    else:
                        continue
            else:
                list2=list1  
                
            printlist(list2)    
            list22=showname(list2)
            list22=noduplicates(list22)
            #print("By dose")
            print()
            printlist(list22)    
        else:     
            finish='true'
            #printlist(list11)
            #print("search complete")
            #break  
            
        list22=showname(list2)
        list22=noduplicates(list22)
        
        if(len(list22)>1):
            finish='false'
            checkAgeS=(input("Age of the patient:"))
            if(checkAgeS!=""):
                checkAge=int(checkAgeS)
                if(checkAge>65):
                    cAge="Elderly"
                if(checkAge<=65 and checkAge>=18):
                    cAge="Adult"
                if(checkAge<18):
                    cAge="child"      
                for inlist2 in list2:
                    rowAge=list2[inlist2][7]       
                    if(cAge==rowAge or rowAge==""):   #by age    
                        list3[j3]=list2[inlist2]
                        j3=j3+1
                    else:
                        continue
            else:
                list3=list2
                
            list33=showname(list3)
            list33=noduplicates(list3)
            print("By age")
            printlist(list33)
        else:
            finish='true'
            #printlist(list22)
            #print("Search complete")
            #break 
        list33=showname(list3)
        list33=noduplicates(list3)
        if(len(list3)>1):
            finish='false'
            checkfreq=(input("Number of doses per day: "))
            checkdoseform=input("Dosage form: ")
            checkroute=input("Administration route: ")
            
            for inlist3 in list3:
                rowfreq=list3[inlist3][5]
                rowform=list3[inlist3][4]
                rowroute=list3[inlist3][3]
                if((checkfreq !="") and ((checkfreq==rowfreq) or rowfreq=="")):
                    list4[j4]=list3[inlist3]
                    j4=j4+1
                else:
                    if((checkdoseform !="") and ((checkdoseform[0].casefold()==rowform[0].casefold()) or rowform=="")): 
                        list4[j4]=list3[inlist3]
                        j4=j4+1
                    else:
                        if((checkroute !="") and ((checkroute[0].casefold()==rowform[0].casefold()) or rowroute=="")):
                            list4[j4]=list3[inlist3]
                            j4=j4+1
                        else:
                            list4=list3
                            continue
                        
            printlist(list4)            
            #list4=showname(list4)
            #list4=noduplicates(list4)
            print("By frequency, dosage form and route")
            printlist(list4)  
        else:
            printlist(list4)
            finish='true'
            #print("Search complete")
            #break
        
        if(len(list4)>1):
            print("Considering combinations of the medicines.....")
            #combinations
            finish='true'
            #break
                  
  
    searchend=input("End of the prescription(y/n)? ")
    print(searchend)
    
    if((searchend==("Y" or "y")) or finish=='true'):
        searchnext = 'false'
        break
    else:
        if(searchend == ("N" or "n")):
            searchnext = 'true'
            print("Searching for next Medicine...")
            continue
        else:
            print("Incorrect input")
            continue
'''            
if(finish=="true"):
    searchnext='true'
    continue
'''          
print("____________")    

data.close()      
