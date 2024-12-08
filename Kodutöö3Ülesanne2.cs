// 1. Kirjutage programm, mis teostab Binary Search'i sorteeritud täisarvude massiivil.

static int BinarySearch(List<int> values, int value) {
    int left = 0, right = values.Count - 1;
    while(left <= right) {
        int mid = (left + right) / 2;
        if (value == values[mid]) return mid;
        else if (value < values[mid]) right = mid - 1;
        else left = mid + 1;
    }
    return -1;
}

// 2. Võrrelge teoreetilises analüüsis valminud Binary Search'i ja Linear Search'i aegkomplekssust.
// 3. Tooge näide stsenaariumist, kus Binary Search on kasulikum kui Linear Search, ja selgitage miks.

/* O(log n) keerukus maksimaalse sammude arvuna on alati 2 lähim aste võrreldes loendi suurusele ümardatuna. 
Näiteks väärtuse leidmine 1000 elemendist koosnevast loendist nõuab lineaarses otsingus kuni 1000 kontrolli, samas kui binaarne otsing tehakse maksimaalselt 10 elemendiga.  
*/
