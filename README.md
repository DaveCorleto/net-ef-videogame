Esercizio di oggi : net-ef-videogame

nome repo : net-ef-videogame
Vogliamo modificare l’esercizio di ieri rimuovendo le parti gestite con SqlClient e implementandole con Entity Framework.
Devono essere presenti tutte le funzionalità dell’esercizio originale.
Aggiungiamo anche un’altra voce al menu :
- inserisci una nuova software house
Fatto questo, ogni volta che creiamo un nuovo videogioco dobbiamo abbinargli la software house che l’ha prodotto (che dobbiamo aver precedentemente inserito in tabella), chiedendo all’utente l’id della software house e impostandolo nell’entity del videogame.
Realizzare quindi tutte le entity e le migration necessarie per creare il database e implementare tutte le richieste dell’esercizio.
BONUS :
aggiungere un’altra voce di menu
- stampa tutti i videogiochi prodotti da una software house (all’utente verrà chiesto l’id della software house della quale mostrare i videogame)
Avete notato quanto è più veloce e semplice creare le tabelle e interrogarle tramite un ORM? :)
Buon lavoro! :)


Esercizio di ieri:
Ciao ragazzi,
Esercizio di oggi : adonet-db-videogame
nome repo : adonet-db-videogame
>
>
> Vogliamo realizzare un programma che permetta di gestire i videogiochi che verranno utilizzati nei tornei.
>
> Creiamo quindi una console app che all'avvio mostra un menu con la possibilità di :
> 1 inserire un nuovo videogioco
> 2 ricercare un videogioco per id
> 3 ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
> 4 cancellare un videogioco
> 5 chiudere il programma
>
> In base alla voce selezionata richiedere le informazioni necessarie per effettuare l'operazione desiderata.
>
> Prevedere tutti i controlli di validazione dei dati (ad esempio non si può inserire un videogioco senza specificare il nome).
> In caso di errori lanciare un'eccezione (che deve essere gestita a più alto livello).
>
> Creare una classe VideogameManager che esponga tutti i metodi necessari al programma (es. InserisciVideogame(…), GetVideogameById(..), etc…).
>
> Creare una classe Videogame da passare come parametro al metodo di inserimento nuovo videogioco e che venga restituita dai metodi di ricerca.
>
> Buon lavoro! :)
