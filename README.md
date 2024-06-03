# Om uppgiften

I denna Övning kommer du att bygga en applikation som arbetar mot en bok databas för ett bibliotek.
En MVC applikation ska vara ansvarig för att behandla och leverera data som finns i databasen.

- [x]  Du behöver en tabell för att jobba med kunder och det borde vara Customer som model.
- [x]  Du ska ha minst fyra eller fler fält i Customer-klassen.
- [x]  Kolumnerna skall formateras i modellerna t.ex. kan Customer.name vara Required , StringLenght, Min=16 och Max = 50 
	
- [x]  En Customer kan låna en eller flera böcker. En bok kan lånas av många Customers
- [x]  Det måste gå att se om en bok är återlämnad oberoende av lånetiden.

- [x]  Du ska bygga tabellerna med hjälp av EF.
- [x]  Du kan skapa exempeldata när tabellen skapas.


- [x]  Du ska hämta alla Customers som är i DB

- [x]  Du ska kunna hämta en specifikt Customer, det går bra med att hämta via Id om det blir för svårt.

- [x]  Vi vill kunna editera , skapa och ta bort en Customer .

- [x]  Vi vill se alla böcker som en Customer har lånat.