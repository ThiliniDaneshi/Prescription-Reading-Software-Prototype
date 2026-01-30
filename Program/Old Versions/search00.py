import csv

with open("Medicines.csv", "r") as data:
  datareader = csv.reader(data)
  check=input("Enter start letters of the medicine : ")
  for row in datareader:
      for s in row:
          name=s
          if check in name:
              print(row)
data.close()      
    
    