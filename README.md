# FootballLiveCheck 
Proiectul isi propune  implementarea unei aplicatii web de scoruri si rezultate live din fotbal.
Utilizatorul va fi notificat in timp real de situatia partidei in care joaca echipa favorita, vizualiza statistici despre meciurile precedente, clasamente, are acces la o camera de chat in care poate comunica cu restul utilizatorilor.

Extra : adaugarea unui serviciu  de estimare a rezultatului unei partide  in functie de storicul meciurilor, valoarea echipei, forma etc.

## Structura Proiectului -> 3 Layere : 
### Core :  ->3 proiecte : 
* Domain   	-> Entitati, Interfetele la repositories, Enums
* Bussiness	-> Comenzi, Queriuri, Modele(DTO's), Servici etc
* CQRS		-> Interfete de CQRS
### Infrastructures	(tot ce depinde de un 3rd party)	-> 2 proiecte :
* Configurations	
* DataAccess       ->Implementari ale repositoriurilor
### Presentation    	->2 proiecte   
* Service	->  Api-ul
* WEB	->Hostul pt proiectul de Angular

