----- valYOU -----

--- Alapötlet, cél ---

Az program célja, hogy egy weboldalt és telefonos alkalmazást imitáljon, amelyben a felhasználók regisztrálhatnak, amelyet követően megtekinthetik két dátum között az adott pénznem magyar forintban vett árfolyamának alakulását (táblázatos és diagram formában). A regisztrációval és árfolyamokkal kapcsolatos információkat le is lehet tölteni többféle fájlformátumokban.
Különböző tesztelési funkciók is rendelkezésre állnak, mint például a program indításakor megjelenő PIN-kód beviteli felület, egy teszt felhasználó hozzáadása, vagy egy/több felhasználó táblázatból való törlése, de fontos még kiemelni a regisztrációs felülethez tartozó Unit teszteket is.





--- Tervezett funkciók ---

A program az working directoryban elhelyezkedő ikonnal is elindítható.



- Belepes.cs -

PIN-kód: 91827364

Az indítást követően első lépésként meg kell adni a további teszteléshez és használathoz szükséges 8 számjegyű PIN-kódot a jobb oldalt látható számozott gombok segítségével (ezzel az alapvető PIN-kód beírás is tesztelhető, ami leginkább a felhasználók számára hasznos).
Gombnyomásra kerül be az adott gombon található szám a bal oldali TextBoxba, amely "elrejti" a benne lévő számokat (betűket nem enged beírni). A TextBox mellett található CheckBox segítségével láthatóvá lehet tenni az eddigi számokat, ha esetleg bizonytalan a bevitel.
A zöld pipa gombbal tovább lehet lépni a Főmenübe, amennyiben a teszteléshez szánt/helyes kódot adtuk meg. Nem fog tovább engedni, ha: üres a TextBox, nincs meg a 8 számjegy, vagy helytelen a kód.
A TextBox kezdetben fehér színű, viszont a számok megadása közben pirosra vált, ezzel jelezve, hogy nem felel meg a továbbhaladási kritériumoknak. Piros marad, amíg nincs meg a 8 számjegy és zölddé válik, ha megvan (8 számjegy a maximálisan megengedett). Ez azonban nem jelzi a számsorozat helyességét, csak azt jelzi, hogy nem üres a TextBox és hogy 8 számjegy szerepel benne.
Az alsó "X" gombra kattintva a TextBox teljes tartalma kiürül, a színe fehérré válik, továbbá ha a CheckBox be van pipálva, akkor azt eltávolítja.
A gyorsabb teszteléshez a bal alsó sarokban lévő FastLogin gombra is rá lehet kattintani a Főmenü megjelenítéséhez a gyorsabb tesztelés/programhasználat érdekében.
A jobb felső sarokban lévő X-szel ki lehet lépni a programból a felugró ablak megerősítését követően.
A helyes kód megadását követően a Főmenü jelenik meg.



- Fomenu.cs -

Ez a felület kizárólag a másik két fő menüponthoz való elnavigálást valósítja meg. A bal oldali gomb az Árfolyamokat jeleníti meg, a jobb oldali pedig a Regisztrációs felületet.



- Arfolyamok.cs -

A program ezen szekciójában lehet megtekinteni két dátum között egy adott pénznemet kiválasztva annak árfolyamának forintban vett alakulását.
Mindez látható DataGridView és Chart formában is.
Alapesetben a kiválasztott valuta: EUR, a kiválasztott kezdő és záró dátumok: 2020.01.01. és 2020.01.31.
A DataGridViewnál az adatokat nem lehet szerkeszteni, illetve nem lehet új sort hozzáadni. Az adott szűrési feltételek mellett a legalacsonyabb értékű forintban vett érték sora zöld színű, míg a legmagasabb értékű pirossal van jelezve. Ez a két érték, és az átlagos érték a DataGridView felett is látható Labelökön. Ha csak 0-ás értékek láthatóak, vagy csak egy sor létezik, akkor fehér marad mindegyik sor. Hibás szűrésnél/üres sorok esetén az említett Labelök mindegyike az "N/A" értéket adja vissza. A hibákat a fogaskerék mellett található piros felkiáltójel mutatja. Az egyik dátumra, vagy a ComboBox-ra való kattintáskor eltűnik a hibakiírás.
A jobb oldalt lévő Chart megjelenése a bal oldali adatokhoz igazodik.
A DataGridView adatai letölthetőek CSV, Excel és PDF formátumokban. Minden egyes letöltésnél megjegyzi az előző mentési helyet és ha már létezik ugyanilyen nevű fájl, akkor törli. Nem lehetséges az export, ha: üres a DataGridView, vagy a megadott útvonal nem létezik.
A Chart is letölthető PNG, vagy JPG formátumban. Itt is megjegyzi az előző mentési útvonalat és törli az ugyanilyen nevű fájlt, ha létezik. Itt sem lehetséges az export, ha: üres a DataGridView/egy sor áll rendelkezésre, vagy a megadott útvonal nem létezik.



- Regisztracio.cs -

Felhasználó regisztrálása (név, email, jelszó, telefonszám, stb.) Regex segítségével
DGW adatainak mentése és kiválasztott egyed törlése
Mentés csv fájlba
Timer: 2 perc tétlenséget követően az eddig megadott új regisztrációs adatok törlése (1 perc tétlenség után figyelmeztetés)
Unit teszt a regisztrációs TextBoxoknál