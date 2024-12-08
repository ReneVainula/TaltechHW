// 1. Kirjutage lühike ülevaade Jump Search algoritmist, sealhulgas selle põhiprintsiibid ja pseudo-koodi näide.

// Hüppeotsing on lineaarse otsingu algoritmi modifikatsioon, kus sammuks on number k, mitte 1, et lubada algoritmi, nii et ebaolulised numbrid jäetakse kiiremini vahele. Aja keerukus on O(n/k)


//2. Võrrelge Jump Search'i ajalist komplekssust Linear Searchi ja Binary Searchiga.

/* samas indeks loendis:
 kui number > loend[indeks]
  indeks += hüpe
 muidu lineaarne otsing viimane hüpe
 */


//3. Arutlege lühidalt stsenaariumide üle, kus Jump Search võib olla efektiivsem võrreldes Linear Searchi ja Binary Searchiga.

/* Hüppeotsing on alati tõhusam kui lineaarne otsing, kui otsitav väärtus pole esimeses hüppes. 
Hüppeotsing on nii keskmise kui ka halvima stsenaariumi korral halvem kui binaarne otsing, nii et see oleks kiirem ainult siis, kui see tabab väärtust otse esimestel hüpetel.
*/
