# Heading Skibidi-Toilet-Fighter
## MuSCoW
### Musts
- There must be atleast to controlable skibidi-toilets, opponents
- The skibidi-toilets must have a stamina and health bar
- Must regenerate stamina and health via items
- There must be a ranged attack
- There must be a melee attack
### Should
- There should be spawning items randomly
### Could:
- There could be a KO
- The could be an audience for the skibidi-toilets
### Won't have this time:
- Mulitplayer via LAN
- Different camera angles
## Flowdiagram
![Alt text](/Assets/Resources/Flowchart.drawio.png "FlowChart")
## Generel dokumentation
### Piss
For at lave Piss-funktionaliteten er der brugt Unitys partikelsystem; når der hvis der i trykkes space eller venstre muskano spilles partklerne.

I body er der difineret at vhis der rammes med partikler tages der damaga.
### Items
Items fungerer ved at der når et Toilet collider vil der:
- Skabes en ny item med en tilfældig position på banen
- Ødelægges item
- Øges CurrentHealth på Toilettet der collider

For at skabe en ny Item laves der metoden CreatItem(), som instantierer et nyt bottle prefab når den er givet en position til den som parameter.

Da der ønskes at lave en ny postion, indenfor arenaen er VectorGenerator lavet, som laver en ny postion hvor højden er bestemt og hvor x og z er indenfor rækkevidde, derfor returnerer den en vector 3.  

Når der collides med et Toilet tjekkes der om der er snakke om et toilet ved at få componentet fra gameobjectet og putte dne igennem GiveHealth som tager et Toilet som prametre og give tilgåt funktion TakeHEalth under mutanten som har en float som parameter. Derved øges CurrentHealth.
### Toilet
Da der er meget i toilettet gennemgåes der kun det vigtigste her:
- Movement og spillere
- Vigtige variable
#### Movement og spillere
Under Update() ligger der to sæt controls er for:
- PlayerOne
- PlayerTwo
Om det er den enne eller den anden der bevæger sig afhænger af om boolen IsPlayerOne er sandt eller falsk. Samtidig haves der funktionerne for bevægelse som kaldes hvis knapper er trykket.
#### Vigtige variable
Der er en række vitgige variabler:
- MaxHealth er en float der bestemmer hvor meget CurrentHealth må være.
- CurrentHealth er en float der erviser hvor meget Health en mutant har.
- movespeed er en float der bestemmer topilleterne hasitghed da den indragges i funktionerne for bevægelse.
For health er der en række if-stament der implementerer dem:
- Der er et if-stament der siger at hvis CurrentHealth > MaxHealth så  CurrentHealth = MaxHealth.
- Ligeledes er der også en funktion der siger at hvis current er lig med eller under 0 ødelægges mutanten og startscenen loades.
