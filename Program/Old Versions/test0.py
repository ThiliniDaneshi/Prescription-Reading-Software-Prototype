import csv

with open("Medicines.csv", "r") as data:
    datareader = csv.reader(data)
    for row in datareader:
        print(id)
        print(name[0])
        print(type(name[0]))
        
data.close()      
    
    