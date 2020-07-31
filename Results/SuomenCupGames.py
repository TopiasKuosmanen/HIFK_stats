import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

Data = pd.read_csv('SuomenCup2017to2020.csv', encoding='latin-1', 
                   usecols = ['Id', 'Opponent', 'DateTime', 'Result', 'ResultCode', 
                              'Stadion', 'Home_match'])
# CONVERTING DATETIME TO Datetime64-type
from datetime import datetime
df = pd.DataFrame({'Time':['28.9.2019 14.00.00']},index=['tst'])
from functools import partial
to_datetime_fmt = partial(pd.to_datetime, format='%d.%m.%Y %H.%M.%S')
Data['DateTime'] = Data['DateTime'].apply(to_datetime_fmt)

Data['Year'] = Data['DateTime'].dt.strftime('%Y')
Data['Year'] = Data['Year'].astype(int)




Data1 = Data.where(Data['ResultCode'] == 0)
Ties = Data1.dropna()
Data2 = Data.where(Data['ResultCode'] == 1)
Wins = Data2.dropna()
Data3 = Data.where(Data['ResultCode'] == 2)
Losses = Data3.dropna()

TYear = Ties.groupby(['Year']).count()
WYear = Wins.groupby(['Year']).count()
LYear = Losses.groupby(['Year']).count()





print(TYear)

print(WYear)

print(LYear)

plt.figure(figsize=(4,4))
plt.plot(TYear['ResultCode'].value_counts(), label='Tasapelit', color='yellow')
plt.plot(WYear['ResultCode'].value_counts(), label='Voitot', color='green')
plt.plot(LYear['ResultCode'].value_counts(), label='Häviöt', color='red')
plt.legend()
plt.xlim(2017,2020)
plt.ylim(0,8)
ax = plt.subplot(111)
ax.bar(TYear.index, TYear['ResultCode'].values, color='yellow', align='center', width=0.2)
ax.bar(LYear.index, LYear['ResultCode'].values, color='red', align='center', width=0.2)
ax.bar(WYear.index, WYear['ResultCode'].values, color='green', align='center', width=0.2)
plt.xlabel('Kausi')
plt.ylabel('Ottelut')
plt.title('HIFK:n Veikkausliiga-ottelut 2019')
plt.show()
#count_row = Losses.shape[0]


'''
N = 3
ind = np.arange(N)
plt.figure(figsize=(12,8))
width = 0.2

fig = plt.figure()
ax = fig.add_subplot(111)

yvals = TMonth['ResultCode']
rects1 = ax.bar(ind, yvals, width, color='yellow')
zvals = WMonth['ResultCode']
rects2 = ax.bar(ind+width, zvals, width, color='green')
kvals = LMonth['ResultCode']
rects3 = ax.bar(ind+width*2, kvals, width, color='red')

ax.set_ylabel('Scores')
ax.set_xticks(ind+width)
ax.set_xticklabels(4,10)
ax.legend( (rects1[0], rects2[0], rects3[0]), ('Tasapelit', 'Voitot', 'Tappiot') )

def autolabel(rects):
    for rect in rects:
        h = rect.get_height()
        ax.text(rect.get_x()+rect.get_width()/2., 1.05*h, '%d'%int(h),
                ha='center', va='bottom')

autolabel(rects1)
autolabel(rects2)
autolabel(rects3)

plt.show()
'''




