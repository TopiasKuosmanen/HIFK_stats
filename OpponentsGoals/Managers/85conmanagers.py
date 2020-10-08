import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

DataHonkavaara = pd.read_csv('Honkavaara.csv', encoding='latin-1', 
                   usecols = ['Id', 'Winner', 'Penalty', 'Minute'])
DataMuurinen = pd.read_csv('Muurinen.csv', encoding='latin-1', 
                   usecols = ['Id', 'Winner', 'Penalty', 'Minute'])
DataThodesen = pd.read_csv('Thodesen.csv', encoding='latin-1', 
                   usecols = ['Id', 'Winner', 'Penalty', 'Minute'])
DataKankkunenKeeney = pd.read_csv('KankkunenKeeney.csv', encoding='latin-1', 
                   usecols = ['Id', 'Winner', 'Penalty', 'Minute'])

# Parsitaan data pelkiksi voittomaaleiksi:

Data1 = DataHonkavaara.where(DataHonkavaara['Winner'] == True)
HonkavaaraWinners = Data1.dropna()
Data2 = DataMuurinen.where(DataMuurinen['Winner'] == True)
MuurinenWinners = Data2.dropna()
Data3 = DataThodesen.where(DataThodesen['Winner'] == True)
ThodesenWinners = Data3.dropna()
Data4 = DataKankkunenKeeney.where(DataKankkunenKeeney['Winner'] == True)
KankkunenKeeneyWinners = Data4.dropna()

# Parsitaan maalit, jotka ovat syntyneet 85+ minuutilla

Data5 = DataHonkavaara.where(DataHonkavaara['Minute'] > 84)
Honkavaara85 = Data5.dropna()
Data6 = DataMuurinen.where(DataMuurinen['Minute'] > 84)
Muurinen85 = Data6.dropna()
Data7 = DataThodesen.where(DataThodesen['Minute'] > 84)
Thodesen85 = Data7.dropna()
Data8 = DataKankkunenKeeney.where(DataKankkunenKeeney['Minute'] > 84)
KankkunenKeeney85 = Data8.dropna()


print(len(DataHonkavaara.index))
print(len(DataMuurinen.index))
print(len(DataThodesen.index))
print(len(DataKankkunenKeeney.index))

# Määritellään valmentaja, jonka voittomaaleja käsitellään
Data = HonkavaaraWinners
#Ne maalit, joita halutaan käyttää=
Data9 = Data.where(Data['Minute'] < 16)
first = Data9.dropna()
Data10 = Data.where((Data['Minute'] < 31) & (Data['Minute'] > 15))
second = Data10.dropna()
Data11 = Data.where((Data['Minute'] < 46) & (Data['Minute'] > 30))
third = Data11.dropna()
Data12 = Data.where((Data['Minute'] < 61) & (Data['Minute'] > 45))
fourth = Data12.dropna()
Data13 = Data.where((Data['Minute'] < 76) & (Data['Minute'] > 60))
fifth = Data13.dropna()
Data14 = Data.where(Data['Minute'] > 75)
sixth = Data14.dropna()


# voittomaalien minuuttijako


# 85+ minuutilla syntyneet maalit per valmentaja

x = ['Honkavaara', 'Muurinen', 'Thodesen', 'K&K']
x_index = np.arange(len(x))


palkit=[len(Honkavaara85.index), len(Muurinen85.index), len(Thodesen85.index), 
        len(KankkunenKeeney85.index)]
plt.bar(x, palkit, color=("grey"), align="center")
plt.ylabel("Maalit")
plt.title("85+ minuuteilla päästetyt maalit per valmentaja")
plt.xticks(x_index, x, rotation=10)


