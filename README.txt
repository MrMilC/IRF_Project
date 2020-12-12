--- valYOU ---

- Alapötlet, cél -

Az alkalmazás célja, hogy egy weboldalt és telefonos alkalmazást imitáljon, amelyben a felhasználók regisztrálhatnak, amelyhez egy 8 számjegyű PIN-kód megadása is szükséges. A regisztrációt követően a felhasználók megtekinthetik két adott időpont között az adott pénznem árfolyamának alakulását, illetve egy napot kiválasztva a webszolgáltatásban lévő összes pénznem árfolyamát.





--- Tervezett funkciók ---

A program az working directoryban elhelyezkedő ikonnal is elindítható.



- Belepes.cs -

PIN-kód: 91827364

Az indítást követően első lépésként meg kell adni a további teszteléshez és használathoz szükséges 8 számjegyű PIN-kódot a jobb oldalt látható számozott gombokkal (ezzel az alapvető PIN-kód beírás is tesztelhető, amit leginkább a felhasználók fognak használni).
Gombnyomásra kerül be az adott gombon található szám a bal oldali TextBoxba, amely "elrejti" a benne lévő számokat (betűket nem enged beírni). A TextBox mellett található CheckBox segítségével láthatóvá lehet tenni az eddigi számokat, ha esetleg bizonytalan a bevitel. Az alsó "X" gombbal kitörölhető a TextBox teljes tartalma, továbbá ha a láthatósági CheckBox be van pipálva, akkor azt eltávolítja.
A zöld pipa gombbal tovább lehet lépni a Főmenübe, amennyiben a teszteléshez szánt/helyes kódot adtuk meg. Nem fog tovább engedni, ha: üres a TextBox, nincs meg a 8 számjegy, vagy helytelen a kód.
A TextBox kezdetben fehér színű, viszont a számok megadása közben halvány pirosra vált, ezzel jelezve, hogy nem felel meg a továbbhaladási kritériumoknak. Halvány piros marad, amíg nincs meg a 8 számjegy és fehérré válik, ha megvan (8 számjegy a maximálisan megengedett). Ez azonban nem jelzi a számsorozat helyességét, csak a fentebb található első két hibánál jelez (üres a TextBox, nincs meg a 8 számjegy).
A gyorsabb teszteléshez a bal alsó sarokban lévő FastLogin gombra is rá lehet kattintani a Főmenübe való gyors navigáláshoz a gyorsabb tesztelés érdekében.
A jobb felső sarokban lévő X-szel ki lehet lépni a programból a felugró ablak megerősítését követően.
A helyes kód megadását követően a Főmenü jelenik meg.



- Fomenu.cs -

Ez a Form kizárólag a másik két fő menüponthoz való elnavigálást valósítja meg. A bal oldali gomb az Árfolyamokat jeleníti meg, a jobb oldali pedig a Regisztrációs felületet.



- Arfolyamok.cs (work in progress) -

Az MNB webszolgáltatás beolvasása.
A fent kiválsztott pénznem árfolyamainak magyar forintban vett értékének megjelenítése az első DataGridView-n, jobb oldalt Charton pedig diagram mutatja az árfolyam alakulását.
Ez alatt egy napot kiválasztva válik láthatóvá a webszolgáltatásban lévő összes pénznem árfolyama a második DataGridView-n.
A két DGW által megjelenített adatokat ki lehet exportálni Excel állományba.



- Regisztracio.cs (work in progress) -

Felhasználó regisztrálása (név, email, jelszó, telefonszám, stb.) Regex segítségével
DGW adatainak mentése és kiválasztott egyed törlése
Mentés csv fájlba
Timer: 2 perc tétlenséget követően az eddig megadott új regisztrációs adatok törlése (1 perc tétlenség után figyelmeztetés)
Unit teszt a regisztrációs TextBoxoknál