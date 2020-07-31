import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

Data = pd.read_csv('Veikkausliiga2019.csv', encoding='latin-1', 
                   usecols = ['Id', 'Opponent', 'DateTime', 'Result', 'ResultCode', 
                              'Stadion', 'Home_match'])
# CONVERTING DATETIME TO Datetime64-type
from datetime import datetime
df = pd.DataFrame({'Time':['28.9.2019 14.00.00']},index=['tst'])
from functools import partial
to_datetime_fmt = partial(pd.to_datetime, format='%d.%m.%Y %H.%M.%S')
Data['DateTime'] = Data['DateTime'].apply(to_datetime_fmt)

Data['Month'] = Data['DateTime'].dt.strftime('%m')
Data['Month'] = Data['Month'].astype(int)




Data1 = Data.where(Data['ResultCode'] == 0)
Ties = Data1.dropna()
Data2 = Data.where(Data['ResultCode'] == 1)
Wins = Data2.dropna()
Data3 = Data.where(Data['ResultCode'] == 2)
Losses = Data3.dropna()

TMonth = Ties.groupby(['Month']).count()
WMonth = Wins.groupby(['Month']).count()
LMonth = Losses.groupby(['Month']).count()





print(TMonth)

print(WMonth)

print(LMonth)

plt.figure(figsize=(10,6))
plt.plot(TMonth['ResultCode'].value_counts(), label='Tasapelit', color='yellow')
plt.plot(WMonth['ResultCode'].value_counts(), label='Voitot', color='green')
plt.plot(LMonth['ResultCode'].value_counts(), label='Häviöt', color='red')
plt.legend()
plt.xlim(4,10)
plt.ylim(0,8)
ax = plt.subplot(111)
ax.bar(TMonth.index, TMonth['ResultCode'].values, color='yellow', align='center', width=0.2)
ax.bar(LMonth.index, LMonth['ResultCode'].values, color='red', align='center', width=0.2)
ax.bar(WMonth.index, WMonth['ResultCode'].values, color='green', align='center', width=0.2)
plt.xlabel('Kuukausi')
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




