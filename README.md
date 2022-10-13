# Inventar
 
![project-2](https://user-images.githubusercontent.com/42244235/195608736-364d099f-e041-4825-bbaf-cba8de5d3598.png)

Hva er Inventar?
=============

Da jeg jobbet som teknikker i Holmestrand Datasenter så oppdaget jeg at måten vi kommuniserte og holdt kontroll på hvor mange deler var på de forskjellige lokasjonene, så hadde vi bare ett excel ark som ingen brukte.

Vi hadde store problemer med å holde "kontroll" på hvem som hadde hva, og vi måtte ofte sende hverandre meldinger som typ "Har dere en iPhone 8 Skjerm OEM?" og vente på svar mens kunden var ved disken vår. Veldig lite effektivt.

Så jeg tok meg på ansvar og lage et inventar program som gjorde nettopp dette, + en hel haug med andre ting.

Inventar holder styr på hvilke deler vi har på hvilke lokasjoner, samt et kontrollpanel for å bestille flere deler av den delen, eller bruke hurtiglenke til vår leverandør som har den delen.

Du kan også resevere deler til en avdeling fra en annen ved bruk av dette systemet, samt å printe ut sakslapper.

Prosjekt Oppsett
-------------

Programmet er skrevet i C# hvor jeg bryker costura fra Fody for å sette alle filer internt, samt MySql.Data for sql.
For .NET skin bruker jeg materialskin som jeg liker veldig godt til mine programmer.

Databasen er en hjemmehostet database da dette ikke var i produksjon og var egentlig noe jeg bare hadde det morro med for å lære, men daglig leder kalte det "genialt".

Dessverre så ble bedrift konkurs og bruken for programmet forsvant.

![image](https://user-images.githubusercontent.com/42244235/195610290-1a6bbf5e-a295-4d32-9229-899747568e3e.png)
![image](https://user-images.githubusercontent.com/42244235/195610609-6e4ae0d8-96bd-48e7-a901-3ece15c90a97.png)
![image](https://user-images.githubusercontent.com/42244235/195610672-045b624d-55ac-4d88-8e9c-a8b70c2aa4b4.png)

# Koden til prosjektet er tilgjengelig i denne github repoen.
