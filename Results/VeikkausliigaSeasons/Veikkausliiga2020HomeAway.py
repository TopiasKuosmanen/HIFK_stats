import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

Data = pd.read_csv('Veikkausliiga2020.csv', encoding='latin-1', 
                   usecols = ['Id', 'Opponent', 'DateTime', 'Result', 'ResultCode', 
                              'Stadion', 'Home_match'])
# CONVERTING DATETIME TO Datetime64-type
from datetime import datetime
df = pd.DataFrame({'Time':['28.9.2019 14.00.00']},index=['tst'])
from functools import partial
to_datetime_fmt = partial(pd.to_datetime, format='%d.%m.%Y %H.%M.%S')
Data['DateTime'] = Data['DateTime'].apply(to_datetime_fmt)

Data = Data.where(Data['Home_match'] == False)



Data1 = Data.where(Data['ResultCode'] == 0)
TiesX = Data1.dropna()
Data2 = Data.where(Data['ResultCode'] == 1)
WinsX = Data2.dropna()
Data3 = Data.where(Data['ResultCode'] == 2)
LossesX = Data3.dropna()




Ties = len(TiesX.index)
Wins = len(WinsX.index)
Losses = len(LossesX.index)



data = pd.DataFrame({"Voitot": [Wins],
                    "Tasapelit": [Ties],
                    "Tappiot": [Losses]
                    })
x = ['Voitot', 'Tasapelit', 'Tappiot']
y = [0,1,2,3,4,5]
palkit=[int(data["Voitot"].values), int(data["Tasapelit"].values), int(data["Tappiot"].values)]

Points = (Ties) + (Wins * 3)
Games = (Ties + Wins + Losses)
PointsPerGame = Points/Games


x_index = np.arange(len(x))

plt.bar(x, palkit, color=("green","yellow","red"), align="center")
plt.xlabel("")
plt.ylabel("Ottelut")
plt.title("HIFK:n vierasottelut Veikkausliigassa 2020")
plt.xticks(x_index, x, rotation=10)
plt.yticks(y)

plt.text(0, 4.6, ('Pistekeskiarvo ' + str("%.2f" % PointsPerGame)), fontsize = 14)



print(PointsPerGame)
