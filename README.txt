----- valYOU -----

--- Alapötlet, cél ---

Az program célja, hogy egy weboldalt és telefonos alkalmazást imitáljon, amelyben a felhasználók regisztrálhatnak, amelyet követően megtekinthetik két dátum között az adott pénznem magyar forintban vett árfolyamának alakulását (táblázatos és diagram formában). A regisztrációval és árfolyamokkal kapcsolatos információkat le is lehet tölteni többféle fájlformátumokban.
Különböző tesztelési funkciók is rendelkezésre állnak, mint például a program indításakor megjelenő PIN-kód beviteli felület, egy teszt felhasználó hozzáadása, vagy egy/több felhasználó táblázatból való törlése, de fontos még kiemelni a regisztrációs felülethez tartozó Unit teszteket is.





--- Tervezett funkciók ---

A program a working directoryban elhelyezkedő ikonnal is elindítható.



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

A program ezen szekciójában lehet megtekinteni két dátum között egy adott pénznemet kiválasztva annak árfolyamának forintban vett alakulását. A program az adatokat az MNB webszolgáltatásából olvassa be. 
Mindez látható DataGridView és Chart formában is.
Alapesetben a kiválasztott valuta: EUR, a kiválasztott kezdő és záró dátumok: 2020.01.01. és 2020.01.31.
A DataGridViewnál az adatokat nem lehet szerkeszteni, illetve nem lehet új sort hozzáadni. Az adott szűrési feltételek mellett a legalacsonyabb értékű forintban vett érték sora zöld színű, míg a legmagasabb értékű pirossal van jelezve. Ez a két érték, és az átlagos érték a DataGridView felett is látható Labelökön. Ha csak 0-ás értékek láthatóak, vagy csak egy sor létezik, akkor fehér marad mindegyik sor. Hibás szűrésnél/üres sorok esetén az említett Labelök mindegyike az "N/A" értéket adja vissza. A hibákat a fogaskerék mellett található piros felkiáltójel mutatja. Az egyik dátumra, vagy a ComboBox-ra való kattintáskor eltűnik a hibakiírás.
A jobb oldalt lévő Chart megjelenése a bal oldali adatokhoz igazodik.
A DataGridView adatai letölthetőek CSV, Excel és PDF formátumokban. Minden egyes letöltésnél megjegyzi az előző mentési útvonalat és ha már létezik ugyanilyen nevű fájl, akkor törli. Nem lehetséges az export, ha: üres a DataGridView, vagy a megadott útvonal nem létezik.
A Chart is letölthető PNG, vagy JPG formátumban. Itt is megjegyzi az előző mentési útvonalat és törli az ugyanilyen nevű fájlt, ha létezik. Itt sem lehetséges az export, ha: üres a DataGridView/egy sor áll rendelkezésre, vagy a megadott útvonal nem létezik.



- Regisztracio.cs -

Ezen felület segítségével valósíthatók meg a regisztrációs és exportálási folyamatok, illetve a felhasználók törlése és teszt felhasználó hozzáadása. A bal oldalt található DataGridView nem szerkeszthető és nem lehet sort hozzáadni.
A mezők helyes kitöltését követően az alul lévő "+" ikonra kattinva a felhasználó bekerül a DataGridViewba (a Nemet nem szükséges magadni). Nem kerülhet be user, ha: nincsenek elfogadva a felhasználási feltételek, helytelenek a formátumok, kitöltetlenek a mezők, vagy a két E-mail cím és jelszó mező nem egyezik meg.
A TextBoxokba való íráskor piros színű az adott mező, ha nem felel meg a megadott formátumnak, és zöld, ha megfelel.
A jelszó és PIN-kód mezők alapvetően elrejtik a bevitt karaktereket, viszont a mellettük lévő CheckBoxok segítségével láthatóvá lehet tenni az említett mezők karaktereit.
A név mezőbe csak az ABC betűi kerülhetnek,  míg a PIN-kód és telefonszám mezőkbe csak számok. A PIN-kódhoz tartozó mezőhöz 8 számjegyet lehet írni, a telefonszámhoz 9-et.
A "?" gombra kattintva további információk találhatók meg a helyes formátumokkal kapcsolatban. Az esetleges hibákról a a jobb alsó sarokban lévő fogaskerék melletti hibaüzenet értesít.
Bármelyik Controlra kattintva az említett hibaüzenet eltűnik.
A helyes kitöltést követően a "+" gombra kattintva a DataGridViewba való bekerülés mellett minden Formon lévő Control fehér lesz és tartalmuk kiürül, illetve a bevitt adathoz igazodva változik az oszlopok szélessége.
Az "X" gomb megnyomása az utóbbiakban említett fehér és üres Controlokat eredményezi, továbbá a hibaüzenet is eltűnik.
A "szemét" gombbal törölhető egy vagy több felhasználó a DataGridViewból (ehhez azonban ki kell jelölni legalább egy egész sort).
A "Teszt user" gombbal azonnal felvehető egy személy a táblázatba, amely az egyes funkciók gyors kipróbálását segíti elő.
Az eddigi felhasználók listáját le lehet tölteni CSV, Excel és PDF formátumokban. Minden egyes letöltésnél megjegyzi az előző mentési útvonalat és ha már létezik ugyanilyen nevű fájl, akkor törli. Nem lehetséges az export, ha: üres a DataGridView, vagy a megadott útvonal nem létezik.



- vY_UnitTest.cs -

A