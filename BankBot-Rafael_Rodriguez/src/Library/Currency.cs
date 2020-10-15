using System;
using System.Collections.Generic;

namespace Bankbot
{
     public enum Currency
    {
    USS,
    URU,
    ARG,
    }
    
    public class Coin
    {
        public static Coin operator +(Coin a,Coin b) => new Coin(a.currency,a.amount+(Convert(a.currency,b)).amount);
        public static Coin operator -(Coin a,Coin b) => new Coin(a.currency,a.amount-(Convert(a.currency,b)).amount);
        public Currency currency {get;set;}
        public double amount {get;set;}
        public Coin(){}
        public Coin(Currency currency, double amount)
        {
            this.currency = currency;
            this.amount = amount;
        }
        public static Coin Convert(Currency coin, Coin money)      //Ver cual es la mejor forma de implementarlo
        {
            switch (coin)
            {
                case Currency.ARG:
                    switch (coin.currency)
                    {
                        case Currency.ARG:
                            return new Coin(coin.currency,coin.amount);
                        case Currency.URU:
                            return new Coin(Currency.URU,coin.amount *0.2);
                        case Currency.USS:
                            return new Coin(Currency.USS,coin.amount* 0.04);
                    }
                    break;
                case Currency.URU:
                    switch (coin.currency)
                    {
                        case Currency.ARG:
                            return new Coin(Currency.ARG,coin.amount*5);
                        case Currency.URU:
                            return new Coin(coin.currency,coin.amount);
                        case Currency.USS:
                            return new Coin(Currency.USS,coin.amount* 0.025);
                    }
                    break;              
                case Currency.USS:
                    switch (coin.currency)
                        {
                            case Currency.ARG:
                                return new Coin(Currency.ARG,coin.amount*500);
                            case Currency.URU:
                                return new Coin(Currency.URU,coin.amount*40);
                            case Currency.USS:
                                return new Coin(coin.currency,coin.amount);
                        }
                    break;
                default:
                    return new Coin(coin.currency,coin.amount);
            }
            return new Coin(coin.currency,coin.amount);
        }
        public void Convert(Currency currency)      //Ver cual es la mejor forma de implementarlo
        {
            switch (currency)
            {
                case Currency.ARG:
                    switch (this.currency)
                    {
                        case currency.ARG:
                            break;
                        case Currency.URU:
                            this.amount = this.amount*0.2;
                            this.currency = Currency.URU;
                            break;
                        case Currency.USS:
                            this.amount = this.amount *0.04;
                            this.currency = currency.USS;
                            break;
                    }
                    break;
                case Currency.URU:
                    switch (this.currency)
                    {
                        case Currency.ARG:
                            this.amount = this.amount *5;
                            this.currency = Currency.ARG;
                            break;
                        case Currency.URU:
                            break;
                        case Currency.USS:
                            this.amount = this.amount *0.025;
                            this.currency = Currency.USS;
                            break;
                    }
                    break;              
                case Currency.USS:
                    switch (this.currency)
                        {
                            case Currency.ARG:
                                this.amount = this.amount *500;
                                this.currency = Currency.ARG;
                            break;
                            case Currency.URU:
                                this.amount = this.amount *40;
                                this.currency =Currency.URU;
                                break;
                            case Currency.USS:
                                break;
                        }
                    break;
            }
        }
    }
}