*Byggt en Klient serverapplikation kommunicera b�de TCP och UDP.*


*Har skapat 4 KLasser*


# Tcpserver: 
   **-F�r att kuuna �verf�ra data �ver n�tverk l�ngsamt  men garanterar att tas i r�tt ordning ordning och s�ker.**

   **-N�r vi k�r den metoden (Tcpserver.start) Tcpserver  v�ntar p� en klient och skriver ut vad den klienten skickar.**
# Udpserver:
   **-F�r att kunn� �verf�ra data �ver n�tverk  snabbt och enkelt men garanterar inte att tas i r�tt  ordning och os�ker.**
   
   **-N�r vi k�r den metoden tas i mot massa meddelande det kan komma fr�n olika st�lle eller  ett st�lle.**
# Client:
   **-Har skapat tv� metoder:**   
   ### Sendtcpsmessage: Startar up en Tcpklient det konekter anslutning till ip adressen

   ### SendudpMessage:  Startar up en Udpklient det konekter anslutning till ip adressen

# Settings:
   **-Har skapat tv� variable f�r att anv�nda samma port och sen arvat till Tcpserver och Udpserver.**



   # Program.cs
   **-I Program.cs:Har jag skapat en input f�llt som man v�ljer 1 till 4 val.i f�rsta valet Tcpserver startar och tredje valet b�rjar kommunicera mellan Tcpserver och klaient.**
   **-Val 2 startar Udpserver och i 4 val b�rjar kommunicera mellan Udpserver och klaient.**
