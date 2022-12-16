'''
TEORIA W PRAKTYCE 
- matplotlib
- numpy/pandas
Mamy gotową tabelę z imionami zapisaną jako plik w excelu imiona.xlsx
'''
import pandas as pd
import numpy as np
print('\n')

# Odczytajmy tą tabelę z excela i wyświetlmy
df = pd.read_excel('imiona.xlsx') # *argument index_col=0 powoduje znany problem z pandas - pierwsza nazwa kolumny jest brana jako wiersz
print(df)
print('\n')

# -------------------------------------------------------------------------------------------
# Nasza tabela ma braki (NaN), ktore nalezy usunac (wiersze zawierajace braki) lub je uzupelnic.
# Sprawdzmy czy oplaca sie usuwac cale wiesze z tabeli - dowiedzmy sie ile wierszy ma tabela
print(len(df)) # 9
print('\n')
# Nie oplaca sie usuwac calych wierszy, poniewaz jest ich za malo.

# Uzupelnijmy wiec braki w tabeli w kolumnie:
# NAZWISKO
df.loc[df['Imie'] == 'Ewa', 'Nazwisko'] = 'Zabor'

# WIEK
# Sposob 1
#df.iloc[1, 2] = 35
#df.iloc[5, 2] = 35

# Sposob 2
#df.iloc[[1,5], 2] = 35

# Sposob 3
df.iloc[ np.where(df["Wiek"].isna())[0] , 2] = 35

# MIASTO
df.loc[df['Imie'] == 'Ewa', 'Miasto'] = 'Wroclaw'

#print(df)

# ----------------------------------------------------------------------------
# Teraz dodamy nowy wiersz do tabeli:
# Sposob 1
nowy_wiersz = {'Imie': 'Aleksander', 'Nazwisko': 'Hamilton', 'Wiek': 23, 'Plec':'M', 'Miasto': 'Katowice'} # slownik
#df = df.append(nowy_wiersz, ignore_index=True) 

# Sposob 2 -> df.loc[index weirsza] = 0
df.loc[len(df)] = ['Aleksander', 'Hamilton', 23, 'M', 'Katowice']

#print(df)

# Teraz dodamy nowa kolumne do tabeli z zerami:
df['Nowa Kolumna'] = 0

# mozemy w petli wypelniac po kolei nowa kolumne liczbami - kazda wieksza o 2
for i in range(len(df)):
    df.iloc[i, len(df.columns)-1] = i*2

# możemy też zmieniać nazwy kolumn:
df = df.rename(columns = {'Nowa Kolumna': 'Inna nazwa'})

# mozemy usuwac:
df = df.drop('Inna nazwa', axis = 1)        # kolumne 
df = df.drop(9, axis = 0)                   # wiersz 

# mozemy scalac kolumny:
df['| Imie i nazwisko |'] = '|' + df['Imie'] + ' ' + df['Nazwisko'] + '|'
# i rozdzielac kolumny:
df[['czesc1', 'czesc 2']] = df['| Imie i nazwisko |'].str.split(' ', expand=True)

# usuniecie dodanych kolumn
df = df.drop(['| Imie i nazwisko |', 'czesc1', 'czesc 2'], axis=1)

print(df)

# grupowanie i srednia dla danej kolumny
print(df.groupby(['Wiek', 'Imie']).min())
print(df['Wiek'].mean())

# Teraz zapiszemy nasza zmieniona tablice do pliku excel
df.to_excel('imiona_po_zmianiach.xlsx', index=False) # zapisujemy bez indeksow (index=False)

# ----------------------------------------------------------------------------------
# Zrobimy prosty wykres ankietowanych do ich wieku
import matplotlib.pyplot as plt

x = df.sort_values('Wiek')['Imie']
y = df.sort_values('Wiek')['Wiek']

#plt.plot(x,y, color='maroon')                                               # wykres liniowy
plt.bar(x,y, color = 'maroon')                                              # wykres kolumnowy
plt.scatter(len(df)/2, df['Wiek'].mean(), 100, marker='o', color='orange')  #średnia wieku
plt.xlabel('Imie')
plt.ylabel('Wiek')
plt.title("Ankietowani i ich wiek")  
plt.savefig("wykres.jpg", dpi = 72) 
plt.show()






