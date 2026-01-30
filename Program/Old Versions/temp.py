import pandas as pd
import pandas as pd  
import numpy as np  
import matplotlib.pyplot as plt 
  
# reading csv file from url  
data = pd.read_csv("C:/Users/acer/AppData/Local/Programs/Python/Python37-32/Medicines.csv") 

words = ["Amoxicillin","Amox"]
found = {}
for line in data:
    str1,strength=line.split()
    for w in words:
        if w in str1:
            print ("Yes")
            found[w]=str1
            break

print(found)