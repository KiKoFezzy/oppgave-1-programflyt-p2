Et program som sjekker hvor mange produkter en butikk har av en vare, 
og skriver ut hvor mye rabatt varen skal få basert på beholdningen.

input "gjenstand" - output "antall + eventuell rabatt" (10% rabatt ved 10stk, 25% ved 25stk og 40% alt over)
input "f.eks: 50" output: Sennep: 50stk 40% rabatt
input "f.eks: 12" output: Egg: 12stk 25% rabatt
input "f.eks: 3" output: Melk: 3stk 10% rabatt
utgangspunkt 3 forskjellige varer: Melk, Egg, Sennep
input: 1-9, 10-25 og/eller 26-99
output: Melk: (under 10) 10% rabatt 
        Egg: (under 25) 25% rabatt  
        Sennep: (mellom 26 og 99) 40% rabatt 
under 10stk - 10% rabatt
under 25stk - 25% rabatt
under 99stk - 40# rabatt
har testa input: 2stk, 3stk, 5stk, 15stk, 20stk, 25stk, 26stk, 31stk, 69stk, 72stk og 101stk - 
alle ga riktig output -rotet litt og skjønte ikke helt hvordan jeg skulle legge til å "velge" et produkt for så å legge til antall