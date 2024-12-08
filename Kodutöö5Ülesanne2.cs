// Task 2: Theoretical Analysis of Heap Structures

/* 1. Min-kuhi on puustruktuur, kus kõik emasõlmed peavad olema väiksemad kui nende lapsed. 
Maksimaalse kuhja puhul kehtib vastupidine, kõik emasõlmed peavad olema suuremad kui nende lapsed. 
Nii minimaalse kui ka maksimaalse kuhjad puud peavad olema täielikud kahendpuud.

2. Olenevalt nõutavast toimingust on mõlemal kuhjal sarnane ajaline keerukus, nt. keskmine sisestamise juhtum on O(logN), kustutamine on O(logN) ja otsimine on O(N). 
Minimaalse või maksimaalse väärtuse saamine nendes kuhjades on vastavalt O(1) või O(N), kui tüüp ühtib ja kui mitte. 
Mõlema kuhjau ruumiline keerukus on O(N), kuna lisaruumi pole vaja.

3. Kuhjastruktuurid on head andmete sortimiseks, kuna meil on võimalus olemasolevast massiivist kuhja luua.
Kuhjamist kasutades saame selle seejärel kohapeal sorteerida, ilma et oleks vaja lisamälu. 
Kõik kuhjad on osaliselt sorteeritud struktuurid, mille ülaosas on suurim või väikseim prioriteetne üksus. 
See omadus muudab need ideaalseks prioriteetse järjekorra kontseptsiooni jaoks. Kuhi on kasulik, kui peate korduvalt eemaldama kõrgeima või madalaima prioriteediga objekti (kuhja juur).
*/
