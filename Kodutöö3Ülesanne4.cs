//1. Kirjutage lühike ülevaade Ternary Search algoritmist, sealhulgas selle põhiprintsiibid ja pseudo-koodi näide.

/* Kolmekordne otsing on algoritm, mis järgib sama põhimõtet nagu kahendotsing, kuid kasutab selle asemel kolme võrdse suurusega segmenti. 
See töötab ka ainult sorteeritud loendite puhul.
*/


//2. Võrrelge Ternary Search'i ja Binary Search'i aegkomplekssust. (Kas mõõdetud tulemus, teoreetiline võrdlus, vms)

/* Ternaarse otsingu korduvustermin on 4clog3(n) + O(1) (kus c on konstant) ja binaarse puhul on see 2clog2(n) + O(1) (kus c on konstant) 
pärast nende terminite arvutamist saame tulemuseks 2,885*ln(n) kahendotsingu jaoks ja 3,6408*ln(n) kolmendotsingu jaoks, mis tõestab, et binaarne on kiirem.
*/


//3. Arutlege lühidalt, kas Binary Search on üldiselt tõhusam kui Ternary Search ning millistes olukordades.
