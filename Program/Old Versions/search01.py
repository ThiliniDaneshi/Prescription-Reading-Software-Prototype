import csv

with open("Medicines.csv", "r") as data:
  datareader = csv.reader(data)
checkfront=input("Enter start letters of the medicine : ")
checkmid=input("Enter any middle letters of the medicine :")
checkback=input("Enter last letters of the medicine : ")

  for row in datareader:
      id,name,strength=row.split(',')
      #Id,title = row[0:1]
      for name in row:
          print(id)
          if (checkfront in s[0]):
              print(row)
data.close()      
    
    