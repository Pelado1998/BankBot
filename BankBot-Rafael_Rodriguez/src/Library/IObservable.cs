using System;

namespace Bankbot
{
    public interface IObservable //Utilizamos el principio observer y observable para que cada vez que se aproxima a el monto o se logra un 
    // objetivo se mande automaticamente una alerta al usuario dependiendo el canal seleccionado y poniendo uno por defecto
        {
        Money amount {get;set;}
        Money objective{get;set;}
    }
}