 //  1. Rakendage Linear Search algoritm vabalt valitud programmeerimiskeeles. Kasutusel C#

static int Find(List<int> list, int value) {
    for (int i = 0; i < list.Count; i++) {
        if (list[i] == value) return i;
    }
    return -1;
}


 /* 
 2. Analüüsige oma algoritmi aja- ja ruumikomplekssust.

O(n) keerukus ühe ahela olemasolu tõttu


3. Arutlege lühidal, kuidas Linear Search algoritmi saab kasutada reaalmaailma
rakendustes ja millised on selle piirangud.

Lineaarset otsingualgoritmi saab kasutada telefoninumbri leidmiseks telefonist, kasutades näiteks kontakti nime.
*/

