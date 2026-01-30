import csv

with open("Medicines.csv", "r") as data:
  reader = csv.reader(data)
  checkfront=input("Enter start letters of the medicine : ")
  #checkmid=input("Enter any middle letters of the medicine :")
  checkback=input("Enter last letter of the medicine : ")
  list1={}
  list2={}
  i=0
  j=0
  k=0
  l=0
  done='false'
  done2='false'
  for row in reader:
      name=row[1]
      #while (done==false):
      for i in range(0,len(checkfront)):
          if (checkfront[i]==name[i]):
              i=i+1
              done='true'
              continue
          else:
              done='false'
      if(done=='true'):
          list1[j]=name
          j=j+1
  for x in range(len(list1)):  
      print(list1[x])            
"""
      for ele in list1:
          for k in range(0,len(checkback)):
              if(checkback[k]==ele[len(ele)-1]):
                  k=k+1
                  done2='true'
                  continue
              else:
                  done='false'
          if(done=='true'):
              list2[l]=ele
              l=l+1
  for x in range(0,len(list2)):
        print(list2[x])           
"""            
print("Search complete")            
data.close()      
    
    