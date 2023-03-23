// See https://aka.ms/new-console-template for more information

using System;
using static csharp_abstract_animals.MondoAnimale;

// Instanziamento di classe figle della classe astratta animal
Cane fido = new Cane();
fido.Verso();
fido.Eat();

Delfino doggy = new Delfino();
doggy.Verso();
doggy.Eat();

Uccello pulcinella = new Uccello();
Uccello uccello = new Uccello();
Pesce pesce = new Pesce();

takeVolo(uccello); // questo metodo prende come parametro un instaziamento specifico di tipo uccello che ha come interfaccia necessria IVola e prende il metodo che caratterizza il volare di questo animale. 
takeNuoto(pesce);
static void takeVolo(IVola animal)
{
    animal.Vola();
}
static void takeNuoto(INuota animal)
{
    animal.Nuota();
}

