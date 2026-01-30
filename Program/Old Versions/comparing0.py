# -*- coding: utf-8 -*-
"""
Created on Wed Aug 28 20:38:56 2019

@author: acer
"""
import csv

fields={'Aaa','Bbb','Ccc','Ddd'}

with open(r'Combinations.csv', 'a') as com:
    writer = csv.writer(com)
    writer.writerow(fields)