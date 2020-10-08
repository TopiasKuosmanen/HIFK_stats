import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

Data = pd.read_csv('VeikkausliigaGoals2020.csv', encoding='latin-1', 
                   usecols = ['Id', 'Winner', 'Penalty', 'FirstName', 
                              'LastName', 'Minute', 'AssistFirstName', 'AssistLastName'])

Data['FirstName'] = Data['FirstName'].astype(str)
Data['LastName'] = Data['LastName'].astype(str)
Data['AssistFirstName'] = Data['AssistFirstName'].astype(str)
Data['AssistLastName'] = Data['AssistLastName'].astype(str)

print(Data.dtypes)
Data1 = Data.where(Data['Minute'] < 16)
first = Data1.dropna()
Data2 = Data.where((Data['Minute'] < 31) & (Data['Minute'] > 15))
second = Data2.dropna()
Data3 = Data.where((Data['Minute'] < 46) & (Data['Minute'] > 30))
third = Data3.dropna()
Data4 = Data.where((Data['Minute'] < 61) & (Data['Minute'] > 45))
fourth = Data4.dropna()
Data5 = Data.where((Data['Minute'] < 76) & (Data['Minute'] > 60))
fifth = Data5.dropna()
Data6 = Data.where(Data['Minute'] > 75)
sixth = Data6.dropna()

print(len(first.index))
print(len(second.index))
print(len(third.index))
print(len(fourth.index))
print(len(fifth.index))
print(len(sixth.index))

x = ['0-15', '16-30', '31-45', '46-60', '61-75', '76-90']
x_index = np.arange(len(x))


palkit=[len(first.index), len(second.index), len(third.index), 
        len(fourth.index), len(fifth.index), len(sixth.index)]
plt.bar(x, palkit, color=("skyblue"), align="center")
plt.xlabel("Peliminuutti")
plt.ylabel("Ottelut")
plt.title("HIFK:n Veikkausliigamaalit minuuttijaoilla 2015-2020")
plt.xticks(x_index, x, rotation=10)



