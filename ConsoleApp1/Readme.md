*Byggt en Klient serverapplikation kommunicera både TCP och UDP.*


*Har skapat 4 KLasser*


# Tcpserver: 
   **-För att kuuna överföra data över nätverk långsamt  men garanterar att tas i rätt ordning ordning och säker.**

   **-När vi kör den metoden (Tcpserver.start) Tcpserver  väntar på en klient och skriver ut vad den klienten skickar.**
# Udpserver:
   **-För att kunná överföra data över nätverk  snabbt och enkelt men garanterar inte att tas i rätt  ordning och osäker.**
   
   **-När vi kör den metoden tas i mot massa meddelande det kan komma från olika ställe eller  ett ställe.**
# Client:
   **-Har skapat två metoder:**   
   ### Sendtcpsmessage: Startar up en Tcpklient det konekter anslutning till ip adressen

   ### SendudpMessage:  Startar up en Udpklient det konekter anslutning till ip adressen

# Settings:
   **-Har skapat två variable för att använda samma port och sen arvat till Tcpserver och Udpserver.**



   # Program.cs
   **-I Program.cs:Har jag skapat en input fällt som man väljer 1 till 4 val.i första valet Tcpserver startar och tredje valet börjar kommunicera mellan Tcpserver och klaient.**
   **-Val 2 startar Udpserver och i 4 val börjar kommunicera mellan Udpserver och klaient.**
